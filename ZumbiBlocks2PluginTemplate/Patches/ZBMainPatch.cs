using HarmonyLib;

namespace ExamplePlugin.Patches;

[HarmonyPatch(typeof(ZBMain))]
public static class ZBMainPatch
{
    [HarmonyPostfix]
    [HarmonyPatch(nameof(ZBMain.Start))]
    public static void ExamplePatch(ZBMain __instance)
    {
        ExamplePlugin.Logger.LogInfo($"Current game version is {__instance.gameVersion}");
    }
}
