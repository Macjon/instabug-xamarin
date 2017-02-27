using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='VPxBooleanEncoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/VPxBooleanEncoder", DoNotGenerateAcw=true)]
	public partial class VPxBooleanEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/VPxBooleanEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VPxBooleanEncoder); }
		}

		protected VPxBooleanEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='VPxBooleanEncoder']/constructor[@name='VPxBooleanEncoder' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;)V", "")]
		public unsafe VPxBooleanEncoder (global::Java.Nio.ByteBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VPxBooleanEncoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_position;
#pragma warning disable 0169
		static Delegate GetPositionHandler ()
		{
			if (cb_position == null)
				cb_position = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Position);
			return cb_position;
		}

		static int n_Position (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position ();
		}
#pragma warning restore 0169

		static IntPtr id_position;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='VPxBooleanEncoder']/method[@name='position' and count(parameter)=0]"
		[Register ("position", "()I", "GetPositionHandler")]
		public virtual unsafe int Position ()
		{
			if (id_position == IntPtr.Zero)
				id_position = JNIEnv.GetMethodID (class_ref, "position", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_position);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "position", "()I"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='VPxBooleanEncoder']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_writeBit_II;
#pragma warning disable 0169
		static Delegate GetWriteBit_IIHandler ()
		{
			if (cb_writeBit_II == null)
				cb_writeBit_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_WriteBit_II);
			return cb_writeBit_II;
		}

		static void n_WriteBit_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.VPxBooleanEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteBit (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeBit_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='VPxBooleanEncoder']/method[@name='writeBit' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("writeBit", "(II)V", "GetWriteBit_IIHandler")]
		public virtual unsafe void WriteBit (int p0, int p1)
		{
			if (id_writeBit_II == IntPtr.Zero)
				id_writeBit_II = JNIEnv.GetMethodID (class_ref, "writeBit", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeBit_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeBit", "(II)V"), __args);
			} finally {
			}
		}

	}
}
