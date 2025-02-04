using HarmonyLib;

namespace ExamplePlugin.Patches;

[HarmonyPatch(typeof(sc_gamecontrol))]
public static class sc_gamecontrolPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(sc_gamecontrol.Start))]
    public static void ExamplePatch(sc_gamecontrol __instance)
    {
        ExamplePlugin.Logger.LogInfo($"Current game version is {__instance.buildversion}");
    }
}
