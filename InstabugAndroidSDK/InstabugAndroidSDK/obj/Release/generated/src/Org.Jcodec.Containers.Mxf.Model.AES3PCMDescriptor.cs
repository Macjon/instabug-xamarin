using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/AES3PCMDescriptor", DoNotGenerateAcw=true)]
	public partial class AES3PCMDescriptor : global::Org.Jcodec.Containers.Mxf.Model.WaveAudioDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/AES3PCMDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AES3PCMDescriptor); }
		}

		protected AES3PCMDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/constructor[@name='AES3PCMDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe AES3PCMDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AES3PCMDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
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

		static Delegate cb_getAuxBitsMode;
#pragma warning disable 0169
		static Delegate GetGetAuxBitsModeHandler ()
		{
			if (cb_getAuxBitsMode == null)
				cb_getAuxBitsMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAuxBitsMode);
			return cb_getAuxBitsMode;
		}

		static sbyte n_GetAuxBitsMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AuxBitsMode;
		}
#pragma warning restore 0169

		static IntPtr id_getAuxBitsMode;
		public virtual unsafe sbyte AuxBitsMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getAuxBitsMode' and count(parameter)=0]"
			[Register ("getAuxBitsMode", "()B", "GetGetAuxBitsModeHandler")]
			get {
				if (id_getAuxBitsMode == IntPtr.Zero)
					id_getAuxBitsMode = JNIEnv.GetMethodID (class_ref, "getAuxBitsMode", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAuxBitsMode);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuxBitsMode", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getBlockStartOffset;
#pragma warning disable 0169
		static Delegate GetGetBlockStartOffsetHandler ()
		{
			if (cb_getBlockStartOffset == null)
				cb_getBlockStartOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetBlockStartOffset);
			return cb_getBlockStartOffset;
		}

		static short n_GetBlockStartOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockStartOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockStartOffset;
		public virtual unsafe short BlockStartOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getBlockStartOffset' and count(parameter)=0]"
			[Register ("getBlockStartOffset", "()S", "GetGetBlockStartOffsetHandler")]
			get {
				if (id_getBlockStartOffset == IntPtr.Zero)
					id_getBlockStartOffset = JNIEnv.GetMethodID (class_ref, "getBlockStartOffset", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getBlockStartOffset);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockStartOffset", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelStatusMode;
#pragma warning disable 0169
		static Delegate GetGetChannelStatusModeHandler ()
		{
			if (cb_getChannelStatusMode == null)
				cb_getChannelStatusMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelStatusMode);
			return cb_getChannelStatusMode;
		}

		static IntPtr n_GetChannelStatusMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChannelStatusMode);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelStatusMode;
		public virtual unsafe global::Java.Nio.ByteBuffer ChannelStatusMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getChannelStatusMode' and count(parameter)=0]"
			[Register ("getChannelStatusMode", "()Ljava/nio/ByteBuffer;", "GetGetChannelStatusModeHandler")]
			get {
				if (id_getChannelStatusMode == IntPtr.Zero)
					id_getChannelStatusMode = JNIEnv.GetMethodID (class_ref, "getChannelStatusMode", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelStatusMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelStatusMode", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEmphasis;
#pragma warning disable 0169
		static Delegate GetGetEmphasisHandler ()
		{
			if (cb_getEmphasis == null)
				cb_getEmphasis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetEmphasis);
			return cb_getEmphasis;
		}

		static sbyte n_GetEmphasis (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Emphasis;
		}
#pragma warning restore 0169

		static IntPtr id_getEmphasis;
		public virtual unsafe sbyte Emphasis {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getEmphasis' and count(parameter)=0]"
			[Register ("getEmphasis", "()B", "GetGetEmphasisHandler")]
			get {
				if (id_getEmphasis == IntPtr.Zero)
					id_getEmphasis = JNIEnv.GetMethodID (class_ref, "getEmphasis", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getEmphasis);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmphasis", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getFixedChannelStatusData;
#pragma warning disable 0169
		static Delegate GetGetFixedChannelStatusDataHandler ()
		{
			if (cb_getFixedChannelStatusData == null)
				cb_getFixedChannelStatusData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedChannelStatusData);
			return cb_getFixedChannelStatusData;
		}

		static IntPtr n_GetFixedChannelStatusData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedChannelStatusData);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedChannelStatusData;
		public virtual unsafe global::Java.Nio.ByteBuffer FixedChannelStatusData {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getFixedChannelStatusData' and count(parameter)=0]"
			[Register ("getFixedChannelStatusData", "()Ljava/nio/ByteBuffer;", "GetGetFixedChannelStatusDataHandler")]
			get {
				if (id_getFixedChannelStatusData == IntPtr.Zero)
					id_getFixedChannelStatusData = JNIEnv.GetMethodID (class_ref, "getFixedChannelStatusData", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFixedChannelStatusData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedChannelStatusData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFixedUserData;
#pragma warning disable 0169
		static Delegate GetGetFixedUserDataHandler ()
		{
			if (cb_getFixedUserData == null)
				cb_getFixedUserData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFixedUserData);
			return cb_getFixedUserData;
		}

		static IntPtr n_GetFixedUserData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FixedUserData);
		}
#pragma warning restore 0169

		static IntPtr id_getFixedUserData;
		public virtual unsafe global::Java.Nio.ByteBuffer FixedUserData {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getFixedUserData' and count(parameter)=0]"
			[Register ("getFixedUserData", "()Ljava/nio/ByteBuffer;", "GetGetFixedUserDataHandler")]
			get {
				if (id_getFixedUserData == IntPtr.Zero)
					id_getFixedUserData = JNIEnv.GetMethodID (class_ref, "getFixedUserData", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFixedUserData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFixedUserData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserDataMode;
#pragma warning disable 0169
		static Delegate GetGetUserDataModeHandler ()
		{
			if (cb_getUserDataMode == null)
				cb_getUserDataMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserDataMode);
			return cb_getUserDataMode;
		}

		static IntPtr n_GetUserDataMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.AES3PCMDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserDataMode);
		}
#pragma warning restore 0169

		static IntPtr id_getUserDataMode;
		public virtual unsafe global::Java.Nio.ByteBuffer UserDataMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='AES3PCMDescriptor']/method[@name='getUserDataMode' and count(parameter)=0]"
			[Register ("getUserDataMode", "()Ljava/nio/ByteBuffer;", "GetGetUserDataModeHandler")]
			get {
				if (id_getUserDataMode == IntPtr.Zero)
					id_getUserDataMode = JNIEnv.GetMethodID (class_ref, "getUserDataMode", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDataMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDataMode", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
