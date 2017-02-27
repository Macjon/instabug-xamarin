using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/MKVStreamingMuxer", DoNotGenerateAcw=true)]
	public partial class MKVStreamingMuxer : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/MKVStreamingMuxer$HeaderSegment", DoNotGenerateAcw=true)]
		public partial class HeaderSegment : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/MKVStreamingMuxer$HeaderSegment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeaderSegment); }
			}

			protected HeaderSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']/constructor[@name='MKVStreamingMuxer.HeaderSegment' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.jcodec.containers.mkv.boxes.EbmlMaster&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe HeaderSegment (global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (HeaderSegment)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
						id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Nio.ByteBuffer Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDataLen;
#pragma warning disable 0169
			static Delegate GetGetDataLenHandler ()
			{
				if (cb_getDataLen == null)
					cb_getDataLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataLen);
				return cb_getDataLen;
			}

			static int n_GetDataLen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLen;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLen;
			public virtual unsafe int DataLen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']/method[@name='getDataLen' and count(parameter)=0]"
				[Register ("getDataLen", "()I", "GetGetDataLenHandler")]
				get {
					if (id_getDataLen == IntPtr.Zero)
						id_getDataLen = JNIEnv.GetMethodID (class_ref, "getDataLen", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataLen);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLen", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getNo;
#pragma warning disable 0169
			static Delegate GetGetNoHandler ()
			{
				if (cb_getNo == null)
					cb_getNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNo);
				return cb_getNo;
			}

			static int n_GetNo (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.No;
			}
#pragma warning restore 0169

			static IntPtr id_getNo;
			public virtual unsafe int No {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']/method[@name='getNo' and count(parameter)=0]"
				[Register ("getNo", "()I", "GetGetNoHandler")]
				get {
					if (id_getNo == IntPtr.Zero)
						id_getNo = JNIEnv.GetMethodID (class_ref, "getNo", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNo);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNo", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getPos;
#pragma warning disable 0169
			static Delegate GetGetPosHandler ()
			{
				if (cb_getPos == null)
					cb_getPos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPos);
				return cb_getPos;
			}

			static long n_GetPos (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.HeaderSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pos;
			}
#pragma warning restore 0169

			static IntPtr id_getPos;
			public virtual unsafe long Pos {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.HeaderSegment']/method[@name='getPos' and count(parameter)=0]"
				[Register ("getPos", "()J", "GetGetPosHandler")]
				get {
					if (id_getPos == IntPtr.Zero)
						id_getPos = JNIEnv.GetMethodID (class_ref, "getPos", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPos);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPos", "()J"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.WebmCluster']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/MKVStreamingMuxer$WebmCluster", DoNotGenerateAcw=true)]
		public partial class WebmCluster : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/MKVStreamingMuxer$WebmCluster", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WebmCluster); }
			}

			protected WebmCluster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Nio.ByteBuffer Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.WebmCluster']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDataLen;
#pragma warning disable 0169
			static Delegate GetGetDataLenHandler ()
			{
				if (cb_getDataLen == null)
					cb_getDataLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataLen);
				return cb_getDataLen;
			}

			static int n_GetDataLen (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DataLen;
			}
#pragma warning restore 0169

			static IntPtr id_getDataLen;
			public virtual unsafe int DataLen {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.WebmCluster']/method[@name='getDataLen' and count(parameter)=0]"
				[Register ("getDataLen", "()I", "GetGetDataLenHandler")]
				get {
					if (id_getDataLen == IntPtr.Zero)
						id_getDataLen = JNIEnv.GetMethodID (class_ref, "getDataLen", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDataLen);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLen", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getNo;
#pragma warning disable 0169
			static Delegate GetGetNoHandler ()
			{
				if (cb_getNo == null)
					cb_getNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNo);
				return cb_getNo;
			}

			static int n_GetNo (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.No;
			}
#pragma warning restore 0169

			static IntPtr id_getNo;
			public virtual unsafe int No {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.WebmCluster']/method[@name='getNo' and count(parameter)=0]"
				[Register ("getNo", "()I", "GetGetNoHandler")]
				get {
					if (id_getNo == IntPtr.Zero)
						id_getNo = JNIEnv.GetMethodID (class_ref, "getNo", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNo);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNo", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getPos;
#pragma warning disable 0169
			static Delegate GetGetPosHandler ()
			{
				if (cb_getPos == null)
					cb_getPos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPos);
				return cb_getPos;
			}

			static long n_GetPos (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVStreamingMuxer.WebmCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pos;
			}
#pragma warning restore 0169

			static IntPtr id_getPos;
			public virtual unsafe long Pos {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer.WebmCluster']/method[@name='getPos' and count(parameter)=0]"
				[Register ("getPos", "()J", "GetGetPosHandler")]
				get {
					if (id_getPos == IntPtr.Zero)
						id_getPos = JNIEnv.GetMethodID (class_ref, "getPos", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPos);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPos", "()J"));
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/MKVStreamingMuxer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MKVStreamingMuxer); }
		}

		protected MKVStreamingMuxer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='MKVStreamingMuxer']/constructor[@name='MKVStreamingMuxer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKVStreamingMuxer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MKVStreamingMuxer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

	}
}
