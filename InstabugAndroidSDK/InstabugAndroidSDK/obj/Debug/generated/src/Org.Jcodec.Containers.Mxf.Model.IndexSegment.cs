using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/IndexSegment", DoNotGenerateAcw=true)]
	public partial class IndexSegment : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/IndexSegment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IndexSegment); }
		}

		protected IndexSegment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/constructor[@name='IndexSegment' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe IndexSegment (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (IndexSegment)) {
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

		static Delegate cb_getBodySID;
#pragma warning disable 0169
		static Delegate GetGetBodySIDHandler ()
		{
			if (cb_getBodySID == null)
				cb_getBodySID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBodySID);
			return cb_getBodySID;
		}

		static int n_GetBodySID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BodySID;
		}
#pragma warning restore 0169

		static IntPtr id_getBodySID;
		public virtual unsafe int BodySID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getBodySID' and count(parameter)=0]"
			[Register ("getBodySID", "()I", "GetGetBodySIDHandler")]
			get {
				if (id_getBodySID == IntPtr.Zero)
					id_getBodySID = JNIEnv.GetMethodID (class_ref, "getBodySID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBodySID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodySID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaEntries;
#pragma warning disable 0169
		static Delegate GetGetDeltaEntriesHandler ()
		{
			if (cb_getDeltaEntries == null)
				cb_getDeltaEntries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeltaEntries);
			return cb_getDeltaEntries;
		}

		static IntPtr n_GetDeltaEntries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeltaEntries);
		}
#pragma warning restore 0169

		static IntPtr id_getDeltaEntries;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries DeltaEntries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getDeltaEntries' and count(parameter)=0]"
			[Register ("getDeltaEntries", "()Lorg/jcodec/containers/mxf/model/DeltaEntries;", "GetGetDeltaEntriesHandler")]
			get {
				if (id_getDeltaEntries == IntPtr.Zero)
					id_getDeltaEntries = JNIEnv.GetMethodID (class_ref, "getDeltaEntries", "()Lorg/jcodec/containers/mxf/model/DeltaEntries;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeltaEntries), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.DeltaEntries> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeltaEntries", "()Lorg/jcodec/containers/mxf/model/DeltaEntries;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEditUnitByteCount;
#pragma warning disable 0169
		static Delegate GetGetEditUnitByteCountHandler ()
		{
			if (cb_getEditUnitByteCount == null)
				cb_getEditUnitByteCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditUnitByteCount);
			return cb_getEditUnitByteCount;
		}

		static int n_GetEditUnitByteCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EditUnitByteCount;
		}
#pragma warning restore 0169

		static IntPtr id_getEditUnitByteCount;
		public virtual unsafe int EditUnitByteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getEditUnitByteCount' and count(parameter)=0]"
			[Register ("getEditUnitByteCount", "()I", "GetGetEditUnitByteCountHandler")]
			get {
				if (id_getEditUnitByteCount == IntPtr.Zero)
					id_getEditUnitByteCount = JNIEnv.GetMethodID (class_ref, "getEditUnitByteCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEditUnitByteCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditUnitByteCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIe;
#pragma warning disable 0169
		static Delegate GetGetIeHandler ()
		{
			if (cb_getIe == null)
				cb_getIe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIe);
			return cb_getIe;
		}

		static IntPtr n_GetIe (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ie);
		}
