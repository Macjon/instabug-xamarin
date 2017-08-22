using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPredQuad']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGPredQuad", DoNotGenerateAcw=true)]
	public partial class MPEGPredQuad : global::Org.Jcodec.Codecs.Mpeg12.MPEGPred {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGPredQuad", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGPredQuad); }
		}

		protected MPEGPredQuad (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPredQuad']/constructor[@name='MPEGPredQuad' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPEGPred']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPEGPred;)V", "")]
		public unsafe MPEGPredQuad (global::Org.Jcodec.Codecs.Mpeg12.MPEGPred other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				if (((object) this).GetType () != typeof (MPEGPredQuad)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/mpeg12/MPEGPred;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/mpeg12/MPEGPred;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/MPEGPred;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_, __args);
			} finally {
			}
		}

		static Delegate cb_getPix2_arrayIIIIIIIIII;
#pragma warning disable 0169
		static Delegate GetGetPix2_arrayIIIIIIIIIIHandler ()
		{
			if (cb_getPix2_arrayIIIIIIIIII == null)
				cb_getPix2_arrayIIIIIIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, int, int, int>) n_GetPix2_arrayIIIIIIIIII);
			return cb_getPix2_arrayIIIIIIIIII;
		}

		static int n_GetPix2_arrayIIIIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refW, int refH, int x1, int y1, int x2, int y2, int refVertStep, int refVertOff, int i)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPredQuad __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPredQuad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.GetPix2 (@ref, refW, refH, x1, y1, x2, y2, refVertStep, refVertOff, i);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPix2_arrayIIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPredQuad']/method[@name='getPix2' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("getPix2", "([IIIIIIIIII)I", "GetGetPix2_arrayIIIIIIIIIIHandler")]
		protected virtual unsafe int GetPix2 (int[] @ref, int refW, int refH, int x1, int y1, int x2, int y2, int refVertStep, int refVertOff, int i)
		{
			if (id_getPix2_arrayIIIIIIIIII == IntPtr.Zero)
				id_getPix2_arrayIIIIIIIIII = JNIEnv.GetMethodID (class_ref, "getPix2", "([IIIIIIIIII)I");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refW);
				__args [2] = new JValue (refH);
				__args [3] = new JValue (x1);
				__args [4] = new JValue (y1);
				__args [5] = new JValue (x2);
				__args [6] = new JValue (y2);
				__args [7] = new JValue (refVertStep);
				__args [8] = new JValue (refVertOff);
				__args [9] = new JValue (i);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPix2_arrayIIIIIIIIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPix2", "([IIIIIIIIII)I"), __args);
				return __ret;
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
			}
		}

	}
}
