using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']"
	[global::Android.Runtime.Register ("org/jcodec/audio/ConvolutionFilter", DoNotGenerateAcw=true)]
	public abstract partial class ConvolutionFilter : global::Java.Lang.Object, global::Org.Jcodec.Audio.IAudioFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/ConvolutionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvolutionFilter); }
		}

		protected ConvolutionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/constructor[@name='ConvolutionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConvolutionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConvolutionFilter)) {
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
			global::Org.Jcodec.Audio.ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		public virtual unsafe int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='getDelay' and count(parameter)=0]"
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
			global::Org.Jcodec.Audio.ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NInputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNInputs;
		public virtual unsafe int NInputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='getNInputs' and count(parameter)=0]"
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
			global::Org.Jcodec.Audio.ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NOutputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNOutputs;
		public virtual unsafe int NOutputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='getNOutputs' and count(parameter)=0]"
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

		static Delegate cb_buildKernel;
#pragma warning disable 0169
		static Delegate GetBuildKernelHandler ()
		{
			if (cb_buildKernel == null)
				cb_buildKernel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildKernel);
			return cb_buildKernel;
		}

		static IntPtr n_BuildKernel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BuildKernel ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='buildKernel' and count(parameter)=0]"
		[Register ("buildKernel", "()[D", "GetBuildKernelHandler")]
		protected abstract double[] BuildKernel ();

		static Delegate cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetFilter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_Handler ()
		{
			if (cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ == null)
				cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_);
			return cb_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
		}

		static void n_Filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_pos, IntPtr native__out)
		{
			global::Org.Jcodec.Audio.ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer[] @in = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native__in, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			long[] pos = (long[]) JNIEnv.GetArray (native_pos, JniHandleOwnership.DoNotTransfer, typeof (long));
			global::Java.Nio.FloatBuffer[] @out = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native__out, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			__this.Filter (@in, pos, @out);
			if (@in != null)
				JNIEnv.CopyArray (@in, native__in);
			if (pos != null)
				JNIEnv.CopyArray (pos, native_pos);
			if (@out != null)
				JNIEnv.CopyArray (@out, native__out);
		}
#pragma warning restore 0169

		static IntPtr id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.nio.FloatBuffer[]'] and parameter[2][@type='long[]'] and parameter[3][@type='java.nio.FloatBuffer[]']]"
		[Register ("filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V", "GetFilter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void Filter (global::Java.Nio.FloatBuffer[] @in, long[] pos, global::Java.Nio.FloatBuffer[] @out)
		{
			if (id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ == IntPtr.Zero)
				id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V");
			IntPtr native__in = JNIEnv.NewArray (@in);
			IntPtr native_pos = JNIEnv.NewArray (pos);
			IntPtr native__out = JNIEnv.NewArray (@out);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__in);
				__args [1] = new JValue (native_pos);
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
				if (pos != null) {
					JNIEnv.CopyArray (native_pos, pos);
					JNIEnv.DeleteLocalRef (native_pos);
				}
				if (@out != null) {
					JNIEnv.CopyArray (native__out, @out);
					JNIEnv.DeleteLocalRef (native__out);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/audio/ConvolutionFilter", DoNotGenerateAcw=true)]
	internal partial class ConvolutionFilterInvoker : ConvolutionFilter {

		public ConvolutionFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConvolutionFilterInvoker); }
		}

		static IntPtr id_buildKernel;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='ConvolutionFilter']/method[@name='buildKernel' and count(parameter)=0]"
		[Register ("buildKernel", "()[D", "GetBuildKernelHandler")]
		protected override unsafe double[] BuildKernel ()
		{
			if (id_buildKernel == IntPtr.Zero)
				id_buildKernel = JNIEnv.GetMethodID (class_ref, "buildKernel", "()[D");
			try {
				return (double[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildKernel), JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}

}
