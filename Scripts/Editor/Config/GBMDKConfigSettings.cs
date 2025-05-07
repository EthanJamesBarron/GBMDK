using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    [FilePath("Exported/GBMDKConfig.asset", FilePathAttribute.Location.PreferencesFolder)]
    public class GBMDKConfigSettings : ScriptableSingleton<GBMDKConfigSettings>
    {
        public const string GBMDKFirstRunKey = "GBMDK_FirstRun";
        
        public bool IsFirstRun => EditorPrefs.GetBool(GBMDKFirstRunKey, true);
        
        public GameSettings gameSettings;

        public new void Save(bool saveAsText = false)
        {
            base.Save(saveAsText);
        }
    }
}