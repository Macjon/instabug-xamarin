using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPEGPred", DoNotGenerateAcw=true)]
	public partial class MPEGPred : global::Java.Lang.Object {


		static IntPtr mvPred_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/field[@name='mvPred']"
		[Register ("mvPred")]
		protected IList<int[][]> MvPred {
			get {
				if (mvPred_jfieldId == IntPtr.Zero)
					mvPred_jfieldId = JNIEnv.GetFieldID (class_ref, "mvPred", "[[[I");
				return global::Android.Runtime.JavaArray<int[][]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mvPred_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mvPred_jfieldId == IntPtr.Zero)
					mvPred_jfieldId = JNIEnv.GetFieldID (class_ref, "mvPred", "[[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[][]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mvPred_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPEGPred", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEGPred); }
		}

		protected MPEGPred (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayarrayIIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/constructor[@name='MPEGPred' and count(parameter)=3 and parameter[1][@type='int[][]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "([[IIZ)V", "")]
		public unsafe MPEGPred (int[][] fCode, int chromaFormat, bool topFieldFirst)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fCode = JNIEnv.NewArray (fCode);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_fCode);
				__args [1] = new JValue (chromaFormat);
				__args [2] = new JValue (topFieldFirst);
				if (((object) this).GetType () != typeof (MPEGPred)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([[IIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([[IIZ)V", __args);
					return;
				}

				if (id_ctor_arrayarrayIIZ == IntPtr.Zero)
					id_ctor_arrayarrayIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "([[IIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayarrayIIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayarrayIIZ, __args);
			} finally {
				if (fCode != null) {
					JNIEnv.CopyArray (native_fCode, fCode);
					JNIEnv.DeleteLocalRef (native_fCode);
				}
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPEGPred_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/constructor[@name='MPEGPred' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPEGPred']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPEGPred;)V", "")]
		public unsafe MPEGPred (global::Org.Jcodec.Codecs.Mpeg12.MPEGPred other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				if (((object) this).GetType () != typeof (MPEGPred)) {
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

		static IntPtr id_getPix1_arrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='getPix1' and count(parameter)=7 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getPix1", "([IIIIIII)I", "")]
		protected unsafe int GetPix1 (int[] @ref, int refW, int refH, int x, int y, int refVertStep, int refVertOff)
		{
			if (id_getPix1_arrayIIIIIII == IntPtr.Zero)
				id_getPix1_arrayIIIIIII = JNIEnv.GetMethodID (class_ref, "getPix1", "([IIIIIII)I");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refW);
				__args [2] = new JValue (refH);
				__args [3] = new JValue (x);
				__args [4] = new JValue (y);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPix1_arrayIIIIIII, __args);
				return __ret;
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
			}
		}

		static IntPtr id_getPix2_arrayIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='getPix2' and count(parameter)=9 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("getPix2", "([IIIIIIIII)I", "")]
		protected unsafe int GetPix2 (int[] @ref, int refW, int refH, int x1, int y1, int x2, int y2, int refVertStep, int refVertOff)
		{
			if (id_getPix2_arrayIIIIIIIII == IntPtr.Zero)
				id_getPix2_arrayIIIIIIIII = JNIEnv.GetMethodID (class_ref, "getPix2", "([IIIIIIIII)I");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refW);
				__args [2] = new JValue (refH);
				__args [3] = new JValue (x1);
				__args [4] = new JValue (y1);
				__args [5] = new JValue (x2);
				__args [6] = new JValue (y2);
				__args [7] = new JValue (refVertStep);
				__args [8] = new JValue (refVertOff);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPix2_arrayIIIIIIIII, __args);
				return __ret;
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
			}
		}

		static IntPtr id_getPix4_arrayIIIIIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='getPix4' and count(parameter)=13 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='int']]"
		[Register ("getPix4", "([IIIIIIIIIIIII)I", "")]
		protected unsafe int GetPix4 (int[] @ref, int refW, int refH, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int refVertStep, int refVertOff)
		{
			if (id_getPix4_arrayIIIIIIIIIIIII == IntPtr.Zero)
				id_getPix4_arrayIIIIIIIIIIIII = JNIEnv.GetMethodID (class_ref, "getPix4", "([IIIIIIIIIIIII)I");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			try {
				JValue* __args = stackalloc JValue [13];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refW);
				__args [2] = new JValue (refH);
				__args [3] = new JValue (x1);
				__args [4] = new JValue (y1);
				__args [5] = new JValue (x2);
				__args [6] = new JValue (y2);
				__args [7] = new JValue (x3);
				__args [8] = new JValue (y3);
				__args [9] = new JValue (x4);
				__args [10] = new JValue (y4);
				__args [11] = new JValue (refVertStep);
				__args [12] = new JValue (refVertOff);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPix4_arrayIIIIIIIIIIIII, __args);
				return __ret;
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
			}
		}

		static Delegate cb_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
