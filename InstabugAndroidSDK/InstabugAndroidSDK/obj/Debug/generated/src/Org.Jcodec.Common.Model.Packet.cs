using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']"
	[global::Android.Runtime.Register ("org/jcodec/common/model/Packet", DoNotGenerateAcw=true)]
	public partial class Packet : global::Java.Lang.Object {


		static IntPtr FRAME_ASC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/field[@name='FRAME_ASC']"
		[Register ("FRAME_ASC")]
		public static global::Java.Util.IComparator FrameAsc {
			get {
				if (FRAME_ASC_jfieldId == IntPtr.Zero)
					FRAME_ASC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FRAME_ASC", "Ljava/util/Comparator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FRAME_ASC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/model/Packet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Packet); }
		}

		protected Packet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=8 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;I)V", "")]
		public unsafe Packet (global::Java.Nio.ByteBuffer p0, long p1, long p2, long p3, long p4, bool p5, global::Org.Jcodec.Common.Model.TapeTimecode p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_I == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Packet_Lorg_jcodec_common_model_TapeTimecode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Packet'] and parameter[2][@type='org.jcodec.common.model.TapeTimecode']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Packet;Lorg/jcodec/common/model/TapeTimecode;)V", "")]
		public unsafe Packet (global::Org.Jcodec.Common.Model.Packet p0, global::Org.Jcodec.Common.Model.TapeTimecode p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Packet;Lorg/jcodec/common/model/TapeTimecode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Packet;Lorg/jcodec/common/model/TapeTimecode;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Packet_Lorg_jcodec_common_model_TapeTimecode_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Packet_Lorg_jcodec_common_model_TapeTimecode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Packet;Lorg/jcodec/common/model/TapeTimecode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Packet_Lorg_jcodec_common_model_TapeTimecode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Packet_Lorg_jcodec_common_model_TapeTimecode_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Packet_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=2 and parameter[1][@type='org.jcodec.common.model.Packet'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Packet;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe Packet (global::Org.Jcodec.Common.Model.Packet p0, global::Java.Nio.ByteBuffer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Packet;Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Packet;Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Packet_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Packet_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Packet;Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Packet_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Packet_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lorg_jcodec_common_model_Packet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.Packet']]"
		[Register (".ctor", "(Lorg/jcodec/common/model/Packet;)V", "")]
		public unsafe Packet (global::Org.Jcodec.Common.Model.Packet p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/common/model/Packet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/common/model/Packet;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_common_model_Packet_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_common_model_Packet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/common/model/Packet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_common_model_Packet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_common_model_Packet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/constructor[@name='Packet' and count(parameter)=7 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='boolean'] and parameter[7][@type='org.jcodec.common.model.TapeTimecode']]"
		[Register (".ctor", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", "")]
		public unsafe Packet (global::Java.Nio.ByteBuffer p0, long p1, long p2, long p3, long p4, bool p5, global::Org.Jcodec.Common.Model.TapeTimecode p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (((object) this).GetType () != typeof (Packet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V", __args);
					return;
				}

				if (id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_ == IntPtr.Zero)
					id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;JJJJZLorg/jcodec/common/model/TapeTimecode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_JJJJZLorg_jcodec_common_model_TapeTimecode_, __args);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_setData_Ljava_nio_ByteBuffer_ == null)
				cb_setData_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_nio_ByteBuffer_);
			return cb_setData_Ljava_nio_ByteBuffer_;
		}

		static void n_SetData_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Ljava_nio_ByteBuffer_;
		public virtual unsafe global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("setData", "(Ljava/nio/ByteBuffer;)V", "GetSetData_Ljava_nio_ByteBuffer_Handler")]
			set {
				if (id_setData_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_setData_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/nio/ByteBuffer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_nio_ByteBuffer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/nio/ByteBuffer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayOrder;
#pragma warning disable 0169
		static Delegate GetGetDisplayOrderHandler ()
		{
			if (cb_getDisplayOrder == null)
				cb_getDisplayOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisplayOrder);
			return cb_getDisplayOrder;
		}

		static int n_GetDisplayOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayOrder;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayOrder_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOrder_IHandler ()
		{
			if (cb_setDisplayOrder_I == null)
				cb_setDisplayOrder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayOrder_I);
			return cb_setDisplayOrder_I;
		}

		static void n_SetDisplayOrder_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayOrder = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayOrder;
		static IntPtr id_setDisplayOrder_I;
		public virtual unsafe int DisplayOrder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getDisplayOrder' and count(parameter)=0]"
			[Register ("getDisplayOrder", "()I", "GetGetDisplayOrderHandler")]
			get {
				if (id_getDisplayOrder == IntPtr.Zero)
					id_getDisplayOrder = JNIEnv.GetMethodID (class_ref, "getDisplayOrder", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayOrder);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOrder", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='setDisplayOrder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisplayOrder", "(I)V", "GetSetDisplayOrder_IHandler")]
			set {
				if (id_setDisplayOrder_I == IntPtr.Zero)
					id_setDisplayOrder_I = JNIEnv.GetMethodID (class_ref, "setDisplayOrder", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayOrder_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayOrder", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDurationD;
#pragma warning disable 0169
		static Delegate GetGetDurationDHandler ()
		{
			if (cb_getDurationD == null)
				cb_getDurationD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDurationD);
			return cb_getDurationD;
		}

		static double n_GetDurationD (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationD;
		}
#pragma warning restore 0169

		static IntPtr id_getDurationD;
		public virtual unsafe double DurationD {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getDurationD' and count(parameter)=0]"
			[Register ("getDurationD", "()D", "GetGetDurationDHandler")]
			get {
				if (id_getDurationD == IntPtr.Zero)
					id_getDurationD = JNIEnv.GetMethodID (class_ref, "getDurationD", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDurationD);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDurationD", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameNo;
#pragma warning disable 0169
		static Delegate GetGetFrameNoHandler ()
		{
			if (cb_getFrameNo == null)
				cb_getFrameNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFrameNo);
			return cb_getFrameNo;
		}

		static long n_GetFrameNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameNo;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameNo;
		public virtual unsafe long FrameNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getFrameNo' and count(parameter)=0]"
			[Register ("getFrameNo", "()J", "GetGetFrameNoHandler")]
			get {
				if (id_getFrameNo == IntPtr.Zero)
					id_getFrameNo = JNIEnv.GetMethodID (class_ref, "getFrameNo", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFrameNo);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameNo", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isKeyFrame;
#pragma warning disable 0169
		static Delegate GetIsKeyFrameHandler ()
		{
			if (cb_isKeyFrame == null)
				cb_isKeyFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKeyFrame);
			return cb_isKeyFrame;
		}

		static bool n_IsKeyFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKeyFrame;
		}
#pragma warning restore 0169

		static IntPtr id_isKeyFrame;
		public virtual unsafe bool IsKeyFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='isKeyFrame' and count(parameter)=0]"
			[Register ("isKeyFrame", "()Z", "GetIsKeyFrameHandler")]
			get {
				if (id_isKeyFrame == IntPtr.Zero)
					id_isKeyFrame = JNIEnv.GetMethodID (class_ref, "isKeyFrame", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isKeyFrame);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isKeyFrame", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPts;
#pragma warning disable 0169
		static Delegate GetGetPtsHandler ()
		{
			if (cb_getPts == null)
				cb_getPts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPts);
			return cb_getPts;
		}

		static long n_GetPts (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pts;
		}
#pragma warning restore 0169

		static IntPtr id_getPts;
		public virtual unsafe long Pts {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getPts' and count(parameter)=0]"
			[Register ("getPts", "()J", "GetGetPtsHandler")]
			get {
				if (id_getPts == IntPtr.Zero)
					id_getPts = JNIEnv.GetMethodID (class_ref, "getPts", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPts);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPts", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getPtsD;
#pragma warning disable 0169
		static Delegate GetGetPtsDHandler ()
		{
			if (cb_getPtsD == null)
				cb_getPtsD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetPtsD);
			return cb_getPtsD;
		}

		static double n_GetPtsD (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PtsD;
		}
#pragma warning restore 0169

		static IntPtr id_getPtsD;
		public virtual unsafe double PtsD {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getPtsD' and count(parameter)=0]"
			[Register ("getPtsD", "()D", "GetGetPtsDHandler")]
			get {
				if (id_getPtsD == IntPtr.Zero)
					id_getPtsD = JNIEnv.GetMethodID (class_ref, "getPtsD", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getPtsD);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPtsD", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getPtsR;
#pragma warning disable 0169
		static Delegate GetGetPtsRHandler ()
		{
			if (cb_getPtsR == null)
				cb_getPtsR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPtsR);
			return cb_getPtsR;
		}

		static IntPtr n_GetPtsR (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PtsR);
		}
#pragma warning restore 0169

		static IntPtr id_getPtsR;
		public virtual unsafe global::Org.Jcodec.Common.Model.RationalLarge PtsR {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getPtsR' and count(parameter)=0]"
			[Register ("getPtsR", "()Lorg/jcodec/common/model/RationalLarge;", "GetGetPtsRHandler")]
			get {
				if (id_getPtsR == IntPtr.Zero)
					id_getPtsR = JNIEnv.GetMethodID (class_ref, "getPtsR", "()Lorg/jcodec/common/model/RationalLarge;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPtsR), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.RationalLarge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPtsR", "()Lorg/jcodec/common/model/RationalLarge;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TapeTimecode);
		}
#pragma warning restore 0169

		static Delegate cb_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_;
#pragma warning disable 0169
		static Delegate GetSetTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_Handler ()
		{
			if (cb_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_ == null)
				cb_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_);
			return cb_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_;
		}

		static void n_SetTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Common.Model.TapeTimecode p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TapeTimecode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTapeTimecode;
		static IntPtr id_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_;
		public virtual unsafe global::Org.Jcodec.Common.Model.TapeTimecode TapeTimecode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getTapeTimecode' and count(parameter)=0]"
			[Register ("getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;", "GetGetTapeTimecodeHandler")]
			get {
				if (id_getTapeTimecode == IntPtr.Zero)
					id_getTapeTimecode = JNIEnv.GetMethodID (class_ref, "getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTapeTimecode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.TapeTimecode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTapeTimecode", "()Lorg/jcodec/common/model/TapeTimecode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='setTapeTimecode' and count(parameter)=1 and parameter[1][@type='org.jcodec.common.model.TapeTimecode']]"
			[Register ("setTapeTimecode", "(Lorg/jcodec/common/model/TapeTimecode;)V", "GetSetTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_Handler")]
			set {
				if (id_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_ == IntPtr.Zero)
					id_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_ = JNIEnv.GetMethodID (class_ref, "setTapeTimecode", "(Lorg/jcodec/common/model/TapeTimecode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTapeTimecode_Lorg_jcodec_common_model_TapeTimecode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTapeTimecode", "(Lorg/jcodec/common/model/TapeTimecode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimescale;
#pragma warning disable 0169
		static Delegate GetGetTimescaleHandler ()
		{
			if (cb_getTimescale == null)
				cb_getTimescale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimescale);
			return cb_getTimescale;
		}

		static long n_GetTimescale (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timescale;
		}
#pragma warning restore 0169

		static IntPtr id_getTimescale;
		public virtual unsafe long Timescale {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='getTimescale' and count(parameter)=0]"
			[Register ("getTimescale", "()J", "GetGetTimescaleHandler")]
			get {
				if (id_getTimescale == IntPtr.Zero)
					id_getTimescale = JNIEnv.GetMethodID (class_ref, "getTimescale", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimescale);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimescale", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_setTimescale_I;
#pragma warning disable 0169
		static Delegate GetSetTimescale_IHandler ()
		{
			if (cb_setTimescale_I == null)
				cb_setTimescale_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimescale_I);
			return cb_setTimescale_I;
		}

		static void n_SetTimescale_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Common.Model.Packet __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Packet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimescale (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimescale_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.model']/class[@name='Packet']/method[@name='setTimescale' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimescale", "(I)V", "GetSetTimescale_IHandler")]
		public virtual unsafe void SetTimescale (int p0)
		{
			if (id_setTimescale_I == IntPtr.Zero)
				id_setTimescale_I = JNIEnv.GetMethodID (class_ref, "setTimescale", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimescale_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimescale", "(I)V"), __args);
			} finally {
			}
		}

	}
}
