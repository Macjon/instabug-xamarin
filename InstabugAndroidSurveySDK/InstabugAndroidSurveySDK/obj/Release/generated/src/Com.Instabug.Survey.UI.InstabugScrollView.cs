using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Survey.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.survey.ui']/class[@name='InstabugScrollView']"
	[global::Android.Runtime.Register ("com/instabug/survey/ui/InstabugScrollView", DoNotGenerateAcw=true)]
	public partial class InstabugScrollView : global::Android.Widget.ScrollView {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.instabug.survey.ui']/interface[@name='InstabugScrollView.OnScrollListener']"
		[Register ("com/instabug/survey/ui/InstabugScrollView$OnScrollListener", "", "Com.Instabug.Survey.UI.InstabugScrollView/IOnScrollListenerInvoker")]
		public partial interface IOnScrollListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.ui']/interface[@name='InstabugScrollView.OnScrollListener']/method[@name='onBottomReached' and count(parameter)=0]"
			[Register ("onBottomReached", "()V", "GetOnBottomReachedHandler:Com.Instabug.Survey.UI.InstabugScrollView/IOnScrollListenerInvoker, InstabugAndroidSurveySDK")]
			void OnBottomReached ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.ui']/interface[@name='InstabugScrollView.OnScrollListener']/method[@name='onScrolling' and count(parameter)=0]"
			[Register ("onScrolling", "()V", "GetOnScrollingHandler:Com.Instabug.Survey.UI.InstabugScrollView/IOnScrollListenerInvoker, InstabugAndroidSurveySDK")]
			void OnScrolling ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.ui']/interface[@name='InstabugScrollView.OnScrollListener']/method[@name='onTopReached' and count(parameter)=0]"
			[Register ("onTopReached", "()V", "GetOnTopReachedHandler:Com.Instabug.Survey.UI.InstabugScrollView/IOnScrollListenerInvoker, InstabugAndroidSurveySDK")]
			void OnTopReached ();

		}

		[global::Android.Runtime.Register ("com/instabug/survey/ui/InstabugScrollView$OnScrollListener", DoNotGenerateAcw=true)]
		internal class IOnScrollListenerInvoker : global::Java.Lang.Object, IOnScrollListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/instabug/survey/ui/InstabugScrollView$OnScrollListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnScrollListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnScrollListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnScrollListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.instabug.survey.ui.InstabugScrollView.OnScrollListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnScrollListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBottomReached;
#pragma warning disable 0169
			static Delegate GetOnBottomReachedHandler ()
			{
				if (cb_onBottomReached == null)
					cb_onBottomReached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBottomReached);
				return cb_onBottomReached;
			}

			static void n_OnBottomReached (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBottomReached ();
			}
#pragma warning restore 0169

			IntPtr id_onBottomReached;
			public unsafe void OnBottomReached ()
			{
				if (id_onBottomReached == IntPtr.Zero)
					id_onBottomReached = JNIEnv.GetMethodID (class_ref, "onBottomReached", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBottomReached);
			}

			static Delegate cb_onScrolling;
#pragma warning disable 0169
			static Delegate GetOnScrollingHandler ()
			{
				if (cb_onScrolling == null)
					cb_onScrolling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnScrolling);
				return cb_onScrolling;
			}

			static void n_OnScrolling (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnScrolling ();
			}
#pragma warning restore 0169

			IntPtr id_onScrolling;
			public unsafe void OnScrolling ()
			{
				if (id_onScrolling == IntPtr.Zero)
					id_onScrolling = JNIEnv.GetMethodID (class_ref, "onScrolling", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrolling);
			}

			static Delegate cb_onTopReached;
#pragma warning disable 0169
			static Delegate GetOnTopReachedHandler ()
			{
				if (cb_onTopReached == null)
					cb_onTopReached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTopReached);
				return cb_onTopReached;
			}

			static void n_OnTopReached (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTopReached ();
			}
