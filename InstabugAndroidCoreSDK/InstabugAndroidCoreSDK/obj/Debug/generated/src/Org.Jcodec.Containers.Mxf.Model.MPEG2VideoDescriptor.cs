using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MPEG2VideoDescriptor", DoNotGenerateAcw=true)]
	public partial class MPEG2VideoDescriptor : global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/MPEG2VideoDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPEG2VideoDescriptor); }
		}

		protected MPEG2VideoDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/constructor[@name='MPEG2VideoDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe MPEG2VideoDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (MPEG2VideoDescriptor)) {
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

		static Delegate cb_getBitRate;
#pragma warning disable 0169
		static Delegate GetGetBitRateHandler ()
		{
			if (cb_getBitRate == null)
				cb_getBitRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBitRate);
			return cb_getBitRate;
		}

		static int n_GetBitRate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitRate;
		}
#pragma warning restore 0169

		static IntPtr id_getBitRate;
		public virtual unsafe int BitRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getBitRate' and count(parameter)=0]"
			[Register ("getBitRate", "()I", "GetGetBitRateHandler")]
			get {
				if (id_getBitRate == IntPtr.Zero)
					id_getBitRate = JNIEnv.GetMethodID (class_ref, "getBitRate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBitRate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitRate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getClosedGOP;
#pragma warning disable 0169
		static Delegate GetGetClosedGOPHandler ()
		{
			if (cb_getClosedGOP == null)
				cb_getClosedGOP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetClosedGOP);
			return cb_getClosedGOP;
		}

		static sbyte n_GetClosedGOP (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClosedGOP;
		}
#pragma warning restore 0169

		static IntPtr id_getClosedGOP;
		public virtual unsafe sbyte ClosedGOP {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getClosedGOP' and count(parameter)=0]"
			[Register ("getClosedGOP", "()B", "GetGetClosedGOPHandler")]
			get {
				if (id_getClosedGOP == IntPtr.Zero)
					id_getClosedGOP = JNIEnv.GetMethodID (class_ref, "getClosedGOP", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getClosedGOP);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClosedGOP", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getCodedContentType;
#pragma warning disable 0169
		static Delegate GetGetCodedContentTypeHandler ()
		{
			if (cb_getCodedContentType == null)
				cb_getCodedContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetCodedContentType);
			return cb_getCodedContentType;
		}

		static sbyte n_GetCodedContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodedContentType;
		}
#pragma warning restore 0169

		static IntPtr id_getCodedContentType;
		public virtual unsafe sbyte CodedContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getCodedContentType' and count(parameter)=0]"
			[Register ("getCodedContentType", "()B", "GetGetCodedContentTypeHandler")]
			get {
				if (id_getCodedContentType == IntPtr.Zero)
					id_getCodedContentType = JNIEnv.GetMethodID (class_ref, "getCodedContentType", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getCodedContentType);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodedContentType", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getConstantBFrames;
#pragma warning disable 0169
		static Delegate GetGetConstantBFramesHandler ()
		{
			if (cb_getConstantBFrames == null)
				cb_getConstantBFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetConstantBFrames);
			return cb_getConstantBFrames;
		}

		static sbyte n_GetConstantBFrames (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConstantBFrames;
		}
#pragma warning restore 0169

		static IntPtr id_getConstantBFrames;
		public virtual unsafe sbyte ConstantBFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getConstantBFrames' and count(parameter)=0]"
			[Register ("getConstantBFrames", "()B", "GetGetConstantBFramesHandler")]
			get {
				if (id_getConstantBFrames == IntPtr.Zero)
					id_getConstantBFrames = JNIEnv.GetMethodID (class_ref, "getConstantBFrames", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getConstantBFrames);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConstantBFrames", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getIdenticalGOP;
#pragma warning disable 0169
		static Delegate GetGetIdenticalGOPHandler ()
		{
			if (cb_getIdenticalGOP == null)
				cb_getIdenticalGOP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetIdenticalGOP);
			return cb_getIdenticalGOP;
		}

		static sbyte n_GetIdenticalGOP (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdenticalGOP;
		}
#pragma warning restore 0169

		static IntPtr id_getIdenticalGOP;
		public virtual unsafe sbyte IdenticalGOP {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getIdenticalGOP' and count(parameter)=0]"
			[Register ("getIdenticalGOP", "()B", "GetGetIdenticalGOPHandler")]
			get {
				if (id_getIdenticalGOP == IntPtr.Zero)
					id_getIdenticalGOP = JNIEnv.GetMethodID (class_ref, "getIdenticalGOP", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getIdenticalGOP);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdenticalGOP", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getLowDelay;
#pragma warning disable 0169
		static Delegate GetGetLowDelayHandler ()
		{
			if (cb_getLowDelay == null)
				cb_getLowDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetLowDelay);
			return cb_getLowDelay;
		}

		static sbyte n_GetLowDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getLowDelay;
		public virtual unsafe sbyte LowDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getLowDelay' and count(parameter)=0]"
			[Register ("getLowDelay", "()B", "GetGetLowDelayHandler")]
			get {
				if (id_getLowDelay == IntPtr.Zero)
					id_getLowDelay = JNIEnv.GetMethodID (class_ref, "getLowDelay", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getLowDelay);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLowDelay", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxGOP;
#pragma warning disable 0169
		static Delegate GetGetMaxGOPHandler ()
		{
			if (cb_getMaxGOP == null)
				cb_getMaxGOP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetMaxGOP);
			return cb_getMaxGOP;
		}

		static short n_GetMaxGOP (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxGOP;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxGOP;
		public virtual unsafe short MaxGOP {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getMaxGOP' and count(parameter)=0]"
			[Register ("getMaxGOP", "()S", "GetGetMaxGOPHandler")]
			get {
				if (id_getMaxGOP == IntPtr.Zero)
					id_getMaxGOP = JNIEnv.GetMethodID (class_ref, "getMaxGOP", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getMaxGOP);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxGOP", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getProfileAndLevel;
#pragma warning disable 0169
		static Delegate GetGetProfileAndLevelHandler ()
		{
			if (cb_getProfileAndLevel == null)
				cb_getProfileAndLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetProfileAndLevel);
			return cb_getProfileAndLevel;
		}

		static sbyte n_GetProfileAndLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProfileAndLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getProfileAndLevel;
		public virtual unsafe sbyte ProfileAndLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getProfileAndLevel' and count(parameter)=0]"
			[Register ("getProfileAndLevel", "()B", "GetGetProfileAndLevelHandler")]
			get {
				if (id_getProfileAndLevel == IntPtr.Zero)
					id_getProfileAndLevel = JNIEnv.GetMethodID (class_ref, "getProfileAndLevel", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getProfileAndLevel);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfileAndLevel", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getSingleSequence;
#pragma warning disable 0169
		static Delegate GetGetSingleSequenceHandler ()
		{
			if (cb_getSingleSequence == null)
				cb_getSingleSequence = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSingleSequence);
			return cb_getSingleSequence;
		}

		static sbyte n_GetSingleSequence (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SingleSequence;
		}
#pragma warning restore 0169

		static IntPtr id_getSingleSequence;
		public virtual unsafe sbyte SingleSequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getSingleSequence' and count(parameter)=0]"
			[Register ("getSingleSequence", "()B", "GetGetSingleSequenceHandler")]
			get {
				if (id_getSingleSequence == IntPtr.Zero)
					id_getSingleSequence = JNIEnv.GetMethodID (class_ref, "getSingleSequence", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getSingleSequence);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSingleSequence", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getbPictureCount;
#pragma warning disable 0169
		static Delegate GetGetbPictureCountHandler ()
		{
			if (cb_getbPictureCount == null)
				cb_getbPictureCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetbPictureCount);
			return cb_getbPictureCount;
		}

		static short n_GetbPictureCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MPEG2VideoDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetbPictureCount ();
		}
#pragma warning restore 0169

		static IntPtr id_getbPictureCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MPEG2VideoDescriptor']/method[@name='getbPictureCount' and count(parameter)=0]"
		[Register ("getbPictureCount", "()S", "GetGetbPictureCountHandler")]
		public virtual unsafe short GetbPictureCount ()
		{
			if (id_getbPictureCount == IntPtr.Zero)
				id_getbPictureCount = JNIEnv.GetMethodID (class_ref, "getbPictureCount", "()S");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getbPictureCount);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getbPictureCount", "()S"));
			} finally {
			}
		}

	}
}
