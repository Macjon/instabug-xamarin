using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio']"
	[global::Android.Runtime.Register ("org/jcodec/audio/Audio", DoNotGenerateAcw=true)]
	public partial class Audio : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']"
		[global::Android.Runtime.Register ("org/jcodec/audio/Audio$DummyFilter", DoNotGenerateAcw=true)]
		public partial class DummyFilter : global::Java.Lang.Object, global::Org.Jcodec.Audio.IAudioFilter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/audio/Audio$DummyFilter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DummyFilter); }
			}

			protected DummyFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']/constructor[@name='Audio.DummyFilter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe DummyFilter (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (DummyFilter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
						return;
					}

					if (id_ctor_I == IntPtr.Zero)
						id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
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
				global::Org.Jcodec.Audio.Audio.DummyFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.Audio.DummyFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Delay;
			}
#pragma warning restore 0169

			static IntPtr id_getDelay;
			public virtual unsafe int Delay {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']/method[@name='getDelay' and count(parameter)=0]"
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
				global::Org.Jcodec.Audio.Audio.DummyFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.Audio.DummyFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NInputs;
			}
#pragma warning restore 0169

			static IntPtr id_getNInputs;
			public virtual unsafe int NInputs {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']/method[@name='getNInputs' and count(parameter)=0]"
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
				global::Org.Jcodec.Audio.Audio.DummyFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.Audio.DummyFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NOutputs;
			}
#pragma warning restore 0169

			static IntPtr id_getNOutputs;
			public virtual unsafe int NOutputs {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']/method[@name='getNOutputs' and count(parameter)=0]"
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

			static void n_Filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Org.Jcodec.Audio.Audio.DummyFilter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.Audio.DummyFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.FloatBuffer[] p0 = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
				long[] p1 = (long[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (long));
				global::Java.Nio.FloatBuffer[] p2 = (global::Java.Nio.FloatBuffer[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Nio.FloatBuffer));
				__this.Filter (p0, p1, p2);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			static IntPtr id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio.DummyFilter']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.nio.FloatBuffer[]'] and parameter[2][@type='long[]'] and parameter[3][@type='java.nio.FloatBuffer[]']]"
			[Register ("filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V", "GetFilter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_Handler")]
			public virtual unsafe void Filter (global::Java.Nio.FloatBuffer[] p0, long[] p1, global::Java.Nio.FloatBuffer[] p2)
			{
				if (id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ == IntPtr.Zero)
					id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filter_arrayLjava_nio_FloatBuffer_arrayJarrayLjava_nio_FloatBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "([Ljava/nio/FloatBuffer;[J[Ljava/nio/FloatBuffer;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/Audio", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Audio); }
		}

		protected Audio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio']/constructor[@name='Audio' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Audio ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Audio)) {
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

		static IntPtr id_print_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio']/method[@name='print' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
		[Register ("print", "(Ljava/nio/FloatBuffer;)V", "")]
		public static unsafe void Print (global::Java.Nio.FloatBuffer p0)
		{
			if (id_print_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_print_Ljava_nio_FloatBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "print", "(Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_print_Ljava_nio_FloatBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_rotate_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='Audio']/method[@name='rotate' and count(parameter)=1 and parameter[1][@type='java.nio.FloatBuffer']]"
		[Register ("rotate", "(Ljava/nio/FloatBuffer;)V", "")]
		public static unsafe void Rotate (global::Java.Nio.FloatBuffer p0)
		{
			if (id_rotate_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_rotate_Ljava_nio_FloatBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "rotate", "(Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_rotate_Ljava_nio_FloatBuffer_, __args);
			} finally {
			}
		}

	}
}
