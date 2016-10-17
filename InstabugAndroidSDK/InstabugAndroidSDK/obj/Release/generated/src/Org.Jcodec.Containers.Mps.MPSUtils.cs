using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils", DoNotGenerateAcw=true)]
	public partial class MPSUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='AUDIO_MAX']"
		[Register ("AUDIO_MAX")]
		public const int AudioMax = (int) 479;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='AUDIO_MIN']"
		[Register ("AUDIO_MIN")]
		public const int AudioMin = (int) 448;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='PACK']"
		[Register ("PACK")]
		public const int Pack = (int) 442;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='PRIVATE_1']"
		[Register ("PRIVATE_1")]
		public const int Private1 = (int) 445;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='PRIVATE_2']"
		[Register ("PRIVATE_2")]
		public const int Private2 = (int) 447;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='PSM']"
		[Register ("PSM")]
		public const int Psm = (int) 444;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='SYSTEM']"
		[Register ("SYSTEM")]
		public const int System = (int) 443;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='VIDEO_MAX']"
		[Register ("VIDEO_MAX")]
		public const int VideoMax = (int) 495;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='VIDEO_MIN']"
		[Register ("VIDEO_MIN")]
		public const int VideoMin = (int) 480;

		static IntPtr dMapping_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/field[@name='dMapping']"
		[Register ("dMapping")]
		public static IList<Java.Lang.Class> DMapping {
			get {
				if (dMapping_jfieldId == IntPtr.Zero)
					dMapping_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dMapping", "[Ljava/lang/Class;");
				return global::Android.Runtime.JavaArray<global::Java.Lang.Class>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, dMapping_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dMapping_jfieldId == IntPtr.Zero)
					dMapping_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dMapping", "[Ljava/lang/Class;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Lang.Class>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, dMapping_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AACAudioDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$AACAudioDescriptor", DoNotGenerateAcw=true)]
		public partial class AACAudioDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$AACAudioDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AACAudioDescriptor); }
			}

			protected AACAudioDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AACAudioDescriptor']/constructor[@name='MPSUtils.AACAudioDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AACAudioDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AACAudioDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AVCVideoDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$AVCVideoDescriptor", DoNotGenerateAcw=true)]
		public partial class AVCVideoDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$AVCVideoDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AVCVideoDescriptor); }
			}

			protected AVCVideoDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AVCVideoDescriptor']/constructor[@name='MPSUtils.AVCVideoDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AVCVideoDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AVCVideoDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AudioStreamDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$AudioStreamDescriptor", DoNotGenerateAcw=true)]
		public partial class AudioStreamDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$AudioStreamDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AudioStreamDescriptor); }
			}

			protected AudioStreamDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.AudioStreamDescriptor']/constructor[@name='MPSUtils.AudioStreamDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AudioStreamDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (AudioStreamDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.ISO639LanguageDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$ISO639LanguageDescriptor", DoNotGenerateAcw=true)]
		public partial class ISO639LanguageDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$ISO639LanguageDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISO639LanguageDescriptor); }
			}

			protected ISO639LanguageDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.ISO639LanguageDescriptor']/constructor[@name='MPSUtils.ISO639LanguageDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ISO639LanguageDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (ISO639LanguageDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.MP4TextDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$MP4TextDescriptor", DoNotGenerateAcw=true)]
		public partial class MP4TextDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$MP4TextDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MP4TextDescriptor); }
			}

			protected MP4TextDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.MP4TextDescriptor']/constructor[@name='MPSUtils.MP4TextDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MP4TextDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MP4TextDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.MPEGMediaDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$MPEGMediaDescriptor", DoNotGenerateAcw=true)]
		public partial class MPEGMediaDescriptor : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$MPEGMediaDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MPEGMediaDescriptor); }
			}

			protected MPEGMediaDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.MPEGMediaDescriptor']/constructor[@name='MPSUtils.MPEGMediaDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MPEGMediaDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (MPEGMediaDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

			static Delegate cb_parse_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetParse_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_parse_Ljava_nio_ByteBuffer_ == null)
					cb_parse_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_nio_ByteBuffer_);
				return cb_parse_Ljava_nio_ByteBuffer_;
			}

			static void n_Parse_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Parse (p0);
			}
