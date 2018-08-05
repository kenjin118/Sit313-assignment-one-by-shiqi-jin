using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var calendarVIew = FindViewById<CalendarView>(Resource.Id.calendarView1);
            var txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);

            txtDisplay.Text = "Date :";
            calendarVIew.DateChange += (s, e) =>
            {
                int day = e.DayOfMonth;
                int month = e.Month;
                int year = e.Year;
                txtDisplay.Text = "Date: " + day + "/" + month + "/" + year;
            };
        }
    }
}

