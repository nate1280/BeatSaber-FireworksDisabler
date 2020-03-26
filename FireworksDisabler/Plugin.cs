using HarmonyLib;
using IPA;
using Logger = IPA.Logging.Logger;

namespace FireworksDisabler
{
    [Plugin(RuntimeOptions.SingleStartInit)]
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
            harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        }

        [OnExit]
        public void OnExit()
        {
            harmony.UnpatchAll("com.nate1280.BeatSaber.FireworksDisabler");
        }
    }
}
