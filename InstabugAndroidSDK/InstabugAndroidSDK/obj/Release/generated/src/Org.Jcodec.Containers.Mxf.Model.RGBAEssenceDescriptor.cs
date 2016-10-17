using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/RGBAEssenceDescriptor", DoNotGenerateAcw=true)]
	public partial class RGBAEssenceDescriptor : global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/RGBAEssenceDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RGBAEssenceDescriptor); }
		}

		protected RGBAEssenceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/constructor[@name='RGBAEssenceDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe RGBAEssenceDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RGBAEssenceDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
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

		static Delegate cb_getAlphaMaxRef;
#pragma warning disable 0169
		static Delegate GetGetAlphaMaxRefHandler ()
		{
			if (cb_getAlphaMaxRef == null)
				cb_getAlphaMaxRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlphaMaxRef);
			return cb_getAlphaMaxRef;
		}

		static int n_GetAlphaMaxRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaMaxRef;
		}
#pragma warning restore 0169

		static IntPtr id_getAlphaMaxRef;
		public virtual unsafe int AlphaMaxRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getAlphaMaxRef' and count(parameter)=0]"
			[Register ("getAlphaMaxRef", "()I", "GetGetAlphaMaxRefHandler")]
			get {
				if (id_getAlphaMaxRef == IntPtr.Zero)
					id_getAlphaMaxRef = JNIEnv.GetMethodID (class_ref, "getAlphaMaxRef", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlphaMaxRef);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlphaMaxRef", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAlphaMinRef;
#pragma warning disable 0169
		static Delegate GetGetAlphaMinRefHandler ()
		{
			if (cb_getAlphaMinRef == null)
				cb_getAlphaMinRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlphaMinRef);
			return cb_getAlphaMinRef;
		}

		static int n_GetAlphaMinRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaMinRef;
		}
#pragma warning restore 0169

		static IntPtr id_getAlphaMinRef;
		public virtual unsafe int AlphaMinRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getAlphaMinRef' and count(parameter)=0]"
			[Register ("getAlphaMinRef", "()I", "GetGetAlphaMinRefHandler")]
			get {
				if (id_getAlphaMinRef == IntPtr.Zero)
					id_getAlphaMinRef = JNIEnv.GetMethodID (class_ref, "getAlphaMinRef", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlphaMinRef);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlphaMinRef", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getComponentMaxRef;
#pragma warning disable 0169
		static Delegate GetGetComponentMaxRefHandler ()
		{
			if (cb_getComponentMaxRef == null)
				cb_getComponentMaxRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComponentMaxRef);
			return cb_getComponentMaxRef;
		}

		static int n_GetComponentMaxRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComponentMaxRef;
		}
#pragma warning restore 0169

		static IntPtr id_getComponentMaxRef;
		public virtual unsafe int ComponentMaxRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getComponentMaxRef' and count(parameter)=0]"
			[Register ("getComponentMaxRef", "()I", "GetGetComponentMaxRefHandler")]
			get {
				if (id_getComponentMaxRef == IntPtr.Zero)
					id_getComponentMaxRef = JNIEnv.GetMethodID (class_ref, "getComponentMaxRef", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getComponentMaxRef);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComponentMaxRef", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getComponentMinRef;
#pragma warning disable 0169
		static Delegate GetGetComponentMinRefHandler ()
		{
			if (cb_getComponentMinRef == null)
				cb_getComponentMinRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComponentMinRef);
			return cb_getComponentMinRef;
		}

		static int n_GetComponentMinRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComponentMinRef;
		}
#pragma warning restore 0169

		static IntPtr id_getComponentMinRef;
		public virtual unsafe int ComponentMinRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getComponentMinRef' and count(parameter)=0]"
			[Register ("getComponentMinRef", "()I", "GetGetComponentMinRefHandler")]
			get {
				if (id_getComponentMinRef == IntPtr.Zero)
					id_getComponentMinRef = JNIEnv.GetMethodID (class_ref, "getComponentMinRef", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getComponentMinRef);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComponentMinRef", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPalette;
#pragma warning disable 0169
		static Delegate GetGetPaletteHandler ()
		{
			if (cb_getPalette == null)
				cb_getPalette = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPalette);
			return cb_getPalette;
		}

		static IntPtr n_GetPalette (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Palette);
		}
#pragma warning restore 0169

		static IntPtr id_getPalette;
		public virtual unsafe global::Java.Nio.ByteBuffer Palette {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getPalette' and count(parameter)=0]"
			[Register ("getPalette", "()Ljava/nio/ByteBuffer;", "GetGetPaletteHandler")]
			get {
				if (id_getPalette == IntPtr.Zero)
					id_getPalette = JNIEnv.GetMethodID (class_ref, "getPalette", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalette), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPalette", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaletteLayout;
#pragma warning disable 0169
		static Delegate GetGetPaletteLayoutHandler ()
		{
			if (cb_getPaletteLayout == null)
				cb_getPaletteLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaletteLayout);
			return cb_getPaletteLayout;
		}

		static IntPtr n_GetPaletteLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaletteLayout);
		}
#pragma warning restore 0169

		static IntPtr id_getPaletteLayout;
		public virtual unsafe global::Java.Nio.ByteBuffer PaletteLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getPaletteLayout' and count(parameter)=0]"
			[Register ("getPaletteLayout", "()Ljava/nio/ByteBuffer;", "GetGetPaletteLayoutHandler")]
			get {
				if (id_getPaletteLayout == IntPtr.Zero)
					id_getPaletteLayout = JNIEnv.GetMethodID (class_ref, "getPaletteLayout", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaletteLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaletteLayout", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPixelLayout;
#pragma warning disable 0169
		static Delegate GetGetPixelLayoutHandler ()
		{
			if (cb_getPixelLayout == null)
				cb_getPixelLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPixelLayout);
			return cb_getPixelLayout;
		}

		static IntPtr n_GetPixelLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PixelLayout);
		}
#pragma warning restore 0169

		static IntPtr id_getPixelLayout;
		public virtual unsafe global::Java.Nio.ByteBuffer PixelLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getPixelLayout' and count(parameter)=0]"
			[Register ("getPixelLayout", "()Ljava/nio/ByteBuffer;", "GetGetPixelLayoutHandler")]
			get {
				if (id_getPixelLayout == IntPtr.Zero)
					id_getPixelLayout = JNIEnv.GetMethodID (class_ref, "getPixelLayout", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPixelLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelLayout", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScanningDirection;
#pragma warning disable 0169
		static Delegate GetGetScanningDirectionHandler ()
		{
			if (cb_getScanningDirection == null)
				cb_getScanningDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetScanningDirection);
			return cb_getScanningDirection;
		}

		static sbyte n_GetScanningDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.RGBAEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScanningDirection;
		}
#pragma warning restore 0169

		static IntPtr id_getScanningDirection;
		public virtual unsafe sbyte ScanningDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='RGBAEssenceDescriptor']/method[@name='getScanningDirection' and count(parameter)=0]"
			[Register ("getScanningDirection", "()B", "GetGetScanningDirectionHandler")]
			get {
				if (id_getScanningDirection == IntPtr.Zero)
					id_getScanningDirection = JNIEnv.GetMethodID (class_ref, "getScanningDirection", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getScanningDirection);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScanningDirection", "()B"));
				} finally {
				}
			}
		}

	}
}
