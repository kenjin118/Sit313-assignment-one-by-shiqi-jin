package md5ac12f5686dcf2585c957e453054e8c72;


public class MainActivity_signInAsync
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
		mono.android.Runtime.register ("XamarinLogin.MainActivity+signInAsync, XamarinLogin", MainActivity_signInAsync.class, __md_methods);
	}


	public MainActivity_signInAsync ()
	{
		super ();
		if (getClass () == MainActivity_signInAsync.class)
			mono.android.TypeManager.Activate ("XamarinLogin.MainActivity+signInAsync, XamarinLogin", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_signInAsync (md5ac12f5686dcf2585c957e453054e8c72.MainActivity p0)
	{
		super ();
		if (getClass () == MainActivity_signInAsync.class)
			mono.android.TypeManager.Activate ("XamarinLogin.MainActivity+signInAsync, XamarinLogin", "XamarinLogin.MainActivity, XamarinLogin", this, new java.lang.Object[] { p0 });
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
