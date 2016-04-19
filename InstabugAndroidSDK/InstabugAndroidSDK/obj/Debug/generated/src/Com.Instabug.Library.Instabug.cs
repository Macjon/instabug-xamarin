using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']"
	[global::Android.Runtime.Register ("com/instabug/library/Instabug", DoNotGenerateAcw=true)]
	public partial class Instabug : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/field[@name='SDK_LEVEL']"
		[Register ("SDK_LEVEL")]
		public const string SdkLevel = (string) "SDK Level ";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "2.3.1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public const bool Verbose = (bool) false;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']"
		[global::Android.Runtime.Register ("com/instabug/library/Instabug$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/Instabug$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_app_Application_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/constructor[@name='Instabug.Builder' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Landroid/app/Application;Ljava/lang/String;)V", "")]
			public unsafe Builder (global::Android.App.Application p0, string p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Application;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Landroid_app_Application_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Landroid_app_Application_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_IBGInvocationEvent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/constructor[@name='Instabug.Builder' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.instabug.library.IBGInvocationEvent']]"
			[Register (".ctor", "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/IBGInvocationEvent;)V", "")]
			public unsafe Builder (global::Android.App.Application p0, string p1, global::Com.Instabug.Library.IBGInvocationEvent p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/IBGInvocationEvent;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/IBGInvocationEvent;)V", __args);
						return;
					}

					if (id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_IBGInvocationEvent_ == IntPtr.Zero)
						id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_IBGInvocationEvent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/IBGInvocationEvent;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_IBGInvocationEvent_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_IBGInvocationEvent_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/instabug/library/Instabug;", "GetBuildHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/instabug/library/Instabug;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallObjectMethod  (Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/instabug/library/Instabug;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetBuild_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_build_Lcom_instabug_library_Feature_State_ == null)
					cb_build_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Lcom_instabug_library_Feature_State_);
				return cb_build_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_Build_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("build", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug;", "GetBuild_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug Build (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_build_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_build_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "build", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallObjectMethod  (Handle, id_build_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setColorTheme_Lcom_instabug_library_IBGColorTheme_;
#pragma warning disable 0169
			static Delegate GetSetColorTheme_Lcom_instabug_library_IBGColorTheme_Handler ()
			{
				if (cb_setColorTheme_Lcom_instabug_library_IBGColorTheme_ == null)
					cb_setColorTheme_Lcom_instabug_library_IBGColorTheme_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetColorTheme_Lcom_instabug_library_IBGColorTheme_);
				return cb_setColorTheme_Lcom_instabug_library_IBGColorTheme_;
			}

			static IntPtr n_SetColorTheme_Lcom_instabug_library_IBGColorTheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.IBGColorTheme p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetColorTheme (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setColorTheme_Lcom_instabug_library_IBGColorTheme_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setColorTheme' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGColorTheme']]"
			[Register ("setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;", "GetSetColorTheme_Lcom_instabug_library_IBGColorTheme_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetColorTheme (global::Com.Instabug.Library.IBGColorTheme p0)
			{
				if (id_setColorTheme_Lcom_instabug_library_IBGColorTheme_ == IntPtr.Zero)
					id_setColorTheme_Lcom_instabug_library_IBGColorTheme_ = JNIEnv.GetMethodID (class_ref, "setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setColorTheme_Lcom_instabug_library_IBGColorTheme_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setCommentFieldRequired_Z;
#pragma warning disable 0169
			static Delegate GetSetCommentFieldRequired_ZHandler ()
			{
				if (cb_setCommentFieldRequired_Z == null)
					cb_setCommentFieldRequired_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCommentFieldRequired_Z);
				return cb_setCommentFieldRequired_Z;
			}

			static IntPtr n_SetCommentFieldRequired_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCommentFieldRequired (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setCommentFieldRequired_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setCommentFieldRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCommentFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetCommentFieldRequired_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetCommentFieldRequired (bool p0)
			{
				if (id_setCommentFieldRequired_Z == IntPtr.Zero)
					id_setCommentFieldRequired_Z = JNIEnv.GetMethodID (class_ref, "setCommentFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCommentFieldRequired_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommentFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setConsoleLogState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetConsoleLogState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setConsoleLogState_Lcom_instabug_library_Feature_State_ == null)
					cb_setConsoleLogState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConsoleLogState_Lcom_instabug_library_Feature_State_);
				return cb_setConsoleLogState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetConsoleLogState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetConsoleLogState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setConsoleLogState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setConsoleLogState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setConsoleLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetConsoleLogState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetConsoleLogState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setConsoleLogState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setConsoleLogState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setConsoleLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setConsoleLogState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConsoleLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setCrashReportingState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetCrashReportingState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setCrashReportingState_Lcom_instabug_library_Feature_State_ == null)
					cb_setCrashReportingState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCrashReportingState_Lcom_instabug_library_Feature_State_);
				return cb_setCrashReportingState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetCrashReportingState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCrashReportingState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCrashReportingState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setCrashReportingState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setCrashReportingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetCrashReportingState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetCrashReportingState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setCrashReportingState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setCrashReportingState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setCrashReportingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setCrashReportingState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCrashReportingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setDebugEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetDebugEnabled_ZHandler ()
			{
				if (cb_setDebugEnabled_Z == null)
					cb_setDebugEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDebugEnabled_Z);
				return cb_setDebugEnabled_Z;
			}

			static IntPtr n_SetDebugEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDebugEnabled (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setDebugEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setDebugEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetDebugEnabled_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetDebugEnabled (bool p0)
			{
				if (id_setDebugEnabled_Z == IntPtr.Zero)
					id_setDebugEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDebugEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDebugEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDebugEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_;
#pragma warning disable 0169
			static Delegate GetSetDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_Handler ()
			{
				if (cb_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ == null)
					cb_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_);
				return cb_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_;
			}

			static IntPtr n_SetDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.IBGInvocationMode p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDefaultInvocationMode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setDefaultInvocationMode' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGInvocationMode']]"
			[Register ("setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;", "GetSetDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetDefaultInvocationMode (global::Com.Instabug.Library.IBGInvocationMode p0)
			{
				if (id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ == IntPtr.Zero)
					id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ = JNIEnv.GetMethodID (class_ref, "setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setEmailFieldRequired_Z;
#pragma warning disable 0169
			static Delegate GetSetEmailFieldRequired_ZHandler ()
			{
				if (cb_setEmailFieldRequired_Z == null)
					cb_setEmailFieldRequired_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEmailFieldRequired_Z);
				return cb_setEmailFieldRequired_Z;
			}

			static IntPtr n_SetEmailFieldRequired_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEmailFieldRequired (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setEmailFieldRequired_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setEmailFieldRequired' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEmailFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetEmailFieldRequired_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetEmailFieldRequired (bool p0)
			{
				if (id_setEmailFieldRequired_Z == IntPtr.Zero)
					id_setEmailFieldRequired_Z = JNIEnv.GetMethodID (class_ref, "setEmailFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setEmailFieldRequired_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_;
#pragma warning disable 0169
			static Delegate GetSetFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_Handler ()
			{
				if (cb_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ == null)
					cb_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_);
				return cb_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_;
			}

			static IntPtr n_SetFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.IBGFloatingButtonEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGFloatingButtonEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFloatingButtonEdge (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setFloatingButtonEdge' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGFloatingButtonEdge']]"
			[Register ("setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;", "GetSetFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetFloatingButtonEdge (global::Com.Instabug.Library.IBGFloatingButtonEdge p0)
			{
				if (id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ == IntPtr.Zero)
					id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ = JNIEnv.GetMethodID (class_ref, "setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setFloatingButtonOffsetFromTop_I;
#pragma warning disable 0169
			static Delegate GetSetFloatingButtonOffsetFromTop_IHandler ()
			{
				if (cb_setFloatingButtonOffsetFromTop_I == null)
					cb_setFloatingButtonOffsetFromTop_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetFloatingButtonOffsetFromTop_I);
				return cb_setFloatingButtonOffsetFromTop_I;
			}

			static IntPtr n_SetFloatingButtonOffsetFromTop_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetFloatingButtonOffsetFromTop (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setFloatingButtonOffsetFromTop_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setFloatingButtonOffsetFromTop' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFloatingButtonOffsetFromTop", "(I)Lcom/instabug/library/Instabug$Builder;", "GetSetFloatingButtonOffsetFromTop_IHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetFloatingButtonOffsetFromTop (int p0)
			{
				if (id_setFloatingButtonOffsetFromTop_I == IntPtr.Zero)
					id_setFloatingButtonOffsetFromTop_I = JNIEnv.GetMethodID (class_ref, "setFloatingButtonOffsetFromTop", "(I)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setFloatingButtonOffsetFromTop_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonOffsetFromTop", "(I)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setInAppMessagingState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetInAppMessagingState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setInAppMessagingState_Lcom_instabug_library_Feature_State_ == null)
					cb_setInAppMessagingState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInAppMessagingState_Lcom_instabug_library_Feature_State_);
				return cb_setInAppMessagingState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetInAppMessagingState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInAppMessagingState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInAppMessagingState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setInAppMessagingState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setInAppMessagingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetInAppMessagingState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetInAppMessagingState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setInAppMessagingState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setInAppMessagingState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setInAppMessagingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInAppMessagingState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInAppMessagingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setInstabugLogState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetInstabugLogState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setInstabugLogState_Lcom_instabug_library_Feature_State_ == null)
					cb_setInstabugLogState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInstabugLogState_Lcom_instabug_library_Feature_State_);
				return cb_setInstabugLogState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetInstabugLogState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInstabugLogState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInstabugLogState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setInstabugLogState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setInstabugLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetInstabugLogState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetInstabugLogState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setInstabugLogState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setInstabugLogState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setInstabugLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInstabugLogState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstabugLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_;
#pragma warning disable 0169
			static Delegate GetSetInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_Handler ()
			{
				if (cb_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ == null)
					cb_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_);
				return cb_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_;
			}

			static IntPtr n_SetInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.IBGInvocationEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGInvocationEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInvocationEvent (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setInvocationEvent' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGInvocationEvent']]"
			[Register ("setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;", "GetSetInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetInvocationEvent (global::Com.Instabug.Library.IBGInvocationEvent p0)
			{
				if (id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ == IntPtr.Zero)
					id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ = JNIEnv.GetMethodID (class_ref, "setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setLocale_Ljava_util_Locale_;
#pragma warning disable 0169
			static Delegate GetSetLocale_Ljava_util_Locale_Handler ()
			{
				if (cb_setLocale_Ljava_util_Locale_ == null)
					cb_setLocale_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocale_Ljava_util_Locale_);
				return cb_setLocale_Ljava_util_Locale_;
			}

			static IntPtr n_SetLocale_Ljava_util_Locale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Util.Locale p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLocale (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setLocale_Ljava_util_Locale_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
			[Register ("setLocale", "(Ljava/util/Locale;)Lcom/instabug/library/Instabug$Builder;", "GetSetLocale_Ljava_util_Locale_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetLocale (global::Java.Util.Locale p0)
			{
				if (id_setLocale_Ljava_util_Locale_ == IntPtr.Zero)
					id_setLocale_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "setLocale", "(Ljava/util/Locale;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setLocale_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocale", "(Ljava/util/Locale;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setPushNotificationState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetPushNotificationState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setPushNotificationState_Lcom_instabug_library_Feature_State_ == null)
					cb_setPushNotificationState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPushNotificationState_Lcom_instabug_library_Feature_State_);
				return cb_setPushNotificationState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetPushNotificationState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPushNotificationState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setPushNotificationState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setPushNotificationState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setPushNotificationState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetPushNotificationState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetPushNotificationState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setPushNotificationState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setPushNotificationState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setPushNotificationState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setPushNotificationState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushNotificationState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setShakingThreshold_F;
#pragma warning disable 0169
			static Delegate GetSetShakingThreshold_FHandler ()
			{
				if (cb_setShakingThreshold_F == null)
					cb_setShakingThreshold_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetShakingThreshold_F);
				return cb_setShakingThreshold_F;
			}

			static IntPtr n_SetShakingThreshold_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShakingThreshold (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setShakingThreshold_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setShakingThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShakingThreshold", "(F)Lcom/instabug/library/Instabug$Builder;", "GetSetShakingThreshold_FHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetShakingThreshold (float p0)
			{
				if (id_setShakingThreshold_F == IntPtr.Zero)
					id_setShakingThreshold_F = JNIEnv.GetMethodID (class_ref, "setShakingThreshold", "(F)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setShakingThreshold_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShakingThreshold", "(F)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setShouldPlayConversationSounds_Z;
#pragma warning disable 0169
			static Delegate GetSetShouldPlayConversationSounds_ZHandler ()
			{
				if (cb_setShouldPlayConversationSounds_Z == null)
					cb_setShouldPlayConversationSounds_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShouldPlayConversationSounds_Z);
				return cb_setShouldPlayConversationSounds_Z;
			}

			static IntPtr n_SetShouldPlayConversationSounds_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShouldPlayConversationSounds (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setShouldPlayConversationSounds_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setShouldPlayConversationSounds' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldPlayConversationSounds", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetShouldPlayConversationSounds_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetShouldPlayConversationSounds (bool p0)
			{
				if (id_setShouldPlayConversationSounds_Z == IntPtr.Zero)
					id_setShouldPlayConversationSounds_Z = JNIEnv.GetMethodID (class_ref, "setShouldPlayConversationSounds", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setShouldPlayConversationSounds_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldPlayConversationSounds", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setShouldShowIntroDialog_Z;
#pragma warning disable 0169
			static Delegate GetSetShouldShowIntroDialog_ZHandler ()
			{
				if (cb_setShouldShowIntroDialog_Z == null)
					cb_setShouldShowIntroDialog_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShouldShowIntroDialog_Z);
				return cb_setShouldShowIntroDialog_Z;
			}

			static IntPtr n_SetShouldShowIntroDialog_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShouldShowIntroDialog (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setShouldShowIntroDialog_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setShouldShowIntroDialog' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetShouldShowIntroDialog_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetShouldShowIntroDialog (bool p0)
			{
				if (id_setShouldShowIntroDialog_Z == IntPtr.Zero)
					id_setShouldShowIntroDialog_Z = JNIEnv.GetMethodID (class_ref, "setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setShouldShowIntroDialog_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetTrackingUserStepsState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_ == null)
					cb_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTrackingUserStepsState_Lcom_instabug_library_Feature_State_);
				return cb_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetTrackingUserStepsState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTrackingUserStepsState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setTrackingUserStepsState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setTrackingUserStepsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetTrackingUserStepsState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetTrackingUserStepsState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setTrackingUserStepsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackingUserStepsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setUserDataState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetUserDataState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setUserDataState_Lcom_instabug_library_Feature_State_ == null)
					cb_setUserDataState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserDataState_Lcom_instabug_library_Feature_State_);
				return cb_setUserDataState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetUserDataState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserDataState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUserDataState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setUserDataState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setUserDataState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetUserDataState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetUserDataState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setUserDataState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setUserDataState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setUserDataState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setUserDataState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserDataState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setWillTakeScreenshot_Z;
#pragma warning disable 0169
			static Delegate GetSetWillTakeScreenshot_ZHandler ()
			{
				if (cb_setWillTakeScreenshot_Z == null)
					cb_setWillTakeScreenshot_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWillTakeScreenshot_Z);
				return cb_setWillTakeScreenshot_Z;
			}

			static IntPtr n_SetWillTakeScreenshot_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWillTakeScreenshot (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setWillTakeScreenshot_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setWillTakeScreenshot' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetWillTakeScreenshot_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetWillTakeScreenshot (bool p0)
			{
				if (id_setWillTakeScreenshot_Z == IntPtr.Zero)
					id_setWillTakeScreenshot_Z = JNIEnv.GetMethodID (class_ref, "setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod  (Handle, id_setWillTakeScreenshot_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/Instabug", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Instabug); }
		}

		protected Instabug (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAppToken;
		public static unsafe string AppToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getAppToken' and count(parameter)=0]"
			[Register ("getAppToken", "()Ljava/lang/String;", "GetGetAppTokenHandler")]
			get {
				if (id_getAppToken == IntPtr.Zero)
					id_getAppToken = JNIEnv.GetStaticMethodID (class_ref, "getAppToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getColorTheme;
		public static unsafe global::Com.Instabug.Library.IBGColorTheme ColorTheme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getColorTheme' and count(parameter)=0]"
			[Register ("getColorTheme", "()Lcom/instabug/library/IBGColorTheme;", "GetGetColorThemeHandler")]
			get {
				if (id_getColorTheme == IntPtr.Zero)
					id_getColorTheme = JNIEnv.GetStaticMethodID (class_ref, "getColorTheme", "()Lcom/instabug/library/IBGColorTheme;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.IBGColorTheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getColorTheme), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.Instabug Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/Instabug;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/Instabug;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isDebugEnabled;
		public static unsafe bool IsDebugEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isDebugEnabled' and count(parameter)=0]"
			[Register ("isDebugEnabled", "()Z", "GetIsDebugEnabledHandler")]
			get {
				if (id_isDebugEnabled == IntPtr.Zero)
					id_isDebugEnabled = JNIEnv.GetStaticMethodID (class_ref, "isDebugEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebugEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isEnabled;
		public static unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetStaticMethodID (class_ref, "isEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isSDKInvoked;
		public static unsafe bool IsSDKInvoked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isSDKInvoked' and count(parameter)=0]"
			[Register ("isSDKInvoked", "()Z", "GetIsSDKInvokedHandler")]
			get {
				if (id_isSDKInvoked == IntPtr.Zero)
					id_isSDKInvoked = JNIEnv.GetStaticMethodID (class_ref, "isSDKInvoked", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSDKInvoked);
				} finally {
				}
			}
		}

		static IntPtr id_getLocale;
		public static unsafe global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "GetGetLocaleHandler")]
			get {
				if (id_getLocale == IntPtr.Zero)
					id_getLocale = JNIEnv.GetStaticMethodID (class_ref, "getLocale", "()Ljava/util/Locale;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocale), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPrimaryColor;
		static IntPtr id_setPrimaryColor_I;
		public static unsafe int PrimaryColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getPrimaryColor' and count(parameter)=0]"
			[Register ("getPrimaryColor", "()I", "GetGetPrimaryColorHandler")]
			get {
				if (id_getPrimaryColor == IntPtr.Zero)
					id_getPrimaryColor = JNIEnv.GetStaticMethodID (class_ref, "getPrimaryColor", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getPrimaryColor);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setPrimaryColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPrimaryColor", "(I)V", "GetSetPrimaryColor_IHandler")]
			set {
				if (id_setPrimaryColor_I == IntPtr.Zero)
					id_setPrimaryColor_I = JNIEnv.GetStaticMethodID (class_ref, "setPrimaryColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setPrimaryColor_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getUserData;
		static IntPtr id_setUserData_Ljava_lang_String_;
		public static unsafe string UserData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getUserData' and count(parameter)=0]"
			[Register ("getUserData", "()Ljava/lang/String;", "GetGetUserDataHandler")]
			get {
				if (id_getUserData == IntPtr.Zero)
					id_getUserData = JNIEnv.GetStaticMethodID (class_ref, "getUserData", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setUserData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserData", "(Ljava/lang/String;)V", "GetSetUserData_Ljava_lang_String_Handler")]
			set {
				if (id_setUserData_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserData_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserData", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserData_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getUserEmail;
		static IntPtr id_setUserEmail_Ljava_lang_String_;
		public static unsafe string UserEmail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getUserEmail' and count(parameter)=0]"
			[Register ("getUserEmail", "()Ljava/lang/String;", "GetGetUserEmailHandler")]
			get {
				if (id_getUserEmail == IntPtr.Zero)
					id_getUserEmail = JNIEnv.GetStaticMethodID (class_ref, "getUserEmail", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserEmail), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setUserEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserEmail", "(Ljava/lang/String;)V", "GetSetUserEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setUserEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserEmail_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserEmail_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getUsername;
		static IntPtr id_setUsername_Ljava_lang_String_;
		public static unsafe string Username {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getUsername' and count(parameter)=0]"
			[Register ("getUsername", "()Ljava/lang/String;", "GetGetUsernameHandler")]
			get {
				if (id_getUsername == IntPtr.Zero)
					id_getUsername = JNIEnv.GetStaticMethodID (class_ref, "getUsername", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUsername), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUsername", "(Ljava/lang/String;)V", "GetSetUsername_Ljava_lang_String_Handler")]
			set {
				if (id_setUsername_Ljava_lang_String_ == IntPtr.Zero)
					id_setUsername_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUsername", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setUsername_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_addMapView_Landroid_view_View_Lcom_google_android_gms_maps_GoogleMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='addMapView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.google.android.gms.maps.GoogleMap']]"
		[Register ("addMapView", "(Landroid/view/View;Lcom/google/android/gms/maps/GoogleMap;)V", "")]
		public static unsafe void AddMapView (global::Android.Views.View p0, global::Android.Gms.Maps.GoogleMap p1)
		{
			if (id_addMapView_Landroid_view_View_Lcom_google_android_gms_maps_GoogleMap_ == IntPtr.Zero)
				id_addMapView_Landroid_view_View_Lcom_google_android_gms_maps_GoogleMap_ = JNIEnv.GetStaticMethodID (class_ref, "addMapView", "(Landroid/view/View;Lcom/google/android/gms/maps/GoogleMap;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addMapView_Landroid_view_View_Lcom_google_android_gms_maps_GoogleMap_, __args);
			} finally {
			}
		}

		static IntPtr id_changeInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='changeInvocationEvent' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGInvocationEvent']]"
		[Register ("changeInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)V", "")]
		public static unsafe void ChangeInvocationEvent (global::Com.Instabug.Library.IBGInvocationEvent p0)
		{
			if (id_changeInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ == IntPtr.Zero)
				id_changeInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ = JNIEnv.GetStaticMethodID (class_ref, "changeInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_changeInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_, __args);
			} finally {
			}
		}

		static IntPtr id_changeLocale_Ljava_util_Locale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='changeLocale' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register ("changeLocale", "(Ljava/util/Locale;)V", "")]
		public static unsafe void ChangeLocale (global::Java.Util.Locale p0)
		{
			if (id_changeLocale_Ljava_util_Locale_ == IntPtr.Zero)
				id_changeLocale_Ljava_util_Locale_ = JNIEnv.GetStaticMethodID (class_ref, "changeLocale", "(Ljava/util/Locale;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_changeLocale_Ljava_util_Locale_, __args);
			} finally {
			}
		}

		static IntPtr id_clearLog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='clearLog' and count(parameter)=0]"
		[Register ("clearLog", "()V", "")]
		public static unsafe void ClearLog ()
		{
			if (id_clearLog == IntPtr.Zero)
				id_clearLog = JNIEnv.GetStaticMethodID (class_ref, "clearLog", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLog);
			} finally {
			}
		}

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "")]
		public static unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetStaticMethodID (class_ref, "disable", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disable);
			} finally {
			}
		}

		static IntPtr id_dismiss;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "")]
		public static unsafe void Dismiss ()
		{
			if (id_dismiss == IntPtr.Zero)
				id_dismiss = JNIEnv.GetStaticMethodID (class_ref, "dismiss", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dismiss);
			} finally {
			}
		}

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "")]
		public static unsafe void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetStaticMethodID (class_ref, "enable", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enable);
			} finally {
			}
		}

		static IntPtr id_invoke;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='invoke' and count(parameter)=0]"
		[Register ("invoke", "()V", "")]
		public static unsafe void Invoke ()
		{
			if (id_invoke == IntPtr.Zero)
				id_invoke = JNIEnv.GetStaticMethodID (class_ref, "invoke", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invoke);
			} finally {
			}
		}

		static IntPtr id_invoke_Lcom_instabug_library_IBGInvocationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGInvocationMode']]"
		[Register ("invoke", "(Lcom/instabug/library/IBGInvocationMode;)V", "")]
		public static unsafe void Invoke (global::Com.Instabug.Library.IBGInvocationMode p0)
		{
			if (id_invoke_Lcom_instabug_library_IBGInvocationMode_ == IntPtr.Zero)
				id_invoke_Lcom_instabug_library_IBGInvocationMode_ = JNIEnv.GetStaticMethodID (class_ref, "invoke", "(Lcom/instabug/library/IBGInvocationMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invoke_Lcom_instabug_library_IBGInvocationMode_, __args);
			} finally {
			}
		}

		static IntPtr id_log_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void Log (string p0)
		{
			if (id_log_Ljava_lang_String_ == IntPtr.Zero)
				id_log_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_notifyActivityDestroyed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='notifyActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityDestroyed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityDestroyed (global::Android.App.Activity p0)
		{
			if (id_notifyActivityDestroyed_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityDestroyed_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityDestroyed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityDestroyed_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityPaused_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='notifyActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityPaused", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityPaused (global::Android.App.Activity p0)
		{
			if (id_notifyActivityPaused_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityPaused_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityPaused", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityPaused_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityResumed_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='notifyActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityResumed", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityResumed (global::Android.App.Activity p0)
		{
			if (id_notifyActivityResumed_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityResumed_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityResumed", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityResumed_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityStarted_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='notifyActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityStarted", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityStarted (global::Android.App.Activity p0)
		{
			if (id_notifyActivityStarted_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityStarted_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityStarted", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityStarted_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_notifyActivityStopped_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='notifyActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("notifyActivityStopped", "(Landroid/app/Activity;)V", "")]
		public static unsafe void NotifyActivityStopped (global::Android.App.Activity p0)
		{
			if (id_notifyActivityStopped_Landroid_app_Activity_ == IntPtr.Zero)
				id_notifyActivityStopped_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "notifyActivityStopped", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notifyActivityStopped_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_reportException_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='reportException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("reportException", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void ReportException (global::Java.Lang.Throwable p0)
		{
			if (id_reportException_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_reportException_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "reportException", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportException_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_reportException_Ljava_lang_Throwable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='reportException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportException", "(Ljava/lang/Throwable;Ljava/lang/String;)V", "")]
		public static unsafe void ReportException (global::Java.Lang.Throwable p0, string p1)
		{
			if (id_reportException_Ljava_lang_Throwable_Ljava_lang_String_ == IntPtr.Zero)
				id_reportException_Ljava_lang_Throwable_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportException", "(Ljava/lang/Throwable;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportException_Ljava_lang_Throwable_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setDialog_Landroid_app_Dialog_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setDialog' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Register ("setDialog", "(Landroid/app/Dialog;)V", "")]
		public static unsafe void SetDialog (global::Android.App.Dialog p0)
		{
			if (id_setDialog_Landroid_app_Dialog_ == IntPtr.Zero)
				id_setDialog_Landroid_app_Dialog_ = JNIEnv.GetStaticMethodID (class_ref, "setDialog", "(Landroid/app/Dialog;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDialog_Landroid_app_Dialog_, __args);
			} finally {
			}
		}

		static IntPtr id_setFileAttachment_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setFileAttachment' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setFileAttachment", "(Landroid/net/Uri;)V", "")]
		public static unsafe void SetFileAttachment (global::Android.Net.Uri p0)
		{
			if (id_setFileAttachment_Landroid_net_Uri_ == IntPtr.Zero)
				id_setFileAttachment_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "setFileAttachment", "(Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setFileAttachment_Landroid_net_Uri_, __args);
			} finally {
			}
		}

		static IntPtr id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setGLSurfaceView' and count(parameter)=1 and parameter[1][@type='android.opengl.GLSurfaceView']]"
		[Register ("setGLSurfaceView", "(Landroid/opengl/GLSurfaceView;)V", "")]
		public static unsafe void SetGLSurfaceView (global::Android.Opengl.GLSurfaceView p0)
		{
			if (id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ == IntPtr.Zero)
				id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ = JNIEnv.GetStaticMethodID (class_ref, "setGLSurfaceView", "(Landroid/opengl/GLSurfaceView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_, __args);
			} finally {
			}
		}

		static IntPtr id_setPreSendingRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setPreSendingRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setPreSendingRunnable", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void SetPreSendingRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_setPreSendingRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setPreSendingRunnable_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setPreSendingRunnable", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPreSendingRunnable_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_showIntroMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='showIntroMessage' and count(parameter)=0]"
		[Register ("showIntroMessage", "()V", "")]
		public static unsafe void ShowIntroMessage ()
		{
			if (id_showIntroMessage == IntPtr.Zero)
				id_showIntroMessage = JNIEnv.GetStaticMethodID (class_ref, "showIntroMessage", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showIntroMessage);
			} finally {
			}
		}

	}
}
