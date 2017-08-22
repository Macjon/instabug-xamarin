using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer", DoNotGenerateAcw=true)]
	public partial class MPSDemuxer : global::Org.Jcodec.Codecs.Mpeg12.SegmentReader {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$BaseTrack", DoNotGenerateAcw=true)]
		public abstract partial class BaseTrack : global::Java.Lang.Object {


			static IntPtr streamId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/field[@name='streamId']"
			[Register ("streamId")]
			protected int StreamId {
				get {
					if (streamId_jfieldId == IntPtr.Zero)
						streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId);
				}
				set {
					if (streamId_jfieldId == IntPtr.Zero)
						streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer$BaseTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseTrack); }
			}

			protected BaseTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/constructor[@name='MPSDemuxer.BaseTrack' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mps.MPSDemuxer'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.containers.mps.MPSDemuxer.PESPacket']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", "")]
			public unsafe BaseTrack (global::Org.Jcodec.Containers.Mps.MPSDemuxer __self, int streamId, global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (streamId);
					__args [2] = new JValue (pkt);
					if (((object) this).GetType () != typeof (BaseTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args);
				} finally {
				}
			}

			static Delegate cb_getPending;
#pragma warning disable 0169
			static Delegate GetGetPendingHandler ()
			{
				if (cb_getPending == null)
					cb_getPending = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPending);
				return cb_getPending;
			}

			static IntPtr n_GetPending (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket>.ToLocalJniHandle (__this.Pending);
			}
#pragma warning restore 0169

			static IntPtr id_getPending;
			public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> Pending {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/method[@name='getPending' and count(parameter)=0]"
				[Register ("getPending", "()Ljava/util/List;", "GetGetPendingHandler")]
				get {
					if (id_getPending == IntPtr.Zero)
						id_getPending = JNIEnv.GetMethodID (class_ref, "getPending", "()Ljava/util/List;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPending), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPending", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSid;
#pragma warning disable 0169
			static Delegate GetGetSidHandler ()
			{
				if (cb_getSid == null)
					cb_getSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSid);
				return cb_getSid;
			}

			static int n_GetSid (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Sid;
			}
#pragma warning restore 0169

			static IntPtr id_getSid;
			public virtual unsafe int Sid {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/method[@name='getSid' and count(parameter)=0]"
				[Register ("getSid", "()I", "GetGetSidHandler")]
				get {
					if (id_getSid == IntPtr.Zero)
						id_getSid = JNIEnv.GetMethodID (class_ref, "getSid", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSid);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSid", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_ignore;
#pragma warning disable 0169
			static Delegate GetIgnoreHandler ()
			{
				if (cb_ignore == null)
					cb_ignore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Ignore);
				return cb_ignore;
			}

			static void n_Ignore (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ignore ();
			}
#pragma warning restore 0169

			static IntPtr id_ignore;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/method[@name='ignore' and count(parameter)=0]"
			[Register ("ignore", "()V", "GetIgnoreHandler")]
			public virtual unsafe void Ignore ()
			{
				if (id_ignore == IntPtr.Zero)
					id_ignore = JNIEnv.GetMethodID (class_ref, "ignore", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ignore);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ignore", "()V"));
				} finally {
				}
			}

			static Delegate cb_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
#pragma warning disable 0169
			static Delegate GetInvokePending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_Handler ()
			{
				if (cb_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ == null)
					cb_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvokePending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_);
				return cb_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
			}

			static void n_InvokePending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkt)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (native_pkt, JniHandleOwnership.DoNotTransfer);
				__this.InvokePending (pkt);
			}
