using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugNotificationManager']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugNotificationManager", DoNotGenerateAcw=true)]
	public partial class InstabugNotificationManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugNotificationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugNotificationManager); }
		}

		protected InstabugNotificationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.InstabugNotificationManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugNotificationManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/InstabugNotificationManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/InstabugNotificationManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugNotificationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dismissInstabugSystemNotification_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDismissInstabugSystemNotification_Landroid_content_Context_Handler ()
		{
			if (cb_dismissInstabugSystemNotification_Landroid_content_Context_ == null)
				cb_dismissInstabugSystemNotification_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DismissInstabugSystemNotification_Landroid_content_Context_);
			return cb_dismissInstabugSystemNotification_Landroid_content_Context_;
		}

		static void n_DismissInstabugSystemNotification_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DismissInstabugSystemNotification (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dismissInstabugSystemNotification_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugNotificationManager']/method[@name='dismissInstabugSystemNotification' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("dismissInstabugSystemNotification", "(Landroid/content/Context;)V", "GetDismissInstabugSystemNotification_Landroid_content_Context_Handler")]
		public virtual unsafe void DismissInstabugSystemNotification (global::Android.Content.Context p0)
		{
			if (id_dismissInstabugSystemNotification_Landroid_content_Context_ == IntPtr.Zero)
				id_dismissInstabugSystemNotification_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "dismissInstabugSystemNotification", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismissInstabugSystemNotification_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismissInstabugSystemNotification", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_playNotificationSound_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetPlayNotificationSound_Landroid_content_Context_Handler ()
		{
			if (cb_playNotificationSound_Landroid_content_Context_ == null)
				cb_playNotificationSound_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PlayNotificationSound_Landroid_content_Context_);
			return cb_playNotificationSound_Landroid_content_Context_;
		}

		static void n_PlayNotificationSound_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayNotificationSound (p0);
		}
#pragma warning restore 0169

		static IntPtr id_playNotificationSound_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugNotificationManager']/method[@name='playNotificationSound' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("playNotificationSound", "(Landroid/content/Context;)V", "GetPlayNotificationSound_Landroid_content_Context_Handler")]
		public virtual unsafe void PlayNotificationSound (global::Android.Content.Context p0)
		{
			if (id_playNotificationSound_Landroid_content_Context_ == IntPtr.Zero)
				id_playNotificationSound_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "playNotificationSound", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playNotificationSound_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playNotificationSound", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSystemNotification_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendSystemNotification_Landroid_content_Context_Ljava_lang_String_);
			return cb_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_SendSystemNotification_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.InstabugNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendSystemNotification (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugNotificationManager']/method[@name='sendSystemNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendSystemNotification", "(Landroid/content/Context;Ljava/lang/String;)V", "GetSendSystemNotification_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void SendSystemNotification (global::Android.Content.Context p0, string p1)
		{
			if (id_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendSystemNotification", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSystemNotification_Landroid_content_Context_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSystemNotification", "(Landroid/content/Context;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
