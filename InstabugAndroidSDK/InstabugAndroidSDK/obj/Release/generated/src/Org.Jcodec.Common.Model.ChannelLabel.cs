using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/ChannelLabel", DoNotGenerateAcw=true)]
	public sealed partial class ChannelLabel : global::Java.Lang.Enum {


		static IntPtr CENTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='CENTER']"
		[Register ("CENTER")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel Center {
			get {
				if (CENTER_jfieldId == IntPtr.Zero)
					CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRONT_CENTER_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='FRONT_CENTER_LEFT']"
		[Register ("FRONT_CENTER_LEFT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel FrontCenterLeft {
			get {
				if (FRONT_CENTER_LEFT_jfieldId == IntPtr.Zero)
					FRONT_CENTER_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRONT_CENTER_LEFT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRONT_CENTER_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRONT_CENTER_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='FRONT_CENTER_RIGHT']"
		[Register ("FRONT_CENTER_RIGHT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel FrontCenterRight {
			get {
				if (FRONT_CENTER_RIGHT_jfieldId == IntPtr.Zero)
					FRONT_CENTER_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRONT_CENTER_RIGHT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRONT_CENTER_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRONT_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='FRONT_LEFT']"
		[Register ("FRONT_LEFT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel FrontLeft {
			get {
				if (FRONT_LEFT_jfieldId == IntPtr.Zero)
					FRONT_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRONT_LEFT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRONT_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FRONT_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='FRONT_RIGHT']"
		[Register ("FRONT_RIGHT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel FrontRight {
			get {
				if (FRONT_RIGHT_jfieldId == IntPtr.Zero)
					FRONT_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRONT_RIGHT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRONT_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LEFT_TOTAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='LEFT_TOTAL']"
		[Register ("LEFT_TOTAL")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel LeftTotal {
			get {
				if (LEFT_TOTAL_jfieldId == IntPtr.Zero)
					LEFT_TOTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_TOTAL", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_TOTAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LFE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='LFE']"
		[Register ("LFE")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel Lfe {
			get {
				if (LFE_jfieldId == IntPtr.Zero)
					LFE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LFE", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LFE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MONO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='MONO']"
		[Register ("MONO")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel Mono {
			get {
				if (MONO_jfieldId == IntPtr.Zero)
					MONO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MONO", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MONO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REAR_CENTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='REAR_CENTER']"
		[Register ("REAR_CENTER")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel RearCenter {
			get {
				if (REAR_CENTER_jfieldId == IntPtr.Zero)
					REAR_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REAR_CENTER", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REAR_CENTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REAR_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='REAR_LEFT']"
		[Register ("REAR_LEFT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel RearLeft {
			get {
				if (REAR_LEFT_jfieldId == IntPtr.Zero)
					REAR_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REAR_LEFT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REAR_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REAR_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='REAR_RIGHT']"
		[Register ("REAR_RIGHT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel RearRight {
			get {
				if (REAR_RIGHT_jfieldId == IntPtr.Zero)
					REAR_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REAR_RIGHT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REAR_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RIGHT_TOTAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='RIGHT_TOTAL']"
		[Register ("RIGHT_TOTAL")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel RightTotal {
			get {
				if (RIGHT_TOTAL_jfieldId == IntPtr.Zero)
					RIGHT_TOTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_TOTAL", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_TOTAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIDE_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='SIDE_LEFT']"
		[Register ("SIDE_LEFT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel SideLeft {
			get {
				if (SIDE_LEFT_jfieldId == IntPtr.Zero)
					SIDE_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIDE_LEFT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIDE_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SIDE_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='SIDE_RIGHT']"
		[Register ("SIDE_RIGHT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel SideRight {
			get {
				if (SIDE_RIGHT_jfieldId == IntPtr.Zero)
					SIDE_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIDE_RIGHT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIDE_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STEREO_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='STEREO_LEFT']"
		[Register ("STEREO_LEFT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel StereoLeft {
			get {
				if (STEREO_LEFT_jfieldId == IntPtr.Zero)
					STEREO_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STEREO_LEFT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STEREO_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STEREO_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/field[@name='STEREO_RIGHT']"
		[Register ("STEREO_RIGHT")]
		public static global::Org.Jcodec.Common.Model.ChannelLabel StereoRight {
			get {
				if (STEREO_RIGHT_jfieldId == IntPtr.Zero)
					STEREO_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STEREO_RIGHT", "Lorg/jcodec/common/model/ChannelLabel;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STEREO_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/ChannelLabel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelLabel); }
		}

		internal ChannelLabel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/ChannelLabel;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.ChannelLabel ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/common/model/ChannelLabel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Common.Model.ChannelLabel __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.ChannelLabel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='ChannelLabel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/common/model/ChannelLabel;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/common/model/ChannelLabel;");
			try {
				return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
			} finally {
			}
		}

	}
}
