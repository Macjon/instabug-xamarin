using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/RationalLarge", DoNotGenerateAcw=true)]
	public partial class RationalLarge : global::Java.Lang.Object {


		static IntPtr HALF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/field[@name='HALF']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/field[@name='ONE']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/field[@name='ZERO']"
		[Register ("ZERO")]
		public static global::Org.Jcodec.Common.Model.RationalLarge Zero {
			get {
				if (ZERO_jfieldId == IntPtr.Zero)
					ZERO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZERO", "Lorg/jcodec/common/model/RationalLarge;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZERO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/RationalLarge", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RationalLarge); }
		}

		protected RationalLarge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/constructor[@name='RationalLarge' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe RationalLarge (long num, long den)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (num);
				__args [1] = new JValue (den);
				if (((object) this).GetType () != typeof (RationalLarge)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
					return;
				}

				if (id_ctor_JJ == IntPtr.Zero)
					id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
			} finally {
			}
		}

		static Delegate cb_getDen;
#pragma warning disable 0169
		static Delegate GetGetDenHandler ()
		{
			if (cb_getDen == null)
				cb_getDen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDen);
			return cb_getDen;
		}

		static long n_GetDen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Den;
		}
#pragma warning restore 0169

		static IntPtr id_getDen;
		public virtual unsafe long Den {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='getDen' and count(parameter)=0]"
			[Register ("getDen", "()J", "GetGetDenHandler")]
			get {
				if (id_getDen == IntPtr.Zero)
					id_getDen = JNIEnv.GetMethodID (class_ref, "getDen", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDen);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDen", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getNum;
#pragma warning disable 0169
		static Delegate GetGetNumHandler ()
		{
			if (cb_getNum == null)
				cb_getNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNum);
			return cb_getNum;
		}

		static long n_GetNum (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num;
		}
