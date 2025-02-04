# Zumbi Blocks Plugin Templates

Modding templates for [Zumbi Blocks 1](https://zumbiblocks.yolasite.com/) and [Zumbi Blocks 2](https://store.steampowered.com/app/1941780/Zumbi_Blocks_2_Open_Alpha/), powered by [BepInEx](https://github.com/BepInEx/BepInEx).

## Features

These templates are designed to work out-of-the-box: that means you can click `Build` and the project will just work.  
Some configuration will be needed for Zumbi Blocks 1.

- Batteries-included: already configured for modding
- Customizable with feature toggles
- Validates game and mod loader installation
- Automatically installs your plugins
- Copies assets to your mod folder
- Embeds resources if needed

## Requirements

- [Zumbi Blocks 1](https://zumbiblocks.yolasite.com/) or [Zumbi Blocks 2](https://store.steampowered.com/app/1941780/Zumbi_Blocks_2_Open_Alpha/)
- [BepInEx 5](https://github.com/BepInEx/BepInEx/releases)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or [newer](https://dotnet.microsoft.com/en-us/download)
- [.NET Framework 3.5 Development Tools](https://visualstudio.microsoft.com/downloads/#build-tools-for-visual-studio-2022) if modding Zumbi Blocks 1
- .NET IDE of choice

> [!NOTE]
> **Using [Visual Studio Community 2022](https://visualstudio.microsoft.com/vs/community/)?**
> 
> The **.NET Desktop Development** workload automatically includes `.NET 9.0 SDK` and `.NET 8.0 SDK`.

## Getting Started

This guide will help you get started with modding Zumbi Blocks in just a few minutes.

### Installing BepInEx

Installing BepInEx is incredibly easy and won't take much time.

> [!TIP]
> For a more comprehensive guide on [installing BepInEx](https://docs.bepinex.dev/articles/user_guide/installation/index.html), as well as several articles on [using it](https://docs.bepinex.dev/articles/user_guide/configuration.html), please refer to the [official BepInEx documentation site](https://docs.bepinex.dev/).

#### Zumbi Blocks 1

First, open the folder where you extracted Zumbi Blocks 1. This will be named `ZumbiBlocks` for the 32-bit version, and `ZumbiBlocks-64bit` for the 64-bit version.

Next, extract the BepInEx ZIP file. This will result in four files and one folder: `.doorstop_version`, `changelog.txt`, `doorstop_config.ini`, `winhttp.dll`, and a `BepInEx` folder.

Drag everything into the game folder. The `BepInEx` folder should now be next to the `ZumbiBlocks.exe` file and the `ZumbiBlocks_Data` folder.

Run the game and wait a couple seconds. BepInEx has crashed.  
This is because Zumbi Blocks 1 is on an old version of Unity, and requires a bit of configuration.

Open the `BepInEx` folder, and you'll see a `config` folder inside. This is where BepInEx and all mods store their config files.  
Open the `BepInEx.cfg` file in Notepad and scroll all the way to the bottom. Replace the word `Application` with `MonoBehaviour`.  
Save the file, then run the game again.  
**You're done!** BepInEx is now installed. You may now close the game.

#### Zumbi Blocks 2

In your Steam client, right-click **Zumbi Blocks 2**, hover over `Manage`, then click on `Browse local files`.  
This will open the game folder in Windows Explorer. If it didn't appear on screen, click on the Explorer icon in the taskbar or tab over to it.

Next, extract the BepInEx ZIP file. This will result in four files and one folder: `.doorstop_version`, `changelog.txt`, `doorstop_config.ini`, `winhttp.dll`, and a `BepInEx` folder.

Drag everything into the `Zumbi Blocks 2 Open Alpha` folder. The `BepInEx` folder should now be next to the `MonoBleedingEdge` and `ZumbiBlocks2_Data` folders.

Run the game--either from Steam or the `ZumbiBlocks2.exe` file--and wait for the game to load.  
**You're done!** BepInEx is now installed. You may now close the game.

### Installing the template

Much like BepInEx, installing the template is very simple.

First, [clone the repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository) or [download the source code from Releases](https://github.com/nyawoi/ZumbiBlocksPluginTemplates/releases). If downloaded, extract the ZIP file.  
Be sure to move the folder somewhere safe where you know it won't be deleted or overwritten.

Next, open the folder. Inside, you'll see two scripts: `install.bat` and `uninstall.bat`. Run `install.bat` to add the template to your list of .NET templates, and `uninstall.bat` to remove it.

That's it! The template is now installed and ready to create projects.

### Creating a project

Launch your .NET IDE of choice and open the list of available templates.  
If using Visual Studio Community 2022, this is done by clicking on "Create a new project" on the right.  
If using Rider, this is done by clicking on "New Solution" near the top middle.

If the template isn't immediately visible, use the search bar to filter the results.  
Visual Studio Community 2022 should automatically display the templates at the top of the list after you install them, and will then list them on the left, under "Recent project templates".  
Rider will have the templates listed in the "Custom Template" section, beneath the default templates.

Select the template for the game you'd like to mod, and start customizing it. Give it a name and list yourself as the author.

Create the project and you're done!  
The template takes care of all references for you, so you can focus on what really matters, rather than mess with project configuration.

### Customizing your project

The template comes with some optional features you might find useful. They can be toggled on and off easily, and are separate from the main project, so you can share your code without worrying about it conflicting with someone else's settings.

Open the `*.csproj.user` file and customize the settings.  
If modding Zumbi Blocks 1, this is where you set its install location.  
If modding Zumbi Blocks 2 and your Steam library is not on the C: drive, this is where you can enter its custom installation location.

When done customizing your plugin base, click on `Build` in your IDE.  
If the task is enabled, your plugin will automatically be installed. Open the game and test it out!

When ready to publish, don't forget to [add a license](https://choosealicense.com/)! This is very important in the open source community.  
Additionally, a `.gitignore` file has been included for you to use. Simply move it to the root directory of your project.

### Assets and Resources

If your plugin has assets, create a folder named `Assets` and it'll automatically be copied over to your mod folder when building your project.

Likewise, if you have embedded resources, create a folder named `Resources` and those will automatically be embedded when building.

---

## Community

If you ever get stuck or need assistance getting started, feel free to join the official [Zumbi Blocks 2 Discord Server](https://discord.gg/eCWaHR9).  
There's a modding channel where you can share and discuss everything related to mods.