#pragma warning restore 0169

			static IntPtr id_parse_Ljava_nio_ByteBuffer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.MPEGMediaDescriptor']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("parse", "(Ljava/nio/ByteBuffer;)V", "GetParse_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe void Parse (global::Java.Nio.ByteBuffer p0)
			{
				if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_nio_ByteBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Ljava/nio/ByteBuffer;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.Mpeg4AudioDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$Mpeg4AudioDescriptor", DoNotGenerateAcw=true)]
		public partial class Mpeg4AudioDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$Mpeg4AudioDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mpeg4AudioDescriptor); }
			}

			protected Mpeg4AudioDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.Mpeg4AudioDescriptor']/constructor[@name='MPSUtils.Mpeg4AudioDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Mpeg4AudioDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Mpeg4AudioDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.Mpeg4VideoDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$Mpeg4VideoDescriptor", DoNotGenerateAcw=true)]
		public partial class Mpeg4VideoDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$Mpeg4VideoDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mpeg4VideoDescriptor); }
			}

			protected Mpeg4VideoDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.Mpeg4VideoDescriptor']/constructor[@name='MPSUtils.Mpeg4VideoDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Mpeg4VideoDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Mpeg4VideoDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$PESReader", DoNotGenerateAcw=true)]
		public abstract partial class PESReader : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$PESReader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PESReader); }
			}

			protected PESReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']/constructor[@name='MPSUtils.PESReader' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PESReader ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (PESReader)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

			static Delegate cb_analyseBuffer_Ljava_nio_ByteBuffer_J;
#pragma warning disable 0169
			static Delegate GetAnalyseBuffer_Ljava_nio_ByteBuffer_JHandler ()
			{
				if (cb_analyseBuffer_Ljava_nio_ByteBuffer_J == null)
					cb_analyseBuffer_Ljava_nio_ByteBuffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_AnalyseBuffer_Ljava_nio_ByteBuffer_J);
				return cb_analyseBuffer_Ljava_nio_ByteBuffer_J;
			}

			static void n_AnalyseBuffer_Ljava_nio_ByteBuffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AnalyseBuffer (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_analyseBuffer_Ljava_nio_ByteBuffer_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']/method[@name='analyseBuffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
			[Register ("analyseBuffer", "(Ljava/nio/ByteBuffer;J)V", "GetAnalyseBuffer_Ljava_nio_ByteBuffer_JHandler")]
			public virtual unsafe void AnalyseBuffer (global::Java.Nio.ByteBuffer p0, long p1)
			{
				if (id_analyseBuffer_Ljava_nio_ByteBuffer_J == IntPtr.Zero)
					id_analyseBuffer_Ljava_nio_ByteBuffer_J = JNIEnv.GetMethodID (class_ref, "analyseBuffer", "(Ljava/nio/ByteBuffer;J)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_analyseBuffer_Ljava_nio_ByteBuffer_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "analyseBuffer", "(Ljava/nio/ByteBuffer;J)V"), __args);
				} finally {
				}
			}

			static Delegate cb_finishRead;
#pragma warning disable 0169
			static Delegate GetFinishReadHandler ()
			{
				if (cb_finishRead == null)
					cb_finishRead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishRead);
				return cb_finishRead;
			}

			static void n_FinishRead (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FinishRead ();
			}
#pragma warning restore 0169

			static IntPtr id_finishRead;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']/method[@name='finishRead' and count(parameter)=0]"
			[Register ("finishRead", "()V", "GetFinishReadHandler")]
			public virtual unsafe void FinishRead ()
			{
				if (id_finishRead == IntPtr.Zero)
					id_finishRead = JNIEnv.GetMethodID (class_ref, "finishRead", "()V");
				try {

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finishRead);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishRead", "()V"));
				} finally {
				}
			}

			static Delegate cb_pes_Ljava_nio_ByteBuffer_JII;