#pragma warning restore 0169

		static IntPtr id_getIe;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.IndexEntries Ie {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIe' and count(parameter)=0]"
			[Register ("getIe", "()Lorg/jcodec/containers/mxf/model/IndexEntries;", "GetGetIeHandler")]
			get {
				if (id_getIe == IntPtr.Zero)
					id_getIe = JNIEnv.GetMethodID (class_ref, "getIe", "()Lorg/jcodec/containers/mxf/model/IndexEntries;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIe), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIe", "()Lorg/jcodec/containers/mxf/model/IndexEntries;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIndexDuration;
#pragma warning disable 0169
		static Delegate GetGetIndexDurationHandler ()
		{
			if (cb_getIndexDuration == null)
				cb_getIndexDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIndexDuration);
			return cb_getIndexDuration;
		}

		static long n_GetIndexDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexDuration;
		public virtual unsafe long IndexDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIndexDuration' and count(parameter)=0]"
			[Register ("getIndexDuration", "()J", "GetGetIndexDurationHandler")]
			get {
				if (id_getIndexDuration == IntPtr.Zero)
					id_getIndexDuration = JNIEnv.GetMethodID (class_ref, "getIndexDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIndexDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexEditRateDen;
#pragma warning disable 0169
		static Delegate GetGetIndexEditRateDenHandler ()
		{
			if (cb_getIndexEditRateDen == null)
				cb_getIndexEditRateDen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexEditRateDen);
			return cb_getIndexEditRateDen;
		}

		static int n_GetIndexEditRateDen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexEditRateDen;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexEditRateDen;
		public virtual unsafe int IndexEditRateDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIndexEditRateDen' and count(parameter)=0]"
			[Register ("getIndexEditRateDen", "()I", "GetGetIndexEditRateDenHandler")]
			get {
				if (id_getIndexEditRateDen == IntPtr.Zero)
					id_getIndexEditRateDen = JNIEnv.GetMethodID (class_ref, "getIndexEditRateDen", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexEditRateDen);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexEditRateDen", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexEditRateNum;
#pragma warning disable 0169
		static Delegate GetGetIndexEditRateNumHandler ()
		{
			if (cb_getIndexEditRateNum == null)
				cb_getIndexEditRateNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexEditRateNum);
			return cb_getIndexEditRateNum;
		}

		static int n_GetIndexEditRateNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexEditRateNum;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexEditRateNum;
		public virtual unsafe int IndexEditRateNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIndexEditRateNum' and count(parameter)=0]"
			[Register ("getIndexEditRateNum", "()I", "GetGetIndexEditRateNumHandler")]
			get {
				if (id_getIndexEditRateNum == IntPtr.Zero)
					id_getIndexEditRateNum = JNIEnv.GetMethodID (class_ref, "getIndexEditRateNum", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexEditRateNum);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexEditRateNum", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexSID;
#pragma warning disable 0169
		static Delegate GetGetIndexSIDHandler ()
		{
			if (cb_getIndexSID == null)
				cb_getIndexSID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndexSID);
			return cb_getIndexSID;
		}

		static int n_GetIndexSID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexSID;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexSID;
		public virtual unsafe int IndexSID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIndexSID' and count(parameter)=0]"
			[Register ("getIndexSID", "()I", "GetGetIndexSIDHandler")]
			get {
				if (id_getIndexSID == IntPtr.Zero)
					id_getIndexSID = JNIEnv.GetMethodID (class_ref, "getIndexSID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexSID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexSID", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getIndexStartPosition;
#pragma warning disable 0169
		static Delegate GetGetIndexStartPositionHandler ()
		{
			if (cb_getIndexStartPosition == null)
				cb_getIndexStartPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetIndexStartPosition);
			return cb_getIndexStartPosition;
		}

		static long n_GetIndexStartPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndexStartPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getIndexStartPosition;
		public virtual unsafe long IndexStartPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getIndexStartPosition' and count(parameter)=0]"
			[Register ("getIndexStartPosition", "()J", "GetGetIndexStartPositionHandler")]
			get {
				if (id_getIndexStartPosition == IntPtr.Zero)
					id_getIndexStartPosition = JNIEnv.GetMethodID (class_ref, "getIndexStartPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getIndexStartPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIndexStartPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getInstanceUID;
#pragma warning disable 0169
		static Delegate GetGetInstanceUIDHandler ()
		{
			if (cb_getInstanceUID == null)
				cb_getInstanceUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInstanceUID);
			return cb_getInstanceUID;
		}

		static IntPtr n_GetInstanceUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InstanceUID);
		}
#pragma warning restore 0169

		static IntPtr id_getInstanceUID;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL InstanceUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getInstanceUID' and count(parameter)=0]"
			[Register ("getInstanceUID", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetInstanceUIDHandler")]
			get {
				if (id_getInstanceUID == IntPtr.Zero)
					id_getInstanceUID = JNIEnv.GetMethodID (class_ref, "getInstanceUID", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInstanceUID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInstanceUID", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPosTableCount;
#pragma warning disable 0169
		static Delegate GetGetPosTableCountHandler ()
		{
			if (cb_getPosTableCount == null)
				cb_getPosTableCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPosTableCount);
			return cb_getPosTableCount;
		}

		static int n_GetPosTableCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PosTableCount;
		}
#pragma warning restore 0169

		static IntPtr id_getPosTableCount;
		public virtual unsafe int PosTableCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getPosTableCount' and count(parameter)=0]"
			[Register ("getPosTableCount", "()I", "GetGetPosTableCountHandler")]
			get {
				if (id_getPosTableCount == IntPtr.Zero)
					id_getPosTableCount = JNIEnv.GetMethodID (class_ref, "getPosTableCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosTableCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosTableCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSliceCount;
#pragma warning disable 0169
		static Delegate GetGetSliceCountHandler ()
		{
			if (cb_getSliceCount == null)
				cb_getSliceCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSliceCount);
			return cb_getSliceCount;
		}

		static int n_GetSliceCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SliceCount;
		}
#pragma warning restore 0169

		static IntPtr id_getSliceCount;
		public virtual unsafe int SliceCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='getSliceCount' and count(parameter)=0]"
			[Register ("getSliceCount", "()I", "GetGetSliceCountHandler")]
			get {
				if (id_getSliceCount == IntPtr.Zero)
					id_getSliceCount = JNIEnv.GetMethodID (class_ref, "getSliceCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSliceCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSliceCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_read_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_util_Map_Handler ()
		{
			if (cb_read_Ljava_util_Map_ == null)
				cb_read_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_util_Map_);
			return cb_read_Ljava_util_Map_;
		}

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexSegment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexSegment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexSegment']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
		[Register ("read", "(Ljava/util/Map;)V", "GetRead_Ljava_util_Map_Handler")]
		protected override unsafe void Read (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer> p0)
		{
			if (id_read_Ljava_util_Map_ == IntPtr.Zero)
				id_read_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
