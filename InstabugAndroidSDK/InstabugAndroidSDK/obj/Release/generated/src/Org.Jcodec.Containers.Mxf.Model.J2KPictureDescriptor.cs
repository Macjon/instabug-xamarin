using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/J2KPictureDescriptor", DoNotGenerateAcw=true)]
	public partial class J2KPictureDescriptor : global::Org.Jcodec.Containers.Mxf.Model.MXFInterchangeObject {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/J2KPictureDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (J2KPictureDescriptor); }
		}

		protected J2KPictureDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/constructor[@name='J2KPictureDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe J2KPictureDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (J2KPictureDescriptor)) {
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

		static Delegate cb_getCsiz;
#pragma warning disable 0169
		static Delegate GetGetCsizHandler ()
		{
			if (cb_getCsiz == null)
				cb_getCsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetCsiz);
			return cb_getCsiz;
		}

		static short n_GetCsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Csiz;
		}
#pragma warning restore 0169

		static IntPtr id_getCsiz;
		public virtual unsafe short Csiz {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getCsiz' and count(parameter)=0]"
			[Register ("getCsiz", "()S", "GetGetCsizHandler")]
			get {
				if (id_getCsiz == IntPtr.Zero)
					id_getCsiz = JNIEnv.GetMethodID (class_ref, "getCsiz", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getCsiz);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCsiz", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getRsiz;
#pragma warning disable 0169
		static Delegate GetGetRsizHandler ()
		{
			if (cb_getRsiz == null)
				cb_getRsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetRsiz);
			return cb_getRsiz;
		}

		static short n_GetRsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rsiz;
		}
#pragma warning restore 0169

		static IntPtr id_getRsiz;
		public virtual unsafe short Rsiz {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getRsiz' and count(parameter)=0]"
			[Register ("getRsiz", "()S", "GetGetRsizHandler")]
			get {
				if (id_getRsiz == IntPtr.Zero)
					id_getRsiz = JNIEnv.GetMethodID (class_ref, "getRsiz", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getRsiz);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRsiz", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getXsiz;
#pragma warning disable 0169
		static Delegate GetGetXsizHandler ()
		{
			if (cb_getXsiz == null)
				cb_getXsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXsiz);
			return cb_getXsiz;
		}

		static int n_GetXsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Xsiz;
		}
#pragma warning restore 0169

		static IntPtr id_getXsiz;
		public virtual unsafe int Xsiz {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getXsiz' and count(parameter)=0]"
			[Register ("getXsiz", "()I", "GetGetXsizHandler")]
			get {
				if (id_getXsiz == IntPtr.Zero)
					id_getXsiz = JNIEnv.GetMethodID (class_ref, "getXsiz", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getXsiz);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXsiz", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getYsiz;
#pragma warning disable 0169
		static Delegate GetGetYsizHandler ()
		{
			if (cb_getYsiz == null)
				cb_getYsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYsiz);
			return cb_getYsiz;
		}

		static int n_GetYsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ysiz;
		}
