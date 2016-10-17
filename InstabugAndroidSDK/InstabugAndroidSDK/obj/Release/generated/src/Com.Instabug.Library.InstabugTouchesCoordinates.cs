using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugTouchesCoordinates", DoNotGenerateAcw=true)]
	public partial class InstabugTouchesCoordinates : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']"
		[global::Android.Runtime.Register ("com/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent", DoNotGenerateAcw=true)]
		public partial class InstabugTouchEvent : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InstabugTouchEvent); }
			}

			protected InstabugTouchEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']/constructor[@name='InstabugTouchesCoordinates.InstabugTouchEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe InstabugTouchEvent (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (InstabugTouchEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

			static Delegate cb_getX;
#pragma warning disable 0169
			static Delegate GetGetXHandler ()
			{
				if (cb_getX == null)
					cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetX);
				return cb_getX;
			}

			static int n_GetX (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetX ();
			}
#pragma warning restore 0169

			static IntPtr id_getX;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']/method[@name='getX' and count(parameter)=0]"
			[Register ("getX", "()I", "GetGetXHandler")]
			public virtual unsafe int GetX ()
			{
				if (id_getX == IntPtr.Zero)
					id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getX);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()I"));
				} finally {
				}
			}

			static Delegate cb_getY;
#pragma warning disable 0169
			static Delegate GetGetYHandler ()
			{
				if (cb_getY == null)
					cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetY);
				return cb_getY;
			}

			static int n_GetY (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetY ();
			}
#pragma warning restore 0169

			static IntPtr id_getY;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']/method[@name='getY' and count(parameter)=0]"
			[Register ("getY", "()I", "GetGetYHandler")]
			public virtual unsafe int GetY ()
			{
				if (id_getY == IntPtr.Zero)
					id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getY);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()I"));
				} finally {
				}
			}

			static Delegate cb_setX_I;
#pragma warning disable 0169
			static Delegate GetSetX_IHandler ()
			{
				if (cb_setX_I == null)
					cb_setX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetX_I);
				return cb_setX_I;
			}

			static void n_SetX_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetX (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setX_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']/method[@name='setX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setX", "(I)V", "GetSetX_IHandler")]
			public virtual unsafe void SetX (int p0)
			{
				if (id_setX_I == IntPtr.Zero)
					id_setX_I = JNIEnv.GetMethodID (class_ref, "setX", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setX_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setY_I;
#pragma warning disable 0169
			static Delegate GetSetY_IHandler ()
			{
				if (cb_setY_I == null)
					cb_setY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetY_I);
				return cb_setY_I;
			}

			static void n_SetY_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetY (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setY_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates.InstabugTouchEvent']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setY", "(I)V", "GetSetY_IHandler")]
			public virtual unsafe void SetY (int p0)
			{
				if (id_setY_I == IntPtr.Zero)
					id_setY_I = JNIEnv.GetMethodID (class_ref, "setY", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setY_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setY", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugTouchesCoordinates", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugTouchesCoordinates); }
		}

		protected InstabugTouchesCoordinates (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.InstabugTouchesCoordinates Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/InstabugTouchesCoordinates;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/InstabugTouchesCoordinates;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTouchEvents;
#pragma warning disable 0169
		static Delegate GetGetTouchEventsHandler ()
		{
			if (cb_getTouchEvents == null)
				cb_getTouchEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTouchEvents);
			return cb_getTouchEvents;
		}

		static IntPtr n_GetTouchEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugTouchesCoordinates __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTouchEvents ());
		}
#pragma warning restore 0169

		static IntPtr id_getTouchEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates']/method[@name='getTouchEvents' and count(parameter)=0]"
		[Register ("getTouchEvents", "()[Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;", "GetGetTouchEventsHandler")]
		public virtual unsafe global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[] GetTouchEvents ()
		{
			if (id_getTouchEvents == IntPtr.Zero)
				id_getTouchEvents = JNIEnv.GetMethodID (class_ref, "getTouchEvents", "()[Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;");
			try {

				if (GetType () == ThresholdType)
					return (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTouchEvents), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent));
				else
					return (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTouchEvents", "()[Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent));
			} finally {
			}
		}

		static Delegate cb_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_;
#pragma warning disable 0169
		static Delegate GetSetTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_Handler ()
		{
			if (cb_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_ == null)
				cb_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_);
			return cb_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_;
		}

		static void n_SetTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugTouchesCoordinates __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugTouchesCoordinates> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[] p0 = (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent));
			__this.SetTouchEvents (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugTouchesCoordinates']/method[@name='setTouchEvents' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugTouchesCoordinates.InstabugTouchEvent[]']]"
		[Register ("setTouchEvents", "([Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;)V", "GetSetTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_Handler")]
		public virtual unsafe void SetTouchEvents (global::Com.Instabug.Library.InstabugTouchesCoordinates.InstabugTouchEvent[] p0)
		{
			if (id_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_ == IntPtr.Zero)
				id_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_ = JNIEnv.GetMethodID (class_ref, "setTouchEvents", "([Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTouchEvents_arrayLcom_instabug_library_InstabugTouchesCoordinates_InstabugTouchEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTouchEvents", "([Lcom/instabug/library/InstabugTouchesCoordinates$InstabugTouchEvent;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
