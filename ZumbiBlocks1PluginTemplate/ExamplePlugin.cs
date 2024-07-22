using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace ExamplePlugin;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
public class ExamplePlugin : BaseUnityPlugin
{
    public const string PluginGUID = PluginAuthor + "." + PluginName;
    public const string PluginAuthor = "AuthorName";
    public const string PluginName = "ExamplePlugin";
    public const string PluginVersion = "0.1.0";

    internal new static ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGUID);
    }
}
