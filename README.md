# <img src="icon_small.png" width="71" height="71"/> Bluetooth LE plugin for Xamarin & MAUI

Build status: [![Build status](https://github.com/dotnet-bluetooth-le/dotnet-bluetooth-le/actions/workflows/dotnet.yml/badge.svg)](https://github.com/dotnet-bluetooth-le/dotnet-bluetooth-le/actions/workflows/dotnet.yml?branch=master)

[Xamarin](https://github.com/xamarin), [MAUI](https://github.com/dotnet/maui) and [MvvMCross](https://github.com/MvvmCross) plugin for accessing the bluetooth functionality. The plugin is loosely based on the BLE implementation of [Monkey Robotics](https://github.com/xamarin/Monkey.Robotics).

**Important Note:** With the term *"vanilla"* we mean the non-MvvmCross version, i.e. the pure Xamarin or MAUI plugin. You **can** use it without MvvmCross, if you download the vanilla package.


## Support & Limitations

[Release Notes](doc/changelog.md)

Supported .NET and OS versions (targeted and minimum) per release:

| Plugin.BLE      |   3.0 |   3.0 |   3.1 |   3.1 |   3.2 |   3.2 |   3.3 |   3.3 |
|:----------------|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|:-----:|
| .NET            |   6.0 |   7.0 |   7.0 |   8.0 |   8.0 |   9.0 |   9.0 |  10.0 |
| Android: target |    33 |    33 |    33 |    34 |    34 |    35 |    35 |    36 |
| Android: min    |    21 |    21 |    21 |    21 |    21 |    21 |    21 |    21 |
| iOS: target     |  16.1 |  16.1 |  16.1 |  17.2 |  18.0 |  18.0 |  18.0 |  26.0 |
| iOS: min        |  10.0 |  10.0 |  10.0 |  10.0 |  12.2 |  12.2 |  12.2 |  12.2 |
| Mac: target     |  16.1 |  16.1 |  16.1 |  17.2 |  18.0 |  18.0 |  18.0 |  26.0 |
| Mac: min        |  13.1 |  13.1 |  13.1 |  13.1 |  15.0 |  15.0 |  15.0 |  15.0 |
| Windows: target | 19041 | 19041 | 19041 | 19041 | 19041 | 19041 | 19041 | 19041 |
| Windows: min    | 17763 | 17763 | 17763 | 17763 | 17763 | 17763 | 17763 | 17763 |


## Nuget Packages

| package              | stable    | beta      | downloads |
| ---------------------|:---------:|:---------:|:---------:|
| Plugin.BLE           | [![NuGet](https://img.shields.io/nuget/v/Plugin.BLE.svg?style=flat)](https://www.nuget.org/packages/Plugin.BLE) | [![NuGet Beta](https://img.shields.io/nuget/vpre/Plugin.BLE.svg?style=flat)](https://www.nuget.org/packages/Plugin.BLE) | [![Downloads](https://img.shields.io/nuget/dt/Plugin.BLE.svg)](https://www.nuget.org/packages/Plugin.BLE)
| MvvmCross.Plugin.BLE | [![NuGet MvvMCross](https://img.shields.io/nuget/v/MvvmCross.Plugin.BLE.svg?style=flat)](https://www.nuget.org/packages/MvvmCross.Plugin.BLE) | [![NuGet MvvMCross Beta](https://img.shields.io/nuget/vpre/MvvmCross.Plugin.BLE.svg?style=flat)](https://www.nuget.org/packages/MvvmCross.Plugin.BLE) | [![Downloads](https://img.shields.io/nuget/dt/MvvmCross.Plugin.BLE.svg)](https://www.nuget.org/packages/MvvmCross.Plugin.BLE)


## Usage

- [Usage](doc/usage.md)
  - [Installation](doc/usage.md#installation)
  - [Permissions](doc/usage.md#permissions)
  - [API Usage](doc/usage.md#api-usage)
  - [Important remarks / API limitations](doc/usage.md#important-remarks--api-limitations)
  - [Best practice](doc/usage.md#best-practice)
  - [Extended topics](doc/usage.md#extended-topics)

## Sample app

We provide a sample Xamarin.Forms app, that is a basic bluetooth LE scanner. With this app, it's possible to

- check the BLE status
- discover devices
- connect/disconnect
- discover the services
- discover the characteristics
- see characteristic details
- read/write and register for notifications of a characteristic

Have a look at the code and use it as starting point to learn about the plugin and play around with it.


## How to build the nuget package

1) Build

    Open a console, change to the folder "dotnet-bluetooth-le/.build" and run `cake`.

2) pack the nuget

    `nuget pack ../Source/Plugin.BLE/Plugin.BLE.csproj`

    `nuget pack ../Source/MvvmCross.Plugins.BLE/MvvmCross.Plugins.BLE.csproj`


## Useful Links

- [Bluetooth Core Specification v5.4 (2024)](https://www.bluetooth.com/specifications/specs/core-specification-amended-5-4/)
- [Bluetooth Core Specification v6.2 (2025)](https://www.bluetooth.com/specifications/specs/core-specification-6-2/)
- [Bluetooth Assigned Numbers](https://www.bluetooth.com/specifications/assigned-numbers/)
- [Android Bluetooth LE guideline](https://developer.android.com/develop/connectivity/bluetooth/ble/ble-overview)
- [iOS CoreBluetooth Best Practices](https://developer.apple.com/library/archive/documentation/NetworkingInternetWeb/Conceptual/CoreBluetooth_concepts/BestPracticesForInteractingWithARemotePeripheralDevice/BestPracticesForInteractingWithARemotePeripheralDevice.html)
- [iOS CoreBluetooth Background Modes](https://developer.apple.com/library/archive/documentation/NetworkingInternetWeb/Conceptual/CoreBluetooth_concepts/CoreBluetoothBackgroundProcessingForIOSApps/PerformingTasksWhileYourAppIsInTheBackground.html#//apple_ref/doc/uid/TP40013257-CH7-SW7)
- [Monkey Robotics](https://github.com/xamarin/Monkey.BluetoothLE)


## How to contribute

We usually do our development work on a branch with the name of the milestone. So please base your pull requests on the currently open development branch.


## Licence

[Apache 2.0](https://github.com/dotnet-bluetooth-le/dotnet-bluetooth-le/blob/master/LICENSE)
