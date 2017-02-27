using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Common.Biari {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/BitIO", DoNotGenerateAcw=true)]
	public partial class BitIO : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/interface[@name='BitIO.InputBits']"
		[Register ("org/jcodec/codecs/common/biari/BitIO$InputBits", "", "Org.Jcodec.Codecs.Common.Biari.BitIO/IInputBitsInvoker")]
		public partial interface IInputBits : IJavaObject {

			int Bit {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/interface[@name='BitIO.InputBits']/method[@name='getBit' and count(parameter)=0]"
				[Register ("getBit", "()I", "GetGetBitHandler:Org.Jcodec.Codecs.Common.Biari.BitIO/IInputBitsInvoker, InstabugAndroidSDK")] get;
			}

		}

		[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/BitIO$InputBits", DoNotGenerateAcw=true)]
		internal class IInputBitsInvoker : global::Java.Lang.Object, IInputBits {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/common/biari/BitIO$InputBits");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInputBitsInvoker); }
			}

			IntPtr class_ref;

			public static IInputBits GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInputBits> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.common.biari.BitIO.InputBits"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInputBitsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getBit;
#pragma warning disable 0169
			static Delegate GetGetBitHandler ()
			{
				if (cb_getBit == null)
					cb_getBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBit);
				return cb_getBit;
			}

			static int n_GetBit (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Bit;
			}
#pragma warning restore 0169

			IntPtr id_getBit;
			public unsafe int Bit {
				get {
					if (id_getBit == IntPtr.Zero)
						id_getBit = JNIEnv.GetMethodID (class_ref, "getBit", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBit);
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/interface[@name='BitIO.OutputBits']"
		[Register ("org/jcodec/codecs/common/biari/BitIO$OutputBits", "", "Org.Jcodec.Codecs.Common.Biari.BitIO/IOutputBitsInvoker")]
		public partial interface IOutputBits : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/interface[@name='BitIO.OutputBits']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "GetFlushHandler:Org.Jcodec.Codecs.Common.Biari.BitIO/IOutputBitsInvoker, InstabugAndroidSDK")]
			void Flush ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/interface[@name='BitIO.OutputBits']/method[@name='putBit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("putBit", "(I)V", "GetPutBit_IHandler:Org.Jcodec.Codecs.Common.Biari.BitIO/IOutputBitsInvoker, InstabugAndroidSDK")]
			void PutBit (int p0);

		}

		[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/BitIO$OutputBits", DoNotGenerateAcw=true)]
		internal class IOutputBitsInvoker : global::Java.Lang.Object, IOutputBits {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/jcodec/codecs/common/biari/BitIO$OutputBits");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOutputBitsInvoker); }
			}

			IntPtr class_ref;

			public static IOutputBits GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOutputBits> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.jcodec.codecs.common.biari.BitIO.OutputBits"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOutputBitsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_flush;
#pragma warning disable 0169
			static Delegate GetFlushHandler ()
			{
				if (cb_flush == null)
					cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
				return cb_flush;
			}

			static void n_Flush (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Flush ();
			}
#pragma warning restore 0169

			IntPtr id_flush;
			public unsafe void Flush ()
			{
				if (id_flush == IntPtr.Zero)
					id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
			}

			static Delegate cb_putBit_I;
#pragma warning disable 0169
			static Delegate GetPutBit_IHandler ()
			{
				if (cb_putBit_I == null)
					cb_putBit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutBit_I);
				return cb_putBit_I;
			}

			static void n_PutBit_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PutBit (p0);
			}
#pragma warning restore 0169

			IntPtr id_putBit_I;
			public unsafe void PutBit (int p0)
			{
				if (id_putBit_I == IntPtr.Zero)
					id_putBit_I = JNIEnv.GetMethodID (class_ref, "putBit", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBit_I, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamInputBits']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/BitIO$StreamInputBits", DoNotGenerateAcw=true)]
		public partial class StreamInputBits : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/BitIO$StreamInputBits", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StreamInputBits); }
			}

			protected StreamInputBits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamInputBits']/constructor[@name='BitIO.StreamInputBits' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public unsafe StreamInputBits (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (StreamInputBits)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_getBit;
#pragma warning disable 0169
			static Delegate GetGetBitHandler ()
			{
				if (cb_getBit == null)
					cb_getBit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBit);
				return cb_getBit;
			}

			static int n_GetBit (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamInputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamInputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Bit;
			}
