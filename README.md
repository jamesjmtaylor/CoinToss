
# CoinToss

This is an experiment to run a Unity app on an Android Wear device.  A coin is animated rotating until the user taps on the screen,
 at which point it lands on either heads or tails.  Tapping again starts the rotation again.

## Setup

Setup was accomplished with the following steps:

1. Exporting the Unity build as an Android Studio project (https://support.unity3d.com/hc/en-us/articles/115005695763-Exporting-a-project-to-Gradle-and-building-deploying-on-Android-Studio)
2. Generating a second, new Android Studio project with mobile & wear configurations set in the new project wizard
3. Importing the exported project into the second project (http://www.pallmag.ro/index.php/unity-wear/android-wear-unity)

The third step can be further broken down into the following steps (these should be all that are necessary in future projects if you use this repo's wear module as a template)

1. Copy the libs folder, the src/main/assets folder, src/main/jniLibs folder, and src/main/res folder
2. Add `provided files('libs/unity-classes.jar')` to the dependancies of the wear module's build.gradle
3. Set `compileSdkVersion 27`, `targetSdkVersion 27`, and support libraries to 27.0.0 in the wear module's build.gradle
4. Set `classpath 'com.android.tools.build:gradle:3.1.3'` in the project's build.gradle

## Toolchain

* GIMP (For texture image editing)
* Blender (For object design & UV Mapping with textures)
* Unity (For scene creation, object association, lighting, Visual Studio integration, and Android Studio exporting)
* Visual Studio (For object scripting & logic)
* Android Studio (For compiling to a wearable device)