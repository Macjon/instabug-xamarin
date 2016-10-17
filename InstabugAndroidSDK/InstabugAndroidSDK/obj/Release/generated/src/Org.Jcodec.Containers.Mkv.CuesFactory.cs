using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/CuesFactory", DoNotGenerateAcw=true)]
	public partial class CuesFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']"
		[global::Android.Runtime.Register ("org/jcodec/containers/mkv/CuesFactory$CuePointMock", DoNotGenerateAcw=true)]
		public partial class CuePointMock : global::Java.Lang.Object {


			static IntPtr cueClusterPositionSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']/field[@name='cueClusterPositionSize']"
			[Register ("cueClusterPositionSize")]
			public int CueClusterPositionSize {
				get {
					if (cueClusterPositionSize_jfieldId == IntPtr.Zero)
						cueClusterPositionSize_jfieldId = JNIEnv.GetFieldID (class_ref, "cueClusterPositionSize", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cueClusterPositionSize_jfieldId);
				}
				set {
					if (cueClusterPositionSize_jfieldId == IntPtr.Zero)
						cueClusterPositionSize_jfieldId = JNIEnv.GetFieldID (class_ref, "cueClusterPositionSize", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cueClusterPositionSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr elementOffset_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']/field[@name='elementOffset']"
			[Register ("elementOffset")]
			public long ElementOffset {
				get {
					if (elementOffset_jfieldId == IntPtr.Zero)
						elementOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "elementOffset", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, elementOffset_jfieldId);
				}
				set {
					if (elementOffset_jfieldId == IntPtr.Zero)
						elementOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "elementOffset", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, elementOffset_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/containers/mkv/CuesFactory$CuePointMock", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CuePointMock); }
			}

			protected CuePointMock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']/constructor[@name='CuesFactory.CuePointMock' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CuePointMock ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (CuePointMock)) {
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

			static IntPtr id_make_arrayBJJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']/method[@name='make' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
			[Register ("make", "([BJJ)Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock Make (byte[] p0, long p1, long p2)
			{
				if (id_make_arrayBJJ == IntPtr.Zero)
					id_make_arrayBJJ = JNIEnv.GetStaticMethodID (class_ref, "make", "([BJJ)Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_make_arrayBJJ, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_make_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory.CuePointMock']/method[@name='make' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.boxes.EbmlMaster']]"
			[Register ("make", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;)Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;", "")]
			public static unsafe global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock Make (global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster p0)
			{
				if (id_make_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_ == IntPtr.Zero)
					id_make_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_ = JNIEnv.GetStaticMethodID (class_ref, "make", "(Lorg/jcodec/containers/mkv/boxes/EbmlMaster;)Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock> (JNIEnv.CallStaticObjectMethod  (class_ref, id_make_Lorg_jcodec_containers_mkv_boxes_EbmlMaster_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/CuesFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CuesFactory); }
		}

		protected CuesFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/constructor[@name='CuesFactory' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe CuesFactory (long p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CuesFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
					return;
				}

				if (id_ctor_JJ == IntPtr.Zero)
					id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
			} finally {
			}
		}

		static Delegate cb_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_Handler ()
		{
			if (cb_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ == null)
				cb_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_);
			return cb_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
		}

		static void n_Add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.CuesFactory.CuePointMock']]"
		[Register ("add", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V", "GetAdd_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_Handler")]
		public virtual unsafe void Add (global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock p0)
		{
			if (id_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ == IntPtr.Zero)
				id_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
#pragma warning disable 0169
		static Delegate GetAddFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_Handler ()
		{
			if (cb_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ == null)
				cb_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_);
			return cb_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
		}

		static void n_AddFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFixedSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='addFixedSize' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mkv.CuesFactory.CuePointMock']]"
		[Register ("addFixedSize", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V", "GetAddFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_Handler")]
		public virtual unsafe void AddFixedSize (global::Org.Jcodec.Containers.Mkv.CuesFactory.CuePointMock p0)
		{
			if (id_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ == IntPtr.Zero)
				id_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_ = JNIEnv.GetMethodID (class_ref, "addFixedSize", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFixedSize_Lorg_jcodec_containers_mkv_CuesFactory_CuePointMock_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFixedSize", "(Lorg/jcodec/containers/mkv/CuesFactory$CuePointMock;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_computeCuesSize;
#pragma warning disable 0169
		static Delegate GetComputeCuesSizeHandler ()
		{
			if (cb_computeCuesSize == null)
				cb_computeCuesSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ComputeCuesSize);
			return cb_computeCuesSize;
		}

		static int n_ComputeCuesSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeCuesSize ();
		}
#pragma warning restore 0169

		static IntPtr id_computeCuesSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='computeCuesSize' and count(parameter)=0]"
		[Register ("computeCuesSize", "()I", "GetComputeCuesSizeHandler")]
		public virtual unsafe int ComputeCuesSize ()
		{
			if (id_computeCuesSize == IntPtr.Zero)
				id_computeCuesSize = JNIEnv.GetMethodID (class_ref, "computeCuesSize", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_computeCuesSize);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeCuesSize", "()I"));
			} finally {
			}
		}

		static Delegate cb_createCues;
#pragma warning disable 0169
		static Delegate GetCreateCuesHandler ()
		{
			if (cb_createCues == null)
				cb_createCues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateCues);
			return cb_createCues;
		}

		static IntPtr n_CreateCues (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateCues ());
		}
#pragma warning restore 0169

		static IntPtr id_createCues;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='createCues' and count(parameter)=0]"
		[Register ("createCues", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;", "GetCreateCuesHandler")]
		public virtual unsafe global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster CreateCues ()
		{
			if (id_createCues == IntPtr.Zero)
				id_createCues = JNIEnv.GetMethodID (class_ref, "createCues", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createCues), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlMaster> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCues", "()Lorg/jcodec/containers/mkv/boxes/EbmlMaster;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_estimateCuePointSize_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='estimateCuePointSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("estimateCuePointSize", "(III)I", "")]
		public static unsafe int EstimateCuePointSize (int p0, int p1, int p2)
		{
			if (id_estimateCuePointSize_III == IntPtr.Zero)
				id_estimateCuePointSize_III = JNIEnv.GetStaticMethodID (class_ref, "estimateCuePointSize", "(III)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_estimateCuePointSize_III, __args);
			} finally {
			}
		}

		static Delegate cb_estimateFixedSize_I;
#pragma warning disable 0169
		static Delegate GetEstimateFixedSize_IHandler ()
		{
			if (cb_estimateFixedSize_I == null)
				cb_estimateFixedSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_EstimateFixedSize_I);
			return cb_estimateFixedSize_I;
		}

		static int n_EstimateFixedSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EstimateFixedSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_estimateFixedSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='estimateFixedSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("estimateFixedSize", "(I)I", "GetEstimateFixedSize_IHandler")]
		public virtual unsafe int EstimateFixedSize (int p0)
		{
			if (id_estimateFixedSize_I == IntPtr.Zero)
				id_estimateFixedSize_I = JNIEnv.GetMethodID (class_ref, "estimateFixedSize", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_estimateFixedSize_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "estimateFixedSize", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_estimateSize;
#pragma warning disable 0169
		static Delegate GetEstimateSizeHandler ()
		{
			if (cb_estimateSize == null)
				cb_estimateSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_EstimateSize);
			return cb_estimateSize;
		}

		static int n_EstimateSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.CuesFactory __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.CuesFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EstimateSize ();
		}
#pragma warning restore 0169

		static IntPtr id_estimateSize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv']/class[@name='CuesFactory']/method[@name='estimateSize' and count(parameter)=0]"
		[Register ("estimateSize", "()I", "GetEstimateSizeHandler")]
		public virtual unsafe int EstimateSize ()
		{
			if (id_estimateSize == IntPtr.Zero)
				id_estimateSize = JNIEnv.GetMethodID (class_ref, "estimateSize", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_estimateSize);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "estimateSize", "()I"));
			} finally {
			}
		}

	}
}
