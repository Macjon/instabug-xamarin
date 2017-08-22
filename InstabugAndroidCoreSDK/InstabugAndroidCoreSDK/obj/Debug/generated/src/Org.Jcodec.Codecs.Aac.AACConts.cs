using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACConts']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/AACConts", DoNotGenerateAcw=true)]
	public partial class AACConts : global::Java.Lang.Object {


		static IntPtr AAC_CHANNEL_COUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACConts']/field[@name='AAC_CHANNEL_COUNT']"
		[Register ("AAC_CHANNEL_COUNT")]
		public static IList<short> AacChannelCount {
			get {
				if (AAC_CHANNEL_COUNT_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_COUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_COUNT", "[S");
				return global::Android.Runtime.JavaArray<short>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_COUNT_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AAC_SAMPLE_RATES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACConts']/field[@name='AAC_SAMPLE_RATES']"
		[Register ("AAC_SAMPLE_RATES")]
		public static IList<int> AacSampleRates {
			get {
				if (AAC_SAMPLE_RATES_jfieldId == IntPtr.Zero)
					AAC_SAMPLE_RATES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_SAMPLE_RATES", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, AAC_SAMPLE_RATES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AAC_SAMPLE_RATES_jfieldId == IntPtr.Zero)
					AAC_SAMPLE_RATES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_SAMPLE_RATES", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, AAC_SAMPLE_RATES_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/AACConts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AACConts); }
		}

		protected AACConts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACConts']/constructor[@name='AACConts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AACConts ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AACConts)) {
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

	}
}
