using UnityEditor;
using UnityEditor.AddressableAssets;

namespace GBMDK.Editor
{
    public static class TestTemplates
    {
        [MenuItem("GBMDK/Testing/Test GBMDK Templates")]
        public static void Test()
        {
            ContentStarters.CreateMapStuff("Assets/Mods/GBMDKTemplatesMod/Maps");
            ContentStarters.CreateCostumeStuff("Assets/Mods/GBMDKTemplatesMod/Costumes");
            
            ModTester.TestMod();
        }
    }
}