#pragma warning restore 0169

			IntPtr id_onTopReached;
			public unsafe void OnTopReached ()
			{
				if (id_onTopReached == IntPtr.Zero)
					id_onTopReached = JNIEnv.GetMethodID (class_ref, "onTopReached", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTopReached);
			}

		}

		[global::Android.Runtime.Register ("mono/com/instabug/survey/ui/InstabugScrollView_OnScrollListenerImplementor")]
		internal sealed partial class IOnScrollListenerImplementor : global::Java.Lang.Object, IOnScrollListener {

			object sender;

			public IOnScrollListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/instabug/survey/ui/InstabugScrollView_OnScrollListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnBottomReachedHandler;
#pragma warning restore 0649

			public void OnBottomReached ()
			{
				var __h = OnBottomReachedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnScrollingHandler;
#pragma warning restore 0649

			public void OnScrolling ()
			{
				var __h = OnScrollingHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnTopReachedHandler;
#pragma warning restore 0649

			public void OnTopReached ()
			{
				var __h = OnTopReachedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnScrollListenerImplementor value)
			{
				return value.OnBottomReachedHandler == null && value.OnScrollingHandler == null && value.OnTopReachedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/survey/ui/InstabugScrollView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugScrollView); }
		}

		protected InstabugScrollView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.ui']/class[@name='InstabugScrollView']/constructor[@name='InstabugScrollView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe InstabugScrollView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (InstabugScrollView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.ui']/class[@name='InstabugScrollView']/constructor[@name='InstabugScrollView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe InstabugScrollView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				if (((object) this).GetType () != typeof (InstabugScrollView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.survey.ui']/class[@name='InstabugScrollView']/constructor[@name='InstabugScrollView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe InstabugScrollView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				__args [2] = new JValue (defStyle);
				if (((object) this).GetType () != typeof (InstabugScrollView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static Delegate cb_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_;
#pragma warning disable 0169
		static Delegate GetSetOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_Handler ()
		{
			if (cb_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_ == null)
				cb_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_);
			return cb_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_;
		}

		static void n_SetOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onScrollListener)
		{
			global::Com.Instabug.Survey.UI.InstabugScrollView __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.UI.InstabugScrollView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener onScrollListener = (global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener)global::Java.Lang.Object.GetObject<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener> (native_onScrollListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnScrollListener (onScrollListener);
		}
#pragma warning restore 0169

		static IntPtr id_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.survey.ui']/class[@name='InstabugScrollView']/method[@name='setOnScrollListener' and count(parameter)=1 and parameter[1][@type='com.instabug.survey.ui.InstabugScrollView.OnScrollListener']]"
		[Register ("setOnScrollListener", "(Lcom/instabug/survey/ui/InstabugScrollView$OnScrollListener;)V", "GetSetOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_Handler")]
		public virtual unsafe void SetOnScrollListener (global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener onScrollListener)
		{
			if (id_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_ == IntPtr.Zero)
				id_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_ = JNIEnv.GetMethodID (class_ref, "setOnScrollListener", "(Lcom/instabug/survey/ui/InstabugScrollView$OnScrollListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onScrollListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnScrollListener_Lcom_instabug_survey_ui_InstabugScrollView_OnScrollListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnScrollListener", "(Lcom/instabug/survey/ui/InstabugScrollView$OnScrollListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener"
		public event EventHandler BottomReached {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						__CreateIOnScrollListenerImplementor,
						SetOnScrollListener,
						__h => __h.OnBottomReachedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor.__IsEmpty,
						__v => SetOnScrollListener (null),
						__h => __h.OnBottomReachedHandler -= value);
			}
		}

		public event EventHandler Scrolling {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						__CreateIOnScrollListenerImplementor,
						SetOnScrollListener,
						__h => __h.OnScrollingHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor.__IsEmpty,
						__v => SetOnScrollListener (null),
						__h => __h.OnScrollingHandler -= value);
			}
		}

		public event EventHandler TopReached {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						__CreateIOnScrollListenerImplementor,
						SetOnScrollListener,
						__h => __h.OnTopReachedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListener, global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor>(
						ref weak_implementor_SetOnScrollListener,
						global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor.__IsEmpty,
						__v => SetOnScrollListener (null),
						__h => __h.OnTopReachedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnScrollListener;

		global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor __CreateIOnScrollListenerImplementor ()
		{
			return new global::Com.Instabug.Survey.UI.InstabugScrollView.IOnScrollListenerImplementor (this);
		}
#endregion
	}
}
