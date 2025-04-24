using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    [InitializeOnLoad]
    public static class UpdateHelper
    {
        public const string GBMDKFirstRunKey = "GBMDK_FirstRun";
        
        public static bool IsFirstRun => EditorPrefs.GetBool(GBMDKFirstRunKey, true);
        
        static UpdateHelper()
        {
            Initialize();
        }

        private static void Initialize()
        {
            if (!IsFirstRun) return;
            
            ExtractAddressableData();      
            ExtractProjectSettings();
            EditorPrefs.SetBool(GBMDKFirstRunKey, false);
        }

        [MenuItem("GBMDK/Testing/Set First Run", priority = 10)]
        private static void SetFirstRun()
        {
            EditorPrefs.SetBool(GBMDKFirstRunKey, true);
            Initialize();
        }

        [MenuItem("GBMDK/Refresh Project Assets")]
        private static void RefreshProjectAssets()
        {
            AssetDatabase.Refresh();
        }

        private static void ExtractAddressableData()
        {
            var packageAddrPath = $"{Application.dataPath}/../Packages/com.cementgb.gbmdk/AddressableAssetsData";
            var projectAddrPath = $"{Application.dataPath}/AddressableAssetsData";
            if (!Directory.Exists(packageAddrPath) || Directory.Exists(projectAddrPath)) return;
            
            CopyFilesRecursively(packageAddrPath, projectAddrPath);
            Directory.Delete(packageAddrPath, true);
        }

        private static void ExtractProjectSettings()
        {
            var packageProjectSettingsPath = $"{Application.dataPath}/../Packages/com.cementgb.gbmdk/ProjectSettings";
            var projectProjectSettingsPath = $"{Application.dataPath}/../ProjectSettings";
            if (!Directory.Exists(packageProjectSettingsPath) || !Directory.Exists(projectProjectSettingsPath)) return;
            
            Directory.Delete(projectProjectSettingsPath, true);
            CopyFilesRecursively(packageProjectSettingsPath, projectProjectSettingsPath);
        }
        
        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*",SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }
    }
    
}