#pragma warning restore 0169

			static IntPtr id_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.BaseTrack']/method[@name='pending' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mps.MPSDemuxer.PESPacket']]"
			[Register ("pending", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", "GetInvokePending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_Handler")]
			public virtual unsafe void InvokePending (global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt)
			{
				if (id_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ == IntPtr.Zero)
					id_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ = JNIEnv.GetMethodID (class_ref, "pending", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (pkt);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pending_Lorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pending", "(Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V"), __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$BaseTrack", DoNotGenerateAcw=true)]
		internal partial class BaseTrackInvoker : BaseTrack {

			public BaseTrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (BaseTrackInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$MPEGPacket", DoNotGenerateAcw=true)]
		public partial class MPEGPacket : global::Org.Jcodec.Common.Model.Packet {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer$MPEGPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MPEGPacket); }
			}

			protected MPEGPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']/constructor[@name='MPSDemuxer.MPEGPacket' and count(parameter)=7 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode']]"
			[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", "")]
			public unsafe MPEGPacket (global::Java.Nio.ByteBuffer data, long pts, long timescale, long duration, long frameNo, bool keyFrame, global::Org.Jcodec.Common.Model.TapeTimecode tapeTimecode)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [7];
					__args [0] = new JValue (data);
					__args [1] = new JValue (pts);
					__args [2] = new JValue (timescale);
					__args [3] = new JValue (duration);
					__args [4] = new JValue (frameNo);
					__args [5] = new JValue (keyFrame);
					__args [6] = new JValue (tapeTimecode);
					if (((object) this).GetType () != typeof (MPEGPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", __args);
						return;
					}

					if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_ == IntPtr.Zero)
						id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_, __args);
				} finally {
				}
			}

			static Delegate cb_getGOP;
#pragma warning disable 0169
			static Delegate GetGetGOPHandler ()
			{
				if (cb_getGOP == null)
					cb_getGOP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGOP);
				return cb_getGOP;
			}

			static int n_GetGOP (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GOP;
			}
#pragma warning restore 0169

			static IntPtr id_getGOP;
			public virtual unsafe int GOP {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']/method[@name='getGOP' and count(parameter)=0]"
				[Register ("getGOP", "()I", "GetGetGOPHandler")]
				get {
					if (id_getGOP == IntPtr.Zero)
						id_getGOP = JNIEnv.GetMethodID (class_ref, "getGOP", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGOP);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGOP", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getOffset;
#pragma warning disable 0169
			static Delegate GetGetOffsetHandler ()
			{
				if (cb_getOffset == null)
					cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
				return cb_getOffset;
			}

			static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Offset;
			}
#pragma warning restore 0169

			static IntPtr id_getOffset;
			public virtual unsafe long Offset {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']/method[@name='getOffset' and count(parameter)=0]"
				[Register ("getOffset", "()J", "GetGetOffsetHandler")]
				get {
					if (id_getOffset == IntPtr.Zero)
						id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()J"));
					} finally {
					}
				}
			}

			static Delegate cb_getSeq;
#pragma warning disable 0169
			static Delegate GetGetSeqHandler ()
			{
				if (cb_getSeq == null)
					cb_getSeq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeq);
				return cb_getSeq;
			}

			static IntPtr n_GetSeq (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Seq);
			}
#pragma warning restore 0169

			static IntPtr id_getSeq;
			public virtual unsafe global::Java.Nio.ByteBuffer Seq {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']/method[@name='getSeq' and count(parameter)=0]"
				[Register ("getSeq", "()Ljava/nio/ByteBuffer;", "GetGetSeqHandler")]
				get {
					if (id_getSeq == IntPtr.Zero)
						id_getSeq = JNIEnv.GetMethodID (class_ref, "getSeq", "()Ljava/nio/ByteBuffer;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeq), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeq", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTimecode;
#pragma warning disable 0169
			static Delegate GetGetTimecodeHandler ()
			{
				if (cb_getTimecode == null)
					cb_getTimecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimecode);
				return cb_getTimecode;
			}

			static int n_GetTimecode (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Timecode;
			}
#pragma warning restore 0169

			static IntPtr id_getTimecode;
			public virtual unsafe int Timecode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGPacket']/method[@name='getTimecode' and count(parameter)=0]"
				[Register ("getTimecode", "()I", "GetGetTimecodeHandler")]
				get {
					if (id_getTimecode == IntPtr.Zero)
						id_getTimecode = JNIEnv.GetMethodID (class_ref, "getTimecode", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTimecode);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimecode", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$MPEGTrack", DoNotGenerateAcw=true)]
		public partial class MPEGTrack : global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack, global::Java.Nio.Channels.IReadableByteChannel {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer$MPEGTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MPEGTrack); }
			}

			protected MPEGTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/constructor[@name='MPSDemuxer.MPEGTrack' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mps.MPSDemuxer'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.containers.mps.MPSDemuxer.PESPacket']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", "")]
			public unsafe MPEGTrack (global::Org.Jcodec.Containers.Mps.MPSDemuxer __self, int streamId, global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (streamId);
					__args [2] = new JValue (pkt);
					if (((object) this).GetType () != typeof (MPEGTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args);
				} finally {
				}
			}

			static Delegate cb_getES;
