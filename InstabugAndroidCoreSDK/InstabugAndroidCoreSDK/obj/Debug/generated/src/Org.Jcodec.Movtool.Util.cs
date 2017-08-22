using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Movtool {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util']"
	[global::Android.Runtime.Register ("org/jcodec/movtool/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util.Pair']"
		[global::Android.Runtime.Register ("org/jcodec/movtool/Util$Pair", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class Pair : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/movtool/Util$Pair", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Pair); }
			}

			protected Pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util.Pair']/constructor[@name='Util.Pair' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
			[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
			public unsafe Pair (global::Java.Lang.Object a, global::Java.Lang.Object b)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
				IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_a);
					__args [1] = new JValue (native_b);
					if (((object) this).GetType () != typeof (Pair)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Object;Ljava/lang/Object;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Object;Ljava/lang/Object;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_lang_Object_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_a);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}

			static Delegate cb_getA;
#pragma warning disable 0169
			static Delegate GetGetAHandler ()
			{
				if (cb_getA == null)
					cb_getA = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetA);
				return cb_getA;
			}

			static IntPtr n_GetA (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Movtool.Util.Pair __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Util.Pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetA ());
			}
#pragma warning restore 0169

			static IntPtr id_getA;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util.Pair']/method[@name='getA' and count(parameter)=0]"
			[Register ("getA", "()Ljava/lang/Object;", "GetGetAHandler")]
			public virtual unsafe global::Java.Lang.Object GetA ()
			{
				if (id_getA == IntPtr.Zero)
					id_getA = JNIEnv.GetMethodID (class_ref, "getA", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getA), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getA", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getB;
#pragma warning disable 0169
			static Delegate GetGetBHandler ()
			{
				if (cb_getB == null)
					cb_getB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetB);
				return cb_getB;
			}

			static IntPtr n_GetB (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Movtool.Util.Pair __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Movtool.Util.Pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetB ());
			}
#pragma warning restore 0169

			static IntPtr id_getB;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util.Pair']/method[@name='getB' and count(parameter)=0]"
			[Register ("getB", "()Ljava/lang/Object;", "GetGetBHandler")]
			public virtual unsafe global::Java.Lang.Object GetB ()
			{
				if (id_getB == IntPtr.Zero)
					id_getB = JNIEnv.GetMethodID (class_ref, "getB", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getB), JniHandleOwnership.TransferLocalRef);
					else
						return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getB", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/movtool/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.movtool']/class[@name='Util']/constructor[@name='Util' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Util ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Util)) {
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

	}
}
