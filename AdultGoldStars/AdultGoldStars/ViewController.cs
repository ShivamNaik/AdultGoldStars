using System;

using UIKit;
using Xamarin.Auth;
using System.Json;

namespace AdultGoldStars
{
    public partial class ViewController : UIViewController
    {
        private async void Auth_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {
			if (e.IsAuthenticated)
			{
				var request = new OAuth2Request(
				   "GET",
				 new Uri("https://graph.facebook.com/me?fields=name,picture,cover,birthday"),
				   null,
				  e.Account);

				var fbResponse = await request.GetResponseAsync();

				var fbUser = JsonValue.Parse(fbResponse.GetResponseText());

				var name = fbUser["name"];
				var id = fbUser["id"];
				var picture = fbUser["picture"]["data"]["url"];
				var cover = fbUser["cover"]["source"];

				//NameLabel.Text += name;
				//IdLabel.Text += id;
				//PictureImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(picture)));
				//CoverImage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(cover)));
			}

			DismissViewController(true, null);
        }

        partial void FacebookLogin_TouchUpInside(UIButton sender)
        {
            // TO DO : add facebook login picture to login


            OAuth2Authenticator auth = new OAuth2Authenticator
            (
                clientId: "insertidtowork",
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));
    
            var ui = auth.GetUI();

            PresentViewController(ui, true, null);
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
