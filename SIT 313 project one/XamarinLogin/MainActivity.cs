using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Android.Support.V7.App;
using Android;
using System;

namespace XamarinLogin
{
	[Activity(Label = "XamarinLogin", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, Android.Views.View.IOnClickListener
	{
        EditText userEmail, userPassword;
        TextView signUp;
		EditText email, password;
		Button signIn;
	



        protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			initialize();
		}
		public void initialize()
		{
			signUp = (TextView)FindViewById(Resource.Id.signUpTxt);
			email = (EditText)FindViewById(Resource.Id.userEmail);
			password = (EditText)FindViewById(Resource.Id.userPass);
			signIn = (Button)FindViewById(Resource.Id.signInBtn);

            userEmail = (EditText)FindViewById(Resource.Id.userEmail);
            userPassword = (EditText)FindViewById(Resource.Id.userPass);
            signUp.SetOnClickListener(this);
			signIn.SetOnClickListener(this);
		}

		public void OnClick(View v)
		{
			switch (v.Id)
			{

                case Resource.Id.signInBtn:
                    if (userEmail.Text.Equals("") && userPassword.Text.Equals(""))
                    {
                        Toast.MakeText(this, "Empty Fields Found", ToastLength.Short).Show();
                    }
                    else
                    {
                        Toast.MakeText(this, "Sign in success", ToastLength.Short).Show();
                        Intent up = new Intent(this, typeof(calendar));
                        StartActivity(up);
                        Finish();
                        break;

                    }
                    break;

                case Resource.Id.signUpTxt:
                    Intent down = new Intent(this, typeof(SignUp));
                    StartActivity(down);
                    Finish();
                    break;
            }
		}


			
		

	}
}


