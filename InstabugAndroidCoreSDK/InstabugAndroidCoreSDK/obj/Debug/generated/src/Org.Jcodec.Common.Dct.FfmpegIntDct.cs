using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Dct {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='FfmpegIntDct']"
	[global::Android.Runtime.Register ("org/jcodec/common/dct/FfmpegIntDct", DoNotGenerateAcw=true)]
	public partial class FfmpegIntDct : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/dct/FfmpegIntDct", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FfmpegIntDct); }
		}

		protected FfmpegIntDct (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='FfmpegIntDct']/constructor[@name='FfmpegIntDct' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FfmpegIntDct ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FfmpegIntDct)) {
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

		static Delegate cb_decode_arrayS;
#pragma warning disable 0169
		static Delegate GetDecode_arraySHandler ()
		{
			if (cb_decode_arrayS == null)
				cb_decode_arrayS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_arrayS);
			return cb_decode_arrayS;
		}

		static IntPtr n_Decode_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_orig)
		{
			global::Org.Jcodec.Common.Dct.FfmpegIntDct __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Dct.FfmpegIntDct> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] orig = (short[]) JNIEnv.GetArray (native_orig, JniHandleOwnership.DoNotTransfer, typeof (short));
			IntPtr __ret = JNIEnv.NewArray (__this.Decode (orig));
			if (orig != null)
				JNIEnv.CopyArray (orig, native_orig);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decode_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.dct']/class[@name='FfmpegIntDct']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("decode", "([S)[S", "GetDecode_arraySHandler")]
		public virtual unsafe short[] Decode (short[] orig)
		{
			if (id_decode_arrayS == IntPtr.Zero)
				id_decode_arrayS = JNIEnv.GetMethodID (class_ref, "decode", "([S)[S");
			IntPtr native_orig = JNIEnv.NewArray (orig);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_orig);

				short[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (short[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_arrayS, __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				else
					__ret = (short[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decode", "([S)[S"), __args), JniHandleOwnership.TransferLocalRef, typeof (short));
				return __ret;
			} finally {
				if (orig != null) {
					JNIEnv.CopyArray (native_orig, orig);
					JNIEnv.DeleteLocalRef (native_orig);
				}
			}
		}

	}
}
