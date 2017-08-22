using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']"
	[global::Android.Runtime.Register ("org/jcodec/common/logging/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']"
		[global::Android.Runtime.Register ("org/jcodec/common/logging/Logger$Level", DoNotGenerateAcw=true)]
		public sealed partial class Level : global::Java.Lang.Enum {


			static IntPtr DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/field[@name='DEBUG']"
			[Register ("DEBUG")]
			public static global::Org.Jcodec.Common.Logging.Logger.Level Debug {
				get {
					if (DEBUG_jfieldId == IntPtr.Zero)
						DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Lorg/jcodec/common/logging/Logger$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Org.Jcodec.Common.Logging.Logger.Level Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lorg/jcodec/common/logging/Logger$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Org.Jcodec.Common.Logging.Logger.Level Info {
				get {
					if (INFO_jfieldId == IntPtr.Zero)
						INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INFO", "Lorg/jcodec/common/logging/Logger$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WARN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/field[@name='WARN']"
			[Register ("WARN")]
			public static global::Org.Jcodec.Common.Logging.Logger.Level Warn {
				get {
					if (WARN_jfieldId == IntPtr.Zero)
						WARN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARN", "Lorg/jcodec/common/logging/Logger$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/common/logging/Logger$Level", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Level); }
			}

			internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/logging/Logger$Level;", "")]
			public static unsafe global::Org.Jcodec.Common.Logging.Logger.Level ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/logging/Logger$Level;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Jcodec.Common.Logging.Logger.Level __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Level']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/common/logging/Logger$Level;", "")]
			public static unsafe global::Org.Jcodec.Common.Logging.Logger.Level[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/common/logging/Logger$Level;");
				try {
					return (global::Org.Jcodec.Common.Logging.Logger.Level[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Logging.Logger.Level));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.common.logging']/interface[@name='Logger.LogSink']"
		[Register ("org/jcodec/common/logging/Logger$LogSink", "", "Org.Jcodec.Common.Logging.Logger/ILogSinkInvoker")]
		public partial interface ILogSink : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/interface[@name='Logger.LogSink']/method[@name='postMessage' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.Message']]"
			[Register ("postMessage", "(Lorg/jcodec/common/logging/Logger$Message;)V", "GetPostMessage_Lorg_jcodec_common_logging_Logger_Message_Handler:Org.Jcodec.Common.Logging.Logger/ILogSinkInvoker, InstabugAndroidCoreSDK")]
			void PostMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0);

		}

		[global::Android.Runtime.Register ("org/jcodec/common/logging/Logger$LogSink", DoNotGenerateAcw=true)]
		internal class ILogSinkInvoker : global::Java.Lang.Object, ILogSink {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/common/logging/Logger$LogSink");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILogSinkInvoker); }
			}

			IntPtr class_ref;

			public static ILogSink GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogSink> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.common.logging.Logger.LogSink"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILogSinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Org.Jcodec.Common.Logging.Logger.ILogSink __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.ILogSink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Logging.Logger.Message p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.PostMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_postMessage_Lorg_jcodec_common_logging_Logger_Message_;
			public unsafe void PostMessage (global::Org.Jcodec.Common.Logging.Logger.Message p0)
			{
				if (id_postMessage_Lorg_jcodec_common_logging_Logger_Message_ == IntPtr.Zero)
					id_postMessage_Lorg_jcodec_common_logging_Logger_Message_ = JNIEnv.GetMethodID (class_ref, "postMessage", "(Lorg/jcodec/common/logging/Logger$Message;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postMessage_Lorg_jcodec_common_logging_Logger_Message_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']"
		[global::Android.Runtime.Register ("org/jcodec/common/logging/Logger$Message", DoNotGenerateAcw=true)]
		public partial class Message : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/common/logging/Logger$Message", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Message); }
			}

			protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_common_logging_Logger_Level_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/constructor[@name='Logger.Message' and count(parameter)=6 and parameter[1][@type='org.jcodec.common.logging.Logger.Level'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
			[Register (".ctor", "(Lorg/jcodec/common/logging/Logger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
			public unsafe Message (global::Org.Jcodec.Common.Logging.Logger.Level level, string fileName, string className, string methodName, int lineNumber, string message)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_fileName = JNIEnv.NewString (fileName);
				IntPtr native_className = JNIEnv.NewString (className);
				IntPtr native_methodName = JNIEnv.NewString (methodName);
				IntPtr native_message = JNIEnv.NewString (message);
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (level);
					__args [1] = new JValue (native_fileName);
					__args [2] = new JValue (native_className);
					__args [3] = new JValue (native_methodName);
					__args [4] = new JValue (lineNumber);
					__args [5] = new JValue (native_message);
					if (((object) this).GetType () != typeof (Message)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/logging/Logger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/logging/Logger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_common_logging_Logger_Level_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_common_logging_Logger_Level_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/logging/Logger$Level;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_logging_Logger_Level_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_logging_Logger_Level_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_fileName);
					JNIEnv.DeleteLocalRef (native_className);
					JNIEnv.DeleteLocalRef (native_methodName);
					JNIEnv.DeleteLocalRef (native_message);
				}
			}

			static Delegate cb_getClassName;
#pragma warning disable 0169
			static Delegate GetGetClassNameHandler ()
			{
				if (cb_getClassName == null)
					cb_getClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassName);
				return cb_getClassName;
			}

			static IntPtr n_GetClassName (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ClassName);
			}
#pragma warning restore 0169

			static IntPtr id_getClassName;
			public virtual unsafe string ClassName {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getClassName' and count(parameter)=0]"
				[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
				get {
					if (id_getClassName == IntPtr.Zero)
						id_getClassName = JNIEnv.GetMethodID (class_ref, "getClassName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClassName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClassName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFileName;
#pragma warning disable 0169
			static Delegate GetGetFileNameHandler ()
			{
				if (cb_getFileName == null)
					cb_getFileName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileName);
				return cb_getFileName;
			}

			static IntPtr n_GetFileName (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FileName);
			}
#pragma warning restore 0169

			static IntPtr id_getFileName;
			public virtual unsafe string FileName {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getFileName' and count(parameter)=0]"
				[Register ("getFileName", "()Ljava/lang/String;", "GetGetFileNameHandler")]
				get {
					if (id_getFileName == IntPtr.Zero)
						id_getFileName = JNIEnv.GetMethodID (class_ref, "getFileName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLevel;
#pragma warning disable 0169
			static Delegate GetGetLevelHandler ()
			{
				if (cb_getLevel == null)
					cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLevel);
				return cb_getLevel;
			}

			static IntPtr n_GetLevel (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Level);
			}
#pragma warning restore 0169

			static IntPtr id_getLevel;
			public virtual unsafe global::Org.Jcodec.Common.Logging.Logger.Level Level {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getLevel' and count(parameter)=0]"
				[Register ("getLevel", "()Lorg/jcodec/common/logging/Logger$Level;", "GetGetLevelHandler")]
				get {
					if (id_getLevel == IntPtr.Zero)
						id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()Lorg/jcodec/common/logging/Logger$Level;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLevel), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Level> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLevel", "()Lorg/jcodec/common/logging/Logger$Level;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLineNumber;
#pragma warning disable 0169
			static Delegate GetGetLineNumberHandler ()
			{
				if (cb_getLineNumber == null)
					cb_getLineNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLineNumber);
				return cb_getLineNumber;
			}

			static int n_GetLineNumber (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LineNumber;
			}
#pragma warning restore 0169

			static IntPtr id_getLineNumber;
			public virtual unsafe int LineNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getLineNumber' and count(parameter)=0]"
				[Register ("getLineNumber", "()I", "GetGetLineNumberHandler")]
				get {
					if (id_getLineNumber == IntPtr.Zero)
						id_getLineNumber = JNIEnv.GetMethodID (class_ref, "getLineNumber", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLineNumber);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLineNumber", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getMethodName;
#pragma warning disable 0169
			static Delegate GetGetMethodNameHandler ()
			{
				if (cb_getMethodName == null)
					cb_getMethodName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethodName);
				return cb_getMethodName;
			}

			static IntPtr n_GetMethodName (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MethodName);
			}
#pragma warning restore 0169

			static IntPtr id_getMethodName;
			public virtual unsafe string MethodName {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getMethodName' and count(parameter)=0]"
				[Register ("getMethodName", "()Ljava/lang/String;", "GetGetMethodNameHandler")]
				get {
					if (id_getMethodName == IntPtr.Zero)
						id_getMethodName = JNIEnv.GetMethodID (class_ref, "getMethodName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethodName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethodName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getMessage;
#pragma warning disable 0169
			static Delegate GetGetMessageHandler ()
			{
				if (cb_getMessage == null)
					cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
				return cb_getMessage;
			}

			static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Common.Logging.Logger.Message __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Logging.Logger.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GetMessage ());
			}
#pragma warning restore 0169

			static IntPtr id_getMessage;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger.Message']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			public virtual unsafe string GetMessage ()
			{
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/logging/Logger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logger); }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Logger)) {
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

		static IntPtr id_addSink_Lorg_jcodec_common_logging_Logger_LogSink_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/method[@name='addSink' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.logging.Logger.LogSink']]"
		[Register ("addSink", "(Lorg/jcodec/common/logging/Logger$LogSink;)V", "")]
		public static unsafe void AddSink (global::Org.Jcodec.Common.Logging.Logger.ILogSink sink)
		{
			if (id_addSink_Lorg_jcodec_common_logging_Logger_LogSink_ == IntPtr.Zero)
				id_addSink_Lorg_jcodec_common_logging_Logger_LogSink_ = JNIEnv.GetStaticMethodID (class_ref, "addSink", "(Lorg/jcodec/common/logging/Logger$LogSink;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sink);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addSink_Lorg_jcodec_common_logging_Logger_LogSink_, __args);
			} finally {
			}
		}

		static IntPtr id_debug_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public static unsafe void Debug (string message)
		{
			if (id_debug_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "debug", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_debug_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_error_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public static unsafe void Error (string message)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_info_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public static unsafe void Info (string message)
		{
			if (id_info_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "info", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_info_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_warn_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.logging']/class[@name='Logger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public static unsafe void Warn (string message)
		{
			if (id_warn_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "warn", "(Ljava/lang/String;)V");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warn_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
