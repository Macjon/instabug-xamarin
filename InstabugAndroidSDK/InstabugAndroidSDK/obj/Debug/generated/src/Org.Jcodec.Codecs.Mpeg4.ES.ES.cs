using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg4.ES {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='ES']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg4/es/ES", DoNotGenerateAcw=true)]
	public partial class ES : global::Org.Jcodec.Codecs.Mpeg4.ES.NodeDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg4/es/ES", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ES); }
		}

		protected ES (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='ES']/constructor[@name='ES' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe ES (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ES)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
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

		static IntPtr id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='ES']/constructor[@name='ES' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.codecs.mpeg4.es.Descriptor...']]"
		[Register (".ctor", "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", "")]
		public unsafe ES (int p0, params global:: Org.Jcodec.Codecs.Mpeg4.ES.Descriptor[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ES)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V", __args);
					return;
				}

				if (id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ == IntPtr.Zero)
					id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[Lorg/jcodec/codecs/mpeg4/es/Descriptor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayLorg_jcodec_codecs_mpeg4_es_Descriptor_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getTrackId;
#pragma warning disable 0169
		static Delegate GetGetTrackIdHandler ()
		{
			if (cb_getTrackId == null)
				cb_getTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackId);
			return cb_getTrackId;
		}

		static int n_GetTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg4.ES.ES __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg4.ES.ES> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackId;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackId;
		public virtual unsafe int TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='ES']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()I", "GetGetTrackIdHandler")]
			get {
				if (id_getTrackId == IntPtr.Zero)
					id_getTrackId = JNIEnv.GetMethodID (class_ref, "getTrackId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackId", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_tag;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg4.es']/class[@name='ES']/method[@name='tag' and count(parameter)=0]"
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
