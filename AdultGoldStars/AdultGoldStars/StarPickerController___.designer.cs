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
    [Register ("StarPickerController")]
    partial class StarPickerController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AdultGoldStars.StarPickerController dataSource { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        AdultGoldStars.StarPickerController @delegate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dataSource != null) {
                dataSource.Dispose ();
                dataSource = null;
            }

            if (@delegate != null) {
                @delegate.Dispose ();
                @delegate = null;
            }
        }
    }
}