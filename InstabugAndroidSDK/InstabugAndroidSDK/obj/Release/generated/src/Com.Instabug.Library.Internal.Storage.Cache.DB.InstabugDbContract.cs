using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Storage.Cache.DB {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/InstabugDbContract", DoNotGenerateAcw=true)]
	public partial class InstabugDbContract : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']"
		[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$InstabugLogEntry", DoNotGenerateAcw=true)]
		public partial class InstabugLogEntry : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='COLUMN_LOG_DATE']"
			[Register ("COLUMN_LOG_DATE")]
			public const string ColumnLogDate = (string) "log_date";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='COLUMN_LOG_LEVEL']"
			[Register ("COLUMN_LOG_LEVEL")]
			public const string ColumnLogLevel = (string) "log_level";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='COLUMN_LOG_MESSAGE']"
			[Register ("COLUMN_LOG_MESSAGE")]
			public const string ColumnLogMessage = (string) "log_message";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='DELETE_ALL_EXCEPT_THE_LATEST_1000_ENTRY']"
			[Register ("DELETE_ALL_EXCEPT_THE_LATEST_1000_ENTRY")]
			public const string DeleteAllExceptTheLatest1000Entry = (string) "DELETE FROM instabug_logs WHERE log_date IN (SELECT log_date FROM instabug_logs ORDER BY log_date DESC LIMIT -1 OFFSET 1000)";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='DELETE_THE_OLDEST_INSERTED_ENTRY']"
			[Register ("DELETE_THE_OLDEST_INSERTED_ENTRY")]
			public const string DeleteTheOldestInsertedEntry = (string) "DELETE FROM instabug_logs WHERE log_date = (SELECT MAX(log_date) FROM instabug_logs);";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='DROP_QUERY_INSTABUG_LOG']"
			[Register ("DROP_QUERY_INSTABUG_LOG")]
			public const string DropQueryInstabugLog = (string) "DROP TABLE IF EXISTS instabug_logs";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='INSTABUG_LOG_LIMIT']"
			[Register ("INSTABUG_LOG_LIMIT")]
			public const int InstabugLogLimit = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='SELECT_LIMITED_INSTABUG_LOG']"
			[Register ("SELECT_LIMITED_INSTABUG_LOG")]
			public const string SelectLimitedInstabugLog = (string) "SELECT * FROM instabug_logs ORDER  BY log_date DESC LIMIT 1000";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='SQL_CREATE_INSTABUG_LOGS']"
			[Register ("SQL_CREATE_INSTABUG_LOGS")]
			public const string SqlCreateInstabugLogs = (string) "CREATE TABLE IF NOT EXISTS instabug_logs (log_message TEXT,log_level TEXT,log_date TEXT )";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='TABLE_NAME']"
			[Register ("TABLE_NAME")]
			public const string TableName = (string) "instabug_logs";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/field[@name='TRIM_INSTABUG_LOG_SQL_QUERY']"
			[Register ("TRIM_INSTABUG_LOG_SQL_QUERY")]
			public const string TrimInstabugLogSqlQuery = (string) "DELETE FROM instabug_logs WHERE log_date NOT IN ( SELECT log_date FROM instabug_logs WHERE log_date ORDER BY log_date DESC LIMIT 1000 )";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$InstabugLogEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InstabugLogEntry); }
			}

			protected InstabugLogEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.InstabugLogEntry']/constructor[@name='InstabugDbContract.InstabugLogEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe InstabugLogEntry ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (InstabugLogEntry)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']"
		[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$NetworkLogEntry", DoNotGenerateAcw=true)]
		public partial class NetworkLogEntry : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_DATE']"
			[Register ("COLUMN_DATE")]
			public const string ColumnDate = (string) "date";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_HEADERS']"
			[Register ("COLUMN_HEADERS")]
			public const string ColumnHeaders = (string) "headers";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_METHOD']"
			[Register ("COLUMN_METHOD")]
			public const string ColumnMethod = (string) "method";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_REQUEST']"
			[Register ("COLUMN_REQUEST")]
			public const string ColumnRequest = (string) "request";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_RESPONSE']"
			[Register ("COLUMN_RESPONSE")]
			public const string ColumnResponse = (string) "response";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_RESPONSE_CODE']"
			[Register ("COLUMN_RESPONSE_CODE")]
			public const string ColumnResponseCode = (string) "status";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='COLUMN_URL']"
			[Register ("COLUMN_URL")]
			public const string ColumnUrl = (string) "url";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='DELETE_ALL_EXCEPT_THE_LATEST_100_ENTRY']"
			[Register ("DELETE_ALL_EXCEPT_THE_LATEST_100_ENTRY")]
			public const string DeleteAllExceptTheLatest100Entry = (string) "DELETE FROM network_logs WHERE date IN (SELECT date FROM network_logs ORDER BY date DESC LIMIT -1 OFFSET 100)";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='NETWORK_LOG_LIMIT']"
			[Register ("NETWORK_LOG_LIMIT")]
			public const int NetworkLogLimit = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='SQL_CREATE_NETWORK_LOGS']"
			[Register ("SQL_CREATE_NETWORK_LOGS")]
			public const string SqlCreateNetworkLogs = (string) "CREATE TABLE network_logs (_id INTEGER PRIMARY KEY,url TEXT,request TEXT,method TEXT,response TEXT,status INTEGER,headers TEXT,date TEXT )";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='SQL_DELETE_ENTRIES']"
			[Register ("SQL_DELETE_ENTRIES")]
			public const string SqlDeleteEntries = (string) "DROP TABLE IF EXISTS network_logs";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/field[@name='TABLE_NAME']"
			[Register ("TABLE_NAME")]
			public const string TableName = (string) "network_logs";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$NetworkLogEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkLogEntry); }
			}

			protected NetworkLogEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.NetworkLogEntry']/constructor[@name='InstabugDbContract.NetworkLogEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NetworkLogEntry ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (NetworkLogEntry)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']"
		[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$UserEventEntry", DoNotGenerateAcw=true)]
		public partial class UserEventEntry : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/field[@name='COLUMN_EVENT_IDENTIFIER']"
			[Register ("COLUMN_EVENT_IDENTIFIER")]
			public const string ColumnEventIdentifier = (string) "event_identifier";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/field[@name='COLUMN_EVENT_LOGGING_COUNT']"
			[Register ("COLUMN_EVENT_LOGGING_COUNT")]
			public const string ColumnEventLoggingCount = (string) "event_logging_count";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/field[@name='CREATE_TABLE']"
			[Register ("CREATE_TABLE")]
			public const string CreateTable = (string) "CREATE TABLE IF NOT EXISTS user_events_logs ( event_identifier TEXT,event_logging_count INTEGER )";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/field[@name='DROP_TABLE']"
			[Register ("DROP_TABLE")]
			public const string DropTable = (string) "DROP TABLE IF EXISTS user_events_logs";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/field[@name='TABLE_NAME']"
			[Register ("TABLE_NAME")]
			public const string TableName = (string) "user_events_logs";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/instabug/library/internal/storage/cache/db/InstabugDbContract$UserEventEntry", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UserEventEntry); }
			}

			protected UserEventEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='InstabugDbContract.UserEventEntry']/constructor[@name='InstabugDbContract.UserEventEntry' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe UserEventEntry ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (UserEventEntry)) {
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

		}

		protected InstabugDbContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
