using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Codecs.Mpeg12 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']"
	[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPSMediaInfo", DoNotGenerateAcw=true)]
	public partial class MPSMediaInfo : global::Org.Jcodec.Containers.Mps.MPSUtils.PESReader {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTimecodeMetadata']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTimecodeMetadata", DoNotGenerateAcw=true)]
		public partial class MPEGTimecodeMetadata : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTimecodeMetadata", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MPEGTimecodeMetadata); }
			}

			protected MPEGTimecodeMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTimecodeMetadata']/constructor[@name='MPSMediaInfo.MPEGTimecodeMetadata' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPSMediaInfo']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;)V", "")]
			public unsafe MPEGTimecodeMetadata (global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (MPEGTimecodeMetadata)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_, __args);
				} finally {
				}
			}

			static Delegate cb_getNumFrames;
#pragma warning disable 0169
			static Delegate GetGetNumFramesHandler ()
			{
				if (cb_getNumFrames == null)
					cb_getNumFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumFrames);
				return cb_getNumFrames;
			}

			static IntPtr n_GetNumFrames (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.NumFrames);
			}
#pragma warning restore 0169

			static IntPtr id_getNumFrames;
			public virtual unsafe string NumFrames {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTimecodeMetadata']/method[@name='getNumFrames' and count(parameter)=0]"
				[Register ("getNumFrames", "()Ljava/lang/String;", "GetGetNumFramesHandler")]
				get {
					if (id_getNumFrames == IntPtr.Zero)
						id_getNumFrames = JNIEnv.GetMethodID (class_ref, "getNumFrames", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNumFrames), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumFrames", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getStartCounter;
#pragma warning disable 0169
			static Delegate GetGetStartCounterHandler ()
			{
				if (cb_getStartCounter == null)
					cb_getStartCounter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartCounter);
				return cb_getStartCounter;
			}

			static IntPtr n_GetStartCounter (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StartCounter);
			}
#pragma warning restore 0169

			static IntPtr id_getStartCounter;
			public virtual unsafe string StartCounter {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTimecodeMetadata']/method[@name='getStartCounter' and count(parameter)=0]"
				[Register ("getStartCounter", "()Ljava/lang/String;", "GetGetStartCounterHandler")]
				get {
					if (id_getStartCounter == IntPtr.Zero)
						id_getStartCounter = JNIEnv.GetMethodID (class_ref, "getStartCounter", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartCounter), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartCounter", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_isDropFrame;
#pragma warning disable 0169
			static Delegate GetIsDropFrameHandler ()
			{
				if (cb_isDropFrame == null)
					cb_isDropFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsDropFrame);
				return cb_isDropFrame;
			}

			static IntPtr n_IsDropFrame (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.IsDropFrame ());
			}
#pragma warning restore 0169

			static IntPtr id_isDropFrame;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTimecodeMetadata']/method[@name='isDropFrame' and count(parameter)=0]"
			[Register ("isDropFrame", "()Ljava/lang/String;", "GetIsDropFrameHandler")]
			public virtual unsafe string IsDropFrame ()
			{
				if (id_isDropFrame == IntPtr.Zero)
					id_isDropFrame = JNIEnv.GetMethodID (class_ref, "isDropFrame", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isDropFrame), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDropFrame", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata", DoNotGenerateAcw=true)]
		public partial class MPEGTrackMetadata : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MPEGTrackMetadata); }
			}

			protected MPEGTrackMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/constructor[@name='MPSMediaInfo.MPEGTrackMetadata' and count(parameter)=2 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPSMediaInfo'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;I)V", "")]
			public unsafe MPEGTrackMetadata (global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __self, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MPEGTrackMetadata)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_I == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_I, __args);
				} finally {
				}
			}

			static Delegate cb_getCodedSize;
#pragma warning disable 0169
			static Delegate GetGetCodedSizeHandler ()
			{
				if (cb_getCodedSize == null)
					cb_getCodedSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodedSize);
				return cb_getCodedSize;
			}

			static IntPtr n_GetCodedSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CodedSize);
			}