#pragma warning disable 0169
			static Delegate GetGetESHandler ()
			{
				if (cb_getES == null)
					cb_getES = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetES);
				return cb_getES;
			}

			static IntPtr n_GetES (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ES);
			}
#pragma warning restore 0169

			static IntPtr id_getES;
			public virtual unsafe global::Org.Jcodec.Codecs.Mpeg12.MPEGES ES {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/method[@name='getES' and count(parameter)=0]"
				[Register ("getES", "()Lorg/jcodec/codecs/mpeg12/MPEGES;", "GetGetESHandler")]
				get {
					if (id_getES == IntPtr.Zero)
						id_getES = JNIEnv.GetMethodID (class_ref, "getES", "()Lorg/jcodec/codecs/mpeg12/MPEGES;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGES> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getES), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPEGES> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getES", "()Lorg/jcodec/codecs/mpeg12/MPEGES;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isOpen;
#pragma warning disable 0169
			static Delegate GetIsOpenHandler ()
			{
				if (cb_isOpen == null)
					cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
				return cb_isOpen;
			}

			static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsOpen;
			}
#pragma warning restore 0169

			static IntPtr id_isOpen;
			public virtual unsafe bool IsOpen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/method[@name='isOpen' and count(parameter)=0]"
				[Register ("isOpen", "()Z", "GetIsOpenHandler")]
				get {
					if (id_isOpen == IntPtr.Zero)
						id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
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
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
				} finally {
				}
			}

			static Delegate cb_nextFrame_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetNextFrame_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_nextFrame_Ljava_nio_ByteBuffer_ == null)
					cb_nextFrame_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextFrame_Ljava_nio_ByteBuffer_);
				return cb_nextFrame_Ljava_nio_ByteBuffer_;
			}

			static IntPtr n_NextFrame_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NextFrame (buf));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_nextFrame_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;", "GetNextFrame_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet NextFrame (global::Java.Nio.ByteBuffer buf)
			{
				if (id_nextFrame_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_nextFrame_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (buf);

					global::Org.Jcodec.Common.Model.Packet __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_read_Ljava_nio_ByteBuffer_ == null)
					cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_Ljava_nio_ByteBuffer_);
				return cb_read_Ljava_nio_ByteBuffer_;
			}

			static int n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.MPEGTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer arg0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_arg0, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Read (arg0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.MPEGTrack']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("read", "(Ljava/nio/ByteBuffer;)I", "GetRead_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int Read (global::Java.Nio.ByteBuffer arg0)
			{
				if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (arg0);

					int __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)I"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$PESPacket", DoNotGenerateAcw=true)]
		public partial class PESPacket : global::Java.Lang.Object {


			static IntPtr data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='data']"
			[Register ("data")]
			public global::Java.Nio.ByteBuffer Data {
				get {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr dts_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='dts']"
			[Register ("dts")]
			public long Dts {
				get {
					if (dts_jfieldId == IntPtr.Zero)
						dts_jfieldId = JNIEnv.GetFieldID (class_ref, "dts", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, dts_jfieldId);
				}
				set {
					if (dts_jfieldId == IntPtr.Zero)
						dts_jfieldId = JNIEnv.GetFieldID (class_ref, "dts", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dts_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr length_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='length']"
			[Register ("length")]
			public int Length {
				get {
					if (length_jfieldId == IntPtr.Zero)
						length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, length_jfieldId);
				}
				set {
					if (length_jfieldId == IntPtr.Zero)
						length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, length_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr pos_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='pos']"
			[Register ("pos")]
			public long Pos {
				get {
					if (pos_jfieldId == IntPtr.Zero)
						pos_jfieldId = JNIEnv.GetFieldID (class_ref, "pos", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, pos_jfieldId);
				}
				set {
					if (pos_jfieldId == IntPtr.Zero)
						pos_jfieldId = JNIEnv.GetFieldID (class_ref, "pos", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pos_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr pts_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='pts']"
			[Register ("pts")]
			public long Pts {
				get {
					if (pts_jfieldId == IntPtr.Zero)
						pts_jfieldId = JNIEnv.GetFieldID (class_ref, "pts", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, pts_jfieldId);
				}
				set {
					if (pts_jfieldId == IntPtr.Zero)
						pts_jfieldId = JNIEnv.GetFieldID (class_ref, "pts", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pts_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr streamId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/field[@name='streamId']"
			[Register ("streamId")]
			public int StreamId {
				get {
					if (streamId_jfieldId == IntPtr.Zero)
						streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId);
				}
				set {
					if (streamId_jfieldId == IntPtr.Zero)
						streamId_jfieldId = JNIEnv.GetFieldID (class_ref, "streamId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, streamId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer$PESPacket", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PESPacket); }
			}

			protected PESPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_nio_ByteBuffer_JIIJJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PESPacket']/constructor[@name='MPSDemuxer.PESPacket' and count(parameter)=6 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
			[Register (".ctor", "(Ljava/nio/ByteBuffer;JIIJJ)V", "")]
			public unsafe PESPacket (global::Java.Nio.ByteBuffer data, long pts, int streamId, int length, long pos, long dts)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (data);
					__args [1] = new JValue (pts);
					__args [2] = new JValue (streamId);
					__args [3] = new JValue (length);
					__args [4] = new JValue (pos);
					__args [5] = new JValue (dts);
					if (((object) this).GetType () != typeof (PESPacket)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JIIJJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JIIJJ)V", __args);
						return;
					}

					if (id_ctor_Ljava_nio_ByteBuffer_JIIJJ == IntPtr.Zero)
						id_ctor_Ljava_nio_ByteBuffer_JIIJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JIIJJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JIIJJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JIIJJ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PlainTrack']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSDemuxer$PlainTrack", DoNotGenerateAcw=true)]
		public partial class PlainTrack : global::Org.Jcodec.Containers.Mps.MPSDemuxer.BaseTrack {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer$PlainTrack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlainTrack); }
			}

			protected PlainTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PlainTrack']/constructor[@name='MPSDemuxer.PlainTrack' and count(parameter)=3 and parameter[1][@type='org.jcodec.containers.mps.MPSDemuxer'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.containers.mps.MPSDemuxer.PESPacket']]"
			[Register (".ctor", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", "")]
			public unsafe PlainTrack (global::Org.Jcodec.Containers.Mps.MPSDemuxer __self, int streamId, global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket pkt)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (streamId);
					__args [2] = new JValue (pkt);
					if (((object) this).GetType () != typeof (PlainTrack)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mps/MPSDemuxer;ILorg/jcodec/containers/mps/MPSDemuxer$PESPacket;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mps_MPSDemuxer_ILorg_jcodec_containers_mps_MPSDemuxer_PESPacket_, __args);
				} finally {
				}
			}

			static Delegate cb_isOpen;
#pragma warning disable 0169
			static Delegate GetIsOpenHandler ()
			{
				if (cb_isOpen == null)
					cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
				return cb_isOpen;
			}

			static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsOpen;
			}
#pragma warning restore 0169

			static IntPtr id_isOpen;
			public virtual unsafe bool IsOpen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PlainTrack']/method[@name='isOpen' and count(parameter)=0]"
				[Register ("isOpen", "()Z", "GetIsOpenHandler")]
				get {
					if (id_isOpen == IntPtr.Zero)
						id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
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
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Close ();
			}
#pragma warning restore 0169

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PlainTrack']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "GetCloseHandler")]
			public virtual unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
				} finally {
				}
			}

			static Delegate cb_nextFrame_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetNextFrame_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_nextFrame_Ljava_nio_ByteBuffer_ == null)
					cb_nextFrame_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextFrame_Ljava_nio_ByteBuffer_);
				return cb_nextFrame_Ljava_nio_ByteBuffer_;
			}

			static IntPtr n_NextFrame_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf)
			{
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PlainTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NextFrame (buf));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_nextFrame_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer.PlainTrack']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;", "GetNextFrame_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.Packet NextFrame (global::Java.Nio.ByteBuffer buf)
			{
				if (id_nextFrame_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_nextFrame_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (buf);

					global::Org.Jcodec.Common.Model.Packet __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextFrame", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/common/model/Packet;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSDemuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPSDemuxer); }
		}

		protected MPSDemuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer);
		}