#pragma warning disable 0169
			static Delegate GetPes_Ljava_nio_ByteBuffer_JIIHandler ()
			{
				if (cb_pes_Ljava_nio_ByteBuffer_JII == null)
					cb_pes_Ljava_nio_ByteBuffer_JII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int, int>) n_Pes_Ljava_nio_ByteBuffer_JII);
				return cb_pes_Ljava_nio_ByteBuffer_JII;
			}

			static void n_Pes_Ljava_nio_ByteBuffer_JII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, int p3)
			{
				global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Pes (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']/method[@name='pes' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("pes", "(Ljava/nio/ByteBuffer;JII)V", "GetPes_Ljava_nio_ByteBuffer_JIIHandler")]
			protected abstract void Pes (global::Java.Nio.ByteBuffer p0, long p1, int p2, int p3);

		}

		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$PESReader", DoNotGenerateAcw=true)]
		internal partial class PESReaderInvoker : PESReader {

			public PESReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (PESReaderInvoker); }
			}

			static IntPtr id_pes_Ljava_nio_ByteBuffer_JII;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.PESReader']/method[@name='pes' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("pes", "(Ljava/nio/ByteBuffer;JII)V", "GetPes_Ljava_nio_ByteBuffer_JIIHandler")]
			protected override unsafe void Pes (global::Java.Nio.ByteBuffer p0, long p1, int p2, int p3)
			{
				if (id_pes_Ljava_nio_ByteBuffer_JII == IntPtr.Zero)
					id_pes_Ljava_nio_ByteBuffer_JII = JNIEnv.GetMethodID (class_ref, "pes", "(Ljava/nio/ByteBuffer;JII)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pes_Ljava_nio_ByteBuffer_JII, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.VideoStreamDescriptor']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mps/MPSUtils$VideoStreamDescriptor", DoNotGenerateAcw=true)]
		public partial class VideoStreamDescriptor : global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils$VideoStreamDescriptor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoStreamDescriptor); }
			}

			protected VideoStreamDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.VideoStreamDescriptor']/constructor[@name='MPSUtils.VideoStreamDescriptor' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VideoStreamDescriptor ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (VideoStreamDescriptor)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

			static Delegate cb_getFrameRate;
#pragma warning disable 0169
			static Delegate GetGetFrameRateHandler ()
			{
				if (cb_getFrameRate == null)
					cb_getFrameRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameRate);
				return cb_getFrameRate;
			}

			static IntPtr n_GetFrameRate (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Containers.Mps.MPSUtils.VideoStreamDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSUtils.VideoStreamDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FrameRate);
			}
