using Android.Widget;
using System;
using Xamarin.Forms;

namespace _75Hard
{
    public partial class MainPage : ContentPage
    {
        int counter;
        int tally;
        public MainPage()
        {
            InitializeComponent();

            BindingContext = Application.Current;

            if (Application.Current.Properties.ContainsKey("Day_Counter"))
            {
                counter = (int)Application.Current.Properties["Day_Counter"];
            }

            if (Application.Current.Properties.ContainsKey("Tally"))
            {
                tally = (int)Application.Current.Properties["Tally"];
            }

        }

        private async void Button_Clicked_Day_Done(object sender, EventArgs e)
        {
            if (tally == 10)
            {
                if (counter == 75)
                {
                    await DisplayAlert("Well Done", "Congratulations on completing your 75 Days", "OK");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }
            else
            {
                counter = 0;
                tally = 0;
            }

            Uncheck_All();

            lb_Day_Counter.Text = string.Format("Day Counter: {0}", counter);

            //Why is this needed?
            Application.Current.Properties["Day_Counter"] = counter;
            Application.Current.Properties["Tally"] = tally;
        }
        private void Uncheck_All()
        {
            cb_Exercise_1.IsChecked = false;
            cb_Exercise_2.IsChecked = false;
            cb_Diet.IsChecked = false;
            cb_Study.IsChecked = false;
            cb_Water_1.IsChecked = false;
            cb_Water_2.IsChecked = false;
            cb_Water_3.IsChecked = false;
            cb_Water_4.IsChecked = false;
            cb_Book_Read.IsChecked = false;
            cb_Progress_Picture.IsChecked = false;

            tally = 0;
        }
        private void Button_Clicked_Check_All(object sender, EventArgs e)
        {
            cb_Exercise_1.IsChecked = true;
            cb_Exercise_2.IsChecked = true;
            cb_Diet.IsChecked = true;
            cb_Study.IsChecked = true;
            cb_Water_1.IsChecked = true;
            cb_Water_2.IsChecked = true;
            cb_Water_3.IsChecked = true;
            cb_Water_4.IsChecked = true;
            cb_Book_Read.IsChecked = true;
            cb_Progress_Picture.IsChecked = true;

            tally = 10;
        }
        private void CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            Application.Current.Properties["Tally"] = tally;
        }
    }
}