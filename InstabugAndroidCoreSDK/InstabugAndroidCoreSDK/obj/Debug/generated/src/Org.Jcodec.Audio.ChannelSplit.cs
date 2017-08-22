using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ChannelSplit']"
	[global::Android.Runtime.Register ("org/jcodec/audio/ChannelSplit", DoNotGenerateAcw=true)]
	public partial class ChannelSplit : global::Java.Lang.Object, global::Org.Jcodec.Audio.IAudioFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/ChannelSplit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelSplit); }
		}

		protected ChannelSplit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDelay;
#pragma warning disable 0169
		static Delegate GetGetDelayHandler ()
		{
			if (cb_getDelay == null)
				cb_getDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDelay);
			return cb_getDelay;
		}

		static int n_GetDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.ChannelSplit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ChannelSplit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		public virtual unsafe int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ChannelSplit']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDelay);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNInputs;
#pragma warning disable 0169
		static Delegate GetGetNInputsHandler ()
		{
			if (cb_getNInputs == null)
				cb_getNInputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNInputs);
			return cb_getNInputs;
		}

		static int n_GetNInputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.ChannelSplit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ChannelSplit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NInputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNInputs;
		public virtual unsafe int NInputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ChannelSplit']/method[@name='getNInputs' and count(parameter)=0]"
			[Register ("getNInputs", "()I", "GetGetNInputsHandler")]
			get {
				if (id_getNInputs == IntPtr.Zero)
					id_getNInputs = JNIEnv.GetMethodID (class_ref, "getNInputs", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNInputs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNInputs", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNOutputs;
#pragma warning disable 0169
		static Delegate GetGetNOutputsHandler ()
		{
			if (cb_getNOutputs == null)
				cb_getNOutputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNOutputs);
			return cb_getNOutputs;
		}

		static int n_GetNOutputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.ChannelSplit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ChannelSplit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NOutputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNOutputs;
		public virtual unsafe int NOutputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ChannelSplit']/method[@name='getNOutputs' and count(parameter)=0]"
			[Register ("getNOutputs", "()I", "GetGetNOutputsHandler")]
			get {
				if (id_getNOutputs == IntPtr.Zero)
					id_getNOutputs = JNIEnv.GetMethodID (class_ref, "getNOutputs", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNOutputs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNOutputs", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetFilter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_Handler ()
		{
			if (cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ == null)
				cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_);
			return cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
		}

		static void n_Filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_inPos, IntPtr native__out)
		{
			global::Org.Jcodec.Audio.ChannelSplit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ChannelSplit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer[] @in = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native__in, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			long[] inPos = (long[]) JNIEnv.GetArray (native_inPos, JniHandleOwnership.DoNotTransfer, typeof (long));
			global::Java.Nio.FloatBuffer[] @out = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native__out, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			__this.Filter (@in, inPos, @out);
			if (@in != null)
				JNIEnv.CopyArray (@in, native__in);
			if (inPos != null)
				JNIEnv.CopyArray (inPos, native_inPos);
			if (@out != null)
				JNIEnv.CopyArray (@out, native__out);
		}
#pragma warning restore 0169

		static IntPtr id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ChannelSplit']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.nio.FloatBuffer[]'] and parameter[2][@type='long[]'] and parameter[3][@type='java.nio.FloatBuffer[]']]"
		[Register ("filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V", "GetFilter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void Filter (global::Java.Nio.FloatBuffer[] @in, long[] inPos, global::Java.Nio.FloatBuffer[] @out)
		{
			if (id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ == IntPtr.Zero)
				id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V");
			IntPtr native__in = JNIEnv.NewArray (@in);
			IntPtr native_inPos = JNIEnv.NewArray (inPos);
			IntPtr native__out = JNIEnv.NewArray (@out);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native_inPos);
				__args [2] = new JValue (native__out);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V"), __args);
			} finally {
				if (@in != null) {
					JNIEnv.CopyArray (native__in, @in);
					JNIEnv.DeleteLocalRef (native__in);
				}
				if (inPos != null) {
					JNIEnv.CopyArray (native_inPos, inPos);
					JNIEnv.DeleteLocalRef (native_inPos);
				}
				if (@out != null) {
					JNIEnv.CopyArray (native__out, @out);
					JNIEnv.DeleteLocalRef (native__out);
				}
			}
		}

	}
}
