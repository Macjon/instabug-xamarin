using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']"
	[global::Android.Runtime.Register ("org/jcodec/audio/FilterGraph", DoNotGenerateAcw=true)]
	public partial class FilterGraph : global::Java.Lang.Object, global::Org.Jcodec.Audio.IAudioFilter {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']"
		[global::Android.Runtime.Register ("org/jcodec/audio/FilterGraph$Factory", DoNotGenerateAcw=true)]
		public partial class Factory : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/audio/FilterGraph$Factory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Factory); }
			}

			protected Factory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_audio_AudioFilter_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']/constructor[@name='FilterGraph.Factory' and count(parameter)=1 and parameter[1][@type='org.jcodec.audio.AudioFilter']]"
			[Register (".ctor", "(Lorg/jcodec/audio/AudioFilter;)V", "")]
			protected unsafe Factory (global::Org.Jcodec.Audio.IAudioFilter p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (Factory)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/audio/AudioFilter;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/audio/AudioFilter;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_audio_AudioFilter_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_audio_AudioFilter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/audio/AudioFilter;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_audio_AudioFilter_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_audio_AudioFilter_, __args);
				} finally {
				}
			}

			static Delegate cb_addLevel_Lorg_jcodec_audio_AudioFilter_I;
#pragma warning disable 0169
			static Delegate GetAddLevel_Lorg_jcodec_audio_AudioFilter_IHandler ()
			{
				if (cb_addLevel_Lorg_jcodec_audio_AudioFilter_I == null)
					cb_addLevel_Lorg_jcodec_audio_AudioFilter_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AddLevel_Lorg_jcodec_audio_AudioFilter_I);
				return cb_addLevel_Lorg_jcodec_audio_AudioFilter_I;
			}

			static IntPtr n_AddLevel_Lorg_jcodec_audio_AudioFilter_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Org.Jcodec.Audio.FilterGraph.Factory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Audio.IAudioFilter p0 = (global::Org.Jcodec.Audio.IAudioFilter)global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.IAudioFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLevel (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addLevel_Lorg_jcodec_audio_AudioFilter_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']/method[@name='addLevel' and count(parameter)=2 and parameter[1][@type='org.jcodec.audio.AudioFilter'] and parameter[2][@type='int']]"
			[Register ("addLevel", "(Lorg/jcodec/audio/AudioFilter;I)Lorg/jcodec/audio/FilterGraph$Factory;", "GetAddLevel_Lorg_jcodec_audio_AudioFilter_IHandler")]
			public virtual unsafe global::Org.Jcodec.Audio.FilterGraph.Factory AddLevel (global::Org.Jcodec.Audio.IAudioFilter p0, int p1)
			{
				if (id_addLevel_Lorg_jcodec_audio_AudioFilter_I == IntPtr.Zero)
					id_addLevel_Lorg_jcodec_audio_AudioFilter_I = JNIEnv.GetMethodID (class_ref, "addLevel", "(Lorg/jcodec/audio/AudioFilter;I)Lorg/jcodec/audio/FilterGraph$Factory;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Org.Jcodec.Audio.FilterGraph.Factory __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addLevel_Lorg_jcodec_audio_AudioFilter_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLevel", "(Lorg/jcodec/audio/AudioFilter;I)Lorg/jcodec/audio/FilterGraph$Factory;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_addLevel_arrayLorg_jcodec_audio_AudioFilter_;
#pragma warning disable 0169
			static Delegate GetAddLevel_arrayLorg_jcodec_audio_AudioFilter_Handler ()
			{
				if (cb_addLevel_arrayLorg_jcodec_audio_AudioFilter_ == null)
					cb_addLevel_arrayLorg_jcodec_audio_AudioFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLevel_arrayLorg_jcodec_audio_AudioFilter_);
				return cb_addLevel_arrayLorg_jcodec_audio_AudioFilter_;
			}

			static IntPtr n_AddLevel_arrayLorg_jcodec_audio_AudioFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Audio.FilterGraph.Factory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Audio.IAudioFilter[] p0 = (global::Org.Jcodec.Audio.IAudioFilter[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Jcodec.Audio.IAudioFilter));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLevel (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addLevel_arrayLorg_jcodec_audio_AudioFilter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']/method[@name='addLevel' and count(parameter)=1 and parameter[1][@type='org.jcodec.audio.AudioFilter...']]"
			[Register ("addLevel", "([Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;", "GetAddLevel_arrayLorg_jcodec_audio_AudioFilter_Handler")]
			public virtual unsafe global::Org.Jcodec.Audio.FilterGraph.Factory AddLevel (params global:: Org.Jcodec.Audio.IAudioFilter[] p0)
			{
				if (id_addLevel_arrayLorg_jcodec_audio_AudioFilter_ == IntPtr.Zero)
					id_addLevel_arrayLorg_jcodec_audio_AudioFilter_ = JNIEnv.GetMethodID (class_ref, "addLevel", "([Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Org.Jcodec.Audio.FilterGraph.Factory __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addLevel_arrayLorg_jcodec_audio_AudioFilter_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLevel", "([Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_addLevelSpan_Lorg_jcodec_audio_AudioFilter_;
#pragma warning disable 0169
			static Delegate GetAddLevelSpan_Lorg_jcodec_audio_AudioFilter_Handler ()
			{
				if (cb_addLevelSpan_Lorg_jcodec_audio_AudioFilter_ == null)
					cb_addLevelSpan_Lorg_jcodec_audio_AudioFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddLevelSpan_Lorg_jcodec_audio_AudioFilter_);
				return cb_addLevelSpan_Lorg_jcodec_audio_AudioFilter_;
			}

			static IntPtr n_AddLevelSpan_Lorg_jcodec_audio_AudioFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Audio.FilterGraph.Factory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Audio.IAudioFilter p0 = (global::Org.Jcodec.Audio.IAudioFilter)global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.IAudioFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLevelSpan (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_addLevelSpan_Lorg_jcodec_audio_AudioFilter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']/method[@name='addLevelSpan' and count(parameter)=1 and parameter[1][@type='org.jcodec.audio.AudioFilter']]"
			[Register ("addLevelSpan", "(Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;", "GetAddLevelSpan_Lorg_jcodec_audio_AudioFilter_Handler")]
			public virtual unsafe global::Org.Jcodec.Audio.FilterGraph.Factory AddLevelSpan (global::Org.Jcodec.Audio.IAudioFilter p0)
			{
				if (id_addLevelSpan_Lorg_jcodec_audio_AudioFilter_ == IntPtr.Zero)
					id_addLevelSpan_Lorg_jcodec_audio_AudioFilter_ = JNIEnv.GetMethodID (class_ref, "addLevelSpan", "(Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Org.Jcodec.Audio.FilterGraph.Factory __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addLevelSpan_Lorg_jcodec_audio_AudioFilter_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLevelSpan", "(Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_create;
#pragma warning disable 0169
			static Delegate GetCreateHandler ()
			{
				if (cb_create == null)
					cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
				return cb_create;
			}

			static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Audio.FilterGraph.Factory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			static IntPtr id_create;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph.Factory']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lorg/jcodec/audio/FilterGraph;", "GetCreateHandler")]
			public virtual unsafe global::Org.Jcodec.Audio.FilterGraph Create ()
			{
				if (id_create == IntPtr.Zero)
					id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lorg/jcodec/audio/FilterGraph;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()Lorg/jcodec/audio/FilterGraph;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/audio/FilterGraph", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilterGraph); }
		}

		protected FilterGraph (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Jcodec.Audio.FilterGraph __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Delay;
		}
#pragma warning restore 0169

		static IntPtr id_getDelay;
		public virtual unsafe int Delay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']/method[@name='getDelay' and count(parameter)=0]"
			[Register ("getDelay", "()I", "GetGetDelayHandler")]
			get {
				if (id_getDelay == IntPtr.Zero)
					id_getDelay = JNIEnv.GetMethodID (class_ref, "getDelay", "()I");
				try {

					if (GetType () == ThresholdType)
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
			global::Org.Jcodec.Audio.FilterGraph __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NInputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNInputs;
		public virtual unsafe int NInputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']/method[@name='getNInputs' and count(parameter)=0]"
			[Register ("getNInputs", "()I", "GetGetNInputsHandler")]
			get {
				if (id_getNInputs == IntPtr.Zero)
					id_getNInputs = JNIEnv.GetMethodID (class_ref, "getNInputs", "()I");
				try {

					if (GetType () == ThresholdType)
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
			global::Org.Jcodec.Audio.FilterGraph __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NOutputs;
		}
#pragma warning restore 0169

		static IntPtr id_getNOutputs;
		public virtual unsafe int NOutputs {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']/method[@name='getNOutputs' and count(parameter)=0]"
			[Register ("getNOutputs", "()I", "GetGetNOutputsHandler")]
			get {
				if (id_getNOutputs == IntPtr.Zero)
					id_getNOutputs = JNIEnv.GetMethodID (class_ref, "getNOutputs", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNOutputs);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNOutputs", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_addLevel_Lorg_jcodec_audio_AudioFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']/method[@name='addLevel' and count(parameter)=1 and parameter[1][@type='org.jcodec.audio.AudioFilter']]"
		[Register ("addLevel", "(Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;", "")]
		public static unsafe global::Org.Jcodec.Audio.FilterGraph.Factory AddLevel (global::Org.Jcodec.Audio.IAudioFilter p0)
		{
			if (id_addLevel_Lorg_jcodec_audio_AudioFilter_ == IntPtr.Zero)
				id_addLevel_Lorg_jcodec_audio_AudioFilter_ = JNIEnv.GetStaticMethodID (class_ref, "addLevel", "(Lorg/jcodec/audio/AudioFilter;)Lorg/jcodec/audio/FilterGraph$Factory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Audio.FilterGraph.Factory __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph.Factory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_addLevel_Lorg_jcodec_audio_AudioFilter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Org.Jcodec.Audio.FilterGraph __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Audio.FilterGraph> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.audio']/class[@name='FilterGraph']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.nio.FloatBuffer[]'] and parameter[2][@type='long[]'] and parameter[3][@type='java.nio.FloatBuffer[]']]"
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

				if (GetType () == ThresholdType)
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
}
