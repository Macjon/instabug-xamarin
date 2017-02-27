using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Y4m {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/y4m/Y4MDecoder", DoNotGenerateAcw=true)]
	public partial class Y4MDecoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/y4m/Y4MDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Y4MDecoder); }
		}

		protected Y4MDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getFps;
#pragma warning disable 0169
		static Delegate GetGetFpsHandler ()
		{
			if (cb_getFps == null)
				cb_getFps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFps);
			return cb_getFps;
		}

		static IntPtr n_GetFps (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Y4m.Y4MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Y4m.Y4MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Fps);
		}
#pragma warning restore 0169

		static IntPtr id_getFps;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Fps {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']/method[@name='getFps' and count(parameter)=0]"
			[Register ("getFps", "()Lorg/jcodec/common/model/Rational;", "GetGetFpsHandler")]
			get {
				if (id_getFps == IntPtr.Zero)
					id_getFps = JNIEnv.GetMethodID (class_ref, "getFps", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFps), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFps", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Y4m.Y4MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Y4m.Y4MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']/method[@name='getHeight' and count(parameter)=0]"
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

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Y4m.Y4MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Y4m.Y4MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe global::Org.Jcodec.Common.Model.Size Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Lorg/jcodec/common/model/Size;", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()Lorg/jcodec/common/model/Size;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()Lorg/jcodec/common/model/Size;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Codecs.Y4m.Y4MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Y4m.Y4MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']/method[@name='getWidth' and count(parameter)=0]"
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

		static Delegate cb_nextFrame_arrayarrayI;
#pragma warning disable 0169
		static Delegate GetNextFrame_arrayarrayIHandler ()
		{
			if (cb_nextFrame_arrayarrayI == null)
				cb_nextFrame_arrayarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextFrame_arrayarrayI);
			return cb_nextFrame_arrayarrayI;
		}

		static IntPtr n_NextFrame_arrayarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Y4m.Y4MDecoder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Y4m.Y4MDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[][] p0 = (int[][]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int[]));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NextFrame (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nextFrame_arrayarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.y4m']/class[@name='Y4MDecoder']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='int[][]']]"
		[Register ("nextFrame", "([[I)Lorg/jcodec/common/model/Picture;", "GetNextFrame_arrayarrayIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture NextFrame (int[][] p0)
		{
			if (id_nextFrame_arrayarrayI == IntPtr.Zero)
				id_nextFrame_arrayarrayI = JNIEnv.GetMethodID (class_ref, "nextFrame", "([[I)Lorg/jcodec/common/model/Picture;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Jcodec.Common.Model.Picture __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame_arrayarrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "([[I)Lorg/jcodec/common/model/Picture;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
