using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Invocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']"
	[global::Android.Runtime.Register ("com/instabug/library/invocation/PromptOptions", DoNotGenerateAcw=true)]
	public partial class PromptOptions : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/invocation/PromptOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PromptOptions); }
		}

		protected PromptOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/constructor[@name='PromptOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PromptOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PromptOptions)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static IntPtr id_ctor_ZZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/constructor[@name='PromptOptions' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(ZZZ)V", "")]
		public unsafe PromptOptions (bool p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PromptOptions)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ZZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZZZ)V", __args);
					return;
				}

				if (id_ctor_ZZZ == IntPtr.Zero)
					id_ctor_ZZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZZZ, __args);
			} finally {
			}
		}

		static Delegate cb_getWillShowGeneralFeedback;
#pragma warning disable 0169
		static Delegate GetGetWillShowGeneralFeedbackHandler ()
		{
			if (cb_getWillShowGeneralFeedback == null)
				cb_getWillShowGeneralFeedback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWillShowGeneralFeedback);
			return cb_getWillShowGeneralFeedback;
		}

		static bool n_GetWillShowGeneralFeedback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WillShowGeneralFeedback;
		}
#pragma warning restore 0169

		static IntPtr id_getWillShowGeneralFeedback;
		public virtual unsafe bool WillShowGeneralFeedback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='getWillShowGeneralFeedback' and count(parameter)=0]"
			[Register ("getWillShowGeneralFeedback", "()Z", "GetGetWillShowGeneralFeedbackHandler")]
			get {
				if (id_getWillShowGeneralFeedback == IntPtr.Zero)
					id_getWillShowGeneralFeedback = JNIEnv.GetMethodID (class_ref, "getWillShowGeneralFeedback", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getWillShowGeneralFeedback);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWillShowGeneralFeedback", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getWillShowReportProblem;
#pragma warning disable 0169
		static Delegate GetGetWillShowReportProblemHandler ()
		{
			if (cb_getWillShowReportProblem == null)
				cb_getWillShowReportProblem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWillShowReportProblem);
			return cb_getWillShowReportProblem;
		}

		static bool n_GetWillShowReportProblem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WillShowReportProblem;
		}
#pragma warning restore 0169

		static IntPtr id_getWillShowReportProblem;
		public virtual unsafe bool WillShowReportProblem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='getWillShowReportProblem' and count(parameter)=0]"
			[Register ("getWillShowReportProblem", "()Z", "GetGetWillShowReportProblemHandler")]
			get {
				if (id_getWillShowReportProblem == IntPtr.Zero)
					id_getWillShowReportProblem = JNIEnv.GetMethodID (class_ref, "getWillShowReportProblem", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getWillShowReportProblem);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWillShowReportProblem", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getWillShowTalkToUs;
#pragma warning disable 0169
		static Delegate GetGetWillShowTalkToUsHandler ()
		{
			if (cb_getWillShowTalkToUs == null)
				cb_getWillShowTalkToUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWillShowTalkToUs);
			return cb_getWillShowTalkToUs;
		}

		static bool n_GetWillShowTalkToUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WillShowTalkToUs;
		}
#pragma warning restore 0169

		static IntPtr id_getWillShowTalkToUs;
		public virtual unsafe bool WillShowTalkToUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='getWillShowTalkToUs' and count(parameter)=0]"
			[Register ("getWillShowTalkToUs", "()Z", "GetGetWillShowTalkToUsHandler")]
			get {
				if (id_getWillShowTalkToUs == IntPtr.Zero)
					id_getWillShowTalkToUs = JNIEnv.GetMethodID (class_ref, "getWillShowTalkToUs", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getWillShowTalkToUs);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWillShowTalkToUs", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_setWillShowGeneralFeedback_Z;
#pragma warning disable 0169
		static Delegate GetSetWillShowGeneralFeedback_ZHandler ()
		{
			if (cb_setWillShowGeneralFeedback_Z == null)
				cb_setWillShowGeneralFeedback_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWillShowGeneralFeedback_Z);
			return cb_setWillShowGeneralFeedback_Z;
		}

		static IntPtr n_SetWillShowGeneralFeedback_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetWillShowGeneralFeedback (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setWillShowGeneralFeedback_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='setWillShowGeneralFeedback' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWillShowGeneralFeedback", "(Z)Lcom/instabug/library/invocation/PromptOptions;", "GetSetWillShowGeneralFeedback_ZHandler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.PromptOptions SetWillShowGeneralFeedback (bool p0)
		{
			if (id_setWillShowGeneralFeedback_Z == IntPtr.Zero)
				id_setWillShowGeneralFeedback_Z = JNIEnv.GetMethodID (class_ref, "setWillShowGeneralFeedback", "(Z)Lcom/instabug/library/invocation/PromptOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWillShowGeneralFeedback_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillShowGeneralFeedback", "(Z)Lcom/instabug/library/invocation/PromptOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setWillShowReportProblem_Z;
#pragma warning disable 0169
		static Delegate GetSetWillShowReportProblem_ZHandler ()
		{
			if (cb_setWillShowReportProblem_Z == null)
				cb_setWillShowReportProblem_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWillShowReportProblem_Z);
			return cb_setWillShowReportProblem_Z;
		}

		static IntPtr n_SetWillShowReportProblem_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetWillShowReportProblem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setWillShowReportProblem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='setWillShowReportProblem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWillShowReportProblem", "(Z)Lcom/instabug/library/invocation/PromptOptions;", "GetSetWillShowReportProblem_ZHandler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.PromptOptions SetWillShowReportProblem (bool p0)
		{
			if (id_setWillShowReportProblem_Z == IntPtr.Zero)
				id_setWillShowReportProblem_Z = JNIEnv.GetMethodID (class_ref, "setWillShowReportProblem", "(Z)Lcom/instabug/library/invocation/PromptOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWillShowReportProblem_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillShowReportProblem", "(Z)Lcom/instabug/library/invocation/PromptOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setWillShowTalkToUs_Z;
#pragma warning disable 0169
		static Delegate GetSetWillShowTalkToUs_ZHandler ()
		{
			if (cb_setWillShowTalkToUs_Z == null)
				cb_setWillShowTalkToUs_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetWillShowTalkToUs_Z);
			return cb_setWillShowTalkToUs_Z;
		}

		static IntPtr n_SetWillShowTalkToUs_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Instabug.Library.Invocation.PromptOptions __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetWillShowTalkToUs (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setWillShowTalkToUs_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.invocation']/class[@name='PromptOptions']/method[@name='setWillShowTalkToUs' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setWillShowTalkToUs", "(Z)Lcom/instabug/library/invocation/PromptOptions;", "GetSetWillShowTalkToUs_ZHandler")]
		public virtual unsafe global::Com.Instabug.Library.Invocation.PromptOptions SetWillShowTalkToUs (bool p0)
		{
			if (id_setWillShowTalkToUs_Z == IntPtr.Zero)
				id_setWillShowTalkToUs_Z = JNIEnv.GetMethodID (class_ref, "setWillShowTalkToUs", "(Z)Lcom/instabug/library/invocation/PromptOptions;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setWillShowTalkToUs_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Invocation.PromptOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWillShowTalkToUs", "(Z)Lcom/instabug/library/invocation/PromptOptions;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
