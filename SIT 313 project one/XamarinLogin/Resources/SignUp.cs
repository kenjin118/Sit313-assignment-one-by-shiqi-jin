
using System.Collections.Specialized;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android;
using System;



namespace XamarinLogin
{
	[Activity(Label = "SignUp")]
	public class SignUp : Activity, View.IOnClickListener
	{
		EditText userName, userEmail, userPassword;
		Button signUp;


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.sign_up);
			initialize();
		}
		public void initialize()
		{
			userName = (EditText)FindViewById(Resource.Id.newUserName);
			userEmail = (EditText)FindViewById(Resource.Id.newUserEmail);
			userPassword = (EditText)FindViewById(Resource.Id.newUserPassword);
			signUp = (Button)FindViewById(Resource.Id.signUpBtn);
			signUp.SetOnClickListener(this);
		}

		public void OnClick(View v)
		{
			switch (v.Id)
			{
				case Resource.Id.signUpBtn:
					if (userName.Text.Equals("") && userEmail.Text.Equals("") && userPassword.Text.Equals(""))
					{
						Toast.MakeText(this, "Empty Fields Found", ToastLength.Short).Show();
					}
					else {

                        Toast.MakeText(this, "Sign up success", ToastLength.Short).Show();
                        Intent up = new Intent(this, typeof(MainActivity));
                        StartActivity(up);
                        Finish();
                        break;

                    }
                    break;
                 
            }
		}



	}
}

