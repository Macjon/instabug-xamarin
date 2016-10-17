using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']"
	[global::Android.Runtime.Register ("org/jcodec/api/FrameGrab", DoNotGenerateAcw=true)]
	public partial class FrameGrab : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab.MediaInfo']"
		[global::Android.Runtime.Register ("org/jcodec/api/FrameGrab$MediaInfo", DoNotGenerateAcw=true)]
		public partial class MediaInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/api/FrameGrab$MediaInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaInfo); }
			}

			protected MediaInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_common_model_Size_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab.MediaInfo']/constructor[@name='FrameGrab.MediaInfo' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Size']]"
			[Register (".ctor", "(Lorg/jcodec/common/model/Size;)V", "")]
			public unsafe MediaInfo (global::Org.Jcodec.Common.Model.Size p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (MediaInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/common/model/Size;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Size;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Size;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Size_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Size_, __args);
				} finally {
				}
			}

			static Delegate cb_getDim;
#pragma warning disable 0169
			static Delegate GetGetDimHandler ()
			{
				if (cb_getDim == null)
					cb_getDim = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDim);
				return cb_getDim;
			}

			static IntPtr n_GetDim (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Api.FrameGrab.MediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Dim);
			}
#pragma warning restore 0169

			static Delegate cb_setDim_Lorg_jcodec_common_model_Size_;
#pragma warning disable 0169
			static Delegate GetSetDim_Lorg_jcodec_common_model_Size_Handler ()
			{
				if (cb_setDim_Lorg_jcodec_common_model_Size_ == null)
					cb_setDim_Lorg_jcodec_common_model_Size_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDim_Lorg_jcodec_common_model_Size_);
				return cb_setDim_Lorg_jcodec_common_model_Size_;
			}

			static void n_SetDim_Lorg_jcodec_common_model_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Api.FrameGrab.MediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Common.Model.Size p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Dim = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getDim;
			static IntPtr id_setDim_Lorg_jcodec_common_model_Size_;
			public virtual unsafe global::Org.Jcodec.Common.Model.Size Dim {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab.MediaInfo']/method[@name='getDim' and count(parameter)=0]"
				[Register ("getDim", "()Lorg/jcodec/common/model/Size;", "GetGetDimHandler")]
				get {
					if (id_getDim == IntPtr.Zero)
						id_getDim = JNIEnv.GetMethodID (class_ref, "getDim", "()Lorg/jcodec/common/model/Size;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDim), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDim", "()Lorg/jcodec/common/model/Size;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab.MediaInfo']/method[@name='setDim' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Size']]"
				[Register ("setDim", "(Lorg/jcodec/common/model/Size;)V", "GetSetDim_Lorg_jcodec_common_model_Size_Handler")]
				set {
					if (id_setDim_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
						id_setDim_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "setDim", "(Lorg/jcodec/common/model/Size;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDim_Lorg_jcodec_common_model_Size_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDim", "(Lorg/jcodec/common/model/Size;)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/api/FrameGrab", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FrameGrab); }
		}

		protected FrameGrab (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getNativeFrame;
#pragma warning disable 0169
		static Delegate GetGetNativeFrameHandler ()
		{
			if (cb_getNativeFrame == null)
				cb_getNativeFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNativeFrame);
			return cb_getNativeFrame;
		}

		static IntPtr n_GetNativeFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NativeFrame);
		}
