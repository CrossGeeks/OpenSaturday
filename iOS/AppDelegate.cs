using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace OpenSaturdayEventApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			ImageCircleRenderer.Init();

			UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(0, 135, 196);

			var text = new UITextAttributes
			{
				TextColor = UIColor.White
			};

			UINavigationBar.Appearance.SetTitleTextAttributes(text);
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