#pragma warning restore 0169

			static IntPtr id_getCodedSize;
			public virtual unsafe global::Org.Jcodec.Common.Model.Size CodedSize {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getCodedSize' and count(parameter)=0]"
				[Register ("getCodedSize", "()Lorg/jcodec/common/model/Size;", "GetGetCodedSizeHandler")]
				get {
					if (id_getCodedSize == IntPtr.Zero)
						id_getCodedSize = JNIEnv.GetMethodID (class_ref, "getCodedSize", "()Lorg/jcodec/common/model/Size;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCodedSize), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCodedSize", "()Lorg/jcodec/common/model/Size;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDisplaySize;
#pragma warning disable 0169
			static Delegate GetGetDisplaySizeHandler ()
			{
				if (cb_getDisplaySize == null)
					cb_getDisplaySize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplaySize);
				return cb_getDisplaySize;
			}

			static IntPtr n_GetDisplaySize (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DisplaySize);
			}
#pragma warning restore 0169

			static IntPtr id_getDisplaySize;
			public virtual unsafe global::Org.Jcodec.Common.Model.Size DisplaySize {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getDisplaySize' and count(parameter)=0]"
				[Register ("getDisplaySize", "()Lorg/jcodec/common/model/Size;", "GetGetDisplaySizeHandler")]
				get {
					if (id_getDisplaySize == IntPtr.Zero)
						id_getDisplaySize = JNIEnv.GetMethodID (class_ref, "getDisplaySize", "()Lorg/jcodec/common/model/Size;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplaySize), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Size> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplaySize", "()Lorg/jcodec/common/model/Size;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getDuration;
#pragma warning disable 0169
			static Delegate GetGetDurationHandler ()
			{
				if (cb_getDuration == null)
					cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDuration);
				return cb_getDuration;
			}

			static float n_GetDuration (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Duration;
			}
#pragma warning restore 0169

			static IntPtr id_getDuration;
			public virtual unsafe float Duration {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getDuration' and count(parameter)=0]"
				[Register ("getDuration", "()F", "GetGetDurationHandler")]
				get {
					if (id_getDuration == IntPtr.Zero)
						id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()F");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
						else
							return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()F"));
					} finally {
					}
				}
			}

			static Delegate cb_getFourcc;
#pragma warning disable 0169
			static Delegate GetGetFourccHandler ()
			{
				if (cb_getFourcc == null)
					cb_getFourcc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFourcc);
				return cb_getFourcc;
			}

			static IntPtr n_GetFourcc (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Fourcc);
			}
#pragma warning restore 0169

			static IntPtr id_getFourcc;
			public virtual unsafe string Fourcc {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getFourcc' and count(parameter)=0]"
				[Register ("getFourcc", "()Ljava/lang/String;", "GetGetFourccHandler")]
				get {
					if (id_getFourcc == IntPtr.Zero)
						id_getFourcc = JNIEnv.GetMethodID (class_ref, "getFourcc", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFourcc), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFourcc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getFps;
#pragma warning disable 0169
			static Delegate GetGetFpsHandler ()
			{
				if (cb_getFps == null)
					cb_getFps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFps);
				return cb_getFps;
			}

			static float n_GetFps (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Fps;
			}
#pragma warning restore 0169

			static IntPtr id_getFps;
			public virtual unsafe float Fps {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getFps' and count(parameter)=0]"
				[Register ("getFps", "()F", "GetGetFpsHandler")]
				get {
					if (id_getFps == IntPtr.Zero)
						id_getFps = JNIEnv.GetMethodID (class_ref, "getFps", "()F");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFps);
						else
							return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFps", "()F"));
					} finally {
					}
				}
			}

			static Delegate cb_getFpsR;
#pragma warning disable 0169
			static Delegate GetGetFpsRHandler ()
			{
				if (cb_getFpsR == null)
					cb_getFpsR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFpsR);
				return cb_getFpsR;
			}

			static IntPtr n_GetFpsR (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FpsR);
			}
