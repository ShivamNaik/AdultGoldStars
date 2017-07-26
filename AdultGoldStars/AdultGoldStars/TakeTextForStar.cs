using Foundation;
using System;
using UIKit;

namespace AdultGoldStars
{
    public partial class TakeTextForStar : UIViewController
    {
        public TakeTextForStar (IntPtr handle) : base (handle)
        {

        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			//Save.TouchUpInside += (object sender, EventArgs e) =>
			//{
				
				// Dismiss the keyboard if text field was tapped
				//TakeTextForStarName.ResignFirstResponder();

				
			//};
		}
    }
}