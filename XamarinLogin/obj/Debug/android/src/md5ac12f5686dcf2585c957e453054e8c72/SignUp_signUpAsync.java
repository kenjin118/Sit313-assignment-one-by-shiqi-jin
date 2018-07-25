package md5ac12f5686dcf2585c957e453054e8c72;


public class SignUp_signUpAsync
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinLogin.SignUp+signUpAsync, XamarinLogin", SignUp_signUpAsync.class, __md_methods);
	}


	public SignUp_signUpAsync ()
	{
		super ();
		if (getClass () == SignUp_signUpAsync.class)
			mono.android.TypeManager.Activate ("XamarinLogin.SignUp+signUpAsync, XamarinLogin", "", this, new java.lang.Object[] {  });
	}

	public SignUp_signUpAsync (md5ac12f5686dcf2585c957e453054e8c72.SignUp p0)
	{
		super ();
		if (getClass () == SignUp_signUpAsync.class)
			mono.android.TypeManager.Activate ("XamarinLogin.SignUp+signUpAsync, XamarinLogin", "XamarinLogin.SignUp, XamarinLogin", this, new java.lang.Object[] { p0 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
