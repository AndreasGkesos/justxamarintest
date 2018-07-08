using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using testxamarin.CustomRenderers;
using testxamarin.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientColorStack), typeof(GradientColorStackRenderer))]
namespace testxamarin.Droid.CustomRenderers
{
    public class GradientColorStackRenderer:VisualElementRenderer<Xamarin.Forms.AbsoluteLayout>
    {
        //public GradientColorStackRenderer(Color startColor, Color endColor)
        //{
        //    StartColor = startColor;
        //    EndColor = endColor;
        //}

        private Color StartColor { get; set; }
        private Color EndColor { get; set; }

        protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        {
            var gradient = new Android.Graphics.LinearGradient(0, 0, this.Width, 0,StartColor.ToAndroid(), EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Repeat);
            var paint = new Android.Graphics.Paint()
            {
                Dither = true
            };
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.AbsoluteLayout> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                var stack = e.NewElement as GradientColorStack;
                this.StartColor = stack.StartColor;
                this.EndColor = stack.EndColor;
            }catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"ERROR:", ex.Message);
            }
        }
    }
}