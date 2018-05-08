using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']"
	[global::Android.Runtime.Register ("com/google/ar/core/HitResult", DoNotGenerateAcw=true)]
	public partial class HitResult : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/HitResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HitResult); }
		}

		protected HitResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/constructor[@name='HitResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe HitResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HitResult)) {
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

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDistance);
			return cb_getDistance;
		}

		static float n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distance;
		}
#pragma warning restore 0169

		static IntPtr id_getDistance;
		public virtual unsafe float Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()F", "GetGetDistanceHandler")]
			get {
				if (id_getDistance == IntPtr.Zero)
					id_getDistance = JNIEnv.GetMethodID (class_ref, "getDistance", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDistance);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistance", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getHitPose;
#pragma warning disable 0169
		static Delegate GetGetHitPoseHandler ()
		{
			if (cb_getHitPose == null)
				cb_getHitPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHitPose);
			return cb_getHitPose;
		}

		static IntPtr n_GetHitPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HitPose);
		}
#pragma warning restore 0169

		static IntPtr id_getHitPose;
		public virtual unsafe global::Google.AR.Core.Pose HitPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getHitPose' and count(parameter)=0]"
			[Register ("getHitPose", "()Lcom/google/ar/core/Pose;", "GetGetHitPoseHandler")]
			get {
				if (id_getHitPose == IntPtr.Zero)
					id_getHitPose = JNIEnv.GetMethodID (class_ref, "getHitPose", "()Lcom/google/ar/core/Pose;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHitPose), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHitPose", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackable;
#pragma warning disable 0169
		static Delegate GetGetTrackableHandler ()
		{
			if (cb_getTrackable == null)
				cb_getTrackable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackable);
			return cb_getTrackable;
		}

		static IntPtr n_GetTrackable (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trackable);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackable;
		public virtual unsafe global::Google.AR.Core.ITrackable Trackable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='getTrackable' and count(parameter)=0]"
			[Register ("getTrackable", "()Lcom/google/ar/core/Trackable;", "GetGetTrackableHandler")]
			get {
				if (id_getTrackable == IntPtr.Zero)
					id_getTrackable = JNIEnv.GetMethodID (class_ref, "getTrackable", "()Lcom/google/ar/core/Trackable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ITrackable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackable", "()Lcom/google/ar/core/Trackable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAnchor;
#pragma warning disable 0169
		static Delegate GetCreateAnchorHandler ()
		{
			if (cb_createAnchor == null)
				cb_createAnchor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateAnchor);
			return cb_createAnchor;
		}

		static IntPtr n_CreateAnchor (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.HitResult __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.HitResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateAnchor ());
		}
#pragma warning restore 0169

		static IntPtr id_createAnchor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='HitResult']/method[@name='createAnchor' and count(parameter)=0]"
		[Register ("createAnchor", "()Lcom/google/ar/core/Anchor;", "GetCreateAnchorHandler")]
		public virtual unsafe global::Google.AR.Core.Anchor CreateAnchor ()
		{
			if (id_createAnchor == IntPtr.Zero)
				id_createAnchor = JNIEnv.GetMethodID (class_ref, "createAnchor", "()Lcom/google/ar/core/Anchor;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAnchor), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAnchor", "()Lcom/google/ar/core/Anchor;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
