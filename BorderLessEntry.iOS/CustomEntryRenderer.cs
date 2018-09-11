using System;
using BorderLessEntry.iOS;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]

namespace BorderLessEntry.iOS
{
	public class MyEntryRenderer : EntryRenderer
	{
		private CALayer _line;

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{

				Control.Layer.CornerRadius = 0;
				Control.TextColor = UIColor.Black;

				Control.BorderStyle = UITextBorderStyle.None;

				_line = new CALayer
				{
					BorderColor = UIColor.Red.CGColor,//UIColor.FromRGB(174, 174, 174).CGColor,
					BackgroundColor = UIColor.Green.CGColor,//UIColor.FromRGB(174, 174, 174).CGColor,
                    Frame = new CGRect(0, Frame.Height / 2, Frame.Width * 2, 1f)
                };

                Control.Layer.AddSublayer(_line);

			}
		}
	}
}