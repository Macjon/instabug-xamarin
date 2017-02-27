using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mp4/Chunk", DoNotGenerateAcw=true)]
	public partial class Chunk : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mp4/Chunk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Chunk); }
		}

		protected Chunk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJIIarrayIIarrayII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/constructor[@name='Chunk' and count(parameter)=8 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int'] and parameter[7][@type='int[]'] and parameter[8][@type='int']]"
		[Register (".ctor", "(JJII[II[II)V", "")]
		public unsafe Chunk (long p0, long p1, int p2, int p3, int[] p4, int p5, int[] p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (Chunk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJII[II[II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJII[II[II)V", __args);
					return;
				}

				if (id_ctor_JJIIarrayIIarrayII == IntPtr.Zero)
					id_ctor_JJIIarrayIIarrayII = JNIEnv.GetMethodID (class_ref, "<init>", "(JJII[II[II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJIIarrayIIarrayII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJIIarrayIIarrayII, __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDuration);
			return cb_getDuration;
		}

		static int n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe int Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()I", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEntry;
#pragma warning disable 0169
		static Delegate GetGetEntryHandler ()
		{
			if (cb_getEntry == null)
				cb_getEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntry);
			return cb_getEntry;
		}

		static int n_GetEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Entry;
		}
#pragma warning restore 0169

		static IntPtr id_getEntry;
		public virtual unsafe int Entry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getEntry' and count(parameter)=0]"
			[Register ("getEntry", "()I", "GetGetEntryHandler")]
			get {
				if (id_getEntry == IntPtr.Zero)
					id_getEntry = JNIEnv.GetMethodID (class_ref, "getEntry", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntry);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntry", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
			return cb_getOffset;
		}

		static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		public virtual unsafe long Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()J", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleCount;
#pragma warning disable 0169
		static Delegate GetGetSampleCountHandler ()
		{
			if (cb_getSampleCount == null)
				cb_getSampleCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampleCount);
			return cb_getSampleCount;
		}

		static int n_GetSampleCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleCount;
		}
#pragma warning restore 0169

		static IntPtr id_getSampleCount;
		public virtual unsafe int SampleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSampleCount' and count(parameter)=0]"
			[Register ("getSampleCount", "()I", "GetGetSampleCountHandler")]
			get {
				if (id_getSampleCount == IntPtr.Zero)
					id_getSampleCount = JNIEnv.GetMethodID (class_ref, "getSampleCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampleCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleDur;
#pragma warning disable 0169
		static Delegate GetGetSampleDurHandler ()
		{
			if (cb_getSampleDur == null)
				cb_getSampleDur = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampleDur);
			return cb_getSampleDur;
		}

		static int n_GetSampleDur (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleDur;
		}
#pragma warning restore 0169

		static IntPtr id_getSampleDur;
		public virtual unsafe int SampleDur {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSampleDur' and count(parameter)=0]"
			[Register ("getSampleDur", "()I", "GetGetSampleDurHandler")]
			get {
				if (id_getSampleDur == IntPtr.Zero)
					id_getSampleDur = JNIEnv.GetMethodID (class_ref, "getSampleDur", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampleDur);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleDur", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleSize;
#pragma warning disable 0169
		static Delegate GetGetSampleSizeHandler ()
		{
			if (cb_getSampleSize == null)
				cb_getSampleSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampleSize);
			return cb_getSampleSize;
		}

		static int n_GetSampleSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleSize;
		}
#pragma warning restore 0169

		static IntPtr id_getSampleSize;
		public virtual unsafe int SampleSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSampleSize' and count(parameter)=0]"
			[Register ("getSampleSize", "()I", "GetGetSampleSizeHandler")]
			get {
				if (id_getSampleSize == IntPtr.Zero)
					id_getSampleSize = JNIEnv.GetMethodID (class_ref, "getSampleSize", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSampleSize);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleSize", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSize);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getStartTv;
#pragma warning disable 0169
		static Delegate GetGetStartTvHandler ()
		{
			if (cb_getStartTv == null)
				cb_getStartTv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartTv);
			return cb_getStartTv;
		}

		static long n_GetStartTv (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTv;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTv;
		public virtual unsafe long StartTv {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getStartTv' and count(parameter)=0]"
			[Register ("getStartTv", "()J", "GetGetStartTvHandler")]
			get {
				if (id_getStartTv == IntPtr.Zero)
					id_getStartTv = JNIEnv.GetMethodID (class_ref, "getStartTv", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartTv);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTv", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSampleDurs;
#pragma warning disable 0169
		static Delegate GetGetSampleDursHandler ()
		{
			if (cb_getSampleDurs == null)
				cb_getSampleDurs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSampleDurs);
			return cb_getSampleDurs;
		}

		static IntPtr n_GetSampleDurs (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSampleDurs ());
		}
#pragma warning restore 0169

		static IntPtr id_getSampleDurs;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSampleDurs' and count(parameter)=0]"
		[Register ("getSampleDurs", "()[I", "GetGetSampleDursHandler")]
		public virtual unsafe int[] GetSampleDurs ()
		{
			if (id_getSampleDurs == IntPtr.Zero)
				id_getSampleDurs = JNIEnv.GetMethodID (class_ref, "getSampleDurs", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSampleDurs), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleDurs", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getSampleSizes;
#pragma warning disable 0169
		static Delegate GetGetSampleSizesHandler ()
		{
			if (cb_getSampleSizes == null)
				cb_getSampleSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSampleSizes);
			return cb_getSampleSizes;
		}

		static IntPtr n_GetSampleSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mp4.Chunk __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mp4.Chunk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSampleSizes ());
		}
#pragma warning restore 0169

		static IntPtr id_getSampleSizes;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mp4']/class[@name='Chunk']/method[@name='getSampleSizes' and count(parameter)=0]"
		[Register ("getSampleSizes", "()[I", "GetGetSampleSizesHandler")]
		public virtual unsafe int[] GetSampleSizes ()
		{
			if (id_getSampleSizes == IntPtr.Zero)
				id_getSampleSizes = JNIEnv.GetMethodID (class_ref, "getSampleSizes", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSampleSizes), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSampleSizes", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
