﻿using Android.Content;
using System;
using testxamarin;
using testxamarin.CustomRenderers;
using testxamarin.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Login), typeof(CustomPageRenderer))]
namespace testxamarin.Droid.CustomRenderers
{
    public class CustomPageRenderer : PageRenderer
    {
        public CustomPageRenderer(Context context) : base(context)
        {
        }

        private Color StartColor { get; set; }
        private Color EndColor { get; set; }
        protected override void DispatchDraw(
            global::Android.Graphics.Canvas canvas)
        {
            var gradient = new Android.Graphics.LinearGradient(0, 0, Width, 0,
                this.StartColor.ToAndroid(),
                this.EndColor.ToAndroid(),
                Android.Graphics.Shader.TileMode.Mirror);
            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                var page = e.NewElement as testxamarin.CustomRenderers.CustomPage;
                this.StartColor = page.StartColor;
                this.EndColor = page.EndColor;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"ERROR: ", ex.Message);
            }
        }
    }
}