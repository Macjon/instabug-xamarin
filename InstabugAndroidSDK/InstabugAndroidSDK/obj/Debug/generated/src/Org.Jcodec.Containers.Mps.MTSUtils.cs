using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSUtils", DoNotGenerateAcw=true)]
	public partial class MTSUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.PMTExtractor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSUtils$PMTExtractor", DoNotGenerateAcw=true)]
		public partial class PMTExtractor : global::Org.Jcodec.Containers.Mps.MTSUtils.TSReader {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSUtils$PMTExtractor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PMTExtractor); }
			}

			protected PMTExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getPmt;
#pragma warning disable 0169
			static Delegate GetGetPmtHandler ()
			{
				if (cb_getPmt == null)
					cb_getPmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPmt);
				return cb_getPmt;
			}

			static IntPtr n_GetPmt (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MTSUtils.PMTExtractor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.PMTExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Pmt);
			}
#pragma warning restore 0169

			static IntPtr id_getPmt;
			public virtual unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection Pmt {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.PMTExtractor']/method[@name='getPmt' and count(parameter)=0]"
				[Register ("getPmt", "()Lorg/jcodec/containers/mps/psi/PMTSection;", "GetGetPmtHandler")]
				get {
					if (id_getPmt == IntPtr.Zero)
						id_getPmt = JNIEnv.GetMethodID (class_ref, "getPmt", "()Lorg/jcodec/containers/mps/psi/PMTSection;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPmt), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPmt", "()Lorg/jcodec/containers/mps/psi/PMTSection;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_onPkt_IZLjava_nio_ByteBuffer_J;
#pragma warning disable 0169
			static Delegate GetOnPkt_IZLjava_nio_ByteBuffer_JHandler ()
			{
				if (cb_onPkt_IZLjava_nio_ByteBuffer_J == null)
					cb_onPkt_IZLjava_nio_ByteBuffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr, long, bool>) n_OnPkt_IZLjava_nio_ByteBuffer_J);
				return cb_onPkt_IZLjava_nio_ByteBuffer_J;
			}

			static bool n_OnPkt_IZLjava_nio_ByteBuffer_J (IntPtr jnienv, IntPtr native__this, int p0, bool p1, IntPtr native_p2, long p3)
			{
				global::Org.Jcodec.Containers.Mps.MTSUtils.PMTExtractor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.PMTExtractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPkt (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPkt_IZLjava_nio_ByteBuffer_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.PMTExtractor']/method[@name='onPkt' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='long']]"
			[Register ("onPkt", "(IZLjava/nio/ByteBuffer;J)Z", "GetOnPkt_IZLjava_nio_ByteBuffer_JHandler")]
			protected override unsafe bool OnPkt (int p0, bool p1, global::Java.Nio.ByteBuffer p2, long p3)
			{
				if (id_onPkt_IZLjava_nio_ByteBuffer_J == IntPtr.Zero)
					id_onPkt_IZLjava_nio_ByteBuffer_J = JNIEnv.GetMethodID (class_ref, "onPkt", "(IZLjava/nio/ByteBuffer;J)Z");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPkt_IZLjava_nio_ByteBuffer_J, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPkt", "(IZLjava/nio/ByteBuffer;J)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSUtils$StreamType", DoNotGenerateAcw=true)]
		public sealed partial class StreamType : global::Java.Lang.Enum {


			static IntPtr ATM_SYNC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='ATM_SYNC']"
			[Register ("ATM_SYNC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AtmSync {
				get {
					if (ATM_SYNC_jfieldId == IntPtr.Zero)
						ATM_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATM_SYNC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATM_SYNC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_AAC_ADTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_AAC_ADTS']"
			[Register ("AUDIO_AAC_ADTS")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioAacAdts {
				get {
					if (AUDIO_AAC_ADTS_jfieldId == IntPtr.Zero)
						AUDIO_AAC_ADTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_AAC_ADTS", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_AAC_ADTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_AAC_LATM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_AAC_LATM']"
			[Register ("AUDIO_AAC_LATM")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioAacLatm {
				get {
					if (AUDIO_AAC_LATM_jfieldId == IntPtr.Zero)
						AUDIO_AAC_LATM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_AAC_LATM", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_AAC_LATM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_AAC_RAW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_AAC_RAW']"
			[Register ("AUDIO_AAC_RAW")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioAacRaw {
				get {
					if (AUDIO_AAC_RAW_jfieldId == IntPtr.Zero)
						AUDIO_AAC_RAW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_AAC_RAW", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_AAC_RAW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_AC3_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_AC3']"
			[Register ("AUDIO_AC3")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioAc3 {
				get {
					if (AUDIO_AC3_jfieldId == IntPtr.Zero)
						AUDIO_AC3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_AC3", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_AC3_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_DTS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_DTS']"
			[Register ("AUDIO_DTS")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioDts {
				get {
					if (AUDIO_DTS_jfieldId == IntPtr.Zero)
						AUDIO_DTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_DTS", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_DTS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_MPEG1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_MPEG1']"
			[Register ("AUDIO_MPEG1")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioMpeg1 {
				get {
					if (AUDIO_MPEG1_jfieldId == IntPtr.Zero)
						AUDIO_MPEG1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_MPEG1", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_MPEG1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_MPEG2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUDIO_MPEG2']"
			[Register ("AUDIO_MPEG2")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType AudioMpeg2 {
				get {
					if (AUDIO_MPEG2_jfieldId == IntPtr.Zero)
						AUDIO_MPEG2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_MPEG2", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_MPEG2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUX_3D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='AUX_3D']"
			[Register ("AUX_3D")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType Aux3d {
				get {
					if (AUX_3D_jfieldId == IntPtr.Zero)
						AUX_3D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUX_3D", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUX_3D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC']"
			[Register ("DSM_CC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCc {
				get {
					if (DSM_CC_jfieldId == IntPtr.Zero)
						DSM_CC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_A_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_A']"
			[Register ("DSM_CC_A")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcA {
				get {
					if (DSM_CC_A_jfieldId == IntPtr.Zero)
						DSM_CC_A_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_A", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_A_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_B_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_B']"
			[Register ("DSM_CC_B")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcB {
				get {
					if (DSM_CC_B_jfieldId == IntPtr.Zero)
						DSM_CC_B_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_B", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_B_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_C_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_C']"
			[Register ("DSM_CC_C")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcC {
				get {
					if (DSM_CC_C_jfieldId == IntPtr.Zero)
						DSM_CC_C_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_C", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_C_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_D']"
			[Register ("DSM_CC_D")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcD {
				get {
					if (DSM_CC_D_jfieldId == IntPtr.Zero)
						DSM_CC_D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_D", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_DATA_CAROUSEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_DATA_CAROUSEL']"
			[Register ("DSM_CC_DATA_CAROUSEL")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcDataCarousel {
				get {
					if (DSM_CC_DATA_CAROUSEL_jfieldId == IntPtr.Zero)
						DSM_CC_DATA_CAROUSEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_DATA_CAROUSEL", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_DATA_CAROUSEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_OBJ_CAROUSEL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_OBJ_CAROUSEL']"
			[Register ("DSM_CC_OBJ_CAROUSEL")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcObjCarousel {
				get {
					if (DSM_CC_OBJ_CAROUSEL_jfieldId == IntPtr.Zero)
						DSM_CC_OBJ_CAROUSEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_OBJ_CAROUSEL", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_OBJ_CAROUSEL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_SDP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_SDP']"
			[Register ("DSM_CC_SDP")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcSdp {
				get {
					if (DSM_CC_SDP_jfieldId == IntPtr.Zero)
						DSM_CC_SDP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_SDP", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_SDP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DSM_CC_SDP1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='DSM_CC_SDP1']"
			[Register ("DSM_CC_SDP1")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType DsmCcSdp1 {
				get {
					if (DSM_CC_SDP1_jfieldId == IntPtr.Zero)
						DSM_CC_SDP1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DSM_CC_SDP1", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DSM_CC_SDP1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLEXMUX_PES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='FLEXMUX_PES']"
			[Register ("FLEXMUX_PES")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType FlexmuxPes {
				get {
					if (FLEXMUX_PES_jfieldId == IntPtr.Zero)
						FLEXMUX_PES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLEXMUX_PES", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLEXMUX_PES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLEXMUX_SEC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='FLEXMUX_SEC']"
			[Register ("FLEXMUX_SEC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType FlexmuxSec {
				get {
					if (FLEXMUX_SEC_jfieldId == IntPtr.Zero)
						FLEXMUX_SEC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLEXMUX_SEC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLEXMUX_SEC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IPMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='IPMP']"
			[Register ("IPMP")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType Ipmp {
				get {
					if (IPMP_jfieldId == IntPtr.Zero)
						IPMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IPMP", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IPMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IPMP_STREAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='IPMP_STREAM']"
			[Register ("IPMP_STREAM")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType IpmpStream {
				get {
					if (IPMP_STREAM_jfieldId == IntPtr.Zero)
						IPMP_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IPMP_STREAM", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IPMP_STREAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr META_PES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='META_PES']"
			[Register ("META_PES")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType MetaPes {
				get {
					if (META_PES_jfieldId == IntPtr.Zero)
						META_PES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "META_PES", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, META_PES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr META_SEC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='META_SEC']"
			[Register ("META_SEC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType MetaSec {
				get {
					if (META_SEC_jfieldId == IntPtr.Zero)
						META_SEC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "META_SEC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, META_SEC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MHEG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='MHEG']"
			[Register ("MHEG")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType Mheg {
				get {
					if (MHEG_jfieldId == IntPtr.Zero)
						MHEG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MHEG", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MHEG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MPEG_AUX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='MPEG_AUX']"
			[Register ("MPEG_AUX")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType MpegAux {
				get {
					if (MPEG_AUX_jfieldId == IntPtr.Zero)
						MPEG_AUX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG_AUX", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG_AUX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRIVATE_DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='PRIVATE_DATA']"
			[Register ("PRIVATE_DATA")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType PrivateData {
				get {
					if (PRIVATE_DATA_jfieldId == IntPtr.Zero)
						PRIVATE_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE_DATA", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRIVATE_SECTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='PRIVATE_SECTION']"
			[Register ("PRIVATE_SECTION")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType PrivateSection {
				get {
					if (PRIVATE_SECTION_jfieldId == IntPtr.Zero)
						PRIVATE_SECTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE_SECTION", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_SECTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESERVED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='RESERVED']"
			[Register ("RESERVED")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType Reserved {
				get {
					if (RESERVED_jfieldId == IntPtr.Zero)
						RESERVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESERVED", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESERVED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='SUBS']"
			[Register ("SUBS")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType Subs {
				get {
					if (SUBS_jfieldId == IntPtr.Zero)
						SUBS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBS", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_AVC_MVC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_AVC_MVC']"
			[Register ("VIDEO_AVC_MVC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoAvcMvc {
				get {
					if (VIDEO_AVC_MVC_jfieldId == IntPtr.Zero)
						VIDEO_AVC_MVC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_AVC_MVC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_AVC_MVC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_AVC_SVC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_AVC_SVC']"
			[Register ("VIDEO_AVC_SVC")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoAvcSvc {
				get {
					if (VIDEO_AVC_SVC_jfieldId == IntPtr.Zero)
						VIDEO_AVC_SVC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_AVC_SVC", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_AVC_SVC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CAVS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_CAVS']"
			[Register ("VIDEO_CAVS")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoCavs {
				get {
					if (VIDEO_CAVS_jfieldId == IntPtr.Zero)
						VIDEO_CAVS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CAVS", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CAVS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_H264_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_H264']"
			[Register ("VIDEO_H264")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoH264 {
				get {
					if (VIDEO_H264_jfieldId == IntPtr.Zero)
						VIDEO_H264_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_H264", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_H264_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_H264_3D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_H264_3D']"
			[Register ("VIDEO_H264_3D")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoH2643d {
				get {
					if (VIDEO_H264_3D_jfieldId == IntPtr.Zero)
						VIDEO_H264_3D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_H264_3D", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_H264_3D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_J2K_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_J2K']"
			[Register ("VIDEO_J2K")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoJ2k {
				get {
					if (VIDEO_J2K_jfieldId == IntPtr.Zero)
						VIDEO_J2K_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_J2K", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_J2K_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_MPEG1_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_MPEG1']"
			[Register ("VIDEO_MPEG1")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoMpeg1 {
				get {
					if (VIDEO_MPEG1_jfieldId == IntPtr.Zero)
						VIDEO_MPEG1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_MPEG1", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_MPEG1_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_MPEG2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_MPEG2']"
			[Register ("VIDEO_MPEG2")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoMpeg2 {
				get {
					if (VIDEO_MPEG2_jfieldId == IntPtr.Zero)
						VIDEO_MPEG2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_MPEG2", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_MPEG2_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_MPEG2_3D_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_MPEG2_3D']"
			[Register ("VIDEO_MPEG2_3D")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoMpeg23d {
				get {
					if (VIDEO_MPEG2_3D_jfieldId == IntPtr.Zero)
						VIDEO_MPEG2_3D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_MPEG2_3D", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_MPEG2_3D_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_MPEG4_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/field[@name='VIDEO_MPEG4']"
			[Register ("VIDEO_MPEG4")]
			public static global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType VideoMpeg4 {
				get {
					if (VIDEO_MPEG4_jfieldId == IntPtr.Zero)
						VIDEO_MPEG4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_MPEG4", "Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_MPEG4_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSUtils$StreamType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StreamType); }
			}

			internal StreamType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_isAudio;
			public unsafe bool IsAudio {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='isAudio' and count(parameter)=0]"
				[Register ("isAudio", "()Z", "GetIsAudioHandler")]
				get {
					if (id_isAudio == IntPtr.Zero)
						id_isAudio = JNIEnv.GetMethodID (class_ref, "isAudio", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAudio);
					} finally {
					}
				}
			}

			static IntPtr id_isVideo;
			public unsafe bool IsVideo {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='isVideo' and count(parameter)=0]"
				[Register ("isVideo", "()Z", "GetIsVideoHandler")]
				get {
					if (id_isVideo == IntPtr.Zero)
						id_isVideo = JNIEnv.GetMethodID (class_ref, "isVideo", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideo);
					} finally {
					}
				}
			}

			static IntPtr id_getTag;
			public unsafe int Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()I", "GetGetTagHandler")]
				get {
					if (id_getTag == IntPtr.Zero)
						id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTag);
					} finally {
					}
				}
			}

			static IntPtr id_fromTag_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='fromTag' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromTag", "(I)Lorg/jcodec/containers/mps/MTSUtils$StreamType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType FromTag (int p0)
			{
				if (id_fromTag_I == IntPtr.Zero)
					id_fromTag_I = JNIEnv.GetStaticMethodID (class_ref, "fromTag", "(I)Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromTag_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mps/MTSUtils$StreamType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.StreamType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/containers/mps/MTSUtils$StreamType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mps/MTSUtils$StreamType;");
				try {
					return (global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.MTSUtils.StreamType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.TSReader']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSUtils$TSReader", DoNotGenerateAcw=true)]
		public abstract partial class TSReader : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.TSReader']/field[@name='BUFFER_SIZE']"
			[Register ("BUFFER_SIZE")]
			public const int BufferSize = (int) 96256;
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSUtils$TSReader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TSReader); }
			}

			protected TSReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.TSReader']/constructor[@name='MTSUtils.TSReader' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TSReader ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (TSReader)) {
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

			static Delegate cb_onPkt_IZLjava_nio_ByteBuffer_J;
#pragma warning disable 0169
			static Delegate GetOnPkt_IZLjava_nio_ByteBuffer_JHandler ()
			{
				if (cb_onPkt_IZLjava_nio_ByteBuffer_J == null)
					cb_onPkt_IZLjava_nio_ByteBuffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, IntPtr, long, bool>) n_OnPkt_IZLjava_nio_ByteBuffer_J);
				return cb_onPkt_IZLjava_nio_ByteBuffer_J;
			}

			static bool n_OnPkt_IZLjava_nio_ByteBuffer_J (IntPtr jnienv, IntPtr native__this, int p0, bool p1, IntPtr native_p2, long p3)
			{
				global::Org.Jcodec.Containers.Mps.MTSUtils.TSReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MTSUtils.TSReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPkt (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.TSReader']/method[@name='onPkt' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='long']]"
			[Register ("onPkt", "(IZLjava/nio/ByteBuffer;J)Z", "GetOnPkt_IZLjava_nio_ByteBuffer_JHandler")]
			protected abstract bool OnPkt (int p0, bool p1, global::Java.Nio.ByteBuffer p2, long p3);

		}

		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MTSUtils$TSReader", DoNotGenerateAcw=true)]
		internal partial class TSReaderInvoker : TSReader {

			public TSReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TSReaderInvoker); }
			}

			static IntPtr id_onPkt_IZLjava_nio_ByteBuffer_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils.TSReader']/method[@name='onPkt' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='long']]"
			[Register ("onPkt", "(IZLjava/nio/ByteBuffer;J)Z", "GetOnPkt_IZLjava_nio_ByteBuffer_JHandler")]
			protected override unsafe bool OnPkt (int p0, bool p1, global::Java.Nio.ByteBuffer p2, long p3)
			{
				if (id_onPkt_IZLjava_nio_ByteBuffer_J == IntPtr.Zero)
					id_onPkt_IZLjava_nio_ByteBuffer_J = JNIEnv.GetMethodID (class_ref, "onPkt", "(IZLjava/nio/ByteBuffer;J)Z");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPkt_IZLjava_nio_ByteBuffer_J, __args);
					return __ret;
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MTSUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTSUtils); }
		}

		protected MTSUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/constructor[@name='MTSUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MTSUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MTSUtils)) {
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

		static IntPtr id_getAudioPid_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='getAudioPid' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getAudioPid", "(Ljava/io/File;)I", "")]
		public static unsafe int GetAudioPid (global::Java.IO.File p0)
		{
			if (id_getAudioPid_Ljava_io_File_ == IntPtr.Zero)
				id_getAudioPid_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getAudioPid", "(Ljava/io/File;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getAudioPid_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMediaPids_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='getMediaPids' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getMediaPids", "(Ljava/io/File;)[I", "")]
		public static unsafe int[] GetMediaPids (global::Java.IO.File p0)
		{
			if (id_getMediaPids_Ljava_io_File_ == IntPtr.Zero)
				id_getMediaPids_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getMediaPids", "(Ljava/io/File;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMediaPids_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getProgramGuids_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='getProgramGuids' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getProgramGuids", "(Ljava/io/File;)[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[] GetProgramGuids (global::Java.IO.File p0)
		{
			if (id_getProgramGuids_Ljava_io_File_ == IntPtr.Zero)
				id_getProgramGuids_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getProgramGuids", "(Ljava/io/File;)[Lorg/jcodec/containers/mps/psi/PMTSection$PMTStream;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[] __ret = (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProgramGuids_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mps.Psi.PMTSection.PMTStream));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getVideoPid_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='getVideoPid' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getVideoPid", "(Ljava/io/File;)I", "")]
		public static unsafe int GetVideoPid (global::Java.IO.File p0)
		{
			if (id_getVideoPid_Ljava_io_File_ == IntPtr.Zero)
				id_getVideoPid_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getVideoPid", "(Ljava/io/File;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getVideoPid_Ljava_io_File_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parsePAT_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='parsePAT' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("parsePAT", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParsePAT (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parsePAT_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parsePAT_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parsePAT", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parsePAT_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parsePMT_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='parsePMT' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("parsePMT", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PMTSection;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PMTSection ParsePMT (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parsePMT_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parsePMT_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parsePMT", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PMTSection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.Psi.PMTSection __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PMTSection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parsePMT_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseSection_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MTSUtils']/method[@name='parseSection' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Obsolete (@"deprecated")]
		[Register ("parseSection", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PSISection;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PSISection ParseSection (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parseSection_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parseSection_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parseSection", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PSISection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.Psi.PSISection __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseSection_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
