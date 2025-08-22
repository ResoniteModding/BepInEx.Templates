using BepInEx;
using BepInEx.Logging;
using BepInEx.NET.Common;
using BepInExResoniteShim;

namespace ProjectName;

[ResonitePlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION, PluginInfo.AUTHORS, PluginInfo.REPOSITORY_URL)]
[BepInDependency(BepInExResoniteShim.PluginInfo.GUID, BepInDependency.DependencyFlags.HardDependency)]
public class Plugin : BasePlugin
{
    internal static new ManualLogSource Log;

    public override void Load()
    {
        // Plugin startup logic
        Log = base.Log;
        Log.LogInfo($"Plugin {PluginInfo.GUID} is loaded!");
    }
}
