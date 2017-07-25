using Foundation;
using System;
using UIKit;

namespace AdultGoldStars
{

	public partial class StarPicker : UITableViewController
	{

		static NSString starPickerCellId = new NSString("CallHistoryCell");

		public StarPicker(IntPtr handle) : base(handle)
		{
			TableView.RegisterClassForCellReuse(typeof(UITableViewCell), starPickerCellId);
			TableView.Source = new StarPickerDataSource(this);
		}

		class StarPickerDataSource : UITableViewSource
		{
			StarPicker controller;

			public StarPickerDataSource(StarPicker controller)
			{
				this.controller = controller;
			}

			public override nint RowsInSection(UITableView tableView, nint section)
			{
				return 2;
			}

			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell(StarPicker.starPickerCellId);

				int row = indexPath.Row;
				return cell;
			}
		}
	}

}