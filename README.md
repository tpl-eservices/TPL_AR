## Introduction:
**tpl:ar** is an augmented reality app in which users can interact and explore library materials in virtual space. It was originally created to be used with the 2019 edition of "The List" to provide additional opportunities for interaction (such as playable video clips when the user hovers their phone over the pamphlet).

## Installation:
I strongly recommend installing the [Unity Hub](https://docs.unity3d.com/Manual/GettingStartedInstallingHub.html) which is used to make it much easier to keep track of the various Unity versions available. As of this writing, the app works with Unity **2018.4.9f1**.

Once you clone this repo, you will be able to open this folder directly into Unity.

## Development:
The app was built in Unity and uses a plugin called Vuforia which allows for images to be recognized as targets which then trigger events, such as playing video clips, animating 3D models etc.

For TPL's the List, you can find the project under the folder Assets --> Scenes --> SampleScene

The following are some tutorials you can follow to aid in your development:

https://www.youtube.com/watch?v=MtiUx_szKbI    
https://www.youtube.com/watch?v=SoQuUW-oL3k

## Creating build:
Once the app has been developed, you will want to deploy the app to its respective app store. Before doing so, you will need to create a build for each both Android and iOS (the process is separate for each).

For Android, you can create the build directly in Unity. While in iOS, there is an additional step to open the build in XCode before it is sent to the iOS store for processing.

In both cases, go to File --> Build Settings --> Select Platform (iOS or Android) --> Build (or Build and Run if you have a device plugged into your computer). For Android, this will create an aab file that can be directly uploaded to the Google Play Store and for iOS, it will create an XCode Project that can be used to upload the app to the iOS Store.

## Deployment to app stores:
**Google Play Store**:

Google Play apps are deployed via the [Google Play Console](https://play.google.com/apps/publish/) (use the tpldigitalservices@gmail.com login details).

As opposed to iOS (as you'll see below), the process is pretty straightforward:

Go to Release Management --> App Releases --> Production Track (Click Manage) --> Create Release --> Upload the Android App Bundle (aab file) and continue the steps from there.

**iOS Store**:

iOS apps are deployed via [App Store Connect](https://appstoreconnect.apple.com/login) but are uploaded via Xcode as opposed to through the browser website like the Google Play Store. Once the app has been uploaded, it will take several minutes to fully process before you can proceed (you will get an email once it's ready). 

Once you login (ask Margot to add your email to the TPL group), you'll see a section in App Store called "VERSION OR PLATFORM", click this and select iOS. From here, you can select the build that you are uploading and at all the release details associated with it.

## Relevant links:
TPL information page: https://www.torontopubliclibrary.ca/ar/

Google Play Store app page: https://play.google.com/store/apps/details?id=com.TPL.TPL_AR&hl=en_CA

iOS Store app page: https://itunes.apple.com/us/app/tpl-ar/id1460052198?ls=1&mt=8

