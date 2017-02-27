using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Aso {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MBToSliceGroupMap']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/aso/MBToSliceGroupMap", DoNotGenerateAcw=true)]
	public partial class MBToSliceGroupMap : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/aso/MBToSliceGroupMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MBToSliceGroupMap); }
		}

		protected MBToSliceGroupMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayIarrayIarrayarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MBToSliceGroupMap']/constructor[@name='MBToSliceGroupMap' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[][]']]"
		[Register (".ctor", "([I[I[[I)V", "")]
		public unsafe MBToSliceGroupMap (int[] p0, int[] p1, int[][] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MBToSliceGroupMap)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([I[I[[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I[I[[I)V", __args);
					return;
				}

				if (id_ctor_arrayIarrayIarrayarrayI == IntPtr.Zero)
					id_ctor_arrayIarrayIarrayarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I[I[[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayIarrayIarrayarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayIarrayIarrayarrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getGroups;
#pragma warning disable 0169
		static Delegate GetGetGroupsHandler ()
		{
			if (cb_getGroups == null)
				cb_getGroups = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroups);
			return cb_getGroups;
		}

		static IntPtr n_GetGroups (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetGroups ());
		}
#pragma warning restore 0169

		static IntPtr id_getGroups;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MBToSliceGroupMap']/method[@name='getGroups' and count(parameter)=0]"
		[Register ("getGroups", "()[I", "GetGetGroupsHandler")]
		public virtual unsafe int[] GetGroups ()
		{
			if (id_getGroups == IntPtr.Zero)
				id_getGroups = JNIEnv.GetMethodID (class_ref, "getGroups", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroups), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroups", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getIndices;
#pragma warning disable 0169
		static Delegate GetGetIndicesHandler ()
		{
			if (cb_getIndices == null)
				cb_getIndices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIndices);
			return cb_getIndices;
		}

		static IntPtr n_GetIndices (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetIndices ());
		}
#pragma warning restore 0169

		static IntPtr id_getIndices;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MBToSliceGroupMap']/method[@name='getIndices' and count(parameter)=0]"
		[Register ("getIndices", "()[I", "GetGetIndicesHandler")]
		public virtual unsafe int[] GetIndices ()
		{
			if (id_getIndices == IntPtr.Zero)
				id_getIndices = JNIEnv.GetMethodID (class_ref, "getIndices", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIndices), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndices", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getInverse;
#pragma warning disable 0169
		static Delegate GetGetInverseHandler ()
		{
			if (cb_getInverse == null)
				cb_getInverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInverse);
			return cb_getInverse;
		}

		static IntPtr n_GetInverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.MBToSliceGroupMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInverse ());
		}
#pragma warning restore 0169

		static IntPtr id_getInverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='MBToSliceGroupMap']/method[@name='getInverse' and count(parameter)=0]"
		[Register ("getInverse", "()[[I", "GetGetInverseHandler")]
		public virtual unsafe int[][] GetInverse ()
		{
			if (id_getInverse == IntPtr.Zero)
				id_getInverse = JNIEnv.GetMethodID (class_ref, "getInverse", "()[[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInverse), JniHandleOwnership.TransferLocalRef, typeof (int[]));
				else
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInverse", "()[[I")), JniHandleOwnership.TransferLocalRef, typeof (int[]));
			} finally {
			}
		}

	}
}
