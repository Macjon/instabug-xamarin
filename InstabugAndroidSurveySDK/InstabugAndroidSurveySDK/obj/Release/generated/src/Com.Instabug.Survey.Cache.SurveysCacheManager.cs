using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']"
	[global::Android.Runtime.Register ("com/instabug/survey/cache/SurveysCacheManager", DoNotGenerateAcw=true)]
	public partial class SurveysCacheManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']/field[@name='SURVEYS_DISK_CACHE_FILE_NAME']"
		[Register ("SURVEYS_DISK_CACHE_FILE_NAME")]
		public const string SurveysDiskCacheFileName = (string) "/surveys.cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']/field[@name='SURVEYS_DISK_CACHE_KEY']"
		[Register ("SURVEYS_DISK_CACHE_KEY")]
		public const string SurveysDiskCacheKey = (string) "surveys_disk_cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']/field[@name='SURVEYS_MEMORY_CACHE_KEY']"
		[Register ("SURVEYS_MEMORY_CACHE_KEY")]
		public const string SurveysMemoryCacheKey = (string) "surveys_memory_cache";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/cache/SurveysCacheManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SurveysCacheManager); }
		}

		protected SurveysCacheManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']/constructor[@name='SurveysCacheManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveysCacheManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SurveysCacheManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static IntPtr id_saveCacheToDisk;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.cache']/class[@name='SurveysCacheManager']/method[@name='saveCacheToDisk' and count(parameter)=0]"
		[Register ("saveCacheToDisk", "()V", "")]
		public static unsafe void SaveCacheToDisk ()
		{
			if (id_saveCacheToDisk == IntPtr.Zero)
				id_saveCacheToDisk = JNIEnv.GetStaticMethodID (class_ref, "saveCacheToDisk", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_saveCacheToDisk);
			} finally {
			}
		}

	}
}
