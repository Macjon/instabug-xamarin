using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12.Bitstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/bitstream/GOPHeader", DoNotGenerateAcw=true)]
	public partial class GOPHeader : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Mpeg12.Bitstream.IMPEGHeader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/bitstream/GOPHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GOPHeader); }
		}

		protected GOPHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_common_model_TapeTimecode_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/constructor[@name='GOPHeader' and count(parameter)=3 and parameter[1][@type='org.jcodec.common.model.TapeTimecode'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/TapeTimecode;ZZ)V", "")]
		public unsafe GOPHeader (global::Org.Jcodec.Common.Model.TapeTimecode p0, bool p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (GOPHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/TapeTimecode;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/TapeTimecode;ZZ)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_TapeTimecode_ZZ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_TapeTimecode_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/TapeTimecode;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_TapeTimecode_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_TapeTimecode_ZZ, __args);
			} finally {
			}
		}

		static Delegate cb_isBrokenLink;
#pragma warning disable 0169
		static Delegate GetIsBrokenLinkHandler ()
		{
			if (cb_isBrokenLink == null)
				cb_isBrokenLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBrokenLink);
			return cb_isBrokenLink;
		}

		static bool n_IsBrokenLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBrokenLink;
		}
#pragma warning restore 0169

		static IntPtr id_isBrokenLink;
		public virtual unsafe bool IsBrokenLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/method[@name='isBrokenLink' and count(parameter)=0]"
			[Register ("isBrokenLink", "()Z", "GetIsBrokenLinkHandler")]
			get {
				if (id_isBrokenLink == IntPtr.Zero)
					id_isBrokenLink = JNIEnv.GetMethodID (class_ref, "isBrokenLink", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBrokenLink);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBrokenLink", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isClosedGop;
#pragma warning disable 0169
		static Delegate GetIsClosedGopHandler ()
		{
			if (cb_isClosedGop == null)
				cb_isClosedGop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosedGop);
			return cb_isClosedGop;
		}

		static bool n_IsClosedGop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosedGop;
		}
#pragma warning restore 0169

		static IntPtr id_isClosedGop;
		public virtual unsafe bool IsClosedGop {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/method[@name='isClosedGop' and count(parameter)=0]"
			[Register ("isClosedGop", "()Z", "GetIsClosedGopHandler")]
			get {
				if (id_isClosedGop == IntPtr.Zero)
					id_isClosedGop = JNIEnv.GetMethodID (class_ref, "isClosedGop", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosedGop);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosedGop", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimeCode;
#pragma warning disable 0169
		static Delegate GetGetTimeCodeHandler ()
		{
			if (cb_getTimeCode == null)
				cb_getTimeCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeCode);
			return cb_getTimeCode;
		}

		static IntPtr n_GetTimeCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeCode);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeCode;
		public virtual unsafe global::Org.Jcodec.Common.Model.TapeTimecode TimeCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/method[@name='getTimeCode' and count(parameter)=0]"
			[Register ("getTimeCode", "()Lorg/jcodec/common/model/TapeTimecode;", "GetGetTimeCodeHandler")]
			get {
				if (id_getTimeCode == IntPtr.Zero)
					id_getTimeCode = JNIEnv.GetMethodID (class_ref, "getTimeCode", "()Lorg/jcodec/common/model/TapeTimecode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeCode", "()Lorg/jcodec/common/model/TapeTimecode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/codecs/mpeg12/bitstream/GOPHeader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_write_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWrite_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_write_Ljava_nio_ByteBuffer_ == null)
				cb_write_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Ljava_nio_ByteBuffer_);
			return cb_write_Ljava_nio_ByteBuffer_;
		}

		static void n_Write_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.Bitstream.GOPHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0);
		}
#pragma warning restore 0169

		static IntPtr id_write_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12.bitstream']/class[@name='GOPHeader']/method[@name='write' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("write", "(Ljava/nio/ByteBuffer;)V", "GetWrite_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void Write (global::Java.Nio.ByteBuffer p0)
		{
			if (id_write_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_write_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "write", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Ljava_nio_ByteBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Ljava/nio/ByteBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
