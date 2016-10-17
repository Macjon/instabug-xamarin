using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/AudioFrame", DoNotGenerateAcw=true)]
	public partial class AudioFrame : global::Org.Jcodec.Common.Model.AudioBuffer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/AudioFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioFrame); }
		}

		protected AudioFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_common_model_AudioBuffer_JJJI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']/constructor[@name='AudioFrame' and count(parameter)=5 and parameter[1][@type='org.jcodec.common.model.AudioBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/AudioBuffer;JJJI)V", "")]
		public unsafe AudioFrame (global::Org.Jcodec.Common.Model.AudioBuffer p0, long p1, long p2, long p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (AudioFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/common/model/AudioBuffer;JJJI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/AudioBuffer;JJJI)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_AudioBuffer_JJJI == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_AudioBuffer_JJJI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/AudioBuffer;JJJI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_AudioBuffer_JJJI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_AudioBuffer_JJJI, __args);
			} finally {
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioFrame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameNo;
#pragma warning disable 0169
		static Delegate GetGetFrameNoHandler ()
		{
			if (cb_getFrameNo == null)
				cb_getFrameNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameNo);
			return cb_getFrameNo;
		}

		static int n_GetFrameNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioFrame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameNo;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameNo;
		public virtual unsafe int FrameNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']/method[@name='getFrameNo' and count(parameter)=0]"
			[Register ("getFrameNo", "()I", "GetGetFrameNoHandler")]
			get {
				if (id_getFrameNo == IntPtr.Zero)
					id_getFrameNo = JNIEnv.GetMethodID (class_ref, "getFrameNo", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameNo);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameNo", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPts;
#pragma warning disable 0169
		static Delegate GetGetPtsHandler ()
		{
			if (cb_getPts == null)
				cb_getPts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPts);
			return cb_getPts;
		}

		static long n_GetPts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioFrame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pts;
		}
#pragma warning restore 0169

		static IntPtr id_getPts;
		public virtual unsafe long Pts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']/method[@name='getPts' and count(parameter)=0]"
			[Register ("getPts", "()J", "GetGetPtsHandler")]
			get {
				if (id_getPts == IntPtr.Zero)
					id_getPts = JNIEnv.GetMethodID (class_ref, "getPts", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPts);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPts", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimescale;
#pragma warning disable 0169
		static Delegate GetGetTimescaleHandler ()
		{
			if (cb_getTimescale == null)
				cb_getTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimescale);
			return cb_getTimescale;
		}

		static long n_GetTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.AudioFrame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.AudioFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timescale;
		}
#pragma warning restore 0169

		static IntPtr id_getTimescale;
		public virtual unsafe long Timescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='AudioFrame']/method[@name='getTimescale' and count(parameter)=0]"
			[Register ("getTimescale", "()J", "GetGetTimescaleHandler")]
			get {
				if (id_getTimescale == IntPtr.Zero)
					id_getTimescale = JNIEnv.GetMethodID (class_ref, "getTimescale", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimescale);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimescale", "()J"));
				} finally {
				}
			}
		}

	}
}
