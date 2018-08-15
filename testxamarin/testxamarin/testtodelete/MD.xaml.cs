using System;
using testxamarin;
using Xamarin.Forms;

namespace testxamarin
{
    public class MD : MasterDetailPage
    {
        MainPage masterPage;

        public MD()
        {
            InitializeComponent();
        }

        //void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as MasterPageItem;
        //    if (item != null)
        //    {
        //        Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
        //        masterPage.ListView.SelectedItem = null;
        //        IsPresented = false;
        //    }
        //}
    }
}