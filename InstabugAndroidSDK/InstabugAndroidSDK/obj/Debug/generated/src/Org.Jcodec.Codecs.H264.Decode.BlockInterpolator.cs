using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/BlockInterpolator", DoNotGenerateAcw=true)]
	public partial class BlockInterpolator : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/interface[@name='BlockInterpolator.LumaInterpolator']"
		[Register ("org/jcodec/codecs/h264/decode/BlockInterpolator$LumaInterpolator", "", "Org.Jcodec.Codecs.H264.Decode.BlockInterpolator/ILumaInterpolatorInvoker")]
		public partial interface ILumaInterpolator : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/interface[@name='BlockInterpolator.LumaInterpolator']/method[@name='getLuma' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
			[Register ("getLuma", "([III[IIIIIII)V", "GetGetLuma_arrayIIIarrayIIIIIIIHandler:Org.Jcodec.Codecs.H264.Decode.BlockInterpolator/ILumaInterpolatorInvoker, InstabugAndroidSDK")]
			void GetLuma (int[] p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7, int p8, int p9);

		}

		[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/BlockInterpolator$LumaInterpolator", DoNotGenerateAcw=true)]
		internal class ILumaInterpolatorInvoker : global::Java.Lang.Object, ILumaInterpolator {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/BlockInterpolator$LumaInterpolator");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ILumaInterpolatorInvoker); }
			}

			IntPtr class_ref;

			public static ILumaInterpolator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILumaInterpolator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.h264.decode.BlockInterpolator.LumaInterpolator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILumaInterpolatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getLuma_arrayIIIarrayIIIIIII;
#pragma warning disable 0169
			static Delegate GetGetLuma_arrayIIIarrayIIIIIIIHandler ()
			{
				if (cb_getLuma_arrayIIIarrayIIIIIII == null)
					cb_getLuma_arrayIIIarrayIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int, int, int, int, int, int>) n_GetLuma_arrayIIIarrayIIIIIII);
				return cb_getLuma_arrayIIIarrayIIIIIII;
			}

			static void n_GetLuma_arrayIIIarrayIIIIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4, int p5, int p6, int p7, int p8, int p9)
			{
				global::Org.Jcodec.Codecs.H264.Decode.BlockInterpolator.ILumaInterpolator __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.BlockInterpolator.ILumaInterpolator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
				int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
				__this.GetLuma (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
			}
#pragma warning restore 0169

			IntPtr id_getLuma_arrayIIIarrayIIIIIII;
			public unsafe void GetLuma (int[] p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7, int p8, int p9)
			{
				if (id_getLuma_arrayIIIarrayIIIIIII == IntPtr.Zero)
					id_getLuma_arrayIIIarrayIIIIIII = JNIEnv.GetMethodID (class_ref, "getLuma", "([III[IIIIIII)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLuma_arrayIIIarrayIIIIIII, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/BlockInterpolator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlockInterpolator); }
		}

		protected BlockInterpolator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/constructor[@name='BlockInterpolator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlockInterpolator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlockInterpolator)) {
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

		static IntPtr id_getBlockChroma_arrayIIIarrayIIIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/method[@name='getBlockChroma' and count(parameter)=10 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='int']]"
		[Register ("getBlockChroma", "([III[IIIIIII)V", "")]
		public static unsafe void GetBlockChroma (int[] p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7, int p8, int p9)
		{
			if (id_getBlockChroma_arrayIIIarrayIIIIIII == IntPtr.Zero)
				id_getBlockChroma_arrayIIIarrayIIIIIII = JNIEnv.GetStaticMethodID (class_ref, "getBlockChroma", "([III[IIIIIII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getBlockChroma_arrayIIIarrayIIIIIII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='BlockInterpolator']/method[@name='getBlockLuma' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.Picture'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("getBlockLuma", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;IIIII)V", "")]
		public static unsafe void GetBlockLuma (global::Org.Jcodec.Common.Model.Picture p0, global::Org.Jcodec.Common.Model.Picture p1, int p2, int p3, int p4, int p5, int p6)
		{
			if (id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII == IntPtr.Zero)
				id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII = JNIEnv.GetStaticMethodID (class_ref, "getBlockLuma", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/Picture;IIIII)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getBlockLuma_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_Picture_IIIII, __args);
			} finally {
			}
		}

	}
}
