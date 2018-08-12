using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android;
using System;

using Android.Content;
using Android.Runtime;
using Android.Views;
namespace XamarinLogin
{
    [Activity(Label = "calendar")]
    public class calendar : Activity,View.IOnClickListener
    {
        Button LOGOUT;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.calendar);
            initialize();
            var calendarVIew = FindViewById<CalendarView>(Resource.Id.Newcalendar);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay1);

            txtDisplay.Text = "Date :";
            calendarVIew.DateChange += (s, e) =>
            {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;
                txtDisplay.Text = "Date: " + day + "/" + month + "/" + year;
            };



        }


        public void initialize()
        {

            LOGOUT = (Button)FindViewById(Resource.Id.BackButton);
            LOGOUT.SetOnClickListener(this);

        }
        public void OnClick(View v)
        {
            switch (v.Id)
            {

                case Resource.Id.BackButton:
                    Intent up = new Intent(this, typeof(MainActivity));
                    StartActivity(up);
                    Finish();
                    break;


            }

        }

        

    }

}
