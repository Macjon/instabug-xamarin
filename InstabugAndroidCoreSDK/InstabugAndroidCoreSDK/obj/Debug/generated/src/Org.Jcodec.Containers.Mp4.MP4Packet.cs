using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/MP4Packet", DoNotGenerateAcw=true)]
	public partial class MP4Packet : global::Org.Jcodec.Common.Model.Packet {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/MP4Packet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MP4Packet); }
		}

		protected MP4Packet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=9 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode'] and parameter[8][@type='long'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", "")]
		public unsafe MP4Packet (global::Java.Nio.ByteBuffer data, long pts, long timescale, long duration, long frameNo, bool iframe, global::Org.Jcodec.Common.Model.TapeTimecode tapeTimecode, long mediaPts, int entryNo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (data);
				__args [1] = new JValue (pts);
				__args [2] = new JValue (timescale);
				__args [3] = new JValue (duration);
				__args [4] = new JValue (frameNo);
				__args [5] = new JValue (iframe);
				__args [6] = new JValue (tapeTimecode);
				__args [7] = new JValue (mediaPts);
				__args [8] = new JValue (entryNo);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JI, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JIJIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=12 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode'] and parameter[8][@type='long'] and parameter[9][@type='int'] and parameter[10][@type='long'] and parameter[11][@type='int'] and parameter[12][@type='boolean']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JIJIZ)V", "")]
		public unsafe MP4Packet (global::Java.Nio.ByteBuffer data, long pts, long timescale, long duration, long frameNo, bool iframe, global::Org.Jcodec.Common.Model.TapeTimecode tapeTimecode, long mediaPts, int entryNo, long fileOff, int size, bool psync)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [12];
				__args [0] = new JValue (data);
				__args [1] = new JValue (pts);
				__args [2] = new JValue (timescale);
				__args [3] = new JValue (duration);
				__args [4] = new JValue (frameNo);
				__args [5] = new JValue (iframe);
				__args [6] = new JValue (tapeTimecode);
				__args [7] = new JValue (mediaPts);
				__args [8] = new JValue (entryNo);
				__args [9] = new JValue (fileOff);
				__args [10] = new JValue (size);
				__args [11] = new JValue (psync);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JIJIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JIJIZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JIJIZ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JIJIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;JIJIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JIJIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_JIJIZ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Packet_JI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.model.Packet'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Packet;JI)V", "")]
		public unsafe MP4Packet (global::Org.Jcodec.Common.Model.Packet packet, long mediaPts, int entryNo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (packet);
				__args [1] = new JValue (mediaPts);
				__args [2] = new JValue (entryNo);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Packet;JI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Packet;JI)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Packet_JI == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Packet_JI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Packet;JI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Packet_JI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Packet_JI, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mp4.MP4Packet']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mp4/MP4Packet;)V", "")]
		public unsafe MP4Packet (global::Org.Jcodec.Containers.Mp4.MP4Packet packet)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (packet);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mp4/MP4Packet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mp4/MP4Packet;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mp4/MP4Packet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mp4.MP4Packet'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mp4/MP4Packet;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe MP4Packet (global::Org.Jcodec.Containers.Mp4.MP4Packet packet, global::Java.Nio.ByteBuffer frm)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (packet);
				__args [1] = new JValue (frm);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mp4/MP4Packet;Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mp4/MP4Packet;Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mp4/MP4Packet;Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Lorg_jcodec_common_model_TapeTimecode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/constructor[@name='MP4Packet' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mp4.MP4Packet'] and parameter[2][@type='org.jcodec.common.model.TapeTimecode']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mp4/MP4Packet;Lorg/jcodec/common/model/TapeTimecode;)V", "")]
		public unsafe MP4Packet (global::Org.Jcodec.Containers.Mp4.MP4Packet packet, global::Org.Jcodec.Common.Model.TapeTimecode timecode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (packet);
				__args [1] = new JValue (timecode);
				if (((object) this).GetType () != typeof (MP4Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mp4/MP4Packet;Lorg/jcodec/common/model/TapeTimecode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mp4/MP4Packet;Lorg/jcodec/common/model/TapeTimecode;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Lorg_jcodec_common_model_TapeTimecode_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Lorg_jcodec_common_model_TapeTimecode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mp4/MP4Packet;Lorg/jcodec/common/model/TapeTimecode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Lorg_jcodec_common_model_TapeTimecode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mp4_MP4Packet_Lorg_jcodec_common_model_TapeTimecode_, __args);
			} finally {
			}
		}

		static Delegate cb_getEntryNo;
#pragma warning disable 0169
		static Delegate GetGetEntryNoHandler ()
		{
			if (cb_getEntryNo == null)
				cb_getEntryNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntryNo);
			return cb_getEntryNo;
		}

		static int n_GetEntryNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.MP4Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryNo;
		}
#pragma warning restore 0169

		static IntPtr id_getEntryNo;
		public virtual unsafe int EntryNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/method[@name='getEntryNo' and count(parameter)=0]"
			[Register ("getEntryNo", "()I", "GetGetEntryNoHandler")]
			get {
				if (id_getEntryNo == IntPtr.Zero)
					id_getEntryNo = JNIEnv.GetMethodID (class_ref, "getEntryNo", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntryNo);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryNo", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFileOff;
#pragma warning disable 0169
		static Delegate GetGetFileOffHandler ()
		{
			if (cb_getFileOff == null)
				cb_getFileOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileOff);
			return cb_getFileOff;
		}

		static long n_GetFileOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.MP4Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileOff;
		}
#pragma warning restore 0169

		static IntPtr id_getFileOff;
		public virtual unsafe long FileOff {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/method[@name='getFileOff' and count(parameter)=0]"
			[Register ("getFileOff", "()J", "GetGetFileOffHandler")]
			get {
				if (id_getFileOff == IntPtr.Zero)
					id_getFileOff = JNIEnv.GetMethodID (class_ref, "getFileOff", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFileOff);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileOff", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isPsync;
#pragma warning disable 0169
		static Delegate GetIsPsyncHandler ()
		{
			if (cb_isPsync == null)
				cb_isPsync = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPsync);
			return cb_isPsync;
		}

		static bool n_IsPsync (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.MP4Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPsync;
		}
#pragma warning restore 0169

		static IntPtr id_isPsync;
		public virtual unsafe bool IsPsync {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/method[@name='isPsync' and count(parameter)=0]"
			[Register ("isPsync", "()Z", "GetIsPsyncHandler")]
			get {
				if (id_isPsync == IntPtr.Zero)
					id_isPsync = JNIEnv.GetMethodID (class_ref, "isPsync", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPsync);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPsync", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMediaPts;
#pragma warning disable 0169
		static Delegate GetGetMediaPtsHandler ()
		{
			if (cb_getMediaPts == null)
				cb_getMediaPts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMediaPts);
			return cb_getMediaPts;
		}

		static long n_GetMediaPts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.MP4Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediaPts;
		}
#pragma warning restore 0169

		static IntPtr id_getMediaPts;
		public virtual unsafe long MediaPts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/method[@name='getMediaPts' and count(parameter)=0]"
			[Register ("getMediaPts", "()J", "GetGetMediaPtsHandler")]
			get {
				if (id_getMediaPts == IntPtr.Zero)
					id_getMediaPts = JNIEnv.GetMethodID (class_ref, "getMediaPts", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMediaPts);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaPts", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.MP4Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.MP4Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='MP4Packet']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
				} finally {
				}
			}
		}

	}
}
