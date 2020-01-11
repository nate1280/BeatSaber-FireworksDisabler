using Harmony;
using UnityEngine;
using HMUI;
using System;

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

    //[HarmonyPatch(typeof(ResultsViewController), "DidActivate",
    //    new Type[]{
    //        typeof(bool), typeof(ViewController.ActivationType) })]
    //class ResultsViewControllerDidActivate
    //{
    //    static void Postfix(ResultsViewController __instance, ref bool firstActivation, ref ViewController.ActivationType activationType, ref Coroutine ____startFireworksAfterDelayCoroutine)
    //    {
    //        if (____startFireworksAfterDelayCoroutine == null)
    //            ____startFireworksAfterDelayCoroutine = __instance.StartCoroutine(__instance.StartFireworksAfterDelay(1.95f));
    //    }
    //}
}
