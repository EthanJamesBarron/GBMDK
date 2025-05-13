using UnityEditor;

namespace GBMDK.Editor
{
    public static class TestTemplates
    {
        [MenuItem("GBMDK/Testing/Test GBMDK Templates")]
        public static void Test()
        {
            ContentStarters.CreateMapStuff();
            ContentStarters.CreateCostumeStuff();
            
            ModTester.TestMod();
        }
    }
}

