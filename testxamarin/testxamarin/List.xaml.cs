using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using testxamarin.Helpers;
using testxamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testxamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class List : ContentPage
	{
		public List ()
		{
			InitializeComponent ();

            EmployeeId.Text = "Test";
            EmployeeName.Text = "Test";
            EmployeeSalary.Text = "Test";
            EmployeeAge.Text = "Test";
            EmployeeImage.Text = "Test";
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            activityIndicator.IsRunning = true;
            activityIndicator.IsVisible = true;
            

            try
            {
                var employees = await Network.GetAsync<List<Employee2>>("getEmployees");
                if (employees != null)
                {
                    list.ItemsSource = employees;

                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                activityIndicator.IsRunning = false;
                activityIndicator.IsVisible = false;
            }
        }

        private void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // DisplayAlert("list", ((Employee) e.Item).id, "cancel");

            EmployeeId.Text = ((Employee2) e.Item).id;
            EmployeeName.Text = ((Employee2)e.Item).employee_name;
            EmployeeSalary.Text = ((Employee2)e.Item).employee_salary;
            EmployeeAge.Text = ((Employee2)e.Item).employee_age;
            EmployeeImage.Text = ((Employee2)e.Item).profile_image;
        }
    }
}