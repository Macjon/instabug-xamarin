using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Boxes.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='ChannelUtils']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/boxes/channel/ChannelUtils", DoNotGenerateAcw=true)]
	public partial class ChannelUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/boxes/channel/ChannelUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelUtils); }
		}

		protected ChannelUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='ChannelUtils']/constructor[@name='ChannelUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelUtils)) {
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

		static IntPtr id_getLabelsByBitmap_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='ChannelUtils']/method[@name='getLabelsByBitmap' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getLabelsByBitmap", "(J)[Lorg/jcodec/containers/mp4/boxes/channel/Label;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label[] GetLabelsByBitmap (long p0)
		{
			if (id_getLabelsByBitmap_J == IntPtr.Zero)
				id_getLabelsByBitmap_J = JNIEnv.GetStaticMethodID (class_ref, "getLabelsByBitmap", "(J)[Lorg/jcodec/containers/mp4/boxes/channel/Label;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLabelsByBitmap_J, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label));
			} finally {
			}
		}

	}
}
