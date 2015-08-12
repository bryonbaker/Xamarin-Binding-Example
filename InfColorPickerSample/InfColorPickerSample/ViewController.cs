using System;
using UIKit;
using InfColorPickerBinding;

namespace InfColorPickerSample
{
	public partial class ViewController : UIViewController
	{
		ColorSelectedDelegate selector;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			selector = new ColorSelectedDelegate (this);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void bBackgroundColour_TouchUpInside (UIButton sender)
		{
			InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
			picker.Delegate = selector;
			picker.PresentModallyOverViewController (this);
		}
	}
}

