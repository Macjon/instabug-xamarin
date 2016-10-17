using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/ObjectType", DoNotGenerateAcw=true)]
	public sealed partial class ObjectType : global::Java.Lang.Enum {


		static IntPtr AOT_AAC_LC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_AAC_LC']"
		[Register ("AOT_AAC_LC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAacLc {
			get {
				if (AOT_AAC_LC_jfieldId == IntPtr.Zero)
					AOT_AAC_LC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_AAC_LC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_AAC_LC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_AAC_LTP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_AAC_LTP']"
		[Register ("AOT_AAC_LTP")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAacLtp {
			get {
				if (AOT_AAC_LTP_jfieldId == IntPtr.Zero)
					AOT_AAC_LTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_AAC_LTP", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_AAC_LTP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_AAC_MAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_AAC_MAIN']"
		[Register ("AOT_AAC_MAIN")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAacMain {
			get {
				if (AOT_AAC_MAIN_jfieldId == IntPtr.Zero)
					AOT_AAC_MAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_AAC_MAIN", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_AAC_MAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_AAC_SCALABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_AAC_SCALABLE']"
		[Register ("AOT_AAC_SCALABLE")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAacScalable {
			get {
				if (AOT_AAC_SCALABLE_jfieldId == IntPtr.Zero)
					AOT_AAC_SCALABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_AAC_SCALABLE", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_AAC_SCALABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_AAC_SSR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_AAC_SSR']"
		[Register ("AOT_AAC_SSR")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAacSsr {
			get {
				if (AOT_AAC_SSR_jfieldId == IntPtr.Zero)
					AOT_AAC_SSR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_AAC_SSR", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_AAC_SSR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ALS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ALS']"
		[Register ("AOT_ALS")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotAls {
			get {
				if (AOT_ALS_jfieldId == IntPtr.Zero)
					AOT_ALS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ALS", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ALS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_CELP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_CELP']"
		[Register ("AOT_CELP")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotCelp {
			get {
				if (AOT_CELP_jfieldId == IntPtr.Zero)
					AOT_CELP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_CELP", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_CELP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_DST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_DST']"
		[Register ("AOT_DST")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotDst {
			get {
				if (AOT_DST_jfieldId == IntPtr.Zero)
					AOT_DST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_DST", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_DST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_AAC_ELD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_AAC_ELD']"
		[Register ("AOT_ER_AAC_ELD")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErAacEld {
			get {
				if (AOT_ER_AAC_ELD_jfieldId == IntPtr.Zero)
					AOT_ER_AAC_ELD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_AAC_ELD", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_AAC_ELD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_AAC_LC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_AAC_LC']"
		[Register ("AOT_ER_AAC_LC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErAacLc {
			get {
				if (AOT_ER_AAC_LC_jfieldId == IntPtr.Zero)
					AOT_ER_AAC_LC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_AAC_LC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_AAC_LC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_AAC_LD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_AAC_LD']"
		[Register ("AOT_ER_AAC_LD")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErAacLd {
			get {
				if (AOT_ER_AAC_LD_jfieldId == IntPtr.Zero)
					AOT_ER_AAC_LD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_AAC_LD", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_AAC_LD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_AAC_LTP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_AAC_LTP']"
		[Register ("AOT_ER_AAC_LTP")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErAacLtp {
			get {
				if (AOT_ER_AAC_LTP_jfieldId == IntPtr.Zero)
					AOT_ER_AAC_LTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_AAC_LTP", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_AAC_LTP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_AAC_SCALABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_AAC_SCALABLE']"
		[Register ("AOT_ER_AAC_SCALABLE")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErAacScalable {
			get {
				if (AOT_ER_AAC_SCALABLE_jfieldId == IntPtr.Zero)
					AOT_ER_AAC_SCALABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_AAC_SCALABLE", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_AAC_SCALABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_BSAC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_BSAC']"
		[Register ("AOT_ER_BSAC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErBsac {
			get {
				if (AOT_ER_BSAC_jfieldId == IntPtr.Zero)
					AOT_ER_BSAC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_BSAC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_BSAC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_CELP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_CELP']"
		[Register ("AOT_ER_CELP")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErCelp {
			get {
				if (AOT_ER_CELP_jfieldId == IntPtr.Zero)
					AOT_ER_CELP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_CELP", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_CELP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_HILN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_HILN']"
		[Register ("AOT_ER_HILN")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErHiln {
			get {
				if (AOT_ER_HILN_jfieldId == IntPtr.Zero)
					AOT_ER_HILN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_HILN", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_HILN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_HVXC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_HVXC']"
		[Register ("AOT_ER_HVXC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErHvxc {
			get {
				if (AOT_ER_HVXC_jfieldId == IntPtr.Zero)
					AOT_ER_HVXC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_HVXC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_HVXC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_PARAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_PARAM']"
		[Register ("AOT_ER_PARAM")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErParam {
			get {
				if (AOT_ER_PARAM_jfieldId == IntPtr.Zero)
					AOT_ER_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_PARAM", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_PARAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ER_TWINVQ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ER_TWINVQ']"
		[Register ("AOT_ER_TWINVQ")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotErTwinvq {
			get {
				if (AOT_ER_TWINVQ_jfieldId == IntPtr.Zero)
					AOT_ER_TWINVQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ER_TWINVQ", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ER_TWINVQ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_ESCAPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_ESCAPE']"
		[Register ("AOT_ESCAPE")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotEscape {
			get {
				if (AOT_ESCAPE_jfieldId == IntPtr.Zero)
					AOT_ESCAPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_ESCAPE", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_ESCAPE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_HVXC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_HVXC']"
		[Register ("AOT_HVXC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotHvxc {
			get {
				if (AOT_HVXC_jfieldId == IntPtr.Zero)
					AOT_HVXC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_HVXC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_HVXC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_L1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_L1']"
		[Register ("AOT_L1")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotL1 {
			get {
				if (AOT_L1_jfieldId == IntPtr.Zero)
					AOT_L1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_L1", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_L1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_L2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_L2']"
		[Register ("AOT_L2")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotL2 {
			get {
				if (AOT_L2_jfieldId == IntPtr.Zero)
					AOT_L2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_L2", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_L2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_L3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_L3']"
		[Register ("AOT_L3")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotL3 {
			get {
				if (AOT_L3_jfieldId == IntPtr.Zero)
					AOT_L3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_L3", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_L3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_LD_SURROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_LD_SURROUND']"
		[Register ("AOT_LD_SURROUND")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotLdSurround {
			get {
				if (AOT_LD_SURROUND_jfieldId == IntPtr.Zero)
					AOT_LD_SURROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_LD_SURROUND", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_LD_SURROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_MAINSYNTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_MAINSYNTH']"
		[Register ("AOT_MAINSYNTH")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotMainsynth {
			get {
				if (AOT_MAINSYNTH_jfieldId == IntPtr.Zero)
					AOT_MAINSYNTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_MAINSYNTH", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_MAINSYNTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_MIDI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_MIDI']"
		[Register ("AOT_MIDI")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotMidi {
			get {
				if (AOT_MIDI_jfieldId == IntPtr.Zero)
					AOT_MIDI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_MIDI", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_MIDI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_NULL']"
		[Register ("AOT_NULL")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotNull {
			get {
				if (AOT_NULL_jfieldId == IntPtr.Zero)
					AOT_NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_NULL", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_PS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_PS']"
		[Register ("AOT_PS")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotPs {
			get {
				if (AOT_PS_jfieldId == IntPtr.Zero)
					AOT_PS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_PS", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_PS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SAFX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SAFX']"
		[Register ("AOT_SAFX")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSafx {
			get {
				if (AOT_SAFX_jfieldId == IntPtr.Zero)
					AOT_SAFX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SAFX", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SAFX_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SAOC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SAOC']"
		[Register ("AOT_SAOC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSaoc {
			get {
				if (AOT_SAOC_jfieldId == IntPtr.Zero)
					AOT_SAOC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SAOC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SAOC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SBR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SBR']"
		[Register ("AOT_SBR")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSbr {
			get {
				if (AOT_SBR_jfieldId == IntPtr.Zero)
					AOT_SBR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SBR", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SBR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SLS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SLS']"
		[Register ("AOT_SLS")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSls {
			get {
				if (AOT_SLS_jfieldId == IntPtr.Zero)
					AOT_SLS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SLS", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SLS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SLS_NON_CORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SLS_NON_CORE']"
		[Register ("AOT_SLS_NON_CORE")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSlsNonCore {
			get {
				if (AOT_SLS_NON_CORE_jfieldId == IntPtr.Zero)
					AOT_SLS_NON_CORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SLS_NON_CORE", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SLS_NON_CORE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SMR_MAIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SMR_MAIN']"
		[Register ("AOT_SMR_MAIN")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSmrMain {
			get {
				if (AOT_SMR_MAIN_jfieldId == IntPtr.Zero)
					AOT_SMR_MAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SMR_MAIN", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SMR_MAIN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SMR_SIMPLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SMR_SIMPLE']"
		[Register ("AOT_SMR_SIMPLE")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSmrSimple {
			get {
				if (AOT_SMR_SIMPLE_jfieldId == IntPtr.Zero)
					AOT_SMR_SIMPLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SMR_SIMPLE", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SMR_SIMPLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SSC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SSC']"
		[Register ("AOT_SSC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSsc {
			get {
				if (AOT_SSC_jfieldId == IntPtr.Zero)
					AOT_SSC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SSC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SSC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_SURROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_SURROUND']"
		[Register ("AOT_SURROUND")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotSurround {
			get {
				if (AOT_SURROUND_jfieldId == IntPtr.Zero)
					AOT_SURROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_SURROUND", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_SURROUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_TTSI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_TTSI']"
		[Register ("AOT_TTSI")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotTtsi {
			get {
				if (AOT_TTSI_jfieldId == IntPtr.Zero)
					AOT_TTSI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_TTSI", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_TTSI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_TWINVQ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_TWINVQ']"
		[Register ("AOT_TWINVQ")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotTwinvq {
			get {
				if (AOT_TWINVQ_jfieldId == IntPtr.Zero)
					AOT_TWINVQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_TWINVQ", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_TWINVQ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_USAC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_USAC']"
		[Register ("AOT_USAC")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotUsac {
			get {
				if (AOT_USAC_jfieldId == IntPtr.Zero)
					AOT_USAC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_USAC", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_USAC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_USAC_NOSBR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_USAC_NOSBR']"
		[Register ("AOT_USAC_NOSBR")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotUsacNosbr {
			get {
				if (AOT_USAC_NOSBR_jfieldId == IntPtr.Zero)
					AOT_USAC_NOSBR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_USAC_NOSBR", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_USAC_NOSBR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AOT_WAVESYNTH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='AOT_WAVESYNTH']"
		[Register ("AOT_WAVESYNTH")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType AotWavesynth {
			get {
				if (AOT_WAVESYNTH_jfieldId == IntPtr.Zero)
					AOT_WAVESYNTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AOT_WAVESYNTH", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AOT_WAVESYNTH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRAP1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='CRAP1']"
		[Register ("CRAP1")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType Crap1 {
			get {
				if (CRAP1_jfieldId == IntPtr.Zero)
					CRAP1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRAP1", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRAP1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRAP2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='CRAP2']"
		[Register ("CRAP2")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType Crap2 {
			get {
				if (CRAP2_jfieldId == IntPtr.Zero)
					CRAP2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRAP2", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRAP2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CRAP3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/field[@name='CRAP3']"
		[Register ("CRAP3")]
		public static global::Org.Jcodec.Codecs.Aac.ObjectType Crap3 {
			get {
				if (CRAP3_jfieldId == IntPtr.Zero)
					CRAP3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CRAP3", "Lorg/jcodec/codecs/aac/ObjectType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CRAP3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/ObjectType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectType); }
		}

		internal ObjectType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/ObjectType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.ObjectType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/ObjectType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Aac.ObjectType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ObjectType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ObjectType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/codecs/aac/ObjectType;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.ObjectType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/aac/ObjectType;");
			try {
				return (global::Org.Jcodec.Codecs.Aac.ObjectType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Aac.ObjectType));
			} finally {
			}
		}

	}
}
