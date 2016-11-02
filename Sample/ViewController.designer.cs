// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnClickMe { get; set; }

        [Action ("BtnClickMeTouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnClickMeTouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnClickMe != null) {
                BtnClickMe.Dispose ();
                BtnClickMe = null;
            }
        }
    }
}