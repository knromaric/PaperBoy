using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaperBoy.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            InitializeSettings();

            base.OnAppearing();
        }

        private void InitializeSettings()
        {
            displayNameEntry.Text = "Roma";
            bioEditor.Text = "Roma has been developping Microsoft enterprise solution for organization.";
            articleCountSlider.Value = 10;
            categoryPicker.SelectedIndex = 1;
        }
	}
}