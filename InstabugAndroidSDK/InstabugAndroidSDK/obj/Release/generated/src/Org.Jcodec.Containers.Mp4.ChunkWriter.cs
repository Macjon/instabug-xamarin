using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='ChunkWriter']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/ChunkWriter", DoNotGenerateAcw=true)]
	public partial class ChunkWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/ChunkWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChunkWriter); }
		}

		protected ChunkWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_apply;
#pragma warning disable 0169
		static Delegate GetApplyHandler ()
		{
			if (cb_apply == null)
				cb_apply = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Apply);
			return cb_apply;
		}

		static void n_Apply (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.ChunkWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.ChunkWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Apply ();
		}
#pragma warning restore 0169

		static IntPtr id_apply;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='ChunkWriter']/method[@name='apply' and count(parameter)=0]"
		[Register ("apply", "()V", "GetApplyHandler")]
		public virtual unsafe void Apply ()
		{
			if (id_apply == IntPtr.Zero)
				id_apply = JNIEnv.GetMethodID (class_ref, "apply", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_apply);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "apply", "()V"));
			} finally {
			}
		}

		static Delegate cb_write_Lorg_jcodec_containers_mp4_Chunk_;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_jcodec_containers_mp4_Chunk_Handler ()
		{
			if (cb_write_Lorg_jcodec_containers_mp4_Chunk_ == null)
				cb_write_Lorg_jcodec_containers_mp4_Chunk_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lorg_jcodec_containers_mp4_Chunk_);
			return cb_write_Lorg_jcodec_containers_mp4_Chunk_;
		}

		static void n_Write_Lorg_jcodec_containers_mp4_Chunk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mp4.ChunkWriter __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.ChunkWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mp4.Chunk p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lorg_jcodec_containers_mp4_Chunk_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='ChunkWriter']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mp4.Chunk']]"
		[Register ("write", "(Lorg/jcodec/containers/mp4/Chunk;)V", "GetWrite_Lorg_jcodec_containers_mp4_Chunk_Handler")]
		public virtual unsafe void Write (global::Org.Jcodec.Containers.Mp4.Chunk p0)
		{
			if (id_write_Lorg_jcodec_containers_mp4_Chunk_ == IntPtr.Zero)
				id_write_Lorg_jcodec_containers_mp4_Chunk_ = JNIEnv.GetMethodID (class_ref, "write", "(Lorg/jcodec/containers/mp4/Chunk;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lorg_jcodec_containers_mp4_Chunk_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lorg/jcodec/containers/mp4/Chunk;)V"), __args);
			} finally {
			}
		}

	}
}
