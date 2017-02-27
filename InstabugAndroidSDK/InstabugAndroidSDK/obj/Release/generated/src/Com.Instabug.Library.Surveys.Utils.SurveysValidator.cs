using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Surveys.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']"
	[global::Android.Runtime.Register ("com/instabug/library/surveys/utils/SurveysValidator", DoNotGenerateAcw=true)]
	public partial class SurveysValidator : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_APP_VERSION']"
		[Register ("KEY_CONDITION_APP_VERSION")]
		public const string KeyConditionAppVersion = (string) "app_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_DATE']"
		[Register ("KEY_CONDITION_DATE")]
		public const string KeyConditionDate = (string) "date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_FIRST_SEEN']"
		[Register ("KEY_CONDITION_FIRST_SEEN")]
		public const string KeyConditionFirstSeen = (string) "first_seen";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_CONDITION_USER_EMAIL']"
		[Register ("KEY_CONDITION_USER_EMAIL")]
		public const string KeyConditionUserEmail = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_AND']"
		[Register ("KEY_OPERATOR_AND")]
		public const string KeyOperatorAnd = (string) "and";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_CONTAINS']"
		[Register ("KEY_OPERATOR_CONTAINS")]
		public const string KeyOperatorContains = (string) "contains";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_EQUAL']"
		[Register ("KEY_OPERATOR_EQUAL")]
		public const string KeyOperatorEqual = (string) "equal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_GREATER_THAN']"
		[Register ("KEY_OPERATOR_GREATER_THAN")]
		public const string KeyOperatorGreaterThan = (string) "greater_than";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_LESS_THAN']"
		[Register ("KEY_OPERATOR_LESS_THAN")]
		public const string KeyOperatorLessThan = (string) "less_than";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_NOT_CONTAINS']"
		[Register ("KEY_OPERATOR_NOT_CONTAINS")]
		public const string KeyOperatorNotContains = (string) "not_contains";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_NOT_EQUAL']"
		[Register ("KEY_OPERATOR_NOT_EQUAL")]
		public const string KeyOperatorNotEqual = (string) "not_equal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.surveys.utils']/class[@name='SurveysValidator']/field[@name='KEY_OPERATOR_OR']"
		[Register ("KEY_OPERATOR_OR")]
		public const string KeyOperatorOr = (string) "or";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/surveys/utils/SurveysValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysValidator); }
		}

		protected SurveysValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
