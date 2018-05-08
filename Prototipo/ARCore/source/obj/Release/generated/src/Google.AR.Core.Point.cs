using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']"
	[global::Android.Runtime.Register ("com/google/ar/core/Point", DoNotGenerateAcw=true)]
	public partial class Point : global::Google.AR.Core.TrackableBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point.OrientationMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Point$OrientationMode", DoNotGenerateAcw=true)]
		public sealed partial class OrientationMode : global::Java.Lang.Enum {


			static IntPtr ESTIMATED_SURFACE_NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point.OrientationMode']/field[@name='ESTIMATED_SURFACE_NORMAL']"
			[Register ("ESTIMATED_SURFACE_NORMAL")]
			public static global::Google.AR.Core.Point.OrientationMode EstimatedSurfaceNormal {
				get {
					if (ESTIMATED_SURFACE_NORMAL_jfieldId == IntPtr.Zero)
						ESTIMATED_SURFACE_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ESTIMATED_SURFACE_NORMAL", "Lcom/google/ar/core/Point$OrientationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ESTIMATED_SURFACE_NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point.OrientationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INITIALIZED_TO_IDENTITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point.OrientationMode']/field[@name='INITIALIZED_TO_IDENTITY']"
			[Register ("INITIALIZED_TO_IDENTITY")]
			public static global::Google.AR.Core.Point.OrientationMode InitializedToIdentity {
				get {
					if (INITIALIZED_TO_IDENTITY_jfieldId == IntPtr.Zero)
						INITIALIZED_TO_IDENTITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZED_TO_IDENTITY", "Lcom/google/ar/core/Point$OrientationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZED_TO_IDENTITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point.OrientationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/Point$OrientationMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OrientationMode); }
			}

			internal OrientationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point.OrientationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Point$OrientationMode;", "")]
			public static unsafe global::Google.AR.Core.Point.OrientationMode ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Point$OrientationMode;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.Point.OrientationMode __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point.OrientationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point.OrientationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Point$OrientationMode;", "")]
			public static unsafe global::Google.AR.Core.Point.OrientationMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/Point$OrientationMode;");
				try {
					return (global::Google.AR.Core.Point.OrientationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Point.OrientationMode));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Point", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Point); }
		}

		protected Point (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/constructor[@name='Point' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Point ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Point)) {
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
			global::Google.AR.Core.Point __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingState;
		public override unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/method[@name='getTrackingState' and count(parameter)=0]"
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
			global::Google.AR.Core.Point __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (pose));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAnchor_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler")]
		public override unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose pose)
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

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Google.AR.Core.Point __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler")]
		public override unsafe bool Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "equals", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getOrientationMode;
#pragma warning disable 0169
		static Delegate GetGetOrientationModeHandler ()
		{
			if (cb_getOrientationMode == null)
				cb_getOrientationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientationMode);
			return cb_getOrientationMode;
		}

		static IntPtr n_GetOrientationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Point __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOrientationMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getOrientationMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/method[@name='getOrientationMode' and count(parameter)=0]"
		[Register ("getOrientationMode", "()Lcom/google/ar/core/Point$OrientationMode;", "GetGetOrientationModeHandler")]
		public virtual unsafe global::Google.AR.Core.Point.OrientationMode GetOrientationMode ()
		{
			if (id_getOrientationMode == IntPtr.Zero)
				id_getOrientationMode = JNIEnv.GetMethodID (class_ref, "getOrientationMode", "()Lcom/google/ar/core/Point$OrientationMode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point.OrientationMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrientationMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point.OrientationMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientationMode", "()Lcom/google/ar/core/Point$OrientationMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Point __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Point> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Point']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "GetGetHashCodeHandler")]
		public override unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hashCode", "()I"));
			} finally {
			}
		}

	}
}
