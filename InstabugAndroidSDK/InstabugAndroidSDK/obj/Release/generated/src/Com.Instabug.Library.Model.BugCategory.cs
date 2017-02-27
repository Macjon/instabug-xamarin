using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/instabug/library/model/BugCategory", DoNotGenerateAcw=true)]
	public partial class BugCategory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/model/BugCategory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BugCategory); }
		}

		protected BugCategory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon);
			return cb_getIcon;
		}

		static int n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Icon;
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_I;
#pragma warning disable 0169
		static Delegate GetSetIcon_IHandler ()
		{
			if (cb_setIcon_I == null)
				cb_setIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIcon_I);
			return cb_setIcon_I;
		}

		static void n_SetIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Icon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		static IntPtr id_setIcon_I;
		public virtual unsafe int Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()I", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIcon);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIcon", "(I)V", "GetSetIcon_IHandler")]
			set {
				if (id_setIcon_I == IntPtr.Zero)
					id_setIcon_I = JNIEnv.GetMethodID (class_ref, "setIcon", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIcon_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(I)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.Model.BugCategory Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/model/BugCategory;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/model/BugCategory;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		static IntPtr id_setLabel_Ljava_lang_String_;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLabel", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_withIcon_I;
#pragma warning disable 0169
		static Delegate GetWithIcon_IHandler ()
		{
			if (cb_withIcon_I == null)
				cb_withIcon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_WithIcon_I);
			return cb_withIcon_I;
		}

		static IntPtr n_WithIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithIcon (p0));
		}
#pragma warning restore 0169

		static IntPtr id_withIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='withIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("withIcon", "(I)Lcom/instabug/library/model/BugCategory;", "GetWithIcon_IHandler")]
		public virtual unsafe global::Com.Instabug.Library.Model.BugCategory WithIcon (int p0)
		{
			if (id_withIcon_I == IntPtr.Zero)
				id_withIcon_I = JNIEnv.GetMethodID (class_ref, "withIcon", "(I)Lcom/instabug/library/model/BugCategory;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withIcon_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withIcon", "(I)Lcom/instabug/library/model/BugCategory;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithLabel_Ljava_lang_String_Handler ()
		{
			if (cb_withLabel_Ljava_lang_String_ == null)
				cb_withLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithLabel_Ljava_lang_String_);
			return cb_withLabel_Ljava_lang_String_;
		}

		static IntPtr n_WithLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Model.BugCategory __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithLabel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withLabel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.model']/class[@name='BugCategory']/method[@name='withLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withLabel", "(Ljava/lang/String;)Lcom/instabug/library/model/BugCategory;", "GetWithLabel_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Instabug.Library.Model.BugCategory WithLabel (string p0)
		{
			if (id_withLabel_Ljava_lang_String_ == IntPtr.Zero)
				id_withLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withLabel", "(Ljava/lang/String;)Lcom/instabug/library/model/BugCategory;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Instabug.Library.Model.BugCategory __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withLabel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Model.BugCategory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withLabel", "(Ljava/lang/String;)Lcom/instabug/library/model/BugCategory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
