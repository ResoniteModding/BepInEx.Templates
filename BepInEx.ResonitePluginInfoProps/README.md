## BepInEx ResonitePluginInfo generator

Generates `PluginInfo.cs` based on csproj tags.

## Basic usage

Define the following properties in your `csproj`:

```xml
<PackageId>Example.Plugin</AssemblyName>
<Product>My first plugin</Product>
<Version>1.0.0</Version>
<Authors>ResoniteModding</Authors>
<RepositoryUrl>https://github.com/ResoniteModding/BepInEx.Templates</RepositoryUrl>
```

this will generate the following class:

```cs
using System;

public static class PluginMetadata
{
    public const string GUID = "Example.Plugin";
    public const string NAME = "My first plugin";
    public const string VERSION = "1.0.0";
    public const string AUTHORS = "ResoniteModding";
    public const string REPOSITORY_URL = "https://github.com/ResoniteModding/BepInEx.Templates";
}
```
