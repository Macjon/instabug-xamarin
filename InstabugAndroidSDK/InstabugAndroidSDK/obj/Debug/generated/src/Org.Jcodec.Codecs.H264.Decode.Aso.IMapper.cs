using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.H264.Decode.Aso {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']"
	[Register ("org/jcodec/codecs/h264/decode/aso/Mapper", "", "Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker")]
	public partial interface IMapper : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='getAddress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAddress", "(I)I", "GetGetAddress_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		int GetAddress (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='getMbX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMbX", "(I)I", "GetGetMbX_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		int GetMbX (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='getMbY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMbY", "(I)I", "GetGetMbY_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		int GetMbY (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='leftAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("leftAvailable", "(I)Z", "GetLeftAvailable_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		bool LeftAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='topAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topAvailable", "(I)Z", "GetTopAvailable_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		bool TopAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='topLeftAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topLeftAvailable", "(I)Z", "GetTopLeftAvailable_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		bool TopLeftAvailable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.h264.decode.aso']/interface[@name='Mapper']/method[@name='topRightAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("topRightAvailable", "(I)Z", "GetTopRightAvailable_IHandler:Org.Jcodec.Codecs.H264.Decode.Aso.IMapperInvoker, InstabugAndroidSDK")]
		bool TopRightAvailable (int p0);

	}

	[global::Android.Runtime.Register ("org/jcodec/codecs/h264/decode/aso/Mapper", DoNotGenerateAcw=true)]
	internal class IMapperInvoker : global::Java.Lang.Object, IMapper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/h264/decode/aso/Mapper");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMapperInvoker); }
		}

		IntPtr class_ref;

		public static IMapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.h264.decode.aso.Mapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddress_I;
#pragma warning disable 0169
		static Delegate GetGetAddress_IHandler ()
		{
			if (cb_getAddress_I == null)
				cb_getAddress_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAddress_I);
			return cb_getAddress_I;
		}

		static int n_GetAddress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAddress (p0);
		}
#pragma warning restore 0169

		IntPtr id_getAddress_I;
		public unsafe int GetAddress (int p0)
		{
			if (id_getAddress_I == IntPtr.Zero)
				id_getAddress_I = JNIEnv.GetMethodID (class_ref, "getAddress", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAddress_I, __args);
		}

		static Delegate cb_getMbX_I;
#pragma warning disable 0169
		static Delegate GetGetMbX_IHandler ()
		{
			if (cb_getMbX_I == null)
				cb_getMbX_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetMbX_I);
			return cb_getMbX_I;
		}

		static int n_GetMbX_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMbX (p0);
		}
#pragma warning restore 0169

		IntPtr id_getMbX_I;
		public unsafe int GetMbX (int p0)
		{
			if (id_getMbX_I == IntPtr.Zero)
				id_getMbX_I = JNIEnv.GetMethodID (class_ref, "getMbX", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMbX_I, __args);
		}

		static Delegate cb_getMbY_I;
#pragma warning disable 0169
		static Delegate GetGetMbY_IHandler ()
		{
			if (cb_getMbY_I == null)
				cb_getMbY_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetMbY_I);
			return cb_getMbY_I;
		}

		static int n_GetMbY_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetMbY (p0);
		}
#pragma warning restore 0169

		IntPtr id_getMbY_I;
		public unsafe int GetMbY (int p0)
		{
			if (id_getMbY_I == IntPtr.Zero)
				id_getMbY_I = JNIEnv.GetMethodID (class_ref, "getMbY", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMbY_I, __args);
		}

		static Delegate cb_leftAvailable_I;
#pragma warning disable 0169
		static Delegate GetLeftAvailable_IHandler ()
		{
			if (cb_leftAvailable_I == null)
				cb_leftAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_LeftAvailable_I);
			return cb_leftAvailable_I;
		}

		static bool n_LeftAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_leftAvailable_I;
		public unsafe bool LeftAvailable (int p0)
		{
			if (id_leftAvailable_I == IntPtr.Zero)
				id_leftAvailable_I = JNIEnv.GetMethodID (class_ref, "leftAvailable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_leftAvailable_I, __args);
		}

		static Delegate cb_topAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopAvailable_IHandler ()
		{
			if (cb_topAvailable_I == null)
				cb_topAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopAvailable_I);
			return cb_topAvailable_I;
		}

		static bool n_TopAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_topAvailable_I;
		public unsafe bool TopAvailable (int p0)
		{
			if (id_topAvailable_I == IntPtr.Zero)
				id_topAvailable_I = JNIEnv.GetMethodID (class_ref, "topAvailable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topAvailable_I, __args);
		}

		static Delegate cb_topLeftAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopLeftAvailable_IHandler ()
		{
			if (cb_topLeftAvailable_I == null)
				cb_topLeftAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopLeftAvailable_I);
			return cb_topLeftAvailable_I;
		}

		static bool n_TopLeftAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopLeftAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_topLeftAvailable_I;
		public unsafe bool TopLeftAvailable (int p0)
		{
			if (id_topLeftAvailable_I == IntPtr.Zero)
				id_topLeftAvailable_I = JNIEnv.GetMethodID (class_ref, "topLeftAvailable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topLeftAvailable_I, __args);
		}

		static Delegate cb_topRightAvailable_I;
#pragma warning disable 0169
		static Delegate GetTopRightAvailable_IHandler ()
		{
			if (cb_topRightAvailable_I == null)
				cb_topRightAvailable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_TopRightAvailable_I);
			return cb_topRightAvailable_I;
		}

		static bool n_TopRightAvailable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.H264.Decode.Aso.IMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopRightAvailable (p0);
		}
#pragma warning restore 0169

		IntPtr id_topRightAvailable_I;
		public unsafe bool TopRightAvailable (int p0)
		{
			if (id_topRightAvailable_I == IntPtr.Zero)
				id_topRightAvailable_I = JNIEnv.GetMethodID (class_ref, "topRightAvailable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_topRightAvailable_I, __args);
		}

	}

}
