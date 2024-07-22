using HarmonyLib;
using UnityEngine;

namespace ExamplePlugin;

[HarmonyPatch(typeof(sc_gamecontrol))]
public static class sc_gamecontrolPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(sc_gamecontrol.Start))]
    public static void RetrieveLanguagePack(sc_gamecontrol __instance)
    {
        ExamplePlugin.Logger.LogInfo($"Current game version is {__instance.buildversion}");
    }
}
