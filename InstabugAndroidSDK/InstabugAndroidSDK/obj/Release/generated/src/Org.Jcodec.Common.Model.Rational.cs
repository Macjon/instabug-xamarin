using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Rational", DoNotGenerateAcw=true)]
	public partial class Rational : global::Java.Lang.Object {


		static IntPtr HALF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/field[@name='HALF']"
		[Register ("HALF")]
		public static global::Org.Jcodec.Common.Model.Rational Half {
			get {
				if (HALF_jfieldId == IntPtr.Zero)
					HALF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HALF", "Lorg/jcodec/common/model/Rational;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HALF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/field[@name='ONE']"
		[Register ("ONE")]
		public static global::Org.Jcodec.Common.Model.Rational One {
			get {
				if (ONE_jfieldId == IntPtr.Zero)
					ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE", "Lorg/jcodec/common/model/Rational;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ZERO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/field[@name='ZERO']"
		[Register ("ZERO")]
		public static global::Org.Jcodec.Common.Model.Rational Zero {
			get {
				if (ZERO_jfieldId == IntPtr.Zero)
					ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZERO", "Lorg/jcodec/common/model/Rational;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Rational", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rational); }
		}

		protected Rational (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/constructor[@name='Rational' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Rational (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Rational)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getDen;
#pragma warning disable 0169
		static Delegate GetGetDenHandler ()
		{
			if (cb_getDen == null)
				cb_getDen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDen);
			return cb_getDen;
		}

		static int n_GetDen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Den;
		}
#pragma warning restore 0169

		static IntPtr id_getDen;
		public virtual unsafe int Den {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='getDen' and count(parameter)=0]"
			[Register ("getDen", "()I", "GetGetDenHandler")]
			get {
				if (id_getDen == IntPtr.Zero)
					id_getDen = JNIEnv.GetMethodID (class_ref, "getDen", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDen);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDen", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getNum;
#pragma warning disable 0169
		static Delegate GetGetNumHandler ()
		{
			if (cb_getNum == null)
				cb_getNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum);
			return cb_getNum;
		}

		static int n_GetNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num;
		}
#pragma warning restore 0169

		static IntPtr id_getNum;
		public virtual unsafe int Num {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='getNum' and count(parameter)=0]"
			[Register ("getNum", "()I", "GetGetNumHandler")]
			get {
				if (id_getNum == IntPtr.Zero)
					id_getNum = JNIEnv.GetMethodID (class_ref, "getNum", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNum);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNum", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_R_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='R' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("R", "(I)Lorg/jcodec/common/model/Rational;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Rational R (int p0)
		{
			if (id_R_I == IntPtr.Zero)
				id_R_I = JNIEnv.GetStaticMethodID (class_ref, "R", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallStaticObjectMethod  (class_ref, id_R_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_R_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='R' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("R", "(II)Lorg/jcodec/common/model/Rational;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Rational R (int p0, int p1)
		{
			if (id_R_II == IntPtr.Zero)
				id_R_II = JNIEnv.GetStaticMethodID (class_ref, "R", "(II)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallStaticObjectMethod  (class_ref, id_R_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_divide_I;
#pragma warning disable 0169
		static Delegate GetDivide_IHandler ()
		{
			if (cb_divide_I == null)
				cb_divide_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Divide_I);
			return cb_divide_I;
		}

		static IntPtr n_Divide_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Divide (p0));
		}
#pragma warning restore 0169

		static IntPtr id_divide_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("divide", "(I)Lorg/jcodec/common/model/Rational;", "GetDivide_IHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Divide (int p0)
		{
			if (id_divide_I == IntPtr.Zero)
				id_divide_I = JNIEnv.GetMethodID (class_ref, "divide", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(I)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_divide_J;
#pragma warning disable 0169
		static Delegate GetDivide_JHandler ()
		{
			if (cb_divide_J == null)
				cb_divide_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_Divide_J);
			return cb_divide_J;
		}

		static long n_Divide_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Divide (p0);
		}
#pragma warning restore 0169

		static IntPtr id_divide_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("divide", "(J)J", "GetDivide_JHandler")]
		public virtual unsafe long Divide (long p0)
		{
			if (id_divide_J == IntPtr.Zero)
				id_divide_J = JNIEnv.GetMethodID (class_ref, "divide", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_divide_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(J)J"), __args);
			} finally {
			}
		}

		static Delegate cb_divide_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetDivide_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_divide_Lorg_jcodec_common_model_Rational_ == null)
				cb_divide_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Divide_Lorg_jcodec_common_model_Rational_);
			return cb_divide_Lorg_jcodec_common_model_Rational_;
		}

		static IntPtr n_Divide_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Divide (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divide_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;", "GetDivide_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Divide (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_divide_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_divide_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.Rational __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divide_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetDivide_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_divide_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_divide_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Divide_Lorg_jcodec_common_model_RationalLarge_);
			return cb_divide_Lorg_jcodec_common_model_RationalLarge_;
		}

		static IntPtr n_Divide_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Divide (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divide_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetDivide_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Divide (global::Org.Jcodec.Common.Model.RationalLarge p0)
		{
			if (id_divide_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_divide_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divideBy_I;
#pragma warning disable 0169
		static Delegate GetDivideBy_IHandler ()
		{
			if (cb_divideBy_I == null)
				cb_divideBy_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DivideBy_I);
			return cb_divideBy_I;
		}

		static IntPtr n_DivideBy_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DivideBy (p0));
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("divideBy", "(I)Lorg/jcodec/common/model/Rational;", "GetDivideBy_IHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational DivideBy (int p0)
		{
			if (id_divideBy_I == IntPtr.Zero)
				id_divideBy_I = JNIEnv.GetMethodID (class_ref, "divideBy", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(I)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_divideBy_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetDivideBy_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_divideBy_Lorg_jcodec_common_model_Rational_ == null)
				cb_divideBy_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DivideBy_Lorg_jcodec_common_model_Rational_);
			return cb_divideBy_Lorg_jcodec_common_model_Rational_;
		}

		static IntPtr n_DivideBy_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DivideBy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;", "GetDivideBy_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational DivideBy (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_divideBy_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_divideBy_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.Rational __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divideBy_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetDivideBy_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_divideBy_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_divideBy_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DivideBy_Lorg_jcodec_common_model_RationalLarge_);
			return cb_divideBy_Lorg_jcodec_common_model_RationalLarge_;
		}

		static IntPtr n_DivideBy_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DivideBy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetDivideBy_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge DivideBy (global::Org.Jcodec.Common.Model.RationalLarge p0)
		{
			if (id_divideBy_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_divideBy_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divideByS_I;
#pragma warning disable 0169
		static Delegate GetDivideByS_IHandler ()
		{
			if (cb_divideByS_I == null)
				cb_divideByS_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DivideByS_I);
			return cb_divideByS_I;
		}

		static int n_DivideByS_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DivideByS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_divideByS_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divideByS' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("divideByS", "(I)I", "GetDivideByS_IHandler")]
		public virtual unsafe int DivideByS (int p0)
		{
			if (id_divideByS_I == IntPtr.Zero)
				id_divideByS_I = JNIEnv.GetMethodID (class_ref, "divideByS", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_divideByS_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideByS", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_divideS_I;
#pragma warning disable 0169
		static Delegate GetDivideS_IHandler ()
		{
			if (cb_divideS_I == null)
				cb_divideS_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_DivideS_I);
			return cb_divideS_I;
		}

		static int n_DivideS_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DivideS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_divideS_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='divideS' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("divideS", "(I)I", "GetDivideS_IHandler")]
		public virtual unsafe int DivideS (int p0)
		{
			if (id_divideS_I == IntPtr.Zero)
				id_divideS_I = JNIEnv.GetMethodID (class_ref, "divideS", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_divideS_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideS", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_equals_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_equals_Lorg_jcodec_common_model_Rational_ == null)
				cb_equals_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Lorg_jcodec_common_model_Rational_);
			return cb_equals_Lorg_jcodec_common_model_Rational_;
		}

		static bool n_Equals_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("equals", "(Lorg/jcodec/common/model/Rational;)Z", "GetEquals_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe bool Equals (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_equals_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_equals_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lorg/jcodec/common/model/Rational;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lorg_jcodec_common_model_Rational_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Lorg/jcodec/common/model/Rational;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_flip;
#pragma warning disable 0169
		static Delegate GetFlipHandler ()
		{
			if (cb_flip == null)
				cb_flip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Flip);
			return cb_flip;
		}

		static IntPtr n_Flip (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Flip ());
		}
#pragma warning restore 0169

		static IntPtr id_flip;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='flip' and count(parameter)=0]"
		[Register ("flip", "()Lorg/jcodec/common/model/Rational;", "GetFlipHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Flip ()
		{
			if (id_flip == IntPtr.Zero)
				id_flip = JNIEnv.GetMethodID (class_ref, "flip", "()Lorg/jcodec/common/model/Rational;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flip), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flip", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetGreaterOrEqualTo_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_ == null)
				cb_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GreaterOrEqualTo_Lorg_jcodec_common_model_Rational_);
			return cb_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_;
		}

		static bool n_GreaterOrEqualTo_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GreaterOrEqualTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='greaterOrEqualTo' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("greaterOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z", "GetGreaterOrEqualTo_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe bool GreaterOrEqualTo (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "greaterOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_greaterOrEqualTo_Lorg_jcodec_common_model_Rational_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "greaterOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_greaterThen_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetGreaterThen_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_greaterThen_Lorg_jcodec_common_model_Rational_ == null)
				cb_greaterThen_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GreaterThen_Lorg_jcodec_common_model_Rational_);
			return cb_greaterThen_Lorg_jcodec_common_model_Rational_;
		}

		static bool n_GreaterThen_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GreaterThen (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_greaterThen_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='greaterThen' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("greaterThen", "(Lorg/jcodec/common/model/Rational;)Z", "GetGreaterThen_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe bool GreaterThen (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_greaterThen_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_greaterThen_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "greaterThen", "(Lorg/jcodec/common/model/Rational;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_greaterThen_Lorg_jcodec_common_model_Rational_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "greaterThen", "(Lorg/jcodec/common/model/Rational;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_minus_I;
#pragma warning disable 0169
		static Delegate GetMinus_IHandler ()
		{
			if (cb_minus_I == null)
				cb_minus_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Minus_I);
			return cb_minus_I;
		}

		static IntPtr n_Minus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Minus (p0));
		}
#pragma warning restore 0169

		static IntPtr id_minus_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("minus", "(I)Lorg/jcodec/common/model/Rational;", "GetMinus_IHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Minus (int p0)
		{
			if (id_minus_I == IntPtr.Zero)
				id_minus_I = JNIEnv.GetMethodID (class_ref, "minus", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(I)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_minus_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetMinus_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_minus_Lorg_jcodec_common_model_Rational_ == null)
				cb_minus_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Minus_Lorg_jcodec_common_model_Rational_);
			return cb_minus_Lorg_jcodec_common_model_Rational_;
		}

		static IntPtr n_Minus_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Minus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minus_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;", "GetMinus_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Minus (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_minus_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_minus_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.Rational __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_minus_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetMinus_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_minus_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_minus_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Minus_Lorg_jcodec_common_model_RationalLarge_);
			return cb_minus_Lorg_jcodec_common_model_RationalLarge_;
		}

		static IntPtr n_Minus_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Minus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minus_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetMinus_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Minus (global::Org.Jcodec.Common.Model.RationalLarge p0)
		{
			if (id_minus_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_minus_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_multiply_I;
#pragma warning disable 0169
		static Delegate GetMultiply_IHandler ()
		{
			if (cb_multiply_I == null)
				cb_multiply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Multiply_I);
			return cb_multiply_I;
		}

		static IntPtr n_Multiply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Multiply (p0));
		}
#pragma warning restore 0169

		static IntPtr id_multiply_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("multiply", "(I)Lorg/jcodec/common/model/Rational;", "GetMultiply_IHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Multiply (int p0)
		{
			if (id_multiply_I == IntPtr.Zero)
				id_multiply_I = JNIEnv.GetMethodID (class_ref, "multiply", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(I)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_multiply_J;
#pragma warning disable 0169
		static Delegate GetMultiply_JHandler ()
		{
			if (cb_multiply_J == null)
				cb_multiply_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_Multiply_J);
			return cb_multiply_J;
		}

		static long n_Multiply_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Multiply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_multiply_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("multiply", "(J)J", "GetMultiply_JHandler")]
		public virtual unsafe long Multiply (long p0)
		{
			if (id_multiply_J == IntPtr.Zero)
				id_multiply_J = JNIEnv.GetMethodID (class_ref, "multiply", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_multiply_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(J)J"), __args);
			} finally {
			}
		}

		static Delegate cb_multiply_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetMultiply_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_multiply_Lorg_jcodec_common_model_Rational_ == null)
				cb_multiply_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Multiply_Lorg_jcodec_common_model_Rational_);
			return cb_multiply_Lorg_jcodec_common_model_Rational_;
		}

		static IntPtr n_Multiply_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Multiply (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_multiply_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;", "GetMultiply_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Multiply (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_multiply_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_multiply_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.Rational __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_multiply_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetMultiply_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_multiply_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_multiply_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Multiply_Lorg_jcodec_common_model_RationalLarge_);
			return cb_multiply_Lorg_jcodec_common_model_RationalLarge_;
		}

		static IntPtr n_Multiply_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Multiply (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_multiply_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetMultiply_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Multiply (global::Org.Jcodec.Common.Model.RationalLarge p0)
		{
			if (id_multiply_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_multiply_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_multiplyS_I;
#pragma warning disable 0169
		static Delegate GetMultiplyS_IHandler ()
		{
			if (cb_multiplyS_I == null)
				cb_multiplyS_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MultiplyS_I);
			return cb_multiplyS_I;
		}

		static int n_MultiplyS_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiplyS (p0);
		}
#pragma warning restore 0169

		static IntPtr id_multiplyS_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='multiplyS' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("multiplyS", "(I)I", "GetMultiplyS_IHandler")]
		public virtual unsafe int MultiplyS (int p0)
		{
			if (id_multiplyS_I == IntPtr.Zero)
				id_multiplyS_I = JNIEnv.GetMethodID (class_ref, "multiplyS", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_multiplyS_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiplyS", "(I)I"), __args);
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lorg/jcodec/common/model/Rational;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Rational Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lorg/jcodec/common/model/Rational;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Common.Model.Rational __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_plus_I;
#pragma warning disable 0169
		static Delegate GetPlus_IHandler ()
		{
			if (cb_plus_I == null)
				cb_plus_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Plus_I);
			return cb_plus_I;
		}

		static IntPtr n_Plus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Plus (p0));
		}