#pragma warning restore 0169

			static IntPtr id_getFpsR;
			public virtual unsafe global::Org.Jcodec.Common.Model.Rational FpsR {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getFpsR' and count(parameter)=0]"
				[Register ("getFpsR", "()Lorg/jcodec/common/model/Rational;", "GetGetFpsRHandler")]
				get {
					if (id_getFpsR == IntPtr.Zero)
						id_getFpsR = JNIEnv.GetMethodID (class_ref, "getFpsR", "()Lorg/jcodec/common/model/Rational;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFpsR), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.Model.Rational> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFpsR", "()Lorg/jcodec/common/model/Rational;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getNumFrames;
#pragma warning disable 0169
			static Delegate GetGetNumFramesHandler ()
			{
				if (cb_getNumFrames == null)
					cb_getNumFrames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFrames);
				return cb_getNumFrames;
			}

			static int n_GetNumFrames (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NumFrames;
			}
#pragma warning restore 0169

			static IntPtr id_getNumFrames;
			public virtual unsafe int NumFrames {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getNumFrames' and count(parameter)=0]"
				[Register ("getNumFrames", "()I", "GetGetNumFramesHandler")]
				get {
					if (id_getNumFrames == IntPtr.Zero)
						id_getNumFrames = JNIEnv.GetMethodID (class_ref, "getNumFrames", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumFrames);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumFrames", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getTimecode;
#pragma warning disable 0169
			static Delegate GetGetTimecodeHandler ()
			{
				if (cb_getTimecode == null)
					cb_getTimecode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimecode);
				return cb_getTimecode;
			}

			static IntPtr n_GetTimecode (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Timecode);
			}
#pragma warning restore 0169

			static IntPtr id_getTimecode;
			public virtual unsafe global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata Timecode {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getTimecode' and count(parameter)=0]"
				[Register ("getTimecode", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTimecodeMetadata;", "GetGetTimecodeHandler")]
				get {
					if (id_getTimecode == IntPtr.Zero)
						id_getTimecode = JNIEnv.GetMethodID (class_ref, "getTimecode", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTimecodeMetadata;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimecode), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTimecodeMetadata> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimecode", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTimecodeMetadata;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getChannelLables;
#pragma warning disable 0169
			static Delegate GetGetChannelLablesHandler ()
			{
				if (cb_getChannelLables == null)
					cb_getChannelLables = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelLables);
				return cb_getChannelLables;
			}

			static IntPtr n_GetChannelLables (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetChannelLables ());
			}
#pragma warning restore 0169

			static IntPtr id_getChannelLables;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MPEGTrackMetadata']/method[@name='getChannelLables' and count(parameter)=0]"
			[Register ("getChannelLables", "()[Lorg/jcodec/common/model/ChannelLabel;", "GetGetChannelLablesHandler")]
			public virtual unsafe global::Org.Jcodec.Common.Model.ChannelLabel[] GetChannelLables ()
			{
				if (id_getChannelLables == IntPtr.Zero)
					id_getChannelLables = JNIEnv.GetMethodID (class_ref, "getChannelLables", "()[Lorg/jcodec/common/model/ChannelLabel;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelLables), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
					else
						return (global::Org.Jcodec.Common.Model.ChannelLabel[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelLables", "()[Lorg/jcodec/common/model/ChannelLabel;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Jcodec.Common.Model.ChannelLabel));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MediaInfoDone']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MediaInfoDone", DoNotGenerateAcw=true)]
		public partial class MediaInfoDone : global::Java.Lang.RuntimeException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPSMediaInfo$MediaInfoDone", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaInfoDone); }
			}

			protected MediaInfoDone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.MediaInfoDone']/constructor[@name='MPSMediaInfo.MediaInfoDone' and count(parameter)=1 and parameter[1][@type='org.jcodec.codecs.mpeg12.MPSMediaInfo']]"
			[Register (".ctor", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;)V", "")]
			public unsafe MediaInfoDone (global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (MediaInfoDone)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_ == IntPtr.Zero)
						id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/jcodec/codecs/mpeg12/MPSMediaInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lorg_jcodec_codecs_mpeg12_MPSMediaInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.PSM']"
		[global::Android.Runtime.Register ("org/jcodec/codecs/mpeg12/MPSMediaInfo$PSM", DoNotGenerateAcw=true)]
		public partial class PSM : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPSMediaInfo$PSM", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PSM); }
			}

			protected PSM (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo.PSM']/constructor[@name='MPSMediaInfo.PSM' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PSM ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (PSM)) {
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

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/codecs/mpeg12/MPSMediaInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MPSMediaInfo); }
		}

		protected MPSMediaInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/constructor[@name='MPSMediaInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPSMediaInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MPSMediaInfo)) {
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

		static Delegate cb_getAudioTracks;
#pragma warning disable 0169
		static Delegate GetGetAudioTracksHandler ()
		{
			if (cb_getAudioTracks == null)
				cb_getAudioTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioTracks);
			return cb_getAudioTracks;
		}

		static IntPtr n_GetAudioTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.ToLocalJniHandle (__this.AudioTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> AudioTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='getAudioTracks' and count(parameter)=0]"
			[Register ("getAudioTracks", "()Ljava/util/List;", "GetGetAudioTracksHandler")]
			get {
				if (id_getAudioTracks == IntPtr.Zero)
					id_getAudioTracks = JNIEnv.GetMethodID (class_ref, "getAudioTracks", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInfos;
#pragma warning disable 0169
		static Delegate GetGetInfosHandler ()
		{
			if (cb_getInfos == null)
				cb_getInfos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfos);
			return cb_getInfos;
		}

		static IntPtr n_GetInfos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.ToLocalJniHandle (__this.Infos);
		}
#pragma warning restore 0169

		static IntPtr id_getInfos;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> Infos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='getInfos' and count(parameter)=0]"
			[Register ("getInfos", "()Ljava/util/List;", "GetGetInfosHandler")]
			get {
				if (id_getInfos == IntPtr.Zero)
					id_getInfos = JNIEnv.GetMethodID (class_ref, "getInfos", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfos), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfos", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoTrack;
#pragma warning disable 0169
		static Delegate GetGetVideoTrackHandler ()
		{
			if (cb_getVideoTrack == null)
				cb_getVideoTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoTrack);
			return cb_getVideoTrack;
		}

		static IntPtr n_GetVideoTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrack);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoTrack;
		public virtual unsafe global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata VideoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='getVideoTrack' and count(parameter)=0]"
			[Register ("getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;", "GetGetVideoTrackHandler")]
			get {
				if (id_getVideoTrack == IntPtr.Zero)
					id_getVideoTrack = JNIEnv.GetMethodID (class_ref, "getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoTrack), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoTrack", "()Lorg/jcodec/codecs/mpeg12/MPSMediaInfo$MPEGTrackMetadata;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaInfo_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetGetMediaInfo_Ljava_io_File_Handler ()
		{
			if (cb_getMediaInfo_Ljava_io_File_ == null)
				cb_getMediaInfo_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMediaInfo_Ljava_io_File_);
			return cb_getMediaInfo_Ljava_io_File_;
		}

		static IntPtr n_GetMediaInfo_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.ToLocalJniHandle (__this.GetMediaInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMediaInfo_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='getMediaInfo' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getMediaInfo", "(Ljava/io/File;)Ljava/util/List;", "GetGetMediaInfo_Ljava_io_File_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> GetMediaInfo (global::Java.IO.File p0)
		{
			if (id_getMediaInfo_Ljava_io_File_ == IntPtr.Zero)
				id_getMediaInfo_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "getMediaInfo", "(Ljava/io/File;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaInfo_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo.MPEGTrackMetadata>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaInfo", "(Ljava/io/File;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_pes_Ljava_nio_ByteBuffer_JII;
#pragma warning disable 0169
		static Delegate GetPes_Ljava_nio_ByteBuffer_JIIHandler ()
		{
			if (cb_pes_Ljava_nio_ByteBuffer_JII == null)
				cb_pes_Ljava_nio_ByteBuffer_JII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int, int>) n_Pes_Ljava_nio_ByteBuffer_JII);
			return cb_pes_Ljava_nio_ByteBuffer_JII;
		}

		static void n_Pes_Ljava_nio_ByteBuffer_JII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, int p3)
		{
			global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Codecs.Mpeg12.MPSMediaInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pes (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_pes_Ljava_nio_ByteBuffer_JII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.codecs.mpeg12']/class[@name='MPSMediaInfo']/method[@name='pes' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("pes", "(Ljava/nio/ByteBuffer;JII)V", "GetPes_Ljava_nio_ByteBuffer_JIIHandler")]
		protected override unsafe void Pes (global::Java.Nio.ByteBuffer p0, long p1, int p2, int p3)
		{
			if (id_pes_Ljava_nio_ByteBuffer_JII == IntPtr.Zero)
				id_pes_Ljava_nio_ByteBuffer_JII = JNIEnv.GetMethodID (class_ref, "pes", "(Ljava/nio/ByteBuffer;JII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pes_Ljava_nio_ByteBuffer_JII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pes", "(Ljava/nio/ByteBuffer;JII)V"), __args);
			} finally {
			}
		}

	}
}
