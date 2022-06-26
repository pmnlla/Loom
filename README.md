# Notice
I, the developer of this project, have failed to maintain it past fabric 12.2 amd minecraft 1.18.2. I could make excuses for this, but it mostly boils down to me not wanting to deal with updating the config file every time.

However, I do have an idea on how to make versions update by themselves using the modrinth API. I'll implement it... some day. I'm not exactly sure when. 
But you can cry in the issues to make me think about it more.

# Loom

[![forthebadge](https://forthebadge.com/images/badges/does-not-contain-treenuts.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/made-with-out-pants.svg)](https://forthebadge.com)
[![forthebadge](https://forthebadge.com/images/badges/powered-by-coffee.svg)](https://forthebadge.com)

A simple mods installer for Minecraft. 

Loom installs a series of mods outlined in `vortck`'s guide on Github Gist. 
While the guide is made for 1.16.5, all the mods are actively maintained and supported.

## Requirements
Minecraft 1.18.1, Fabric modloader 1.12.2. Fabric API will be installed through Loom.


## How to use
Launch the executable. You should find a download for it in the releases, and building instructions are below.
You will be prompted with a checklist. Select the mods you would like to install and allow loom to get to work.

Please ensure your mods folder is empty, otherwsie this would result in conflicts between mods and fabric versions.


## How to build
0. Ensure you have the dotnet CLI installed.
1. Clone the repository
2. cd into the folder using a shell such as bash or cmd.
3. `$ dotnet puublish`. The result should be in your /bin folder, with a file that ends with either exe or nothing, and some dependencies.
    **Please note that the executable does not contain it's own dependencies yet, and would need to be shipped with a redistributable.**


## Acknowledgements
- https://github.com/LarsVomMars/Checkboxes | MIT License
- https://gitignore.io
- Newtonsoft JSON library
