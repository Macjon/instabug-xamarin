using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Muxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/muxer/MKVMuxerTrack", DoNotGenerateAcw=true)]
	public partial class MKVMuxerTrack : global::Java.Lang.Object {


		static IntPtr codecId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/field[@name='codecId']"
		[Register ("codecId")]
		public string CodecId {
			get {
				if (codecId_jfieldId == IntPtr.Zero)
					codecId_jfieldId = JNIEnv.GetFieldID (class_ref, "codecId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codecId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codecId_jfieldId == IntPtr.Zero)
					codecId_jfieldId = JNIEnv.GetFieldID (class_ref, "codecId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frameDimentions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/field[@name='frameDimentions']"
		[Register ("frameDimentions")]
		public global::Org.Jcodec.Common.Model.Size FrameDimentions {
			get {
				if (frameDimentions_jfieldId == IntPtr.Zero)
					frameDimentions_jfieldId = JNIEnv.GetFieldID (class_ref, "frameDimentions", "Lorg/jcodec/common/model/Size;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frameDimentions_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frameDimentions_jfieldId == IntPtr.Zero)
					frameDimentions_jfieldId = JNIEnv.GetFieldID (class_ref, "frameDimentions", "Lorg/jcodec/common/model/Size;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameDimentions_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/field[@name='type']"
		[Register ("type")]
		public global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack.MKVMuxerTrackType']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType", DoNotGenerateAcw=true)]
		public sealed partial class MKVMuxerTrackType : global::Java.Lang.Enum {


			static IntPtr VIDEO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack.MKVMuxerTrackType']/field[@name='VIDEO']"
			[Register ("VIDEO")]
			public static global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType Video {
				get {
					if (VIDEO_jfieldId == IntPtr.Zero)
						VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO", "Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MKVMuxerTrackType); }
			}

			internal MKVMuxerTrackType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack.MKVMuxerTrackType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack.MKVMuxerTrackType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mkv/muxer/MKVMuxerTrack$MKVMuxerTrackType;");
				try {
					return (global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack.MKVMuxerTrackType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/muxer/MKVMuxerTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKVMuxerTrack); }
		}

		protected MKVMuxerTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/constructor[@name='MKVMuxerTrack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKVMuxerTrack ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MKVMuxerTrack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static Delegate cb_getTimescale;
#pragma warning disable 0169
		static Delegate GetGetTimescaleHandler ()
		{
			if (cb_getTimescale == null)
				cb_getTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimescale);
			return cb_getTimescale;
		}

		static int n_GetTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timescale;
		}
#pragma warning restore 0169

		static IntPtr id_getTimescale;
		public virtual unsafe int Timescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/method[@name='getTimescale' and count(parameter)=0]"
			[Register ("getTimescale", "()I", "GetGetTimescaleHandler")]
			get {
				if (id_getTimescale == IntPtr.Zero)
					id_getTimescale = JNIEnv.GetMethodID (class_ref, "getTimescale", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimescale);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimescale", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTrackNo;
#pragma warning disable 0169
		static Delegate GetGetTrackNoHandler ()
		{
			if (cb_getTrackNo == null)
				cb_getTrackNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTrackNo);
			return cb_getTrackNo;
		}

		static long n_GetTrackNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackNo;
		}
#pragma warning restore 0169

		static IntPtr id_getTrackNo;
		public virtual unsafe long TrackNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/method[@name='getTrackNo' and count(parameter)=0]"
			[Register ("getTrackNo", "()J", "GetGetTrackNoHandler")]
			get {
				if (id_getTrackNo == IntPtr.Zero)
					id_getTrackNo = JNIEnv.GetMethodID (class_ref, "getTrackNo", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTrackNo);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackNo", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_addSampleEntry_Ljava_nio_ByteBuffer_I;
#pragma warning disable 0169
		static Delegate GetAddSampleEntry_Ljava_nio_ByteBuffer_IHandler ()
		{
			if (cb_addSampleEntry_Ljava_nio_ByteBuffer_I == null)
				cb_addSampleEntry_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_AddSampleEntry_Ljava_nio_ByteBuffer_I);
			return cb_addSampleEntry_Ljava_nio_ByteBuffer_I;
		}

		static void n_AddSampleEntry_Ljava_nio_ByteBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Muxer.MKVMuxerTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSampleEntry (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addSampleEntry_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.muxer']/class[@name='MKVMuxerTrack']/method[@name='addSampleEntry' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("addSampleEntry", "(Ljava/nio/ByteBuffer;I)V", "GetAddSampleEntry_Ljava_nio_ByteBuffer_IHandler")]
		public virtual unsafe void AddSampleEntry (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_addSampleEntry_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_addSampleEntry_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID (class_ref, "addSampleEntry", "(Ljava/nio/ByteBuffer;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSampleEntry_Ljava_nio_ByteBuffer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSampleEntry", "(Ljava/nio/ByteBuffer;I)V"), __args);
			} finally {
			}
		}

	}
}
