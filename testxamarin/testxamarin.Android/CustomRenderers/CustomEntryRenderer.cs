using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using testxamarin.CustomRenderers;
using testxamarin.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace testxamarin.Droid.CustomRenderers
{
    class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                // Control.SetTextColor(Android.Graphics.Color.Black);
            }
        }
    }
}