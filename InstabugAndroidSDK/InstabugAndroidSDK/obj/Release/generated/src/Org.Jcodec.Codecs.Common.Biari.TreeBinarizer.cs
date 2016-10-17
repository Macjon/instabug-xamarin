using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='TreeBinarizer']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/TreeBinarizer", DoNotGenerateAcw=true)]
	public partial class TreeBinarizer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/TreeBinarizer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TreeBinarizer); }
		}

		protected TreeBinarizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='TreeBinarizer']/constructor[@name='TreeBinarizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TreeBinarizer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (TreeBinarizer)) {
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

		static Delegate cb_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_;
#pragma warning disable 0169
		static Delegate GetBinarize_ILorg_jcodec_codecs_common_biari_MQEncoder_Handler ()
		{
			if (cb_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_ == null)
				cb_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_);
			return cb_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_;
		}

		static void n_Binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Codecs.Common.Biari.TreeBinarizer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.TreeBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MQEncoder p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MQEncoder> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Binarize (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='TreeBinarizer']/method[@name='binarize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.common.biari.MQEncoder']]"
		[Register ("binarize", "(ILorg/jcodec/codecs/common/biari/MQEncoder;)V", "GetBinarize_ILorg_jcodec_codecs_common_biari_MQEncoder_Handler")]
		public virtual unsafe void Binarize (int p0, global::Org.Jcodec.Codecs.Common.Biari.MQEncoder p1)
		{
			if (id_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_ == IntPtr.Zero)
				id_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_ = JNIEnv.GetMethodID (class_ref, "binarize", "(ILorg/jcodec/codecs/common/biari/MQEncoder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_binarize_ILorg_jcodec_codecs_common_biari_MQEncoder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "binarize", "(ILorg/jcodec/codecs/common/biari/MQEncoder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_;
#pragma warning disable 0169
		static Delegate GetDebinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_Handler ()
		{
			if (cb_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_ == null)
				cb_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_);
			return cb_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_;
		}

		static int n_Debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Common.Biari.TreeBinarizer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.TreeBinarizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Codecs.Common.Biari.MQDecoder p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.MQDecoder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Debinarize (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='TreeBinarizer']/method[@name='debinarize' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.common.biari.MQDecoder']]"
		[Register ("debinarize", "(Lorg/jcodec/codecs/common/biari/MQDecoder;)I", "GetDebinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_Handler")]
		public virtual unsafe int Debinarize (global::Org.Jcodec.Codecs.Common.Biari.MQDecoder p0)
		{
			if (id_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_ == IntPtr.Zero)
				id_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_ = JNIEnv.GetMethodID (class_ref, "debinarize", "(Lorg/jcodec/codecs/common/biari/MQDecoder;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_debinarize_Lorg_jcodec_codecs_common_biari_MQDecoder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "debinarize", "(Lorg/jcodec/codecs/common/biari/MQDecoder;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
