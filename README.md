# BepInEx.Templates

A collection of .NET project templates for 6 plugins for developing Resonite mods.

## Installation

You will need [.NET 9 or newer](https://dotnet.microsoft.com/download) to use the templates.

To install, use [dotnet](https://dotnet.microsoft.com/download) tool.

### Install Bleeding Edge templates

These templates are for **BepInEx 6.0.0-be** builds:

```
dotnet new install BepInEx.Templates::2.0.0-be.4 --nuget-source https://nuget.pkg.github.com/ResoniteModding/index.json
```

This will install the following project templates:

| Templates                         | Short Name              | Language | Tags                                        |
|-----------------------------------|-------------------------|----------|---------------------------------------------|
| BepInEx 6 Resonite Plugin         | bep6plugin_resonite     | [C#]     | BepInEx/BepInEx 6/Plugin/Resonite/.NET Core |

## Using a template

To use a template, you can use `dotnet new` command.  
If you use Rider or Visual Studio 2022, you will be able to select the templates when creating a new solution.

For example, to create a BepInEx 5 plugin project:
```
dotnet new bep6plugin_resonite -n MyPluginName
```

This will create a folder name MyPluginName with an example plugin project.

All templates have additional options. To view them, use `--help` switch. For example:

```
dotnet new bep6plugin_resonite --help
```

will show additional options you can specify when creating a project:

```
Options:
  -T|--TargetFramework  The target framework for the project
                        text - Optional
                        Default: net9.0

  -V|--Version          Plugin version
                        text - Optional
                        Default: 1.0.0

  -A|--Authors          Comma-separated list of plugin authors
                        text - Optional
                        Default: Your Name

  -R|--RepositoryUrl    Repository URL for the plugin
                        text - Optional
                        Default: https://github.com/OWNER/BepInEx6.PluginTemplate.Resonite
```

## Documentation, guides and more

For more guides, refer to [Resonite Modding Docs](https://modding.resonite.net).