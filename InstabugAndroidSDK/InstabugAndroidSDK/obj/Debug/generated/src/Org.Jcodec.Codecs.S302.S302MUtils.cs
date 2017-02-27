using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.S302 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.s302']/class[@name='S302MUtils']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/s302/S302MUtils", DoNotGenerateAcw=true)]
	public partial class S302MUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/s302/S302MUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (S302MUtils); }
		}

		protected S302MUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.s302']/class[@name='S302MUtils']/constructor[@name='S302MUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe S302MUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (S302MUtils)) {
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

		static IntPtr id_labels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.s302']/class[@name='S302MUtils']/method[@name='labels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("labels", "(I)[Lorg/jcodec/common/model/ChannelLabel;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] Labels (int p0)
		{
			if (id_labels_I == IntPtr.Zero)
				id_labels_I = JNIEnv.GetStaticMethodID (class_ref, "labels", "(I)[Lorg/jcodec/common/model/ChannelLabel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_labels_I, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
			} finally {
			}
		}

		static IntPtr id_name_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.s302']/class[@name='S302MUtils']/method[@name='name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name", "(I)Ljava/lang/String;", "")]
		public static unsafe string Name (int p0)
		{
			if (id_name_I == IntPtr.Zero)
				id_name_I = JNIEnv.GetStaticMethodID (class_ref, "name", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_name_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
