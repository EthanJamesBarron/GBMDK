using Costumes;
using GB.Data.Loading;
using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GBMDK.Editor
{
    public class ContentStarters
    {
        private static void MarkAddressable(string assetPath, string assetAddress)
        {
            var settings = AddressableAssetSettingsDefaultObject.Settings;
            var entry = settings.CreateOrMoveEntry(AssetDatabase.AssetPathToGUID(assetPath), settings.DefaultGroup);
            entry.SetAddress(assetAddress);

            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
        }

        private static string GetCurrentSelectedAssetPath()
        {
            var path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
                path = "Assets";
            else if (Path.GetExtension(path) != "")
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");

            return path;
        }
        
        [MenuItem("Assets/GBMDK/Starters/Costume Starter", priority = 10000)] 
        public static void CostumeStarter()
        {
            CreateCostumeStuff();
        }
            
        public static void CreateCostumeStuff(string fallbackPath=null)
        {
            if (!AddressableAssetSettingsDefaultObject.SettingsExists)
            {
                Debug.LogError("Addressables not initialized!");
                return;
            }

            var path = string.IsNullOrWhiteSpace(fallbackPath) ? GetCurrentSelectedAssetPath() : fallbackPath;

            var prefabTemplate = PrefabUtility.LoadPrefabContents($"Packages/com.cementgb.gbmdk/Prefabs/Templates/CustomContent/HatTemplate.prefab");
            var assetPath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, $"NewCostume.prefab"));
            var prefab = PrefabUtility.SaveAsPrefabAssetAndConnect(prefabTemplate, assetPath, InteractionMode.AutomatedAction);
            prefab.name = "NewCostume";
            Object.DestroyImmediate(prefabTemplate);
            EditorUtility.SetDirty(prefab);

            MarkAddressable(assetPath, Path.GetFileNameWithoutExtension(assetPath));

            var costumeData = ScriptableObject.CreateInstance<CostumeObject>();
            costumeData.name = $"{prefab.name}-Data";
            costumeData.PrimaryPart = CostumeParts.Head;
            costumeData.Unlocked = true;
            costumeData.Enabled = true;
            costumeData.CostumeItems = new AssetReferenceGameObject[]
            {
                new(AssetDatabase.GUIDFromAssetPath(assetPath).ToString())
            };
            var dataPath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, $"{costumeData.name}.asset"));
            AssetDatabase.CreateAsset(costumeData, dataPath);
            EditorUtility.SetDirty(costumeData);

            MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));

            AssetDatabase.SaveAssets();
            EditorUtility.FocusProjectWindow();
            Selection.activeObject = costumeData;
        }

        [MenuItem("Assets/GBMDK/Starters/Map Starter", priority = 10000)]
		public static void MapStarter()
		{
			CreateMapStuff();
		}		

        public static void CreateMapStuff(string fallbackPath=null)
        {
            if (!AddressableAssetSettingsDefaultObject.SettingsExists)
            {
                Debug.LogError("Addressables not initialized!");
                return;
            }
            
            var path = string.IsNullOrWhiteSpace(fallbackPath) ? GetCurrentSelectedAssetPath() : fallbackPath;

            var sceneTemplate = AssetDatabase.LoadAssetAtPath<SceneTemplateAsset>("Packages/com.cementgb.gbmdk/Scenes/MapTemplate_Template.scenetemplate");
            var scenePath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "NewMap.unity"));
            var newScene = SceneTemplateService.Instantiate(sceneTemplate, false, scenePath);
            Lightmapping.Bake();
            EditorSceneManager.SaveScene(newScene.scene);

            MarkAddressable(scenePath, Path.GetFileNameWithoutExtension(scenePath));

            var sceneData = ScriptableObject.CreateInstance<SceneData>();
            sceneData.name = "NewMap-Data";
            var dataPath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "NewMap-Data.asset"));
            sceneData._sceneRef = new AssetReference(AssetDatabase.GUIDFromAssetPath(scenePath).ToString());
            AssetDatabase.CreateAsset(sceneData, dataPath);
            EditorUtility.SetDirty(sceneData);

            MarkAddressable(dataPath, Path.GetFileNameWithoutExtension(dataPath));

            var sceneInfo = ScriptableObject.CreateInstance<CustomMapInfo>();
            sceneInfo.name = "NewMap-Info";
            var infoPath = AssetDatabase.GenerateUniqueAssetPath(Path.Combine(path, "NewMap-Info.asset"));
            sceneInfo.allowedGamemodes = GB.Gamemodes.GameModeEnum.Melee | GB.Gamemodes.GameModeEnum.Waves;
            AssetDatabase.CreateAsset(sceneInfo, infoPath);
            EditorUtility.SetDirty(sceneInfo);

            EditorUtility.FocusProjectWindow();

            MarkAddressable(infoPath, Path.GetFileNameWithoutExtension(infoPath));

            AssetDatabase.SaveAssets();
            Selection.activeObject = sceneData;
        }
    }
}