#pragma warning restore 0169

			static IntPtr id_getBit;
			public virtual unsafe int Bit {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamInputBits']/method[@name='getBit' and count(parameter)=0]"
				[Register ("getBit", "()I", "GetGetBitHandler")]
				get {
					if (id_getBit == IntPtr.Zero)
						id_getBit = JNIEnv.GetMethodID (class_ref, "getBit", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBit);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBit", "()I"));
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamOutputBits']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/common/biari/BitIO$StreamOutputBits", DoNotGenerateAcw=true)]
		public partial class StreamOutputBits : global::Java.Lang.Object, global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/BitIO$StreamOutputBits", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StreamOutputBits); }
			}

			protected StreamOutputBits (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_OutputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamOutputBits']/constructor[@name='BitIO.StreamOutputBits' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
			[Register (".ctor", "(Ljava/io/OutputStream;)V", "")]
			public unsafe StreamOutputBits (global::System.IO.Stream p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (StreamOutputBits)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/OutputStream;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/OutputStream;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_OutputStream_ == IntPtr.Zero)
						id_ctor_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/OutputStream;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_OutputStream_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_OutputStream_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_flush;
#pragma warning disable 0169
			static Delegate GetFlushHandler ()
			{
				if (cb_flush == null)
					cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
				return cb_flush;
			}

			static void n_Flush (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamOutputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamOutputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Flush ();
			}
#pragma warning restore 0169

			static IntPtr id_flush;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamOutputBits']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "GetFlushHandler")]
			public virtual unsafe void Flush ()
			{
				if (id_flush == IntPtr.Zero)
					id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
				} finally {
				}
			}

			static Delegate cb_putBit_I;
#pragma warning disable 0169
			static Delegate GetPutBit_IHandler ()
			{
				if (cb_putBit_I == null)
					cb_putBit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_PutBit_I);
				return cb_putBit_I;
			}

			static void n_PutBit_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamOutputBits __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.StreamOutputBits> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PutBit (p0);
			}
#pragma warning restore 0169

			static IntPtr id_putBit_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO.StreamOutputBits']/method[@name='putBit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("putBit", "(I)V", "GetPutBit_IHandler")]
			public virtual unsafe void PutBit (int p0)
			{
				if (id_putBit_I == IntPtr.Zero)
					id_putBit_I = JNIEnv.GetMethodID (class_ref, "putBit", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBit_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBit", "(I)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/common/biari/BitIO", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitIO); }
		}

		protected BitIO (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/constructor[@name='BitIO' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitIO ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BitIO)) {
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

		static IntPtr id_compressBits_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='compressBits' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("compressBits", "([I)[B", "")]
		public static unsafe byte[] CompressBits (int[] p0)
		{
			if (id_compressBits_arrayI == IntPtr.Zero)
				id_compressBits_arrayI = JNIEnv.GetStaticMethodID (class_ref, "compressBits", "([I)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_compressBits_arrayI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decompressBits_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='decompressBits' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decompressBits", "([B)[I", "")]
		public static unsafe int[] DecompressBits (byte[] p0)
		{
			if (id_decompressBits_arrayB == IntPtr.Zero)
				id_decompressBits_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decompressBits", "([B)[I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decompressBits_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_inputFromArray_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='inputFromArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("inputFromArray", "([B)Lorg/jcodec/codecs/common/biari/BitIO$InputBits;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits InputFromArray (byte[] p0)
		{
			if (id_inputFromArray_arrayB == IntPtr.Zero)
				id_inputFromArray_arrayB = JNIEnv.GetStaticMethodID (class_ref, "inputFromArray", "([B)Lorg/jcodec/codecs/common/biari/BitIO$InputBits;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits> (JNIEnv.CallStaticObjectMethod  (class_ref, id_inputFromArray_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_inputFromStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='inputFromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("inputFromStream", "(Ljava/io/InputStream;)Lorg/jcodec/codecs/common/biari/BitIO$InputBits;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits InputFromStream (global::System.IO.Stream p0)
		{
			if (id_inputFromStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_inputFromStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "inputFromStream", "(Ljava/io/InputStream;)Lorg/jcodec/codecs/common/biari/BitIO$InputBits;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IInputBits> (JNIEnv.CallStaticObjectMethod  (class_ref, id_inputFromStream_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_outputFromArray_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='outputFromArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("outputFromArray", "([B)Lorg/jcodec/codecs/common/biari/BitIO$OutputBits;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits OutputFromArray (byte[] p0)
		{
			if (id_outputFromArray_arrayB == IntPtr.Zero)
				id_outputFromArray_arrayB = JNIEnv.GetStaticMethodID (class_ref, "outputFromArray", "([B)Lorg/jcodec/codecs/common/biari/BitIO$OutputBits;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits> (JNIEnv.CallStaticObjectMethod  (class_ref, id_outputFromArray_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_outputFromStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.common.biari']/class[@name='BitIO']/method[@name='outputFromStream' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("outputFromStream", "(Ljava/io/OutputStream;)Lorg/jcodec/codecs/common/biari/BitIO$OutputBits;", "")]
		public static unsafe global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits OutputFromStream (global::System.IO.Stream p0)
		{
			if (id_outputFromStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_outputFromStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "outputFromStream", "(Ljava/io/OutputStream;)Lorg/jcodec/codecs/common/biari/BitIO$OutputBits;");
			IntPtr native_p0 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Common.Biari.BitIO.IOutputBits> (JNIEnv.CallStaticObjectMethod  (class_ref, id_outputFromStream_Ljava_io_OutputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
