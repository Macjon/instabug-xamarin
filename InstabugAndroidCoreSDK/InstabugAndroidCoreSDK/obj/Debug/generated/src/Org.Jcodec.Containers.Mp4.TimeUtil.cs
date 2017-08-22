using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/TimeUtil", DoNotGenerateAcw=true)]
	public partial class TimeUtil : global::Java.Lang.Object {


		static IntPtr MOV_TIME_OFFSET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']/field[@name='MOV_TIME_OFFSET']"
		[Register ("MOV_TIME_OFFSET")]
		public static long MovTimeOffset {
			get {
				if (MOV_TIME_OFFSET_jfieldId == IntPtr.Zero)
					MOV_TIME_OFFSET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOV_TIME_OFFSET", "J");
				return JNIEnv.GetStaticLongField (class_ref, MOV_TIME_OFFSET_jfieldId);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/TimeUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeUtil); }
		}

		protected TimeUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']/constructor[@name='TimeUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimeUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TimeUtil)) {
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

		static IntPtr id_fromMovTime_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']/method[@name='fromMovTime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMovTime", "(I)J", "")]
		public static unsafe long FromMovTime (int movSec)
		{
			if (id_fromMovTime_I == IntPtr.Zero)
				id_fromMovTime_I = JNIEnv.GetStaticMethodID (class_ref, "fromMovTime", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (movSec);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_fromMovTime_I, __args);
			} finally {
			}
		}

		static IntPtr id_macTimeToDate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']/method[@name='macTimeToDate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("macTimeToDate", "(I)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date MacTimeToDate (int movSec)
		{
			if (id_macTimeToDate_I == IntPtr.Zero)
				id_macTimeToDate_I = JNIEnv.GetStaticMethodID (class_ref, "macTimeToDate", "(I)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (movSec);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallStaticObjectMethod  (class_ref, id_macTimeToDate_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toMovTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TimeUtil']/method[@name='toMovTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toMovTime", "(J)I", "")]
		public static unsafe int ToMovTime (long millis)
		{
			if (id_toMovTime_J == IntPtr.Zero)
				id_toMovTime_J = JNIEnv.GetStaticMethodID (class_ref, "toMovTime", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (millis);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_toMovTime_J, __args);
			} finally {
			}
		}

	}
}
