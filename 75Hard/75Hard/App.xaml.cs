using System;
using Xamarin.Forms;

namespace _75Hard
{
    public partial class App : Application
    {
        private const string Exercise_1Key = "Excercise_1";
        private const string Exercise_2Key = "Excercise_2";
        private const string DietKey = "Diet";
        private const string StudyKey = "Study";
        private const string Water_1Key = "Water_1";
        private const string Water_2Key = "Water_2";
        private const string Water_3Key = "Water_3";
        private const string Water_4Key = "Water_4";
        private const string Book_ReadKey = "Book_Read";
        private const string Progress_PictureKey = "Progress_Picture";
        private const string Day_CounterKey = "Day_Counter";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public bool Excercise_1
        {
            get
            {
                if (Properties.ContainsKey(Exercise_1Key))
                {
                    return (bool)Properties[Exercise_1Key];
                }
                return false;
            }
            set
            {
                Properties[Exercise_1Key] = value;
            }
        }

        public bool Excercise_2
        {
            get
            {
                if (Properties.ContainsKey(Exercise_2Key))
                {
                    return (bool)Properties[Exercise_2Key];
                }
                return false;
            }
            set
            {
                Properties[Exercise_2Key] = value;
            }
        }

        public bool Diet
        {
            get
            {
                if (Properties.ContainsKey(DietKey))
                {
                    return (bool)Properties[DietKey];
                }
                return false;
            }
            set
            {
                Properties[DietKey] = value;
            }
        }

        public bool Study
        {
            get
            {
                if (Properties.ContainsKey(StudyKey))
                {
                    return (bool)Properties[StudyKey];
                }
                return false;
            }
            set
            {
                Properties[StudyKey] = value;
            }
        }

        public bool Water_1
        {
            get
            {
                if (Properties.ContainsKey(Water_1Key))
                {
                    return (bool)Properties[Water_1Key];
                }
                return false;
            }
            set
            {
                Properties[Water_1Key] = value;
            }
        }

        public bool Water_2
        {
            get
            {
                if (Properties.ContainsKey(Water_2Key))
                {
                    return (bool)Properties[Water_2Key];
                }
                return false;
            }
            set
            {
                Properties[Water_2Key] = value;
            }
        }

        public bool Water_3
        {
            get
            {
                if (Properties.ContainsKey(Water_3Key))
                {
                    return (bool)Properties[Water_3Key];
                }
                return false;
            }
            set
            {
                Properties[Water_3Key] = value;
            }
        }

        public bool Water_4
        {
            get
            {
                if (Properties.ContainsKey(Water_4Key))
                {
                    return (bool)Properties[Water_4Key];
                }
                return false;
            }
            set
            {
                Properties[Water_4Key] = value;
            }
        }

        public bool Book_Read
        {
            get
            {
                if (Properties.ContainsKey(Book_ReadKey))
                {
                    return (bool)Properties[Book_ReadKey];
                }
                return false;
            }
            set
            {
                Properties[Book_ReadKey] = value;
            }
        }

        public bool Progress_Picture
        {
            get
            {
                if (Properties.ContainsKey(Progress_PictureKey))
                {
                    return (bool)Properties[Progress_PictureKey];
                }
                return false;
            }
            set
            {
                Properties[Progress_PictureKey] = value;
            }
        }

        public string Day_Counter
        {
            get
            {
                if (Properties.ContainsKey(Day_CounterKey))
                {
                    return Properties[Day_CounterKey].ToString();
                }
                return "Day Counter: 0";
            }
            set
            {
                Properties[Day_CounterKey] = value;
            }
        }
    }
}