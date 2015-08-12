// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace InfColorPickerSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton bBackgroundColour { get; set; }

		[Action ("bBackgroundColour_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void bBackgroundColour_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (bBackgroundColour != null) {
				bBackgroundColour.Dispose ();
				bBackgroundColour = null;
			}
		}
	}
}
