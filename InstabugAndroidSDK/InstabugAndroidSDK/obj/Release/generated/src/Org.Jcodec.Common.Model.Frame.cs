using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Frame", DoNotGenerateAcw=true)]
	public partial class Frame : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Frame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Frame); }
		}

		protected Frame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_Rational_ILorg_jcodec_common_model_TapeTimecode_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/constructor[@name='Frame' and count(parameter)=7 and parameter[1][@type='org.jcodec.common.model.Picture'] and parameter[2][@type='org.jcodec.common.model.RationalLarge'] and parameter[3][@type='org.jcodec.common.model.RationalLarge'] and parameter[4][@type='org.jcodec.common.model.Rational'] and parameter[5][@type='int'] and parameter[6][@type='org.jcodec.common.model.TapeTimecode'] and parameter[7][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/Rational;ILorg/jcodec/common/model/TapeTimecode;Ljava/util/List;)V", "")]
		public unsafe Frame (global::Org.Jcodec.Common.Model.Picture p0, global::Org.Jcodec.Common.Model.RationalLarge p1, global::Org.Jcodec.Common.Model.RationalLarge p2, global::Org.Jcodec.Common.Model.Rational p3, int p4, global::Org.Jcodec.Common.Model.TapeTimecode p5, global::System.Collections.Generic.IList<string> p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p6 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				if (GetType () != typeof (Frame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/Rational;ILorg/jcodec/common/model/TapeTimecode;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/Rational;ILorg/jcodec/common/model/TapeTimecode;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_Rational_ILorg_jcodec_common_model_TapeTimecode_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_Rational_ILorg_jcodec_common_model_TapeTimecode_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Picture;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/RationalLarge;Lorg/jcodec/common/model/Rational;ILorg/jcodec/common/model/TapeTimecode;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_Rational_ILorg_jcodec_common_model_TapeTimecode_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Picture_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_RationalLarge_Lorg_jcodec_common_model_Rational_ILorg_jcodec_common_model_TapeTimecode_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDuration);
			return cb_getDuration;
		}

		static IntPtr n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Duration);
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()Lorg/jcodec/common/model/RationalLarge;", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()Lorg/jcodec/common/model/RationalLarge;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDuration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()Lorg/jcodec/common/model/RationalLarge;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFrameNo;
#pragma warning disable 0169
		static Delegate GetGetFrameNoHandler ()
		{
			if (cb_getFrameNo == null)
				cb_getFrameNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameNo);
			return cb_getFrameNo;
		}

		static int n_GetFrameNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameNo;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameNo;
		public virtual unsafe int FrameNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getFrameNo' and count(parameter)=0]"
			[Register ("getFrameNo", "()I", "GetGetFrameNoHandler")]
			get {
				if (id_getFrameNo == IntPtr.Zero)
					id_getFrameNo = JNIEnv.GetMethodID (class_ref, "getFrameNo", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameNo);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameNo", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isAvailable;
#pragma warning disable 0169
		static Delegate GetIsAvailableHandler ()
		{
			if (cb_isAvailable == null)
				cb_isAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAvailable);
			return cb_isAvailable;
		}

		static bool n_IsAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isAvailable;
		public virtual unsafe bool IsAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='isAvailable' and count(parameter)=0]"
			[Register ("isAvailable", "()Z", "GetIsAvailableHandler")]
			get {
				if (id_isAvailable == IntPtr.Zero)
					id_isAvailable = JNIEnv.GetMethodID (class_ref, "isAvailable", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAvailable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAvailable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Messages);
		}
#pragma warning restore 0169

		static IntPtr id_getMessages;
		public virtual unsafe global::System.Collections.Generic.IList<string> Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/util/List;", "GetGetMessagesHandler")]
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPic;
#pragma warning disable 0169
		static Delegate GetGetPicHandler ()
		{
			if (cb_getPic == null)
				cb_getPic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPic);
			return cb_getPic;
		}

		static IntPtr n_GetPic (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pic);
		}
#pragma warning restore 0169

		static IntPtr id_getPic;
		public virtual unsafe global::Org.Jcodec.Common.Model.Picture Pic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getPic' and count(parameter)=0]"
			[Register ("getPic", "()Lorg/jcodec/common/model/Picture;", "GetGetPicHandler")]
			get {
				if (id_getPic == IntPtr.Zero)
					id_getPic = JNIEnv.GetMethodID (class_ref, "getPic", "()Lorg/jcodec/common/model/Picture;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPic), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Picture> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPic", "()Lorg/jcodec/common/model/Picture;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPixelAspect;
#pragma warning disable 0169
		static Delegate GetGetPixelAspectHandler ()
		{
			if (cb_getPixelAspect == null)
				cb_getPixelAspect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPixelAspect);
			return cb_getPixelAspect;
		}

		static IntPtr n_GetPixelAspect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PixelAspect);
		}
#pragma warning restore 0169

		static IntPtr id_getPixelAspect;
		public virtual unsafe global::Org.Jcodec.Common.Model.Rational PixelAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getPixelAspect' and count(parameter)=0]"
			[Register ("getPixelAspect", "()Lorg/jcodec/common/model/Rational;", "GetGetPixelAspectHandler")]
			get {
				if (id_getPixelAspect == IntPtr.Zero)
					id_getPixelAspect = JNIEnv.GetMethodID (class_ref, "getPixelAspect", "()Lorg/jcodec/common/model/Rational;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPixelAspect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelAspect", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPts;
#pragma warning disable 0169
		static Delegate GetGetPtsHandler ()
		{
			if (cb_getPts == null)
				cb_getPts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPts);
			return cb_getPts;
		}

		static IntPtr n_GetPts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pts);
		}
#pragma warning restore 0169

		static IntPtr id_getPts;
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge Pts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getPts' and count(parameter)=0]"
			[Register ("getPts", "()Lorg/jcodec/common/model/RationalLarge;", "GetGetPtsHandler")]
			get {
				if (id_getPts == IntPtr.Zero)
					id_getPts = JNIEnv.GetMethodID (class_ref, "getPts", "()Lorg/jcodec/common/model/RationalLarge;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPts", "()Lorg/jcodec/common/model/RationalLarge;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTapeTimecode;
#pragma warning disable 0169
		static Delegate GetGetTapeTimecodeHandler ()
		{
			if (cb_getTapeTimecode == null)
				cb_getTapeTimecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTapeTimecode);
			return cb_getTapeTimecode;
		}

		static IntPtr n_GetTapeTimecode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Frame __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TapeTimecode);
		}
#pragma warning restore 0169

		static IntPtr id_getTapeTimecode;
		public virtual unsafe global::Org.Jcodec.Common.Model.TapeTimecode TapeTimecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Frame']/method[@name='getTapeTimecode' and count(parameter)=0]"
			[Register ("getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;", "GetGetTapeTimecodeHandler")]
			get {
				if (id_getTapeTimecode == IntPtr.Zero)
					id_getTapeTimecode = JNIEnv.GetMethodID (class_ref, "getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTapeTimecode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
