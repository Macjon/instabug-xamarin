using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/CDCIEssenceDescriptor", DoNotGenerateAcw=true)]
	public partial class CDCIEssenceDescriptor : global::Org.Jcodec.Containers.Mxf.Model.GenericPictureEssenceDescriptor {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/CDCIEssenceDescriptor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CDCIEssenceDescriptor); }
		}

		protected CDCIEssenceDescriptor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_jcodec_containers_mxf_model_UL_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/constructor[@name='CDCIEssenceDescriptor' and count(parameter)=1 and parameter[1][@type='org.jcodec.containers.mxf.model.UL']]"
		[Register (".ctor", "(Lorg/jcodec/containers/mxf/model/UL;)V", "")]
		public unsafe CDCIEssenceDescriptor (global::Org.Jcodec.Containers.Mxf.Model.UL p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CDCIEssenceDescriptor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/jcodec/containers/mxf/model/UL;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/jcodec/containers/mxf/model/UL;)V", __args);
					return;
				}

				if (id_ctor_Lorg_jcodec_containers_mxf_model_UL_ == IntPtr.Zero)
					id_ctor_Lorg_jcodec_containers_mxf_model_UL_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/containers/mxf/model/UL;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_containers_mxf_model_UL_, __args);
			} finally {
			}
		}

		static Delegate cb_getAlphaSampleDepth;
#pragma warning disable 0169
		static Delegate GetGetAlphaSampleDepthHandler ()
		{
			if (cb_getAlphaSampleDepth == null)
				cb_getAlphaSampleDepth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlphaSampleDepth);
			return cb_getAlphaSampleDepth;
		}

		static int n_GetAlphaSampleDepth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaSampleDepth;
		}
#pragma warning restore 0169

		static IntPtr id_getAlphaSampleDepth;
		public virtual unsafe int AlphaSampleDepth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getAlphaSampleDepth' and count(parameter)=0]"
			[Register ("getAlphaSampleDepth", "()I", "GetGetAlphaSampleDepthHandler")]
			get {
				if (id_getAlphaSampleDepth == IntPtr.Zero)
					id_getAlphaSampleDepth = JNIEnv.GetMethodID (class_ref, "getAlphaSampleDepth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlphaSampleDepth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlphaSampleDepth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBlackRefLevel;
#pragma warning disable 0169
		static Delegate GetGetBlackRefLevelHandler ()
		{
			if (cb_getBlackRefLevel == null)
				cb_getBlackRefLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlackRefLevel);
			return cb_getBlackRefLevel;
		}

		static int n_GetBlackRefLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlackRefLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getBlackRefLevel;
		public virtual unsafe int BlackRefLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getBlackRefLevel' and count(parameter)=0]"
			[Register ("getBlackRefLevel", "()I", "GetGetBlackRefLevelHandler")]
			get {
				if (id_getBlackRefLevel == IntPtr.Zero)
					id_getBlackRefLevel = JNIEnv.GetMethodID (class_ref, "getBlackRefLevel", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBlackRefLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlackRefLevel", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getColorRange;
#pragma warning disable 0169
		static Delegate GetGetColorRangeHandler ()
		{
			if (cb_getColorRange == null)
				cb_getColorRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColorRange);
			return cb_getColorRange;
		}

		static int n_GetColorRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorRange;
		}
#pragma warning restore 0169

		static IntPtr id_getColorRange;
		public virtual unsafe int ColorRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getColorRange' and count(parameter)=0]"
			[Register ("getColorRange", "()I", "GetGetColorRangeHandler")]
			get {
				if (id_getColorRange == IntPtr.Zero)
					id_getColorRange = JNIEnv.GetMethodID (class_ref, "getColorRange", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColorRange);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorRange", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getColorSiting;
#pragma warning disable 0169
		static Delegate GetGetColorSitingHandler ()
		{
			if (cb_getColorSiting == null)
				cb_getColorSiting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetColorSiting);
			return cb_getColorSiting;
		}

		static sbyte n_GetColorSiting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ColorSiting;
		}
#pragma warning restore 0169

		static IntPtr id_getColorSiting;
		public virtual unsafe sbyte ColorSiting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getColorSiting' and count(parameter)=0]"
			[Register ("getColorSiting", "()B", "GetGetColorSitingHandler")]
			get {
				if (id_getColorSiting == IntPtr.Zero)
					id_getColorSiting = JNIEnv.GetMethodID (class_ref, "getColorSiting", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getColorSiting);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorSiting", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getComponentDepth;
#pragma warning disable 0169
		static Delegate GetGetComponentDepthHandler ()
		{
			if (cb_getComponentDepth == null)
				cb_getComponentDepth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComponentDepth);
			return cb_getComponentDepth;
		}

		static int n_GetComponentDepth (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComponentDepth;
		}
