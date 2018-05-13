using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace App13
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new TabsPage());
		}

		protected override void OnStart ()
		{
            AppCenter.Start("uwp=b7a1f83f-c0f5-471b-a1ba-b8d398cf70f2;" + "android={Your Android App secret here}" + "ios={Your iOS App secret here}", typeof(Analytics));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
