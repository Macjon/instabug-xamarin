using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Storage.Cache.DB {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='DatabaseManager']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/DatabaseManager", DoNotGenerateAcw=true)]
	public partial class DatabaseManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/internal/storage/cache/db/DatabaseManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatabaseManager); }
		}

		protected DatabaseManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='DatabaseManager']/constructor[@name='DatabaseManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DatabaseManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DatabaseManager)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Instabug.Library.Internal.Storage.Cache.DB.DatabaseManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='DatabaseManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/instabug/library/internal/storage/cache/db/DatabaseManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/instabug/library/internal/storage/cache/db/DatabaseManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.DatabaseManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_init_Landroid_database_sqlite_SQLiteOpenHelper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='DatabaseManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteOpenHelper']]"
		[Register ("init", "(Landroid/database/sqlite/SQLiteOpenHelper;)V", "")]
		public static unsafe void Init (global::Android.Database.Sqlite.SQLiteOpenHelper p0)
		{
			if (id_init_Landroid_database_sqlite_SQLiteOpenHelper_ == IntPtr.Zero)
				id_init_Landroid_database_sqlite_SQLiteOpenHelper_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/database/sqlite/SQLiteOpenHelper;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_database_sqlite_SQLiteOpenHelper_, __args);
			} finally {
			}
		}

		static Delegate cb_openDatabase;
#pragma warning disable 0169
		static Delegate GetOpenDatabaseHandler ()
		{
			if (cb_openDatabase == null)
				cb_openDatabase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OpenDatabase);
			return cb_openDatabase;
		}

		static IntPtr n_OpenDatabase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenDatabase ());
		}
#pragma warning restore 0169

		static IntPtr id_openDatabase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='DatabaseManager']/method[@name='openDatabase' and count(parameter)=0]"
		[Register ("openDatabase", "()Lcom/instabug/library/internal/storage/cache/db/SQLiteDatabaseWrapper;", "GetOpenDatabaseHandler")]
		public virtual unsafe global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper OpenDatabase ()
		{
			if (id_openDatabase == IntPtr.Zero)
				id_openDatabase = JNIEnv.GetMethodID (class_ref, "openDatabase", "()Lcom/instabug/library/internal/storage/cache/db/SQLiteDatabaseWrapper;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDatabase), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDatabase", "()Lcom/instabug/library/internal/storage/cache/db/SQLiteDatabaseWrapper;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
