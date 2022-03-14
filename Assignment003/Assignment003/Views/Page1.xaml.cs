using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment003.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void calcButton_Clicked(object sender, EventArgs e)
        {
            double weight = double.Parse(entryKg.Text);
            double height = double.Parse(entryCm.Text);
            double result = weight / (height * height / 10000);
            lblAnswer.Text = (result).ToString();

            if (result < 18.5) await DisplayAlert("your nutritional status", "Underweight", "OK");
            else if (result >= 18.5 && result < 24.9) await DisplayAlert("your nutritional status", "Normal Weight", "OK");
            else if (result >= 25.0 && result < 29.9) await DisplayAlert("your nutritional status", "Pre-Obesity", "OK");
            else if (result >= 30.0 && result < 34.9) await DisplayAlert("your nutritional status", "Obesity Class-1", "OK");
            else if (result >= 35.0 && result < 39.9) await DisplayAlert("your nutritional status", "Obesity Class-2", "OK");
            else if (result >= 40.0) await DisplayAlert("your nutritional status", "Obesity Class-3", "OK");
        }

        private void resetButton_Clicked(object sender, EventArgs e)
        {

            entryKg.Text = "";
            entryCm.Text = "";

        }
    }
}