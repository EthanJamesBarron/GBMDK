using System.IO;
using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    public class TestTemplates
    {
        [MenuItem("GBMDK/Testing/Test GBMDK Templates")]
        public static void Test()
        {
            var mapsAssetPath = "Assets/Maps";
            var costumesAssetPath = "Assets/Costumes";
            
            ContentStarters.CreateMapStuff(mapsAssetPath);
            ContentStarters.CreateCostumeStuff(costumesAssetPath);
            
            ModTester.TestMod();
        }
    }
}

