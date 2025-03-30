using UnityEditor;
using UnityEngine;

namespace GBMDK.Editor
{
    [FilePath("Exported/GBMDKConfig.asset", FilePathAttribute.Location.PreferencesFolder)]
    public class GBMDKConfigSettings : ScriptableSingleton<GBMDKConfigSettings>
    {
        public GameSettings gameSettings;

        public new void Save(bool saveAsText = false)
        {
            base.Save(saveAsText);
        }
    }
}