using System;
using System.Collections.Generic;
using UIKit;
using Foundation;

namespace Phoneword_iOS
{
	public partial class ViewController : UIViewController
	{
		// translatedNumber was moved here from ViewDidLoad ()
	

		public ViewController (IntPtr handle) : base (handle)
		{
			PhoneNumbers = new List<String> ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();



			//
			// Nativation without Segues
			// - if the segue was deleted from the storyboard, this code would enable the button to open the second view controller
			// 
//			CallHistoryButton.TouchUpInside += (object sender, EventArgs e) => {
//				// Launches a new instance of CallHistoryController
//				CallHistoryController callHistory = this.Storyboard.InstantiateViewController ("CallHistoryController") as CallHistoryController;
//				if (callHistory != null) {
//					callHistory.PhoneNumbers = PhoneNumbers;
//					this.NavigationController.PushViewController (callHistory, true);
//				}
//			};
		}

		//
		// Navigation with Segues
		// - there is already a segue defined in the storyboard, we use this method to populate it with phone numbers
		//
		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			// set the View Controller that’s powering the screen we’re
			// transitioning to

			var callHistoryContoller = segue.DestinationViewController as CallHistoryController;

			//set the Table View Controller’s list of phone numbers to the
			// list of dialed phone numbers

			if (callHistoryContoller != null) {
			}
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

