using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Demuxer {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/demuxer/MKVDemuxer", DoNotGenerateAcw=true)]
	public sealed partial class MKVDemuxer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$AudioTrack", DoNotGenerateAcw=true)]
		public partial class AudioTrack : global::Java.Lang.Object {


			static IntPtr samplingFrequency_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/field[@name='samplingFrequency']"
			[Register ("samplingFrequency")]
			public double SamplingFrequency {
				get {
					if (samplingFrequency_jfieldId == IntPtr.Zero)
						samplingFrequency_jfieldId = JNIEnv.GetFieldID (class_ref, "samplingFrequency", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, samplingFrequency_jfieldId);
				}
				set {
					if (samplingFrequency_jfieldId == IntPtr.Zero)
						samplingFrequency_jfieldId = JNIEnv.GetFieldID (class_ref, "samplingFrequency", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, samplingFrequency_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr trackNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/field[@name='trackNo']"
			[Register ("trackNo")]
			public int TrackNo {
				get {
					if (trackNo_jfieldId == IntPtr.Zero)
						trackNo_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNo", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, trackNo_jfieldId);
				}
				set {
					if (trackNo_jfieldId == IntPtr.Zero)
						trackNo_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNo", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, trackNo_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$AudioTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AudioTrack); }
			}

			protected AudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/constructor[@name='MKVDemuxer.AudioTrack' and count(parameter)=2 and parameter[1][@type='org.jcodec.containers.mkv.demuxer.MKVDemuxer'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer;I)V", "")]
			public unsafe AudioTrack (global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer __self, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (AudioTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_I == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_I, __args);
				} finally {
				}
			}

			static Delegate cb_getCurFrame;
#pragma warning disable 0169
			static Delegate GetGetCurFrameHandler ()
			{
				if (cb_getCurFrame == null)
					cb_getCurFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurFrame);
				return cb_getCurFrame;
			}

			static long n_GetCurFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurFrame;
			}
#pragma warning restore 0169

			static IntPtr id_getCurFrame;
			public virtual unsafe long CurFrame {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='getCurFrame' and count(parameter)=0]"
				[Register ("getCurFrame", "()J", "GetGetCurFrameHandler")]
				get {
					if (id_getCurFrame == IntPtr.Zero)
						id_getCurFrame = JNIEnv.GetMethodID (class_ref, "getCurFrame", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurFrame);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurFrame", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getFrames_I;
#pragma warning disable 0169
			static Delegate GetGetFrames_IHandler ()
			{
				if (cb_getFrames_I == null)
					cb_getFrames_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFrames_I);
				return cb_getFrames_I;
			}

			static IntPtr n_GetFrames_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetFrames (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getFrames_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='getFrames' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getFrames", "(I)Lorg/jcodec/common/model/Packet;", "GetGetFrames_IHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet GetFrames (int p0)
			{
				if (id_getFrames_I == IntPtr.Zero)
					id_getFrames_I = JNIEnv.GetMethodID (class_ref, "getFrames", "(I)Lorg/jcodec/common/model/Packet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrames_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrames", "(I)Lorg/jcodec/common/model/Packet;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_gotoFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoFrame_JHandler ()
			{
				if (cb_gotoFrame_J == null)
					cb_gotoFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoFrame_J);
				return cb_gotoFrame_J;
			}

			static bool n_GotoFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='gotoFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoFrame", "(J)Z", "GetGotoFrame_JHandler")]
			public virtual unsafe bool GotoFrame (long p0)
			{
				if (id_gotoFrame_J == IntPtr.Zero)
					id_gotoFrame_J = JNIEnv.GetMethodID (class_ref, "gotoFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_gotoSyncFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoSyncFrame_JHandler ()
			{
				if (cb_gotoSyncFrame_J == null)
					cb_gotoSyncFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoSyncFrame_J);
				return cb_gotoSyncFrame_J;
			}

			static bool n_GotoSyncFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoSyncFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoSyncFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='gotoSyncFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoSyncFrame", "(J)Z", "GetGotoSyncFrame_JHandler")]
			public virtual unsafe bool GotoSyncFrame (long p0)
			{
				if (id_gotoSyncFrame_J == IntPtr.Zero)
					id_gotoSyncFrame_J = JNIEnv.GetMethodID (class_ref, "gotoSyncFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoSyncFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoSyncFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_nextFrame;
#pragma warning disable 0169
			static Delegate GetNextFrameHandler ()
			{
				if (cb_nextFrame == null)
					cb_nextFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextFrame);
				return cb_nextFrame;
			}

			static IntPtr n_NextFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NextFrame ());
			}
#pragma warning restore 0169

			static IntPtr id_nextFrame;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='nextFrame' and count(parameter)=0]"
			[Register ("nextFrame", "()Lorg/jcodec/common/model/Packet;", "GetNextFrameHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet NextFrame ()
			{
				if (id_nextFrame == IntPtr.Zero)
					id_nextFrame = JNIEnv.GetMethodID (class_ref, "nextFrame", "()Lorg/jcodec/common/model/Packet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "()Lorg/jcodec/common/model/Packet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_seek_D;
#pragma warning disable 0169
			static Delegate GetSeek_DHandler ()
			{
				if (cb_seek_D == null)
					cb_seek_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Seek_D);
				return cb_seek_D;
			}

			static void n_Seek_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Seek (p0);
			}
#pragma warning restore 0169

			static IntPtr id_seek_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.AudioTrack']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("seek", "(D)V", "GetSeek_DHandler")]
			public virtual unsafe void Seek (double p0)
			{
				if (id_seek_D == IntPtr.Zero)
					id_seek_D = JNIEnv.GetMethodID (class_ref, "seek", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seek", "(D)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.IndexedBlock']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$IndexedBlock", DoNotGenerateAcw=true)]
		public partial class IndexedBlock : global::Java.Lang.Object {


			static IntPtr block_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.IndexedBlock']/field[@name='block']"
			[Register ("block")]
			public global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock Block {
				get {
					if (block_jfieldId == IntPtr.Zero)
						block_jfieldId = JNIEnv.GetFieldID (class_ref, "block", "Lorg/jcodec/containers/mkv/boxes/MkvBlock;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, block_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (block_jfieldId == IntPtr.Zero)
						block_jfieldId = JNIEnv.GetFieldID (class_ref, "block", "Lorg/jcodec/containers/mkv/boxes/MkvBlock;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, block_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr firstFrameNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.IndexedBlock']/field[@name='firstFrameNo']"
			[Register ("firstFrameNo")]
			public int FirstFrameNo {
				get {
					if (firstFrameNo_jfieldId == IntPtr.Zero)
						firstFrameNo_jfieldId = JNIEnv.GetFieldID (class_ref, "firstFrameNo", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, firstFrameNo_jfieldId);
				}
				set {
					if (firstFrameNo_jfieldId == IntPtr.Zero)
						firstFrameNo_jfieldId = JNIEnv.GetFieldID (class_ref, "firstFrameNo", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, firstFrameNo_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$IndexedBlock", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IndexedBlock); }
			}

			protected IndexedBlock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.IndexedBlock']/constructor[@name='MKVDemuxer.IndexedBlock' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe IndexedBlock ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (IndexedBlock)) {
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

			static IntPtr id_make_ILorg_jcodec_containers_mkv_boxes_MkvBlock_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.IndexedBlock']/method[@name='make' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.jcodec.containers.mkv.boxes.MkvBlock']]"
			[Register ("make", "(ILorg/jcodec/containers/mkv/boxes/MkvBlock;)Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer$IndexedBlock;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.IndexedBlock Make (int p0, global::Org.Jcodec.Containers.Mkv.Boxes.MkvBlock p1)
			{
				if (id_make_ILorg_jcodec_containers_mkv_boxes_MkvBlock_ == IntPtr.Zero)
					id_make_ILorg_jcodec_containers_mkv_boxes_MkvBlock_ = JNIEnv.GetStaticMethodID (class_ref, "make", "(ILorg/jcodec/containers/mkv/boxes/MkvBlock;)Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer$IndexedBlock;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.IndexedBlock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.IndexedBlock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_make_ILorg_jcodec_containers_mkv_boxes_MkvBlock_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$VideoTrack", DoNotGenerateAcw=true)]
		public partial class VideoTrack : global::Java.Lang.Object {


			static IntPtr trackNo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/field[@name='trackNo']"
			[Register ("trackNo")]
			public int TrackNo {
				get {
					if (trackNo_jfieldId == IntPtr.Zero)
						trackNo_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNo", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, trackNo_jfieldId);
				}
				set {
					if (trackNo_jfieldId == IntPtr.Zero)
						trackNo_jfieldId = JNIEnv.GetFieldID (class_ref, "trackNo", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, trackNo_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/demuxer/MKVDemuxer$VideoTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoTrack); }
			}

			protected VideoTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_ILjava_nio_ByteBuffer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/constructor[@name='MKVDemuxer.VideoTrack' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mkv.demuxer.MKVDemuxer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer;ILjava/nio/ByteBuffer;)V", "")]
			public unsafe VideoTrack (global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer __self, int p1, global::Java.Nio.ByteBuffer p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (VideoTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILjava/nio/ByteBuffer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILjava/nio/ByteBuffer;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mkv/demuxer/MKVDemuxer;ILjava/nio/ByteBuffer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_ILjava_nio_ByteBuffer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mkv_demuxer_MKVDemuxer_ILjava_nio_ByteBuffer_, __args);
				} finally {
				}
			}

			static Delegate cb_getCodecState;
#pragma warning disable 0169
			static Delegate GetGetCodecStateHandler ()
			{
				if (cb_getCodecState == null)
					cb_getCodecState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodecState);
				return cb_getCodecState;
			}

			static IntPtr n_GetCodecState (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CodecState);
			}
#pragma warning restore 0169

			static IntPtr id_getCodecState;
			public virtual unsafe global::Java.Nio.ByteBuffer CodecState {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='getCodecState' and count(parameter)=0]"
				[Register ("getCodecState", "()Ljava/nio/ByteBuffer;", "GetGetCodecStateHandler")]
				get {
					if (id_getCodecState == IntPtr.Zero)
						id_getCodecState = JNIEnv.GetMethodID (class_ref, "getCodecState", "()Ljava/nio/ByteBuffer;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodecState), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodecState", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getCurFrame;
#pragma warning disable 0169
			static Delegate GetGetCurFrameHandler ()
			{
				if (cb_getCurFrame == null)
					cb_getCurFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurFrame);
				return cb_getCurFrame;
			}

			static long n_GetCurFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurFrame;
			}
#pragma warning restore 0169

			static IntPtr id_getCurFrame;
			public virtual unsafe long CurFrame {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='getCurFrame' and count(parameter)=0]"
				[Register ("getCurFrame", "()J", "GetGetCurFrameHandler")]
				get {
					if (id_getCurFrame == IntPtr.Zero)
						id_getCurFrame = JNIEnv.GetMethodID (class_ref, "getCurFrame", "()J");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurFrame);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurFrame", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getFrameCount;
#pragma warning disable 0169
			static Delegate GetGetFrameCountHandler ()
			{
				if (cb_getFrameCount == null)
					cb_getFrameCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameCount);
				return cb_getFrameCount;
			}

			static int n_GetFrameCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameCount;
			}
#pragma warning restore 0169

			static IntPtr id_getFrameCount;
			public virtual unsafe int FrameCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='getFrameCount' and count(parameter)=0]"
				[Register ("getFrameCount", "()I", "GetGetFrameCountHandler")]
				get {
					if (id_getFrameCount == IntPtr.Zero)
						id_getFrameCount = JNIEnv.GetMethodID (class_ref, "getFrameCount", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameCount);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameCount", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_gotoFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoFrame_JHandler ()
			{
				if (cb_gotoFrame_J == null)
					cb_gotoFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoFrame_J);
				return cb_gotoFrame_J;
			}

			static bool n_GotoFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='gotoFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoFrame", "(J)Z", "GetGotoFrame_JHandler")]
			public virtual unsafe bool GotoFrame (long p0)
			{
				if (id_gotoFrame_J == IntPtr.Zero)
					id_gotoFrame_J = JNIEnv.GetMethodID (class_ref, "gotoFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_gotoSyncFrame_J;
#pragma warning disable 0169
			static Delegate GetGotoSyncFrame_JHandler ()
			{
				if (cb_gotoSyncFrame_J == null)
					cb_gotoSyncFrame_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_GotoSyncFrame_J);
				return cb_gotoSyncFrame_J;
			}

			static bool n_GotoSyncFrame_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GotoSyncFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_gotoSyncFrame_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='gotoSyncFrame' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("gotoSyncFrame", "(J)Z", "GetGotoSyncFrame_JHandler")]
			public virtual unsafe bool GotoSyncFrame (long p0)
			{
				if (id_gotoSyncFrame_J == IntPtr.Zero)
					id_gotoSyncFrame_J = JNIEnv.GetMethodID (class_ref, "gotoSyncFrame", "(J)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gotoSyncFrame_J, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "gotoSyncFrame", "(J)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_nextFrame;
#pragma warning disable 0169
			static Delegate GetNextFrameHandler ()
			{
				if (cb_nextFrame == null)
					cb_nextFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextFrame);
				return cb_nextFrame;
			}

			static IntPtr n_NextFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NextFrame ());
			}
#pragma warning restore 0169

			static IntPtr id_nextFrame;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='nextFrame' and count(parameter)=0]"
			[Register ("nextFrame", "()Lorg/jcodec/common/model/Packet;", "GetNextFrameHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet NextFrame ()
			{
				if (id_nextFrame == IntPtr.Zero)
					id_nextFrame = JNIEnv.GetMethodID (class_ref, "nextFrame", "()Lorg/jcodec/common/model/Packet;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "()Lorg/jcodec/common/model/Packet;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_seek_D;
#pragma warning disable 0169
			static Delegate GetSeek_DHandler ()
			{
				if (cb_seek_D == null)
					cb_seek_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Seek_D);
				return cb_seek_D;
			}

			static void n_Seek_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Demuxer.MKVDemuxer.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Seek (p0);
			}
#pragma warning restore 0169

			static IntPtr id_seek_D;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer.VideoTrack']/method[@name='seek' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("seek", "(D)V", "GetSeek_DHandler")]
			public virtual unsafe void Seek (double p0)
			{
				if (id_seek_D == IntPtr.Zero)
					id_seek_D = JNIEnv.GetMethodID (class_ref, "seek", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seek", "(D)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/demuxer/MKVDemuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKVDemuxer); }
		}

		internal MKVDemuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getPictureHeight;
		public unsafe int PictureHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer']/method[@name='getPictureHeight' and count(parameter)=0]"
			[Register ("getPictureHeight", "()I", "GetGetPictureHeightHandler")]
			get {
				if (id_getPictureHeight == IntPtr.Zero)
					id_getPictureHeight = JNIEnv.GetMethodID (class_ref, "getPictureHeight", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPictureHeight);
				} finally {
				}
			}
		}

		static IntPtr id_getPictureWidth;
		public unsafe int PictureWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.demuxer']/class[@name='MKVDemuxer']/method[@name='getPictureWidth' and count(parameter)=0]"
			[Register ("getPictureWidth", "()I", "GetGetPictureWidthHandler")]
			get {
				if (id_getPictureWidth == IntPtr.Zero)
					id_getPictureWidth = JNIEnv.GetMethodID (class_ref, "getPictureWidth", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPictureWidth);
				} finally {
				}
			}
		}

	}
}
