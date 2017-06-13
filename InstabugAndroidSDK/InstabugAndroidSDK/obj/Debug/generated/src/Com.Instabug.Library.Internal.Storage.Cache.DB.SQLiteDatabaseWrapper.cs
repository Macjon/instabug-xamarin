using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Storage.Cache.DB {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/storage/cache/db/SQLiteDatabaseWrapper", DoNotGenerateAcw=true)]
	public partial class SQLiteDatabaseWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/internal/storage/cache/db/SQLiteDatabaseWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteDatabaseWrapper); }
		}

		protected SQLiteDatabaseWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_beginTransaction;
#pragma warning disable 0169
		static Delegate GetBeginTransactionHandler ()
		{
			if (cb_beginTransaction == null)
				cb_beginTransaction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginTransaction);
			return cb_beginTransaction;
		}

		static void n_BeginTransaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginTransaction ();
		}
#pragma warning restore 0169

		static IntPtr id_beginTransaction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='beginTransaction' and count(parameter)=0]"
		[Register ("beginTransaction", "()V", "GetBeginTransactionHandler")]
		public virtual unsafe void BeginTransaction ()
		{
			if (id_beginTransaction == IntPtr.Zero)
				id_beginTransaction = JNIEnv.GetMethodID (class_ref, "beginTransaction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beginTransaction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginTransaction", "()V"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDelete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static void n_Delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Delete (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='delete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "GetDelete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe void Delete (string p0, string p1, string[] p2)
		{
			if (id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_endTransaction;
#pragma warning disable 0169
		static Delegate GetEndTransactionHandler ()
		{
			if (cb_endTransaction == null)
				cb_endTransaction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndTransaction);
			return cb_endTransaction;
		}

		static void n_EndTransaction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndTransaction ();
		}
#pragma warning restore 0169

		static IntPtr id_endTransaction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='endTransaction' and count(parameter)=0]"
		[Register ("endTransaction", "()V", "GetEndTransactionHandler")]
		public virtual unsafe void EndTransaction ()
		{
			if (id_endTransaction == IntPtr.Zero)
				id_endTransaction = JNIEnv.GetMethodID (class_ref, "endTransaction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endTransaction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endTransaction", "()V"));
			} finally {
			}
		}

		static Delegate cb_execSQL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExecSQL_Ljava_lang_String_Handler ()
		{
			if (cb_execSQL_Ljava_lang_String_ == null)
				cb_execSQL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExecSQL_Ljava_lang_String_);
			return cb_execSQL_Ljava_lang_String_;
		}

		static void n_ExecSQL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecSQL (p0);
		}
#pragma warning restore 0169

		static IntPtr id_execSQL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='execSQL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("execSQL", "(Ljava/lang/String;)V", "GetExecSQL_Ljava_lang_String_Handler")]
		public virtual unsafe void ExecSQL (string p0)
		{
			if (id_execSQL_Ljava_lang_String_ == IntPtr.Zero)
				id_execSQL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "execSQL", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execSQL_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execSQL", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == null)
				cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_Insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_);
			return cb_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		}

		static long n_Insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p2 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p2, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Insert (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='insert' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.ContentValues']]"
		[Register ("insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", "GetInsert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_Handler")]
		public virtual unsafe long Insert (string p0, string p1, global::Android.Content.ContentValues p2)
		{
			if (id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_insert_Ljava_lang_String_Ljava_lang_String_Landroid_content_ContentValues_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4, p5, p6));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='query' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Database.ICursor Query (string p0, string[] p1, string p2, string[] p3, string p4, string p5, string p6)
		{
			if (id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4, p5, p6, p7));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='query' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Database.ICursor Query (string p0, string[] p1, string p2, string[] p3, string p4, string p5, string p6, string p7)
		{
			if (id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static Delegate cb_queryNumEntries_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryNumEntries_Ljava_lang_String_Handler ()
		{
			if (cb_queryNumEntries_Ljava_lang_String_ == null)
				cb_queryNumEntries_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_QueryNumEntries_Ljava_lang_String_);
			return cb_queryNumEntries_Ljava_lang_String_;
		}

		static long n_QueryNumEntries_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.QueryNumEntries (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_queryNumEntries_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='queryNumEntries' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryNumEntries", "(Ljava/lang/String;)J", "GetQueryNumEntries_Ljava_lang_String_Handler")]
		public virtual unsafe long QueryNumEntries (string p0)
		{
			if (id_queryNumEntries_Ljava_lang_String_ == IntPtr.Zero)
				id_queryNumEntries_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryNumEntries", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_queryNumEntries_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryNumEntries", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_rawQuery_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRawQuery_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_rawQuery_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_rawQuery_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawQuery_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_rawQuery_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_RawQuery_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawQuery (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rawQuery_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='rawQuery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", "GetRawQuery_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Android.Database.ICursor RawQuery (string p0, string[] p1)
		{
			if (id_rawQuery_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_rawQuery_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rawQuery_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_setTransactionSuccessful;
#pragma warning disable 0169
		static Delegate GetSetTransactionSuccessfulHandler ()
		{
			if (cb_setTransactionSuccessful == null)
				cb_setTransactionSuccessful = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetTransactionSuccessful);
			return cb_setTransactionSuccessful;
		}

		static void n_SetTransactionSuccessful (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransactionSuccessful ();
		}
#pragma warning restore 0169

		static IntPtr id_setTransactionSuccessful;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='setTransactionSuccessful' and count(parameter)=0]"
		[Register ("setTransactionSuccessful", "()V", "GetSetTransactionSuccessfulHandler")]
		public virtual unsafe void SetTransactionSuccessful ()
		{
			if (id_setTransactionSuccessful == IntPtr.Zero)
				id_setTransactionSuccessful = JNIEnv.GetMethodID (class_ref, "setTransactionSuccessful", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransactionSuccessful);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransactionSuccessful", "()V"));
			} finally {
			}
		}

		static Delegate cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Storage.Cache.DB.SQLiteDatabaseWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.storage.cache.db']/class[@name='SQLiteDatabaseWrapper']/method[@name='update' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe int Update (string p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			if (id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_update_Ljava_lang_String_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
