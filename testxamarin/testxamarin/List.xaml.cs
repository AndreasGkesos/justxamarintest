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

            Network.LoginAsync("login", new LoginBindingModel { Username = "asdf", Password = "1234" });
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            activityIndicator.IsRunning = true;
            activityIndicator.IsVisible = true;
            

            try
            {
                var employees = await Network.GetAsync<List<Employee>>("getEmployees");
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

            EmployeeId.Text = ((Employee) e.Item).id;
            EmployeeName.Text = ((Employee)e.Item).employee_name;
            EmployeeSalary.Text = ((Employee)e.Item).employee_salary;
            EmployeeAge.Text = ((Employee)e.Item).employee_age;
            EmployeeImage.Text = ((Employee)e.Item).profile_image;
        }
    }
}