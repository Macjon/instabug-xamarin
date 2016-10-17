using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4.Boxes.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/boxes/channel/Label", DoNotGenerateAcw=true)]
	public sealed partial class Label : global::Java.Lang.Enum {


		static IntPtr Ambisonic_W_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Ambisonic_W']"
		[Register ("Ambisonic_W")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label AmbisonicW {
			get {
				if (Ambisonic_W_jfieldId == IntPtr.Zero)
					Ambisonic_W_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ambisonic_W", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ambisonic_W_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ambisonic_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Ambisonic_X']"
		[Register ("Ambisonic_X")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label AmbisonicX {
			get {
				if (Ambisonic_X_jfieldId == IntPtr.Zero)
					Ambisonic_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ambisonic_X", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ambisonic_X_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ambisonic_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Ambisonic_Y']"
		[Register ("Ambisonic_Y")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label AmbisonicY {
			get {
				if (Ambisonic_Y_jfieldId == IntPtr.Zero)
					Ambisonic_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ambisonic_Y", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ambisonic_Y_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Ambisonic_Z_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Ambisonic_Z']"
		[Register ("Ambisonic_Z")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label AmbisonicZ {
			get {
				if (Ambisonic_Z_jfieldId == IntPtr.Zero)
					Ambisonic_Z_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Ambisonic_Z", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Ambisonic_Z_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Center_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Center']"
		[Register ("Center")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Center {
			get {
				if (Center_jfieldId == IntPtr.Zero)
					Center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Center", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Center_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CenterSurround_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='CenterSurround']"
		[Register ("CenterSurround")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label CenterSurround {
			get {
				if (CenterSurround_jfieldId == IntPtr.Zero)
					CenterSurround_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CenterSurround", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CenterSurround_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CenterSurroundDirect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='CenterSurroundDirect']"
		[Register ("CenterSurroundDirect")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label CenterSurroundDirect {
			get {
				if (CenterSurroundDirect_jfieldId == IntPtr.Zero)
					CenterSurroundDirect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CenterSurroundDirect", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CenterSurroundDirect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ClickTrack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='ClickTrack']"
		[Register ("ClickTrack")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label ClickTrack {
			get {
				if (ClickTrack_jfieldId == IntPtr.Zero)
					ClickTrack_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ClickTrack", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ClickTrack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DialogCentricMix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='DialogCentricMix']"
		[Register ("DialogCentricMix")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label DialogCentricMix {
			get {
				if (DialogCentricMix_jfieldId == IntPtr.Zero)
					DialogCentricMix_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DialogCentricMix", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DialogCentricMix_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete']"
		[Register ("Discrete")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete {
			get {
				if (Discrete_jfieldId == IntPtr.Zero)
					Discrete_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_0']"
		[Register ("Discrete_0")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete0 {
			get {
				if (Discrete_0_jfieldId == IntPtr.Zero)
					Discrete_0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_0", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_0_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_1']"
		[Register ("Discrete_1")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete1 {
			get {
				if (Discrete_1_jfieldId == IntPtr.Zero)
					Discrete_1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_1", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_10']"
		[Register ("Discrete_10")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete10 {
			get {
				if (Discrete_10_jfieldId == IntPtr.Zero)
					Discrete_10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_10", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_11']"
		[Register ("Discrete_11")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete11 {
			get {
				if (Discrete_11_jfieldId == IntPtr.Zero)
					Discrete_11_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_11", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_11_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_12_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_12']"
		[Register ("Discrete_12")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete12 {
			get {
				if (Discrete_12_jfieldId == IntPtr.Zero)
					Discrete_12_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_12", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_12_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_13_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_13']"
		[Register ("Discrete_13")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete13 {
			get {
				if (Discrete_13_jfieldId == IntPtr.Zero)
					Discrete_13_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_13", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_13_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_14_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_14']"
		[Register ("Discrete_14")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete14 {
			get {
				if (Discrete_14_jfieldId == IntPtr.Zero)
					Discrete_14_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_14", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_14_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_15_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_15']"
		[Register ("Discrete_15")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete15 {
			get {
				if (Discrete_15_jfieldId == IntPtr.Zero)
					Discrete_15_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_15", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_15_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_2']"
		[Register ("Discrete_2")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete2 {
			get {
				if (Discrete_2_jfieldId == IntPtr.Zero)
					Discrete_2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_2", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_3']"
		[Register ("Discrete_3")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete3 {
			get {
				if (Discrete_3_jfieldId == IntPtr.Zero)
					Discrete_3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_3", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_4']"
		[Register ("Discrete_4")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete4 {
			get {
				if (Discrete_4_jfieldId == IntPtr.Zero)
					Discrete_4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_4", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_5']"
		[Register ("Discrete_5")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete5 {
			get {
				if (Discrete_5_jfieldId == IntPtr.Zero)
					Discrete_5_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_5", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_6']"
		[Register ("Discrete_6")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete6 {
			get {
				if (Discrete_6_jfieldId == IntPtr.Zero)
					Discrete_6_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_6", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_6_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_65535_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_65535']"
		[Register ("Discrete_65535")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete65535 {
			get {
				if (Discrete_65535_jfieldId == IntPtr.Zero)
					Discrete_65535_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_65535", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_65535_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_7']"
		[Register ("Discrete_7")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete7 {
			get {
				if (Discrete_7_jfieldId == IntPtr.Zero)
					Discrete_7_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_7", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_7_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_8']"
		[Register ("Discrete_8")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete8 {
			get {
				if (Discrete_8_jfieldId == IntPtr.Zero)
					Discrete_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_8", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Discrete_9_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Discrete_9']"
		[Register ("Discrete_9")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Discrete9 {
			get {
				if (Discrete_9_jfieldId == IntPtr.Zero)
					Discrete_9_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Discrete_9", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Discrete_9_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ForeignLanguage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='ForeignLanguage']"
		[Register ("ForeignLanguage")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label ForeignLanguage {
			get {
				if (ForeignLanguage_jfieldId == IntPtr.Zero)
					ForeignLanguage_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ForeignLanguage", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ForeignLanguage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HeadphonesLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='HeadphonesLeft']"
		[Register ("HeadphonesLeft")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label HeadphonesLeft {
			get {
				if (HeadphonesLeft_jfieldId == IntPtr.Zero)
					HeadphonesLeft_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HeadphonesLeft", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HeadphonesLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HeadphonesRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='HeadphonesRight']"
		[Register ("HeadphonesRight")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label HeadphonesRight {
			get {
				if (HeadphonesRight_jfieldId == IntPtr.Zero)
					HeadphonesRight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HeadphonesRight", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HeadphonesRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HearingImpaired_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='HearingImpaired']"
		[Register ("HearingImpaired")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label HearingImpaired {
			get {
				if (HearingImpaired_jfieldId == IntPtr.Zero)
					HearingImpaired_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HearingImpaired", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HearingImpaired_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LFE2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LFE2']"
		[Register ("LFE2")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Lfe2 {
			get {
				if (LFE2_jfieldId == IntPtr.Zero)
					LFE2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LFE2", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LFE2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LFEScreen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LFEScreen']"
		[Register ("LFEScreen")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LFEScreen {
			get {
				if (LFEScreen_jfieldId == IntPtr.Zero)
					LFEScreen_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LFEScreen", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LFEScreen_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Left_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Left']"
		[Register ("Left")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Left {
			get {
				if (Left_jfieldId == IntPtr.Zero)
					Left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Left", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Left_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LeftCenter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LeftCenter']"
		[Register ("LeftCenter")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LeftCenter {
			get {
				if (LeftCenter_jfieldId == IntPtr.Zero)
					LeftCenter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LeftCenter", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LeftCenter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LeftSurround_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LeftSurround']"
		[Register ("LeftSurround")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LeftSurround {
			get {
				if (LeftSurround_jfieldId == IntPtr.Zero)
					LeftSurround_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LeftSurround", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LeftSurround_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LeftSurroundDirect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LeftSurroundDirect']"
		[Register ("LeftSurroundDirect")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LeftSurroundDirect {
			get {
				if (LeftSurroundDirect_jfieldId == IntPtr.Zero)
					LeftSurroundDirect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LeftSurroundDirect", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LeftSurroundDirect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LeftTotal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LeftTotal']"
		[Register ("LeftTotal")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LeftTotal {
			get {
				if (LeftTotal_jfieldId == IntPtr.Zero)
					LeftTotal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LeftTotal", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LeftTotal_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LeftWide_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='LeftWide']"
		[Register ("LeftWide")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label LeftWide {
			get {
				if (LeftWide_jfieldId == IntPtr.Zero)
					LeftWide_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LeftWide", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LeftWide_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MS_Mid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='MS_Mid']"
		[Register ("MS_Mid")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label MSMid {
			get {
				if (MS_Mid_jfieldId == IntPtr.Zero)
					MS_Mid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MS_Mid", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MS_Mid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MS_Side_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='MS_Side']"
		[Register ("MS_Side")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label MSSide {
			get {
				if (MS_Side_jfieldId == IntPtr.Zero)
					MS_Side_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MS_Side", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MS_Side_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Mono_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Mono']"
		[Register ("Mono")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Mono {
			get {
				if (Mono_jfieldId == IntPtr.Zero)
					Mono_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Mono", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Mono_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Narration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Narration']"
		[Register ("Narration")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Narration {
			get {
				if (Narration_jfieldId == IntPtr.Zero)
					Narration_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Narration", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Narration_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RearSurroundLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RearSurroundLeft']"
		[Register ("RearSurroundLeft")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RearSurroundLeft {
			get {
				if (RearSurroundLeft_jfieldId == IntPtr.Zero)
					RearSurroundLeft_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RearSurroundLeft", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RearSurroundLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RearSurroundRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RearSurroundRight']"
		[Register ("RearSurroundRight")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RearSurroundRight {
			get {
				if (RearSurroundRight_jfieldId == IntPtr.Zero)
					RearSurroundRight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RearSurroundRight", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RearSurroundRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Right_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Right']"
		[Register ("Right")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Right {
			get {
				if (Right_jfieldId == IntPtr.Zero)
					Right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Right", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Right_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RightCenter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RightCenter']"
		[Register ("RightCenter")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RightCenter {
			get {
				if (RightCenter_jfieldId == IntPtr.Zero)
					RightCenter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RightCenter", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RightCenter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RightSurround_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RightSurround']"
		[Register ("RightSurround")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RightSurround {
			get {
				if (RightSurround_jfieldId == IntPtr.Zero)
					RightSurround_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RightSurround", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RightSurround_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RightSurroundDirect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RightSurroundDirect']"
		[Register ("RightSurroundDirect")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RightSurroundDirect {
			get {
				if (RightSurroundDirect_jfieldId == IntPtr.Zero)
					RightSurroundDirect_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RightSurroundDirect", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RightSurroundDirect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RightTotal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RightTotal']"
		[Register ("RightTotal")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RightTotal {
			get {
				if (RightTotal_jfieldId == IntPtr.Zero)
					RightTotal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RightTotal", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RightTotal_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RightWide_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='RightWide']"
		[Register ("RightWide")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label RightWide {
			get {
				if (RightWide_jfieldId == IntPtr.Zero)
					RightWide_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RightWide", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RightWide_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TopBackCenter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='TopBackCenter']"
		[Register ("TopBackCenter")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label TopBackCenter {
			get {
				if (TopBackCenter_jfieldId == IntPtr.Zero)
					TopBackCenter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TopBackCenter", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TopBackCenter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TopBackLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='TopBackLeft']"
		[Register ("TopBackLeft")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label TopBackLeft {
			get {
				if (TopBackLeft_jfieldId == IntPtr.Zero)
					TopBackLeft_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TopBackLeft", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TopBackLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TopBackRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='TopBackRight']"
		[Register ("TopBackRight")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label TopBackRight {
			get {
				if (TopBackRight_jfieldId == IntPtr.Zero)
					TopBackRight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TopBackRight", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TopBackRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TopCenterSurround_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='TopCenterSurround']"
		[Register ("TopCenterSurround")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label TopCenterSurround {
			get {
				if (TopCenterSurround_jfieldId == IntPtr.Zero)
					TopCenterSurround_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TopCenterSurround", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TopCenterSurround_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Unknown']"
		[Register ("Unknown")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Unknown {
			get {
				if (Unknown_jfieldId == IntPtr.Zero)
					Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Unused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='Unused']"
		[Register ("Unused")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label Unused {
			get {
				if (Unused_jfieldId == IntPtr.Zero)
					Unused_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unused", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unused_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UseCoordinates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='UseCoordinates']"
		[Register ("UseCoordinates")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label UseCoordinates {
			get {
				if (UseCoordinates_jfieldId == IntPtr.Zero)
					UseCoordinates_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UseCoordinates", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UseCoordinates_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VerticalHeightCenter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='VerticalHeightCenter']"
		[Register ("VerticalHeightCenter")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label VerticalHeightCenter {
			get {
				if (VerticalHeightCenter_jfieldId == IntPtr.Zero)
					VerticalHeightCenter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VerticalHeightCenter", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VerticalHeightCenter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VerticalHeightLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='VerticalHeightLeft']"
		[Register ("VerticalHeightLeft")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label VerticalHeightLeft {
			get {
				if (VerticalHeightLeft_jfieldId == IntPtr.Zero)
					VerticalHeightLeft_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VerticalHeightLeft", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VerticalHeightLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VerticalHeightRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='VerticalHeightRight']"
		[Register ("VerticalHeightRight")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label VerticalHeightRight {
			get {
				if (VerticalHeightRight_jfieldId == IntPtr.Zero)
					VerticalHeightRight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VerticalHeightRight", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VerticalHeightRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XY_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='XY_X']"
		[Register ("XY_X")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label XyX {
			get {
				if (XY_X_jfieldId == IntPtr.Zero)
					XY_X_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XY_X", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XY_X_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr XY_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='XY_Y']"
		[Register ("XY_Y")]
		public static global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label XyY {
			get {
				if (XY_Y_jfieldId == IntPtr.Zero)
					XY_Y_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "XY_Y", "Lorg/jcodec/containers/mp4/boxes/channel/Label;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, XY_Y_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr channelMappingRegex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/field[@name='channelMappingRegex']"
		[Register ("channelMappingRegex")]
		public static global::Java.Util.Regex.Pattern ChannelMappingRegex {
			get {
				if (channelMappingRegex_jfieldId == IntPtr.Zero)
					channelMappingRegex_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "channelMappingRegex", "Ljava/util/regex/Pattern;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, channelMappingRegex_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/boxes/channel/Label", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Label); }
		}

		internal Label (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getVal;
		public unsafe int Val {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/method[@name='getVal' and count(parameter)=0]"
			[Register ("getVal", "()I", "GetGetValHandler")]
			get {
				if (id_getVal == IntPtr.Zero)
					id_getVal = JNIEnv.GetMethodID (class_ref, "getVal", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVal);
				} finally {
				}
			}
		}

		static IntPtr id_getByVal_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/method[@name='getByVal' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getByVal", "(I)Lorg/jcodec/containers/mp4/boxes/channel/Label;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label GetByVal (int p0)
		{
			if (id_getByVal_I == IntPtr.Zero)
				id_getByVal_I = JNIEnv.GetStaticMethodID (class_ref, "getByVal", "(I)Lorg/jcodec/containers/mp4/boxes/channel/Label;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getByVal_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/boxes/channel/Label;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/boxes/channel/Label;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4.boxes.channel']/class[@name='Label']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/containers/mp4/boxes/channel/Label;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mp4/boxes/channel/Label;");
			try {
				return (global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mp4.Boxes.Channel.Label));
			} finally {
			}
		}

	}
}