#pragma warning restore 0169

		static IntPtr id_getNum;
		public virtual unsafe long Num {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='getNum' and count(parameter)=0]"
			[Register ("getNum", "()J", "GetGetNumHandler")]
			get {
				if (id_getNum == IntPtr.Zero)
					id_getNum = JNIEnv.GetMethodID (class_ref, "getNum", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNum);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNum", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_R_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='R' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("R", "(J)Lorg/jcodec/common/model/RationalLarge;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.RationalLarge R (long num)
		{
			if (id_R_J == IntPtr.Zero)
				id_R_J = JNIEnv.GetStaticMethodID (class_ref, "R", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (num);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallStaticObjectMethod  (class_ref, id_R_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_R_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='R' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("R", "(JJ)Lorg/jcodec/common/model/RationalLarge;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.RationalLarge R (long num, long den)
		{
			if (id_R_JJ == IntPtr.Zero)
				id_R_JJ = JNIEnv.GetStaticMethodID (class_ref, "R", "(JJ)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (num);
				__args [1] = new JValue (den);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallStaticObjectMethod  (class_ref, id_R_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_divide_J;
#pragma warning disable 0169
		static Delegate GetDivide_JHandler ()
		{
			if (cb_divide_J == null)
				cb_divide_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Divide_J);
			return cb_divide_J;
		}

		static IntPtr n_Divide_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Divide (scalar));
		}
#pragma warning restore 0169

		static IntPtr id_divide_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("divide", "(J)Lorg/jcodec/common/model/RationalLarge;", "GetDivide_JHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Divide (long scalar)
		{
			if (id_divide_J == IntPtr.Zero)
				id_divide_J = JNIEnv.GetMethodID (class_ref, "divide", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(J)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Divide_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Divide (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divide_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;", "GetDivide_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Divide (global::Org.Jcodec.Common.Model.Rational other)
		{
			if (id_divide_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_divide_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Divide_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Divide (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divide_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetDivide_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Divide (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_divide_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_divide_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divide_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divideBy_J;
#pragma warning disable 0169
		static Delegate GetDivideBy_JHandler ()
		{
			if (cb_divideBy_J == null)
				cb_divideBy_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_DivideBy_J);
			return cb_divideBy_J;
		}

		static IntPtr n_DivideBy_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DivideBy (scalar));
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("divideBy", "(J)Lorg/jcodec/common/model/RationalLarge;", "GetDivideBy_JHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge DivideBy (long scalar)
		{
			if (id_divideBy_J == IntPtr.Zero)
				id_divideBy_J = JNIEnv.GetMethodID (class_ref, "divideBy", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(J)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_DivideBy_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DivideBy (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;", "GetDivideBy_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge DivideBy (global::Org.Jcodec.Common.Model.Rational other)
		{
			if (id_divideBy_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_divideBy_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_DivideBy_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DivideBy (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_divideBy_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divideBy' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetDivideBy_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge DivideBy (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_divideBy_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_divideBy_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_divideBy_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideBy", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_divideByS_J;
#pragma warning disable 0169
		static Delegate GetDivideByS_JHandler ()
		{
			if (cb_divideByS_J == null)
				cb_divideByS_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_DivideByS_J);
			return cb_divideByS_J;
		}

		static long n_DivideByS_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DivideByS (scalar);
		}
#pragma warning restore 0169

		static IntPtr id_divideByS_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divideByS' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("divideByS", "(J)J", "GetDivideByS_JHandler")]
		public virtual unsafe long DivideByS (long scalar)
		{
			if (id_divideByS_J == IntPtr.Zero)
				id_divideByS_J = JNIEnv.GetMethodID (class_ref, "divideByS", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_divideByS_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideByS", "(J)J"), __args);
			} finally {
			}
		}

		static Delegate cb_divideS_J;
#pragma warning disable 0169
		static Delegate GetDivideS_JHandler ()
		{
			if (cb_divideS_J == null)
				cb_divideS_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_DivideS_J);
			return cb_divideS_J;
		}

		static long n_DivideS_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DivideS (scalar);
		}
#pragma warning restore 0169

		static IntPtr id_divideS_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='divideS' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("divideS", "(J)J", "GetDivideS_JHandler")]
		public virtual unsafe long DivideS (long scalar)
		{
			if (id_divideS_J == IntPtr.Zero)
				id_divideS_J = JNIEnv.GetMethodID (class_ref, "divideS", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_divideS_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divideS", "(J)J"), __args);
			} finally {
			}
		}

		static Delegate cb_equals_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetEquals_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_equals_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_equals_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Lorg_jcodec_common_model_RationalLarge_);
			return cb_equals_Lorg_jcodec_common_model_RationalLarge_;
		}

		static bool n_Equals_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("equals", "(Lorg/jcodec/common/model/RationalLarge;)Z", "GetEquals_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe bool Equals (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_equals_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_equals_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "equals", "(Lorg/jcodec/common/model/RationalLarge;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Lorg_jcodec_common_model_RationalLarge_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Lorg/jcodec/common/model/RationalLarge;)Z"), __args);
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
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Flip ());
		}
#pragma warning restore 0169

		static IntPtr id_flip;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='flip' and count(parameter)=0]"
		[Register ("flip", "()Lorg/jcodec/common/model/RationalLarge;", "GetFlipHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Flip ()
		{
			if (id_flip == IntPtr.Zero)
				id_flip = JNIEnv.GetMethodID (class_ref, "flip", "()Lorg/jcodec/common/model/RationalLarge;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flip), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flip", "()Lorg/jcodec/common/model/RationalLarge;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetGreaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GreaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_);
			return cb_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
		}

		static bool n_GreaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sec)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge sec = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_sec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GreaterOrEqualTo (sec);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='greaterOrEqualTo' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("greaterOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z", "GetGreaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe bool GreaterOrEqualTo (global::Org.Jcodec.Common.Model.RationalLarge sec)
		{
			if (id_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "greaterOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sec);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_greaterOrEqualTo_Lorg_jcodec_common_model_RationalLarge_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "greaterOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_greaterThen_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetGreaterThen_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_greaterThen_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_greaterThen_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GreaterThen_Lorg_jcodec_common_model_RationalLarge_);
			return cb_greaterThen_Lorg_jcodec_common_model_RationalLarge_;
		}

		static bool n_GreaterThen_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sec)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge sec = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_sec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GreaterThen (sec);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_greaterThen_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='greaterThen' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("greaterThen", "(Lorg/jcodec/common/model/RationalLarge;)Z", "GetGreaterThen_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe bool GreaterThen (global::Org.Jcodec.Common.Model.RationalLarge sec)
		{
			if (id_greaterThen_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_greaterThen_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "greaterThen", "(Lorg/jcodec/common/model/RationalLarge;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sec);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_greaterThen_Lorg_jcodec_common_model_RationalLarge_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "greaterThen", "(Lorg/jcodec/common/model/RationalLarge;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_lessThen_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetLessThen_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_lessThen_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_lessThen_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LessThen_Lorg_jcodec_common_model_RationalLarge_);
			return cb_lessThen_Lorg_jcodec_common_model_RationalLarge_;
		}

		static bool n_LessThen_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sec)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge sec = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_sec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LessThen (sec);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_lessThen_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='lessThen' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("lessThen", "(Lorg/jcodec/common/model/RationalLarge;)Z", "GetLessThen_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe bool LessThen (global::Org.Jcodec.Common.Model.RationalLarge sec)
		{
			if (id_lessThen_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_lessThen_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "lessThen", "(Lorg/jcodec/common/model/RationalLarge;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sec);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_lessThen_Lorg_jcodec_common_model_RationalLarge_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "lessThen", "(Lorg/jcodec/common/model/RationalLarge;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_minus_J;
#pragma warning disable 0169
		static Delegate GetMinus_JHandler ()
		{
			if (cb_minus_J == null)
				cb_minus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Minus_J);
			return cb_minus_J;
		}

		static IntPtr n_Minus_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Minus (scalar));
		}
#pragma warning restore 0169

		static IntPtr id_minus_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("minus", "(J)Lorg/jcodec/common/model/RationalLarge;", "GetMinus_JHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Minus (long scalar)
		{
			if (id_minus_J == IntPtr.Zero)
				id_minus_J = JNIEnv.GetMethodID (class_ref, "minus", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(J)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Minus_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Minus (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minus_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;", "GetMinus_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Minus (global::Org.Jcodec.Common.Model.Rational other)
		{
			if (id_minus_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_minus_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Minus_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Minus (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minus_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='minus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetMinus_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Minus (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_minus_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_minus_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minus_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_multiply_J;
#pragma warning disable 0169
		static Delegate GetMultiply_JHandler ()
		{
			if (cb_multiply_J == null)
				cb_multiply_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Multiply_J);
			return cb_multiply_J;
		}

		static IntPtr n_Multiply_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Multiply (scalar));
		}
#pragma warning restore 0169

		static IntPtr id_multiply_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("multiply", "(J)Lorg/jcodec/common/model/RationalLarge;", "GetMultiply_JHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Multiply (long scalar)
		{
			if (id_multiply_J == IntPtr.Zero)
				id_multiply_J = JNIEnv.GetMethodID (class_ref, "multiply", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(J)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Multiply_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Multiply (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_multiply_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;", "GetMultiply_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Multiply (global::Org.Jcodec.Common.Model.Rational other)
		{
			if (id_multiply_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_multiply_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Multiply_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Multiply (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_multiply_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetMultiply_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Multiply (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_multiply_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_multiply_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_multiply_Lorg_jcodec_common_model_RationalLarge_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_multiplyS_J;
#pragma warning disable 0169
		static Delegate GetMultiplyS_JHandler ()
		{
			if (cb_multiplyS_J == null)
				cb_multiplyS_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_MultiplyS_J);
			return cb_multiplyS_J;
		}

		static long n_MultiplyS_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MultiplyS (scalar);
		}
#pragma warning restore 0169

		static IntPtr id_multiplyS_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='multiplyS' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("multiplyS", "(J)J", "GetMultiplyS_JHandler")]
		public virtual unsafe long MultiplyS (long scalar)
		{
			if (id_multiplyS_J == IntPtr.Zero)
				id_multiplyS_J = JNIEnv.GetMethodID (class_ref, "multiplyS", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_multiplyS_J, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiplyS", "(J)J"), __args);
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lorg/jcodec/common/model/Rational;", "")]
		public static unsafe global::Org.Jcodec.Common.Model.Rational Parse (string @string)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lorg/jcodec/common/model/Rational;");
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__string);
				global::Org.Jcodec.Common.Model.Rational __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		static Delegate cb_plus_J;
#pragma warning disable 0169
		static Delegate GetPlus_JHandler ()
		{
			if (cb_plus_J == null)
				cb_plus_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Plus_J);
			return cb_plus_J;
		}

		static IntPtr n_Plus_J (IntPtr jnienv, IntPtr native__this, long scalar)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Plus (scalar));
		}
#pragma warning restore 0169

		static IntPtr id_plus_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("plus", "(J)Lorg/jcodec/common/model/RationalLarge;", "GetPlus_JHandler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Plus (long scalar)
		{
			if (id_plus_J == IntPtr.Zero)
				id_plus_J = JNIEnv.GetMethodID (class_ref, "plus", "(J)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scalar);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_plus_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "plus", "(J)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Plus_Lorg_jcodec_common_model_Rational_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.Rational other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Plus (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_plus_Lorg_jcodec_common_model_Rational_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Rational']]"
		[Register ("plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;", "GetPlus_Lorg_jcodec_common_model_Rational_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Plus (global::Org.Jcodec.Common.Model.Rational other)
		{
			if (id_plus_Lorg_jcodec_common_model_Rational_ == IntPtr.Zero)
				id_plus_Lorg_jcodec_common_model_Rational_ = JNIEnv.GetMethodID (class_ref, "plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_plus_Lorg_jcodec_common_model_Rational_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "plus", "(Lorg/jcodec/common/model/Rational;)Lorg/jcodec/common/model/RationalLarge;"), __args), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_Plus_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge other = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Plus (other));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_plus_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='plus' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("plus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;", "GetPlus_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Plus (global::Org.Jcodec.Common.Model.RationalLarge other)
		{
			if (id_plus_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_plus_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "plus", "(Lorg/jcodec/common/model/RationalLarge;)Lorg/jcodec/common/model/RationalLarge;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);

				global::Org.Jcodec.Common.Model.RationalLarge __ret;
				if (((object) this).GetType () == ThresholdType)
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
				cb_scalar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Scalar);
			return cb_scalar;
		}

		static double n_Scalar (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scalar ();
		}
#pragma warning restore 0169

		static IntPtr id_scalar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='scalar' and count(parameter)=0]"
		[Register ("scalar", "()D", "GetScalarHandler")]
		public virtual unsafe double Scalar ()
		{
			if (id_scalar == IntPtr.Zero)
				id_scalar = JNIEnv.GetMethodID (class_ref, "scalar", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_scalar);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scalar", "()D"));
			} finally {
			}
		}

		static Delegate cb_scalarClip;
#pragma warning disable 0169
		static Delegate GetScalarClipHandler ()
		{
			if (cb_scalarClip == null)
				cb_scalarClip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ScalarClip);
			return cb_scalarClip;
		}

		static long n_ScalarClip (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalarClip ();
		}
#pragma warning restore 0169

		static IntPtr id_scalarClip;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='scalarClip' and count(parameter)=0]"
		[Register ("scalarClip", "()J", "GetScalarClipHandler")]
		public virtual unsafe long ScalarClip ()
		{
			if (id_scalarClip == IntPtr.Zero)
				id_scalarClip = JNIEnv.GetMethodID (class_ref, "scalarClip", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_scalarClip);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scalarClip", "()J"));
			} finally {
			}
		}

		static Delegate cb_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
#pragma warning disable 0169
		static Delegate GetSmallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_Handler ()
		{
			if (cb_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ == null)
				cb_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SmallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_);
			return cb_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
		}

		static bool n_SmallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sec)
		{
			global::Org.Jcodec.Common.Model.RationalLarge __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.RationalLarge sec = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (native_sec, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SmallerOrEqualTo (sec);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='RationalLarge']/method[@name='smallerOrEqualTo' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.RationalLarge']]"
		[Register ("smallerOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z", "GetSmallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_Handler")]
		public virtual unsafe bool SmallerOrEqualTo (global::Org.Jcodec.Common.Model.RationalLarge sec)
		{
			if (id_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ == IntPtr.Zero)
				id_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_ = JNIEnv.GetMethodID (class_ref, "smallerOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sec);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_smallerOrEqualTo_Lorg_jcodec_common_model_RationalLarge_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smallerOrEqualTo", "(Lorg/jcodec/common/model/RationalLarge;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
