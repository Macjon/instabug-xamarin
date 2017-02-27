using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']"
	[global::Android.Runtime.Register ("org/jcodec/common/logging/OutLogSink", DoNotGenerateAcw=true)]
	public partial class OutLogSink : global::Java.Lang.Object, global::Org.Jcodec.Common.Logging.Logger.ILogSink {


		static IntPtr DEFAULT_FORMAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']/field[@name='DEFAULT_FORMAT']"
		[Register ("DEFAULT_FORMAT")]
		public static global::Org.Jcodec.Common.Logging.OutLogSink.SimpleFormat DefaultFormat {
			get {
				if (DEFAULT_FORMAT_jfieldId == IntPtr.Zero)
					DEFAULT_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_FORMAT", "Lorg/jcodec/common/logging/OutLogSink$SimpleFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_FORMAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.OutLogSink.SimpleFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_FORMAT_jfieldId == IntPtr.Zero)
					DEFAULT_FORMAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_FORMAT", "Lorg/jcodec/common/logging/OutLogSink$SimpleFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, DEFAULT_FORMAT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.common.logging']/interface[@name='OutLogSink.MessageFormat']"
		[Register ("org/jcodec/common/logging/OutLogSink$MessageFormat", "", "Org.Jcodec.Common.Logging.OutLogSink/IMessageFormatInvoker")]
		public partial interface IMessageFormat : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/interface[@name='OutLogSink.MessageFormat']/method[@name='formatMessage' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.Message']]"
			[Register ("formatMessage", "(Lorg/jcodec/common/logging/Logger$Message;)Ljava/lang/String;", "GetFormatMessage_Lorg_jcodec_common_logging_Logger_Message_Handler:Org.Jcodec.Common.Logging.OutLogSink/IMessageFormatInvoker, InstabugAndroidSDK")]
			string FormatMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0);

		}

		[global::Android.Runtime.Register ("org/jcodec/common/logging/OutLogSink$MessageFormat", DoNotGenerateAcw=true)]
		internal class IMessageFormatInvoker : global::Java.Lang.Object, IMessageFormat {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/common/logging/OutLogSink$MessageFormat");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMessageFormatInvoker); }
			}

			IntPtr class_ref;

			public static IMessageFormat GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMessageFormat> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.common.logging.OutLogSink.MessageFormat"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMessageFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
#pragma warning disable 0169
			static Delegate GetFormatMessage_Lorg_jcodec_common_logging_Logger_Message_Handler ()
			{
				if (cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ == null)
					cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FormatMessage_Lorg_jcodec_common_logging_Logger_Message_);
				return cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
			}

			static IntPtr n_FormatMessage_Lorg_jcodec_common_logging_Logger_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Common.Logging.OutLogSink.IMessageFormat __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.OutLogSink.IMessageFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Logging.Logger.Message p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.FormatMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
			public unsafe string FormatMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0)
			{
				if (id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ == IntPtr.Zero)
					id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNIEnv.GetMethodID (class_ref, "formatMessage", "(Lorg/jcodec/common/logging/Logger$Message;)Ljava/lang/String;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink.SimpleFormat']"
		[global::Android.Runtime.Register ("org/jcodec/common/logging/OutLogSink$SimpleFormat", DoNotGenerateAcw=true)]
		public partial class SimpleFormat : global::Java.Lang.Object, global::Org.Jcodec.Common.Logging.OutLogSink.IMessageFormat {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/common/logging/OutLogSink$SimpleFormat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SimpleFormat); }
			}

			protected SimpleFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink.SimpleFormat']/constructor[@name='OutLogSink.SimpleFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe SimpleFormat (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (SimpleFormat)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
#pragma warning disable 0169
			static Delegate GetFormatMessage_Lorg_jcodec_common_logging_Logger_Message_Handler ()
			{
				if (cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ == null)
					cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FormatMessage_Lorg_jcodec_common_logging_Logger_Message_);
				return cb_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
			}

			static IntPtr n_FormatMessage_Lorg_jcodec_common_logging_Logger_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Common.Logging.OutLogSink.SimpleFormat __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.OutLogSink.SimpleFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Logging.Logger.Message p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.FormatMessage (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink.SimpleFormat']/method[@name='formatMessage' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.Message']]"
			[Register ("formatMessage", "(Lorg/jcodec/common/logging/Logger$Message;)Ljava/lang/String;", "GetFormatMessage_Lorg_jcodec_common_logging_Logger_Message_Handler")]
			public virtual unsafe string FormatMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0)
			{
				if (id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ == IntPtr.Zero)
					id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNIEnv.GetMethodID (class_ref, "formatMessage", "(Lorg/jcodec/common/logging/Logger$Message;)Ljava/lang/String;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_formatMessage_Lorg_jcodec_common_logging_Logger_Message_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "formatMessage", "(Lorg/jcodec/common/logging/Logger$Message;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/logging/OutLogSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutLogSink); }
		}

		protected OutLogSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_PrintStream_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']/constructor[@name='OutLogSink' and count(parameter)=2 and parameter[1][@type='java.io.PrintStream'] and parameter[2][@type='org.jcodec.common.logging.OutLogSink.MessageFormat']]"
		[Register (".ctor", "(Ljava/io/PrintStream;Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", "")]
		public unsafe OutLogSink (global::Java.IO.PrintStream p0, global::Org.Jcodec.Common.Logging.OutLogSink.IMessageFormat p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (OutLogSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/PrintStream;Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/PrintStream;Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_PrintStream_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_ == IntPtr.Zero)
					id_ctor_Ljava_io_PrintStream_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/PrintStream;Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_PrintStream_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_PrintStream_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']/constructor[@name='OutLogSink' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.OutLogSink.MessageFormat']]"
		[Register (".ctor", "(Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", "")]
		public unsafe OutLogSink (global::Org.Jcodec.Common.Logging.OutLogSink.IMessageFormat p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (OutLogSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/logging/OutLogSink$MessageFormat;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_logging_OutLogSink_MessageFormat_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']/constructor[@name='OutLogSink' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutLogSink ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OutLogSink)) {
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
			global::Org.Jcodec.Common.Logging.OutLogSink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.OutLogSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Logging.Logger.Message p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postMessage_Lorg_jcodec_common_logging_Logger_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='OutLogSink']/method[@name='postMessage' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.Message']]"
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
