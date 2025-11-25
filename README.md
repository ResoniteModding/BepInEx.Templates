# BepInEx.Templates

A collection of .NET project templates for 6 plugins for developing Resonite mods.

## Installation

You will need [.NET 10 or newer](https://dotnet.microsoft.com/download) to use the templates.

To install, use [dotnet](https://dotnet.microsoft.com/download) tool.

### Install Bleeding Edge templates

These templates are for **BepInEx 6.0.0-be** builds:

```
dotnet new install BepInEx.Templates::2.0.0-be.* --nuget-source https://nuget-modding.resonite.net/v3/index.json
```

This will install the following project templates:

| Templates                                              | Short Name    | Language | Tags                                                     |
|--------------------------------------------------------|---------------|----------|----------------------------------------------------------|
| BepInEx 6 Resonite Plugin (.NET 10, Thunderstore Ready) | bep6resonite  | [C#]     | BepInEx/BepInEx 6/Plugin/CoreCLR/.NET 10/Resonite/Thunderstore |

## Using a template

To use a template, you can use `dotnet new` command.  
If you use Rider or Visual Studio 2022, you will be able to select the templates when creating a new solution.

For example, to create a BepInEx 6 plugin project:
```
dotnet new bep6resonite -n MyPluginName
```

This will create a folder name MyPluginName with an example plugin project.

All templates have additional options. To view them, use `--help` switch. For example:

```
dotnet new bep6resonite --help
```

will show additional options you can specify when creating a project:

```
Options:
  -ve|--version          Plugin version (e.g., '1.0.0')
                        text - Optional
                        Default: 1.0.0

  -au|--authors          Comma-separated list of plugin authors
                        text - Optional
                        Default: YourName

  -r|--repositoryUrl    Repository URL for the plugin (leave empty for auto-generated: https://github.com/[Author]/[ProjectName])
                        text - Optional
                        Default: 

  -p|--packageId        Package ID for the plugin (leave empty for auto-generated: [FirstAuthor].[ProjectName])
                        text - Optional
                        Default: 

  -g|--gitInit          Initialize a git repository
                        bool - Optional
                        Default: true
```

## Documentation, guides and more

For more guides, refer to [Resonite Modding Docs](https://modding.resonite.net).
