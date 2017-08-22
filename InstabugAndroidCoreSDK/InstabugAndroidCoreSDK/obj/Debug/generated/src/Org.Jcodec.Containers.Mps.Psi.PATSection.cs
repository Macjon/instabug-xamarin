using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps.Psi {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PATSection']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/psi/PATSection", DoNotGenerateAcw=true)]
	public partial class PATSection : global::Org.Jcodec.Containers.Mps.Psi.PSISection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/psi/PATSection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PATSection); }
		}

		protected PATSection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNetworkPids;
#pragma warning disable 0169
		static Delegate GetGetNetworkPidsHandler ()
		{
			if (cb_getNetworkPids == null)
				cb_getNetworkPids = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkPids);
			return cb_getNetworkPids;
		}

		static IntPtr n_GetNetworkPids (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PATSection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PATSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNetworkPids ());
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkPids;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PATSection']/method[@name='getNetworkPids' and count(parameter)=0]"
		[Register ("getNetworkPids", "()[I", "GetGetNetworkPidsHandler")]
		public virtual unsafe int[] GetNetworkPids ()
		{
			if (id_getNetworkPids == IntPtr.Zero)
				id_getNetworkPids = JNIEnv.GetMethodID (class_ref, "getNetworkPids", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkPids), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkPids", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PATSection']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PATSection;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PATSection Parse (global::Java.Nio.ByteBuffer data)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PATSection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				global::Org.Jcodec.Containers.Mps.Psi.PATSection __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PATSection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
