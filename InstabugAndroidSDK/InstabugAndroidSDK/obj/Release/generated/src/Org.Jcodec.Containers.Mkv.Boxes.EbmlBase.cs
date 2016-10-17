using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlBase", DoNotGenerateAcw=true)]
	public abstract partial class EbmlBase : global::Java.Lang.Object {


		static IntPtr dataLen_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='dataLen']"
		[Register ("dataLen")]
		public int DataLen {
			get {
				if (dataLen_jfieldId == IntPtr.Zero)
					dataLen_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLen", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, dataLen_jfieldId);
			}
			set {
				if (dataLen_jfieldId == IntPtr.Zero)
					dataLen_jfieldId = JNIEnv.GetFieldID (class_ref, "dataLen", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataLen_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dataOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='dataOffset']"
		[Register ("dataOffset")]
		public long DataOffset {
			get {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId);
			}
			set {
				if (dataOffset_jfieldId == IntPtr.Zero)
					dataOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "dataOffset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='id']"
		[Register ("id")]
		public IList<byte> Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr offset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='offset']"
		[Register ("offset")]
		public long Offset {
			get {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, offset_jfieldId);
			}
			set {
				if (offset_jfieldId == IntPtr.Zero)
					offset_jfieldId = JNIEnv.GetFieldID (class_ref, "offset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, offset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr parent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='parent']"
		[Register ("parent")]
		protected global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster Parent {
			get {
				if (parent_jfieldId == IntPtr.Zero)
					parent_jfieldId = JNIEnv.GetFieldID (class_ref, "parent", "Lorg/jcodec/containers/mkv/boxes/EbmlMaster;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, parent_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (parent_jfieldId == IntPtr.Zero)
					parent_jfieldId = JNIEnv.GetFieldID (class_ref, "parent", "Lorg/jcodec/containers/mkv/boxes/EbmlMaster;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, parent_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='type']"
		[Register ("type")]
		public global::Org.Jcodec.Containers.Mkv.MKVType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mkv/MKVType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.MKVType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lorg/jcodec/containers/mkv/MKVType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr typeSizeLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/field[@name='typeSizeLength']"
		[Register ("typeSizeLength")]
		public int TypeSizeLength {
			get {
				if (typeSizeLength_jfieldId == IntPtr.Zero)
					typeSizeLength_jfieldId = JNIEnv.GetFieldID (class_ref, "typeSizeLength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, typeSizeLength_jfieldId);
			}
			set {
				if (typeSizeLength_jfieldId == IntPtr.Zero)
					typeSizeLength_jfieldId = JNIEnv.GetFieldID (class_ref, "typeSizeLength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, typeSizeLength_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlBase); }
		}

		protected EbmlBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/constructor[@name='EbmlBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EbmlBase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EbmlBase)) {
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
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		public abstract global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")] get;
		}

		static Delegate cb_equalId_arrayB;
#pragma warning disable 0169
		static Delegate GetEqualId_arrayBHandler ()
		{
			if (cb_equalId_arrayB == null)
				cb_equalId_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualId_arrayB);
			return cb_equalId_arrayB;
		}

		static bool n_EqualId_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.EqualId (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equalId_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/method[@name='equalId' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("equalId", "([B)Z", "GetEqualId_arrayBHandler")]
		public virtual unsafe bool EqualId (byte[] p0)
		{
			if (id_equalId_arrayB == IntPtr.Zero)
				id_equalId_arrayB = JNIEnv.GetMethodID (class_ref, "equalId", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equalId_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equalId", "([B)Z"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Size);
			return cb_size;
		}

		static long n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "GetSizeHandler")]
		public virtual unsafe long Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()J"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlBase", DoNotGenerateAcw=true)]
	internal partial class EbmlBaseInvoker : EbmlBase {

		public EbmlBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlBaseInvoker); }
		}

		static IntPtr id_getData;
		public override unsafe global::Java.Nio.ByteBuffer Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlBase']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/nio/ByteBuffer;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/nio/ByteBuffer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
