using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Instabug.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']"
	[global::Android.Runtime.Register ("com/instabug/library/InstabugFeedbackFragment", DoNotGenerateAcw=true)]
	public partial class InstabugFeedbackFragment : global::Com.Instabug.Library.InstabugBaseFragment, global::Android.Text.ITextWatcher, global::Android.Views.View.IOnClickListener, global::Android.Views.View.IOnFocusChangeListener, global::Com.Instabug.Library.InstabugAddAttachmentsFragment.ICallbacks, global::Com.Instabug.Library.InstabugAudioRecordingFragment.ICallbacks {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/field[@name='VIDEO_PATH']"
		[Register ("VIDEO_PATH")]
		public const string VideoPath = (string) "video.path";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/instabug/library/InstabugFeedbackFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstabugFeedbackFragment); }
		}

		protected InstabugFeedbackFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/constructor[@name='InstabugFeedbackFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstabugFeedbackFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InstabugFeedbackFragment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static Delegate cb_getLayout;
#pragma warning disable 0169
		static Delegate GetGetLayoutHandler ()
		{
			if (cb_getLayout == null)
				cb_getLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLayout);
			return cb_getLayout;
		}

		static int n_GetLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Layout;
		}
#pragma warning restore 0169

		static IntPtr id_getLayout;
		protected override unsafe int Layout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='getLayout' and count(parameter)=0]"
			[Register ("getLayout", "()I", "GetGetLayoutHandler")]
			get {
				if (id_getLayout == IntPtr.Zero)
					id_getLayout = JNIEnv.GetMethodID (class_ref, "getLayout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLayout);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLayout", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		protected override unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_afterTextChanged_Landroid_text_Editable_;
#pragma warning disable 0169
		static Delegate GetAfterTextChanged_Landroid_text_Editable_Handler ()
		{
			if (cb_afterTextChanged_Landroid_text_Editable_ == null)
				cb_afterTextChanged_Landroid_text_Editable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AfterTextChanged_Landroid_text_Editable_);
			return cb_afterTextChanged_Landroid_text_Editable_;
		}

		static void n_AfterTextChanged_Landroid_text_Editable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Text.IEditable p0 = (global::Android.Text.IEditable)global::Java.Lang.Object.GetObject<global::Android.Text.IEditable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AfterTextChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_afterTextChanged_Landroid_text_Editable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='afterTextChanged' and count(parameter)=1 and parameter[1][@type='android.text.Editable']]"
		[Register ("afterTextChanged", "(Landroid/text/Editable;)V", "GetAfterTextChanged_Landroid_text_Editable_Handler")]
		public virtual unsafe void AfterTextChanged (global::Android.Text.IEditable p0)
		{
			if (id_afterTextChanged_Landroid_text_Editable_ == IntPtr.Zero)
				id_afterTextChanged_Landroid_text_Editable_ = JNIEnv.GetMethodID (class_ref, "afterTextChanged", "(Landroid/text/Editable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_afterTextChanged_Landroid_text_Editable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "afterTextChanged", "(Landroid/text/Editable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_attachImageFromGallery;
#pragma warning disable 0169
		static Delegate GetAttachImageFromGalleryHandler ()
		{
			if (cb_attachImageFromGallery == null)
				cb_attachImageFromGallery = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachImageFromGallery);
			return cb_attachImageFromGallery;
		}

		static void n_AttachImageFromGallery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttachImageFromGallery ();
		}
#pragma warning restore 0169

		static IntPtr id_attachImageFromGallery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='attachImageFromGallery' and count(parameter)=0]"
		[Register ("attachImageFromGallery", "()V", "GetAttachImageFromGalleryHandler")]
		public virtual unsafe void AttachImageFromGallery ()
		{
			if (id_attachImageFromGallery == IntPtr.Zero)
				id_attachImageFromGallery = JNIEnv.GetMethodID (class_ref, "attachImageFromGallery", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachImageFromGallery);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachImageFromGallery", "()V"));
			} finally {
			}
		}

		static Delegate cb_attachScreenshot;
#pragma warning disable 0169
		static Delegate GetAttachScreenshotHandler ()
		{
			if (cb_attachScreenshot == null)
				cb_attachScreenshot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachScreenshot);
			return cb_attachScreenshot;
		}

		static void n_AttachScreenshot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttachScreenshot ();
		}
