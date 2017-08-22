using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlMaster", DoNotGenerateAcw=true)]
	public partial class EbmlMaster : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase {


		static IntPtr children_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/field[@name='children']"
		[Register ("children")]
		public global::System.Collections.IList Children {
			get {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, children_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, children_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr usedSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/field[@name='usedSize']"
		[Register ("usedSize")]
		protected long UsedSize {
			get {
				if (usedSize_jfieldId == IntPtr.Zero)
					usedSize_jfieldId = JNIEnv.GetFieldID (class_ref, "usedSize", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, usedSize_jfieldId);
			}
			set {
				if (usedSize_jfieldId == IntPtr.Zero)
					usedSize_jfieldId = JNIEnv.GetFieldID (class_ref, "usedSize", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, usedSize_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlMaster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlMaster); }
		}

		protected EbmlMaster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/constructor[@name='EbmlMaster' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe EbmlMaster (byte[] id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewArray (id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_id);
				if (((object) this).GetType () != typeof (EbmlMaster)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (id != null) {
					JNIEnv.CopyArray (native_id, id);
					JNIEnv.DeleteLocalRef (native_id);
				}
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
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		public override unsafe global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/method[@name='getData' and count(parameter)=0]"
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
		}

		static Delegate cb_getDataLen;
#pragma warning disable 0169
		static Delegate GetGetDataLenHandler ()
		{
			if (cb_getDataLen == null)
				cb_getDataLen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDataLen);
			return cb_getDataLen;
		}

		static long n_GetDataLen (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataLen;
		}
#pragma warning restore 0169

		static IntPtr id_getDataLen;
		protected virtual unsafe long DataLen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/method[@name='getDataLen' and count(parameter)=0]"
			[Register ("getDataLen", "()J", "GetGetDataLenHandler")]
			get {
				if (id_getDataLen == IntPtr.Zero)
					id_getDataLen = JNIEnv.GetMethodID (class_ref, "getDataLen", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDataLen);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataLen", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_jcodec_containers_mkv_boxes_EbmlBase_Handler ()
		{
			if (cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ == null)
				cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_);
			return cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
		}

		static void n_Add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_elem)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase elem = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase> (native_elem, JniHandleOwnership.DoNotTransfer);
			__this.Add (elem);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlMaster']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlBase']]"
		[Register ("add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V", "GetAdd_Lorg_jcodec_containers_mkv_boxes_EbmlBase_Handler")]
		public virtual unsafe void Add (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase elem)
		{
			if (id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ == IntPtr.Zero)
				id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (elem);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V"), __args);
			} finally {
			}
		}

	}
}
