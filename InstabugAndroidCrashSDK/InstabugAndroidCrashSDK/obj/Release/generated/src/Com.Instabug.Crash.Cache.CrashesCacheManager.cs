using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Crash.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']"
	[global::Android.Runtime.Register ("com/instabug/crash/cache/CrashesCacheManager", DoNotGenerateAcw=true)]
	public partial class CrashesCacheManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']/field[@name='CRASHES_DISK_CACHE_FILE_NAME']"
		[Register ("CRASHES_DISK_CACHE_FILE_NAME")]
		public const string CrashesDiskCacheFileName = (string) "/crashes.cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']/field[@name='CRASHES_DISK_CACHE_KEY']"
		[Register ("CRASHES_DISK_CACHE_KEY")]
		public const string CrashesDiskCacheKey = (string) "crashes_disk_cache";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']/field[@name='CRASHES_MEMORY_CACHE_KEY']"
		[Register ("CRASHES_MEMORY_CACHE_KEY")]
		public const string CrashesMemoryCacheKey = (string) "crashes_memory_cache";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/crash/cache/CrashesCacheManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CrashesCacheManager); }
		}

		protected CrashesCacheManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']/constructor[@name='CrashesCacheManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CrashesCacheManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CrashesCacheManager)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.crash.cache']/class[@name='CrashesCacheManager']/method[@name='saveCacheToDisk' and count(parameter)=0]"
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
