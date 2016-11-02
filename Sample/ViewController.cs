using System;
using CustomActivityIndicatorView;
using UIKit;
using CoreGraphics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		partial void BtnClickMeTouchUpInside(UIButton sender)
		{
			DGActivityIndicatorView DView = new DGActivityIndicatorView(DGActivityIndicatorAnimationType.RotatingSandglass, UIColor.Blue, 20f);
			DView.Frame = new CGRect(this.View.Bounds.Width / 2 - 25, this.View.Bounds.Height / 2 - 25, 50, 50);
			this.View.AddSubview(DView);
			DView.StartAnimating();
		}
	}
}
