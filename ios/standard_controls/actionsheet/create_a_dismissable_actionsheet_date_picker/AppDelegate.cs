using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ActionSheetDatePicker {
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate {
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}

		// class-level declarations
		UIWindow window;
		UIViewController viewController;
		UINavigationController navigationController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			window.BackgroundColor = UIColor.White;

			viewController = new ActionSheetViewController();

			navigationController = new UINavigationController();
			navigationController.PushViewController (viewController, false);

			// If you have defined a view, add it here:
			window.RootViewController = navigationController;
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

