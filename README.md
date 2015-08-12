# Xamarin-Binding-Example
This git repository provides a worked example of the Xamarin Binding Objective-C tutorial that is documented here: 
	http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/Walkthrough_Binding_objective-c_library/

I decided to put this out because the tutorial has not been kept up to date and I wanted to share a working solution with the community. There were a couple of challenges with the tutorial:
1. The AppDefinitions.cs instructions are out of date
2. The Makefile does not generate arm64 libraries to it cannot link for later model devices

To build this project you actually only need to build and deploy the InfColorPickerSample project. All the hard work has been done - but that is not why you have downloaded this right? :)

What you should have here are two projects you need to build.

1. The X-Code library
Do not build this in X-Code - just run "make" from the Terminal window in the InfColorPicker folder. Note that the Makefile in the tutorial is no longer complete enough; you need to add the arm64 library.
    That will generate a libInfColorPicker-SDK.a file. This file is used in the InfColorPickerBinding Xamarin project (look in the References package).

2. The second this you need to do is use "sharpie" to build the binding files. The tutorial instructions are out of date here, "unified" is no longer required; Use this command:
    sharpie bind --output=InfColorPicker --namespace=InfColorPicker --sdk=iphoneos8.1 [full-path-to-project]/InfColorPicker/InfColorPicker/*.h
    The version of sharpie I used was: 2.1.6p
    There will be a couple of warhings you need to resolve and they are not the same as the tutorial. The properties are now handled as getters. Have a look at the version in Git for what I changed them to.

3. You should then be ale to build the main project and it will all work.

This example has been tested with Xamarin 5.9.5, and X-Code 6.4.

-Bryon
