using Foundation;
using System;
using UIKit;

namespace AdultGoldStars
{
    public partial class MainMenu : UIViewController
    {
        partial void CreateStar373_TouchUpInside(CreateStar sender)
        {
			TakeTextForStar takeTextForStar = this.Storyboard.InstantiateViewController("TakeTextForStarID") as TakeTextForStar;
            PresentViewController(takeTextForStar, true, null);
        }

        public MainMenu (IntPtr handle) : base (handle)
        {
        }
    }
}

