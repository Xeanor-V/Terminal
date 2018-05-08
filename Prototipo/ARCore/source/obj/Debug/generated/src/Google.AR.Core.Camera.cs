using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']"
	[global::Android.Runtime.Register ("com/google/ar/core/Camera", DoNotGenerateAcw=true)]
	public partial class Camera : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Camera", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Camera); }
		}

		protected Camera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/constructor[@name='Camera' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Camera ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Camera)) {
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

		static Delegate cb_getDisplayOrientedPose;
#pragma warning disable 0169
		static Delegate GetGetDisplayOrientedPoseHandler ()
		{
			if (cb_getDisplayOrientedPose == null)
				cb_getDisplayOrientedPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayOrientedPose);
			return cb_getDisplayOrientedPose;
		}

		static IntPtr n_GetDisplayOrientedPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayOrientedPose);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayOrientedPose;
		public virtual unsafe global::Google.AR.Core.Pose DisplayOrientedPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getDisplayOrientedPose' and count(parameter)=0]"
			[Register ("getDisplayOrientedPose", "()Lcom/google/ar/core/Pose;", "GetGetDisplayOrientedPoseHandler")]
			get {
				if (id_getDisplayOrientedPose == IntPtr.Zero)
					id_getDisplayOrientedPose = JNIEnv.GetMethodID (class_ref, "getDisplayOrientedPose", "()Lcom/google/ar/core/Pose;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayOrientedPose), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOrientedPose", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pose);
		}
#pragma warning restore 0169

		static IntPtr id_getPose;
		public virtual unsafe global::Google.AR.Core.Pose Pose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getPose' and count(parameter)=0]"
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
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingState;
		public virtual unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getTrackingState' and count(parameter)=0]"
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

		static Delegate cb_getProjectionMatrix_arrayFIFF;
#pragma warning disable 0169
		static Delegate GetGetProjectionMatrix_arrayFIFFHandler ()
		{
			if (cb_getProjectionMatrix_arrayFIFF == null)
				cb_getProjectionMatrix_arrayFIFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, float, float>) n_GetProjectionMatrix_arrayFIFF);
			return cb_getProjectionMatrix_arrayFIFF;
		}

		static void n_GetProjectionMatrix_arrayFIFF (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int offset, float near, float far)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] dest = (float[]) JNIEnv.GetArray (native_dest, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetProjectionMatrix (dest, offset, near, far);
			if (dest != null)
				JNIEnv.CopyArray (dest, native_dest);
		}
#pragma warning restore 0169

		static IntPtr id_getProjectionMatrix_arrayFIFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getProjectionMatrix' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("getProjectionMatrix", "([FIFF)V", "GetGetProjectionMatrix_arrayFIFFHandler")]
		public virtual unsafe void GetProjectionMatrix (float[] dest, int offset, float near, float far)
		{
			if (id_getProjectionMatrix_arrayFIFF == IntPtr.Zero)
				id_getProjectionMatrix_arrayFIFF = JNIEnv.GetMethodID (class_ref, "getProjectionMatrix", "([FIFF)V");
			IntPtr native_dest = JNIEnv.NewArray (dest);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_dest);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (near);
				__args [3] = new JValue (far);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getProjectionMatrix_arrayFIFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProjectionMatrix", "([FIFF)V"), __args);
			} finally {
				if (dest != null) {
					JNIEnv.CopyArray (native_dest, dest);
					JNIEnv.DeleteLocalRef (native_dest);
				}
			}
		}

		static Delegate cb_getViewMatrix_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetViewMatrix_arrayFIHandler ()
		{
			if (cb_getViewMatrix_arrayFI == null)
				cb_getViewMatrix_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetViewMatrix_arrayFI);
			return cb_getViewMatrix_arrayFI;
		}

		static void n_GetViewMatrix_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_viewMatrix, int offset)
		{
			global::Google.AR.Core.Camera __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] viewMatrix = (float[]) JNIEnv.GetArray (native_viewMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetViewMatrix (viewMatrix, offset);
			if (viewMatrix != null)
				JNIEnv.CopyArray (viewMatrix, native_viewMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getViewMatrix_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Camera']/method[@name='getViewMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getViewMatrix", "([FI)V", "GetGetViewMatrix_arrayFIHandler")]
		public virtual unsafe void GetViewMatrix (float[] viewMatrix, int offset)
		{
			if (id_getViewMatrix_arrayFI == IntPtr.Zero)
				id_getViewMatrix_arrayFI = JNIEnv.GetMethodID (class_ref, "getViewMatrix", "([FI)V");
			IntPtr native_viewMatrix = JNIEnv.NewArray (viewMatrix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_viewMatrix);
				__args [1] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getViewMatrix_arrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewMatrix", "([FI)V"), __args);
			} finally {
				if (viewMatrix != null) {
					JNIEnv.CopyArray (native_viewMatrix, viewMatrix);
					JNIEnv.DeleteLocalRef (native_viewMatrix);
				}
			}
		}

	}
}
