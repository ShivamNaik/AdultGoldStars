// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AdultGoldStars
{
    [Register ("MainMenu")]
    partial class MainMenu
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AdultGoldStars.CreateStar CreateStarName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SendStarButton { get; set; }

        [Action ("CreateStarName_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CreateStarName_TouchUpInside (AdultGoldStars.CreateStar sender);

        [Action ("SendStarButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SendStarButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CreateStarName != null) {
                CreateStarName.Dispose ();
                CreateStarName = null;
            }

            if (SendStarButton != null) {
                SendStarButton.Dispose ();
                SendStarButton = null;
            }
        }
    }
}