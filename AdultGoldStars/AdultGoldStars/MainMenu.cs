using Foundation;
using System;
using UIKit;

namespace AdultGoldStars
{
    public partial class MainMenu : UIViewController
    {
        partial void CreateStarName_TouchUpInside(CreateStar sender)
        {
			TakeTextForStar takeTextForStar = this.Storyboard.InstantiateViewController("TakeTextForStarID") as TakeTextForStar;
			PresentViewController(takeTextForStar, true, null);
        }

        partial void SendStarButton_TouchUpInside(UIButton sender)
        {
            SendStar sendStar = this.Storyboard.InstantiateViewController("SendStarID") as SendStar;
            PresentViewController(sendStar, true, null);
        }

        public MainMenu (IntPtr handle) : base (handle)
        {
        }
    }
}

