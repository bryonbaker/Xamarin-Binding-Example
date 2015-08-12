using System;
using ObjCRuntime;

[assembly: LinkWith ("libInfColorPicker-i386.a", LinkTarget.Simulator | LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]
