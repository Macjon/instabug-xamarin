using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='BufferLogSink']"
	[global::Android.Runtime.Register ("org/jcodec/common/logging/BufferLogSink", DoNotGenerateAcw=true)]
	public partial class BufferLogSink : global::Java.Lang.Object, global::Org.Jcodec.Common.Logging.Logger.ILogSink {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/logging/BufferLogSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferLogSink); }
		}

		protected BufferLogSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='BufferLogSink']/constructor[@name='BufferLogSink' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BufferLogSink ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BufferLogSink)) {
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

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Logging.BufferLogSink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.BufferLogSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Common.Logging.Logger.Message>.ToLocalJniHandle (__this.Messages);
		}
#pragma warning restore 0169

		static IntPtr id_getMessages;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Common.Logging.Logger.Message> Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='BufferLogSink']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/util/List;", "GetGetMessagesHandler")]
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Common.Logging.Logger.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Common.Logging.Logger.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_postMessage_Lorg_jcodec_common_logging_Logger_Message_;
#pragma warning disable 0169
		static Delegate GetPostMessage_Lorg_jcodec_common_logging_Logger_Message_Handler ()
		{
			if (cb_postMessage_Lorg_jcodec_common_logging_Logger_Message_ == null)
				cb_postMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostMessage_Lorg_jcodec_common_logging_Logger_Message_);
			return cb_postMessage_Lorg_jcodec_common_logging_Logger_Message_;
		}

		static void n_PostMessage_Lorg_jcodec_common_logging_Logger_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Logging.BufferLogSink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.BufferLogSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Logging.Logger.Message p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postMessage_Lorg_jcodec_common_logging_Logger_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='BufferLogSink']/method[@name='postMessage' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.Message']]"
		[Register ("postMessage", "(Lorg/jcodec/common/logging/Logger$Message;)V", "GetPostMessage_Lorg_jcodec_common_logging_Logger_Message_Handler")]
		public virtual unsafe void PostMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0)
		{
			if (id_postMessage_Lorg_jcodec_common_logging_Logger_Message_ == IntPtr.Zero)
				id_postMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNIEnv.GetMethodID (class_ref, "postMessage", "(Lorg/jcodec/common/logging/Logger$Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postMessage_Lorg_jcodec_common_logging_Logger_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postMessage", "(Lorg/jcodec/common/logging/Logger$Message;)V"), __args);
			} finally {
			}
		}

	}
}
