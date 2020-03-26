using HarmonyLib;

namespace FireworksDisabler.HarmonyPatches
{
    [HarmonyPatch(typeof(FireworksController))]
    [HarmonyPatch("OnEnable", MethodType.Normal)]
    class FireworksControllerPatches
    {
        static bool Prefix()
        {
            return false;
        }
    }
}
