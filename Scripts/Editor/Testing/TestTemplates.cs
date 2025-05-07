using UnityEditor;

namespace GBMDK.Editor
{
    public class TestTemplates
    {
        [MenuItem("GBMDK/Testing/Test GBMDK Templates")]
        public static void Test()
        {
            ContentStarters.CreateMapStuff("Maps/NewMap");
            ContentStarters.CreateCostumeStuff("Costumes/NewCostume");
            
            ModTester.TestMod();
        }
    }
}