#pragma warning restore 0169

		static IntPtr id_getBuffer;
		public virtual unsafe global::Java.Nio.ByteBuffer Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/nio/ByteBuffer;", "GetGetBufferHandler")]
			get {
				if (id_getBuffer == IntPtr.Zero)
					id_getBuffer = JNIEnv.GetMethodID (class_ref, "getBuffer", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBuffer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuffer", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_findStreams;
#pragma warning disable 0169
		static Delegate GetFindStreamsHandler ()
		{
			if (cb_findStreams == null)
				cb_findStreams = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FindStreams);
			return cb_findStreams;
		}

		static void n_FindStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindStreams ();
		}
#pragma warning restore 0169

		static IntPtr id_findStreams;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='findStreams' and count(parameter)=0]"
		[Register ("findStreams", "()V", "GetFindStreamsHandler")]
		protected virtual unsafe void FindStreams ()
		{
			if (id_findStreams == IntPtr.Zero)
				id_findStreams = JNIEnv.GetMethodID (class_ref, "findStreams", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_findStreams);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findStreams", "()V"));
			} finally {
			}
		}

		static Delegate cb_nextPacket_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetNextPacket_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_nextPacket_Ljava_nio_ByteBuffer_ == null)
				cb_nextPacket_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NextPacket_Ljava_nio_ByteBuffer_);
			return cb_nextPacket_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_NextPacket_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native__out)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer @out = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NextPacket (@out));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nextPacket_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='nextPacket' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("nextPacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;", "GetNextPacket_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket NextPacket (global::Java.Nio.ByteBuffer @out)
		{
			if (id_nextPacket_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_nextPacket_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "nextPacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@out);

				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextPacket_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextPacket", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_probe_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='probe' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("probe", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int Probe (global::Java.Nio.ByteBuffer b)
		{
			if (id_probe_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_probe_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "probe", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_probe_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_putBack_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetPutBack_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_putBack_Ljava_nio_ByteBuffer_ == null)
				cb_putBack_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutBack_Ljava_nio_ByteBuffer_);
			return cb_putBack_Ljava_nio_ByteBuffer_;
		}

		static void n_PutBack_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer buffer = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buffer, JniHandleOwnership.DoNotTransfer);
			__this.PutBack (buffer);
		}
#pragma warning restore 0169

		static IntPtr id_putBack_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='putBack' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("putBack", "(Ljava/nio/ByteBuffer;)V", "GetPutBack_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void PutBack (global::Java.Nio.ByteBuffer buffer)
		{
			if (id_putBack_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_putBack_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "putBack", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (buffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBack_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBack", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekByte_J;
#pragma warning disable 0169
		static Delegate GetSeekByte_JHandler ()
		{
			if (cb_seekByte_J == null)
				cb_seekByte_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SeekByte_J);
			return cb_seekByte_J;
		}

		static void n_SeekByte_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			global::Org.Jcodec.Containers.Mps.MPSDemuxer __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekByte (offset);
		}
#pragma warning restore 0169

		static IntPtr id_seekByte_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSDemuxer']/method[@name='seekByte' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekByte", "(J)V", "GetSeekByte_JHandler")]
		public virtual unsafe void SeekByte (long offset)
		{
			if (id_seekByte_J == IntPtr.Zero)
				id_seekByte_J = JNIEnv.GetMethodID (class_ref, "seekByte", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekByte_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekByte", "(J)V"), __args);
			} finally {
			}
		}

	}
}
