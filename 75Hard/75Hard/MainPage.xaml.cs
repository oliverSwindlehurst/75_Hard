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
            StartupCheck();
        }

        private void StartupCheck()
        {
            var app = Application.Current as App;

            cb_Exercise_1.IsChecked = app.Exercise_1;
            cb_Exercise_2.IsChecked = app.Exercise_2;
            cb_Diet.IsChecked = app.Diet;
            cb_Study.IsChecked = app.Study;
            cb_Water_1.IsChecked = app.Water_1;
            cb_Water_2.IsChecked = app.Water_2;
            cb_Water_3.IsChecked = app.Water_3;
            cb_Water_4.IsChecked = app.Water_4;
            cb_Book_Read.IsChecked = app.Book_Read;
            cb_Progress_Picture.IsChecked = app.Progress_Picture;
            Day_Counter.Text = "Day Counter: " + app.Day_Counter;
        }

        private void Button_Clicked_Day_Done(object sender, EventArgs e)
        {
            var app = Application.Current as App;

            if (tally == 10)
            {
                if (counter == 75)
                {
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

            app.Day_Counter = counter;

            Uncheck_All();

            Day_Counter.Text = "Day Counter: " + counter;
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
        }
        private void CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if(cb_Exercise_1.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Exercise_1 = cb_Exercise_1.IsChecked;
        }
        private void CheckedChanged_2(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Exercise_2.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Exercise_2 = cb_Exercise_2.IsChecked;
        }
        private void CheckedChanged_3(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Diet.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Diet = cb_Diet.IsChecked;
        }
        private void CheckedChanged_4(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Study.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Study = cb_Study.IsChecked;
        }
        private void CheckedChanged_5(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Water_1.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Water_1 = cb_Water_1.IsChecked;
        }
        private void CheckedChanged_6(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Water_2.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Water_2 = cb_Water_2.IsChecked;
        }
        private void CheckedChanged_7(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Water_3.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Water_3 = cb_Water_3.IsChecked;
        }
        private void CheckedChanged_8(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Water_4.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Water_4 = cb_Water_4.IsChecked;
        }
        private void CheckedChanged_9(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Book_Read.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Book_Read = cb_Book_Read.IsChecked;
        }
        private void CheckedChanged_10(object sender, CheckedChangedEventArgs e)
        {
            var app = Application.Current as App;

            if (cb_Progress_Picture.IsChecked == true)
            {
                tally++;
            }
            else
            {
                tally--;
            }

            app.Progress_Picture = cb_Progress_Picture.IsChecked;
        }
    }
}
