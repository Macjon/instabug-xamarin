using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Prores {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='DCT2Prores']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/prores/DCT2Prores", DoNotGenerateAcw=true)]
	public partial class DCT2Prores : global::Org.Jcodec.Codecs.Prores.ProresEncoder {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/prores/DCT2Prores", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DCT2Prores); }
		}

		protected DCT2Prores (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_codecs_prores_ProresEncoder_Profile_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.prores']/class[@name='DCT2Prores']/constructor[@name='DCT2Prores' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.prores.ProresEncoder.Profile']]"
		[Register (".ctor", "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", "")]
		public unsafe DCT2Prores (global::Org.Jcodec.Codecs.Prores.ProresEncoder.Profile profile)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (profile);
				if (((object) this).GetType () != typeof (DCT2Prores)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/codecs/prores/ProresEncoder$Profile;)V", __args),
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

	}
}
