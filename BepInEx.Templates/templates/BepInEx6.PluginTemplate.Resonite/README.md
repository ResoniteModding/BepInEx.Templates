# ProjectName
A [Resonite](https://resonite.com/) mod that [describe what your mod does here].

## Installation (Manual)
1. Install [BepisLoader](https://github.com/ResoniteModding/BepisLoader) for Resonite.
2. Download the latest release ZIP file (e.g., `{firstAuthor}-ProjectName-{version}.zip`) from the [Releases](https://github.com/{firstAuthor}/ProjectName/releases) page.
3. Extract the ZIP and copy the `plugins` folder to your BepInEx folder in your Resonite installation directory:
   - **Default location:** `C:\Program Files (x86)\Steam\steamapps\common\Resonite\BepInEx\`
4. Start the game. If you want to verify that the mod is working you can check your BepInEx logs.

---

## Template Information

This project was created using the BepInEx 6 Resonite Plugin Template. This template provides:

### Features
- **Pre-configured BepInEx 6 setup** - All necessary references and dependencies are already configured
- **Auto-copy on build** - Built DLLs are automatically copied to your BepInEx plugins folder for rapid testing
- **Thunderstore integration** - Includes `thunderstore.toml` and automatic package building
- **Resonite-specific references** - FrooxEngine, Elements.Core, and other Resonite assemblies are pre-referenced
- **Build path detection** - Automatically detects common Resonite installation paths (Steam, environment variable)
- **BepInEx.ResonitePluginInfoProps** - Automatically generates a `PluginMetadata` class from your .csproj properties:
  - `PackageID` → `GUID`
  - `Product` → `NAME` 
  - `Version` → `VERSION`
  - `Authors` → `AUTHORS`
  - `RepositoryUrl` → `REPOSITORY_URL`
  
  These constants are used in your BepInPlugin attribute, keeping all metadata synchronized in one place

### Project Structure
- `Plugin.cs` - Main plugin entry point with BepInEx attributes
- `ProjectName.csproj` - Project configuration with all necessary references
- `thunderstore.toml` - Thunderstore package configuration
- `.config/dotnet-tools.json` - Local tool manifest for Thunderstore CLI

### Configuration
1. **GamePath** - Set via `ResonitePath` environment variable or update in `.csproj` to point to your Resonite installation
2. **Metadata** - Update your plugin metadata (Version, Authors, Product, etc.) in the `.csproj` file

### Building
```bash
dotnet build              # Debug build - compiles and copies to BepInEx/plugins
dotnet build -c Release   # Release build - also creates Thunderstore package
```
This will:
- Compile your plugin
- Copy it to `$(GamePath)/BepInEx/plugins`
- Create a Thunderstore package in the `build` directory (Release mode only)

### Publishing to Thunderstore
1. Replace the placeholder `icon.png` with your own mod icon ([icon requirements](https://wiki.thunderstore.io/mods/creating-a-package#icon))
2. Update `thunderstore.toml` with your namespace and mod details
3. Run `dotnet tcli publish` to upload to Thunderstore

### Resources
- [Resonite Modding Documentation](https://modding.resonite.net/) - Comprehensive guide to Resonite modding
- [Thunderstore Wiki](https://wiki.thunderstore.io/) - Complete guide to package creation and publishing
- [Thunderstore CLI](https://github.com/thunderstore-io/thunderstore-cli) - Tool for building and publishing packages