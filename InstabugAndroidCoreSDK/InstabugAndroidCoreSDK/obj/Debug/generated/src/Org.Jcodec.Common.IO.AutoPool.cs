using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='AutoPool']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/AutoPool", DoNotGenerateAcw=true)]
	public partial class AutoPool : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/AutoPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AutoPool); }
		}

		protected AutoPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Org.Jcodec.Common.IO.AutoPool Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='AutoPool']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/jcodec/common/io/AutoPool;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/jcodec/common/io/AutoPool;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.AutoPool> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_jcodec_common_io_AutoResource_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_jcodec_common_io_AutoResource_Handler ()
		{
			if (cb_add_Lorg_jcodec_common_io_AutoResource_ == null)
				cb_add_Lorg_jcodec_common_io_AutoResource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_jcodec_common_io_AutoResource_);
			return cb_add_Lorg_jcodec_common_io_AutoResource_;
		}

		static void n_Add_Lorg_jcodec_common_io_AutoResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_res)
		{
			global::Org.Jcodec.Common.IO.AutoPool __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.AutoPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.IO.IAutoResource res = (global::Org.Jcodec.Common.IO.IAutoResource)global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.IAutoResource> (native_res, JniHandleOwnership.DoNotTransfer);
			__this.Add (res);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_jcodec_common_io_AutoResource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='AutoPool']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.io.AutoResource']]"
		[Register ("add", "(Lorg/jcodec/common/io/AutoResource;)V", "GetAdd_Lorg_jcodec_common_io_AutoResource_Handler")]
		public virtual unsafe void Add (global::Org.Jcodec.Common.IO.IAutoResource res)
		{
			if (id_add_Lorg_jcodec_common_io_AutoResource_ == IntPtr.Zero)
				id_add_Lorg_jcodec_common_io_AutoResource_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/jcodec/common/io/AutoResource;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (res);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_jcodec_common_io_AutoResource_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/jcodec/common/io/AutoResource;)V"), __args);
			} finally {
			}
		}

	}
}
