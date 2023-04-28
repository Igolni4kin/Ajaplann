using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Ajaplaan
{
    public partial class AjaplaanPage : ContentPage
    {
        TimeSpan _triggerTime;

        public AjaplaanPage()
        {
            InitializeComponent();
        }

        private void _timePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _triggerTime = _timePicker.Time;

            if (_triggerTime.Hours.ToString() == "4")
            {
                LabelInfo.Text = "Wake up";
                imageforpicker.Source = "wakeup.png";
            }
            else if (_triggerTime.Hours.ToString() == "5")
            {
                LabelInfo.Text = "Get a breakfast";
                imageforpicker.Source = "breakfast.png";
            }
            else if (_triggerTime.Hours.ToString() == "6")
            {
                LabelInfo.Text = "Brush teeth";
                imageforpicker.Source = "brushteeth.png";
            }
            else if (_triggerTime.Hours.ToString() == "7")
            {
                LabelInfo.Text = "Get dressed";
                imageforpicker.Source = "getdressed.png";
            }
            else if (_triggerTime.Hours.ToString() == "8")
            {
                LabelInfo.Text = "Driving a car";
                imageforpicker.Source = "drivingcar.png";
            }
            else if (_triggerTime.Hours.ToString() == "9")
            {
                LabelInfo.Text = "Study";
                imageforpicker.Source = "study.png";
            }
            else if (_triggerTime.Hours.ToString() == "10")
            {
                LabelInfo.Text = "Have a lunch";
                imageforpicker.Source = "havealunch.png";
            }
            else if (_triggerTime.Hours.ToString() == "11")
            {
                LabelInfo.Text = "Go to the shop";
                imageforpicker.Source = "gotoshop.png";
            }
            else if (_triggerTime.Hours.ToString() == "12")
            {
                LabelInfo.Text = "Have play with kids";
                imageforpicker.Source = "playwithkids.png";
            }
            else if (_triggerTime.Hours.ToString() == "13")
            {
                LabelInfo.Text = "Get a dinner";
                imageforpicker.Source = "getadinner.png";
            }
            else if (_triggerTime.Hours.ToString() == "14")
            {
                LabelInfo.Text = "Have a rest";
                imageforpicker.Source = "havearest.png";
            }
            else if (_triggerTime.Hours.ToString() == "15")
            {
                LabelInfo.Text = "Go to sleep";
                imageforpicker.Source = "gotosleep.png";
            }


            ButtonTagasi.Clicked += ButtonTagasi_Clicked;
        }

        private async void ButtonTagasi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}