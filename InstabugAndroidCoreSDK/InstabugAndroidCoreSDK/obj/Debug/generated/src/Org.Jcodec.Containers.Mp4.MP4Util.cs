using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Util']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/MP4Util", DoNotGenerateAcw=true)]
	public partial class MP4Util : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Util.Atom']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mp4/MP4Util$Atom", DoNotGenerateAcw=true)]
		public partial class Atom : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mp4/MP4Util$Atom", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Atom); }
			}

			protected Atom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getOffset;
#pragma warning disable 0169
			static Delegate GetGetOffsetHandler ()
			{
				if (cb_getOffset == null)
					cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
				return cb_getOffset;
			}

			static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mp4.MP4Util.Atom __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Util.Atom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Offset;
			}
#pragma warning restore 0169

			static IntPtr id_getOffset;
			public virtual unsafe long Offset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Util.Atom']/method[@name='getOffset' and count(parameter)=0]"
				[Register ("getOffset", "()J", "GetGetOffsetHandler")]
				get {
					if (id_getOffset == IntPtr.Zero)
						id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()J"));
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/MP4Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MP4Util); }
		}

		protected MP4Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Util']/constructor[@name='MP4Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MP4Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MP4Util)) {
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

	}
}
