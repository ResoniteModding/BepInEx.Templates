using BepInEx;
using BepInEx.Logging;
using BepInEx.NET.Common;
using BepisResoniteWrapper;

namespace ProjectName;

[BepInAutoPlugin]
[BepInDependency(BepInExResoniteShim.PluginMetadata.GUID, BepInDependency.DependencyFlags.HardDependency)]
public partial class Plugin : BasePlugin
{
    internal static new ManualLogSource Log = null!;

    public override void Load()
    {
        Log = base.Log;
        ResoniteHooks.OnEngineReady += OnEngineReady;
        Log.LogInfo($"Plugin {GUID} is loaded!");
    }

    private void OnEngineReady()
    {
//#if (!no-tutorial)
        // The Resonite engine is now fully initialized
        // Safe to access FrooxEngine classes and functionality
//#endif
        Log.LogInfo("Engine is ready!");
    }
}
