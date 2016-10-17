using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool.Streaming.Tracks {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack", DoNotGenerateAcw=true)]
	public partial class Mpeg2AVCTrack : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/field[@name='TARGET_RATE']"
		[Register ("TARGET_RATE")]
		public const int TargetRate = (int) 1024;
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack.GOP']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP", DoNotGenerateAcw=true)]
		public partial class GOP : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GOP); }
			}

			protected GOP (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_ILorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_GOP_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack.GOP']/constructor[@name='Mpeg2AVCTrack.GOP' and count(parameter)=3 and parameter[1][@type='org.jcodec.movtool.streaming.tracks.Mpeg2AVCTrack'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.movtool.streaming.tracks.Mpeg2AVCTrack.GOP']]"
			[Register (".ctor", "(Lorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack;ILorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP;)V", "")]
			public unsafe GOP (global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack __self, int p1, global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack.GOP p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (GOP)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_ILorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_GOP_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_ILorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_GOP_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack;ILorg/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$GOP;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_ILorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_GOP_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_ILorg_jcodec_movtool_streaming_tracks_Mpeg2AVCTrack_GOP_, __args);
				} finally {
				}
			}

			static Delegate cb_getData_I;
#pragma warning disable 0169
			static Delegate GetGetData_IHandler ()
			{
				if (cb_getData_I == null)
					cb_getData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetData_I);
				return cb_getData_I;
			}

			static IntPtr n_GetData_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack.GOP __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack.GOP> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetData (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getData_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack.GOP']/method[@name='getData' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getData", "(I)Ljava/nio/ByteBuffer;", "GetGetData_IHandler")]
			public virtual unsafe global::Java.Nio.ByteBuffer GetData (int p0)
			{
				if (id_getData_I == IntPtr.Zero)
					id_getData_I = JNIEnv.GetMethodID (class_ref, "getData", "(I)Ljava/nio/ByteBuffer;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "(I)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack.TranscodePacket']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack$TranscodePacket", DoNotGenerateAcw=true)]
		public partial class TranscodePacket : global::Org.Jcodec.Movtool.Streaming.Tracks.VirtualPacketWrapper {

			protected TranscodePacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/streaming/tracks/Mpeg2AVCTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mpeg2AVCTrack); }
		}

		protected Mpeg2AVCTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPreferredTimescale;
#pragma warning disable 0169
		static Delegate GetGetPreferredTimescaleHandler ()
		{
			if (cb_getPreferredTimescale == null)
				cb_getPreferredTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreferredTimescale);
			return cb_getPreferredTimescale;
		}

		static int n_GetPreferredTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreferredTimescale;
		}
#pragma warning restore 0169

		static IntPtr id_getPreferredTimescale;
		public virtual unsafe int PreferredTimescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/method[@name='getPreferredTimescale' and count(parameter)=0]"
			[Register ("getPreferredTimescale", "()I", "GetGetPreferredTimescaleHandler")]
			get {
				if (id_getPreferredTimescale == IntPtr.Zero)
					id_getPreferredTimescale = JNIEnv.GetMethodID (class_ref, "getPreferredTimescale", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferredTimescale", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_createTranscoder_I;
#pragma warning disable 0169
		static Delegate GetCreateTranscoder_IHandler ()
		{
			if (cb_createTranscoder_I == null)
				cb_createTranscoder_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateTranscoder_I);
			return cb_createTranscoder_I;
		}

		static IntPtr n_CreateTranscoder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTranscoder (p0));
		}
#pragma warning restore 0169

		static IntPtr id_createTranscoder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/method[@name='createTranscoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createTranscoder", "(I)Lorg/jcodec/movtool/streaming/tracks/MPEGToAVCTranscoder;", "GetCreateTranscoder_IHandler")]
		protected virtual unsafe global::Org.Jcodec.Movtool.Streaming.Tracks.MPEGToAVCTranscoder CreateTranscoder (int p0)
		{
			if (id_createTranscoder_I == IntPtr.Zero)
				id_createTranscoder_I = JNIEnv.GetMethodID (class_ref, "createTranscoder", "(I)Lorg/jcodec/movtool/streaming/tracks/MPEGToAVCTranscoder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPEGToAVCTranscoder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createTranscoder_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.MPEGToAVCTranscoder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTranscoder", "(I)Lorg/jcodec/movtool/streaming/tracks/MPEGToAVCTranscoder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getPicType_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/method[@name='getPicType' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getPicType", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int GetPicType (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getPicType_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getPicType_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getPicType", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getPicType_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_selectScaleFactor_Lorg_jcodec_common_model_Size_;
#pragma warning disable 0169
		static Delegate GetSelectScaleFactor_Lorg_jcodec_common_model_Size_Handler ()
		{
			if (cb_selectScaleFactor_Lorg_jcodec_common_model_Size_ == null)
				cb_selectScaleFactor_Lorg_jcodec_common_model_Size_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SelectScaleFactor_Lorg_jcodec_common_model_Size_);
			return cb_selectScaleFactor_Lorg_jcodec_common_model_Size_;
		}

		static int n_SelectScaleFactor_Lorg_jcodec_common_model_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Streaming.Tracks.Mpeg2AVCTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Size p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SelectScaleFactor (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_selectScaleFactor_Lorg_jcodec_common_model_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool.streaming.tracks']/class[@name='Mpeg2AVCTrack']/method[@name='selectScaleFactor' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Size']]"
		[Register ("selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I", "GetSelectScaleFactor_Lorg_jcodec_common_model_Size_Handler")]
		protected virtual unsafe int SelectScaleFactor (global::Org.Jcodec.Common.Model.Size p0)
		{
			if (id_selectScaleFactor_Lorg_jcodec_common_model_Size_ == IntPtr.Zero)
				id_selectScaleFactor_Lorg_jcodec_common_model_Size_ = JNIEnv.GetMethodID (class_ref, "selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_selectScaleFactor_Lorg_jcodec_common_model_Size_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectScaleFactor", "(Lorg/jcodec/common/model/Size;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
