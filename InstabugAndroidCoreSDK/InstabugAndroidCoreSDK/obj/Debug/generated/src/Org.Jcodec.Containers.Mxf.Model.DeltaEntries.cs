using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='DeltaEntries']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/DeltaEntries", DoNotGenerateAcw=true)]
	public partial class DeltaEntries : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/DeltaEntries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeltaEntries); }
		}

		protected DeltaEntries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBarrayBarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='DeltaEntries']/constructor[@name='DeltaEntries' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int[]']]"
		[Register (".ctor", "([B[B[I)V", "")]
		public unsafe DeltaEntries (byte[] posTabIdx, byte[] slice, int[] elementDelta)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_posTabIdx = JNIEnv.NewArray (posTabIdx);
			IntPtr native_slice = JNIEnv.NewArray (slice);
			IntPtr native_elementDelta = JNIEnv.NewArray (elementDelta);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_posTabIdx);
				__args [1] = new JValue (native_slice);
				__args [2] = new JValue (native_elementDelta);
				if (((object) this).GetType () != typeof (DeltaEntries)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B[B[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B[B[I)V", __args);
					return;
				}

				if (id_ctor_arrayBarrayBarrayI == IntPtr.Zero)
					id_ctor_arrayBarrayBarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([B[B[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBarrayBarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBarrayBarrayI, __args);
			} finally {
				if (posTabIdx != null) {
					JNIEnv.CopyArray (native_posTabIdx, posTabIdx);
					JNIEnv.DeleteLocalRef (native_posTabIdx);
				}
				if (slice != null) {
					JNIEnv.CopyArray (native_slice, slice);
					JNIEnv.DeleteLocalRef (native_slice);
				}
				if (elementDelta != null) {
					JNIEnv.CopyArray (native_elementDelta, elementDelta);
					JNIEnv.DeleteLocalRef (native_elementDelta);
				}
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='DeltaEntries']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/DeltaEntries;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries Read (global::Java.Nio.ByteBuffer bb)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/DeltaEntries;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bb);
				global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
