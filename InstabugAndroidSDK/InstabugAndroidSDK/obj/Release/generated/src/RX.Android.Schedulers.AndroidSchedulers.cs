using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RX.Android.Schedulers {

	// Metadata.xml XPath class reference: path="/api/package[@name='rx.android.schedulers']/class[@name='AndroidSchedulers']"
	[global::Android.Runtime.Register ("rx/android/schedulers/AndroidSchedulers", DoNotGenerateAcw=true)]
	public sealed partial class AndroidSchedulers : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='rx.android.schedulers']/class[@name='AndroidSchedulers.MainThreadSchedulerHolder']"
		[global::Android.Runtime.Register ("rx/android/schedulers/AndroidSchedulers$MainThreadSchedulerHolder", DoNotGenerateAcw=true)]
		public partial class MainThreadSchedulerHolder : global::Java.Lang.Object {

			protected MainThreadSchedulerHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal AndroidSchedulers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
