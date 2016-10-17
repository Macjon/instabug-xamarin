using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps.Psi {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/psi/PMTSection", DoNotGenerateAcw=true)]
	public partial class PMTSection : global::Org.Jcodec.Containers.Mps.Psi.PSISection {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/psi/PMTSection$PMTStream", DoNotGenerateAcw=true)]
		public partial class PMTStream : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/psi/PMTSection$PMTStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PMTStream); }
			}

			protected PMTStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IILjava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']/constructor[@name='PMTSection.PMTStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;org.jcodec.containers.mps.MPSUtils.MPEGMediaDescriptor&gt;']]"
			[Register (".ctor", "(IILjava/util/List;)V", "")]
			public unsafe PMTStream (int p0, int p1, global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor> p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor>.ToLocalJniHandle (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (PMTStream)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/util/List;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/util/List;)V", __args);
						return;
					}

					if (id_ctor_IILjava_util_List_ == IntPtr.Zero)
						id_ctor_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/util/List;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_util_List_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_getDesctiptors;
#pragma warning disable 0169
			static Delegate GetGetDesctiptorsHandler ()
			{
				if (cb_getDesctiptors == null)
					cb_getDesctiptors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDesctiptors);
				return cb_getDesctiptors;
			}

			static IntPtr n_GetDesctiptors (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor>.ToLocalJniHandle (__this.Desctiptors);
			}
#pragma warning restore 0169

			static IntPtr id_getDesctiptors;
			public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor> Desctiptors {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']/method[@name='getDesctiptors' and count(parameter)=0]"
				[Register ("getDesctiptors", "()Ljava/util/List;", "GetGetDesctiptorsHandler")]
				get {
					if (id_getDesctiptors == IntPtr.Zero)
						id_getDesctiptors = JNIEnv.GetMethodID (class_ref, "getDesctiptors", "()Ljava/util/List;");
					try {

						if (GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesctiptors), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDesctiptors", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPid;
#pragma warning disable 0169
			static Delegate GetGetPidHandler ()
			{
				if (cb_getPid == null)
					cb_getPid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPid);
				return cb_getPid;
			}

			static int n_GetPid (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pid;
			}
#pragma warning restore 0169

			static IntPtr id_getPid;
			public virtual unsafe int Pid {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']/method[@name='getPid' and count(parameter)=0]"
				[Register ("getPid", "()I", "GetGetPidHandler")]
				get {
					if (id_getPid == IntPtr.Zero)
						id_getPid = JNIEnv.GetMethodID (class_ref, "getPid", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPid);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPid", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getStreamType;
#pragma warning disable 0169
			static Delegate GetGetStreamTypeHandler ()
			{
				if (cb_getStreamType == null)
					cb_getStreamType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreamType);
				return cb_getStreamType;
			}

			static IntPtr n_GetStreamType (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.StreamType);
			}
#pragma warning restore 0169

			static IntPtr id_getStreamType;
			public virtual unsafe global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType StreamType {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']/method[@name='getStreamType' and count(parameter)=0]"
				[Register ("getStreamType", "()Lorg/jcodec/containers/mps/MTSUtils$StreamType;", "GetGetStreamTypeHandler")]
				get {
					if (id_getStreamType == IntPtr.Zero)
						id_getStreamType = JNIEnv.GetMethodID (class_ref, "getStreamType", "()Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreamType), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreamType", "()Lorg/jcodec/containers/mps/MTSUtils$StreamType;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStreamTypeTag;
#pragma warning disable 0169
			static Delegate GetGetStreamTypeTagHandler ()
			{
				if (cb_getStreamTypeTag == null)
					cb_getStreamTypeTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStreamTypeTag);
				return cb_getStreamTypeTag;
			}

			static int n_GetStreamTypeTag (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StreamTypeTag;
			}
#pragma warning restore 0169

			static IntPtr id_getStreamTypeTag;
			public virtual unsafe int StreamTypeTag {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.PMTStream']/method[@name='getStreamTypeTag' and count(parameter)=0]"
				[Register ("getStreamTypeTag", "()I", "GetGetStreamTypeTagHandler")]
				get {
					if (id_getStreamTypeTag == IntPtr.Zero)
						id_getStreamTypeTag = JNIEnv.GetMethodID (class_ref, "getStreamTypeTag", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStreamTypeTag);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreamTypeTag", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.Tag']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/psi/PMTSection$Tag", DoNotGenerateAcw=true)]
		public partial class Tag : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/psi/PMTSection$Tag", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Tag); }
			}

			protected Tag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_ILjava_nio_ByteBuffer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.Tag']/constructor[@name='PMTSection.Tag' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.ByteBuffer']]"
			[Register (".ctor", "(ILjava/nio/ByteBuffer;)V", "")]
			public unsafe Tag (int p0, global::Java.Nio.ByteBuffer p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Tag)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/nio/ByteBuffer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/nio/ByteBuffer;)V", __args);
						return;
					}

					if (id_ctor_ILjava_nio_ByteBuffer_ == IntPtr.Zero)
						id_ctor_ILjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/nio/ByteBuffer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_nio_ByteBuffer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_nio_ByteBuffer_, __args);
				} finally {
				}
			}

			static Delegate cb_getContent;
