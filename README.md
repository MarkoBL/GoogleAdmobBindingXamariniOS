Google Admob Binding for Xamarin iOS
====================================

A iOS Binding Project for Google Admob, with Unified API support.

Current AdMob Version: 
    
    6.12.2.

Currently included architectures: 
    
    armv7 armv7s arm64 i386 x86_64

Homepage: https://markobl.com/admob-xamarin-ios-binding/


How to use
==========

You can find the required DLLs in bin/Release directory.

For the classic API, use this DLL

    GoogleAdMobAds.dll

For the unified API with 64 Bit support, use this DLL

    GoogleAdMobAdsUnified.dll
    

It works exactly as the Xamarin Component: 
https://components.xamarin.com/view/googleadmob


How to compile
==============

If you want to use another version of AdMob, you can simply drop the libGoogleAdMobAds.a in the main directory, open the GoogleAdMobAds.sln with Xamarin Studio and compile it in Release mode.

For new or removed functions, check out the AdMob release notes https://developers.google.com/mobile-ads-sdk/docs/admob/ios/rel-notes and modify ApiDefinition.cs.

The Xcode project for the AdmobExporter library can be found here: https://github.com/MarkoBL/AdMobExporterLibiOS

Credits
=======

This Binding Project is based on the project of Alex Soto: 
https://github.com/mono/monotouch-bindings/tree/master/GoogleAdMobAds

