using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/MkvBlock", DoNotGenerateAcw=true)]
	public partial class MkvBlock : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin {


		static IntPtr absoluteTimecode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='absoluteTimecode']"
		[Register ("absoluteTimecode")]
		public long AbsoluteTimecode {
			get {
				if (absoluteTimecode_jfieldId == IntPtr.Zero)
					absoluteTimecode_jfieldId = JNIEnv.GetFieldID (class_ref, "absoluteTimecode", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, absoluteTimecode_jfieldId);
			}
			set {
				if (absoluteTimecode_jfieldId == IntPtr.Zero)
					absoluteTimecode_jfieldId = JNIEnv.GetFieldID (class_ref, "absoluteTimecode", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, absoluteTimecode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr discardable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='discardable']"
		[Register ("discardable")]
		public bool Discardable {
			get {
				if (discardable_jfieldId == IntPtr.Zero)
					discardable_jfieldId = JNIEnv.GetFieldID (class_ref, "discardable", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, discardable_jfieldId);
			}
			set {
				if (discardable_jfieldId == IntPtr.Zero)
					discardable_jfieldId = JNIEnv.GetFieldID (class_ref, "discardable", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, discardable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frameOffsets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='frameOffsets']"
		[Register ("frameOffsets")]
		public IList<int> FrameOffsets {
			get {
				if (frameOffsets_jfieldId == IntPtr.Zero)
					frameOffsets_jfieldId = JNIEnv.GetFieldID (class_ref, "frameOffsets", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frameOffsets_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frameOffsets_jfieldId == IntPtr.Zero)
					frameOffsets_jfieldId = JNIEnv.GetFieldID (class_ref, "frameOffsets", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameOffsets_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frameSizes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='frameSizes']"
		[Register ("frameSizes")]
		public IList<int> FrameSizes {
			get {
				if (frameSizes_jfieldId == IntPtr.Zero)
					frameSizes_jfieldId = JNIEnv.GetFieldID (class_ref, "frameSizes", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frameSizes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frameSizes_jfieldId == IntPtr.Zero)
					frameSizes_jfieldId = JNIEnv.GetFieldID (class_ref, "frameSizes", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameSizes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='frames']"
		[Register ("frames")]
		public IList<Java.Nio.ByteBuffer> Frames {
			get {
				if (frames_jfieldId == IntPtr.Zero)
					frames_jfieldId = JNIEnv.GetFieldID (class_ref, "frames", "[Ljava/nio/ByteBuffer;");
				return global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, frames_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frames_jfieldId == IntPtr.Zero)
					frames_jfieldId = JNIEnv.GetFieldID (class_ref, "frames", "[Ljava/nio/ByteBuffer;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frames_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr headerSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='headerSize']"
		[Register ("headerSize")]
		public int HeaderSize {
			get {
				if (headerSize_jfieldId == IntPtr.Zero)
					headerSize_jfieldId = JNIEnv.GetFieldID (class_ref, "headerSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, headerSize_jfieldId);
			}
			set {
				if (headerSize_jfieldId == IntPtr.Zero)
					headerSize_jfieldId = JNIEnv.GetFieldID (class_ref, "headerSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headerSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lacing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='lacing']"
		[Register ("lacing")]
		public string Lacing {
			get {
				if (lacing_jfieldId == IntPtr.Zero)
					lacing_jfieldId = JNIEnv.GetFieldID (class_ref, "lacing", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, lacing_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (lacing_jfieldId == IntPtr.Zero)
					lacing_jfieldId = JNIEnv.GetFieldID (class_ref, "lacing", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lacing_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lacingPresent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='lacingPresent']"
		[Register ("lacingPresent")]
		public bool LacingPresent {
			get {
				if (lacingPresent_jfieldId == IntPtr.Zero)
					lacingPresent_jfieldId = JNIEnv.GetFieldID (class_ref, "lacingPresent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, lacingPresent_jfieldId);
			}
			set {
				if (lacingPresent_jfieldId == IntPtr.Zero)
					lacingPresent_jfieldId = JNIEnv.GetFieldID (class_ref, "lacingPresent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lacingPresent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timecode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='timecode']"
		[Register ("timecode")]
		public int Timecode {
			get {
				if (timecode_jfieldId == IntPtr.Zero)
					timecode_jfieldId = JNIEnv.GetFieldID (class_ref, "timecode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, timecode_jfieldId);
			}
			set {
				if (timecode_jfieldId == IntPtr.Zero)
					timecode_jfieldId = JNIEnv.GetFieldID (class_ref, "timecode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timecode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr trackNumber_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/field[@name='trackNumber']"
		[Register ("trackNumber")]
		public long TrackNumber {
			get {
				if (trackNumber_jfieldId == IntPtr.Zero)
					trackNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNumber", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, trackNumber_jfieldId);
			}
			set {
				if (trackNumber_jfieldId == IntPtr.Zero)
					trackNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNumber", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, trackNumber_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/MkvBlock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MkvBlock); }
		}

		protected MkvBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/constructor[@name='MkvBlock' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MkvBlock (byte[] type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_type = JNIEnv.NewArray (type);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_type);
				if (((object) this).GetType () != typeof (MkvBlock)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (type != null) {
					JNIEnv.CopyArray (native_type, type);
					JNIEnv.DeleteLocalRef (native_type);
				}
			}
		}

		static Delegate cb_getDataSize;
#pragma warning disable 0169
		static Delegate GetGetDataSizeHandler ()
		{
			if (cb_getDataSize == null)
				cb_getDataSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataSize);
			return cb_getDataSize;
		}

		static int n_GetDataSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataSize;
		}
#pragma warning restore 0169

		static IntPtr id_getDataSize;
		public virtual unsafe int DataSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='getDataSize' and count(parameter)=0]"
			[Register ("getDataSize", "()I", "GetGetDataSizeHandler")]
			get {
				if (id_getDataSize == IntPtr.Zero)
					id_getDataSize = JNIEnv.GetMethodID (class_ref, "getDataSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataSize", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_calcEbmlLacingDiffs_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='calcEbmlLacingDiffs' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("calcEbmlLacingDiffs", "([I)[J", "")]
		public static unsafe long[] CalcEbmlLacingDiffs (int[] laceSizes)
		{
			if (id_calcEbmlLacingDiffs_arrayI == IntPtr.Zero)
				id_calcEbmlLacingDiffs_arrayI = JNIEnv.GetStaticMethodID (class_ref, "calcEbmlLacingDiffs", "([I)[J");
			IntPtr native_laceSizes = JNIEnv.NewArray (laceSizes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_laceSizes);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_calcEbmlLacingDiffs_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (laceSizes != null) {
					JNIEnv.CopyArray (native_laceSizes, laceSizes);
					JNIEnv.DeleteLocalRef (native_laceSizes);
				}
			}
		}

		static IntPtr id_copy_Lorg_jcodec_containers_mkv_boxes_MkvBlock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.boxes.MkvBlock']]"
		[Register ("copy", "(Lorg/jcodec/containers/mkv/boxes/MkvBlock;)Lorg/jcodec/containers/mkv/boxes/MkvBlock;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock Copy (global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock old)
		{
			if (id_copy_Lorg_jcodec_containers_mkv_boxes_MkvBlock_ == IntPtr.Zero)
				id_copy_Lorg_jcodec_containers_mkv_boxes_MkvBlock_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Lorg/jcodec/containers/mkv/boxes/MkvBlock;)Lorg/jcodec/containers/mkv/boxes/MkvBlock;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (old);
				global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copy_Lorg_jcodec_containers_mkv_boxes_MkvBlock_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ebmlDecode_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='ebmlDecode' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("ebmlDecode", "(Ljava/nio/ByteBuffer;)J", "")]
		public static unsafe long EbmlDecode (global::Java.Nio.ByteBuffer bb)
		{
			if (id_ebmlDecode_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_ebmlDecode_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "ebmlDecode", "(Ljava/nio/ByteBuffer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bb);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_ebmlDecode_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ebmlDecodeSigned_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='ebmlDecodeSigned' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("ebmlDecodeSigned", "(Ljava/nio/ByteBuffer;)J", "")]
		public static unsafe long EbmlDecodeSigned (global::Java.Nio.ByteBuffer source)
		{
			if (id_ebmlDecodeSigned_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_ebmlDecodeSigned_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "ebmlDecodeSigned", "(Ljava/nio/ByteBuffer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_ebmlDecodeSigned_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getFrames_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetGetFrames_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_getFrames_Ljava_nio_ByteBuffer_ == null)
				cb_getFrames_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFrames_Ljava_nio_ByteBuffer_);
			return cb_getFrames_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_GetFrames_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer source = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetFrames (source));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFrames_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='getFrames' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getFrames", "(Ljava/nio/ByteBuffer;)[Ljava/nio/ByteBuffer;", "GetGetFrames_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Java.Nio.ByteBuffer[] GetFrames (global::Java.Nio.ByteBuffer source)
		{
			if (id_getFrames_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getFrames_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "getFrames", "(Ljava/nio/ByteBuffer;)[Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				global::Java.Nio.ByteBuffer[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrames_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Nio.ByteBuffer));
				else
					__ret = (global::Java.Nio.ByteBuffer[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrames", "(Ljava/nio/ByteBuffer;)[Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Nio.ByteBuffer));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_keyFrame_JILjava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='keyFrame' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register ("keyFrame", "(JILjava/nio/ByteBuffer;)Lorg/jcodec/containers/mkv/boxes/MkvBlock;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock KeyFrame (long trackNumber, int timecode, global::Java.Nio.ByteBuffer frame)
		{
			if (id_keyFrame_JILjava_nio_ByteBuffer_ == IntPtr.Zero)
				id_keyFrame_JILjava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "keyFrame", "(JILjava/nio/ByteBuffer;)Lorg/jcodec/containers/mkv/boxes/MkvBlock;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (trackNumber);
				__args [1] = new JValue (timecode);
				__args [2] = new JValue (frame);
				global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_keyFrame_JILjava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_muxEbmlLacing_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='muxEbmlLacing' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("muxEbmlLacing", "([I)[B", "")]
		public static unsafe byte[] MuxEbmlLacing (int[] laceSizes)
		{
			if (id_muxEbmlLacing_arrayI == IntPtr.Zero)
				id_muxEbmlLacing_arrayI = JNIEnv.GetStaticMethodID (class_ref, "muxEbmlLacing", "([I)[B");
			IntPtr native_laceSizes = JNIEnv.NewArray (laceSizes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_laceSizes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_muxEbmlLacing_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (laceSizes != null) {
					JNIEnv.CopyArray (native_laceSizes, laceSizes);
					JNIEnv.DeleteLocalRef (native_laceSizes);
				}
			}
		}

		static IntPtr id_muxXiphLacing_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='muxXiphLacing' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("muxXiphLacing", "([I)[B", "")]
		public static unsafe byte[] MuxXiphLacing (int[] laceSizes)
		{
			if (id_muxXiphLacing_arrayI == IntPtr.Zero)
				id_muxXiphLacing_arrayI = JNIEnv.GetStaticMethodID (class_ref, "muxXiphLacing", "([I)[B");
			IntPtr native_laceSizes = JNIEnv.NewArray (laceSizes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_laceSizes);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_muxXiphLacing_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (laceSizes != null) {
					JNIEnv.CopyArray (native_laceSizes, laceSizes);
					JNIEnv.DeleteLocalRef (native_laceSizes);
				}
			}
		}

		static IntPtr id_readEBMLLaceSizes_Ljava_nio_ByteBuffer_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='readEBMLLaceSizes' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readEBMLLaceSizes", "(Ljava/nio/ByteBuffer;[III)I", "")]
		public static unsafe int ReadEBMLLaceSizes (global::Java.Nio.ByteBuffer source, int[] sizes, int size, int preLacingHeaderSize)
		{
			if (id_readEBMLLaceSizes_Ljava_nio_ByteBuffer_arrayIII == IntPtr.Zero)
				id_readEBMLLaceSizes_Ljava_nio_ByteBuffer_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "readEBMLLaceSizes", "(Ljava/nio/ByteBuffer;[III)I");
			IntPtr native_sizes = JNIEnv.NewArray (sizes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (source);
				__args [1] = new JValue (native_sizes);
				__args [2] = new JValue (size);
				__args [3] = new JValue (preLacingHeaderSize);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readEBMLLaceSizes_Ljava_nio_ByteBuffer_arrayIII, __args);
				return __ret;
			} finally {
				if (sizes != null) {
					JNIEnv.CopyArray (native_sizes, sizes);
					JNIEnv.DeleteLocalRef (native_sizes);
				}
			}
		}

		static Delegate cb_readFrames_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadFrames_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readFrames_Ljava_nio_ByteBuffer_ == null)
				cb_readFrames_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadFrames_Ljava_nio_ByteBuffer_);
			return cb_readFrames_Ljava_nio_ByteBuffer_;
		}

		static void n_ReadFrames_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer source = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.ReadFrames (source);
		}
#pragma warning restore 0169

		static IntPtr id_readFrames_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='readFrames' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readFrames", "(Ljava/nio/ByteBuffer;)V", "GetReadFrames_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void ReadFrames (global::Java.Nio.ByteBuffer source)
		{
			if (id_readFrames_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readFrames_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "readFrames", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFrames_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFrames", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_readXiphLaceSizes_Ljava_nio_ByteBuffer_arrayIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='readXiphLaceSizes' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readXiphLaceSizes", "(Ljava/nio/ByteBuffer;[III)I", "")]
		public static unsafe int ReadXiphLaceSizes (global::Java.Nio.ByteBuffer bb, int[] sizes, int size, int preLacingHeaderSize)
		{
			if (id_readXiphLaceSizes_Ljava_nio_ByteBuffer_arrayIII == IntPtr.Zero)
				id_readXiphLaceSizes_Ljava_nio_ByteBuffer_arrayIII = JNIEnv.GetStaticMethodID (class_ref, "readXiphLaceSizes", "(Ljava/nio/ByteBuffer;[III)I");
			IntPtr native_sizes = JNIEnv.NewArray (sizes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (bb);
				__args [1] = new JValue (native_sizes);
				__args [2] = new JValue (size);
				__args [3] = new JValue (preLacingHeaderSize);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_readXiphLaceSizes_Ljava_nio_ByteBuffer_arrayIII, __args);
				return __ret;
			} finally {
				if (sizes != null) {
					JNIEnv.CopyArray (native_sizes, sizes);
					JNIEnv.DeleteLocalRef (native_sizes);
				}
			}
		}

		static Delegate cb_seekAndReadContent_Ljava_nio_channels_FileChannel_;
#pragma warning disable 0169
		static Delegate GetSeekAndReadContent_Ljava_nio_channels_FileChannel_Handler ()
		{
			if (cb_seekAndReadContent_Ljava_nio_channels_FileChannel_ == null)
				cb_seekAndReadContent_Ljava_nio_channels_FileChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SeekAndReadContent_Ljava_nio_channels_FileChannel_);
			return cb_seekAndReadContent_Ljava_nio_channels_FileChannel_;
		}

		static void n_SeekAndReadContent_Ljava_nio_channels_FileChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.Channels.FileChannel source = global::Java.Lang.Object.GetObject<global::Java.Nio.Channels.FileChannel> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.SeekAndReadContent (source);
		}
#pragma warning restore 0169

		static IntPtr id_seekAndReadContent_Ljava_nio_channels_FileChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='MkvBlock']/method[@name='seekAndReadContent' and count(parameter)=1 and parameter[1][@type='java.nio.channels.FileChannel']]"
		[Register ("seekAndReadContent", "(Ljava/nio/channels/FileChannel;)V", "GetSeekAndReadContent_Ljava_nio_channels_FileChannel_Handler")]
		public virtual unsafe void SeekAndReadContent (global::Java.Nio.Channels.FileChannel source)
		{
			if (id_seekAndReadContent_Ljava_nio_channels_FileChannel_ == IntPtr.Zero)
				id_seekAndReadContent_Ljava_nio_channels_FileChannel_ = JNIEnv.GetMethodID (class_ref, "seekAndReadContent", "(Ljava/nio/channels/FileChannel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (source);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekAndReadContent_Ljava_nio_channels_FileChannel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekAndReadContent", "(Ljava/nio/channels/FileChannel;)V"), __args);
			} finally {
			}
		}

	}
}
