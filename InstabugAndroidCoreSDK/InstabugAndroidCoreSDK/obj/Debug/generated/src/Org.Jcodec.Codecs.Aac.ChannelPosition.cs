using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Aac {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/aac/ChannelPosition", DoNotGenerateAcw=true)]
	public sealed partial class ChannelPosition : global::Java.Lang.Enum {


		static IntPtr AAC_CHANNEL_BACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/field[@name='AAC_CHANNEL_BACK']"
		[Register ("AAC_CHANNEL_BACK")]
		public static global::Org.Jcodec.Codecs.Aac.ChannelPosition AacChannelBack {
			get {
				if (AAC_CHANNEL_BACK_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_BACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_BACK", "Lorg/jcodec/codecs/aac/ChannelPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_BACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AAC_CHANNEL_CC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/field[@name='AAC_CHANNEL_CC']"
		[Register ("AAC_CHANNEL_CC")]
		public static global::Org.Jcodec.Codecs.Aac.ChannelPosition AacChannelCc {
			get {
				if (AAC_CHANNEL_CC_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_CC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_CC", "Lorg/jcodec/codecs/aac/ChannelPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_CC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AAC_CHANNEL_FRONT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/field[@name='AAC_CHANNEL_FRONT']"
		[Register ("AAC_CHANNEL_FRONT")]
		public static global::Org.Jcodec.Codecs.Aac.ChannelPosition AacChannelFront {
			get {
				if (AAC_CHANNEL_FRONT_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_FRONT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_FRONT", "Lorg/jcodec/codecs/aac/ChannelPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_FRONT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AAC_CHANNEL_LFE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/field[@name='AAC_CHANNEL_LFE']"
		[Register ("AAC_CHANNEL_LFE")]
		public static global::Org.Jcodec.Codecs.Aac.ChannelPosition AacChannelLfe {
			get {
				if (AAC_CHANNEL_LFE_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_LFE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_LFE", "Lorg/jcodec/codecs/aac/ChannelPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_LFE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AAC_CHANNEL_SIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/field[@name='AAC_CHANNEL_SIDE']"
		[Register ("AAC_CHANNEL_SIDE")]
		public static global::Org.Jcodec.Codecs.Aac.ChannelPosition AacChannelSide {
			get {
				if (AAC_CHANNEL_SIDE_jfieldId == IntPtr.Zero)
					AAC_CHANNEL_SIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC_CHANNEL_SIDE", "Lorg/jcodec/codecs/aac/ChannelPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_CHANNEL_SIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/aac/ChannelPosition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelPosition); }
		}

		internal ChannelPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/ChannelPosition;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.ChannelPosition ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/codecs/aac/ChannelPosition;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Org.Jcodec.Codecs.Aac.ChannelPosition __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Aac.ChannelPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.aac']/class[@name='ChannelPosition']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/codecs/aac/ChannelPosition;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Aac.ChannelPosition[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/codecs/aac/ChannelPosition;");
			try {
				return (global::Org.Jcodec.Codecs.Aac.ChannelPosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Codecs.Aac.ChannelPosition));
			} finally {
			}
		}

	}
}
