using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']"
	[global::Android.Runtime.Register ("com/instabug/library/Instabug", DoNotGenerateAcw=true)]
	public partial class Instabug : global::Java.Lang.Object {

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
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Application;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Application;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Landroid_app_Application_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Landroid_app_Application_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static IntPtr id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_invocation_InstabugInvocationEvent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/constructor[@name='Instabug.Builder' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.instabug.library.invocation.InstabugInvocationEvent']]"
			[Register (".ctor", "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/invocation/InstabugInvocationEvent;)V", "")]
			public unsafe Builder (global::Android.App.Application p0, string p1, global::Com.Instabug.Library.Invocation.InstabugInvocationEvent p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/invocation/InstabugInvocationEvent;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/invocation/InstabugInvocationEvent;)V", __args);
						return;
					}

					if (id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_invocation_InstabugInvocationEvent_ == IntPtr.Zero)
						id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_invocation_InstabugInvocationEvent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Application;Ljava/lang/String;Lcom/instabug/library/invocation/InstabugInvocationEvent;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_invocation_InstabugInvocationEvent_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Application_Ljava_lang_String_Lcom_instabug_library_invocation_InstabugInvocationEvent_, __args);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/instabug/library/Instabug;")), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setAttachmentTypesEnabled_ZZZZZ;
#pragma warning disable 0169
			static Delegate GetSetAttachmentTypesEnabled_ZZZZZHandler ()
			{
				if (cb_setAttachmentTypesEnabled_ZZZZZ == null)
					cb_setAttachmentTypesEnabled_ZZZZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, bool, bool, bool, IntPtr>) n_SetAttachmentTypesEnabled_ZZZZZ);
				return cb_setAttachmentTypesEnabled_ZZZZZ;
			}

			static IntPtr n_SetAttachmentTypesEnabled_ZZZZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, bool p2, bool p3, bool p4)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetAttachmentTypesEnabled (p0, p1, p2, p3, p4));
			}
