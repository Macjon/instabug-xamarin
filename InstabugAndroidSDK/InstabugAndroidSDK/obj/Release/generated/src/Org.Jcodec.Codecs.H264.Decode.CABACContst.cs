using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/CABACContst", DoNotGenerateAcw=true)]
	public partial class CABACContst : global::Java.Lang.Object {


		static IntPtr cabac_context_init_I_A_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']/field[@name='cabac_context_init_I_A']"
		[Register ("cabac_context_init_I_A")]
		public static IList<int> CabacContextInitIA {
			get {
				if (cabac_context_init_I_A_jfieldId == IntPtr.Zero)
					cabac_context_init_I_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_I_A", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, cabac_context_init_I_A_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cabac_context_init_I_A_jfieldId == IntPtr.Zero)
					cabac_context_init_I_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_I_A", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cabac_context_init_I_A_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cabac_context_init_I_B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']/field[@name='cabac_context_init_I_B']"
		[Register ("cabac_context_init_I_B")]
		public static IList<int> CabacContextInitIB {
			get {
				if (cabac_context_init_I_B_jfieldId == IntPtr.Zero)
					cabac_context_init_I_B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_I_B", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, cabac_context_init_I_B_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cabac_context_init_I_B_jfieldId == IntPtr.Zero)
					cabac_context_init_I_B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_I_B", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cabac_context_init_I_B_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cabac_context_init_PB_A_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']/field[@name='cabac_context_init_PB_A']"
		[Register ("cabac_context_init_PB_A")]
		public static IList<int[]> CabacContextInitPBA {
			get {
				if (cabac_context_init_PB_A_jfieldId == IntPtr.Zero)
					cabac_context_init_PB_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_PB_A", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, cabac_context_init_PB_A_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cabac_context_init_PB_A_jfieldId == IntPtr.Zero)
					cabac_context_init_PB_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_PB_A", "[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cabac_context_init_PB_A_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cabac_context_init_PB_B_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']/field[@name='cabac_context_init_PB_B']"
		[Register ("cabac_context_init_PB_B")]
		public static IList<int[]> CabacContextInitPBB {
			get {
				if (cabac_context_init_PB_B_jfieldId == IntPtr.Zero)
					cabac_context_init_PB_B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_PB_B", "[[I");
				return global::Android.Runtime.JavaArray<int[]>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, cabac_context_init_PB_B_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cabac_context_init_PB_B_jfieldId == IntPtr.Zero)
					cabac_context_init_PB_B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cabac_context_init_PB_B", "[[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int[]>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cabac_context_init_PB_B_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/CABACContst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CABACContst); }
		}

		protected CABACContst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode']/class[@name='CABACContst']/constructor[@name='CABACContst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CABACContst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CABACContst)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

	}
}
