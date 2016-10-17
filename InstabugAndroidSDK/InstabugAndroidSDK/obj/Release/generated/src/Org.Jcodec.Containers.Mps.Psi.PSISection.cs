using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mps.Psi {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mps/psi/PSISection", DoNotGenerateAcw=true)]
	public partial class PSISection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mps/psi/PSISection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PSISection); }
		}

		protected PSISection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/constructor[@name='PSISection' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mps.psi.PSISection']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mps/psi/PSISection;)V", "")]
		public unsafe PSISection (global::Org.Jcodec.Containers.Mps.Psi.PSISection p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PSISection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/containers/mps/psi/PSISection;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mps/psi/PSISection;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mps/psi/PSISection;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mps_psi_PSISection_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_IIIIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/constructor[@name='PSISection' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(IIIIII)V", "")]
		public unsafe PSISection (int p0, int p1, int p2, int p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (PSISection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIIII)V", __args);
					return;
				}

				if (id_ctor_IIIIII == IntPtr.Zero)
					id_ctor_IIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIIII, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentNextIndicator;
#pragma warning disable 0169
		static Delegate GetGetCurrentNextIndicatorHandler ()
		{
			if (cb_getCurrentNextIndicator == null)
				cb_getCurrentNextIndicator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentNextIndicator);
			return cb_getCurrentNextIndicator;
		}

		static int n_GetCurrentNextIndicator (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentNextIndicator;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentNextIndicator;
		public virtual unsafe int CurrentNextIndicator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getCurrentNextIndicator' and count(parameter)=0]"
			[Register ("getCurrentNextIndicator", "()I", "GetGetCurrentNextIndicatorHandler")]
			get {
				if (id_getCurrentNextIndicator == IntPtr.Zero)
					id_getCurrentNextIndicator = JNIEnv.GetMethodID (class_ref, "getCurrentNextIndicator", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentNextIndicator);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentNextIndicator", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastSectionNumber;
#pragma warning disable 0169
		static Delegate GetGetLastSectionNumberHandler ()
		{
			if (cb_getLastSectionNumber == null)
				cb_getLastSectionNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastSectionNumber);
			return cb_getLastSectionNumber;
		}

		static int n_GetLastSectionNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSectionNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSectionNumber;
		public virtual unsafe int LastSectionNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getLastSectionNumber' and count(parameter)=0]"
			[Register ("getLastSectionNumber", "()I", "GetGetLastSectionNumberHandler")]
			get {
				if (id_getLastSectionNumber == IntPtr.Zero)
					id_getLastSectionNumber = JNIEnv.GetMethodID (class_ref, "getLastSectionNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastSectionNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSectionNumber", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSectionNumber;
#pragma warning disable 0169
		static Delegate GetGetSectionNumberHandler ()
		{
			if (cb_getSectionNumber == null)
				cb_getSectionNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSectionNumber);
			return cb_getSectionNumber;
		}

		static int n_GetSectionNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SectionNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getSectionNumber;
		public virtual unsafe int SectionNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getSectionNumber' and count(parameter)=0]"
			[Register ("getSectionNumber", "()I", "GetGetSectionNumberHandler")]
			get {
				if (id_getSectionNumber == IntPtr.Zero)
					id_getSectionNumber = JNIEnv.GetMethodID (class_ref, "getSectionNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSectionNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSectionNumber", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSpecificId;
#pragma warning disable 0169
		static Delegate GetGetSpecificIdHandler ()
		{
			if (cb_getSpecificId == null)
				cb_getSpecificId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSpecificId);
			return cb_getSpecificId;
		}

		static int n_GetSpecificId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpecificId;
		}
#pragma warning restore 0169

		static IntPtr id_getSpecificId;
		public virtual unsafe int SpecificId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getSpecificId' and count(parameter)=0]"
			[Register ("getSpecificId", "()I", "GetGetSpecificIdHandler")]
			get {
				if (id_getSpecificId == IntPtr.Zero)
					id_getSpecificId = JNIEnv.GetMethodID (class_ref, "getSpecificId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSpecificId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpecificId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTableId;
#pragma warning disable 0169
		static Delegate GetGetTableIdHandler ()
		{
			if (cb_getTableId == null)
				cb_getTableId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTableId);
			return cb_getTableId;
		}

		static int n_GetTableId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TableId;
		}
#pragma warning restore 0169

		static IntPtr id_getTableId;
		public virtual unsafe int TableId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getTableId' and count(parameter)=0]"
			[Register ("getTableId", "()I", "GetGetTableIdHandler")]
			get {
				if (id_getTableId == IntPtr.Zero)
					id_getTableId = JNIEnv.GetMethodID (class_ref, "getTableId", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTableId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTableId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVersionNumber;
#pragma warning disable 0169
		static Delegate GetGetVersionNumberHandler ()
		{
			if (cb_getVersionNumber == null)
				cb_getVersionNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersionNumber);
			return cb_getVersionNumber;
		}

		static int n_GetVersionNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mps.Psi.PSISection __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VersionNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getVersionNumber;
		public virtual unsafe int VersionNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='getVersionNumber' and count(parameter)=0]"
			[Register ("getVersionNumber", "()I", "GetGetVersionNumberHandler")]
			get {
				if (id_getVersionNumber == IntPtr.Zero)
					id_getVersionNumber = JNIEnv.GetMethodID (class_ref, "getVersionNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVersionNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersionNumber", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_parse_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mps.psi']/class[@name='PSISection']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PSISection;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mps.Psi.PSISection Parse (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parse_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parse_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mps/psi/PSISection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mps.Psi.PSISection __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mps.Psi.PSISection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
