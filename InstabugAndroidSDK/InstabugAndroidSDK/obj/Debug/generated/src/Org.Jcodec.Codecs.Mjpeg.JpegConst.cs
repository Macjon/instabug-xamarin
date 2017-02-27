using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mjpeg/JpegConst", DoNotGenerateAcw=true)]
	public partial class JpegConst : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP0']"
		[Register ("APP0")]
		public const int App0 = (int) 224;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP1']"
		[Register ("APP1")]
		public const int App1 = (int) 225;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP2']"
		[Register ("APP2")]
		public const int App2 = (int) 226;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP3']"
		[Register ("APP3")]
		public const int App3 = (int) 227;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP4']"
		[Register ("APP4")]
		public const int App4 = (int) 228;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP5']"
		[Register ("APP5")]
		public const int App5 = (int) 229;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP6']"
		[Register ("APP6")]
		public const int App6 = (int) 230;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP7']"
		[Register ("APP7")]
		public const int App7 = (int) 231;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP8']"
		[Register ("APP8")]
		public const int App8 = (int) 232;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APP9']"
		[Register ("APP9")]
		public const int App9 = (int) 233;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPA']"
		[Register ("APPA")]
		public const int Appa = (int) 234;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPB']"
		[Register ("APPB")]
		public const int Appb = (int) 235;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPC']"
		[Register ("APPC")]
		public const int Appc = (int) 236;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPD']"
		[Register ("APPD")]
		public const int Appd = (int) 237;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPE']"
		[Register ("APPE")]
		public const int Appe = (int) 238;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='APPF']"
		[Register ("APPF")]
		public const int Appf = (int) 239;

		static IntPtr CAC_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='CAC_DEFAULT']"
		[Register ("CAC_DEFAULT")]
		public static global::Org.Jcodec.Common.IO.VLC CacDefault {
			get {
				if (CAC_DEFAULT_jfieldId == IntPtr.Zero)
					CAC_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAC_DEFAULT", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAC_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CDC_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='CDC_DEFAULT']"
		[Register ("CDC_DEFAULT")]
		public static global::Org.Jcodec.Common.IO.VLC CdcDefault {
			get {
				if (CDC_DEFAULT_jfieldId == IntPtr.Zero)
					CDC_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CDC_DEFAULT", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CDC_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='COM']"
		[Register ("COM")]
		public const int Com = (int) 254;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='DHT']"
		[Register ("DHT")]
		public const int Dht = (int) 196;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='DQT']"
		[Register ("DQT")]
		public const int Dqt = (int) 219;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='DRI']"
		[Register ("DRI")]
		public const int Dri = (int) 221;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='EOI']"
		[Register ("EOI")]
		public const int Eoi = (int) 217;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST0']"
		[Register ("RST0")]
		public const int Rst0 = (int) 208;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST1']"
		[Register ("RST1")]
		public const int Rst1 = (int) 209;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST2']"
		[Register ("RST2")]
		public const int Rst2 = (int) 210;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST3']"
		[Register ("RST3")]
		public const int Rst3 = (int) 211;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST4']"
		[Register ("RST4")]
		public const int Rst4 = (int) 212;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST5']"
		[Register ("RST5")]
		public const int Rst5 = (int) 213;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST6']"
		[Register ("RST6")]
		public const int Rst6 = (int) 214;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='RST7']"
		[Register ("RST7")]
		public const int Rst7 = (int) 215;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOF0']"
		[Register ("SOF0")]
		public const int Sof0 = (int) 192;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOF1']"
		[Register ("SOF1")]
		public const int Sof1 = (int) 193;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOF2']"
		[Register ("SOF2")]
		public const int Sof2 = (int) 194;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOF3']"
		[Register ("SOF3")]
		public const int Sof3 = (int) 195;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOI']"
		[Register ("SOI")]
		public const int Soi = (int) 216;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='SOS']"
		[Register ("SOS")]
		public const int Sos = (int) 218;

		static IntPtr YAC_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='YAC_DEFAULT']"
		[Register ("YAC_DEFAULT")]
		public static global::Org.Jcodec.Common.IO.VLC YacDefault {
			get {
				if (YAC_DEFAULT_jfieldId == IntPtr.Zero)
					YAC_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YAC_DEFAULT", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YAC_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr YDC_DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='YDC_DEFAULT']"
		[Register ("YDC_DEFAULT")]
		public static global::Org.Jcodec.Common.IO.VLC YdcDefault {
			get {
				if (YDC_DEFAULT_jfieldId == IntPtr.Zero)
					YDC_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YDC_DEFAULT", "Lorg/jcodec/common/io/VLC;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YDC_DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr naturalOrder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/field[@name='naturalOrder']"
		[Register ("naturalOrder")]
		public static IList<int> NaturalOrder {
			get {
				if (naturalOrder_jfieldId == IntPtr.Zero)
					naturalOrder_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "naturalOrder", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, naturalOrder_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mjpeg/JpegConst", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JpegConst); }
		}

		protected JpegConst (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/constructor[@name='JpegConst' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JpegConst ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JpegConst)) {
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

		static IntPtr id_toString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mjpeg']/class[@name='JpegConst']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ToString (int p0)
		{
			if (id_toString_I == IntPtr.Zero)
				id_toString_I = JNIEnv.GetStaticMethodID (class_ref, "toString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
