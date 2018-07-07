using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using testxamarin.CustomRenderers;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(testxamarin.Droid.CustomRenderers.CustomEntry))]
namespace testxamarin.Droid.CustomRenderers
{
    class CustomEntry : EntryRenderer
    {
        public CustomEntry(Context context) : base(context)
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