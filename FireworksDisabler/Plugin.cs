using HarmonyLib;
using IPA;
using Logger = IPA.Logging.Logger;

namespace FireworksDisabler
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        public static SemVer.Version Version => IPA.Loader.PluginManager.GetPlugin("FireworksDisabler").Version;

        internal static Harmony harmony;

        public static Logger Log { get; internal set; }

        [Init]
        public void Init(Logger log)
        {
            Log = log;
        }

        [OnStart]
        public void OnStart()
        {
            harmony = new Harmony("com.nate1280.BeatSaber.FireworksDisabler");
        }

        [OnEnable]
        public void OnEnable()
        {
            harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        }

        [OnDisable]
        public void OnDisable()
        {
            harmony.UnpatchAll("com.nate1280.BeatSaber.FireworksDisabler");
        }
    }
}
