using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/layer/CapturableViewLayerProvider", DoNotGenerateAcw=true)]
	public partial class CapturableViewLayerProvider : global::Com.Instabug.Library.Internal.Layer.LayerProvider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/internal/layer/CapturableViewLayerProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CapturableViewLayerProvider); }
		}

		protected CapturableViewLayerProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_instabug_library_internal_layer_CapturableView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/constructor[@name='CapturableViewLayerProvider' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.CapturableView']]"
		[Register (".ctor", "(Lcom/instabug/library/internal/layer/CapturableView;)V", "")]
		public unsafe CapturableViewLayerProvider (global::Com.Instabug.Library.Internal.Layer.ICapturableView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CapturableViewLayerProvider)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/instabug/library/internal/layer/CapturableView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/instabug/library/internal/layer/CapturableView;)V", __args);
					return;
				}

				if (id_ctor_Lcom_instabug_library_internal_layer_CapturableView_ == IntPtr.Zero)
					id_ctor_Lcom_instabug_library_internal_layer_CapturableView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/instabug/library/internal/layer/CapturableView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_instabug_library_internal_layer_CapturableView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_instabug_library_internal_layer_CapturableView_, __args);
			} finally {
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public override unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public override unsafe global::Java.Lang.Object View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Ljava/lang/Object;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
#pragma warning disable 0169
		static Delegate GetPrepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler ()
		{
			if (cb_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == null)
				cb_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_);
			return cb_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		}

		static void n_Prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0 = (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback)global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public override unsafe void Prepare (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0)
		{
			if (id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == IntPtr.Zero)
				id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
#pragma warning disable 0169
		static Delegate GetPrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler ()
		{
			if (cb_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == null)
				cb_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_);
			return cb_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		}

		static void n_PrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.CapturableViewLayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0 = (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback)global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareVideoFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='CapturableViewLayerProvider']/method[@name='prepareVideoFrame' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public override unsafe void PrepareVideoFrame (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0)
		{
			if (id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == IntPtr.Zero)
				id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNIEnv.GetMethodID (class_ref, "prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V"), __args);
			} finally {
			}
		}

	}
}
