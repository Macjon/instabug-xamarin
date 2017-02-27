using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MXFPartitionPack", DoNotGenerateAcw=true)]
	public partial class MXFPartitionPack : global::Org.Jcodec.Containers.Mxf.Model.MXFMetadata {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/MXFPartitionPack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFPartitionPack); }
		}

		protected MXFPartitionPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/constructor[@name='MXFPartitionPack' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe MXFPartitionPack (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MXFPartitionPack)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
			} finally {
			}
		}

		static Delegate cb_getBodySid;
#pragma warning disable 0169
		static Delegate GetGetBodySidHandler ()
		{
			if (cb_getBodySid == null)
				cb_getBodySid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBodySid);
			return cb_getBodySid;
		}

		static int n_GetBodySid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BodySid;
		}
#pragma warning restore 0169

		static IntPtr id_getBodySid;
		public virtual unsafe int BodySid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getBodySid' and count(parameter)=0]"
			[Register ("getBodySid", "()I", "GetGetBodySidHandler")]
			get {
				if (id_getBodySid == IntPtr.Zero)
					id_getBodySid = JNIEnv.GetMethodID (class_ref, "getBodySid", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBodySid);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodySid", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFooterPartition;
#pragma warning disable 0169
		static Delegate GetGetFooterPartitionHandler ()
		{
			if (cb_getFooterPartition == null)
				cb_getFooterPartition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFooterPartition);
			return cb_getFooterPartition;
		}

		static long n_GetFooterPartition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FooterPartition;
		}
