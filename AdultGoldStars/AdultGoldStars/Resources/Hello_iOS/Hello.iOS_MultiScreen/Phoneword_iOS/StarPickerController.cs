using Foundation;
using System;
using UIKit;

namespace Phoneword_iOS
{
    public partial class StarPickerController : UITableViewController
    {

		static NSString starPickerCellId = new NSString("StarPickerControllerCell");

		public StarPickerController(IntPtr handle) : base (handle)
        {
			TableView.RegisterClassForCellReuse(typeof(UITableViewCell), starPickerCellId);
			TableView.Source = new StarPickerDataSource(this);
		}

		class StarPickerDataSource : UITableViewSource
		{
			StarPickerController controller;

			public StarPickerDataSource(StarPickerController controller)
			{
				this.controller = controller;
			}

			// Returns the number of rows in each section of the table
			public override nint RowsInSection(UITableView tableView, nint section)
			{
                return 2;
			}

			//
			// Returns a table cell for the row indicated by row property of the NSIndexPath
			// This method is called multiple times to populate each row of the table.
			// The method automatically uses cells that have scrolled off the screen or creates new ones as necessary.
			//
			public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
			{
				var cell = tableView.DequeueReusableCell(StarPickerController.starPickerCellId);

				var row = indexPath.Row;
				return cell;
			}
    }
}