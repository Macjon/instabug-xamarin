using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/ADTSParser", DoNotGenerateAcw=true)]
	public partial class ADTSParser : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/aac/ADTSParser$Header", DoNotGenerateAcw=true)]
		public partial class Header : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/aac/ADTSParser$Header", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Header); }
			}

			protected Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/constructor[@name='ADTSParser.Header' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(IIIII)V", "")]
			public unsafe Header (int object_type, int chanConfig, int crcAbsent, int numAACFrames, int samplingIndex)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (object_type);
					__args [1] = new JValue (chanConfig);
					__args [2] = new JValue (crcAbsent);
					__args [3] = new JValue (numAACFrames);
					__args [4] = new JValue (samplingIndex);
					if (((object) this).GetType () != typeof (Header)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIIII)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIII)V", __args);
						return;
					}

					if (id_ctor_IIIII == IntPtr.Zero)
						id_ctor_IIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIII)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIII, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIII, __args);
				} finally {
				}
			}

			static Delegate cb_getChanConfig;
#pragma warning disable 0169
			static Delegate GetGetChanConfigHandler ()
			{
				if (cb_getChanConfig == null)
					cb_getChanConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChanConfig);
				return cb_getChanConfig;
			}

			static int n_GetChanConfig (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ChanConfig;
			}
#pragma warning restore 0169

			static IntPtr id_getChanConfig;
			public virtual unsafe int ChanConfig {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getChanConfig' and count(parameter)=0]"
				[Register ("getChanConfig", "()I", "GetGetChanConfigHandler")]
				get {
					if (id_getChanConfig == IntPtr.Zero)
						id_getChanConfig = JNIEnv.GetMethodID (class_ref, "getChanConfig", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChanConfig);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChanConfig", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getCrcAbsent;
#pragma warning disable 0169
			static Delegate GetGetCrcAbsentHandler ()
			{
				if (cb_getCrcAbsent == null)
					cb_getCrcAbsent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCrcAbsent);
				return cb_getCrcAbsent;
			}

			static int n_GetCrcAbsent (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CrcAbsent;
			}
#pragma warning restore 0169

			static IntPtr id_getCrcAbsent;
			public virtual unsafe int CrcAbsent {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getCrcAbsent' and count(parameter)=0]"
				[Register ("getCrcAbsent", "()I", "GetGetCrcAbsentHandler")]
				get {
					if (id_getCrcAbsent == IntPtr.Zero)
						id_getCrcAbsent = JNIEnv.GetMethodID (class_ref, "getCrcAbsent", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCrcAbsent);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCrcAbsent", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getNumAACFrames;
#pragma warning disable 0169
			static Delegate GetGetNumAACFramesHandler ()
			{
				if (cb_getNumAACFrames == null)
					cb_getNumAACFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumAACFrames);
				return cb_getNumAACFrames;
			}

			static int n_GetNumAACFrames (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NumAACFrames;
			}
#pragma warning restore 0169

			static IntPtr id_getNumAACFrames;
			public virtual unsafe int NumAACFrames {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getNumAACFrames' and count(parameter)=0]"
				[Register ("getNumAACFrames", "()I", "GetGetNumAACFramesHandler")]
				get {
					if (id_getNumAACFrames == IntPtr.Zero)
						id_getNumAACFrames = JNIEnv.GetMethodID (class_ref, "getNumAACFrames", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumAACFrames);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumAACFrames", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getObjectType;
#pragma warning disable 0169
			static Delegate GetGetObjectTypeHandler ()
			{
				if (cb_getObjectType == null)
					cb_getObjectType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetObjectType);
				return cb_getObjectType;
			}

			static int n_GetObjectType (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ObjectType;
			}
#pragma warning restore 0169

			static IntPtr id_getObjectType;
			public virtual unsafe int ObjectType {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getObjectType' and count(parameter)=0]"
				[Register ("getObjectType", "()I", "GetGetObjectTypeHandler")]
				get {
					if (id_getObjectType == IntPtr.Zero)
						id_getObjectType = JNIEnv.GetMethodID (class_ref, "getObjectType", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getObjectType);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectType", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getSamples;
#pragma warning disable 0169
			static Delegate GetGetSamplesHandler ()
			{
				if (cb_getSamples == null)
					cb_getSamples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSamples);
				return cb_getSamples;
			}

			static int n_GetSamples (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Samples;
			}
#pragma warning restore 0169

			static IntPtr id_getSamples;
			public virtual unsafe int Samples {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getSamples' and count(parameter)=0]"
				[Register ("getSamples", "()I", "GetGetSamplesHandler")]
				get {
					if (id_getSamples == IntPtr.Zero)
						id_getSamples = JNIEnv.GetMethodID (class_ref, "getSamples", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSamples);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamples", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getSamplingIndex;
#pragma warning disable 0169
			static Delegate GetGetSamplingIndexHandler ()
			{
				if (cb_getSamplingIndex == null)
					cb_getSamplingIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSamplingIndex);
				return cb_getSamplingIndex;
			}

			static int n_GetSamplingIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SamplingIndex;
			}
#pragma warning restore 0169

			static IntPtr id_getSamplingIndex;
			public virtual unsafe int SamplingIndex {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser.Header']/method[@name='getSamplingIndex' and count(parameter)=0]"
				[Register ("getSamplingIndex", "()I", "GetGetSamplingIndexHandler")]
				get {
					if (id_getSamplingIndex == IntPtr.Zero)
						id_getSamplingIndex = JNIEnv.GetMethodID (class_ref, "getSamplingIndex", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSamplingIndex);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSamplingIndex", "()I"));
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/ADTSParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ADTSParser); }
		}

		protected ADTSParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser']/constructor[@name='ADTSParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ADTSParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ADTSParser)) {
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

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/aac/ADTSParser$Header;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.ADTSParser.Header Read (global::Java.Nio.ByteBuffer data)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/aac/ADTSParser$Header;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				global::Org.Jcodec.Codecs.Aac.ADTSParser.Header __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ADTSParser.Header> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lorg_jcodec_codecs_aac_ADTSParser_Header_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ADTSParser']/method[@name='write' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.aac.ADTSParser.Header'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='int']]"
		[Register ("write", "(Lorg/jcodec/codecs/aac/ADTSParser$Header;Ljava/nio/ByteBuffer;I)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer Write (global::Org.Jcodec.Codecs.Aac.ADTSParser.Header header, global::Java.Nio.ByteBuffer buf, int frameSize)
		{
			if (id_write_Lorg_jcodec_codecs_aac_ADTSParser_Header_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_write_Lorg_jcodec_codecs_aac_ADTSParser_Header_Ljava_nio_ByteBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "write", "(Lorg/jcodec/codecs/aac/ADTSParser$Header;Ljava/nio/ByteBuffer;I)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (header);
				__args [1] = new JValue (buf);
				__args [2] = new JValue (frameSize);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_write_Lorg_jcodec_codecs_aac_ADTSParser_Header_Ljava_nio_ByteBuffer_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
