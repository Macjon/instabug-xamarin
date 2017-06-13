using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library.Internal.Layer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']"
	[global::Android.Runtime.Register ("com/instabug/library/internal/layer/LayerProvider", DoNotGenerateAcw=true)]
	public abstract partial class LayerProvider : global::Java.Lang.Object {


		static IntPtr bitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/field[@name='bitmap']"
		[Register ("bitmap")]
		public global::Android.Graphics.Bitmap Bitmap {
			get {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='LayerProvider.OnPrepareDoneCallback']"
		[Register ("com/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback", "", "Com.Instabug.Library.Internal.Layer.LayerProvider/IOnPrepareDoneCallbackInvoker")]
		public partial interface IOnPrepareDoneCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='LayerProvider.OnPrepareDoneCallback']/method[@name='onPrepareDone' and count(parameter)=0]"
			[Register ("onPrepareDone", "()V", "GetOnPrepareDoneHandler:Com.Instabug.Library.Internal.Layer.LayerProvider/IOnPrepareDoneCallbackInvoker, InstabugAndroidSDK")]
			void OnPrepareDone ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/interface[@name='LayerProvider.OnPrepareDoneCallback']/method[@name='onPrepareDoneForVideo' and count(parameter)=0]"
			[Register ("onPrepareDoneForVideo", "()V", "GetOnPrepareDoneForVideoHandler:Com.Instabug.Library.Internal.Layer.LayerProvider/IOnPrepareDoneCallbackInvoker, InstabugAndroidSDK")]
			void OnPrepareDoneForVideo ();

		}

		[global::Android.Runtime.Register ("com/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback", DoNotGenerateAcw=true)]
		internal class IOnPrepareDoneCallbackInvoker : global::Java.Lang.Object, IOnPrepareDoneCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPrepareDoneCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IOnPrepareDoneCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPrepareDoneCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPrepareDoneCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPrepareDone;
#pragma warning disable 0169
			static Delegate GetOnPrepareDoneHandler ()
			{
				if (cb_onPrepareDone == null)
					cb_onPrepareDone = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrepareDone);
				return cb_onPrepareDone;
			}

			static void n_OnPrepareDone (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepareDone ();
			}
#pragma warning restore 0169

			IntPtr id_onPrepareDone;
			public unsafe void OnPrepareDone ()
			{
				if (id_onPrepareDone == IntPtr.Zero)
					id_onPrepareDone = JNIEnv.GetMethodID (class_ref, "onPrepareDone", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareDone);
			}

			static Delegate cb_onPrepareDoneForVideo;
#pragma warning disable 0169
			static Delegate GetOnPrepareDoneForVideoHandler ()
			{
				if (cb_onPrepareDoneForVideo == null)
					cb_onPrepareDoneForVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrepareDoneForVideo);
				return cb_onPrepareDoneForVideo;
			}

			static void n_OnPrepareDoneForVideo (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPrepareDoneForVideo ();
			}
#pragma warning restore 0169

			IntPtr id_onPrepareDoneForVideo;
			public unsafe void OnPrepareDoneForVideo ()
			{
				if (id_onPrepareDoneForVideo == IntPtr.Zero)
					id_onPrepareDoneForVideo = JNIEnv.GetMethodID (class_ref, "onPrepareDoneForVideo", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareDoneForVideo);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/internal/layer/LayerProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerProvider); }
		}

		protected LayerProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/constructor[@name='LayerProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LayerProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LayerProvider)) {
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
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public abstract bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")] get;
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
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.Object View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Ljava/lang/Object;", "GetGetViewHandler")] get;
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
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public abstract void Draw (global::Android.Graphics.Canvas p0);

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
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0 = (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback)global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public abstract void Prepare (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0);

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
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0 = (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback)global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareVideoFrame (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='prepareVideoFrame' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public abstract void PrepareVideoFrame (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0);

		static Delegate cb_shouldDraw;
#pragma warning disable 0169
		static Delegate GetShouldDrawHandler ()
		{
			if (cb_shouldDraw == null)
				cb_shouldDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldDraw);
			return cb_shouldDraw;
		}

		static bool n_ShouldDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.Internal.Layer.LayerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.Internal.Layer.LayerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_shouldDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='shouldDraw' and count(parameter)=0]"
		[Register ("shouldDraw", "()Z", "GetShouldDrawHandler")]
		public virtual unsafe bool ShouldDraw ()
		{
			if (id_shouldDraw == IntPtr.Zero)
				id_shouldDraw = JNIEnv.GetMethodID (class_ref, "shouldDraw", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldDraw);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldDraw", "()Z"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/instabug/library/internal/layer/LayerProvider", DoNotGenerateAcw=true)]
	internal partial class LayerProviderInvoker : LayerProvider {

		public LayerProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LayerProviderInvoker); }
		}

		static IntPtr id_isValid;
		public override unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
				} finally {
				}
			}
		}

		static IntPtr id_getView;
		public override unsafe global::Java.Lang.Object View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Ljava/lang/Object;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_, __args);
			} finally {
			}
		}

		static IntPtr id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public override unsafe void Prepare (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0)
		{
			if (id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == IntPtr.Zero)
				id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library.internal.layer']/class[@name='LayerProvider']/method[@name='prepareVideoFrame' and count(parameter)=1 and parameter[1][@type='com.instabug.library.internal.layer.LayerProvider.OnPrepareDoneCallback']]"
		[Register ("prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V", "GetPrepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_Handler")]
		public override unsafe void PrepareVideoFrame (global::Com.Instabug.Library.Internal.Layer.LayerProvider.IOnPrepareDoneCallback p0)
		{
			if (id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ == IntPtr.Zero)
				id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_ = JNIEnv.GetMethodID (class_ref, "prepareVideoFrame", "(Lcom/instabug/library/internal/layer/LayerProvider$OnPrepareDoneCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareVideoFrame_Lcom_instabug_library_internal_layer_LayerProvider_OnPrepareDoneCallback_, __args);
			} finally {
			}
		}

	}

}
