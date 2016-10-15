using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace OpenSaturdayEventApp.Pages
{
	public partial class MainTabbedPage : TabbedPage
	{
		public MainTabbedPage()
		{
			InitializeComponent();

			var model = Xamarin.Forms.JsonModel.Parse(BundleFileToString("OpenSaturdayEventApp.Info.json"));
			BindingContext = model;
		}

		public string BundleFileToString(string path)
		{
			var stream = this.GetType().GetTypeInfo().Assembly.GetManifestResourceStream(path);
			var text = new StreamReader(stream).ReadToEnd();
			return text;
		}
	}
}