#pragma warning restore 0169

		static IntPtr id_getYsiz;
		public virtual unsafe int Ysiz {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getYsiz' and count(parameter)=0]"
			[Register ("getYsiz", "()I", "GetGetYsizHandler")]
			get {
				if (id_getYsiz == IntPtr.Zero)
					id_getYsiz = JNIEnv.GetMethodID (class_ref, "getYsiz", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getYsiz);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYsiz", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getxOsiz;
#pragma warning disable 0169
		static Delegate GetGetxOsizHandler ()
		{
			if (cb_getxOsiz == null)
				cb_getxOsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetxOsiz);
			return cb_getxOsiz;
		}

		static int n_GetxOsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetxOsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getxOsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getxOsiz' and count(parameter)=0]"
		[Register ("getxOsiz", "()I", "GetGetxOsizHandler")]
		public virtual unsafe int GetxOsiz ()
		{
			if (id_getxOsiz == IntPtr.Zero)
				id_getxOsiz = JNIEnv.GetMethodID (class_ref, "getxOsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getxOsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getxOsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_getxTOsiz;
#pragma warning disable 0169
		static Delegate GetGetxTOsizHandler ()
		{
			if (cb_getxTOsiz == null)
				cb_getxTOsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetxTOsiz);
			return cb_getxTOsiz;
		}

		static int n_GetxTOsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetxTOsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getxTOsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getxTOsiz' and count(parameter)=0]"
		[Register ("getxTOsiz", "()I", "GetGetxTOsizHandler")]
		public virtual unsafe int GetxTOsiz ()
		{
			if (id_getxTOsiz == IntPtr.Zero)
				id_getxTOsiz = JNIEnv.GetMethodID (class_ref, "getxTOsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getxTOsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getxTOsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_getxTsiz;
#pragma warning disable 0169
		static Delegate GetGetxTsizHandler ()
		{
			if (cb_getxTsiz == null)
				cb_getxTsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetxTsiz);
			return cb_getxTsiz;
		}

		static int n_GetxTsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetxTsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getxTsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getxTsiz' and count(parameter)=0]"
		[Register ("getxTsiz", "()I", "GetGetxTsizHandler")]
		public virtual unsafe int GetxTsiz ()
		{
			if (id_getxTsiz == IntPtr.Zero)
				id_getxTsiz = JNIEnv.GetMethodID (class_ref, "getxTsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getxTsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getxTsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_getyOsiz;
#pragma warning disable 0169
		static Delegate GetGetyOsizHandler ()
		{
			if (cb_getyOsiz == null)
				cb_getyOsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetyOsiz);
			return cb_getyOsiz;
		}

		static int n_GetyOsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetyOsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getyOsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getyOsiz' and count(parameter)=0]"
		[Register ("getyOsiz", "()I", "GetGetyOsizHandler")]
		public virtual unsafe int GetyOsiz ()
		{
			if (id_getyOsiz == IntPtr.Zero)
				id_getyOsiz = JNIEnv.GetMethodID (class_ref, "getyOsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getyOsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getyOsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_getyTOsiz;
#pragma warning disable 0169
		static Delegate GetGetyTOsizHandler ()
		{
			if (cb_getyTOsiz == null)
				cb_getyTOsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetyTOsiz);
			return cb_getyTOsiz;
		}

		static int n_GetyTOsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetyTOsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getyTOsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getyTOsiz' and count(parameter)=0]"
		[Register ("getyTOsiz", "()I", "GetGetyTOsizHandler")]
		public virtual unsafe int GetyTOsiz ()
		{
			if (id_getyTOsiz == IntPtr.Zero)
				id_getyTOsiz = JNIEnv.GetMethodID (class_ref, "getyTOsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getyTOsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getyTOsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_getyTsiz;
#pragma warning disable 0169
		static Delegate GetGetyTsizHandler ()
		{
			if (cb_getyTsiz == null)
				cb_getyTsiz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetyTsiz);
			return cb_getyTsiz;
		}

		static int n_GetyTsiz (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetyTsiz ();
		}
#pragma warning restore 0169

		static IntPtr id_getyTsiz;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='getyTsiz' and count(parameter)=0]"
		[Register ("getyTsiz", "()I", "GetGetyTsizHandler")]
		public virtual unsafe int GetyTsiz ()
		{
			if (id_getyTsiz == IntPtr.Zero)
				id_getyTsiz = JNIEnv.GetMethodID (class_ref, "getyTsiz", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getyTsiz);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getyTsiz", "()I"));
			} finally {
			}
		}

		static Delegate cb_read_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_util_Map_Handler ()
		{
			if (cb_read_Ljava_util_Map_ == null)
				cb_read_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Read_Ljava_util_Map_);
			return cb_read_Ljava_util_Map_;
		}

		static void n_Read_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.J2KPictureDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0);
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='J2KPictureDescriptor']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, java.nio.ByteBuffer&gt;']]"
		[Register ("read", "(Ljava/util/Map;)V", "GetRead_Ljava_util_Map_Handler")]
		protected override unsafe void Read (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer> p0)
		{
			if (id_read_Ljava_util_Map_ == IntPtr.Zero)
				id_read_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Java.Nio.ByteBuffer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
