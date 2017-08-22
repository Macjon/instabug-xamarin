using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor", DoNotGenerateAcw=true)]
	public partial class GenericPictureEssenceDescriptor : global::Org.Jcodec.Containers.Mxf.Model.FileDescriptor {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType", DoNotGenerateAcw=true)]
		public sealed partial class LayoutType : global::Java.Lang.Enum {


			static IntPtr FullFrame_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/field[@name='FullFrame']"
			[Register ("FullFrame")]
			public static global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType FullFrame {
				get {
					if (FullFrame_jfieldId == IntPtr.Zero)
						FullFrame_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FullFrame", "Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FullFrame_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MixedFields_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/field[@name='MixedFields']"
			[Register ("MixedFields")]
			public static global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType MixedFields {
				get {
					if (MixedFields_jfieldId == IntPtr.Zero)
						MixedFields_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MixedFields", "Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MixedFields_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OneField_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/field[@name='OneField']"
			[Register ("OneField")]
			public static global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType OneField {
				get {
					if (OneField_jfieldId == IntPtr.Zero)
						OneField_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OneField", "Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OneField_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SegmentedFrame_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/field[@name='SegmentedFrame']"
			[Register ("SegmentedFrame")]
			public static global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType SegmentedFrame {
				get {
					if (SegmentedFrame_jfieldId == IntPtr.Zero)
						SegmentedFrame_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SegmentedFrame", "Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SegmentedFrame_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SeparateFields_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/field[@name='SeparateFields']"
			[Register ("SeparateFields")]
			public static global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType SeparateFields {
				get {
					if (SeparateFields_jfieldId == IntPtr.Zero)
						SeparateFields_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SeparateFields", "Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SeparateFields_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutType); }
			}

			internal LayoutType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor.LayoutType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
				try {
					return (global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericPictureEssenceDescriptor); }
		}

		protected GenericPictureEssenceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/constructor[@name='GenericPictureEssenceDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe GenericPictureEssenceDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL ul)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ul);
				if (((object) this).GetType () != typeof (GenericPictureEssenceDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
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

		static Delegate cb_getActiveFormatDescriptor;
#pragma warning disable 0169
		static Delegate GetGetActiveFormatDescriptorHandler ()
		{
			if (cb_getActiveFormatDescriptor == null)
				cb_getActiveFormatDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetActiveFormatDescriptor);
			return cb_getActiveFormatDescriptor;
		}

		static sbyte n_GetActiveFormatDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActiveFormatDescriptor;
		}
#pragma warning restore 0169

		static IntPtr id_getActiveFormatDescriptor;
		public virtual unsafe sbyte ActiveFormatDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getActiveFormatDescriptor' and count(parameter)=0]"
			[Register ("getActiveFormatDescriptor", "()B", "GetGetActiveFormatDescriptorHandler")]
			get {
				if (id_getActiveFormatDescriptor == IntPtr.Zero)
					id_getActiveFormatDescriptor = JNIEnv.GetMethodID (class_ref, "getActiveFormatDescriptor", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getActiveFormatDescriptor);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveFormatDescriptor", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAlphaTransparency;
#pragma warning disable 0169
		static Delegate GetGetAlphaTransparencyHandler ()
		{
			if (cb_getAlphaTransparency == null)
				cb_getAlphaTransparency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAlphaTransparency);
			return cb_getAlphaTransparency;
		}

		static sbyte n_GetAlphaTransparency (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaTransparency;
		}
#pragma warning restore 0169

		static IntPtr id_getAlphaTransparency;
		public virtual unsafe sbyte AlphaTransparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getAlphaTransparency' and count(parameter)=0]"
			[Register ("getAlphaTransparency", "()B", "GetGetAlphaTransparencyHandler")]
			get {
				if (id_getAlphaTransparency == IntPtr.Zero)
					id_getAlphaTransparency = JNIEnv.GetMethodID (class_ref, "getAlphaTransparency", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAlphaTransparency);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlphaTransparency", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioHandler ()
		{
			if (cb_getAspectRatio == null)
				cb_getAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAspectRatio);
			return cb_getAspectRatio;
		}

		static IntPtr n_GetAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AspectRatio);
		}
#pragma warning restore 0169

		static IntPtr id_getAspectRatio;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational AspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getAspectRatio' and count(parameter)=0]"
			[Register ("getAspectRatio", "()Lorg/jcodec/common/model/Rational;", "GetGetAspectRatioHandler")]
			get {
				if (id_getAspectRatio == IntPtr.Zero)
					id_getAspectRatio = JNIEnv.GetMethodID (class_ref, "getAspectRatio", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAspectRatio), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAspectRatio", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodingEquations;
#pragma warning disable 0169
		static Delegate GetGetCodingEquationsHandler ()
		{
			if (cb_getCodingEquations == null)
				cb_getCodingEquations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodingEquations);
			return cb_getCodingEquations;
		}

		static IntPtr n_GetCodingEquations (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CodingEquations);
		}
#pragma warning restore 0169

		static IntPtr id_getCodingEquations;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL CodingEquations {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getCodingEquations' and count(parameter)=0]"
			[Register ("getCodingEquations", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetCodingEquationsHandler")]
			get {
				if (id_getCodingEquations == IntPtr.Zero)
					id_getCodingEquations = JNIEnv.GetMethodID (class_ref, "getCodingEquations", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodingEquations), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodingEquations", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getColorPrimaries;
#pragma warning disable 0169
		static Delegate GetGetColorPrimariesHandler ()
		{
			if (cb_getColorPrimaries == null)
				cb_getColorPrimaries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorPrimaries);
			return cb_getColorPrimaries;
		}

		static IntPtr n_GetColorPrimaries (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ColorPrimaries);
		}
#pragma warning restore 0169

		static IntPtr id_getColorPrimaries;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL ColorPrimaries {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getColorPrimaries' and count(parameter)=0]"
			[Register ("getColorPrimaries", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetColorPrimariesHandler")]
			get {
				if (id_getColorPrimaries == IntPtr.Zero)
					id_getColorPrimaries = JNIEnv.GetMethodID (class_ref, "getColorPrimaries", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorPrimaries), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorPrimaries", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayF2Offset;
#pragma warning disable 0169
		static Delegate GetGetDisplayF2OffsetHandler ()
		{
			if (cb_getDisplayF2Offset == null)
				cb_getDisplayF2Offset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayF2Offset);
			return cb_getDisplayF2Offset;
		}

		static int n_GetDisplayF2Offset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayF2Offset;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayF2Offset;
		public virtual unsafe int DisplayF2Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getDisplayF2Offset' and count(parameter)=0]"
			[Register ("getDisplayF2Offset", "()I", "GetGetDisplayF2OffsetHandler")]
			get {
				if (id_getDisplayF2Offset == IntPtr.Zero)
					id_getDisplayF2Offset = JNIEnv.GetMethodID (class_ref, "getDisplayF2Offset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayF2Offset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayF2Offset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayHeight;
#pragma warning disable 0169
		static Delegate GetGetDisplayHeightHandler ()
		{
			if (cb_getDisplayHeight == null)
				cb_getDisplayHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayHeight);
			return cb_getDisplayHeight;
		}

		static int n_GetDisplayHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayHeight;
		public virtual unsafe int DisplayHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getDisplayHeight' and count(parameter)=0]"
			[Register ("getDisplayHeight", "()I", "GetGetDisplayHeightHandler")]
			get {
				if (id_getDisplayHeight == IntPtr.Zero)
					id_getDisplayHeight = JNIEnv.GetMethodID (class_ref, "getDisplayHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayWidth;
#pragma warning disable 0169
		static Delegate GetGetDisplayWidthHandler ()
		{
			if (cb_getDisplayWidth == null)
				cb_getDisplayWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayWidth);
			return cb_getDisplayWidth;
		}

		static int n_GetDisplayWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayWidth;
		public virtual unsafe int DisplayWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getDisplayWidth' and count(parameter)=0]"
			[Register ("getDisplayWidth", "()I", "GetGetDisplayWidthHandler")]
			get {
				if (id_getDisplayWidth == IntPtr.Zero)
					id_getDisplayWidth = JNIEnv.GetMethodID (class_ref, "getDisplayWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayXOffset;
#pragma warning disable 0169
		static Delegate GetGetDisplayXOffsetHandler ()
		{
			if (cb_getDisplayXOffset == null)
				cb_getDisplayXOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayXOffset);
			return cb_getDisplayXOffset;
		}

		static int n_GetDisplayXOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayXOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayXOffset;
		public virtual unsafe int DisplayXOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getDisplayXOffset' and count(parameter)=0]"
			[Register ("getDisplayXOffset", "()I", "GetGetDisplayXOffsetHandler")]
			get {
				if (id_getDisplayXOffset == IntPtr.Zero)
					id_getDisplayXOffset = JNIEnv.GetMethodID (class_ref, "getDisplayXOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayXOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayXOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayYOffset;
#pragma warning disable 0169
		static Delegate GetGetDisplayYOffsetHandler ()
		{
			if (cb_getDisplayYOffset == null)
				cb_getDisplayYOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayYOffset);
			return cb_getDisplayYOffset;
		}

		static int n_GetDisplayYOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayYOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayYOffset;
		public virtual unsafe int DisplayYOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getDisplayYOffset' and count(parameter)=0]"
			[Register ("getDisplayYOffset", "()I", "GetGetDisplayYOffsetHandler")]
			get {
				if (id_getDisplayYOffset == IntPtr.Zero)
					id_getDisplayYOffset = JNIEnv.GetMethodID (class_ref, "getDisplayYOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayYOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayYOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFieldDominance;
#pragma warning disable 0169
		static Delegate GetGetFieldDominanceHandler ()
		{
			if (cb_getFieldDominance == null)
				cb_getFieldDominance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetFieldDominance);
			return cb_getFieldDominance;
		}

		static sbyte n_GetFieldDominance (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FieldDominance;
		}
#pragma warning restore 0169

		static IntPtr id_getFieldDominance;
		public virtual unsafe sbyte FieldDominance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getFieldDominance' and count(parameter)=0]"
			[Register ("getFieldDominance", "()B", "GetGetFieldDominanceHandler")]
			get {
				if (id_getFieldDominance == IntPtr.Zero)
					id_getFieldDominance = JNIEnv.GetMethodID (class_ref, "getFieldDominance", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getFieldDominance);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFieldDominance", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameLayout;
#pragma warning disable 0169
		static Delegate GetGetFrameLayoutHandler ()
		{
			if (cb_getFrameLayout == null)
				cb_getFrameLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFrameLayout);
			return cb_getFrameLayout;
		}

		static IntPtr n_GetFrameLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FrameLayout);
		}
#pragma warning restore 0169

		static IntPtr id_getFrameLayout;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType FrameLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getFrameLayout' and count(parameter)=0]"
			[Register ("getFrameLayout", "()Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;", "GetGetFrameLayoutHandler")]
			get {
				if (id_getFrameLayout == IntPtr.Zero)
					id_getFrameLayout = JNIEnv.GetMethodID (class_ref, "getFrameLayout", "()Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFrameLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor.LayoutType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameLayout", "()Lorg/jcodec/containers/mxf/model/GenericPictureEssenceDescriptor$LayoutType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageAlignmentOffset;
#pragma warning disable 0169
		static Delegate GetGetImageAlignmentOffsetHandler ()
		{
			if (cb_getImageAlignmentOffset == null)
				cb_getImageAlignmentOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageAlignmentOffset);
			return cb_getImageAlignmentOffset;
		}

		static int n_GetImageAlignmentOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageAlignmentOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getImageAlignmentOffset;
		public virtual unsafe int ImageAlignmentOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getImageAlignmentOffset' and count(parameter)=0]"
			[Register ("getImageAlignmentOffset", "()I", "GetGetImageAlignmentOffsetHandler")]
			get {
				if (id_getImageAlignmentOffset == IntPtr.Zero)
					id_getImageAlignmentOffset = JNIEnv.GetMethodID (class_ref, "getImageAlignmentOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageAlignmentOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageAlignmentOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageEndOffset;
#pragma warning disable 0169
		static Delegate GetGetImageEndOffsetHandler ()
		{
			if (cb_getImageEndOffset == null)
				cb_getImageEndOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageEndOffset);
			return cb_getImageEndOffset;
		}

		static int n_GetImageEndOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageEndOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getImageEndOffset;
		public virtual unsafe int ImageEndOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getImageEndOffset' and count(parameter)=0]"
			[Register ("getImageEndOffset", "()I", "GetGetImageEndOffsetHandler")]
			get {
				if (id_getImageEndOffset == IntPtr.Zero)
					id_getImageEndOffset = JNIEnv.GetMethodID (class_ref, "getImageEndOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageEndOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageEndOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageStartOffset;
#pragma warning disable 0169
		static Delegate GetGetImageStartOffsetHandler ()
		{
			if (cb_getImageStartOffset == null)
				cb_getImageStartOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageStartOffset);
			return cb_getImageStartOffset;
		}

		static int n_GetImageStartOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageStartOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getImageStartOffset;
		public virtual unsafe int ImageStartOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getImageStartOffset' and count(parameter)=0]"
			[Register ("getImageStartOffset", "()I", "GetGetImageStartOffsetHandler")]
			get {
				if (id_getImageStartOffset == IntPtr.Zero)
					id_getImageStartOffset = JNIEnv.GetMethodID (class_ref, "getImageStartOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageStartOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageStartOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPictureEssenceCoding;
#pragma warning disable 0169
		static Delegate GetGetPictureEssenceCodingHandler ()
		{
			if (cb_getPictureEssenceCoding == null)
				cb_getPictureEssenceCoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPictureEssenceCoding);
			return cb_getPictureEssenceCoding;
		}

		static IntPtr n_GetPictureEssenceCoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PictureEssenceCoding);
		}
#pragma warning restore 0169

		static IntPtr id_getPictureEssenceCoding;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL PictureEssenceCoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getPictureEssenceCoding' and count(parameter)=0]"
			[Register ("getPictureEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetPictureEssenceCodingHandler")]
			get {
				if (id_getPictureEssenceCoding == IntPtr.Zero)
					id_getPictureEssenceCoding = JNIEnv.GetMethodID (class_ref, "getPictureEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPictureEssenceCoding), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPictureEssenceCoding", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSampledHeight;
#pragma warning disable 0169
		static Delegate GetGetSampledHeightHandler ()
		{
			if (cb_getSampledHeight == null)
				cb_getSampledHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampledHeight);
			return cb_getSampledHeight;
		}

		static int n_GetSampledHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampledHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getSampledHeight;
		public virtual unsafe int SampledHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getSampledHeight' and count(parameter)=0]"
			[Register ("getSampledHeight", "()I", "GetGetSampledHeightHandler")]
			get {
				if (id_getSampledHeight == IntPtr.Zero)
					id_getSampledHeight = JNIEnv.GetMethodID (class_ref, "getSampledHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampledHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampledHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampledWidth;
#pragma warning disable 0169
		static Delegate GetGetSampledWidthHandler ()
		{
			if (cb_getSampledWidth == null)
				cb_getSampledWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampledWidth);
			return cb_getSampledWidth;
		}

		static int n_GetSampledWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampledWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getSampledWidth;
		public virtual unsafe int SampledWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getSampledWidth' and count(parameter)=0]"
			[Register ("getSampledWidth", "()I", "GetGetSampledWidthHandler")]
			get {
				if (id_getSampledWidth == IntPtr.Zero)
					id_getSampledWidth = JNIEnv.GetMethodID (class_ref, "getSampledWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampledWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampledWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampledXOffset;
#pragma warning disable 0169
		static Delegate GetGetSampledXOffsetHandler ()
		{
			if (cb_getSampledXOffset == null)
				cb_getSampledXOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampledXOffset);
			return cb_getSampledXOffset;
		}

		static int n_GetSampledXOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampledXOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getSampledXOffset;
		public virtual unsafe int SampledXOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getSampledXOffset' and count(parameter)=0]"
			[Register ("getSampledXOffset", "()I", "GetGetSampledXOffsetHandler")]
			get {
				if (id_getSampledXOffset == IntPtr.Zero)
					id_getSampledXOffset = JNIEnv.GetMethodID (class_ref, "getSampledXOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampledXOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampledXOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampledYOffset;
#pragma warning disable 0169
		static Delegate GetGetSampledYOffsetHandler ()
		{
			if (cb_getSampledYOffset == null)
				cb_getSampledYOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampledYOffset);
			return cb_getSampledYOffset;
		}

		static int n_GetSampledYOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampledYOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getSampledYOffset;
		public virtual unsafe int SampledYOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getSampledYOffset' and count(parameter)=0]"
			[Register ("getSampledYOffset", "()I", "GetGetSampledYOffsetHandler")]
			get {
				if (id_getSampledYOffset == IntPtr.Zero)
					id_getSampledYOffset = JNIEnv.GetMethodID (class_ref, "getSampledYOffset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampledYOffset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampledYOffset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSignalStandard;
#pragma warning disable 0169
		static Delegate GetGetSignalStandardHandler ()
		{
			if (cb_getSignalStandard == null)
				cb_getSignalStandard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSignalStandard);
			return cb_getSignalStandard;
		}

		static sbyte n_GetSignalStandard (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SignalStandard;
		}
#pragma warning restore 0169

		static IntPtr id_getSignalStandard;
		public virtual unsafe sbyte SignalStandard {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getSignalStandard' and count(parameter)=0]"
			[Register ("getSignalStandard", "()B", "GetGetSignalStandardHandler")]
			get {
				if (id_getSignalStandard == IntPtr.Zero)
					id_getSignalStandard = JNIEnv.GetMethodID (class_ref, "getSignalStandard", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getSignalStandard);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignalStandard", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getStoredF2Offset;
#pragma warning disable 0169
		static Delegate GetGetStoredF2OffsetHandler ()
		{
			if (cb_getStoredF2Offset == null)
				cb_getStoredF2Offset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStoredF2Offset);
			return cb_getStoredF2Offset;
		}

		static int n_GetStoredF2Offset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StoredF2Offset;
		}
#pragma warning restore 0169

		static IntPtr id_getStoredF2Offset;
		public virtual unsafe int StoredF2Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getStoredF2Offset' and count(parameter)=0]"
			[Register ("getStoredF2Offset", "()I", "GetGetStoredF2OffsetHandler")]
			get {
				if (id_getStoredF2Offset == IntPtr.Zero)
					id_getStoredF2Offset = JNIEnv.GetMethodID (class_ref, "getStoredF2Offset", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStoredF2Offset);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStoredF2Offset", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStoredHeight;
#pragma warning disable 0169
		static Delegate GetGetStoredHeightHandler ()
		{
			if (cb_getStoredHeight == null)
				cb_getStoredHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStoredHeight);
			return cb_getStoredHeight;
		}

		static int n_GetStoredHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StoredHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getStoredHeight;
		public virtual unsafe int StoredHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getStoredHeight' and count(parameter)=0]"
			[Register ("getStoredHeight", "()I", "GetGetStoredHeightHandler")]
			get {
				if (id_getStoredHeight == IntPtr.Zero)
					id_getStoredHeight = JNIEnv.GetMethodID (class_ref, "getStoredHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStoredHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStoredHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getStoredWidth;
#pragma warning disable 0169
		static Delegate GetGetStoredWidthHandler ()
		{
			if (cb_getStoredWidth == null)
				cb_getStoredWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStoredWidth);
			return cb_getStoredWidth;
		}

		static int n_GetStoredWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StoredWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getStoredWidth;
		public virtual unsafe int StoredWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getStoredWidth' and count(parameter)=0]"
			[Register ("getStoredWidth", "()I", "GetGetStoredWidthHandler")]
			get {
				if (id_getStoredWidth == IntPtr.Zero)
					id_getStoredWidth = JNIEnv.GetMethodID (class_ref, "getStoredWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStoredWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStoredWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTransferCharacteristic;
#pragma warning disable 0169
		static Delegate GetGetTransferCharacteristicHandler ()
		{
			if (cb_getTransferCharacteristic == null)
				cb_getTransferCharacteristic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransferCharacteristic);
			return cb_getTransferCharacteristic;
		}

		static IntPtr n_GetTransferCharacteristic (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransferCharacteristic);
		}
#pragma warning restore 0169

		static IntPtr id_getTransferCharacteristic;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.UL TransferCharacteristic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getTransferCharacteristic' and count(parameter)=0]"
			[Register ("getTransferCharacteristic", "()Lorg/jcodec/containers/mxf/model/UL;", "GetGetTransferCharacteristicHandler")]
			get {
				if (id_getTransferCharacteristic == IntPtr.Zero)
					id_getTransferCharacteristic = JNIEnv.GetMethodID (class_ref, "getTransferCharacteristic", "()Lorg/jcodec/containers/mxf/model/UL;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransferCharacteristic), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.UL> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransferCharacteristic", "()Lorg/jcodec/containers/mxf/model/UL;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoLineMap;
#pragma warning disable 0169
		static Delegate GetGetVideoLineMapHandler ()
		{
			if (cb_getVideoLineMap == null)
				cb_getVideoLineMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoLineMap);
			return cb_getVideoLineMap;
		}

		static IntPtr n_GetVideoLineMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVideoLineMap ());
		}
#pragma warning restore 0169

		static IntPtr id_getVideoLineMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='GenericPictureEssenceDescriptor']/method[@name='getVideoLineMap' and count(parameter)=0]"
		[Register ("getVideoLineMap", "()[I", "GetGetVideoLineMapHandler")]
		public virtual unsafe int[] GetVideoLineMap ()
		{
			if (id_getVideoLineMap == IntPtr.Zero)
				id_getVideoLineMap = JNIEnv.GetMethodID (class_ref, "getVideoLineMap", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoLineMap), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoLineMap", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