#pragma warning disable 0169
			static Delegate GetGetContentHandler ()
			{
				if (cb_getContent == null)
					cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
				return cb_getContent;
			}

			static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Content);
			}
#pragma warning restore 0169

			static IntPtr id_getContent;
			public virtual unsafe global::Java.Nio.ByteBuffer Content {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.Tag']/method[@name='getContent' and count(parameter)=0]"
				[Register ("getContent", "()Ljava/nio/ByteBuffer;", "GetGetContentHandler")]
				get {
					if (id_getContent == IntPtr.Zero)
						id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/nio/ByteBuffer;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTag;
#pragma warning disable 0169
			static Delegate GetGetTagHandler ()
			{
				if (cb_getTag == null)
					cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTag);
				return cb_getTag;
			}

			static int n_GetTag (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetTag ();
			}
#pragma warning restore 0169

			static IntPtr id_getTag;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection.Tag']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()I", "GetGetTagHandler")]
			public virtual unsafe int GetTag ()
			{
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTag);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()I"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/psi/PMTSection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PMTSection); }
		}

		protected PMTSection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_IarrayLorg_jcodec_containers_mps_psi_PMTSection_Tag_arrayLorg_jcodec_containers_mps_psi_PMTSection_PMTStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']/constructor[@name='PMTSection' and count(parameter)=4 and parameter[1][@type='org.jcodec.containers.mps.psi.PSISection'] and parameter[2][@type='int'] and parameter[3][@type='org.jcodec.containers.mps.psi.PMTSection.Tag[]'] and parameter[4][@type='org.jcodec.containers.mps.psi.PMTSection.PMTStream[]']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mps/psi/PSISection;I[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;)V", "")]
		public unsafe PMTSection (global::Org.Jcodec.Containers.Mps.Psi.PSISection p0, int p1, global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag[] p2, global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (PMTSection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mps/psi/PSISection;I[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mps/psi/PSISection;I[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_IarrayLorg_jcodec_containers_mps_psi_PMTSection_Tag_arrayLorg_jcodec_containers_mps_psi_PMTSection_PMTStream_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_IarrayLorg_jcodec_containers_mps_psi_PMTSection_Tag_arrayLorg_jcodec_containers_mps_psi_PMTSection_PMTStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mps/psi/PSISection;I[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_IarrayLorg_jcodec_containers_mps_psi_PMTSection_Tag_arrayLorg_jcodec_containers_mps_psi_PMTSection_PMTStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_IarrayLorg_jcodec_containers_mps_psi_PMTSection_Tag_arrayLorg_jcodec_containers_mps_psi_PMTSection_PMTStream_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getPcrPid;
#pragma warning disable 0169
		static Delegate GetGetPcrPidHandler ()
		{
			if (cb_getPcrPid == null)
				cb_getPcrPid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPcrPid);
			return cb_getPcrPid;
		}

		static int n_GetPcrPid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PMTSection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PcrPid;
		}
#pragma warning restore 0169

		static IntPtr id_getPcrPid;
		public virtual unsafe int PcrPid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']/method[@name='getPcrPid' and count(parameter)=0]"
			[Register ("getPcrPid", "()I", "GetGetPcrPidHandler")]
			get {
				if (id_getPcrPid == IntPtr.Zero)
					id_getPcrPid = JNIEnv.GetMethodID (class_ref, "getPcrPid", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPcrPid);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPcrPid", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStreams;
#pragma warning disable 0169
		static Delegate GetGetStreamsHandler ()
		{
			if (cb_getStreams == null)
				cb_getStreams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreams);
			return cb_getStreams;
		}

		static IntPtr n_GetStreams (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PMTSection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStreams ());
		}
#pragma warning restore 0169

		static IntPtr id_getStreams;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']/method[@name='getStreams' and count(parameter)=0]"
		[Register ("getStreams", "()[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;", "GetGetStreamsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[] GetStreams ()
		{
			if (id_getStreams == IntPtr.Zero)
				id_getStreams = JNIEnv.GetMethodID (class_ref, "getStreams", "()[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreams), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream));
				else
					return (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreams", "()[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream));
			} finally {
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PMTSection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTags ());
		}
#pragma warning restore 0169

		static IntPtr id_getTags;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']/method[@name='getTags' and count(parameter)=0]"
		[Register ("getTags", "()[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;", "GetGetTagsHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag[] GetTags ()
		{
			if (id_getTags == IntPtr.Zero)
				id_getTags = JNIEnv.GetMethodID (class_ref, "getTags", "()[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;");
			try {

				if (GetType () == ThresholdType)
					return (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTags), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag));
				else
					return (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTags", "()[Lorg/jcodec/containers/mps/psi/PMTSection$Tag;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.Tag));
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PMTSection']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PMTSection;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection Parse (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PMTSection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
