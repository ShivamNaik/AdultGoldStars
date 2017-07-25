using System;

using UIKit;
using Xamarin.Auth;
using System.Json;
using System.Collections.Generic;


namespace AdultGoldStars
{
    public partial class ViewController : UIViewController
    {
        
        partial void FacebookLogin_TouchUpInside(UIButton sender)
        {
            // TO DO : add facebook login picture to login


            OAuth2Authenticator auth = new OAuth2Authenticator
            (
                clientId: "455704051475923",
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));
    
            var ui = auth.GetUI();
			auth.Completed += FacebookAuth_Completed;

			PresentViewController(ui, true, null);

     
        }

		private async void FacebookAuth_Completed(object sender, AuthenticatorCompletedEventArgs e)
		{
			if (e.IsAuthenticated)
			{
				var request = new OAuth2Request(
				   "GET",
				 new Uri("https://graph.facebook.com/me?fields=name,picture,cover,birthday"),
				   null,
				  e.Account);

				var fbResponse = await request.GetResponseAsync();

				//invoke the method that display the app's page
				//that you want to present to user

				//NameLabel.Text += name;
				//IdLabel.Text += id;
				//PictureImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(picture)));
				//CoverImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(cover)));
				// Launches a new instance of CallHistoryController
				DismissViewController(true, null);

                StarPicker starPicker = this.Storyboard.InstantiateViewController("StarPicker") as StarPicker;
                PresentViewController(starPicker, true, null);
			}

			else
			{
				var alert = UIAlertController.Create("Did not work", "Try again", UIAlertControllerStyle.Alert);
				alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
				PresentViewController(alert, true, null);
			}
		}


		protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
		
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


    }
}
