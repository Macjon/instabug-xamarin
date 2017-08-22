using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlDate']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlDate", DoNotGenerateAcw=true)]
	public partial class EbmlDate : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlSint {


		static IntPtr MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlDate']/field[@name='MILISECONDS_SINCE_UNIX_EPOCH_START']"
		[Register ("MILISECONDS_SINCE_UNIX_EPOCH_START")]
		public static long MilisecondsSinceUnixEpochStart {
			get {
				if (MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId == IntPtr.Zero)
					MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MILISECONDS_SINCE_UNIX_EPOCH_START", "J");
				return JNIEnv.GetStaticLongField (class_ref, MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId);
			}
			set {
				if (MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId == IntPtr.Zero)
					MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MILISECONDS_SINCE_UNIX_EPOCH_START", "J");
				try {
					JNIEnv.SetStaticField (class_ref, MILISECONDS_SINCE_UNIX_EPOCH_START_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlDate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlDate); }
		}

		protected EbmlDate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlDate']/constructor[@name='EbmlDate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe EbmlDate (byte[] id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_id);
				if (((object) this).GetType () != typeof (EbmlDate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (id != null) {
					JNIEnv.CopyArray (native_id, id);
					JNIEnv.DeleteLocalRef (native_id);
				}
			}
		}

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlDate __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Date);
		}
#pragma warning restore 0169

		static Delegate cb_setDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Date_Handler ()
		{
			if (cb_setDate_Ljava_util_Date_ == null)
				cb_setDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Date_);
			return cb_setDate_Ljava_util_Date_;
		}

		static void n_SetDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlDate __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlDate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Date = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		static IntPtr id_setDate_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlDate']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/util/Date;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlDate']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setDate", "(Ljava/util/Date;)V", "GetSetDate_Ljava_util_Date_Handler")]
			set {
				if (id_setDate_Ljava_util_Date_ == IntPtr.Zero)
					id_setDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

	}
}