#pragma warning restore 0169

			static IntPtr id_getFrameRate;
			public virtual unsafe global::Org.Jcodec.Common.Model.Rational FrameRate {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils.VideoStreamDescriptor']/method[@name='getFrameRate' and count(parameter)=0]"
				[Register ("getFrameRate", "()Lorg/jcodec/common/model/Rational;", "GetGetFrameRateHandler")]
				get {
					if (id_getFrameRate == IntPtr.Zero)
						id_getFrameRate = JNIEnv.GetMethodID (class_ref, "getFrameRate", "()Lorg/jcodec/common/model/Rational;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrameRate), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameRate", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/MPSUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPSUtils); }
		}

		protected MPSUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/constructor[@name='MPSUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPSUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MPSUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_audioStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='audioStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("audioStream", "(I)Z", "")]
		public static unsafe bool AudioStream (int p0)
		{
			if (id_audioStream_I == IntPtr.Zero)
				id_audioStream_I = JNIEnv.GetStaticMethodID (class_ref, "audioStream", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_audioStream_I, __args);
			} finally {
			}
		}

		static IntPtr id_mediaMarker_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='mediaMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mediaMarker", "(I)Z", "")]
		public static unsafe bool MediaMarker (int p0)
		{
			if (id_mediaMarker_I == IntPtr.Zero)
				id_mediaMarker_I = JNIEnv.GetStaticMethodID (class_ref, "mediaMarker", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_mediaMarker_I, __args);
			} finally {
			}
		}

		static IntPtr id_mediaStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='mediaStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mediaStream", "(I)Z", "")]
		public static unsafe bool MediaStream (int p0)
		{
			if (id_mediaStream_I == IntPtr.Zero)
				id_mediaStream_I = JNIEnv.GetStaticMethodID (class_ref, "mediaStream", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_mediaStream_I, __args);
			} finally {
			}
		}

		static IntPtr id_mpeg1Pes_IIILjava_nio_ByteBuffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='mpeg1Pes' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='long']]"
		[Register ("mpeg1Pes", "(IIILjava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket Mpeg1Pes (int p0, int p1, int p2, global::Java.Nio.ByteBuffer p3, long p4)
		{
			if (id_mpeg1Pes_IIILjava_nio_ByteBuffer_J == IntPtr.Zero)
				id_mpeg1Pes_IIILjava_nio_ByteBuffer_J = JNIEnv.GetStaticMethodID (class_ref, "mpeg1Pes", "(IIILjava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mpeg1Pes_IIILjava_nio_ByteBuffer_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_mpeg2Pes_IIILjava_nio_ByteBuffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='mpeg2Pes' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.nio.ByteBuffer'] and parameter[5][@type='long']]"
		[Register ("mpeg2Pes", "(IIILjava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket Mpeg2Pes (int p0, int p1, int p2, global::Java.Nio.ByteBuffer p3, long p4)
		{
			if (id_mpeg2Pes_IIILjava_nio_ByteBuffer_J == IntPtr.Zero)
				id_mpeg2Pes_IIILjava_nio_ByteBuffer_J = JNIEnv.GetStaticMethodID (class_ref, "mpeg2Pes", "(IIILjava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_mpeg2Pes_IIILjava_nio_ByteBuffer_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseDescriptors_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='parseDescriptors' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseDescriptors", "(Ljava/nio/ByteBuffer;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor> ParseDescriptors (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parseDescriptors_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parseDescriptors_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parseDescriptors", "(Ljava/nio/ByteBuffer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor> __ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Containers.Mps.MPSUtils.MPEGMediaDescriptor>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseDescriptors_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_psMarker_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='psMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("psMarker", "(I)Z", "")]
		public static unsafe bool PsMarker (int p0)
		{
			if (id_psMarker_I == IntPtr.Zero)
				id_psMarker_I = JNIEnv.GetStaticMethodID (class_ref, "psMarker", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_psMarker_I, __args);
			} finally {
			}
		}

		static IntPtr id_readPESHeader_Ljava_nio_ByteBuffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='readPESHeader' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
		[Register ("readPESHeader", "(Ljava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket ReadPESHeader (global::Java.Nio.ByteBuffer p0, long p1)
		{
			if (id_readPESHeader_Ljava_nio_ByteBuffer_J == IntPtr.Zero)
				id_readPESHeader_Ljava_nio_ByteBuffer_J = JNIEnv.GetStaticMethodID (class_ref, "readPESHeader", "(Ljava/nio/ByteBuffer;J)Lorg/jcodec/containers/mps/MPSDemuxer$PESPacket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.MPSDemuxer.PESPacket> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readPESHeader_Ljava_nio_ByteBuffer_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readTs_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='readTs' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readTs", "(Ljava/nio/ByteBuffer;)J", "")]
		public static unsafe long ReadTs (global::Java.Nio.ByteBuffer p0)
		{
			if (id_readTs_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_readTs_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "readTs", "(Ljava/nio/ByteBuffer;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_readTs_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readTs_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='readTs' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("readTs", "(Ljava/nio/ByteBuffer;I)J", "")]
		public static unsafe long ReadTs (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_readTs_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_readTs_Ljava_nio_ByteBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "readTs", "(Ljava/nio/ByteBuffer;I)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_readTs_Ljava_nio_ByteBuffer_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_videoMarker_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='videoMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("videoMarker", "(I)Z", "")]
		public static unsafe bool VideoMarker (int p0)
		{
			if (id_videoMarker_I == IntPtr.Zero)
				id_videoMarker_I = JNIEnv.GetStaticMethodID (class_ref, "videoMarker", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_videoMarker_I, __args);
			} finally {
			}
		}

		static IntPtr id_videoStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='videoStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("videoStream", "(I)Z", "")]
		public static unsafe bool VideoStream (int p0)
		{
			if (id_videoStream_I == IntPtr.Zero)
				id_videoStream_I = JNIEnv.GetStaticMethodID (class_ref, "videoStream", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_videoStream_I, __args);
			} finally {
			}
		}

		static IntPtr id_writeTs_Ljava_nio_ByteBuffer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps']/class[@name='MPSUtils']/method[@name='writeTs' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long']]"
		[Register ("writeTs", "(Ljava/nio/ByteBuffer;J)V", "")]
		public static unsafe void WriteTs (global::Java.Nio.ByteBuffer p0, long p1)
		{
			if (id_writeTs_Ljava_nio_ByteBuffer_J == IntPtr.Zero)
				id_writeTs_Ljava_nio_ByteBuffer_J = JNIEnv.GetStaticMethodID (class_ref, "writeTs", "(Ljava/nio/ByteBuffer;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeTs_Ljava_nio_ByteBuffer_J, __args);
			} finally {
			}
		}

	}
}
