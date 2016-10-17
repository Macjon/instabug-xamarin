using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/TrackType", DoNotGenerateAcw=true)]
	public sealed partial class TrackType : global::Java.Lang.Enum {


		static IntPtr CC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='CC']"
		[Register ("CC")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Cc {
			get {
				if (CC_jfieldId == IntPtr.Zero)
					CC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CC", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHAPTERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='CHAPTERS']"
		[Register ("CHAPTERS")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Chapters {
			get {
				if (CHAPTERS_jfieldId == IntPtr.Zero)
					CHAPTERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHAPTERS", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHAPTERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='HINT']"
		[Register ("HINT")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Hint {
			get {
				if (HINT_jfieldId == IntPtr.Zero)
					HINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HINT", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HINT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HYPER_TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='HYPER_TEXT']"
		[Register ("HYPER_TEXT")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType HyperText {
			get {
				if (HYPER_TEXT_jfieldId == IntPtr.Zero)
					HYPER_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HYPER_TEXT", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HYPER_TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MPEG1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='MPEG1']"
		[Register ("MPEG1")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Mpeg1 {
			get {
				if (MPEG1_jfieldId == IntPtr.Zero)
					MPEG1_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPEG1", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPEG1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MUSIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='MUSIC']"
		[Register ("MUSIC")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Music {
			get {
				if (MUSIC_jfieldId == IntPtr.Zero)
					MUSIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MUSIC", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MUSIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OBJECTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='OBJECTS']"
		[Register ("OBJECTS")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Objects {
			get {
				if (OBJECTS_jfieldId == IntPtr.Zero)
					OBJECTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBJECTS", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OBJECTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='SOUND']"
		[Register ("SOUND")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Sound {
			get {
				if (SOUND_jfieldId == IntPtr.Zero)
					SOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOUND", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SPRITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='SPRITE']"
		[Register ("SPRITE")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Sprite {
			get {
				if (SPRITE_jfieldId == IntPtr.Zero)
					SPRITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPRITE", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPRITE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STREAMING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='STREAMING']"
		[Register ("STREAMING")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Streaming {
			get {
				if (STREAMING_jfieldId == IntPtr.Zero)
					STREAMING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STREAMING", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STREAMING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='SUB']"
		[Register ("SUB")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Sub {
			get {
				if (SUB_jfieldId == IntPtr.Zero)
					SUB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUB", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='TEXT']"
		[Register ("TEXT")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Text {
			get {
				if (TEXT_jfieldId == IntPtr.Zero)
					TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_D_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='THREE_D']"
		[Register ("THREE_D")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType ThreeD {
			get {
				if (THREE_D_jfieldId == IntPtr.Zero)
					THREE_D_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_D", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_D_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TIMECODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='TIMECODE']"
		[Register ("TIMECODE")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Timecode {
			get {
				if (TIMECODE_jfieldId == IntPtr.Zero)
					TIMECODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMECODE", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMECODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWEEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='TWEEN']"
		[Register ("TWEEN")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Tween {
			get {
				if (TWEEN_jfieldId == IntPtr.Zero)
					TWEEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWEEN", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWEEN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public static global::Org.Jcodec.Containers.Mp4.TrackType Video {
			get {
				if (VIDEO_jfieldId == IntPtr.Zero)
					VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO", "Lorg/jcodec/containers/mp4/TrackType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/TrackType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackType); }
		}

		internal TrackType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHandler;
		public unsafe string Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Ljava/lang/String;", "GetGetHandlerHandler")]
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromHandler_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/method[@name='fromHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromHandler", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/TrackType;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.TrackType FromHandler (string p0)
		{
			if (id_fromHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_fromHandler_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromHandler", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/TrackType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Containers.Mp4.TrackType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromHandler_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/TrackType;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.TrackType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mp4/TrackType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Containers.Mp4.TrackType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.TrackType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='TrackType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/jcodec/containers/mp4/TrackType;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mp4.TrackType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mp4/TrackType;");
			try {
				return (global::Org.Jcodec.Containers.Mp4.TrackType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mp4.TrackType));
			} finally {
			}
		}

	}
}
