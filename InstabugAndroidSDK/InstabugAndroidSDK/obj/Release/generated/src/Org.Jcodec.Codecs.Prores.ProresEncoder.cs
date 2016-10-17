using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresEncoder", DoNotGenerateAcw=true)]
	public partial class ProresEncoder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/prores/ProresEncoder$Profile", DoNotGenerateAcw=true)]
		public sealed partial class Profile : global::Java.Lang.Enum {


			static IntPtr HQ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/field[@name='HQ']"
			[Register ("HQ")]
			public static global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile Hq {
				get {
					if (HQ_jfieldId == IntPtr.Zero)
						HQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HQ", "Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HQ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/field[@name='LT']"
			[Register ("LT")]
			public static global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile Lt {
				get {
					if (LT_jfieldId == IntPtr.Zero)
						LT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LT", "Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROXY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/field[@name='PROXY']"
			[Register ("PROXY")]
			public static global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile Proxy {
				get {
					if (PROXY_jfieldId == IntPtr.Zero)
						PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROXY", "Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROXY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STANDARD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/field[@name='STANDARD']"
			[Register ("STANDARD")]
			public static global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile Standard {
				get {
					if (STANDARD_jfieldId == IntPtr.Zero)
						STANDARD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STANDARD", "Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STANDARD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr fourcc_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/field[@name='fourcc']"
			[Register ("fourcc")]
			public string Fourcc {
				get {
					if (fourcc_jfieldId == IntPtr.Zero)
						fourcc_jfieldId = JNIEnv.GetFieldID (class_ref, "fourcc", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fourcc_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (fourcc_jfieldId == IntPtr.Zero)
						fourcc_jfieldId = JNIEnv.GetFieldID (class_ref, "fourcc", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fourcc_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresEncoder$Profile", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Profile); }
			}

			internal Profile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/prores/ProresEncoder$Profile;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder.Profile']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/codecs/prores/ProresEncoder$Profile;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/prores/ProresEncoder$Profile;");
				try {
					return (global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/ProresEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProresEncoder); }
		}

		protected ProresEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/constructor[@name='ProresEncoder' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.prores.ProresEncoder.Profile']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", "")]
		public unsafe ProresEncoder (global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ProresEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_, __args);
			} finally {
			}
		}

		static Delegate cb_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetEncodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_ == null)
				cb_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_);
			return cb_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_;
		}

		static void n_EncodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Prores.ProresEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture[] p1 = (global::Org.Jcodec.Common.Model.Picture[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Common.Model.Picture));
			__this.EncodeFrame (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='encodeFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.common.model.Picture...']]"
		[Register ("encodeFrame", "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/model/Picture;)V", "GetEncodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void EncodeFrame (global::Java.Nio.ByteBuffer p0, params global:: Org.Jcodec.Common.Model.Picture[] p1)
		{
			if (id_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "encodeFrame", "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/model/Picture;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodeFrame_Ljava_nio_ByteBuffer_arrayLorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeFrame", "(Ljava/nio/ByteBuffer;[Lorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetEncodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_ == null)
				cb_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_EncodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_);
			return cb_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_;
		}

		static void n_EncodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Jcodec.Codecs.Prores.ProresEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[][] p2 = (int[][]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Jcodec.Common.Model.Picture p4 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.EncodePicture (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='encodePicture' and count(parameter)=5 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]'] and parameter[3][@type='int[][]'] and parameter[4][@type='int[]'] and parameter[5][@type='org.jcodec.common.model.Picture']]"
		[Register ("encodePicture", "(Ljava/nio/ByteBuffer;[[I[[I[ILorg/jcodec/common/model/Picture;)V", "GetEncodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_Handler")]
		protected virtual unsafe void EncodePicture (global::Java.Nio.ByteBuffer p0, int[][] p1, int[][] p2, int[] p3, global::Org.Jcodec.Common.Model.Picture p4)
		{
			if (id_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "encodePicture", "(Ljava/nio/ByteBuffer;[[I[[I[ILorg/jcodec/common/model/Picture;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_encodePicture_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayILorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodePicture", "(Ljava/nio/ByteBuffer;[[I[[I[ILorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ;
#pragma warning disable 0169
		static Delegate GetEncodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZHandler ()
		{
			if (cb_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ == null)
				cb_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int, int, int, bool, int>) n_EncodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ);
			return cb_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ;
		}

		static int n_EncodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, int p5, int p6, IntPtr native_p7, int p8, int p9, int p10, bool p11)
		{
			global::Org.Jcodec.Codecs.Prores.ProresEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Prores.ProresEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[][] p1 = (int[][]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[][] p2 = (int[][]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Jcodec.Common.Model.Picture p7 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p7, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncodeSlice (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='encodeSlice' and count(parameter)=12 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[][]'] and parameter[3][@type='int[][]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='org.jcodec.common.model.Picture'] and parameter[9][@type='int'] and parameter[10][@type='int'] and parameter[11][@type='int'] and parameter[12][@type='boolean']]"
		[Register ("encodeSlice", "(Ljava/nio/ByteBuffer;[[I[[I[IIIILorg/jcodec/common/model/Picture;IIIZ)I", "GetEncodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZHandler")]
		protected virtual unsafe int EncodeSlice (global::Java.Nio.ByteBuffer p0, int[][] p1, int[][] p2, int[] p3, int p4, int p5, int p6, global::Org.Jcodec.Common.Model.Picture p7, int p8, int p9, int p10, bool p11)
		{
			if (id_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ == IntPtr.Zero)
				id_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ = JNIEnv.GetMethodID (class_ref, "encodeSlice", "(Ljava/nio/ByteBuffer;[[I[[I[IIIILorg/jcodec/common/model/Picture;IIIZ)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (p8);
				__args [9] = new JValue (p9);
				__args [10] = new JValue (p10);
				__args [11] = new JValue (p11);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_encodeSlice_Ljava_nio_ByteBuffer_arrayarrayIarrayarrayIarrayIIIILorg_jcodec_common_model_Picture_IIIZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeSlice", "(Ljava/nio/ByteBuffer;[[I[[I[IIIILorg/jcodec/common/model/Picture;IIIZ)I"), __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_encodeSliceData_Ljava_nio_ByteBuffer_arrayIarrayIarrayIILorg_jcodec_common_model_Picture_IarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='encodeSliceData' and count(parameter)=8 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='org.jcodec.common.model.Picture'] and parameter[7][@type='int'] and parameter[8][@type='int[]']]"
		[Register ("encodeSliceData", "(Ljava/nio/ByteBuffer;[I[I[IILorg/jcodec/common/model/Picture;I[I)V", "")]
		protected static unsafe void EncodeSliceData (global::Java.Nio.ByteBuffer p0, int[] p1, int[] p2, int[] p3, int p4, global::Org.Jcodec.Common.Model.Picture p5, int p6, int[] p7)
		{
			if (id_encodeSliceData_Ljava_nio_ByteBuffer_arrayIarrayIarrayIILorg_jcodec_common_model_Picture_IarrayI == IntPtr.Zero)
				id_encodeSliceData_Ljava_nio_ByteBuffer_arrayIarrayIarrayIILorg_jcodec_common_model_Picture_IarrayI = JNIEnv.GetStaticMethodID (class_ref, "encodeSliceData", "(Ljava/nio/ByteBuffer;[I[I[IILorg/jcodec/common/model/Picture;I[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p7 = JNIEnv.NewArray (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_encodeSliceData_Ljava_nio_ByteBuffer_arrayIarrayIarrayIILorg_jcodec_common_model_Picture_IarrayI, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p7 != null) {
					JNIEnv.CopyArray (native_p7, p7);
					JNIEnv.DeleteLocalRef (native_p7);
				}
			}
		}

		static IntPtr id_getLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='getLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLevel", "(I)I", "")]
		public static unsafe int GetLevel (int p0)
		{
			if (id_getLevel_I == IntPtr.Zero)
				id_getLevel_I = JNIEnv.GetStaticMethodID (class_ref, "getLevel", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getLevel_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeCodeword_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_prores_Codebook_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='writeCodeword' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.io.BitWriter'] and parameter[2][@type='org.jcodec.codecs.prores.Codebook'] and parameter[3][@type='int']]"
		[Register ("writeCodeword", "(Lorg/jcodec/common/io/BitWriter;Lorg/jcodec/codecs/prores/Codebook;I)V", "")]
		public static unsafe void WriteCodeword (global::Org.Jcodec.Common.IO.BitWriter p0, global::Org.Jcodec.Codecs.Prores.Codebook p1, int p2)
		{
			if (id_writeCodeword_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_prores_Codebook_I == IntPtr.Zero)
				id_writeCodeword_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_prores_Codebook_I = JNIEnv.GetStaticMethodID (class_ref, "writeCodeword", "(Lorg/jcodec/common/io/BitWriter;Lorg/jcodec/codecs/prores/Codebook;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeCodeword_Lorg_jcodec_common_io_BitWriter_Lorg_jcodec_codecs_prores_Codebook_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeFrameHeader_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_prores_ProresConsts_FrameHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='writeFrameHeader' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='org.jcodec.codecs.prores.ProresConsts.FrameHeader']]"
		[Register ("writeFrameHeader", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/prores/ProresConsts$FrameHeader;)V", "")]
		public static unsafe void WriteFrameHeader (global::Java.Nio.ByteBuffer p0, global::Org.Jcodec.Codecs.Prores.ProresConsts.FrameHeader p1)
		{
			if (id_writeFrameHeader_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_prores_ProresConsts_FrameHeader_ == IntPtr.Zero)
				id_writeFrameHeader_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_prores_ProresConsts_FrameHeader_ = JNIEnv.GetStaticMethodID (class_ref, "writeFrameHeader", "(Ljava/nio/ByteBuffer;Lorg/jcodec/codecs/prores/ProresConsts$FrameHeader;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeFrameHeader_Ljava_nio_ByteBuffer_Lorg_jcodec_codecs_prores_ProresConsts_FrameHeader_, __args);
			} finally {
			}
		}

		static IntPtr id_writePictureHeader_IILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='ProresEncoder']/method[@name='writePictureHeader' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("writePictureHeader", "(IILjava/nio/ByteBuffer;)V", "")]
		public static unsafe void WritePictureHeader (int p0, int p1, global::Java.Nio.ByteBuffer p2)
		{
			if (id_writePictureHeader_IILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_writePictureHeader_IILjava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "writePictureHeader", "(IILjava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writePictureHeader_IILjava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

	}
}
