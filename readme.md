# Unity User Guide

## About

This is a [Unity](https://unity.com/) User guide

I will start at the beginning and work my way through the variations avenues you could have about your game. I will go through 2D and 3D games along with general tips and tricks for solo and team-based projects. Without future ado, let's begin! 



<a name="top"></a>

## Index

1. [Installation](#install)
2. [General](#main)
3. [Unity Editor Overview](#unity)
4. [3D](#3D)
   * [General](#4a)
   * [3D Models & Bodies](#4b)
   * [Movement](#4c)
   * [Camera](#4d)
   * [Prefabs](#4e)
   * [Particle Systems](#4f)
   * [Events](#4g)
   * [Collectibles](#3coll)
   * [Music & Sounds](#3music)
   * [Odds and Ends](#3odds)
5. [Title Screen](#title)
6. [Scripting](#script)
7. [Building](#build)
8. [Cloning Guide](#guide)
9. [Collaboration](#team)
   * [Unity's Collab](#unity) (recommended)
   * [GitHub](#git)
10. [Resources](#help)



<a name="install"></a>

### 1. Installation

Before installing, note that Unity is completely free forever, if you or your company makes less than $100 000 (USD). 

Follow the link [here](https://store.unity.com/download) and download the free installer (the plus version is definitely not necessary). Follow the instructions and download the installer. The installer is simple and easy however, if you run into trouble, go to this [video](https://www.youtube.com/watch?v=KMuMhA6Lk0I) for Windows. Also note that you will may need a Unity account or just use your Google/ Facebook account to sign in. 

If you want a new version of Unity, go to the Unity Hub and click the **Installs** tab on the left and **add** (top right) the desired version. Afterwards, the installation will take quite a while, even with a fast internet connection. 

When installing Unity, it might ask you to install **Visual Studio** along-side Unity. If you have Visual Studio, do not install again, it should automatically detect the current VS on the system. Otherwise, it is optional and I've heard that MonoDevelop (comes with Unity) is good enough for handling the task Unity puts forth. 



<a name="main"></a>

### 2. General

**Unity** is a 3D game engine built in **C#** but can be used for 2D. Before you freak out about programming, let me assure, you it is quite trivial. If you have programmed before especially in C++, it is a huge plus. If you have not, don't worry, it's just a bunch of copy and pasting. The most important thing is don't be frustrated and 

```c#
Debug.Log() // logs to Unity console
```

is your friend. Also organize your scenes by naming them or using empties as folders (+1 organization). Now, it is time to pick, 2D or 3D. (As a beginner, start with 2D)



<a name="unity"></a>

### 3. Unity Editor Overview

Unity is a panel based application. These panels can be rearranged however you like and saved as default. 

![layout](C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/layout.png)

This is my default setup. The **Scene** panel is the most important viewport. This is where you modify the scene. The **Game** scene only turns on if you hit play. It is a preview of what the user will see if you build the current scene.

On the right hand side, we have the **Project** directory (folder) panel on the bottom. This is where all your assets are (ie art, music, scripts). The **Hierarchy** is like a layers panel in Photoshop. It is an arrangement of all elements in the scene. For every element of the scene can be hidden from the view by hitting eye button when hovering on the element. The lock button is the pointer icon. The **Inspector** contains all modifiable aspect of an element along with info. This is where you drag scripts in the element.

Other panels include a console, which will output when the game is run. The **Animator** and **Animation** go hand in hand and creates animation for sprites. 



<a name="3D"></a>

### 4. 3D

<a name="4a"></a>

#### 	4a General

3D, it's where we live. Good for you for deciding to go 3D. Before we go any further, it is not recommended that you start off with a 3D project if you just started game design. Furthermore, it is recommended that you start with the previous 2D tutorial because some of the concepts and components will be similar or exact. 

To start a 3D project, press **New** and select 3D on the pop-up screen and use the desired directory (or follow my cloning [guide](#guide) so to not start from starch). This may take some time, but after Unity finishes installing itself, we can get started. Now let's make a 3D game!



\* Note this tutorial (3D) follows this [repo](https://github.com/Zeyu-Li/Unity-Template-3D-2019_3):



<a name="4b"></a>

#### 	4b 3D Models & Bodies

If you have experience with 3D software like Cinema 4D, Blender, or the Autodesk suit, this



<a name="4c"></a>

#### 	4c 





<a name="3music"></a>

#### 4 Music & Sounds



<a name="title"></a>

### 5. Title Screen

One of the last things to do is to create a title screen 



<a name="script"></a>

### 6. Scripting

Unity is based on C# and is very much a c-styled programming language. That means it resembles programs that are written in C, C++, F#, or Java. 

The main thing to know though is Unity's implementation of C#

If you create a script, automatically, it will be drawn from a template that looks similar to the following:

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
```

You will notice that at the top there are imports from Unity's other libraries using the **using** keyword. Afterwards, Unity defines the script as a class*. The class is defined as public so other scripts and Unity can assess and utilize this class. The name you gave the script will follow the **class** keyword. Afterwards, **MonoBehaviour** is defined as what movement inherits from. Think of this as your script **extending** from class MonoBehaviour. 



Below that and indented, we see void Start() and void Update(). As the comments suggest, void Start() occurs before the first frame update and void Update() is called once per frame. Note **void** means there will not be a return value (ie no return statement).

Also, there are different methods of MonoBehaviour such as **FixedUpdate()** that may update more or less than once per frame. This will be important for any physics related functions



\* A class is a data structure that holds a collection of information on the class (ie, its attributes and methods). 

A list of other functions and methods that can be used can be found on the [Unity Documentation](https://docs.unity3d.com/ScriptReference/MonoBehaviour.html) site, however, the most important thing about learning and debugging Unity is to use

```c#
Debug.Log() // logs to Unity console
```

When using this, after running the game, it will output to Unity's debug console



<a name="build"></a>

### 7. Build

So you are finished your game. You need to disturbed the game. This is done through building the game. 

1. Go to **File**, **Build Settings...**

2. Select the scenes that you want to build

   ![build](C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/build.png)

3. Select the desired **Platform**

4. You can customize the company name, product name, icon, and cursor

5. **Build** (**And Run** if you want to run it)

6. Select the folder and wait for it to build



\* Note if you did not add an exit game button, the only way to exit is to close the program externally or Alt-f4



<a name="guide"></a>

### 8. Cloning Guide

From my [GitHub](https://github.com/Zeyu-Li?tab=repositories):

1. Find the right Unity Repo to clone from my account (ie [Unity-Template-2D-2019_3](https://github.com/Zeyu-Li/Unity-Template-2D-2019_3), [Unity-Template-3D-2019](https://github.com/Zeyu-Li/Unity-Template-3D-2019_3)) 

2. Download ZIP after clicking Clone or download

   ![download](C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/download.png)

3. Unzip and move to desired directory

4. Go on Unity Hub and click **Add** and located to directory

5. The project should appear in Projects and it is done

6. Click on the project to open it



<a name="team"></a>

### 9. Collaboration

<a name="unity"></a>

#### Unity's Collab

Collaborating will friends can be tough will Unity, especially with git/GitHub, but it you are careful, things could turn out fine.

If you need to collaborate, the best way is to use Unity's Collab feature

![collab](C:/Users/zeyul/Documents/GitHub/unity-user-guide/images/collab.png)

However, note that this only supports 4 people (which is usually enough because only people that will contribute to the codebase should need it)



<a name='git'></a>

#### GitHub

Otherwise if you are a masochistic and decide to GitHub, here are some general practices:

1. Everyone should work on there own branches and work on there own scenes working towards **Prefabs** (ie one person on movement, one on moving platforms, etc.)
2. Optionally, have one person on the master (final) level to peace it together
3. Use [this](https://github.com/github/gitignore/blob/master/Unity.gitignore) gitignore or clone from my projects on GitHub
4. Have the core gameplay done first (especially at a Game Jam)
5. Get to know Git/GitHub and how version control works
6. Remember you can go back to a previous working version
7. Have fun and don't fight with your team members

[🔝 Back to Top](#top)



<a name="Help"></a>

### 10. Resources

* The [Unity User Manual](https://docs.unity3d.com/Manual/index.html) provides some great documentation with code that can for the most part be copied and pasted
* Brackeys [YouTube channel](https://www.youtube.com/user/Brackeys)
* [Lynda.com](https://www.lynda.com/) - If you have a library card, there is a high probability that you have access to Lynda with their organization deal
* Google is your best friend
* Ask on Reddit or Stack Exchange, don't worry they won't bite

