using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACUtils']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/AACUtils", DoNotGenerateAcw=true)]
	public partial class AACUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACUtils.AudioInfo']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/aac/AACUtils$AudioInfo", DoNotGenerateAcw=true)]
		public partial class AudioInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/aac/AACUtils$AudioInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AudioInfo); }
			}

			protected AudioInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getLabels;
#pragma warning disable 0169
			static Delegate GetGetLabelsHandler ()
			{
				if (cb_getLabels == null)
					cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
				return cb_getLabels;
			}

			static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.AACUtils.AudioInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.AACUtils.AudioInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetLabels ());
			}
#pragma warning restore 0169

			static IntPtr id_getLabels;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACUtils.AudioInfo']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;", "GetGetLabelsHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] GetLabels ()
			{
				if (id_getLabels == IntPtr.Zero)
					id_getLabels = JNIEnv.GetMethodID (class_ref, "getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;");
				try {

					if (GetType () == ThresholdType)
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabels), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
					else
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabels", "()[Lorg/jcodec/common/model/ChannelLabel;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/AACUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AACUtils); }
		}

		protected AACUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACUtils']/constructor[@name='AACUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AACUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AACUtils)) {
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

		static IntPtr id_parseAudioInfo_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='AACUtils']/method[@name='parseAudioInfo' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseAudioInfo", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/aac/AACUtils$AudioInfo;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.AACUtils.AudioInfo ParseAudioInfo (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parseAudioInfo_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parseAudioInfo_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parseAudioInfo", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/aac/AACUtils$AudioInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Aac.AACUtils.AudioInfo __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.AACUtils.AudioInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseAudioInfo_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