#pragma warning disable 0169
		static Delegate GetPredict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIHandler ()
		{
			if (cb_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI == null)
				cb_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>) n_Predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI);
			return cb_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
		}

		static void n_Predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_reference, int x, int y, IntPtr native_bits, int backward, IntPtr native_mbPix)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture[] reference = (global::Org.Jcodec.Common.Model.Picture[]) JNIEnv.GetArray (native_reference, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Common.Model.Picture));
			global::Org.Jcodec.Common.IO.BitReader bits = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_bits, JniHandleOwnership.DoNotTransfer);
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.Predict16x16Field (reference, x, y, bits, backward, mbPix);
			if (reference != null)
				JNIEnv.CopyArray (reference, native_reference);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predict16x16Field' and count(parameter)=6 and parameter[1][@type='org.jcodec.common.model.Picture[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.jcodec.common.io.BitReader'] and parameter[5][@type='int'] and parameter[6][@type='int[][]']]"
		[Register ("predict16x16Field", "([Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V", "GetPredict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIHandler")]
		protected virtual unsafe void Predict16x16Field (global::Org.Jcodec.Common.Model.Picture[] reference, int x, int y, global::Org.Jcodec.Common.IO.BitReader bits, int backward, int[][] mbPix)
		{
			if (id_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI == IntPtr.Zero)
				id_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI = JNIEnv.GetMethodID (class_ref, "predict16x16Field", "([Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V");
			IntPtr native_reference = JNIEnv.NewArray (reference);
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_reference);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (bits);
				__args [4] = new JValue (backward);
				__args [5] = new JValue (native_mbPix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predict16x16Field_arrayLorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict16x16Field", "([Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V"), __args);
			} finally {
				if (reference != null) {
					JNIEnv.CopyArray (native_reference, reference);
					JNIEnv.DeleteLocalRef (native_reference);
				}
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
#pragma warning disable 0169
		static Delegate GetPredict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIHandler ()
		{
			if (cb_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI == null)
				cb_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr>) n_Predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI);
			return cb_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
		}

		static void n_Predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_reference, int x, int y, IntPtr native_bits, int backward, IntPtr native_mbPix)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture reference = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_reference, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader bits = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_bits, JniHandleOwnership.DoNotTransfer);
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.Predict16x16Frame (reference, x, y, bits, backward, mbPix);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predict16x16Frame' and count(parameter)=6 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.jcodec.common.io.BitReader'] and parameter[5][@type='int'] and parameter[6][@type='int[][]']]"
		[Register ("predict16x16Frame", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V", "GetPredict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIHandler")]
		protected virtual unsafe void Predict16x16Frame (global::Org.Jcodec.Common.Model.Picture reference, int x, int y, global::Org.Jcodec.Common.IO.BitReader bits, int backward, int[][] mbPix)
		{
			if (id_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI == IntPtr.Zero)
				id_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI = JNIEnv.GetMethodID (class_ref, "predict16x16Frame", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V");
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (reference);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (bits);
				__args [4] = new JValue (backward);
				__args [5] = new JValue (native_mbPix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predict16x16Frame_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict16x16Frame", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[I)V"), __args);
			} finally {
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI;
#pragma warning disable 0169
		static Delegate GetPredict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayIHandler ()
		{
			if (cb_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI == null)
				cb_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, IntPtr>) n_Predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI);
			return cb_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI;
		}

		static void n_Predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_picture, int x, int y, int pictureStructure, int backward, IntPtr native_mbPix)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture picture = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_picture, JniHandleOwnership.DoNotTransfer);
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.Predict16x16NoMV (picture, x, y, pictureStructure, backward, mbPix);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predict16x16NoMV' and count(parameter)=6 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int[][]']]"
		[Register ("predict16x16NoMV", "(Lorg/jcodec/common/model/Picture;IIII[[I)V", "GetPredict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayIHandler")]
		public virtual unsafe void Predict16x16NoMV (global::Org.Jcodec.Common.Model.Picture picture, int x, int y, int pictureStructure, int backward, int[][] mbPix)
		{
			if (id_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI == IntPtr.Zero)
				id_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI = JNIEnv.GetMethodID (class_ref, "predict16x16NoMV", "(Lorg/jcodec/common/model/Picture;IIII[[I)V");
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (picture);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (pictureStructure);
				__args [4] = new JValue (backward);
				__args [5] = new JValue (native_mbPix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predict16x16NoMV_Lorg_jcodec_common_model_Picture_IIIIarrayarrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predict16x16NoMV", "(Lorg/jcodec/common/model/Picture;IIII[[I)V"), __args);
			} finally {
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictEvenEvenSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictEvenEvenSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictEvenEvenSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictEvenEvenSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictEvenEvenSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictEvenEvenSafe", "([IIIIIII[IIIII)V", "GetPredictEvenEvenSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictEvenEvenSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictEvenEvenSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictEvenEvenSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictEvenEvenSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictEvenEvenUnSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictEvenEvenUnSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictEvenEvenUnSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictEvenEvenUnSafe", "([IIIIIII[IIIII)V", "GetPredictEvenEvenUnSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictEvenEvenUnSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictEvenEvenUnSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictEvenEvenUnSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictEvenEvenUnSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictEvenOddSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictEvenOddSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictEvenOddSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictEvenOddSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictEvenOddSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictEvenOddSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictEvenOddSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictEvenOddSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictEvenOddSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictEvenOddSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictEvenOddSafe", "([IIIIIII[IIIII)V", "GetPredictEvenOddSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictEvenOddSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictEvenOddSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictEvenOddSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictEvenOddSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictEvenOddSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictEvenOddSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictEvenOddUnSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictEvenOddUnSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictEvenOddUnSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictEvenOddUnSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictEvenOddUnSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictEvenOddUnSafe", "([IIIIIII[IIIII)V", "GetPredictEvenOddUnSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictEvenOddUnSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictEvenOddUnSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictEvenOddUnSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictEvenOddUnSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII;
#pragma warning disable 0169
		static Delegate GetPredictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIIIHandler ()
		{
			if (cb_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII == null)
				cb_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, int, int, int, int, int, int, int, int>) n_PredictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII);
			return cb_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII;
		}

		static void n_PredictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_reference, int x, int y, IntPtr native_bits, int backward, IntPtr native_mbPix, int tgtY, int blkW, int blkH, int isSrcField, int srcField, int isDstField, int vectIdx, int predScale)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture reference = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_reference, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.BitReader bits = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_bits, JniHandleOwnership.DoNotTransfer);
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.PredictGeneric (reference, x, y, bits, backward, mbPix, tgtY, blkW, blkH, isSrcField, srcField, isDstField, vectIdx, predScale);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictGeneric' and count(parameter)=14 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.jcodec.common.io.BitReader'] and parameter[5][@type='int'] and parameter[6][@type='int[][]'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int'] and parameter[13][@type='int'] and parameter[14][@type='int']]"
		[Register ("predictGeneric", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[IIIIIIIII)V", "GetPredictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIIIHandler")]
		protected virtual unsafe void PredictGeneric (global::Org.Jcodec.Common.Model.Picture reference, int x, int y, global::Org.Jcodec.Common.IO.BitReader bits, int backward, int[][] mbPix, int tgtY, int blkW, int blkH, int isSrcField, int srcField, int isDstField, int vectIdx, int predScale)
		{
			if (id_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII == IntPtr.Zero)
				id_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII = JNIEnv.GetMethodID (class_ref, "predictGeneric", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[IIIIIIIII)V");
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [14];
				__args [0] = new JValue (reference);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (bits);
				__args [4] = new JValue (backward);
				__args [5] = new JValue (native_mbPix);
				__args [6] = new JValue (tgtY);
				__args [7] = new JValue (blkW);
				__args [8] = new JValue (blkH);
				__args [9] = new JValue (isSrcField);
				__args [10] = new JValue (srcField);
				__args [11] = new JValue (isDstField);
				__args [12] = new JValue (vectIdx);
				__args [13] = new JValue (predScale);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictGeneric_Lorg_jcodec_common_model_Picture_IILorg_jcodec_common_io_BitReader_IarrayarrayIIIIIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictGeneric", "(Lorg/jcodec/common/model/Picture;IILorg/jcodec/common/io/BitReader;I[[IIIIIIIII)V"), __args);
			} finally {
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
#pragma warning disable 0169
		static Delegate GetPredictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_IIIHandler ()
		{
			if (cb_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III == null)
				cb_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, int, int, int>) n_PredictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III);
			return cb_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
		}

		static void n_PredictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III (IntPtr jnienv, IntPtr native__this, IntPtr native_reference, int x, int y, IntPtr native_mbPix, IntPtr native_bits, int motionType, int backward, int fieldNo)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture[] reference = (global::Org.Jcodec.Common.Model.Picture[]) JNIEnv.GetArray (native_reference, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Common.Model.Picture));
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			global::Org.Jcodec.Common.IO.BitReader bits = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native_bits, JniHandleOwnership.DoNotTransfer);
			__this.PredictInField (reference, x, y, mbPix, bits, motionType, backward, fieldNo);
			if (reference != null)
				JNIEnv.CopyArray (reference, native_reference);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictInField' and count(parameter)=8 and parameter[1][@type='org.jcodec.common.model.Picture[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[][]'] and parameter[5][@type='org.jcodec.common.io.BitReader'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("predictInField", "([Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V", "GetPredictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_IIIHandler")]
		public virtual unsafe void PredictInField (global::Org.Jcodec.Common.Model.Picture[] reference, int x, int y, int[][] mbPix, global::Org.Jcodec.Common.IO.BitReader bits, int motionType, int backward, int fieldNo)
		{
			if (id_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III == IntPtr.Zero)
				id_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III = JNIEnv.GetMethodID (class_ref, "predictInField", "([Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V");
			IntPtr native_reference = JNIEnv.NewArray (reference);
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_reference);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (native_mbPix);
				__args [4] = new JValue (bits);
				__args [5] = new JValue (motionType);
				__args [6] = new JValue (backward);
				__args [7] = new JValue (fieldNo);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictInField_arrayLorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictInField", "([Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V"), __args);
			} finally {
				if (reference != null) {
					JNIEnv.CopyArray (native_reference, reference);
					JNIEnv.DeleteLocalRef (native_reference);
				}
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
#pragma warning disable 0169
		static Delegate GetPredictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_IIIHandler ()
		{
			if (cb_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III == null)
				cb_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, IntPtr, int, int, int>) n_PredictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III);
			return cb_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
		}

		static void n_PredictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III (IntPtr jnienv, IntPtr native__this, IntPtr native_reference, int x, int y, IntPtr native_mbPix, IntPtr native__in, int motionType, int backward, int spatial_temporal_weight_code)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture reference = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_reference, JniHandleOwnership.DoNotTransfer);
			int[][] mbPix = (int[][]) JNIEnv.GetArray (native_mbPix, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			global::Org.Jcodec.Common.IO.BitReader @in = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.BitReader> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.PredictInFrame (reference, x, y, mbPix, @in, motionType, backward, spatial_temporal_weight_code);
			if (mbPix != null)
				JNIEnv.CopyArray (mbPix, native_mbPix);
		}
#pragma warning restore 0169

		static IntPtr id_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictInFrame' and count(parameter)=8 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[][]'] and parameter[5][@type='org.jcodec.common.io.BitReader'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register ("predictInFrame", "(Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V", "GetPredictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_IIIHandler")]
		public virtual unsafe void PredictInFrame (global::Org.Jcodec.Common.Model.Picture reference, int x, int y, int[][] mbPix, global::Org.Jcodec.Common.IO.BitReader @in, int motionType, int backward, int spatial_temporal_weight_code)
		{
			if (id_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III == IntPtr.Zero)
				id_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III = JNIEnv.GetMethodID (class_ref, "predictInFrame", "(Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V");
			IntPtr native_mbPix = JNIEnv.NewArray (mbPix);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (reference);
				__args [1] = new JValue (x);
				__args [2] = new JValue (y);
				__args [3] = new JValue (native_mbPix);
				__args [4] = new JValue (@in);
				__args [5] = new JValue (motionType);
				__args [6] = new JValue (backward);
				__args [7] = new JValue (spatial_temporal_weight_code);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictInFrame_Lorg_jcodec_common_model_Picture_IIarrayarrayILorg_jcodec_common_io_BitReader_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictInFrame", "(Lorg/jcodec/common/model/Picture;II[[ILorg/jcodec/common/io/BitReader;III)V"), __args);
			} finally {
				if (mbPix != null) {
					JNIEnv.CopyArray (native_mbPix, mbPix);
					JNIEnv.DeleteLocalRef (native_mbPix);
				}
			}
		}

		static Delegate cb_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII;
#pragma warning disable 0169
		static Delegate GetPredictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIIIHandler ()
		{
			if (cb_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII == null)
				cb_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, int, int, IntPtr, int, int>) n_PredictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII);
			return cb_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII;
		}

		static void n_PredictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int vectX, int refY, int vectY, int blkW, int blkH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture @ref = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native__ref, JniHandleOwnership.DoNotTransfer);
			int[][] tgt = (int[][]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			__this.PredictMB (@ref, refX, vectX, refY, vectY, blkW, blkH, refVertStep, refVertOff, tgt, tgtY, tgtVertStep);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictMB' and count(parameter)=12 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int[][]'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictMB", "(Lorg/jcodec/common/model/Picture;IIIIIIII[[III)V", "GetPredictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIIIHandler")]
		public virtual unsafe void PredictMB (global::Org.Jcodec.Common.Model.Picture @ref, int refX, int vectX, int refY, int vectY, int blkW, int blkH, int refVertStep, int refVertOff, int[][] tgt, int tgtY, int tgtVertStep)
		{
			if (id_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII == IntPtr.Zero)
				id_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII = JNIEnv.GetMethodID (class_ref, "predictMB", "(Lorg/jcodec/common/model/Picture;IIIIIIII[[III)V");
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (@ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (vectX);
				__args [3] = new JValue (refY);
				__args [4] = new JValue (vectY);
				__args [5] = new JValue (blkW);
				__args [6] = new JValue (blkH);
				__args [7] = new JValue (refVertStep);
				__args [8] = new JValue (refVertOff);
				__args [9] = new JValue (native_tgt);
				__args [10] = new JValue (tgtY);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictMB_Lorg_jcodec_common_model_Picture_IIIIIIIIarrayarrayIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictMB", "(Lorg/jcodec/common/model/Picture;IIIIIIII[[III)V"), __args);
			} finally {
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictOddEvenSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictOddEvenSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictOddEvenSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictOddEvenSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictOddEvenSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictOddEvenSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictOddEvenSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictOddEvenSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictOddEvenSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictOddEvenSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictOddEvenSafe", "([IIIIIII[IIIII)V", "GetPredictOddEvenSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictOddEvenSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictOddEvenSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictOddEvenSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictOddEvenSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictOddEvenSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictOddEvenSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictOddEvenUnSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictOddEvenUnSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictOddEvenUnSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictOddEvenUnSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictOddEvenUnSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictOddEvenUnSafe", "([IIIIIII[IIIII)V", "GetPredictOddEvenUnSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictOddEvenUnSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictOddEvenUnSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictOddEvenUnSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictOddEvenUnSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictOddOddSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictOddOddSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictOddOddSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictOddOddSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictOddOddSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictOddOddSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictOddOddSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictOddOddSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictOddOddSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictOddOddSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictOddOddSafe", "([IIIIIII[IIIII)V", "GetPredictOddOddSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictOddOddSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictOddOddSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictOddOddSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictOddOddSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictOddOddSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictOddOddSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictOddOddUnSafe_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII == null)
				cb_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictOddOddUnSafe_arrayIIIIIIIarrayIIIII);
			return cb_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictOddOddUnSafe_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictOddOddUnSafe (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictOddOddUnSafe' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictOddOddUnSafe", "([IIIIIII[IIIII)V", "GetPredictOddOddUnSafe_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictOddOddUnSafe (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictOddOddUnSafe", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictOddOddUnSafe_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictOddOddUnSafe", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_predictPlane_arrayIIIIIIIarrayIIIII;
#pragma warning disable 0169
		static Delegate GetPredictPlane_arrayIIIIIIIarrayIIIIIHandler ()
		{
			if (cb_predictPlane_arrayIIIIIIIarrayIIIII == null)
				cb_predictPlane_arrayIIIIIIIarrayIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, int, int, IntPtr, int, int, int, int>) n_PredictPlane_arrayIIIIIIIarrayIIIII);
			return cb_predictPlane_arrayIIIIIIIarrayIIIII;
		}

		static void n_PredictPlane_arrayIIIIIIIarrayIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native__ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, IntPtr native_tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] @ref = (int[]) JNIEnv.GetArray (native__ref, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] tgt = (int[]) JNIEnv.GetArray (native_tgt, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.PredictPlane (@ref, refX, refY, refW, refH, refVertStep, refVertOff, tgt, tgtY, tgtW, tgtH, tgtVertStep);
			if (@ref != null)
				JNIEnv.CopyArray (@ref, native__ref);
			if (tgt != null)
				JNIEnv.CopyArray (tgt, native_tgt);
		}
#pragma warning restore 0169

		static IntPtr id_predictPlane_arrayIIIIIIIarrayIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='predictPlane' and count(parameter)=12 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int[]'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='int']]"
		[Register ("predictPlane", "([IIIIIII[IIIII)V", "GetPredictPlane_arrayIIIIIIIarrayIIIIIHandler")]
		public virtual unsafe void PredictPlane (int[] @ref, int refX, int refY, int refW, int refH, int refVertStep, int refVertOff, int[] tgt, int tgtY, int tgtW, int tgtH, int tgtVertStep)
		{
			if (id_predictPlane_arrayIIIIIIIarrayIIIII == IntPtr.Zero)
				id_predictPlane_arrayIIIIIIIarrayIIIII = JNIEnv.GetMethodID (class_ref, "predictPlane", "([IIIIIII[IIIII)V");
			IntPtr native__ref = JNIEnv.NewArray (@ref);
			IntPtr native_tgt = JNIEnv.NewArray (tgt);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (native__ref);
				__args [1] = new JValue (refX);
				__args [2] = new JValue (refY);
				__args [3] = new JValue (refW);
				__args [4] = new JValue (refH);
				__args [5] = new JValue (refVertStep);
				__args [6] = new JValue (refVertOff);
				__args [7] = new JValue (native_tgt);
				__args [8] = new JValue (tgtY);
				__args [9] = new JValue (tgtW);
				__args [10] = new JValue (tgtH);
				__args [11] = new JValue (tgtVertStep);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_predictPlane_arrayIIIIIIIarrayIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "predictPlane", "([IIIIIII[IIIII)V"), __args);
			} finally {
				if (@ref != null) {
					JNIEnv.CopyArray (native__ref, @ref);
					JNIEnv.DeleteLocalRef (native__ref);
				}
				if (tgt != null) {
					JNIEnv.CopyArray (native_tgt, tgt);
					JNIEnv.DeleteLocalRef (native_tgt);
				}
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPEGPred __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGPred> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPEGPred']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

	}
}
