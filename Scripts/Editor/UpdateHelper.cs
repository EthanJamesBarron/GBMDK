using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    [InitializeOnLoad]
    public static class UpdateHelper
    {
        static UpdateHelper()
        {
            ExtractProjectSettings();
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