#pragma warning restore 0169

		static IntPtr id_attachScreenshot;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='attachScreenshot' and count(parameter)=0]"
		[Register ("attachScreenshot", "()V", "GetAttachScreenshotHandler")]
		public virtual unsafe void AttachScreenshot ()
		{
			if (id_attachScreenshot == IntPtr.Zero)
				id_attachScreenshot = JNIEnv.GetMethodID (class_ref, "attachScreenshot", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachScreenshot);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachScreenshot", "()V"));
			} finally {
			}
		}

		static Delegate cb_attachVideo;
#pragma warning disable 0169
		static Delegate GetAttachVideoHandler ()
		{
			if (cb_attachVideo == null)
				cb_attachVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachVideo);
			return cb_attachVideo;
		}

		static void n_AttachVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttachVideo ();
		}
#pragma warning restore 0169

		static IntPtr id_attachVideo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='attachVideo' and count(parameter)=0]"
		[Register ("attachVideo", "()V", "GetAttachVideoHandler")]
		public virtual unsafe void AttachVideo ()
		{
			if (id_attachVideo == IntPtr.Zero)
				id_attachVideo = JNIEnv.GetMethodID (class_ref, "attachVideo", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachVideo);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachVideo", "()V"));
			} finally {
			}
		}

		static Delegate cb_attachVoiceNote;
#pragma warning disable 0169
		static Delegate GetAttachVoiceNoteHandler ()
		{
			if (cb_attachVoiceNote == null)
				cb_attachVoiceNote = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AttachVoiceNote);
			return cb_attachVoiceNote;
		}

		static void n_AttachVoiceNote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttachVoiceNote ();
		}
#pragma warning restore 0169

		static IntPtr id_attachVoiceNote;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='attachVoiceNote' and count(parameter)=0]"
		[Register ("attachVoiceNote", "()V", "GetAttachVoiceNoteHandler")]
		public virtual unsafe void AttachVoiceNote ()
		{
			if (id_attachVoiceNote == IntPtr.Zero)
				id_attachVoiceNote = JNIEnv.GetMethodID (class_ref, "attachVoiceNote", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachVoiceNote);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachVoiceNote", "()V"));
			} finally {
			}
		}

		static Delegate cb_beforeTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_beforeTextChanged_Ljava_lang_CharSequence_III == null)
				cb_beforeTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_BeforeTextChanged_Ljava_lang_CharSequence_III);
			return cb_beforeTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_BeforeTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeforeTextChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_beforeTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='beforeTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("beforeTextChanged", "(Ljava/lang/CharSequence;III)V", "GetBeforeTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void BeforeTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_beforeTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_beforeTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beforeTextChanged_Ljava_lang_CharSequence_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beforeTextChanged", "(Ljava/lang/CharSequence;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void BeforeTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			BeforeTextChanged (jls_p0, p1, p2, p3);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_consumeNewInstanceSavedArguments;
#pragma warning disable 0169
		static Delegate GetConsumeNewInstanceSavedArgumentsHandler ()
		{
			if (cb_consumeNewInstanceSavedArguments == null)
				cb_consumeNewInstanceSavedArguments = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConsumeNewInstanceSavedArguments);
			return cb_consumeNewInstanceSavedArguments;
		}

		static void n_ConsumeNewInstanceSavedArguments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeNewInstanceSavedArguments ();
		}
