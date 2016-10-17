using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericTrack", DoNotGenerateAcw=true)]
	public partial class GenericTrack : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericTrack); }
		}

		protected GenericTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/constructor[@name='GenericTrack' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe GenericTrack (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GenericTrack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
			} finally {
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSequenceRef;
#pragma warning disable 0169
		static Delegate GetGetSequenceRefHandler ()
		{
			if (cb_getSequenceRef == null)
				cb_getSequenceRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSequenceRef);
			return cb_getSequenceRef;
		}

		static IntPtr n_GetSequenceRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SequenceRef);
		}
#pragma warning restore 0169

		static IntPtr id_getSequenceRef;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL SequenceRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/method[@name='getSequenceRef' and count(parameter)=0]"
			[Register ("getSequenceRef", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetSequenceRefHandler")]
			get {
				if (id_getSequenceRef == IntPtr.Zero)
					id_getSequenceRef = JNIEnv.GetMethodID (class_ref, "getSequenceRef", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSequenceRef), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequenceRef", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Org.Jcodec.Containers.Mxf.Model.GenericTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackId;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackId;
		public virtual unsafe int TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()I", "GetGetTrackIdHandler")]
			get {
				if (id_getTrackId == IntPtr.Zero)
					id_getTrackId = JNIEnv.GetMethodID (class_ref, "getTrackId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrackNumber;
#pragma warning disable 0169
		static Delegate GetGetTrackNumberHandler ()
		{
			if (cb_getTrackNumber == null)
				cb_getTrackNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrackNumber);
			return cb_getTrackNumber;
		}

		static int n_GetTrackNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackNumber;
		public virtual unsafe int TrackNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/method[@name='getTrackNumber' and count(parameter)=0]"
			[Register ("getTrackNumber", "()I", "GetGetTrackNumberHandler")]
			get {
				if (id_getTrackNumber == IntPtr.Zero)
					id_getTrackNumber = JNIEnv.GetMethodID (class_ref, "getTrackNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTrackNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackNumber", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_read_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_util_Map_Handler ()
		{
			if (cb_read_Ljava_util_Map_ == null)
				cb_read_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_util_Map_);
			return cb_read_Ljava_util_Map_;
		}

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericTrack']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
		[Register ("read", "(Ljava/util/Map;)V", "GetRead_Ljava_util_Map_Handler")]
		protected override unsafe void Read (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer> p0)
		{
			if (id_read_Ljava_util_Map_ == IntPtr.Zero)
				id_read_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