#pragma warning restore 0169

		static IntPtr id_plus_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("plus", "(I)Lorg/jcodec/common/model/Rational;", "GetPlus_IHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Plus (int p0)
		{
			if (id_plus_I == IntPtr.Zero)
				id_plus_I = JNIEnv.GetMethodID (class_ref, "plus", "(I)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_plus_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "plus", "(I)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_plus_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetPlus_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_plus_Lorg_jcodec_common_model_Rational_ == null)
				cb_plus_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Plus_Lorg_jcodec_common_model_Rational_);
			return cb_plus_Lorg_jcodec_common_model_Rational_;
		}

		static IntPtr n_Plus_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Plus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_plus_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;", "GetPlus_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational Plus (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_plus_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_plus_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.Rational __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_plus_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/Rational;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_plus_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetPlus_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_plus_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_plus_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Plus_Lorg_jcodec_common_model_RationalLarge_);
			return cb_plus_Lorg_jcodec_common_model_RationalLarge_;
		}

		static IntPtr n_Plus_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Plus (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_plus_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("plus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetPlus_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Plus (global::Org.Jcodec.Common.Model.RationalLarge p0)
		{
			if (id_plus_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_plus_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "plus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_plus_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "plus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_scalar;
#pragma warning disable 0169
		static Delegate GetScalarHandler ()
		{
			if (cb_scalar == null)
				cb_scalar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Scalar);
			return cb_scalar;
		}

		static float n_Scalar (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scalar ();
		}
#pragma warning restore 0169

		static IntPtr id_scalar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='scalar' and count(parameter)=0]"
		[Register ("scalar", "()F", "GetScalarHandler")]
		public virtual unsafe float Scalar ()
		{
			if (id_scalar == IntPtr.Zero)
				id_scalar = JNIEnv.GetMethodID (class_ref, "scalar", "()F");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_scalar);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scalar", "()F"));
			} finally {
			}
		}

		static Delegate cb_scalarClip;
