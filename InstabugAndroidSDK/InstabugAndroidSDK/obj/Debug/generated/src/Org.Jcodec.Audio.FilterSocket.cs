using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']"
	[global::Android.Runtime.Register ("org/jcodec/audio/FilterSocket", DoNotGenerateAcw=true)]
	public partial class FilterSocket : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/FilterSocket", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilterSocket); }
		}

		protected FilterSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLorg_jcodec_audio_AudioFilter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/constructor[@name='FilterSocket' and count(parameter)=1 and parameter[1][@type='org.jcodec.audio.AudioFilter...']]"
		[Register (".ctor", "([Lorg/jcodec/audio/AudioFilter;)V", "")]
		public unsafe FilterSocket (params global:: Org.Jcodec.Audio.IAudioFilter[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (FilterSocket)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lorg/jcodec/audio/AudioFilter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lorg/jcodec/audio/AudioFilter;)V", __args);
					return;
				}

				if (id_ctor_arrayLorg_jcodec_audio_AudioFilter_ == IntPtr.Zero)
					id_ctor_arrayLorg_jcodec_audio_AudioFilter_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lorg/jcodec/audio/AudioFilter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLorg_jcodec_audio_AudioFilter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLorg_jcodec_audio_AudioFilter_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getTotalInputs;
#pragma warning disable 0169
		static Delegate GetGetTotalInputsHandler ()
		{
			if (cb_getTotalInputs == null)
				cb_getTotalInputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalInputs);
			return cb_getTotalInputs;
		}

		static int n_GetTotalInputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalInputs;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalInputs;
		public virtual unsafe int TotalInputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='getTotalInputs' and count(parameter)=0]"
			[Register ("getTotalInputs", "()I", "GetGetTotalInputsHandler")]
			get {
				if (id_getTotalInputs == IntPtr.Zero)
					id_getTotalInputs = JNIEnv.GetMethodID (class_ref, "getTotalInputs", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalInputs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalInputs", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalOutputs;
#pragma warning disable 0169
		static Delegate GetGetTotalOutputsHandler ()
		{
			if (cb_getTotalOutputs == null)
				cb_getTotalOutputs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalOutputs);
			return cb_getTotalOutputs;
		}

		static int n_GetTotalOutputs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalOutputs;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalOutputs;
		public virtual unsafe int TotalOutputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='getTotalOutputs' and count(parameter)=0]"
			[Register ("getTotalOutputs", "()I", "GetGetTotalOutputsHandler")]
			get {
				if (id_getTotalOutputs == IntPtr.Zero)
					id_getTotalOutputs = JNIEnv.GetMethodID (class_ref, "getTotalOutputs", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalOutputs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalOutputs", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_allocateBuffers_I;
#pragma warning disable 0169
		static Delegate GetAllocateBuffers_IHandler ()
		{
			if (cb_allocateBuffers_I == null)
				cb_allocateBuffers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AllocateBuffers_I);
			return cb_allocateBuffers_I;
		}

		static void n_AllocateBuffers_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllocateBuffers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_allocateBuffers_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='allocateBuffers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("allocateBuffers", "(I)V", "GetAllocateBuffers_IHandler")]
		public virtual unsafe void AllocateBuffers (int p0)
		{
			if (id_allocateBuffers_I == IntPtr.Zero)
				id_allocateBuffers_I = JNIEnv.GetMethodID (class_ref, "allocateBuffers", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_allocateBuffers_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allocateBuffers", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_filter_arrayLjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetFilter_arrayLjava_nio_FloatBuffer_Handler ()
		{
			if (cb_filter_arrayLjava_nio_FloatBuffer_ == null)
				cb_filter_arrayLjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Filter_arrayLjava_nio_FloatBuffer_);
			return cb_filter_arrayLjava_nio_FloatBuffer_;
		}

		static void n_Filter_arrayLjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer[] p0 = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			__this.Filter (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_filter_arrayLjava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer[]']]"
		[Register ("filter", "([Ljava/nio/FloatBuffer;)V", "GetFilter_arrayLjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void Filter (global::Java.Nio.FloatBuffer[] p0)
		{
			if (id_filter_arrayLjava_nio_FloatBuffer_ == IntPtr.Zero)
				id_filter_arrayLjava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "filter", "([Ljava/nio/FloatBuffer;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filter_arrayLjava_nio_FloatBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "([Ljava/nio/FloatBuffer;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getPositions;
#pragma warning disable 0169
		static Delegate GetGetPositionsHandler ()
		{
			if (cb_getPositions == null)
				cb_getPositions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPositions);
			return cb_getPositions;
		}

		static IntPtr n_GetPositions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPositions ());
		}
#pragma warning restore 0169

		static IntPtr id_getPositions;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='getPositions' and count(parameter)=0]"
		[Register ("getPositions", "()[J", "GetGetPositionsHandler")]
		public virtual unsafe long[] GetPositions ()
		{
			if (id_getPositions == IntPtr.Zero)
				id_getPositions = JNIEnv.GetMethodID (class_ref, "getPositions", "()[J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPositions), JniHandleOwnership.TransferLocalRef, typeof (long));
				else
					return (long[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositions", "()[J")), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_rotate;
#pragma warning disable 0169
		static Delegate GetRotateHandler ()
		{
			if (cb_rotate == null)
				cb_rotate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Rotate);
			return cb_rotate;
		}

		static void n_Rotate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotate ();
		}
#pragma warning restore 0169

		static IntPtr id_rotate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='rotate' and count(parameter)=0]"
		[Register ("rotate", "()V", "GetRotateHandler")]
		public virtual unsafe void Rotate ()
		{
			if (id_rotate == IntPtr.Zero)
				id_rotate = JNIEnv.GetMethodID (class_ref, "rotate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rotate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotate", "()V"));
			} finally {
			}
		}

		static Delegate cb_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ;
#pragma warning disable 0169
		static Delegate GetSetBuffers_arrayLjava_nio_FloatBuffer_arrayJHandler ()
		{
			if (cb_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ == null)
				cb_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBuffers_arrayLjava_nio_FloatBuffer_arrayJ);
			return cb_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ;
		}

		static void n_SetBuffers_arrayLjava_nio_FloatBuffer_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Audio.FilterSocket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer[] p0 = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
			long[] p1 = (long[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (long));
			__this.SetBuffers (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterSocket']/method[@name='setBuffers' and count(parameter)=2 and parameter[1][@type='java.nio.FloatBuffer[]'] and parameter[2][@type='long[]']]"
		[Register ("setBuffers", "([Ljava/nio/FloatBuffer;[J)V", "GetSetBuffers_arrayLjava_nio_FloatBuffer_arrayJHandler")]
		public virtual unsafe void SetBuffers (global::Java.Nio.FloatBuffer[] p0, long[] p1)
		{
			if (id_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ == IntPtr.Zero)
				id_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ = JNIEnv.GetMethodID (class_ref, "setBuffers", "([Ljava/nio/FloatBuffer;[J)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBuffers_arrayLjava_nio_FloatBuffer_arrayJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBuffers", "([Ljava/nio/FloatBuffer;[J)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
