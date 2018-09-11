using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Text;
using BorderLessEntry;
using BorderLessEntry.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace BorderLessEntry.Droid
{
	public class CustomEntryRenderer : EntryRenderer
    {
		public CustomEntryRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
			base.OnElementChanged(e);

    //        if (Control != null)
    //        {
				//Control.SetBackgroundColor(Android.Graphics.Color.Transparent);

            
            //}

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
				Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Green);
            else
				Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
        

            }
        }
    }
