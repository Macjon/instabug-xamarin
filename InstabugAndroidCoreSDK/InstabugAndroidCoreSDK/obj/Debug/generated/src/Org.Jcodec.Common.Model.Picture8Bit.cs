using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Picture8Bit", DoNotGenerateAcw=true)]
	public partial class Picture8Bit : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Picture8Bit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Picture8Bit); }
		}

		protected Picture8Bit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIarrayBarrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/constructor[@name='Picture8Bit' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(II[B[B[B)V", "")]
		public unsafe Picture8Bit (int width, int height, byte[] y, byte[] cb, byte[] cr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_y = JNIEnv.NewArray (y);
			IntPtr native_cb = JNIEnv.NewArray (cb);
			IntPtr native_cr = JNIEnv.NewArray (cr);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);
				__args [2] = new JValue (native_y);
				__args [3] = new JValue (native_cb);
				__args [4] = new JValue (native_cr);
				if (((object) this).GetType () != typeof (Picture8Bit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II[B[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II[B[B[B)V", __args);
					return;
				}

				if (id_ctor_IIarrayBarrayBarrayB == IntPtr.Zero)
					id_ctor_IIarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(II[B[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayBarrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIarrayBarrayBarrayB, __args);
			} finally {
				if (y != null) {
					JNIEnv.CopyArray (native_y, y);
					JNIEnv.DeleteLocalRef (native_y);
				}
				if (cb != null) {
					JNIEnv.CopyArray (native_cb, cb);
					JNIEnv.DeleteLocalRef (native_cb);
				}
				if (cr != null) {
					JNIEnv.CopyArray (native_cr, cr);
					JNIEnv.DeleteLocalRef (native_cr);
				}
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Picture8Bit_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/constructor[@name='Picture8Bit' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture8Bit']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Picture8Bit;)V", "")]
		public unsafe Picture8Bit (global::Org.Jcodec.Common.Model.Picture8Bit other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				if (((object) this).GetType () != typeof (Picture8Bit)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Picture8Bit;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Picture8Bit;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Picture8Bit_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Picture8Bit_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Picture8Bit;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Picture8Bit_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Picture8Bit_, __args);
			} finally {
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture8Bit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture8Bit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_create420_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='create420' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("create420", "(II)Lorg/jcodec/common/model/Picture8Bit;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture8Bit Create420 (int width, int height)
		{
			if (id_create420_II == IntPtr.Zero)
				id_create420_II = JNIEnv.GetStaticMethodID (class_ref, "create420", "(II)Lorg/jcodec/common/model/Picture8Bit;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create420_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create422_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='create422' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("create422", "(II)Lorg/jcodec/common/model/Picture8Bit;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture8Bit Create422 (int width, int height)
		{
			if (id_create422_II == IntPtr.Zero)
				id_create422_II = JNIEnv.GetStaticMethodID (class_ref, "create422", "(II)Lorg/jcodec/common/model/Picture8Bit;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create422_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCb;
#pragma warning disable 0169
		static Delegate GetGetCbHandler ()
		{
			if (cb_getCb == null)
				cb_getCb = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCb);
			return cb_getCb;
		}

		static IntPtr n_GetCb (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture8Bit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCb ());
		}
#pragma warning restore 0169

		static IntPtr id_getCb;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='getCb' and count(parameter)=0]"
		[Register ("getCb", "()[B", "GetGetCbHandler")]
		public virtual unsafe byte[] GetCb ()
		{
			if (id_getCb == IntPtr.Zero)
				id_getCb = JNIEnv.GetMethodID (class_ref, "getCb", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCb), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCb", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getCr;
#pragma warning disable 0169
		static Delegate GetGetCrHandler ()
		{
			if (cb_getCr == null)
				cb_getCr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCr);
			return cb_getCr;
		}

		static IntPtr n_GetCr (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture8Bit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCr ());
		}
#pragma warning restore 0169

		static IntPtr id_getCr;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='getCr' and count(parameter)=0]"
		[Register ("getCr", "()[B", "GetGetCrHandler")]
		public virtual unsafe byte[] GetCr ()
		{
			if (id_getCr == IntPtr.Zero)
				id_getCr = JNIEnv.GetMethodID (class_ref, "getCr", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCr), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCr", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetY);
			return cb_getY;
		}

		static IntPtr n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture8Bit __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture8Bit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetY ());
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture8Bit']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()[B", "GetGetYHandler")]
		public virtual unsafe byte[] GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getY), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
