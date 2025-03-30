using System.IO;
using UnityEditor;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace GBMDK.Editor
{
    public class BuildShortcut
    {
        [MenuItem("GBMDK/Build Addressable Content", priority = 10)]
        public static void OnTrigger()
        {
            var outputPath = Path.Combine(Application.dataPath, "Exported");
            Directory.Delete(outputPath, true);
            Directory.CreateDirectory(outputPath);
            AssetDatabase.Refresh();
            AddressableAssetSettings.BuildPlayerContent();
        }

        [MenuItem("GBMDK/Build AssetBundles", priority = 10)]
        public static void OnTriggerAB()
        {
            var outputPath = Path.Combine(Application.dataPath, "Exported", "AssetBundles");
            Directory.Delete(outputPath, true);
            Directory.CreateDirectory(outputPath);
            BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        }
    }
}