#pragma warning restore 0169

		static IntPtr id_getFooterPartition;
		public virtual unsafe long FooterPartition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getFooterPartition' and count(parameter)=0]"
			[Register ("getFooterPartition", "()J", "GetGetFooterPartitionHandler")]
			get {
				if (id_getFooterPartition == IntPtr.Zero)
					id_getFooterPartition = JNIEnv.GetMethodID (class_ref, "getFooterPartition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFooterPartition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFooterPartition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderByteCount;
#pragma warning disable 0169
		static Delegate GetGetHeaderByteCountHandler ()
		{
			if (cb_getHeaderByteCount == null)
				cb_getHeaderByteCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetHeaderByteCount);
			return cb_getHeaderByteCount;
		}

		static long n_GetHeaderByteCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderByteCount;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderByteCount;
		public virtual unsafe long HeaderByteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getHeaderByteCount' and count(parameter)=0]"
			[Register ("getHeaderByteCount", "()J", "GetGetHeaderByteCountHandler")]
			get {
				if (id_getHeaderByteCount == IntPtr.Zero)
					id_getHeaderByteCount = JNIEnv.GetMethodID (class_ref, "getHeaderByteCount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderByteCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderByteCount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexByteCount;
#pragma warning disable 0169
		static Delegate GetGetIndexByteCountHandler ()
		{
			if (cb_getIndexByteCount == null)
				cb_getIndexByteCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIndexByteCount);
			return cb_getIndexByteCount;
		}

		static long n_GetIndexByteCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexByteCount;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexByteCount;
		public virtual unsafe long IndexByteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getIndexByteCount' and count(parameter)=0]"
			[Register ("getIndexByteCount", "()J", "GetGetIndexByteCountHandler")]
			get {
				if (id_getIndexByteCount == IntPtr.Zero)
					id_getIndexByteCount = JNIEnv.GetMethodID (class_ref, "getIndexByteCount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIndexByteCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexByteCount", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexSid;
#pragma warning disable 0169
		static Delegate GetGetIndexSidHandler ()
		{
			if (cb_getIndexSid == null)
				cb_getIndexSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexSid);
			return cb_getIndexSid;
		}

		static int n_GetIndexSid (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexSid;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexSid;
		public virtual unsafe int IndexSid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getIndexSid' and count(parameter)=0]"
			[Register ("getIndexSid", "()I", "GetGetIndexSidHandler")]
			get {
				if (id_getIndexSid == IntPtr.Zero)
					id_getIndexSid = JNIEnv.GetMethodID (class_ref, "getIndexSid", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexSid);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexSid", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getKagSize;
#pragma warning disable 0169
		static Delegate GetGetKagSizeHandler ()
		{
			if (cb_getKagSize == null)
				cb_getKagSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetKagSize);
			return cb_getKagSize;
		}

		static int n_GetKagSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KagSize;
		}
#pragma warning restore 0169

		static IntPtr id_getKagSize;
		public virtual unsafe int KagSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getKagSize' and count(parameter)=0]"
			[Register ("getKagSize", "()I", "GetGetKagSizeHandler")]
			get {
				if (id_getKagSize == IntPtr.Zero)
					id_getKagSize = JNIEnv.GetMethodID (class_ref, "getKagSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getKagSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKagSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNbEssenceContainers;
#pragma warning disable 0169
		static Delegate GetGetNbEssenceContainersHandler ()
		{
			if (cb_getNbEssenceContainers == null)
				cb_getNbEssenceContainers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbEssenceContainers);
			return cb_getNbEssenceContainers;
		}

		static int n_GetNbEssenceContainers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbEssenceContainers;
		}
#pragma warning restore 0169

		static IntPtr id_getNbEssenceContainers;
		public virtual unsafe int NbEssenceContainers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getNbEssenceContainers' and count(parameter)=0]"
			[Register ("getNbEssenceContainers", "()I", "GetGetNbEssenceContainersHandler")]
			get {
				if (id_getNbEssenceContainers == IntPtr.Zero)
					id_getNbEssenceContainers = JNIEnv.GetMethodID (class_ref, "getNbEssenceContainers", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNbEssenceContainers);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNbEssenceContainers", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOp;
#pragma warning disable 0169
		static Delegate GetGetOpHandler ()
		{
			if (cb_getOp == null)
				cb_getOp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOp);
			return cb_getOp;
		}

		static IntPtr n_GetOp (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Op);
		}
#pragma warning restore 0169

		static IntPtr id_getOp;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL Op {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getOp' and count(parameter)=0]"
			[Register ("getOp", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetOpHandler")]
			get {
				if (id_getOp == IntPtr.Zero)
					id_getOp = JNIEnv.GetMethodID (class_ref, "getOp", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOp", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPrevPartition;
#pragma warning disable 0169
		static Delegate GetGetPrevPartitionHandler ()
		{
			if (cb_getPrevPartition == null)
				cb_getPrevPartition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPrevPartition);
			return cb_getPrevPartition;
		}

		static long n_GetPrevPartition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrevPartition;
		}
#pragma warning restore 0169

		static IntPtr id_getPrevPartition;
		public virtual unsafe long PrevPartition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getPrevPartition' and count(parameter)=0]"
			[Register ("getPrevPartition", "()J", "GetGetPrevPartitionHandler")]
			get {
				if (id_getPrevPartition == IntPtr.Zero)
					id_getPrevPartition = JNIEnv.GetMethodID (class_ref, "getPrevPartition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPrevPartition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrevPartition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getThisPartition;
#pragma warning disable 0169
		static Delegate GetGetThisPartitionHandler ()
		{
			if (cb_getThisPartition == null)
				cb_getThisPartition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetThisPartition);
			return cb_getThisPartition;
		}

		static long n_GetThisPartition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThisPartition;
		}
#pragma warning restore 0169

		static IntPtr id_getThisPartition;
		public virtual unsafe long ThisPartition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='getThisPartition' and count(parameter)=0]"
			[Register ("getThisPartition", "()J", "GetGetThisPartitionHandler")]
			get {
				if (id_getThisPartition == IntPtr.Zero)
					id_getThisPartition = JNIEnv.GetMethodID (class_ref, "getThisPartition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getThisPartition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThisPartition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_read_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_read_Ljava_nio_ByteBuffer_ == null)
				cb_read_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_nio_ByteBuffer_);
			return cb_read_Ljava_nio_ByteBuffer_;
		}

		static void n_Read_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartitionPack']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)V", "GetRead_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe void Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
