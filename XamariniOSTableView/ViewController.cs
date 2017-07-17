using System;

using UIKit;

namespace XamariniOSTableView
{
	public partial class ViewController : UIViewController
	{
		public string[] list = {"Xamarin","Windows","iOS","Android","Visual Studio","Azure","UWP","Xcode",
			"Cognitive Service" };

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyTable.Source = new TableSource(list);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