#pragma warning restore 0169

		static IntPtr id_getNativeFrame;
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture NativeFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='getNativeFrame' and count(parameter)=0]"
			[Register ("getNativeFrame", "()Lorg/jcodec/common/model/Picture;", "GetGetNativeFrameHandler")]
			get {
				if (id_getNativeFrame == IntPtr.Zero)
					id_getNativeFrame = JNIEnv.GetMethodID (class_ref, "getNativeFrame", "()Lorg/jcodec/common/model/Picture;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNativeFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNativeFrame", "()Lorg/jcodec/common/model/Picture;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaInfo;
#pragma warning disable 0169
		static Delegate GetGetMediaInfoHandler ()
		{
			if (cb_getMediaInfo == null)
				cb_getMediaInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaInfo);
			return cb_getMediaInfo;
		}

		static IntPtr n_GetMediaInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMediaInfo ());
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='getMediaInfo' and count(parameter)=0]"
		[Register ("getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;", "GetGetMediaInfoHandler")]
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab.MediaInfo GetMediaInfo ()
		{
			if (id_getMediaInfo == IntPtr.Zero)
				id_getMediaInfo = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab.MediaInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaInfo", "()Lorg/jcodec/api/FrameGrab$MediaInfo;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getNativeFrame_Ljava_io_File_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='getNativeFrame' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='double']]"
		[Register ("getNativeFrame", "(Ljava/io/File;D)Lorg/jcodec/common/model/Picture;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture GetNativeFrame (global::Java.IO.File p0, double p1)
		{
			if (id_getNativeFrame_Ljava_io_File_D == IntPtr.Zero)
				id_getNativeFrame_Ljava_io_File_D = JNIEnv.GetStaticMethodID (class_ref, "getNativeFrame", "(Ljava/io/File;D)Lorg/jcodec/common/model/Picture;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Common.Model.Picture __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNativeFrame_Ljava_io_File_D, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNativeFrame_Ljava_io_File_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='getNativeFrame' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='int']]"
		[Register ("getNativeFrame", "(Ljava/io/File;I)Lorg/jcodec/common/model/Picture;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Picture GetNativeFrame (global::Java.IO.File p0, int p1)
		{
			if (id_getNativeFrame_Ljava_io_File_I == IntPtr.Zero)
				id_getNativeFrame_Ljava_io_File_I = JNIEnv.GetStaticMethodID (class_ref, "getNativeFrame", "(Ljava/io/File;I)Lorg/jcodec/common/model/Picture;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Common.Model.Picture __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNativeFrame_Ljava_io_File_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_seekToFramePrecise_I;
#pragma warning disable 0169
		static Delegate GetSeekToFramePrecise_IHandler ()
		{
			if (cb_seekToFramePrecise_I == null)
				cb_seekToFramePrecise_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SeekToFramePrecise_I);
			return cb_seekToFramePrecise_I;
		}

		static IntPtr n_SeekToFramePrecise_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekToFramePrecise (p0));
		}
#pragma warning restore 0169

		static IntPtr id_seekToFramePrecise_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='seekToFramePrecise' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekToFramePrecise", "(I)Lorg/jcodec/api/FrameGrab;", "GetSeekToFramePrecise_IHandler")]
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab SeekToFramePrecise (int p0)
		{
			if (id_seekToFramePrecise_I == IntPtr.Zero)
				id_seekToFramePrecise_I = JNIEnv.GetMethodID (class_ref, "seekToFramePrecise", "(I)Lorg/jcodec/api/FrameGrab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_seekToFramePrecise_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekToFramePrecise", "(I)Lorg/jcodec/api/FrameGrab;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_seekToFrameSloppy_I;
#pragma warning disable 0169
		static Delegate GetSeekToFrameSloppy_IHandler ()
		{
			if (cb_seekToFrameSloppy_I == null)
				cb_seekToFrameSloppy_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SeekToFrameSloppy_I);
			return cb_seekToFrameSloppy_I;
		}

		static IntPtr n_SeekToFrameSloppy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekToFrameSloppy (p0));
		}
#pragma warning restore 0169

		static IntPtr id_seekToFrameSloppy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='seekToFrameSloppy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("seekToFrameSloppy", "(I)Lorg/jcodec/api/FrameGrab;", "GetSeekToFrameSloppy_IHandler")]
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab SeekToFrameSloppy (int p0)
		{
			if (id_seekToFrameSloppy_I == IntPtr.Zero)
				id_seekToFrameSloppy_I = JNIEnv.GetMethodID (class_ref, "seekToFrameSloppy", "(I)Lorg/jcodec/api/FrameGrab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_seekToFrameSloppy_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekToFrameSloppy", "(I)Lorg/jcodec/api/FrameGrab;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_seekToSecondPrecise_D;
#pragma warning disable 0169
		static Delegate GetSeekToSecondPrecise_DHandler ()
		{
			if (cb_seekToSecondPrecise_D == null)
				cb_seekToSecondPrecise_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SeekToSecondPrecise_D);
			return cb_seekToSecondPrecise_D;
		}

		static IntPtr n_SeekToSecondPrecise_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekToSecondPrecise (p0));
		}
#pragma warning restore 0169

		static IntPtr id_seekToSecondPrecise_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='seekToSecondPrecise' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("seekToSecondPrecise", "(D)Lorg/jcodec/api/FrameGrab;", "GetSeekToSecondPrecise_DHandler")]
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab SeekToSecondPrecise (double p0)
		{
			if (id_seekToSecondPrecise_D == IntPtr.Zero)
				id_seekToSecondPrecise_D = JNIEnv.GetMethodID (class_ref, "seekToSecondPrecise", "(D)Lorg/jcodec/api/FrameGrab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_seekToSecondPrecise_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekToSecondPrecise", "(D)Lorg/jcodec/api/FrameGrab;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_seekToSecondSloppy_D;
#pragma warning disable 0169
		static Delegate GetSeekToSecondSloppy_DHandler ()
		{
			if (cb_seekToSecondSloppy_D == null)
				cb_seekToSecondSloppy_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_SeekToSecondSloppy_D);
			return cb_seekToSecondSloppy_D;
		}

		static IntPtr n_SeekToSecondSloppy_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Org.Jcodec.Api.FrameGrab __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SeekToSecondSloppy (p0));
		}
#pragma warning restore 0169

		static IntPtr id_seekToSecondSloppy_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.api']/class[@name='FrameGrab']/method[@name='seekToSecondSloppy' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("seekToSecondSloppy", "(D)Lorg/jcodec/api/FrameGrab;", "GetSeekToSecondSloppy_DHandler")]
		public virtual unsafe global::Org.Jcodec.Api.FrameGrab SeekToSecondSloppy (double p0)
		{
			if (id_seekToSecondSloppy_D == IntPtr.Zero)
				id_seekToSecondSloppy_D = JNIEnv.GetMethodID (class_ref, "seekToSecondSloppy", "(D)Lorg/jcodec/api/FrameGrab;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_seekToSecondSloppy_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Api.FrameGrab> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekToSecondSloppy", "(D)Lorg/jcodec/api/FrameGrab;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
