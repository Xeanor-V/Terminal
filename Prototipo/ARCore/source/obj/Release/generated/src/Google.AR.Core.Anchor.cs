using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']"
	[global::Android.Runtime.Register ("com/google/ar/core/Anchor", DoNotGenerateAcw=true)]
	public partial class Anchor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Anchor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Anchor); }
		}

		protected Anchor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/constructor[@name='Anchor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Anchor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Anchor)) {
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

		static Delegate cb_getPose;
#pragma warning disable 0169
		static Delegate GetGetPoseHandler ()
		{
			if (cb_getPose == null)
				cb_getPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPose);
			return cb_getPose;
		}

		static IntPtr n_GetPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pose);
		}
#pragma warning restore 0169

		static IntPtr id_getPose;
		public virtual unsafe global::Google.AR.Core.Pose Pose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getPose' and count(parameter)=0]"
			[Register ("getPose", "()Lcom/google/ar/core/Pose;", "GetGetPoseHandler")]
			get {
				if (id_getPose == IntPtr.Zero)
					id_getPose = JNIEnv.GetMethodID (class_ref, "getPose", "()Lcom/google/ar/core/Pose;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPose), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPose", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingState;
#pragma warning disable 0169
		static Delegate GetGetTrackingStateHandler ()
		{
			if (cb_getTrackingState == null)
				cb_getTrackingState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingState);
			return cb_getTrackingState;
		}

		static IntPtr n_GetTrackingState (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingState;
		public virtual unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='getTrackingState' and count(parameter)=0]"
			[Register ("getTrackingState", "()Lcom/google/ar/core/TrackingState;", "GetGetTrackingStateHandler")]
			get {
				if (id_getTrackingState == IntPtr.Zero)
					id_getTrackingState = JNIEnv.GetMethodID (class_ref, "getTrackingState", "()Lcom/google/ar/core/TrackingState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackingState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackingState", "()Lcom/google/ar/core/TrackingState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Anchor __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		static IntPtr id_detach;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Anchor']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public virtual unsafe void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detach);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detach", "()V"));
			} finally {
			}
		}

	}
}
