using System;

using UIKit;

namespace XamariniOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public ViewController()
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			LoginBtn.TouchUpInside += LoginBtn_TouchUpInside;
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		void LoginBtn_TouchUpInside(object sender, EventArgs e)
		{
			var homeViewController = this.Storyboard.InstantiateViewController("HomeViewController") as HomeViewController;
			//var listViewController = new ListViewController();
			this.NavigationController.PushViewController(homeViewController, false);
		}
	}
}