#pragma warning restore 0169

		static IntPtr id_getComponentDepth;
		public virtual unsafe int ComponentDepth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getComponentDepth' and count(parameter)=0]"
			[Register ("getComponentDepth", "()I", "GetGetComponentDepthHandler")]
			get {
				if (id_getComponentDepth == IntPtr.Zero)
					id_getComponentDepth = JNIEnv.GetMethodID (class_ref, "getComponentDepth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getComponentDepth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getComponentDepth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHorizontalSubsampling;
#pragma warning disable 0169
		static Delegate GetGetHorizontalSubsamplingHandler ()
		{
			if (cb_getHorizontalSubsampling == null)
				cb_getHorizontalSubsampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHorizontalSubsampling);
			return cb_getHorizontalSubsampling;
		}

		static int n_GetHorizontalSubsampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HorizontalSubsampling;
		}
#pragma warning restore 0169

		static IntPtr id_getHorizontalSubsampling;
		public virtual unsafe int HorizontalSubsampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getHorizontalSubsampling' and count(parameter)=0]"
			[Register ("getHorizontalSubsampling", "()I", "GetGetHorizontalSubsamplingHandler")]
			get {
				if (id_getHorizontalSubsampling == IntPtr.Zero)
					id_getHorizontalSubsampling = JNIEnv.GetMethodID (class_ref, "getHorizontalSubsampling", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHorizontalSubsampling);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHorizontalSubsampling", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPaddingBits;
#pragma warning disable 0169
		static Delegate GetGetPaddingBitsHandler ()
		{
			if (cb_getPaddingBits == null)
				cb_getPaddingBits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetPaddingBits);
			return cb_getPaddingBits;
		}

		static short n_GetPaddingBits (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PaddingBits;
		}
#pragma warning restore 0169

		static IntPtr id_getPaddingBits;
		public virtual unsafe short PaddingBits {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getPaddingBits' and count(parameter)=0]"
			[Register ("getPaddingBits", "()S", "GetGetPaddingBitsHandler")]
			get {
				if (id_getPaddingBits == IntPtr.Zero)
					id_getPaddingBits = JNIEnv.GetMethodID (class_ref, "getPaddingBits", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getPaddingBits);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaddingBits", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getReversedByteOrder;
#pragma warning disable 0169
		static Delegate GetGetReversedByteOrderHandler ()
		{
			if (cb_getReversedByteOrder == null)
				cb_getReversedByteOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetReversedByteOrder);
			return cb_getReversedByteOrder;
		}

		static sbyte n_GetReversedByteOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReversedByteOrder;
		}
#pragma warning restore 0169

		static IntPtr id_getReversedByteOrder;
		public virtual unsafe sbyte ReversedByteOrder {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getReversedByteOrder' and count(parameter)=0]"
			[Register ("getReversedByteOrder", "()B", "GetGetReversedByteOrderHandler")]
			get {
				if (id_getReversedByteOrder == IntPtr.Zero)
					id_getReversedByteOrder = JNIEnv.GetMethodID (class_ref, "getReversedByteOrder", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getReversedByteOrder);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReversedByteOrder", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getVerticalSubsampling;
#pragma warning disable 0169
		static Delegate GetGetVerticalSubsamplingHandler ()
		{
			if (cb_getVerticalSubsampling == null)
				cb_getVerticalSubsampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVerticalSubsampling);
			return cb_getVerticalSubsampling;
		}

		static int n_GetVerticalSubsampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerticalSubsampling;
		}
#pragma warning restore 0169

		static IntPtr id_getVerticalSubsampling;
		public virtual unsafe int VerticalSubsampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getVerticalSubsampling' and count(parameter)=0]"
			[Register ("getVerticalSubsampling", "()I", "GetGetVerticalSubsamplingHandler")]
			get {
				if (id_getVerticalSubsampling == IntPtr.Zero)
					id_getVerticalSubsampling = JNIEnv.GetMethodID (class_ref, "getVerticalSubsampling", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVerticalSubsampling);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerticalSubsampling", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWhiteReflevel;
#pragma warning disable 0169
		static Delegate GetGetWhiteReflevelHandler ()
		{
			if (cb_getWhiteReflevel == null)
				cb_getWhiteReflevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWhiteReflevel);
			return cb_getWhiteReflevel;
		}

		static int n_GetWhiteReflevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.CDCIEssenceDescriptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WhiteReflevel;
		}
#pragma warning restore 0169

		static IntPtr id_getWhiteReflevel;
		public virtual unsafe int WhiteReflevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='CDCIEssenceDescriptor']/method[@name='getWhiteReflevel' and count(parameter)=0]"
			[Register ("getWhiteReflevel", "()I", "GetGetWhiteReflevelHandler")]
			get {
				if (id_getWhiteReflevel == IntPtr.Zero)
					id_getWhiteReflevel = JNIEnv.GetMethodID (class_ref, "getWhiteReflevel", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWhiteReflevel);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWhiteReflevel", "()I"));
				} finally {
				}
			}
		}

	}
}
