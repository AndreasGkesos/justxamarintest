using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            // var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7/"));

            //var imageSource = new UriImageSource { Uri = new Uri("https://img-9gag-fun.9cache.com/photo/a3KNABv_700bwp.webp") };
            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            //image.Source = imageSource;

            //// den douleuei
            //image.Source = ImageSource.FromResource("testxamarin.Images.background.jpg");

            //var imageAsByteArray = GetImageFromFile("Images.background.jpg");
            //image.Source = ImageSource.FromStream(() => new MemoryStream(imageAsByteArray));
        }

        //byte[] GetImageFromFile(string fileName)
        //{
        //    var applicationTypeInfo = Application.Current.GetType().GetTypeInfo();

        //    byte[] buffer = null;
        //    using (var stream = applicationTypeInfo.Assembly.GetManifestResourceStream($"{applicationTypeInfo.Namespace}.fileName"))
        //    {
        //        if (stream != null)
        //        {
        //            long length = stream.Length;
        //            buffer = new byte[length];
        //            stream.Read(buffer, 0, (int)length);
        //        }
        //    }

        //    return buffer;
        //}
    }
}