#pragma warning restore 0169

		static IntPtr id_consumeNewInstanceSavedArguments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='consumeNewInstanceSavedArguments' and count(parameter)=0]"
		[Register ("consumeNewInstanceSavedArguments", "()V", "GetConsumeNewInstanceSavedArgumentsHandler")]
		protected override unsafe void ConsumeNewInstanceSavedArguments ()
		{
			if (id_consumeNewInstanceSavedArguments == IntPtr.Zero)
				id_consumeNewInstanceSavedArguments = JNIEnv.GetMethodID (class_ref, "consumeNewInstanceSavedArguments", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consumeNewInstanceSavedArguments);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "consumeNewInstanceSavedArguments", "()V"));
			} finally {
			}
		}

		static Delegate cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAudioRecorded_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAudioRecorded_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAudioRecorded_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioRecorded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onAudioRecorded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAudioRecorded", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnAudioRecorded_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OnAudioRecorded (string p0, string p1)
		{
			if (id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAudioRecorded", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioRecorded_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAudioRecorded", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_view_View_Handler ()
		{
			if (cb_onClick_Landroid_view_View_ == null)
				cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
			return cb_onClick_Landroid_view_View_;
		}

		static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public virtual unsafe void OnClick (global::Android.Views.View p0)
		{
			if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
				id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onFocusChange_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetOnFocusChange_Landroid_view_View_ZHandler ()
		{
			if (cb_onFocusChange_Landroid_view_View_Z == null)
				cb_onFocusChange_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnFocusChange_Landroid_view_View_Z);
			return cb_onFocusChange_Landroid_view_View_Z;
		}

		static void n_OnFocusChange_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFocusChange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onFocusChange_Landroid_view_View_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onFocusChange' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("onFocusChange", "(Landroid/view/View;Z)V", "GetOnFocusChange_Landroid_view_View_ZHandler")]
		public virtual unsafe void OnFocusChange (global::Android.Views.View p0, bool p1)
		{
			if (id_onFocusChange_Landroid_view_View_Z == IntPtr.Zero)
				id_onFocusChange_Landroid_view_View_Z = JNIEnv.GetMethodID (class_ref, "onFocusChange", "(Landroid/view/View;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFocusChange_Landroid_view_View_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFocusChange", "(Landroid/view/View;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI);
			return cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnRequestPermissionsResult (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onRequestPermissionsResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]']]"
		[Register ("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe void OnRequestPermissionsResult (int p0, string[] p1, int[] p2)
		{
			if (id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onTextChanged_Ljava_lang_CharSequence_III;
#pragma warning disable 0169
		static Delegate GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler ()
		{
			if (cb_onTextChanged_Ljava_lang_CharSequence_III == null)
				cb_onTextChanged_Ljava_lang_CharSequence_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnTextChanged_Ljava_lang_CharSequence_III);
			return cb_onTextChanged_Ljava_lang_CharSequence_III;
		}

		static void n_OnTextChanged_Ljava_lang_CharSequence_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTextChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onTextChanged_Ljava_lang_CharSequence_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onTextChanged' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onTextChanged", "(Ljava/lang/CharSequence;III)V", "GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler")]
		public virtual unsafe void OnTextChanged (global::Java.Lang.ICharSequence p0, int p1, int p2, int p3)
		{
			if (id_onTextChanged_Ljava_lang_CharSequence_III == IntPtr.Zero)
				id_onTextChanged_Ljava_lang_CharSequence_III = JNIEnv.GetMethodID (class_ref, "onTextChanged", "(Ljava/lang/CharSequence;III)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTextChanged_Ljava_lang_CharSequence_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTextChanged", "(Ljava/lang/CharSequence;III)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public void OnTextChanged (string p0, int p1, int p2, int p3)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			OnTextChanged (jls_p0, p1, p2, p3);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static Delegate cb_onVideoEncoded_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoded_Ljava_lang_String_ZHandler ()
		{
			if (cb_onVideoEncoded_Ljava_lang_String_Z == null)
				cb_onVideoEncoded_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnVideoEncoded_Ljava_lang_String_Z);
			return cb_onVideoEncoded_Ljava_lang_String_Z;
		}

		static void n_OnVideoEncoded_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onVideoEncoded_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='onVideoEncoded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onVideoEncoded", "(Ljava/lang/String;Z)V", "GetOnVideoEncoded_Ljava_lang_String_ZHandler")]
		public virtual unsafe void OnVideoEncoded (string p0, bool p1)
		{
			if (id_onVideoEncoded_Ljava_lang_String_Z == IntPtr.Zero)
				id_onVideoEncoded_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onVideoEncoded", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVideoEncoded_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVideoEncoded", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_restoreState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRestoreState_Landroid_os_Bundle_Handler ()
		{
			if (cb_restoreState_Landroid_os_Bundle_ == null)
				cb_restoreState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RestoreState_Landroid_os_Bundle_);
			return cb_restoreState_Landroid_os_Bundle_;
		}

		static void n_RestoreState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_restoreState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='restoreState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreState", "(Landroid/os/Bundle;)V", "GetRestoreState_Landroid_os_Bundle_Handler")]
		protected override unsafe void RestoreState (global::Android.OS.Bundle p0)
		{
			if (id_restoreState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "restoreState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restoreState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_saveState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveState_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveState_Landroid_os_Bundle_ == null)
				cb_saveState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveState_Landroid_os_Bundle_);
			return cb_saveState_Landroid_os_Bundle_;
		}

		static void n_SaveState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Instabug.Library.InstabugFeedbackFragment __this = global::Java.Lang.Object.GetObject<global::Com.Instabug.Library.InstabugFeedbackFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveState_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.instabug.library']/class[@name='InstabugFeedbackFragment']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveState", "(Landroid/os/Bundle;)V", "GetSaveState_Landroid_os_Bundle_Handler")]
		protected override unsafe void SaveState (global::Android.OS.Bundle p0)
		{
			if (id_saveState_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveState_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveState", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveState_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveState", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

	}
}
