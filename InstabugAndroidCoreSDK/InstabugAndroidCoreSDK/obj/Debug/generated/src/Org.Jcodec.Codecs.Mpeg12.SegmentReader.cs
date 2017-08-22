using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/SegmentReader", DoNotGenerateAcw=true)]
	public partial class SegmentReader : global::Java.Lang.Object {


		static IntPtr curMarker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/field[@name='curMarker']"
		[Register ("curMarker")]
		protected int CurMarker {
			get {
				if (curMarker_jfieldId == IntPtr.Zero)
					curMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "curMarker", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, curMarker_jfieldId);
			}
			set {
				if (curMarker_jfieldId == IntPtr.Zero)
					curMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "curMarker", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, curMarker_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/SegmentReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SegmentReader); }
		}

		protected SegmentReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/constructor[@name='SegmentReader' and count(parameter)=1 and parameter[1][@type='java.nio.channels.ReadableByteChannel']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;)V", "")]
		public unsafe SegmentReader (global::Java.Nio.Channels.IReadableByteChannel channel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);
				if (((object) this).GetType () != typeof (SegmentReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_ == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_nio_channels_ReadableByteChannel_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/constructor[@name='SegmentReader' and count(parameter)=2 and parameter[1][@type='java.nio.channels.ReadableByteChannel'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/nio/channels/ReadableByteChannel;I)V", "")]
		public unsafe SegmentReader (global::Java.Nio.Channels.IReadableByteChannel channel, int fetchSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (channel);
				__args [1] = new JValue (fetchSize);
				if (((object) this).GetType () != typeof (SegmentReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/channels/ReadableByteChannel;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/channels/ReadableByteChannel;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_channels_ReadableByteChannel_I == IntPtr.Zero)
					id_ctor_Ljava_nio_channels_ReadableByteChannel_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/channels/ReadableByteChannel;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_channels_ReadableByteChannel_I, __args);
			} finally {
			}
		}

		static IntPtr id_curPos;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/method[@name='curPos' and count(parameter)=0]"
		[Register ("curPos", "()J", "")]
		public unsafe long CurPos ()
		{
			if (id_curPos == IntPtr.Zero)
				id_curPos = JNIEnv.GetMethodID (class_ref, "curPos", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_curPos);
			} finally {
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;I)Z", "")]
		public unsafe bool Read (global::Java.Nio.ByteBuffer @out, int length)
		{
			if (id_read_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;I)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@out);
				__args [1] = new JValue (length);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readToNextMarker_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/method[@name='readToNextMarker' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readToNextMarker", "(Ljava/nio/ByteBuffer;)Z", "")]
		public unsafe bool ReadToNextMarker (global::Java.Nio.ByteBuffer @out)
		{
			if (id_readToNextMarker_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readToNextMarker_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "readToNextMarker", "(Ljava/nio/ByteBuffer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_readToNextMarker_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_skipToMarker;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='SegmentReader']/method[@name='skipToMarker' and count(parameter)=0]"
		[Register ("skipToMarker", "()Z", "")]
		public unsafe bool SkipToMarker ()
		{
			if (id_skipToMarker == IntPtr.Zero)
				id_skipToMarker = JNIEnv.GetMethodID (class_ref, "skipToMarker", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipToMarker);
			} finally {
			}
		}

	}
}
