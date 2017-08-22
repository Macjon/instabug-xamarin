using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioBuffer']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/AudioBuffer", DoNotGenerateAcw=true)]
	public partial class AudioBuffer : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/AudioBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioBuffer); }
		}

		protected AudioBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_common_model_AudioBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioBuffer']/constructor[@name='AudioBuffer' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.AudioBuffer']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/AudioBuffer;)V", "")]
		public unsafe AudioBuffer (global::Org.Jcodec.Common.Model.AudioBuffer other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				if (((object) this).GetType () != typeof (AudioBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/AudioBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/AudioBuffer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_AudioBuffer_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_AudioBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/AudioBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_AudioBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_AudioBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public virtual unsafe global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioBuffer']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNFrames;
#pragma warning disable 0169
		static Delegate GetGetNFramesHandler ()
		{
			if (cb_getNFrames == null)
				cb_getNFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNFrames);
			return cb_getNFrames;
		}

		static int n_GetNFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getNFrames;
		public virtual unsafe int NFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioBuffer']/method[@name='getNFrames' and count(parameter)=0]"
			[Register ("getNFrames", "()I", "GetGetNFramesHandler")]
			get {
				if (id_getNFrames == IntPtr.Zero)
					id_getNFrames = JNIEnv.GetMethodID (class_ref, "getNFrames", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNFrames);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNFrames", "()I"));
				} finally {
				}
			}
		}

	}
}
