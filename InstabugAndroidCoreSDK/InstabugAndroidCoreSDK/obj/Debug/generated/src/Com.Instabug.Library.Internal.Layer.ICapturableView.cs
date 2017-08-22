using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Layer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView.SnapshotPreparationCallback']"
	[Register ("com/instabug/library/internal/layer/CapturableView$SnapshotPreparationCallback", "", "Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallbackInvoker")]
	public partial interface ICapturableViewSnapshotPreparationCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView.SnapshotPreparationCallback']/method[@name='onSnapshotFailed' and count(parameter)=0]"
		[Register ("onSnapshotFailed", "()V", "GetOnSnapshotFailedHandler:Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallbackInvoker, InstabugAndroidCoreSDK")]
		void OnSnapshotFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView.SnapshotPreparationCallback']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("onSnapshotReady", "(Landroid/graphics/Bitmap;)V", "GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler:Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallbackInvoker, InstabugAndroidCoreSDK")]
		void OnSnapshotReady (global::Android.Graphics.Bitmap p0);

	}

	[global::Android.Runtime.Register ("com/instabug/library/internal/layer/CapturableView$SnapshotPreparationCallback", DoNotGenerateAcw=true)]
	internal class ICapturableViewSnapshotPreparationCallbackInvoker : global::Java.Lang.Object, ICapturableViewSnapshotPreparationCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/internal/layer/CapturableView$SnapshotPreparationCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICapturableViewSnapshotPreparationCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ICapturableViewSnapshotPreparationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICapturableViewSnapshotPreparationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.internal.layer.CapturableView.SnapshotPreparationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICapturableViewSnapshotPreparationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSnapshotFailed;
#pragma warning disable 0169
		static Delegate GetOnSnapshotFailedHandler ()
		{
			if (cb_onSnapshotFailed == null)
				cb_onSnapshotFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSnapshotFailed);
			return cb_onSnapshotFailed;
		}

		static void n_OnSnapshotFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSnapshotFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onSnapshotFailed;
		public unsafe void OnSnapshotFailed ()
		{
			if (id_onSnapshotFailed == IntPtr.Zero)
				id_onSnapshotFailed = JNIEnv.GetMethodID (class_ref, "onSnapshotFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotFailed);
		}

		static Delegate cb_onSnapshotReady_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_onSnapshotReady_Landroid_graphics_Bitmap_ == null)
				cb_onSnapshotReady_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Landroid_graphics_Bitmap_);
			return cb_onSnapshotReady_Landroid_graphics_Bitmap_;
		}

		static void n_OnSnapshotReady_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSnapshotReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSnapshotReady_Landroid_graphics_Bitmap_;
		public unsafe void OnSnapshotReady (global::Android.Graphics.Bitmap p0)
		{
			if (id_onSnapshotReady_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_onSnapshotReady_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onSnapshotReady", "(Landroid/graphics/Bitmap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotReady_Landroid_graphics_Bitmap_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView']"
	[Register ("com/instabug/library/internal/layer/CapturableView", "", "Com.Instabug.Library.Internal.Layer.ICapturableViewInvoker")]
	public partial interface ICapturableView : IJavaObject {

		bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:Com.Instabug.Library.Internal.Layer.ICapturableViewInvoker, InstabugAndroidCoreSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView']/method[@name='getLocationOnScreen' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getLocationOnScreen", "([I)V", "GetGetLocationOnScreen_arrayIHandler:Com.Instabug.Library.Internal.Layer.ICapturableViewInvoker, InstabugAndroidCoreSDK")]
		void GetLocationOnScreen (int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='CapturableView']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.CapturableView.SnapshotPreparationCallback']]"
		[Register ("snapshot", "(Lcom/instabug/library/internal/layer/CapturableView$SnapshotPreparationCallback;)V", "GetSnapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_Handler:Com.Instabug.Library.Internal.Layer.ICapturableViewInvoker, InstabugAndroidCoreSDK")]
		void Snapshot (global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback p0);

	}

	[global::Android.Runtime.Register ("com/instabug/library/internal/layer/CapturableView", DoNotGenerateAcw=true)]
	internal class ICapturableViewInvoker : global::Java.Lang.Object, ICapturableView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/internal/layer/CapturableView");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICapturableViewInvoker); }
		}

		IntPtr class_ref;

		public static ICapturableView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICapturableView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.internal.layer.CapturableView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICapturableViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Layer.ICapturableView __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVisible;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		public unsafe bool IsVisible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
		}

		static Delegate cb_getLocationOnScreen_arrayI;
#pragma warning disable 0169
		static Delegate GetGetLocationOnScreen_arrayIHandler ()
		{
			if (cb_getLocationOnScreen_arrayI == null)
				cb_getLocationOnScreen_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLocationOnScreen_arrayI);
			return cb_getLocationOnScreen_arrayI;
		}

		static void n_GetLocationOnScreen_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.ICapturableView __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.GetLocationOnScreen (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_getLocationOnScreen_arrayI;
		public unsafe void GetLocationOnScreen (int[] p0)
		{
			if (id_getLocationOnScreen_arrayI == IntPtr.Zero)
				id_getLocationOnScreen_arrayI = JNIEnv.GetMethodID (class_ref, "getLocationOnScreen", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLocationOnScreen_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_;
#pragma warning disable 0169
		static Delegate GetSnapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_Handler ()
		{
			if (cb_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_ == null)
				cb_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_);
			return cb_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_;
		}

		static void n_Snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.ICapturableView __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback p0 = (global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback)global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Snapshot (p0);
		}
#pragma warning restore 0169

		IntPtr id_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_;
		public unsafe void Snapshot (global::Com.Instabug.Library.Internal.Layer.ICapturableViewSnapshotPreparationCallback p0)
		{
			if (id_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_ == IntPtr.Zero)
				id_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_ = JNIEnv.GetMethodID (class_ref, "snapshot", "(Lcom/instabug/library/internal/layer/CapturableView$SnapshotPreparationCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_snapshot_Lcom_instabug_library_internal_layer_CapturableView_SnapshotPreparationCallback_, __args);
		}

	}

}
