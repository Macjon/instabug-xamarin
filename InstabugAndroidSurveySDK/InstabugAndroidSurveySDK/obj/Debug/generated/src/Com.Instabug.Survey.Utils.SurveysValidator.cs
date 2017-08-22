using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']"
	[global::Android.Runtime.Register ("com/instabug/survey/utils/SurveysValidator", DoNotGenerateAcw=true)]
	public partial class SurveysValidator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_APP_VERSION']"
		[Register ("KEY_CONDITION_APP_VERSION")]
		public const string KeyConditionAppVersion = (string) "app_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_DATE']"
		[Register ("KEY_CONDITION_DATE")]
		public const string KeyConditionDate = (string) "date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_FIRST_SEEN']"
		[Register ("KEY_CONDITION_FIRST_SEEN")]
		public const string KeyConditionFirstSeen = (string) "first_seen";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_USER_EMAIL']"
		[Register ("KEY_CONDITION_USER_EMAIL")]
		public const string KeyConditionUserEmail = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_AND']"
		[Register ("KEY_OPERATOR_AND")]
		public const string KeyOperatorAnd = (string) "and";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_CONTAINS']"
		[Register ("KEY_OPERATOR_CONTAINS")]
		public const string KeyOperatorContains = (string) "contain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_EQUAL']"
		[Register ("KEY_OPERATOR_EQUAL")]
		public const string KeyOperatorEqual = (string) "equal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_GREATER_THAN']"
		[Register ("KEY_OPERATOR_GREATER_THAN")]
		public const string KeyOperatorGreaterThan = (string) "greater_than";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_LESS_THAN']"
		[Register ("KEY_OPERATOR_LESS_THAN")]
		public const string KeyOperatorLessThan = (string) "less_than";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_NOT_CONTAINS']"
		[Register ("KEY_OPERATOR_NOT_CONTAINS")]
		public const string KeyOperatorNotContains = (string) "not_contain";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_NOT_EQUAL']"
		[Register ("KEY_OPERATOR_NOT_EQUAL")]
		public const string KeyOperatorNotEqual = (string) "not_equal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_OR']"
		[Register ("KEY_OPERATOR_OR")]
		public const string KeyOperatorOr = (string) "or";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/utils/SurveysValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysValidator); }
		}

		protected SurveysValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/constructor[@name='SurveysValidator' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe SurveysValidator (string appVersion, string appVersionName)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_appVersion = JNIEnv.NewString (appVersion);
			IntPtr native_appVersionName = JNIEnv.NewString (appVersionName);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_appVersion);
				__args [1] = new JValue (native_appVersionName);
				if (((object) this).GetType () != typeof (SurveysValidator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appVersion);
				JNIEnv.DeleteLocalRef (native_appVersionName);
			}
		}

		static Delegate cb_hasValidSurveys;
#pragma warning disable 0169
		static Delegate GetHasValidSurveysHandler ()
		{
			if (cb_hasValidSurveys == null)
				cb_hasValidSurveys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasValidSurveys);
			return cb_hasValidSurveys;
		}

		static bool n_HasValidSurveys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Survey.Utils.SurveysValidator __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.Utils.SurveysValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasValidSurveys;
		}
#pragma warning restore 0169

		static IntPtr id_hasValidSurveys;
		public virtual unsafe bool HasValidSurveys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.utils']/class[@name='SurveysValidator']/method[@name='hasValidSurveys' and count(parameter)=0]"
			[Register ("hasValidSurveys", "()Z", "GetHasValidSurveysHandler")]
			get {
				if (id_hasValidSurveys == IntPtr.Zero)
					id_hasValidSurveys = JNIEnv.GetMethodID (class_ref, "hasValidSurveys", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasValidSurveys);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasValidSurveys", "()Z"));
				} finally {
				}
			}
		}

	}
}
