using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugBaseActivity", DoNotGenerateAcw=true)]
	public partial class InstabugBaseActivity : global::Android.Support.V4.App.FragmentActivity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugBaseActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugBaseActivity); }
		}

		protected InstabugBaseActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/constructor[@name='InstabugBaseActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugBaseActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugBaseActivity)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Handler ()
		{
			if (cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ == null)
				cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_);
			return cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
		}

		static void n_AddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddFragment (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='addFragment' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String']]"
		[Register ("addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V", "GetAddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Handler")]
		protected virtual unsafe void AddFragment (int p0, global::Android.Support.V4.App.Fragment p1, string p2)
		{
			if (id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ == IntPtr.Zero)
				id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ZHandler ()
		{
			if (cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z == null)
				cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_AddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z);
			return cb_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
		}

		static void n_AddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddFragment (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='addFragment' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V", "GetAddFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ZHandler")]
		protected virtual unsafe void AddFragment (int p0, global::Android.Support.V4.App.Fragment p1, string p2, bool p3)
		{
			if (id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z == IntPtr.Zero)
				id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_popFragment;
#pragma warning disable 0169
		static Delegate GetPopFragmentHandler ()
		{
			if (cb_popFragment == null)
				cb_popFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PopFragment);
			return cb_popFragment;
		}

		static void n_PopFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PopFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_popFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='popFragment' and count(parameter)=0]"
		[Register ("popFragment", "()V", "GetPopFragmentHandler")]
		protected virtual unsafe void PopFragment ()
		{
			if (id_popFragment == IntPtr.Zero)
				id_popFragment = JNIEnv.GetMethodID (class_ref, "popFragment", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_popFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "popFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeFragment_Landroid_support_v4_app_Fragment_;
#pragma warning disable 0169
		static Delegate GetRemoveFragment_Landroid_support_v4_app_Fragment_Handler ()
		{
			if (cb_removeFragment_Landroid_support_v4_app_Fragment_ == null)
				cb_removeFragment_Landroid_support_v4_app_Fragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFragment_Landroid_support_v4_app_Fragment_);
			return cb_removeFragment_Landroid_support_v4_app_Fragment_;
		}

		static void n_RemoveFragment_Landroid_support_v4_app_Fragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFragment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeFragment_Landroid_support_v4_app_Fragment_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='removeFragment' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.Fragment']]"
		[Register ("removeFragment", "(Landroid/support/v4/app/Fragment;)V", "GetRemoveFragment_Landroid_support_v4_app_Fragment_Handler")]
		protected virtual unsafe void RemoveFragment (global::Android.Support.V4.App.Fragment p0)
		{
			if (id_removeFragment_Landroid_support_v4_app_Fragment_ == IntPtr.Zero)
				id_removeFragment_Landroid_support_v4_app_Fragment_ = JNIEnv.GetMethodID (class_ref, "removeFragment", "(Landroid/support/v4/app/Fragment;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeFragment_Landroid_support_v4_app_Fragment_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFragment", "(Landroid/support/v4/app/Fragment;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeFragmentByTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveFragmentByTag_Ljava_lang_String_Handler ()
		{
			if (cb_removeFragmentByTag_Ljava_lang_String_ == null)
				cb_removeFragmentByTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveFragmentByTag_Ljava_lang_String_);
			return cb_removeFragmentByTag_Ljava_lang_String_;
		}

		static void n_RemoveFragmentByTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveFragmentByTag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeFragmentByTag_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='removeFragmentByTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeFragmentByTag", "(Ljava/lang/String;)V", "GetRemoveFragmentByTag_Ljava_lang_String_Handler")]
		protected virtual unsafe void RemoveFragmentByTag (string p0)
		{
			if (id_removeFragmentByTag_Ljava_lang_String_ == IntPtr.Zero)
				id_removeFragmentByTag_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeFragmentByTag", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeFragmentByTag_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeFragmentByTag", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Handler ()
		{
			if (cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ == null)
				cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_ReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_);
			return cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
		}

		static void n_ReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceFragment (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='replaceFragment' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String']]"
		[Register ("replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V", "GetReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Handler")]
		protected virtual unsafe void ReplaceFragment (int p0, global::Android.Support.V4.App.Fragment p1, string p2)
		{
			if (id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ == IntPtr.Zero)
				id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ZHandler ()
		{
			if (cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z == null)
				cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_ReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z);
			return cb_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
		}

		static void n_ReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceFragment (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='replaceFragment' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V", "GetReplaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_ZHandler")]
		protected virtual unsafe void ReplaceFragment (int p0, global::Android.Support.V4.App.Fragment p1, string p2, bool p3)
		{
			if (id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z == IntPtr.Zero)
				id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceFragment_ILandroid_support_v4_app_Fragment_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFragment", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetReplaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_IIHandler ()
		{
			if (cb_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II == null)
				cb_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, int, int>) n_ReplaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II);
			return cb_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II;
		}

		static void n_ReplaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
		{
			global::Com.Instabug.Library.InstabugBaseActivity __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugBaseActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.Fragment p1 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.Fragment> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReplaceFragmentWithAnimation (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugBaseActivity']/method[@name='replaceFragmentWithAnimation' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("replaceFragmentWithAnimation", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;II)V", "GetReplaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_IIHandler")]
		protected virtual unsafe void ReplaceFragmentWithAnimation (int p0, global::Android.Support.V4.App.Fragment p1, string p2, int p3, int p4)
		{
			if (id_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II == IntPtr.Zero)
				id_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "replaceFragmentWithAnimation", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;II)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replaceFragmentWithAnimation_ILandroid_support_v4_app_Fragment_Ljava_lang_String_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replaceFragmentWithAnimation", "(ILandroid/support/v4/app/Fragment;Ljava/lang/String;II)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
