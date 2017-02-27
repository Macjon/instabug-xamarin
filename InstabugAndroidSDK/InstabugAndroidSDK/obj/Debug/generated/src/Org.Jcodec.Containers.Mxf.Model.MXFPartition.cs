using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/MXFPartition", DoNotGenerateAcw=true)]
	public partial class MXFPartition : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/MXFPartition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MXFPartition); }
		}

		protected MXFPartition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_MXFPartitionPack_JZZJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/constructor[@name='MXFPartition' and count(parameter)=5 and parameter[1][@type='org.jcodec.containers.mxf.model.MXFPartitionPack'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='long']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/MXFPartitionPack;JZZJ)V", "")]
		public unsafe MXFPartition (global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack p0, long p1, bool p2, bool p3, long p4)
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
				if (((object) this).GetType () != typeof (MXFPartition)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/MXFPartitionPack;JZZJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/MXFPartitionPack;JZZJ)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_MXFPartitionPack_JZZJ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_MXFPartitionPack_JZZJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/MXFPartitionPack;JZZJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_MXFPartitionPack_JZZJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_MXFPartitionPack_JZZJ, __args);
			} finally {
			}
		}

		static Delegate cb_getEssenceFilePos;
#pragma warning disable 0169
		static Delegate GetGetEssenceFilePosHandler ()
		{
			if (cb_getEssenceFilePos == null)
				cb_getEssenceFilePos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEssenceFilePos);
			return cb_getEssenceFilePos;
		}

		static long n_GetEssenceFilePos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EssenceFilePos;
		}
#pragma warning restore 0169

		static IntPtr id_getEssenceFilePos;
		public virtual unsafe long EssenceFilePos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='getEssenceFilePos' and count(parameter)=0]"
			[Register ("getEssenceFilePos", "()J", "GetGetEssenceFilePosHandler")]
			get {
				if (id_getEssenceFilePos == IntPtr.Zero)
					id_getEssenceFilePos = JNIEnv.GetMethodID (class_ref, "getEssenceFilePos", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceFilePos);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceFilePos", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getEssenceLength;
#pragma warning disable 0169
		static Delegate GetGetEssenceLengthHandler ()
		{
			if (cb_getEssenceLength == null)
				cb_getEssenceLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEssenceLength);
			return cb_getEssenceLength;
		}

		static long n_GetEssenceLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EssenceLength;
		}
#pragma warning restore 0169

		static IntPtr id_getEssenceLength;
		public virtual unsafe long EssenceLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='getEssenceLength' and count(parameter)=0]"
			[Register ("getEssenceLength", "()J", "GetGetEssenceLengthHandler")]
			get {
				if (id_getEssenceLength == IntPtr.Zero)
					id_getEssenceLength = JNIEnv.GetMethodID (class_ref, "getEssenceLength", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEssenceLength);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEssenceLength", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isComplete;
#pragma warning disable 0169
		static Delegate GetIsCompleteHandler ()
		{
			if (cb_isComplete == null)
				cb_isComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsComplete);
			return cb_isComplete;
		}

		static bool n_IsComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsComplete;
		}
#pragma warning restore 0169

		static IntPtr id_isComplete;
		public virtual unsafe bool IsComplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='isComplete' and count(parameter)=0]"
			[Register ("isComplete", "()Z", "GetIsCompleteHandler")]
			get {
				if (id_isComplete == IntPtr.Zero)
					id_isComplete = JNIEnv.GetMethodID (class_ref, "isComplete", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isComplete);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isComplete", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPack;
#pragma warning disable 0169
		static Delegate GetGetPackHandler ()
		{
			if (cb_getPack == null)
				cb_getPack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPack);
			return cb_getPack;
		}

		static IntPtr n_GetPack (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pack);
		}
#pragma warning restore 0169

		static IntPtr id_getPack;
		public virtual unsafe global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack Pack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='getPack' and count(parameter)=0]"
			[Register ("getPack", "()Lorg/jcodec/containers/mxf/model/MXFPartitionPack;", "GetGetPackHandler")]
			get {
				if (id_getPack == IntPtr.Zero)
					id_getPack = JNIEnv.GetMethodID (class_ref, "getPack", "()Lorg/jcodec/containers/mxf/model/MXFPartitionPack;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartitionPack> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPack", "()Lorg/jcodec/containers/mxf/model/MXFPartitionPack;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_read_Lorg_jcodec_containers_mxf_model_UL_Ljava_nio_ByteBuffer_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='MXFPartition']/method[@name='read' and count(parameter)=4 and parameter[1][@type='org.jcodec.containers.mxf.model.UL'] and parameter[2][@type='java.nio.ByteBuffer'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("read", "(Lorg/jcodec/containers/mxf/model/UL;Ljava/nio/ByteBuffer;JJ)Lorg/jcodec/containers/mxf/model/MXFPartition;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.MXFPartition Read (global::Org.Jcodec.Containers.Mxf.Model.UL p0, global::Java.Nio.ByteBuffer p1, long p2, long p3)
		{
			if (id_read_Lorg_jcodec_containers_mxf_model_UL_Ljava_nio_ByteBuffer_JJ == IntPtr.Zero)
				id_read_Lorg_jcodec_containers_mxf_model_UL_Ljava_nio_ByteBuffer_JJ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Lorg/jcodec/containers/mxf/model/UL;Ljava/nio/ByteBuffer;JJ)Lorg/jcodec/containers/mxf/model/MXFPartition;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Org.Jcodec.Containers.Mxf.Model.MXFPartition __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.MXFPartition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Lorg_jcodec_containers_mxf_model_UL_Ljava_nio_ByteBuffer_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
