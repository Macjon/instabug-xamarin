using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Vp8 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/FilterUtil", DoNotGenerateAcw=true)]
	public partial class FilterUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/vp8/FilterUtil$Segment", DoNotGenerateAcw=true)]
		public partial class Segment : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/vp8/FilterUtil$Segment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Segment); }
			}

			protected Segment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/constructor[@name='FilterUtil.Segment' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Segment ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Segment)) {
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

			static Delegate cb_getSigned;
#pragma warning disable 0169
			static Delegate GetGetSignedHandler ()
			{
				if (cb_getSigned == null)
					cb_getSigned = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSigned);
				return cb_getSigned;
			}

			static IntPtr n_GetSigned (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Signed);
			}
#pragma warning restore 0169

			static IntPtr id_getSigned;
			public virtual unsafe global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment Signed {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='getSigned' and count(parameter)=0]"
				[Register ("getSigned", "()Lorg/jcodec/codecs/vp8/FilterUtil$Segment;", "GetGetSignedHandler")]
				get {
					if (id_getSigned == IntPtr.Zero)
						id_getSigned = JNIEnv.GetMethodID (class_ref, "getSigned", "()Lorg/jcodec/codecs/vp8/FilterUtil$Segment;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSigned), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSigned", "()Lorg/jcodec/codecs/vp8/FilterUtil$Segment;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
#pragma warning disable 0169
			static Delegate GetApplyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_IHandler ()
			{
				if (cb_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == null)
					cb_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ApplyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I);
				return cb_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			}

			static void n_ApplyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ApplyHorizontally (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='applyHorizontally' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[3][@type='int']]"
			[Register ("applyHorizontally", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V", "GetApplyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_IHandler")]
			public virtual unsafe void ApplyHorizontally (global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0, global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1, int p2)
			{
				if (id_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == IntPtr.Zero)
					id_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNIEnv.GetMethodID (class_ref, "applyHorizontally", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyHorizontally_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyHorizontally", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
#pragma warning disable 0169
			static Delegate GetApplyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_IHandler ()
			{
				if (cb_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == null)
					cb_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ApplyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I);
				return cb_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			}

			static void n_ApplyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1 = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.ApplyVertically (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='applyVertically' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[3][@type='int']]"
			[Register ("applyVertically", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V", "GetApplyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_IHandler")]
			public virtual unsafe void ApplyVertically (global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0, global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1, int p2)
			{
				if (id_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == IntPtr.Zero)
					id_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNIEnv.GetMethodID (class_ref, "applyVertically", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyVertically_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyVertically", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_filterSb_III;
#pragma warning disable 0169
			static Delegate GetFilterSb_IIIHandler ()
			{
				if (cb_filterSb_III == null)
					cb_filterSb_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_FilterSb_III);
				return cb_filterSb_III;
			}

			static void n_FilterSb_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FilterSb (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_filterSb_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='filterSb' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("filterSb", "(III)V", "GetFilterSb_IIIHandler")]
			public virtual unsafe void FilterSb (int p0, int p1, int p2)
			{
				if (id_filterSb_III == IntPtr.Zero)
					id_filterSb_III = JNIEnv.GetMethodID (class_ref, "filterSb", "(III)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filterSb_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filterSb", "(III)V"), __args);
				} finally {
				}
			}

			static IntPtr id_horizontal_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='horizontal' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[3][@type='int']]"
			[Register ("horizontal", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)Lorg/jcodec/codecs/vp8/FilterUtil$Segment;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment Horizontal (global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0, global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1, int p2)
			{
				if (id_horizontal_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == IntPtr.Zero)
					id_horizontal_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNIEnv.GetStaticMethodID (class_ref, "horizontal", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)Lorg/jcodec/codecs/vp8/FilterUtil$Segment;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_horizontal_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_isFilterRequired_II;
#pragma warning disable 0169
			static Delegate GetIsFilterRequired_IIHandler ()
			{
				if (cb_isFilterRequired_II == null)
					cb_isFilterRequired_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_IsFilterRequired_II);
				return cb_isFilterRequired_II;
			}

			static bool n_IsFilterRequired_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsFilterRequired (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_isFilterRequired_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='isFilterRequired' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("isFilterRequired", "(II)Z", "GetIsFilterRequired_IIHandler")]
			public virtual unsafe bool IsFilterRequired (int p0, int p1)
			{
				if (id_isFilterRequired_II == IntPtr.Zero)
					id_isFilterRequired_II = JNIEnv.GetMethodID (class_ref, "isFilterRequired", "(II)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFilterRequired_II, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFilterRequired", "(II)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_isHighVariance_I;
#pragma warning disable 0169
			static Delegate GetIsHighVariance_IHandler ()
			{
				if (cb_isHighVariance_I == null)
					cb_isHighVariance_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsHighVariance_I);
				return cb_isHighVariance_I;
			}

			static bool n_IsHighVariance_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsHighVariance (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isHighVariance_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='isHighVariance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isHighVariance", "(I)Z", "GetIsHighVariance_IHandler")]
			public virtual unsafe bool IsHighVariance (int p0)
			{
				if (id_isHighVariance_I == IntPtr.Zero)
					id_isHighVariance_I = JNIEnv.GetMethodID (class_ref, "isHighVariance", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHighVariance_I, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHighVariance", "(I)Z"), __args);
				} finally {
				}
			}

			static IntPtr id_vertical_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil.Segment']/method[@name='vertical' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[2][@type='org.jcodec.codecs.vp8.Macroblock.Subblock'] and parameter[3][@type='int']]"
			[Register ("vertical", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)Lorg/jcodec/codecs/vp8/FilterUtil$Segment;", "")]
			public static unsafe global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment Vertical (global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p0, global::Org.Jcodec.Codecs.Vp8.Macroblock.Subblock p1, int p2)
			{
				if (id_vertical_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I == IntPtr.Zero)
					id_vertical_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I = JNIEnv.GetStaticMethodID (class_ref, "vertical", "(Lorg/jcodec/codecs/vp8/Macroblock$Subblock;Lorg/jcodec/codecs/vp8/Macroblock$Subblock;I)Lorg/jcodec/codecs/vp8/FilterUtil$Segment;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Vp8.FilterUtil.Segment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_vertical_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_Lorg_jcodec_codecs_vp8_Macroblock_Subblock_I, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/vp8/FilterUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilterUtil); }
		}

		protected FilterUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil']/constructor[@name='FilterUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FilterUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FilterUtil)) {
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

		static IntPtr id_loopFilterUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil']/method[@name='loopFilterUV' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("loopFilterUV", "([[Lorg/jcodec/codecs/vp8/Macroblock;IZ)V", "")]
		public static unsafe void LoopFilterUV (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0, int p1, bool p2)
		{
			if (id_loopFilterUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ == IntPtr.Zero)
				id_loopFilterUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ = JNIEnv.GetStaticMethodID (class_ref, "loopFilterUV", "([[Lorg/jcodec/codecs/vp8/Macroblock;IZ)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loopFilterUV_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_loopFilterY_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.vp8']/class[@name='FilterUtil']/method[@name='loopFilterY' and count(parameter)=3 and parameter[1][@type='org.jcodec.codecs.vp8.Macroblock[][]'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("loopFilterY", "([[Lorg/jcodec/codecs/vp8/Macroblock;IZ)V", "")]
		public static unsafe void LoopFilterY (global::Org.Jcodec.Codecs.Vp8.Macroblock[][] p0, int p1, bool p2)
		{
			if (id_loopFilterY_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ == IntPtr.Zero)
				id_loopFilterY_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ = JNIEnv.GetStaticMethodID (class_ref, "loopFilterY", "([[Lorg/jcodec/codecs/vp8/Macroblock;IZ)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loopFilterY_arrayarrayLorg_jcodec_codecs_vp8_Macroblock_IZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
