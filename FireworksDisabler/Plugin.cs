using Harmony;
using IPA;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace FireworksDisabler
{
    public class Plugin : IBeatSaberPlugin
    {
        public static SemVer.Version Version => IPA.Loader.PluginManager.GetPlugin("FireworksDisabler").Metadata.Version;

        internal static HarmonyInstance harmony;

        public static IPALogger Log { get; internal set; }

        public void Init(object thisIsNull, IPALogger log)
        {
            Log = log;
        }

        public void OnApplicationStart()
        {
            harmony = HarmonyInstance.Create("com.nate1280.BeatSaber.FireworksDisabler");
            harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
        }

        public void OnApplicationQuit()
        {
            harmony.UnpatchAll("com.nate1280.BeatSaber.FireworksDisabler");
        }

        public void OnUpdate() { }

        public void OnFixedUpdate() { }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode) { }

        public void OnSceneUnloaded(Scene scene) { }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene) { }
    }
}
