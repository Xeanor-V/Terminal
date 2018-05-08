using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackableBase']"
	[global::Android.Runtime.Register ("com/google/ar/core/TrackableBase", DoNotGenerateAcw=true)]
	public partial class TrackableBase : global::Java.Lang.Object, global::Google.AR.Core.ITrackable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/TrackableBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackableBase); }
		}

		protected TrackableBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAnchors;
#pragma warning disable 0169
		static Delegate GetGetAnchorsHandler ()
		{
			if (cb_getAnchors == null)
				cb_getAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnchors);
			return cb_getAnchors;
		}

		static IntPtr n_GetAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.TrackableBase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackableBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.Anchors);
		}
#pragma warning restore 0169

		static IntPtr id_getAnchors;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> Anchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackableBase']/method[@name='getAnchors' and count(parameter)=0]"
			[Register ("getAnchors", "()Ljava/util/Collection;", "GetGetAnchorsHandler")]
			get {
				if (id_getAnchors == IntPtr.Zero)
					id_getAnchors = JNIEnv.GetMethodID (class_ref, "getAnchors", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnchors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnchors", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.TrackableBase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackableBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingState;
		public virtual unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackableBase']/method[@name='getTrackingState' and count(parameter)=0]"
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

		static Delegate cb_createAnchor_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCreateAnchor_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_createAnchor_Lcom_google_ar_core_Pose_ == null)
				cb_createAnchor_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnchor_Lcom_google_ar_core_Pose_);
			return cb_createAnchor_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_CreateAnchor_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pose)
		{
			global::Google.AR.Core.TrackableBase __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackableBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (pose));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAnchor_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackableBase']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose pose)
		{
			if (id_createAnchor_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_createAnchor_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pose);

				global::Google.AR.Core.Anchor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAnchor_Lcom_google_ar_core_Pose_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
