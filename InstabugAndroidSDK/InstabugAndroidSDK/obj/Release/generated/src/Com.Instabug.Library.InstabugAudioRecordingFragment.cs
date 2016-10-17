using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugAudioRecordingFragment", DoNotGenerateAcw=true)]
	public partial class InstabugAudioRecordingFragment : global::Android.Support.V4.App.Fragment, global::Android.Views.View.IOnClickListener, global::Android.Views.View.IOnTouchListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment.AudioTimerTask']"
		[global::Android.Runtime.Register ("com/instabug/library/InstabugAudioRecordingFragment$AudioTimerTask", DoNotGenerateAcw=true)]
		public partial class AudioTimerTask : global::Java.Util.TimerTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/InstabugAudioRecordingFragment$AudioTimerTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AudioTimerTask); }
			}

			protected AudioTimerTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugAudioRecordingFragment.AudioTimerTask __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment.AudioTimerTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment.AudioTimerTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAudioRecordingFragment.Callbacks']"
		[Register ("com/instabug/library/InstabugAudioRecordingFragment$Callbacks", "", "Com.Instabug.Library.InstabugAudioRecordingFragment/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/interface[@name='InstabugAudioRecordingFragment.Callbacks']/method[@name='onAudioRecorded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("onAudioRecorded", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnAudioRecorded_Ljava_lang_String_Ljava_lang_String_Handler:Com.Instabug.Library.InstabugAudioRecordingFragment/ICallbacksInvoker, InstabugAndroidSDK")]
			void OnAudioRecorded (string p0, string p1);

		}

		[global::Android.Runtime.Register ("com/instabug/library/InstabugAudioRecordingFragment$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/InstabugAudioRecordingFragment$Callbacks");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbacksInvoker); }
			}

			IntPtr class_ref;

			public static ICallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.InstabugAudioRecordingFragment.Callbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnAudioRecorded_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAudioRecorded_Ljava_lang_String_Ljava_lang_String_);
				return cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_OnAudioRecorded_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Instabug.Library.InstabugAudioRecordingFragment.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnAudioRecorded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
			public unsafe void OnAudioRecorded (string p0, string p1)
			{
				if (id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAudioRecorded", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugAudioRecordingFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugAudioRecordingFragment); }
		}

		protected InstabugAudioRecordingFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/constructor[@name='InstabugAudioRecordingFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugAudioRecordingFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugAudioRecordingFragment)) {
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

		static IntPtr id_newInstance_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newInstance", "(Ljava/lang/String;)Lcom/instabug/library/InstabugAudioRecordingFragment;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugAudioRecordingFragment NewInstance (string p0)
		{
			if (id_newInstance_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;)Lcom/instabug/library/InstabugAudioRecordingFragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Instabug.Library.InstabugAudioRecordingFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newInstance_Ljava_lang_String_Lcom_instabug_library_InstabugAudioRecordingFragment_Callbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.instabug.library.InstabugAudioRecordingFragment.Callbacks']]"
		[Register ("newInstance", "(Ljava/lang/String;Lcom/instabug/library/InstabugAudioRecordingFragment$Callbacks;)Lcom/instabug/library/InstabugAudioRecordingFragment;", "")]
		public static unsafe global::Com.Instabug.Library.InstabugAudioRecordingFragment NewInstance (string p0, global::Com.Instabug.Library.InstabugAudioRecordingFragment.ICallbacks p1)
		{
			if (id_newInstance_Ljava_lang_String_Lcom_instabug_library_InstabugAudioRecordingFragment_Callbacks_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_Lcom_instabug_library_InstabugAudioRecordingFragment_Callbacks_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;Lcom/instabug/library/InstabugAudioRecordingFragment$Callbacks;)Lcom/instabug/library/InstabugAudioRecordingFragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Instabug.Library.InstabugAudioRecordingFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_Lcom_instabug_library_InstabugAudioRecordingFragment_Callbacks_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugAudioRecordingFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.InstabugAudioRecordingFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.InstabugAudioRecordingFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugAudioRecordingFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugAudioRecordingFragment']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
		{
			if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
