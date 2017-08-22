using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Aso {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/aso/FlatMBlockMapper", DoNotGenerateAcw=true)]
	public partial class FlatMBlockMapper : global::Java.Lang.Object, global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/aso/FlatMBlockMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlatMBlockMapper); }
		}

		protected FlatMBlockMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/constructor[@name='FlatMBlockMapper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe FlatMBlockMapper (int frameWidthInMbs, int firstMBAddr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (frameWidthInMbs);
				__args [1] = new JValue (firstMBAddr);
				if (((object) this).GetType () != typeof (FlatMBlockMapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getAddress_I;
#pragma warning disable 0169
		static Delegate GetGetAddress_IHandler ()
		{
			if (cb_getAddress_I == null)
				cb_getAddress_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAddress_I);
			return cb_getAddress_I;
		}

		static int n_GetAddress_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAddress (index);
		}
#pragma warning restore 0169

		static IntPtr id_getAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='getAddress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAddress", "(I)I", "GetGetAddress_IHandler")]
		public virtual unsafe int GetAddress (int index)
		{
			if (id_getAddress_I == IntPtr.Zero)
				id_getAddress_I = JNIEnv.GetMethodID (class_ref, "getAddress", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAddress_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddress", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getMbX_I;
#pragma warning disable 0169
		static Delegate GetGetMbX_IHandler ()
		{
			if (cb_getMbX_I == null)
				cb_getMbX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetMbX_I);
			return cb_getMbX_I;
		}

		static int n_GetMbX_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMbX (index);
		}
#pragma warning restore 0169

		static IntPtr id_getMbX_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='getMbX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMbX", "(I)I", "GetGetMbX_IHandler")]
		public virtual unsafe int GetMbX (int index)
		{
			if (id_getMbX_I == IntPtr.Zero)
				id_getMbX_I = JNIEnv.GetMethodID (class_ref, "getMbX", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMbX_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMbX", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getMbY_I;
#pragma warning disable 0169
		static Delegate GetGetMbY_IHandler ()
		{
			if (cb_getMbY_I == null)
				cb_getMbY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetMbY_I);
			return cb_getMbY_I;
		}

		static int n_GetMbY_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMbY (index);
		}
#pragma warning restore 0169

		static IntPtr id_getMbY_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='getMbY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMbY", "(I)I", "GetGetMbY_IHandler")]
		public virtual unsafe int GetMbY (int index)
		{
			if (id_getMbY_I == IntPtr.Zero)
				id_getMbY_I = JNIEnv.GetMethodID (class_ref, "getMbY", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMbY_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMbY", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_leftAvailable_I;
#pragma warning disable 0169
		static Delegate GetLeftAvailable_IHandler ()
		{
			if (cb_leftAvailable_I == null)
				cb_leftAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_LeftAvailable_I);
			return cb_leftAvailable_I;
		}

		static bool n_LeftAvailable_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftAvailable (index);
		}
#pragma warning restore 0169

		static IntPtr id_leftAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='leftAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leftAvailable", "(I)Z", "GetLeftAvailable_IHandler")]
		public virtual unsafe bool LeftAvailable (int index)
		{
			if (id_leftAvailable_I == IntPtr.Zero)
				id_leftAvailable_I = JNIEnv.GetMethodID (class_ref, "leftAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_leftAvailable_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leftAvailable", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_topAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopAvailable_IHandler ()
		{
			if (cb_topAvailable_I == null)
				cb_topAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopAvailable_I);
			return cb_topAvailable_I;
		}

		static bool n_TopAvailable_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopAvailable (index);
		}
#pragma warning restore 0169

		static IntPtr id_topAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='topAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topAvailable", "(I)Z", "GetTopAvailable_IHandler")]
		public virtual unsafe bool TopAvailable (int index)
		{
			if (id_topAvailable_I == IntPtr.Zero)
				id_topAvailable_I = JNIEnv.GetMethodID (class_ref, "topAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topAvailable_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "topAvailable", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_topLeftAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopLeftAvailable_IHandler ()
		{
			if (cb_topLeftAvailable_I == null)
				cb_topLeftAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopLeftAvailable_I);
			return cb_topLeftAvailable_I;
		}

		static bool n_TopLeftAvailable_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopLeftAvailable (index);
		}
#pragma warning restore 0169

		static IntPtr id_topLeftAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='topLeftAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topLeftAvailable", "(I)Z", "GetTopLeftAvailable_IHandler")]
		public virtual unsafe bool TopLeftAvailable (int index)
		{
			if (id_topLeftAvailable_I == IntPtr.Zero)
				id_topLeftAvailable_I = JNIEnv.GetMethodID (class_ref, "topLeftAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topLeftAvailable_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "topLeftAvailable", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_topRightAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopRightAvailable_IHandler ()
		{
			if (cb_topRightAvailable_I == null)
				cb_topRightAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopRightAvailable_I);
			return cb_topRightAvailable_I;
		}

		static bool n_TopRightAvailable_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.FlatMBlockMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopRightAvailable (index);
		}
#pragma warning restore 0169

		static IntPtr id_topRightAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/class[@name='FlatMBlockMapper']/method[@name='topRightAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topRightAvailable", "(I)Z", "GetTopRightAvailable_IHandler")]
		public virtual unsafe bool TopRightAvailable (int index)
		{
			if (id_topRightAvailable_I == IntPtr.Zero)
				id_topRightAvailable_I = JNIEnv.GetMethodID (class_ref, "topRightAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topRightAvailable_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "topRightAvailable", "(I)Z"), __args);
			} finally {
			}
		}

	}
}
