using System;

using UIKit;

namespace XamariniOS
{
	public partial class ListViewController : UIViewController
	{
		public ListViewController() : base("ListViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			string[] tableItems = new string[] 
			{ 
				"Vegetables", 
				"Fruits", 
				"Flower Buds", 
				"Legumes", 
				"Bulbs", 
				"Tubers" 
			};

			//ListView.Source = new IosTableSource(tableItems, this);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