#pragma warning disable 0169
		static Delegate GetScalarClipHandler ()
		{
			if (cb_scalarClip == null)
				cb_scalarClip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ScalarClip);
			return cb_scalarClip;
		}

		static int n_ScalarClip (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalarClip ();
		}
#pragma warning restore 0169

		static IntPtr id_scalarClip;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='scalarClip' and count(parameter)=0]"
		[Register ("scalarClip", "()I", "GetScalarClipHandler")]
		public virtual unsafe int ScalarClip ()
		{
			if (id_scalarClip == IntPtr.Zero)
				id_scalarClip = JNIEnv.GetMethodID (class_ref, "scalarClip", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_scalarClip);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scalarClip", "()I"));
			} finally {
			}
		}

		static Delegate cb_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetSmallerOrEqualTo_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_ == null)
				cb_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SmallerOrEqualTo_Lorg_jcodec_common_model_Rational_);
			return cb_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_;
		}

		static bool n_SmallerOrEqualTo_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SmallerOrEqualTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='smallerOrEqualTo' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("smallerOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z", "GetSmallerOrEqualTo_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe bool SmallerOrEqualTo (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "smallerOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_smallerOrEqualTo_Lorg_jcodec_common_model_Rational_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smallerOrEqualTo", "(Lorg/jcodec/common/model/Rational;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_smallerThen_Lorg_jcodec_common_model_Rational_;
#pragma warning disable 0169
		static Delegate GetSmallerThen_Lorg_jcodec_common_model_Rational_Handler ()
		{
			if (cb_smallerThen_Lorg_jcodec_common_model_Rational_ == null)
				cb_smallerThen_Lorg_jcodec_common_model_Rational_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SmallerThen_Lorg_jcodec_common_model_Rational_);
			return cb_smallerThen_Lorg_jcodec_common_model_Rational_;
		}

		static bool n_SmallerThen_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Rational __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SmallerThen (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_smallerThen_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Rational']/method[@name='smallerThen' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("smallerThen", "(Lorg/jcodec/common/model/Rational;)Z", "GetSmallerThen_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe bool SmallerThen (global::Org.Jcodec.Common.Model.Rational p0)
		{
			if (id_smallerThen_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_smallerThen_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "smallerThen", "(Lorg/jcodec/common/model/Rational;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_smallerThen_Lorg_jcodec_common_model_Rational_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smallerThen", "(Lorg/jcodec/common/model/Rational;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