#pragma warning restore 0169

			static IntPtr id_setAttachmentTypesEnabled_ZZZZZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setAttachmentTypesEnabled' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
			[Register ("setAttachmentTypesEnabled", "(ZZZZZ)Lcom/instabug/library/Instabug$Builder;", "GetSetAttachmentTypesEnabled_ZZZZZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetAttachmentTypesEnabled (bool p0, bool p1, bool p2, bool p3, bool p4)
			{
				if (id_setAttachmentTypesEnabled_ZZZZZ == IntPtr.Zero)
					id_setAttachmentTypesEnabled_ZZZZZ = JNIEnv.GetMethodID (class_ref, "setAttachmentTypesEnabled", "(ZZZZZ)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAttachmentTypesEnabled_ZZZZZ, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttachmentTypesEnabled", "(ZZZZZ)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			[Obsolete (@"deprecated")]
			[Register ("setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;", "GetSetColorTheme_Lcom_instabug_library_IBGColorTheme_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetColorTheme (global::Com.Instabug.Library.IBGColorTheme p0)
			{
				if (id_setColorTheme_Lcom_instabug_library_IBGColorTheme_ == IntPtr.Zero)
					id_setColorTheme_Lcom_instabug_library_IBGColorTheme_ = JNIEnv.GetMethodID (class_ref, "setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setColorTheme_Lcom_instabug_library_IBGColorTheme_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorTheme", "(Lcom/instabug/library/IBGColorTheme;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCommentFieldRequired_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCommentFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConsoleLogState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConsoleLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCrashReportingState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCrashReportingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
			[Obsolete (@"deprecated")]
			[Register ("setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;", "GetSetDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetDefaultInvocationMode (global::Com.Instabug.Library.IBGInvocationMode p0)
			{
				if (id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ == IntPtr.Zero)
					id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_ = JNIEnv.GetMethodID (class_ref, "setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultInvocationMode_Lcom_instabug_library_IBGInvocationMode_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultInvocationMode", "(Lcom/instabug/library/IBGInvocationMode;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEmailFieldRequired_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailFieldRequired", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEmailFieldVisibility_Z;
#pragma warning disable 0169
			static Delegate GetSetEmailFieldVisibility_ZHandler ()
			{
				if (cb_setEmailFieldVisibility_Z == null)
					cb_setEmailFieldVisibility_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEmailFieldVisibility_Z);
				return cb_setEmailFieldVisibility_Z;
			}

			static IntPtr n_SetEmailFieldVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEmailFieldVisibility (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setEmailFieldVisibility_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setEmailFieldVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEmailFieldVisibility", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetEmailFieldVisibility_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetEmailFieldVisibility (bool p0)
			{
				if (id_setEmailFieldVisibility_Z == IntPtr.Zero)
					id_setEmailFieldVisibility_Z = JNIEnv.GetMethodID (class_ref, "setEmailFieldVisibility", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEmailFieldVisibility_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailFieldVisibility", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEnableInAppNotificationSound_Z;
#pragma warning disable 0169
			static Delegate GetSetEnableInAppNotificationSound_ZHandler ()
			{
				if (cb_setEnableInAppNotificationSound_Z == null)
					cb_setEnableInAppNotificationSound_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableInAppNotificationSound_Z);
				return cb_setEnableInAppNotificationSound_Z;
			}

			static IntPtr n_SetEnableInAppNotificationSound_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEnableInAppNotificationSound (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setEnableInAppNotificationSound_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setEnableInAppNotificationSound' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableInAppNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetEnableInAppNotificationSound_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetEnableInAppNotificationSound (bool p0)
			{
				if (id_setEnableInAppNotificationSound_Z == IntPtr.Zero)
					id_setEnableInAppNotificationSound_Z = JNIEnv.GetMethodID (class_ref, "setEnableInAppNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableInAppNotificationSound_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableInAppNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setEnableSystemNotificationSound_Z;
#pragma warning disable 0169
			static Delegate GetSetEnableSystemNotificationSound_ZHandler ()
			{
				if (cb_setEnableSystemNotificationSound_Z == null)
					cb_setEnableSystemNotificationSound_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetEnableSystemNotificationSound_Z);
				return cb_setEnableSystemNotificationSound_Z;
			}

			static IntPtr n_SetEnableSystemNotificationSound_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetEnableSystemNotificationSound (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setEnableSystemNotificationSound_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setEnableSystemNotificationSound' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableSystemNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetEnableSystemNotificationSound_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetEnableSystemNotificationSound (bool p0)
			{
				if (id_setEnableSystemNotificationSound_Z == IntPtr.Zero)
					id_setEnableSystemNotificationSound_Z = JNIEnv.GetMethodID (class_ref, "setEnableSystemNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEnableSystemNotificationSound_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableSystemNotificationSound", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			[Obsolete (@"deprecated")]
			[Register ("setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;", "GetSetFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetFloatingButtonEdge (global::Com.Instabug.Library.IBGFloatingButtonEdge p0)
			{
				if (id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ == IntPtr.Zero)
					id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_ = JNIEnv.GetMethodID (class_ref, "setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFloatingButtonEdge_Lcom_instabug_library_IBGFloatingButtonEdge_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonEdge", "(Lcom/instabug/library/IBGFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_;
#pragma warning disable 0169
			static Delegate GetSetFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_Handler ()
			{
				if (cb_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_ == null)
					cb_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_);
				return cb_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_;
			}

			static IntPtr n_SetFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFloatingButtonEdge (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setFloatingButtonEdge' and count(parameter)=1 and parameter[1][@type='com.instabug.library.invocation.util.InstabugFloatingButtonEdge']]"
			[Register ("setFloatingButtonEdge", "(Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;", "GetSetFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetFloatingButtonEdge (global::Com.Instabug.Library.Invocation.Util.InstabugFloatingButtonEdge p0)
			{
				if (id_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_ == IntPtr.Zero)
					id_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_ = JNIEnv.GetMethodID (class_ref, "setFloatingButtonEdge", "(Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFloatingButtonEdge_Lcom_instabug_library_invocation_util_InstabugFloatingButtonEdge_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonEdge", "(Lcom/instabug/library/invocation/util/InstabugFloatingButtonEdge;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFloatingButtonOffsetFromTop_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatingButtonOffsetFromTop", "(I)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInAppMessagingState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInAppMessagingState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInstabugLogState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInstabugLogState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setIntroMessageEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetIntroMessageEnabled_ZHandler ()
			{
				if (cb_setIntroMessageEnabled_Z == null)
					cb_setIntroMessageEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetIntroMessageEnabled_Z);
				return cb_setIntroMessageEnabled_Z;
			}

			static IntPtr n_SetIntroMessageEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetIntroMessageEnabled (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setIntroMessageEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setIntroMessageEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIntroMessageEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetIntroMessageEnabled_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetIntroMessageEnabled (bool p0)
			{
				if (id_setIntroMessageEnabled_Z == IntPtr.Zero)
					id_setIntroMessageEnabled_Z = JNIEnv.GetMethodID (class_ref, "setIntroMessageEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setIntroMessageEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntroMessageEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			[Obsolete (@"deprecated")]
			[Register ("setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;", "GetSetInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetInvocationEvent (global::Com.Instabug.Library.IBGInvocationEvent p0)
			{
				if (id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ == IntPtr.Zero)
					id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_ = JNIEnv.GetMethodID (class_ref, "setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvocationEvent", "(Lcom/instabug/library/IBGInvocationEvent;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_;
#pragma warning disable 0169
			static Delegate GetSetInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_Handler ()
			{
				if (cb_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ == null)
					cb_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_);
				return cb_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_;
			}

			static IntPtr n_SetInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Invocation.InstabugInvocationEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.InstabugInvocationEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInvocationEvent (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setInvocationEvent' and count(parameter)=1 and parameter[1][@type='com.instabug.library.invocation.InstabugInvocationEvent']]"
			[Register ("setInvocationEvent", "(Lcom/instabug/library/invocation/InstabugInvocationEvent;)Lcom/instabug/library/Instabug$Builder;", "GetSetInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetInvocationEvent (global::Com.Instabug.Library.Invocation.InstabugInvocationEvent p0)
			{
				if (id_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ == IntPtr.Zero)
					id_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ = JNIEnv.GetMethodID (class_ref, "setInvocationEvent", "(Lcom/instabug/library/invocation/InstabugInvocationEvent;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInvocationEvent", "(Lcom/instabug/library/invocation/InstabugInvocationEvent;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLocale_Ljava_util_Locale_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocale", "(Ljava/util/Locale;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setNotificationIcon_I;
#pragma warning disable 0169
			static Delegate GetSetNotificationIcon_IHandler ()
			{
				if (cb_setNotificationIcon_I == null)
					cb_setNotificationIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetNotificationIcon_I);
				return cb_setNotificationIcon_I;
			}

			static IntPtr n_SetNotificationIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetNotificationIcon (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setNotificationIcon_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setNotificationIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNotificationIcon", "(I)Lcom/instabug/library/Instabug$Builder;", "GetSetNotificationIcon_IHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetNotificationIcon (int p0)
			{
				if (id_setNotificationIcon_I == IntPtr.Zero)
					id_setNotificationIcon_I = JNIEnv.GetMethodID (class_ref, "setNotificationIcon", "(I)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationIcon_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationIcon", "(I)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPromptOptionsEnabled_ZZZ;
#pragma warning disable 0169
			static Delegate GetSetPromptOptionsEnabled_ZZZHandler ()
			{
				if (cb_setPromptOptionsEnabled_ZZZ == null)
					cb_setPromptOptionsEnabled_ZZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool, bool, IntPtr>) n_SetPromptOptionsEnabled_ZZZ);
				return cb_setPromptOptionsEnabled_ZZZ;
			}

			static IntPtr n_SetPromptOptionsEnabled_ZZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, bool p2)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetPromptOptionsEnabled (p0, p1, p2));
			}
#pragma warning restore 0169

			static IntPtr id_setPromptOptionsEnabled_ZZZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setPromptOptionsEnabled' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
			[Register ("setPromptOptionsEnabled", "(ZZZ)Lcom/instabug/library/Instabug$Builder;", "GetSetPromptOptionsEnabled_ZZZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetPromptOptionsEnabled (bool p0, bool p1, bool p2)
			{
				if (id_setPromptOptionsEnabled_ZZZ == IntPtr.Zero)
					id_setPromptOptionsEnabled_ZZZ = JNIEnv.GetMethodID (class_ref, "setPromptOptionsEnabled", "(ZZZ)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPromptOptionsEnabled_ZZZ, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPromptOptionsEnabled", "(ZZZ)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPushNotificationState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushNotificationState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setShakingThreshold_I;
#pragma warning disable 0169
			static Delegate GetSetShakingThreshold_IHandler ()
			{
				if (cb_setShakingThreshold_I == null)
					cb_setShakingThreshold_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetShakingThreshold_I);
				return cb_setShakingThreshold_I;
			}

			static IntPtr n_SetShakingThreshold_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetShakingThreshold (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setShakingThreshold_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setShakingThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShakingThreshold", "(I)Lcom/instabug/library/Instabug$Builder;", "GetSetShakingThreshold_IHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetShakingThreshold (int p0)
			{
				if (id_setShakingThreshold_I == IntPtr.Zero)
					id_setShakingThreshold_I = JNIEnv.GetMethodID (class_ref, "setShakingThreshold", "(I)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShakingThreshold_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShakingThreshold", "(I)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShouldPlayConversationSounds_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldPlayConversationSounds", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			[Obsolete (@"deprecated")]
			[Register ("setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetShouldShowIntroDialog_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetShouldShowIntroDialog (bool p0)
			{
				if (id_setShouldShowIntroDialog_Z == IntPtr.Zero)
					id_setShouldShowIntroDialog_Z = JNIEnv.GetMethodID (class_ref, "setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShouldShowIntroDialog_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldShowIntroDialog", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSuccessDialogEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetSuccessDialogEnabled_ZHandler ()
			{
				if (cb_setSuccessDialogEnabled_Z == null)
					cb_setSuccessDialogEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetSuccessDialogEnabled_Z);
				return cb_setSuccessDialogEnabled_Z;
			}

			static IntPtr n_SetSuccessDialogEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSuccessDialogEnabled (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setSuccessDialogEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setSuccessDialogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSuccessDialogEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetSuccessDialogEnabled_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetSuccessDialogEnabled (bool p0)
			{
				if (id_setSuccessDialogEnabled_Z == IntPtr.Zero)
					id_setSuccessDialogEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSuccessDialogEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSuccessDialogEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccessDialogEnabled", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setSurveysState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetSurveysState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setSurveysState_Lcom_instabug_library_Feature_State_ == null)
					cb_setSurveysState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSurveysState_Lcom_instabug_library_Feature_State_);
				return cb_setSurveysState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetSurveysState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSurveysState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setSurveysState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setSurveysState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setSurveysState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetSurveysState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetSurveysState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setSurveysState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setSurveysState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setSurveysState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSurveysState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurveysState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setTheme_Lcom_instabug_library_InstabugColorTheme_;
#pragma warning disable 0169
			static Delegate GetSetTheme_Lcom_instabug_library_InstabugColorTheme_Handler ()
			{
				if (cb_setTheme_Lcom_instabug_library_InstabugColorTheme_ == null)
					cb_setTheme_Lcom_instabug_library_InstabugColorTheme_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTheme_Lcom_instabug_library_InstabugColorTheme_);
				return cb_setTheme_Lcom_instabug_library_InstabugColorTheme_;
			}

			static IntPtr n_SetTheme_Lcom_instabug_library_InstabugColorTheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.InstabugColorTheme p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugColorTheme> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTheme (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setTheme_Lcom_instabug_library_InstabugColorTheme_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugColorTheme']]"
			[Register ("setTheme", "(Lcom/instabug/library/InstabugColorTheme;)Lcom/instabug/library/Instabug$Builder;", "GetSetTheme_Lcom_instabug_library_InstabugColorTheme_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetTheme (global::Com.Instabug.Library.InstabugColorTheme p0)
			{
				if (id_setTheme_Lcom_instabug_library_InstabugColorTheme_ == IntPtr.Zero)
					id_setTheme_Lcom_instabug_library_InstabugColorTheme_ = JNIEnv.GetMethodID (class_ref, "setTheme", "(Lcom/instabug/library/InstabugColorTheme;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTheme_Lcom_instabug_library_InstabugColorTheme_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTheme", "(Lcom/instabug/library/InstabugColorTheme;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTrackingUserStepsState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackingUserStepsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUserDataState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserDataState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setUserEventsState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetUserEventsState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setUserEventsState_Lcom_instabug_library_Feature_State_ == null)
					cb_setUserEventsState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUserEventsState_Lcom_instabug_library_Feature_State_);
				return cb_setUserEventsState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetUserEventsState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUserEventsState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setUserEventsState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setUserEventsState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setUserEventsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetUserEventsState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetUserEventsState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setUserEventsState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setUserEventsState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setUserEventsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUserEventsState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserEventsState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setViewHierarchyState_Lcom_instabug_library_Feature_State_;
#pragma warning disable 0169
			static Delegate GetSetViewHierarchyState_Lcom_instabug_library_Feature_State_Handler ()
			{
				if (cb_setViewHierarchyState_Lcom_instabug_library_Feature_State_ == null)
					cb_setViewHierarchyState_Lcom_instabug_library_Feature_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetViewHierarchyState_Lcom_instabug_library_Feature_State_);
				return cb_setViewHierarchyState_Lcom_instabug_library_Feature_State_;
			}

			static IntPtr n_SetViewHierarchyState_Lcom_instabug_library_Feature_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Instabug.Library.Feature.State p0 = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Feature.State> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetViewHierarchyState (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setViewHierarchyState_Lcom_instabug_library_Feature_State_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setViewHierarchyState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.Feature.State']]"
			[Register ("setViewHierarchyState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;", "GetSetViewHierarchyState_Lcom_instabug_library_Feature_State_Handler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetViewHierarchyState (global::Com.Instabug.Library.Feature.State p0)
			{
				if (id_setViewHierarchyState_Lcom_instabug_library_Feature_State_ == IntPtr.Zero)
					id_setViewHierarchyState_Lcom_instabug_library_Feature_State_ = JNIEnv.GetMethodID (class_ref, "setViewHierarchyState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Instabug.Library.Instabug.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setViewHierarchyState_Lcom_instabug_library_Feature_State_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setViewHierarchyState", "(Lcom/instabug/library/Feature$State;)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setWillSkipScreenshotAnnotation_Z;
#pragma warning disable 0169
			static Delegate GetSetWillSkipScreenshotAnnotation_ZHandler ()
			{
				if (cb_setWillSkipScreenshotAnnotation_Z == null)
					cb_setWillSkipScreenshotAnnotation_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWillSkipScreenshotAnnotation_Z);
				return cb_setWillSkipScreenshotAnnotation_Z;
			}

			static IntPtr n_SetWillSkipScreenshotAnnotation_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Instabug.Library.Instabug.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetWillSkipScreenshotAnnotation (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setWillSkipScreenshotAnnotation_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug.Builder']/method[@name='setWillSkipScreenshotAnnotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWillSkipScreenshotAnnotation", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetWillSkipScreenshotAnnotation_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetWillSkipScreenshotAnnotation (bool p0)
			{
				if (id_setWillSkipScreenshotAnnotation_Z == IntPtr.Zero)
					id_setWillSkipScreenshotAnnotation_Z = JNIEnv.GetMethodID (class_ref, "setWillSkipScreenshotAnnotation", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWillSkipScreenshotAnnotation_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillSkipScreenshotAnnotation", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			[Obsolete (@"deprecated")]
			[Register ("setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;", "GetSetWillTakeScreenshot_ZHandler")]
			public virtual unsafe global::Com.Instabug.Library.Instabug.Builder SetWillTakeScreenshot (bool p0)
			{
				if (id_setWillTakeScreenshot_Z == IntPtr.Zero)
					id_setWillTakeScreenshot_Z = JNIEnv.GetMethodID (class_ref, "setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWillTakeScreenshot_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Instabug.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillTakeScreenshot", "(Z)Lcom/instabug/library/Instabug$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr id_getAllUserAttributes;
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> AllUserAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getAllUserAttributes' and count(parameter)=0]"
			[Register ("getAllUserAttributes", "()Ljava/util/HashMap;", "GetGetAllUserAttributesHandler")]
			get {
				if (id_getAllUserAttributes == IntPtr.Zero)
					id_getAllUserAttributes = JNIEnv.GetStaticMethodID (class_ref, "getAllUserAttributes", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAllUserAttributes), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

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

		static IntPtr id_getApplication;
		public static unsafe global::Android.App.Application Application {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getApplication' and count(parameter)=0]"
			[Register ("getApplication", "()Landroid/app/Application;", "GetGetApplicationHandler")]
			get {
				if (id_getApplication == IntPtr.Zero)
					id_getApplication = JNIEnv.GetStaticMethodID (class_ref, "getApplication", "()Landroid/app/Application;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.Application> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplication), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getColorTheme;
		[Obsolete (@"deprecated")]
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

		static IntPtr id_getInstabugState;
		static IntPtr id_setInstabugState_Lcom_instabug_library_InstabugState_;
		public static unsafe global::Com.Instabug.Library.InstabugState InstabugState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getInstabugState' and count(parameter)=0]"
			[Register ("getInstabugState", "()Lcom/instabug/library/InstabugState;", "GetGetInstabugStateHandler")]
			get {
				if (id_getInstabugState == IntPtr.Zero)
					id_getInstabugState = JNIEnv.GetStaticMethodID (class_ref, "getInstabugState", "()Lcom/instabug/library/InstabugState;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstabugState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setInstabugState' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugState']]"
			[Register ("setInstabugState", "(Lcom/instabug/library/InstabugState;)V", "GetSetInstabugState_Lcom_instabug_library_InstabugState_Handler")]
			set {
				if (id_setInstabugState_Lcom_instabug_library_InstabugState_ == IntPtr.Zero)
					id_setInstabugState_Lcom_instabug_library_InstabugState_ = JNIEnv.GetStaticMethodID (class_ref, "setInstabugState", "(Lcom/instabug/library/InstabugState;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstabugState_Lcom_instabug_library_InstabugState_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isCommentFieldRequired;
		public static unsafe bool IsCommentFieldRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isCommentFieldRequired' and count(parameter)=0]"
			[Register ("isCommentFieldRequired", "()Z", "GetIsCommentFieldRequiredHandler")]
			get {
				if (id_isCommentFieldRequired == IntPtr.Zero)
					id_isCommentFieldRequired = JNIEnv.GetStaticMethodID (class_ref, "isCommentFieldRequired", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCommentFieldRequired);
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

		static IntPtr id_getTags;
		public static unsafe global::System.Collections.Generic.IList<string> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/ArrayList;", "GetGetTagsHandler")]
			get {
				if (id_getTags == IntPtr.Zero)
					id_getTags = JNIEnv.GetStaticMethodID (class_ref, "getTags", "()Ljava/util/ArrayList;");
				try {
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTags), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTheme;
		public static unsafe global::Com.Instabug.Library.InstabugColorTheme Theme {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getTheme' and count(parameter)=0]"
			[Register ("getTheme", "()Lcom/instabug/library/InstabugColorTheme;", "GetGetThemeHandler")]
			get {
				if (id_getTheme == IntPtr.Zero)
					id_getTheme = JNIEnv.GetStaticMethodID (class_ref, "getTheme", "()Lcom/instabug/library/InstabugColorTheme;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugColorTheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTheme), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUnreadMessagesCount;
		public static unsafe int UnreadMessagesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getUnreadMessagesCount' and count(parameter)=0]"
			[Register ("getUnreadMessagesCount", "()I", "GetGetUnreadMessagesCountHandler")]
			get {
				if (id_getUnreadMessagesCount == IntPtr.Zero)
					id_getUnreadMessagesCount = JNIEnv.GetStaticMethodID (class_ref, "getUnreadMessagesCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getUnreadMessagesCount);
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

		static IntPtr id_addCapturableView_Lcom_instabug_library_internal_layer_CapturableView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='addCapturableView' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.CapturableView']]"
		[Obsolete (@"deprecated")]
		[Register ("addCapturableView", "(Lcom/instabug/library/internal/layer/CapturableView;)V", "")]
		public static unsafe void AddCapturableView (global::Com.Instabug.Library.Internal.Layer.ICapturableView p0)
		{
			if (id_addCapturableView_Lcom_instabug_library_internal_layer_CapturableView_ == IntPtr.Zero)
				id_addCapturableView_Lcom_instabug_library_internal_layer_CapturableView_ = JNIEnv.GetStaticMethodID (class_ref, "addCapturableView", "(Lcom/instabug/library/internal/layer/CapturableView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addCapturableView_Lcom_instabug_library_internal_layer_CapturableView_, __args);
			} finally {
			}
		}

		static IntPtr id_addFileAttachment_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='addFileAttachment' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String']]"
		[Register ("addFileAttachment", "(Landroid/net/Uri;Ljava/lang/String;)V", "")]
		public static unsafe void AddFileAttachment (global::Android.Net.Uri p0, string p1)
		{
			if (id_addFileAttachment_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_addFileAttachment_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addFileAttachment", "(Landroid/net/Uri;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addFileAttachment_Landroid_net_Uri_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addMapView_Landroid_view_View_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='addMapView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Obsolete (@"deprecated")]
		[Register ("addMapView", "(Landroid/view/View;Ljava/lang/Object;)V", "")]
		public static unsafe void AddMapView (global::Android.Views.View p0, global::Java.Lang.Object p1)
		{
			if (id_addMapView_Landroid_view_View_Ljava_lang_Object_ == IntPtr.Zero)
				id_addMapView_Landroid_view_View_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "addMapView", "(Landroid/view/View;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addMapView_Landroid_view_View_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_addTags_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='addTags' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("addTags", "([Ljava/lang/String;)V", "")]
		public static unsafe void AddTags (params  string[] p0)
		{
			if (id_addTags_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addTags_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addTags", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addTags_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_changeInvocationEvent_Lcom_instabug_library_IBGInvocationEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='changeInvocationEvent' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGInvocationEvent']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_changeInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='changeInvocationEvent' and count(parameter)=1 and parameter[1][@type='com.instabug.library.invocation.InstabugInvocationEvent']]"
		[Register ("changeInvocationEvent", "(Lcom/instabug/library/invocation/InstabugInvocationEvent;)V", "")]
		public static unsafe void ChangeInvocationEvent (global::Com.Instabug.Library.Invocation.InstabugInvocationEvent p0)
		{
			if (id_changeInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ == IntPtr.Zero)
				id_changeInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_ = JNIEnv.GetStaticMethodID (class_ref, "changeInvocationEvent", "(Lcom/instabug/library/invocation/InstabugInvocationEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_changeInvocationEvent_Lcom_instabug_library_invocation_InstabugInvocationEvent_, __args);
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

		static IntPtr id_clearAllUserAttributes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='clearAllUserAttributes' and count(parameter)=0]"
		[Register ("clearAllUserAttributes", "()V", "")]
		public static unsafe void ClearAllUserAttributes ()
		{
			if (id_clearAllUserAttributes == IntPtr.Zero)
				id_clearAllUserAttributes = JNIEnv.GetStaticMethodID (class_ref, "clearAllUserAttributes", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAllUserAttributes);
			} finally {
			}
		}

		static IntPtr id_clearFileAttachment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='clearFileAttachment' and count(parameter)=0]"
		[Register ("clearFileAttachment", "()V", "")]
		public static unsafe void ClearFileAttachment ()
		{
			if (id_clearFileAttachment == IntPtr.Zero)
				id_clearFileAttachment = JNIEnv.GetStaticMethodID (class_ref, "clearFileAttachment", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearFileAttachment);
			} finally {
			}
		}

		static IntPtr id_clearLog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='clearLog' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_getLocale_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getLocale' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLocale", "(Landroid/content/Context;)Ljava/util/Locale;", "")]
		public static unsafe global::Java.Util.Locale GetLocale (global::Android.Content.Context p0)
		{
			if (id_getLocale_Landroid_content_Context_ == IntPtr.Zero)
				id_getLocale_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLocale", "(Landroid/content/Context;)Ljava/util/Locale;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Util.Locale __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocale_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='getUserAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserAttribute", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAttribute (string p0)
		{
			if (id_getUserAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserAttribute_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getUserAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserAttribute_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_identifyUser_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='identifyUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("identifyUser", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void IdentifyUser (string p0, string p1)
		{
			if (id_identifyUser_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_identifyUser_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "identifyUser", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_identifyUser_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
		[Obsolete (@"deprecated")]
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

		static IntPtr id_invoke_Lcom_instabug_library_invocation_InstabugInvocationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='invoke' and count(parameter)=1 and parameter[1][@type='com.instabug.library.invocation.InstabugInvocationMode']]"
		[Register ("invoke", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)V", "")]
		public static unsafe void Invoke (global::Com.Instabug.Library.Invocation.InstabugInvocationMode p0)
		{
			if (id_invoke_Lcom_instabug_library_invocation_InstabugInvocationMode_ == IntPtr.Zero)
				id_invoke_Lcom_instabug_library_invocation_InstabugInvocationMode_ = JNIEnv.GetStaticMethodID (class_ref, "invoke", "(Lcom/instabug/library/invocation/InstabugInvocationMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invoke_Lcom_instabug_library_invocation_InstabugInvocationMode_, __args);
			} finally {
			}
		}

		static IntPtr id_invokeConversations;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='invokeConversations' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("invokeConversations", "()V", "")]
		public static unsafe void InvokeConversations ()
		{
			if (id_invokeConversations == IntPtr.Zero)
				id_invokeConversations = JNIEnv.GetStaticMethodID (class_ref, "invokeConversations", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_invokeConversations);
			} finally {
			}
		}

		static IntPtr id_isInstabugNotification_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isInstabugNotification' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("isInstabugNotification", "(Landroid/os/Bundle;)Z", "")]
		public static unsafe bool IsInstabugNotification (global::Android.OS.Bundle p0)
		{
			if (id_isInstabugNotification_Landroid_os_Bundle_ == IntPtr.Zero)
				id_isInstabugNotification_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "isInstabugNotification", "(Landroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInstabugNotification_Landroid_os_Bundle_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isInstabugNotification_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='isInstabugNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("isInstabugNotification", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool IsInstabugNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_isInstabugNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_isInstabugNotification_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "isInstabugNotification", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInstabugNotification_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_log_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_logUserEvent_Ljava_lang_String_arrayLcom_instabug_library_user_UserEventParam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='logUserEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.instabug.library.user.UserEventParam...']]"
		[Register ("logUserEvent", "(Ljava/lang/String;[Lcom/instabug/library/user/UserEventParam;)V", "")]
		public static unsafe void LogUserEvent (string p0, params global:: Com.Instabug.Library.User.UserEventParam[] p1)
		{
			if (id_logUserEvent_Ljava_lang_String_arrayLcom_instabug_library_user_UserEventParam_ == IntPtr.Zero)
				id_logUserEvent_Ljava_lang_String_arrayLcom_instabug_library_user_UserEventParam_ = JNIEnv.GetStaticMethodID (class_ref, "logUserEvent", "(Ljava/lang/String;[Lcom/instabug/library/user/UserEventParam;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logUserEvent_Ljava_lang_String_arrayLcom_instabug_library_user_UserEventParam_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_logoutUser;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='logoutUser' and count(parameter)=0]"
		[Register ("logoutUser", "()V", "")]
		public static unsafe void LogoutUser ()
		{
			if (id_logoutUser == IntPtr.Zero)
				id_logoutUser = JNIEnv.GetStaticMethodID (class_ref, "logoutUser", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logoutUser);
			} finally {
			}
		}

		static IntPtr id_removeUserAttribute_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='removeUserAttribute' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeUserAttribute", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveUserAttribute (string p0)
		{
			if (id_removeUserAttribute_Ljava_lang_String_ == IntPtr.Zero)
				id_removeUserAttribute_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeUserAttribute", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeUserAttribute_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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

		static IntPtr id_resetTags;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='resetTags' and count(parameter)=0]"
		[Register ("resetTags", "()V", "")]
		public static unsafe void ResetTags ()
		{
			if (id_resetTags == IntPtr.Zero)
				id_resetTags = JNIEnv.GetStaticMethodID (class_ref, "resetTags", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resetTags);
			} finally {
			}
		}

		static IntPtr id_setAttachmentTypesEnabled_ZZZZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setAttachmentTypesEnabled' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("setAttachmentTypesEnabled", "(ZZZZZ)V", "")]
		public static unsafe void SetAttachmentTypesEnabled (bool p0, bool p1, bool p2, bool p3, bool p4)
		{
			if (id_setAttachmentTypesEnabled_ZZZZZ == IntPtr.Zero)
				id_setAttachmentTypesEnabled_ZZZZZ = JNIEnv.GetStaticMethodID (class_ref, "setAttachmentTypesEnabled", "(ZZZZZ)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAttachmentTypesEnabled_ZZZZZ, __args);
			} finally {
			}
		}

		static IntPtr id_setBugCategories_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setBugCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.instabug.library.model.BugCategory&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("setBugCategories", "(Ljava/util/List;)V", "")]
		public static unsafe void SetBugCategories (global::System.Collections.Generic.IList<global::Com.Instabug.Library.Model.BugCategory> p0)
		{
			if (id_setBugCategories_Ljava_util_List_ == IntPtr.Zero)
				id_setBugCategories_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "setBugCategories", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Model.BugCategory>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setBugCategories_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setChatNotificationEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setChatNotificationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setChatNotificationEnabled", "(Z)V", "")]
		public static unsafe void SetChatNotificationEnabled (bool p0)
		{
			if (id_setChatNotificationEnabled_Z == IntPtr.Zero)
				id_setChatNotificationEnabled_Z = JNIEnv.GetStaticMethodID (class_ref, "setChatNotificationEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setChatNotificationEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomTextPlaceHolders_Lcom_instabug_library_IBGCustomTextPlaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setCustomTextPlaceHolders' and count(parameter)=1 and parameter[1][@type='com.instabug.library.IBGCustomTextPlaceHolder']]"
		[Obsolete (@"deprecated")]
		[Register ("setCustomTextPlaceHolders", "(Lcom/instabug/library/IBGCustomTextPlaceHolder;)V", "")]
		public static unsafe void SetCustomTextPlaceHolders (global::Com.Instabug.Library.IBGCustomTextPlaceHolder p0)
		{
			if (id_setCustomTextPlaceHolders_Lcom_instabug_library_IBGCustomTextPlaceHolder_ == IntPtr.Zero)
				id_setCustomTextPlaceHolders_Lcom_instabug_library_IBGCustomTextPlaceHolder_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomTextPlaceHolders", "(Lcom/instabug/library/IBGCustomTextPlaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomTextPlaceHolders_Lcom_instabug_library_IBGCustomTextPlaceHolder_, __args);
			} finally {
			}
		}

		static IntPtr id_setCustomTextPlaceHolders_Lcom_instabug_library_InstabugCustomTextPlaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setCustomTextPlaceHolders' and count(parameter)=1 and parameter[1][@type='com.instabug.library.InstabugCustomTextPlaceHolder']]"
		[Register ("setCustomTextPlaceHolders", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder;)V", "")]
		public static unsafe void SetCustomTextPlaceHolders (global::Com.Instabug.Library.InstabugCustomTextPlaceHolder p0)
		{
			if (id_setCustomTextPlaceHolders_Lcom_instabug_library_InstabugCustomTextPlaceHolder_ == IntPtr.Zero)
				id_setCustomTextPlaceHolders_Lcom_instabug_library_InstabugCustomTextPlaceHolder_ = JNIEnv.GetStaticMethodID (class_ref, "setCustomTextPlaceHolders", "(Lcom/instabug/library/InstabugCustomTextPlaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCustomTextPlaceHolders_Lcom_instabug_library_InstabugCustomTextPlaceHolder_, __args);
			} finally {
			}
		}

		static IntPtr id_setDebugEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setDebugEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugEnabled", "(Z)V", "")]
		public static unsafe void SetDebugEnabled (bool p0)
		{
			if (id_setDebugEnabled_Z == IntPtr.Zero)
				id_setDebugEnabled_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugEnabled_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDialog_Landroid_app_Dialog_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setDialog' and count(parameter)=1 and parameter[1][@type='android.app.Dialog']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_setFileAttachment_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setFileAttachment' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setFileAttachment", "(Landroid/net/Uri;Ljava/lang/String;)V", "")]
		public static unsafe void SetFileAttachment (global::Android.Net.Uri p0, string p1)
		{
			if (id_setFileAttachment_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_setFileAttachment_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setFileAttachment", "(Landroid/net/Uri;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setFileAttachment_Landroid_net_Uri_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setGLSurfaceView' and count(parameter)=1 and parameter[1][@type='android.opengl.GLSurfaceView']]"
		[Obsolete (@"deprecated")]
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

		static IntPtr id_setNewMessageHandler_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setNewMessageHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setNewMessageHandler", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void SetNewMessageHandler (global::Java.Lang.IRunnable p0)
		{
			if (id_setNewMessageHandler_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setNewMessageHandler_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setNewMessageHandler", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setNewMessageHandler_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_setOnSdkInvokedCallback_Lcom_instabug_library_OnSdkInvokedCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setOnSdkInvokedCallback' and count(parameter)=1 and parameter[1][@type='com.instabug.library.OnSdkInvokedCallback']]"
		[Register ("setOnSdkInvokedCallback", "(Lcom/instabug/library/OnSdkInvokedCallback;)V", "")]
		public static unsafe void SetOnSdkInvokedCallback (global::Com.Instabug.Library.IOnSdkInvokedCallback p0)
		{
			if (id_setOnSdkInvokedCallback_Lcom_instabug_library_OnSdkInvokedCallback_ == IntPtr.Zero)
				id_setOnSdkInvokedCallback_Lcom_instabug_library_OnSdkInvokedCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setOnSdkInvokedCallback", "(Lcom/instabug/library/OnSdkInvokedCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setOnSdkInvokedCallback_Lcom_instabug_library_OnSdkInvokedCallback_, __args);
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

		static IntPtr id_setPushNotificationRegistrationToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setPushNotificationRegistrationToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPushNotificationRegistrationToken", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetPushNotificationRegistrationToken (string p0)
		{
			if (id_setPushNotificationRegistrationToken_Ljava_lang_String_ == IntPtr.Zero)
				id_setPushNotificationRegistrationToken_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setPushNotificationRegistrationToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPushNotificationRegistrationToken_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setReportCategories_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setReportCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.instabug.library.bugreporting.model.ReportCategory&gt;']]"
		[Register ("setReportCategories", "(Ljava/util/List;)V", "")]
		public static unsafe void SetReportCategories (global::System.Collections.Generic.IList<global::Com.Instabug.Library.Bugreporting.Model.ReportCategory> p0)
		{
			if (id_setReportCategories_Ljava_util_List_ == IntPtr.Zero)
				id_setReportCategories_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "setReportCategories", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Instabug.Library.Bugreporting.Model.ReportCategory>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setReportCategories_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setShouldAudioRecordingOptionAppear_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setShouldAudioRecordingOptionAppear' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldAudioRecordingOptionAppear", "(Z)V", "")]
		public static unsafe void SetShouldAudioRecordingOptionAppear (bool p0)
		{
			if (id_setShouldAudioRecordingOptionAppear_Z == IntPtr.Zero)
				id_setShouldAudioRecordingOptionAppear_Z = JNIEnv.GetStaticMethodID (class_ref, "setShouldAudioRecordingOptionAppear", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setShouldAudioRecordingOptionAppear_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setUserAttribute_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='setUserAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUserAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetUserAttribute (string p0, string p1)
		{
			if (id_setUserAttribute_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserAttribute_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setUserAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setUserAttribute_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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

		static IntPtr id_showNotification_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='showNotification' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("showNotification", "(Landroid/os/Bundle;)V", "")]
		public static unsafe void ShowNotification (global::Android.OS.Bundle p0)
		{
			if (id_showNotification_Landroid_os_Bundle_ == IntPtr.Zero)
				id_showNotification_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "showNotification", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showNotification_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_showNotification_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='Instabug']/method[@name='showNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("showNotification", "(Ljava/util/Map;)V", "")]
		public static unsafe void ShowNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_showNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_showNotification_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "showNotification", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showNotification_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
