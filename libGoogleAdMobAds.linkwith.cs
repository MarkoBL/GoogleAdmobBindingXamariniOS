using System;
#if UNIFIED
using ObjCRuntime;
#else
using MonoTouch.ObjCRuntime;
#endif

[assembly: LinkWith ("libGoogleAdMobAds.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, SmartLink = true, ForceLoad = true, Frameworks = "AudioToolbox MessageUI SystemConfiguration CoreGraphics MediaPlayer StoreKit AVFoundation AdSupport CoreTelephony EventKit EventKitUI", LinkerFlags = "-lz -lsqlite3 ")]
