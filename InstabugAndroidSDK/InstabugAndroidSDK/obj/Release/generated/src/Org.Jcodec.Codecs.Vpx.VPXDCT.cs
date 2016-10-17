using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vpx {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vpx/VPXDCT", DoNotGenerateAcw=true)]
	public partial class VPXDCT : global::Java.Lang.Object {


		static IntPtr cospi8sqrt2minus1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/field[@name='cospi8sqrt2minus1']"
		[Register ("cospi8sqrt2minus1")]
		public static int Cospi8sqrt2minus1 {
			get {
				if (cospi8sqrt2minus1_jfieldId == IntPtr.Zero)
					cospi8sqrt2minus1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cospi8sqrt2minus1", "I");
				return JNIEnv.GetStaticIntField (class_ref, cospi8sqrt2minus1_jfieldId);
			}
			set {
				if (cospi8sqrt2minus1_jfieldId == IntPtr.Zero)
					cospi8sqrt2minus1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cospi8sqrt2minus1", "I");
				try {
					JNIEnv.SetStaticField (class_ref, cospi8sqrt2minus1_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sinpi8sqrt2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/field[@name='sinpi8sqrt2']"
		[Register ("sinpi8sqrt2")]
		public static int Sinpi8sqrt2 {
			get {
				if (sinpi8sqrt2_jfieldId == IntPtr.Zero)
					sinpi8sqrt2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sinpi8sqrt2", "I");
				return JNIEnv.GetStaticIntField (class_ref, sinpi8sqrt2_jfieldId);
			}
			set {
				if (sinpi8sqrt2_jfieldId == IntPtr.Zero)
					sinpi8sqrt2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sinpi8sqrt2", "I");
				try {
					JNIEnv.SetStaticField (class_ref, sinpi8sqrt2_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vpx/VPXDCT", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPXDCT); }
		}

		protected VPXDCT (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/constructor[@name='VPXDCT' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VPXDCT ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VPXDCT)) {
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

		static IntPtr id_fdct4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/method[@name='fdct4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fdct4x4", "([I)V", "")]
		public static unsafe void Fdct4x4 (int[] p0)
		{
			if (id_fdct4x4_arrayI == IntPtr.Zero)
				id_fdct4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fdct4x4", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fdct4x4_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_idct4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/method[@name='idct4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("idct4x4", "([I)V", "")]
		public static unsafe void Idct4x4 (int[] p0)
		{
			if (id_idct4x4_arrayI == IntPtr.Zero)
				id_idct4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "idct4x4", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_idct4x4_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_iwalsh4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/method[@name='iwalsh4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("iwalsh4x4", "([I)V", "")]
		public static unsafe void Iwalsh4x4 (int[] p0)
		{
			if (id_iwalsh4x4_arrayI == IntPtr.Zero)
				id_iwalsh4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "iwalsh4x4", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_iwalsh4x4_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_walsh4x4_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vpx']/class[@name='VPXDCT']/method[@name='walsh4x4' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("walsh4x4", "([I)V", "")]
		public static unsafe void Walsh4x4 (int[] p0)
		{
			if (id_walsh4x4_arrayI == IntPtr.Zero)
				id_walsh4x4_arrayI = JNIEnv.GetStaticMethodID (class_ref, "walsh4x4", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_walsh4x4_arrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
