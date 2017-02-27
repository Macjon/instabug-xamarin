using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlBin", DoNotGenerateAcw=true)]
	public partial class EbmlBin : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase {


		static IntPtr dataRead_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/field[@name='dataRead']"
		[Register ("dataRead")]
		protected bool DataRead {
			get {
				if (dataRead_jfieldId == IntPtr.Zero)
					dataRead_jfieldId = JNIEnv.GetFieldID (class_ref, "dataRead", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, dataRead_jfieldId);
			}
			set {
				if (dataRead_jfieldId == IntPtr.Zero)
					dataRead_jfieldId = JNIEnv.GetFieldID (class_ref, "dataRead", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataRead_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlBin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlBin); }
		}

		protected EbmlBin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/constructor[@name='EbmlBin' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe EbmlBin (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (EbmlBin)) {
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
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public override unsafe global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static void n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)V", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_set_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_set_Ljava_nio_ByteBuffer_ == null)
				cb_set_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Ljava_nio_ByteBuffer_);
			return cb_set_Ljava_nio_ByteBuffer_;
		}

		static void n_Set_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/method[@name='set' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("set", "(Ljava/nio/ByteBuffer;)V", "GetSet_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Set (global::Java.Nio.ByteBuffer p0)
		{
			if (id_set_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_set_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_skip_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSkip_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_skip_Ljava_nio_ByteBuffer_ == null)
				cb_skip_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Skip_Ljava_nio_ByteBuffer_);
			return cb_skip_Ljava_nio_ByteBuffer_;
		}

		static void n_Skip_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Skip (p0);
		}
#pragma warning restore 0169

		static IntPtr id_skip_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBin']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("skip", "(Ljava/nio/ByteBuffer;)V", "GetSkip_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Skip (global::Java.Nio.ByteBuffer p0)
		{
			if (id_skip_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_skip_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "skip", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skip_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
