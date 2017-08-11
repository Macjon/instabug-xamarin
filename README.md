# Instabug Xamarin SDK

## Installation

This section explains how to install Instabug SDK into your Xamarin application.

To install and integrate the SDK in your project follow the following steps:

1. From Visual Studio project navigator, expand ProjectName.Droid. Right click on the *Components* folder. Click on *Edit Components*.

![1](/<update_readme>/../assets/1.png?raw=true)

2. Click on *Open Component Store* as displayed in the image below.

![2](/<update_readme>/../assets/2.png?raw=true)

3. Search for **Instabug**. You will find Instabug for Android, click on it to download the component.

![3](/<update_readme>/../assets/3.png?raw=true)

4. Last, click on *Add to App* and your component will start downloading automatically.

![4](/<update_readme>/../assets/4.png?raw=true)

5. Repeat all the steps from 1 to 4, but, start by a right click on the ProjectName.iOS.

## Using Instabug

### iOS
To start using Instabug in your application you will need to initialize it. Add the following line in the ```FinishedLaunching``` method inside the ```AppDelegate``` class.

```
Instabug.StartWithToken("IOS_APP_TOKEN", IBGInvocationEvent.Shake);
```

### Android
To start using Instabug in your application you will need to initialize it. Add the following line in the ```OnCreate``` method inside the ```MainApplication``` class.

```
new Instabug.Builder(this, "ANDROID_APP_TOKEN")
  	.SetInvocationEvent(InstabugInvocationEvent.FloatingButton)
  	.Build();
```

## Documentation
For more details about the supported APIs and how to use them, you can check our [**Documentation**](https://docs.instabug.com/docs/xamarin-overview).


## Contact US 
If you have any questions or feedback don't hesitate to get in touch. You can reach us at any time through **support@instabug.com**.

