using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Picture", DoNotGenerateAcw=true)]
	public partial class Picture : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Picture", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Picture); }
		}

		protected Picture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/constructor[@name='Picture' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Picture;)V", "")]
		public unsafe Picture (global::Org.Jcodec.Common.Model.Picture p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Picture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Picture;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Picture;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Picture;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Picture_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Picture_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/constructor[@name='Picture' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[][]'] and parameter[4][@type='org.jcodec.common.model.ColorSpace'] and parameter[5][@type='org.jcodec.common.model.Rect']]"
		[Register (".ctor", "(II[[ILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)V", "")]
		public unsafe Picture (int p0, int p1, int[][] p2, global::Org.Jcodec.Common.Model.ColorSpace p3, global::Org.Jcodec.Common.Model.Rect p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (Picture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II[[ILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II[[ILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)V", __args);
					return;
				}

				if (id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_ == IntPtr.Zero)
					id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_ = JNIEnv.GetMethodID (class_ref, "<init>", "(II[[ILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/constructor[@name='Picture' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[][]'] and parameter[4][@type='org.jcodec.common.model.ColorSpace']]"
		[Register (".ctor", "(II[[ILorg/jcodec/common/model/ColorSpace;)V", "")]
		public unsafe Picture (int p0, int p1, int[][] p2, global::Org.Jcodec.Common.Model.ColorSpace p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (Picture)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II[[ILorg/jcodec/common/model/ColorSpace;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II[[ILorg/jcodec/common/model/ColorSpace;)V", __args);
					return;
				}

				if (id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_ == IntPtr.Zero)
					id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_ = JNIEnv.GetMethodID (class_ref, "<init>", "(II[[ILorg/jcodec/common/model/ColorSpace;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIarrayarrayILorg_jcodec_common_model_ColorSpace_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColor);
			return cb_getColor;
		}

		static IntPtr n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Color);
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual unsafe global::Org.Jcodec.Common.Model.ColorSpace Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()Lorg/jcodec/common/model/ColorSpace;", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()Lorg/jcodec/common/model/ColorSpace;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ColorSpace> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()Lorg/jcodec/common/model/ColorSpace;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCrop;
#pragma warning disable 0169
		static Delegate GetGetCropHandler ()
		{
			if (cb_getCrop == null)
				cb_getCrop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCrop);
			return cb_getCrop;
		}

		static IntPtr n_GetCrop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Crop);
		}
#pragma warning restore 0169

		static Delegate cb_setCrop_Lorg_jcodec_common_model_Rect_;
#pragma warning disable 0169
		static Delegate GetSetCrop_Lorg_jcodec_common_model_Rect_Handler ()
		{
			if (cb_setCrop_Lorg_jcodec_common_model_Rect_ == null)
				cb_setCrop_Lorg_jcodec_common_model_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCrop_Lorg_jcodec_common_model_Rect_);
			return cb_setCrop_Lorg_jcodec_common_model_Rect_;
		}

		static void n_SetCrop_Lorg_jcodec_common_model_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rect p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rect> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Crop = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCrop;
		static IntPtr id_setCrop_Lorg_jcodec_common_model_Rect_;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rect Crop {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getCrop' and count(parameter)=0]"
			[Register ("getCrop", "()Lorg/jcodec/common/model/Rect;", "GetGetCropHandler")]
			get {
				if (id_getCrop == IntPtr.Zero)
					id_getCrop = JNIEnv.GetMethodID (class_ref, "getCrop", "()Lorg/jcodec/common/model/Rect;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCrop), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCrop", "()Lorg/jcodec/common/model/Rect;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='setCrop' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rect']]"
			[Register ("setCrop", "(Lorg/jcodec/common/model/Rect;)V", "GetSetCrop_Lorg_jcodec_common_model_Rect_Handler")]
			set {
				if (id_setCrop_Lorg_jcodec_common_model_Rect_ == IntPtr.Zero)
					id_setCrop_Lorg_jcodec_common_model_Rect_ = JNIEnv.GetMethodID (class_ref, "setCrop", "(Lorg/jcodec/common/model/Rect;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCrop_Lorg_jcodec_common_model_Rect_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCrop", "(Lorg/jcodec/common/model/Rect;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCroppedHeight;
#pragma warning disable 0169
		static Delegate GetGetCroppedHeightHandler ()
		{
			if (cb_getCroppedHeight == null)
				cb_getCroppedHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCroppedHeight);
			return cb_getCroppedHeight;
		}

		static int n_GetCroppedHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CroppedHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getCroppedHeight;
		public virtual unsafe int CroppedHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getCroppedHeight' and count(parameter)=0]"
			[Register ("getCroppedHeight", "()I", "GetGetCroppedHeightHandler")]
			get {
				if (id_getCroppedHeight == IntPtr.Zero)
					id_getCroppedHeight = JNIEnv.GetMethodID (class_ref, "getCroppedHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCroppedHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCroppedHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCroppedWidth;
#pragma warning disable 0169
		static Delegate GetGetCroppedWidthHandler ()
		{
			if (cb_getCroppedWidth == null)
				cb_getCroppedWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCroppedWidth);
			return cb_getCroppedWidth;
		}

		static int n_GetCroppedWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CroppedWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getCroppedWidth;
		public virtual unsafe int CroppedWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getCroppedWidth' and count(parameter)=0]"
			[Register ("getCroppedWidth", "()I", "GetGetCroppedWidthHandler")]
			get {
				if (id_getCroppedWidth == IntPtr.Zero)
					id_getCroppedWidth = JNIEnv.GetMethodID (class_ref, "getCroppedWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCroppedWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCroppedWidth", "()I"));
				} finally {
				}
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
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getHeight' and count(parameter)=0]"
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
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_compatible_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetCompatible_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_compatible_Lorg_jcodec_common_model_Picture_ == null)
				cb_compatible_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Compatible_Lorg_jcodec_common_model_Picture_);
			return cb_compatible_Lorg_jcodec_common_model_Picture_;
		}

		static bool n_Compatible_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Compatible (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compatible_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='compatible' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture']]"
		[Register ("compatible", "(Lorg/jcodec/common/model/Picture;)Z", "GetCompatible_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe bool Compatible (global::Org.Jcodec.Common.Model.Picture p0)
		{
			if (id_compatible_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_compatible_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "compatible", "(Lorg/jcodec/common/model/Picture;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_compatible_Lorg_jcodec_common_model_Picture_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compatible", "(Lorg/jcodec/common/model/Picture;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_copyFrom_Lorg_jcodec_common_model_Picture_;
#pragma warning disable 0169
		static Delegate GetCopyFrom_Lorg_jcodec_common_model_Picture_Handler ()
		{
			if (cb_copyFrom_Lorg_jcodec_common_model_Picture_ == null)
				cb_copyFrom_Lorg_jcodec_common_model_Picture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyFrom_Lorg_jcodec_common_model_Picture_);
			return cb_copyFrom_Lorg_jcodec_common_model_Picture_;
		}

		static void n_CopyFrom_Lorg_jcodec_common_model_Picture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Picture p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyFrom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_copyFrom_Lorg_jcodec_common_model_Picture_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='copyFrom' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Picture']]"
		[Register ("copyFrom", "(Lorg/jcodec/common/model/Picture;)V", "GetCopyFrom_Lorg_jcodec_common_model_Picture_Handler")]
		public virtual unsafe void CopyFrom (global::Org.Jcodec.Common.Model.Picture p0)
		{
			if (id_copyFrom_Lorg_jcodec_common_model_Picture_ == IntPtr.Zero)
				id_copyFrom_Lorg_jcodec_common_model_Picture_ = JNIEnv.GetMethodID (class_ref, "copyFrom", "(Lorg/jcodec/common/model/Picture;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyFrom_Lorg_jcodec_common_model_Picture_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyFrom", "(Lorg/jcodec/common/model/Picture;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_create_IILorg_jcodec_common_model_ColorSpace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='create' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.common.model.ColorSpace']]"
		[Register ("create", "(IILorg/jcodec/common/model/ColorSpace;)Lorg/jcodec/common/model/Picture;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture Create (int p0, int p1, global::Org.Jcodec.Common.Model.ColorSpace p2)
		{
			if (id_create_IILorg_jcodec_common_model_ColorSpace_ == IntPtr.Zero)
				id_create_IILorg_jcodec_common_model_ColorSpace_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(IILorg/jcodec/common/model/ColorSpace;)Lorg/jcodec/common/model/Picture;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Org.Jcodec.Common.Model.Picture __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_IILorg_jcodec_common_model_ColorSpace_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_IILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='create' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.common.model.ColorSpace'] and parameter[4][@type='org.jcodec.common.model.Rect']]"
		[Register ("create", "(IILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)Lorg/jcodec/common/model/Picture;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture Create (int p0, int p1, global::Org.Jcodec.Common.Model.ColorSpace p2, global::Org.Jcodec.Common.Model.Rect p3)
		{
			if (id_create_IILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_ == IntPtr.Zero)
				id_create_IILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(IILorg/jcodec/common/model/ColorSpace;Lorg/jcodec/common/model/Rect;)Lorg/jcodec/common/model/Picture;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Jcodec.Common.Model.Picture __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_IILorg_jcodec_common_model_ColorSpace_Lorg_jcodec_common_model_Rect_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createCompatible;
#pragma warning disable 0169
		static Delegate GetCreateCompatibleHandler ()
		{
			if (cb_createCompatible == null)
				cb_createCompatible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateCompatible);
			return cb_createCompatible;
		}

		static IntPtr n_CreateCompatible (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateCompatible ());
		}
#pragma warning restore 0169

		static IntPtr id_createCompatible;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='createCompatible' and count(parameter)=0]"
		[Register ("createCompatible", "()Lorg/jcodec/common/model/Picture;", "GetCreateCompatibleHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture CreateCompatible ()
		{
			if (id_createCompatible == IntPtr.Zero)
				id_createCompatible = JNIEnv.GetMethodID (class_ref, "createCompatible", "()Lorg/jcodec/common/model/Picture;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createCompatible), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCompatible", "()Lorg/jcodec/common/model/Picture;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cropped;
#pragma warning disable 0169
		static Delegate GetCroppedHandler ()
		{
			if (cb_cropped == null)
				cb_cropped = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Cropped);
			return cb_cropped;
		}

		static IntPtr n_Cropped (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cropped ());
		}
#pragma warning restore 0169

		static IntPtr id_cropped;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='cropped' and count(parameter)=0]"
		[Register ("cropped", "()Lorg/jcodec/common/model/Picture;", "GetCroppedHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture Cropped ()
		{
			if (id_cropped == IntPtr.Zero)
				id_cropped = JNIEnv.GetMethodID (class_ref, "cropped", "()Lorg/jcodec/common/model/Picture;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cropped), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cropped", "()Lorg/jcodec/common/model/Picture;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[[I", "GetGetDataHandler")]
		public virtual unsafe int[][] GetData ()
		{
			if (id_getData == IntPtr.Zero)
				id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()[[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef, typeof (int[]));
				else
					return (int[][]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()[[I")), JniHandleOwnership.TransferLocalRef, typeof (int[]));
			} finally {
			}
		}

		static Delegate cb_getPlaneData_I;
#pragma warning disable 0169
		static Delegate GetGetPlaneData_IHandler ()
		{
			if (cb_getPlaneData_I == null)
				cb_getPlaneData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPlaneData_I);
			return cb_getPlaneData_I;
		}

		static IntPtr n_GetPlaneData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPlaneData (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getPlaneData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getPlaneData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPlaneData", "(I)[I", "GetGetPlaneData_IHandler")]
		public virtual unsafe int[] GetPlaneData (int p0)
		{
			if (id_getPlaneData_I == IntPtr.Zero)
				id_getPlaneData_I = JNIEnv.GetMethodID (class_ref, "getPlaneData", "(I)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaneData_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaneData", "(I)[I"), __args), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getPlaneHeight_I;
#pragma warning disable 0169
		static Delegate GetGetPlaneHeight_IHandler ()
		{
			if (cb_getPlaneHeight_I == null)
				cb_getPlaneHeight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPlaneHeight_I);
			return cb_getPlaneHeight_I;
		}

		static int n_GetPlaneHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPlaneHeight (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPlaneHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getPlaneHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPlaneHeight", "(I)I", "GetGetPlaneHeight_IHandler")]
		public virtual unsafe int GetPlaneHeight (int p0)
		{
			if (id_getPlaneHeight_I == IntPtr.Zero)
				id_getPlaneHeight_I = JNIEnv.GetMethodID (class_ref, "getPlaneHeight", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaneHeight_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaneHeight", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getPlaneWidth_I;
#pragma warning disable 0169
		static Delegate GetGetPlaneWidth_IHandler ()
		{
			if (cb_getPlaneWidth_I == null)
				cb_getPlaneWidth_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetPlaneWidth_I);
			return cb_getPlaneWidth_I;
		}

		static int n_GetPlaneWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Picture __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPlaneWidth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPlaneWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Picture']/method[@name='getPlaneWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPlaneWidth", "(I)I", "GetGetPlaneWidth_IHandler")]
		public virtual unsafe int GetPlaneWidth (int p0)
		{
			if (id_getPlaneWidth_I == IntPtr.Zero)
				id_getPlaneWidth_I = JNIEnv.GetMethodID (class_ref, "getPlaneWidth", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPlaneWidth_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaneWidth", "(I)I"), __args);
			} finally {
			}
		}

	}
}
