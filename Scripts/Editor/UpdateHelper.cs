using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Application = UnityEngine.Application;

namespace GBMDK.Editor
{
    [InitializeOnLoad]
    public static class UpdateHelper
    {
        static UpdateHelper()
        {
            Initialize();
        }

        private static void Initialize()
        {
            if (!GBMDKConfigSettings.instance || !GBMDKConfigSettings.instance.IsFirstRun) return;
            
            ExtractProjectSettings();
            ExtractAddressableData();
            EditorPrefs.SetBool(GBMDKConfigSettings.GBMDKFirstRunKey, false);
        }

        [MenuItem("GBMDK/Testing/Set First Run", priority = 10)]
        public static void SetFirstRun()
        {
            EditorPrefs.SetBool(GBMDKConfigSettings.GBMDKFirstRunKey, true);
            Initialize();
        }

        private static void ExtractAddressableData()
        {
            if (!EditorUtility.DisplayDialog("Destructive Action Warning",
                    "First Run has been activated and is about to update your Addressables configuration. This may delete your current Addressables data, and might require you to reassign your assets as Addressable.",
                    "OK", "Cancel")) return;
            
            var projectAddrData = $"{Application.dataPath}/../{AddressableAssetSettingsDefaultObject.kDefaultConfigFolder}";

            if (Directory.Exists(projectAddrData) && AddressableAssetSettingsDefaultObject.SettingsExists)
            {
                AssetDatabase.DeleteAsset("Assets/AddressableAssetsData");
                Object.DestroyImmediate(AddressableAssetSettingsDefaultObject.Settings, true);
            }
            
            AddressableAssetSettingsDefaultObject.Settings = AddressableAssetSettings.Create(AddressableAssetSettingsDefaultObject.kDefaultConfigFolder, AddressableAssetSettingsDefaultObject.kDefaultConfigAssetName, true, true);
            Debug.Assert(AddressableAssetSettingsDefaultObject.SettingsExists, "Something went wrong; Addressables settings do not exist!");

            AddressableAssetSettingsDefaultObject.Settings.BuildRemoteCatalog = true;
            AddressableAssetSettingsDefaultObject.Settings.UniqueBundleIds = true;
            AddressableAssetSettingsDefaultObject.Settings.OverridePlayerVersion = "[UnityEditor.PlayerSettings.bundleVersion]";
            
            var bundledAssetSchemaDefaultGroup = AddressableAssetSettingsDefaultObject.Settings.DefaultGroup.GetSchema<BundledAssetGroupSchema>();
            bundledAssetSchemaDefaultGroup.UseAssetBundleCrc = false;
            bundledAssetSchemaDefaultGroup.InternalIdNamingMode = BundledAssetGroupSchema.AssetNamingMode.FullPath;
            bundledAssetSchemaDefaultGroup.InternalBundleIdMode =
                BundledAssetGroupSchema.BundleInternalIdMode.GroupGuidProjectIdEntriesHash;
            
            foreach (var template in AddressableAssetSettingsDefaultObject.Settings.GroupTemplateObjects)
            {
                if (template is not AddressableAssetGroupTemplate castedTemplate) return;
                var bundledAssetSchema =
                    (BundledAssetGroupSchema)castedTemplate.GetSchemaByType(typeof(BundledAssetGroupSchema));
                if (!bundledAssetSchema) 
                    continue;

                bundledAssetSchema.UseAssetBundleCrc = false;
                bundledAssetSchema.InternalIdNamingMode = BundledAssetGroupSchema.AssetNamingMode.FullPath;
                bundledAssetSchema.InternalBundleIdMode =
                    BundledAssetGroupSchema.BundleInternalIdMode.GroupGuidProjectIdEntriesHash;
            }
            
            if (AddressableAssetSettingsDefaultObject.Settings.profileSettings.GetValueByName(AddressableAssetSettingsDefaultObject.Settings.activeProfileId, "ModName") == null)
                AddressableAssetSettingsDefaultObject.Settings.profileSettings.CreateValue("ModName", "NewMod");
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId,
                "Remote.BuildPath", "[UnityEngine.Application.dataPath]/Exported/[ModName]/aa");
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId,
                "Remote.LoadPath", "{MelonLoader.Utils.MelonEnvironment.ModsDirectory}/[ModName]/aa");
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId,
                "Local.BuildPath", "[UnityEngine.Application.dataPath]/Exported/[ModName]/aa");
            AddressableAssetSettingsDefaultObject.Settings.profileSettings.SetValue(
                AddressableAssetSettingsDefaultObject.Settings.activeProfileId,
                "Local.LoadPath", "{MelonLoader.Utils.MelonEnvironment.ModsDirectory}/[ModName]/aa");
        }

        private static void ExtractProjectSettings()
        {
            var packageProjectSettingsPath = $"{Application.dataPath}/../Packages/com.cementgb.gbmdk/ProjectSettings";
            var projectProjectSettingsPath = $"{Application.dataPath}/../ProjectSettings";
            if (!Directory.Exists(packageProjectSettingsPath) || !Directory.Exists(projectProjectSettingsPath)) 
                return;
            
            CopyFilesRecursively(packageProjectSettingsPath, projectProjectSettingsPath);
        }
        
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (var newPath in Directory.GetFiles(sourcePath, "*.*",SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
    }
    
}
