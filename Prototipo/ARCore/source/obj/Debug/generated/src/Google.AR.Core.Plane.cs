using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']"
	[global::Android.Runtime.Register ("com/google/ar/core/Plane", DoNotGenerateAcw=true)]
	public partial class Plane : global::Google.AR.Core.TrackableBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']"
		[global::Android.Runtime.Register ("com/google/ar/core/Plane$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr HORIZONTAL_DOWNWARD_FACING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/field[@name='HORIZONTAL_DOWNWARD_FACING']"
			[Register ("HORIZONTAL_DOWNWARD_FACING")]
			public static global::Google.AR.Core.Plane.Type HorizontalDownwardFacing {
				get {
					if (HORIZONTAL_DOWNWARD_FACING_jfieldId == IntPtr.Zero)
						HORIZONTAL_DOWNWARD_FACING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORIZONTAL_DOWNWARD_FACING", "Lcom/google/ar/core/Plane$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HORIZONTAL_DOWNWARD_FACING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HORIZONTAL_UPWARD_FACING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/field[@name='HORIZONTAL_UPWARD_FACING']"
			[Register ("HORIZONTAL_UPWARD_FACING")]
			public static global::Google.AR.Core.Plane.Type HorizontalUpwardFacing {
				get {
					if (HORIZONTAL_UPWARD_FACING_jfieldId == IntPtr.Zero)
						HORIZONTAL_UPWARD_FACING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORIZONTAL_UPWARD_FACING", "Lcom/google/ar/core/Plane$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HORIZONTAL_UPWARD_FACING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/Plane$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Plane$Type;", "")]
			public static unsafe global::Google.AR.Core.Plane.Type ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Plane$Type;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.Plane.Type __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Plane$Type;", "")]
			public static unsafe global::Google.AR.Core.Plane.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/Plane$Type;");
				try {
					return (global::Google.AR.Core.Plane.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Plane.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Plane", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Plane); }
		}

		protected Plane (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/constructor[@name='Plane' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Plane ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Plane)) {
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

		static Delegate cb_getCenterPose;
#pragma warning disable 0169
		static Delegate GetGetCenterPoseHandler ()
		{
			if (cb_getCenterPose == null)
				cb_getCenterPose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterPose);
			return cb_getCenterPose;
		}

		static IntPtr n_GetCenterPose (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterPose);
		}
#pragma warning restore 0169

		static IntPtr id_getCenterPose;
		public virtual unsafe global::Google.AR.Core.Pose CenterPose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getCenterPose' and count(parameter)=0]"
			[Register ("getCenterPose", "()Lcom/google/ar/core/Pose;", "GetGetCenterPoseHandler")]
			get {
				if (id_getCenterPose == IntPtr.Zero)
					id_getCenterPose = JNIEnv.GetMethodID (class_ref, "getCenterPose", "()Lcom/google/ar/core/Pose;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenterPose), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenterPose", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExtentX;
#pragma warning disable 0169
		static Delegate GetGetExtentXHandler ()
		{
			if (cb_getExtentX == null)
				cb_getExtentX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtentX);
			return cb_getExtentX;
		}

		static float n_GetExtentX (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentX;
		}
#pragma warning restore 0169

		static IntPtr id_getExtentX;
		public virtual unsafe float ExtentX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getExtentX' and count(parameter)=0]"
			[Register ("getExtentX", "()F", "GetGetExtentXHandler")]
			get {
				if (id_getExtentX == IntPtr.Zero)
					id_getExtentX = JNIEnv.GetMethodID (class_ref, "getExtentX", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getExtentX);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtentX", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getExtentZ;
#pragma warning disable 0169
		static Delegate GetGetExtentZHandler ()
		{
			if (cb_getExtentZ == null)
				cb_getExtentZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtentZ);
			return cb_getExtentZ;
		}

		static float n_GetExtentZ (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtentZ;
		}
#pragma warning restore 0169

		static IntPtr id_getExtentZ;
		public virtual unsafe float ExtentZ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getExtentZ' and count(parameter)=0]"
			[Register ("getExtentZ", "()F", "GetGetExtentZHandler")]
			get {
				if (id_getExtentZ == IntPtr.Zero)
					id_getExtentZ = JNIEnv.GetMethodID (class_ref, "getExtentZ", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getExtentZ);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtentZ", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getPolygon;
#pragma warning disable 0169
		static Delegate GetGetPolygonHandler ()
		{
			if (cb_getPolygon == null)
				cb_getPolygon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPolygon);
			return cb_getPolygon;
		}

		static IntPtr n_GetPolygon (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Polygon);
		}
#pragma warning restore 0169

		static IntPtr id_getPolygon;
		public virtual unsafe global::Java.Nio.FloatBuffer Polygon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getPolygon' and count(parameter)=0]"
			[Register ("getPolygon", "()Ljava/nio/FloatBuffer;", "GetGetPolygonHandler")]
			get {
				if (id_getPolygon == IntPtr.Zero)
					id_getPolygon = JNIEnv.GetMethodID (class_ref, "getPolygon", "()Ljava/nio/FloatBuffer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPolygon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPolygon", "()Ljava/nio/FloatBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubsumedBy;
#pragma warning disable 0169
		static Delegate GetGetSubsumedByHandler ()
		{
			if (cb_getSubsumedBy == null)
				cb_getSubsumedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubsumedBy);
			return cb_getSubsumedBy;
		}

		static IntPtr n_GetSubsumedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubsumedBy);
		}
#pragma warning restore 0169

		static IntPtr id_getSubsumedBy;
		public virtual unsafe global::Google.AR.Core.Plane SubsumedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getSubsumedBy' and count(parameter)=0]"
			[Register ("getSubsumedBy", "()Lcom/google/ar/core/Plane;", "GetGetSubsumedByHandler")]
			get {
				if (id_getSubsumedBy == IntPtr.Zero)
					id_getSubsumedBy = JNIEnv.GetMethodID (class_ref, "getSubsumedBy", "()Lcom/google/ar/core/Plane;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubsumedBy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubsumedBy", "()Lcom/google/ar/core/Plane;")), JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingState);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackingState;
		public override unsafe global::Google.AR.Core.TrackingState TrackingState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getTrackingState' and count(parameter)=0]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (pose));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAnchor_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetType ());
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='getType' and count(parameter)=0]"
		[Register ("getType", "()Lcom/google/ar/core/Plane$Type;", "GetGetTypeHandler")]
		public virtual unsafe global::Google.AR.Core.Plane.Type GetType ()
		{
			if (id_getType == IntPtr.Zero)
				id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/google/ar/core/Plane$Type;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane.Type> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/google/ar/core/Plane$Type;")), JniHandleOwnership.TransferLocalRef);
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
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='hashCode' and count(parameter)=0]"
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

		static Delegate cb_isPoseInExtents_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetIsPoseInExtents_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_isPoseInExtents_Lcom_google_ar_core_Pose_ == null)
				cb_isPoseInExtents_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPoseInExtents_Lcom_google_ar_core_Pose_);
			return cb_isPoseInExtents_Lcom_google_ar_core_Pose_;
		}

		static bool n_IsPoseInExtents_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pose)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPoseInExtents (pose);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isPoseInExtents_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='isPoseInExtents' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("isPoseInExtents", "(Lcom/google/ar/core/Pose;)Z", "GetIsPoseInExtents_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe bool IsPoseInExtents (global::Google.AR.Core.Pose pose)
		{
			if (id_isPoseInExtents_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_isPoseInExtents_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "isPoseInExtents", "(Lcom/google/ar/core/Pose;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pose);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPoseInExtents_Lcom_google_ar_core_Pose_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPoseInExtents", "(Lcom/google/ar/core/Pose;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isPoseInPolygon_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetIsPoseInPolygon_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_isPoseInPolygon_Lcom_google_ar_core_Pose_ == null)
				cb_isPoseInPolygon_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsPoseInPolygon_Lcom_google_ar_core_Pose_);
			return cb_isPoseInPolygon_Lcom_google_ar_core_Pose_;
		}

		static bool n_IsPoseInPolygon_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pose)
		{
			global::Google.AR.Core.Plane __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Plane> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsPoseInPolygon (pose);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isPoseInPolygon_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Plane']/method[@name='isPoseInPolygon' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("isPoseInPolygon", "(Lcom/google/ar/core/Pose;)Z", "GetIsPoseInPolygon_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe bool IsPoseInPolygon (global::Google.AR.Core.Pose pose)
		{
			if (id_isPoseInPolygon_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_isPoseInPolygon_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "isPoseInPolygon", "(Lcom/google/ar/core/Pose;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pose);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPoseInPolygon_Lcom_google_ar_core_Pose_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPoseInPolygon", "(Lcom/google/ar/core/Pose;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
