using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg4.ES {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/DecoderConfig", DoNotGenerateAcw=true)]
	public partial class DecoderConfig : global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg4/es/DecoderConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecoderConfig); }
		}

		protected DecoderConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/constructor[@name='DecoderConfig' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DecoderConfig (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DecoderConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIIIarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/constructor[@name='DecoderConfig' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.jcodec.codecs.mpeg4.es.Descriptor...']]"
		[Register (".ctor", "(IIII[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", "")]
		public unsafe DecoderConfig (int p0, int p1, int p2, int p3, params global:: Org.Jcodec.Codecs.Mpeg4.ES.Descriptor[] p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (GetType () != typeof (DecoderConfig)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args);
					return;
				}

				if (id_ctor_IIIIarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ == IntPtr.Zero)
					id_ctor_IIIIarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_getAvgBitrate;
#pragma warning disable 0169
		static Delegate GetGetAvgBitrateHandler ()
		{
			if (cb_getAvgBitrate == null)
				cb_getAvgBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAvgBitrate);
			return cb_getAvgBitrate;
		}

		static int n_GetAvgBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AvgBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getAvgBitrate;
		public virtual unsafe int AvgBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/method[@name='getAvgBitrate' and count(parameter)=0]"
			[Register ("getAvgBitrate", "()I", "GetGetAvgBitrateHandler")]
			get {
				if (id_getAvgBitrate == IntPtr.Zero)
					id_getAvgBitrate = JNIEnv.GetMethodID (class_ref, "getAvgBitrate", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAvgBitrate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvgBitrate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBufSize;
#pragma warning disable 0169
		static Delegate GetGetBufSizeHandler ()
		{
			if (cb_getBufSize == null)
				cb_getBufSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufSize);
			return cb_getBufSize;
		}

		static int n_GetBufSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufSize;
		}
#pragma warning restore 0169

		static IntPtr id_getBufSize;
		public virtual unsafe int BufSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/method[@name='getBufSize' and count(parameter)=0]"
			[Register ("getBufSize", "()I", "GetGetBufSizeHandler")]
			get {
				if (id_getBufSize == IntPtr.Zero)
					id_getBufSize = JNIEnv.GetMethodID (class_ref, "getBufSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxBitrate;
#pragma warning disable 0169
		static Delegate GetGetMaxBitrateHandler ()
		{
			if (cb_getMaxBitrate == null)
				cb_getMaxBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxBitrate);
			return cb_getMaxBitrate;
		}

		static int n_GetMaxBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxBitrate;
		public virtual unsafe int MaxBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/method[@name='getMaxBitrate' and count(parameter)=0]"
			[Register ("getMaxBitrate", "()I", "GetGetMaxBitrateHandler")]
			get {
				if (id_getMaxBitrate == IntPtr.Zero)
					id_getMaxBitrate = JNIEnv.GetMethodID (class_ref, "getMaxBitrate", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxBitrate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxBitrate", "()I"));
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
			global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.DecoderConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ObjectType;
		}
#pragma warning restore 0169

		static IntPtr id_getObjectType;
		public virtual unsafe int ObjectType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/method[@name='getObjectType' and count(parameter)=0]"
			[Register ("getObjectType", "()I", "GetGetObjectTypeHandler")]
			get {
				if (id_getObjectType == IntPtr.Zero)
					id_getObjectType = JNIEnv.GetMethodID (class_ref, "getObjectType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getObjectType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObjectType", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_tag;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='DecoderConfig']/method[@name='tag' and count(parameter)=0]"
		[Register ("tag", "()I", "")]
		public static unsafe int Tag ()
		{
			if (id_tag == IntPtr.Zero)
				id_tag = JNIEnv.GetStaticMethodID (class_ref, "tag", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_tag);
			} finally {
			}
		}

	}
}
