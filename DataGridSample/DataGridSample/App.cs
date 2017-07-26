using System;

using Xamarin.Forms;

namespace DataGridSample
{
	public class App : Application
	{
		public App()
		{
			//Load the assembly
			Xamarin.Forms.DataGrid.DataGridComponent.Init();

			try
			{

				MainPage = new MainPage() { BindingContext = new ViewModels.MainViewModel() };
			}
			catch (Exception ex)
			{
			}
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
