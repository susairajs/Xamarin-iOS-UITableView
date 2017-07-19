using System;
using Foundation;
using UIKit;

namespace XamariniOSTableView
{
	public class TableSource:UITableViewSource
	{
		string[] list;

		public TableSource()
		{
		}

		public TableSource(string[] list)
		{
			this.list = list;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
			string item = list[indexPath.Row];
			cell.TextLabel.Text = item;
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return list.Length;
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			string item = list[indexPath.Row];
			UIAlertView alert = new UIAlertView("Selected Item", item,null, "OK");
			alert.Show();
		}

	

	}
}
