using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/SeekHeadFactory", DoNotGenerateAcw=true)]
	public partial class SeekHeadFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory.SeekMock']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/SeekHeadFactory$SeekMock", DoNotGenerateAcw=true)]
		public partial class SeekMock : global::Java.Lang.Object {


			static IntPtr dataOffset_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory.SeekMock']/field[@name='dataOffset']"
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
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/SeekHeadFactory$SeekMock", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SeekMock); }
			}

			protected SeekMock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory.SeekMock']/constructor[@name='SeekHeadFactory.SeekMock' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SeekMock ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (SeekMock)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

			static IntPtr id_make_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory.SeekMock']/method[@name='make' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlBase']]"
			[Register ("make", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)Lorg/jcodec/containers/mkv/SeekHeadFactory$SeekMock;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.SeekHeadFactory.SeekMock Make (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase p0)
			{
				if (id_make_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ == IntPtr.Zero)
					id_make_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ = JNIEnv.GetStaticMethodID (class_ref, "make", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)Lorg/jcodec/containers/mkv/SeekHeadFactory$SeekMock;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Jcodec.Containers.Mkv.SeekHeadFactory.SeekMock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.SeekHeadFactory.SeekMock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_make_Lorg_jcodec_containers_mkv_boxes_EbmlBase_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/SeekHeadFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeekHeadFactory); }
		}

		protected SeekHeadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']/constructor[@name='SeekHeadFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SeekHeadFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SeekHeadFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
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

		static Delegate cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_jcodec_containers_mkv_boxes_EbmlBase_Handler ()
		{
			if (cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ == null)
				cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_);
			return cb_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
		}

		static void n_Add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.SeekHeadFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.SeekHeadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlBase']]"
		[Register ("add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V", "GetAdd_Lorg_jcodec_containers_mkv_boxes_EbmlBase_Handler")]
		public virtual unsafe void Add (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBase p0)
		{
			if (id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ == IntPtr.Zero)
				id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_jcodec_containers_mkv_boxes_EbmlBase_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/jcodec/containers/mkv/boxes/EbmlBase;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_computeSeekHeadSize;
#pragma warning disable 0169
		static Delegate GetComputeSeekHeadSizeHandler ()
		{
			if (cb_computeSeekHeadSize == null)
				cb_computeSeekHeadSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ComputeSeekHeadSize);
			return cb_computeSeekHeadSize;
		}

		static int n_ComputeSeekHeadSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.SeekHeadFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.SeekHeadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeSeekHeadSize ();
		}
#pragma warning restore 0169

		static IntPtr id_computeSeekHeadSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']/method[@name='computeSeekHeadSize' and count(parameter)=0]"
		[Register ("computeSeekHeadSize", "()I", "GetComputeSeekHeadSizeHandler")]
		public virtual unsafe int ComputeSeekHeadSize ()
		{
			if (id_computeSeekHeadSize == IntPtr.Zero)
				id_computeSeekHeadSize = JNIEnv.GetMethodID (class_ref, "computeSeekHeadSize", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_computeSeekHeadSize);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeSeekHeadSize", "()I"));
			} finally {
			}
		}

		static IntPtr id_estimeteSeekSize_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']/method[@name='estimeteSeekSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("estimeteSeekSize", "(II)I", "")]
		public static unsafe int EstimeteSeekSize (int p0, int p1)
		{
			if (id_estimeteSeekSize_II == IntPtr.Zero)
				id_estimeteSeekSize_II = JNIEnv.GetStaticMethodID (class_ref, "estimeteSeekSize", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_estimeteSeekSize_II, __args);
			} finally {
			}
		}

		static Delegate cb_indexSeekHead;
#pragma warning disable 0169
		static Delegate GetIndexSeekHeadHandler ()
		{
			if (cb_indexSeekHead == null)
				cb_indexSeekHead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IndexSeekHead);
			return cb_indexSeekHead;
		}

		static IntPtr n_IndexSeekHead (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.SeekHeadFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.SeekHeadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IndexSeekHead ());
		}
#pragma warning restore 0169

		static IntPtr id_indexSeekHead;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='SeekHeadFactory']/method[@name='indexSeekHead' and count(parameter)=0]"
		[Register ("indexSeekHead", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;", "GetIndexSeekHeadHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster IndexSeekHead ()
		{
			if (id_indexSeekHead == IntPtr.Zero)
				id_indexSeekHead = JNIEnv.GetMethodID (class_ref, "indexSeekHead", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_indexSeekHead), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "indexSeekHead", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
