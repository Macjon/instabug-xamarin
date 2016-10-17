using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/TapeTimecode", DoNotGenerateAcw=true)]
	public partial class TapeTimecode : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/TapeTimecode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TapeTimecode); }
		}

		protected TapeTimecode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_SBBBZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/constructor[@name='TapeTimecode' and count(parameter)=5 and parameter[1][@type='short'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(SBBBZ)V", "")]
		public unsafe TapeTimecode (short p0, sbyte p1, sbyte p2, sbyte p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (TapeTimecode)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(SBBBZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(SBBBZ)V", __args);
					return;
				}

				if (id_ctor_SBBBZ == IntPtr.Zero)
					id_ctor_SBBBZ = JNIEnv.GetMethodID (class_ref, "<init>", "(SBBBZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_SBBBZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_SBBBZ, __args);
			} finally {
			}
		}

		static Delegate cb_getFrame;
#pragma warning disable 0169
		static Delegate GetGetFrameHandler ()
		{
			if (cb_getFrame == null)
				cb_getFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetFrame);
			return cb_getFrame;
		}

		static sbyte n_GetFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.TapeTimecode __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Frame;
		}
#pragma warning restore 0169

		static IntPtr id_getFrame;
		public virtual unsafe sbyte Frame {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/method[@name='getFrame' and count(parameter)=0]"
			[Register ("getFrame", "()B", "GetGetFrameHandler")]
			get {
				if (id_getFrame == IntPtr.Zero)
					id_getFrame = JNIEnv.GetMethodID (class_ref, "getFrame", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getFrame);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrame", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getHour;
#pragma warning disable 0169
		static Delegate GetGetHourHandler ()
		{
			if (cb_getHour == null)
				cb_getHour = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetHour);
			return cb_getHour;
		}

		static short n_GetHour (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.TapeTimecode __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hour;
		}
#pragma warning restore 0169

		static IntPtr id_getHour;
		public virtual unsafe short Hour {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/method[@name='getHour' and count(parameter)=0]"
			[Register ("getHour", "()S", "GetGetHourHandler")]
			get {
				if (id_getHour == IntPtr.Zero)
					id_getHour = JNIEnv.GetMethodID (class_ref, "getHour", "()S");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getHour);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHour", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_isDropFrame;
#pragma warning disable 0169
		static Delegate GetIsDropFrameHandler ()
		{
			if (cb_isDropFrame == null)
				cb_isDropFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDropFrame);
			return cb_isDropFrame;
		}

		static bool n_IsDropFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.TapeTimecode __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDropFrame;
		}
#pragma warning restore 0169

		static IntPtr id_isDropFrame;
		public virtual unsafe bool IsDropFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/method[@name='isDropFrame' and count(parameter)=0]"
			[Register ("isDropFrame", "()Z", "GetIsDropFrameHandler")]
			get {
				if (id_isDropFrame == IntPtr.Zero)
					id_isDropFrame = JNIEnv.GetMethodID (class_ref, "isDropFrame", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDropFrame);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDropFrame", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinute;
#pragma warning disable 0169
		static Delegate GetGetMinuteHandler ()
		{
			if (cb_getMinute == null)
				cb_getMinute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetMinute);
			return cb_getMinute;
		}

		static sbyte n_GetMinute (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.TapeTimecode __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minute;
		}
#pragma warning restore 0169

		static IntPtr id_getMinute;
		public virtual unsafe sbyte Minute {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/method[@name='getMinute' and count(parameter)=0]"
			[Register ("getMinute", "()B", "GetGetMinuteHandler")]
			get {
				if (id_getMinute == IntPtr.Zero)
					id_getMinute = JNIEnv.GetMethodID (class_ref, "getMinute", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getMinute);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinute", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getSecond;
#pragma warning disable 0169
		static Delegate GetGetSecondHandler ()
		{
			if (cb_getSecond == null)
				cb_getSecond = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSecond);
			return cb_getSecond;
		}

		static sbyte n_GetSecond (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.TapeTimecode __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Second;
		}
#pragma warning restore 0169

		static IntPtr id_getSecond;
		public virtual unsafe sbyte Second {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='TapeTimecode']/method[@name='getSecond' and count(parameter)=0]"
			[Register ("getSecond", "()B", "GetGetSecondHandler")]
			get {
				if (id_getSecond == IntPtr.Zero)
					id_getSecond = JNIEnv.GetMethodID (class_ref, "getSecond", "()B");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getSecond);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecond", "()B"));
				} finally {
				}
			}
		}

	}
}
