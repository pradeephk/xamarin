using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace XamariniOS
{
	public partial class HomeViewController : UIViewController
	{
		public HomeViewController(IntPtr handle) : base(handle)
		{
            //TableView.RegisterNibForCellReuse(UINib.FromName("Cell", null), "Cell");
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.NavigationItem.Title = "List View";


			var table = new UITableView(new CGRect(0, 20, View.Bounds.Width, View.Bounds.Height - 20)); // defaults to Plain style
			table.AutoresizingMask = UIViewAutoresizing.All;



			string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
			table.Source = new IosTableSource(tableItems, this);

			this.Add(table);
		}
	}
}