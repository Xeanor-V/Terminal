using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/google/ar/core/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$LightEstimationMode", DoNotGenerateAcw=true)]
		public sealed partial class LightEstimationMode : global::Java.Lang.Enum {


			static IntPtr AMBIENT_INTENSITY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/field[@name='AMBIENT_INTENSITY']"
			[Register ("AMBIENT_INTENSITY")]
			public static global::Google.AR.Core.Config.LightEstimationMode AmbientIntensity {
				get {
					if (AMBIENT_INTENSITY_jfieldId == IntPtr.Zero)
						AMBIENT_INTENSITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AMBIENT_INTENSITY", "Lcom/google/ar/core/Config$LightEstimationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AMBIENT_INTENSITY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.LightEstimationMode Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/google/ar/core/Config$LightEstimationMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/Config$LightEstimationMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LightEstimationMode); }
			}

			internal LightEstimationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$LightEstimationMode;", "")]
			public static unsafe global::Google.AR.Core.Config.LightEstimationMode ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$LightEstimationMode;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.Config.LightEstimationMode __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.LightEstimationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$LightEstimationMode;", "")]
			public static unsafe global::Google.AR.Core.Config.LightEstimationMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/Config$LightEstimationMode;");
				try {
					return (global::Google.AR.Core.Config.LightEstimationMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.LightEstimationMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$PlaneFindingMode", DoNotGenerateAcw=true)]
		public sealed partial class PlaneFindingMode : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Google.AR.Core.Config.PlaneFindingMode Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lcom/google/ar/core/Config$PlaneFindingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HORIZONTAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/field[@name='HORIZONTAL']"
			[Register ("HORIZONTAL")]
			public static global::Google.AR.Core.Config.PlaneFindingMode Horizontal {
				get {
					if (HORIZONTAL_jfieldId == IntPtr.Zero)
						HORIZONTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HORIZONTAL", "Lcom/google/ar/core/Config$PlaneFindingMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HORIZONTAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/Config$PlaneFindingMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlaneFindingMode); }
			}

			internal PlaneFindingMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$PlaneFindingMode;", "")]
			public static unsafe global::Google.AR.Core.Config.PlaneFindingMode ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$PlaneFindingMode;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.Config.PlaneFindingMode __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.PlaneFindingMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$PlaneFindingMode;", "")]
			public static unsafe global::Google.AR.Core.Config.PlaneFindingMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/Config$PlaneFindingMode;");
				try {
					return (global::Google.AR.Core.Config.PlaneFindingMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.PlaneFindingMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']"
		[global::Android.Runtime.Register ("com/google/ar/core/Config$UpdateMode", DoNotGenerateAcw=true)]
		public sealed partial class UpdateMode : global::Java.Lang.Enum {


			static IntPtr BLOCKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/field[@name='BLOCKING']"
			[Register ("BLOCKING")]
			public static global::Google.AR.Core.Config.UpdateMode Blocking {
				get {
					if (BLOCKING_jfieldId == IntPtr.Zero)
						BLOCKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BLOCKING", "Lcom/google/ar/core/Config$UpdateMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BLOCKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LATEST_CAMERA_IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/field[@name='LATEST_CAMERA_IMAGE']"
			[Register ("LATEST_CAMERA_IMAGE")]
			public static global::Google.AR.Core.Config.UpdateMode LatestCameraImage {
				get {
					if (LATEST_CAMERA_IMAGE_jfieldId == IntPtr.Zero)
						LATEST_CAMERA_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LATEST_CAMERA_IMAGE", "Lcom/google/ar/core/Config$UpdateMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LATEST_CAMERA_IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/Config$UpdateMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UpdateMode); }
			}

			internal UpdateMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$UpdateMode;", "")]
			public static unsafe global::Google.AR.Core.Config.UpdateMode ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/Config$UpdateMode;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.Config.UpdateMode __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config.UpdateMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/Config$UpdateMode;", "")]
			public static unsafe global::Google.AR.Core.Config.UpdateMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/Config$UpdateMode;");
				try {
					return (global::Google.AR.Core.Config.UpdateMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.Config.UpdateMode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Config ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Config)) {
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

		static IntPtr id_ctor_Lcom_google_ar_core_Session_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/constructor[@name='Config' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Session']]"
		[Register (".ctor", "(Lcom/google/ar/core/Session;)V", "")]
		public unsafe Config (global::Google.AR.Core.Session session)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (session);
				if (((object) this).GetType () != typeof (Config)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/ar/core/Session;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/ar/core/Session;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_ar_core_Session_ == IntPtr.Zero)
					id_ctor_Lcom_google_ar_core_Session_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/ar/core/Session;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_ar_core_Session_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_ar_core_Session_, __args);
			} finally {
			}
		}

		static Delegate cb_getLightEstimationMode;
#pragma warning disable 0169
		static Delegate GetGetLightEstimationModeHandler ()
		{
			if (cb_getLightEstimationMode == null)
				cb_getLightEstimationMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLightEstimationMode);
			return cb_getLightEstimationMode;
		}

		static IntPtr n_GetLightEstimationMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetLightEstimationMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getLightEstimationMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getLightEstimationMode' and count(parameter)=0]"
		[Register ("getLightEstimationMode", "()Lcom/google/ar/core/Config$LightEstimationMode;", "GetGetLightEstimationModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.LightEstimationMode GetLightEstimationMode ()
		{
			if (id_getLightEstimationMode == IntPtr.Zero)
				id_getLightEstimationMode = JNIEnv.GetMethodID (class_ref, "getLightEstimationMode", "()Lcom/google/ar/core/Config$LightEstimationMode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLightEstimationMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLightEstimationMode", "()Lcom/google/ar/core/Config$LightEstimationMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPlaneFindingMode;
#pragma warning disable 0169
		static Delegate GetGetPlaneFindingModeHandler ()
		{
			if (cb_getPlaneFindingMode == null)
				cb_getPlaneFindingMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaneFindingMode);
			return cb_getPlaneFindingMode;
		}

		static IntPtr n_GetPlaneFindingMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPlaneFindingMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getPlaneFindingMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getPlaneFindingMode' and count(parameter)=0]"
		[Register ("getPlaneFindingMode", "()Lcom/google/ar/core/Config$PlaneFindingMode;", "GetGetPlaneFindingModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.PlaneFindingMode GetPlaneFindingMode ()
		{
			if (id_getPlaneFindingMode == IntPtr.Zero)
				id_getPlaneFindingMode = JNIEnv.GetMethodID (class_ref, "getPlaneFindingMode", "()Lcom/google/ar/core/Config$PlaneFindingMode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaneFindingMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaneFindingMode", "()Lcom/google/ar/core/Config$PlaneFindingMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUpdateMode;
#pragma warning disable 0169
		static Delegate GetGetUpdateModeHandler ()
		{
			if (cb_getUpdateMode == null)
				cb_getUpdateMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateMode);
			return cb_getUpdateMode;
		}

		static IntPtr n_GetUpdateMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUpdateMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='getUpdateMode' and count(parameter)=0]"
		[Register ("getUpdateMode", "()Lcom/google/ar/core/Config$UpdateMode;", "GetGetUpdateModeHandler")]
		public virtual unsafe global::Google.AR.Core.Config.UpdateMode GetUpdateMode ()
		{
			if (id_getUpdateMode == IntPtr.Zero)
				id_getUpdateMode = JNIEnv.GetMethodID (class_ref, "getUpdateMode", "()Lcom/google/ar/core/Config$UpdateMode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateMode", "()Lcom/google/ar/core/Config$UpdateMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_;
#pragma warning disable 0169
		static Delegate GetSetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_Handler ()
		{
			if (cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ == null)
				cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_);
			return cb_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_;
		}

		static void n_SetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lightEstimationMode)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.LightEstimationMode lightEstimationMode = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.LightEstimationMode> (native_lightEstimationMode, JniHandleOwnership.DoNotTransfer);
			__this.SetLightEstimationMode (lightEstimationMode);
		}
#pragma warning restore 0169

		static IntPtr id_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setLightEstimationMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.LightEstimationMode']]"
		[Register ("setLightEstimationMode", "(Lcom/google/ar/core/Config$LightEstimationMode;)V", "GetSetLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_Handler")]
		public virtual unsafe void SetLightEstimationMode (global::Google.AR.Core.Config.LightEstimationMode lightEstimationMode)
		{
			if (id_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ == IntPtr.Zero)
				id_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_ = JNIEnv.GetMethodID (class_ref, "setLightEstimationMode", "(Lcom/google/ar/core/Config$LightEstimationMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lightEstimationMode);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLightEstimationMode_Lcom_google_ar_core_Config_LightEstimationMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLightEstimationMode", "(Lcom/google/ar/core/Config$LightEstimationMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_;
#pragma warning disable 0169
		static Delegate GetSetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_Handler ()
		{
			if (cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ == null)
				cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_);
			return cb_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_;
		}

		static void n_SetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_planeFindingMode)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.PlaneFindingMode planeFindingMode = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.PlaneFindingMode> (native_planeFindingMode, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaneFindingMode (planeFindingMode);
		}
#pragma warning restore 0169

		static IntPtr id_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setPlaneFindingMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.PlaneFindingMode']]"
		[Register ("setPlaneFindingMode", "(Lcom/google/ar/core/Config$PlaneFindingMode;)V", "GetSetPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_Handler")]
		public virtual unsafe void SetPlaneFindingMode (global::Google.AR.Core.Config.PlaneFindingMode planeFindingMode)
		{
			if (id_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ == IntPtr.Zero)
				id_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_ = JNIEnv.GetMethodID (class_ref, "setPlaneFindingMode", "(Lcom/google/ar/core/Config$PlaneFindingMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (planeFindingMode);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaneFindingMode_Lcom_google_ar_core_Config_PlaneFindingMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaneFindingMode", "(Lcom/google/ar/core/Config$PlaneFindingMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_;
#pragma warning disable 0169
		static Delegate GetSetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_Handler ()
		{
			if (cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ == null)
				cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_);
			return cb_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_;
		}

		static void n_SetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_updateMode)
		{
			global::Google.AR.Core.Config __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config.UpdateMode updateMode = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config.UpdateMode> (native_updateMode, JniHandleOwnership.DoNotTransfer);
			__this.SetUpdateMode (updateMode);
		}
#pragma warning restore 0169

		static IntPtr id_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Config']/method[@name='setUpdateMode' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config.UpdateMode']]"
		[Register ("setUpdateMode", "(Lcom/google/ar/core/Config$UpdateMode;)V", "GetSetUpdateMode_Lcom_google_ar_core_Config_UpdateMode_Handler")]
		public virtual unsafe void SetUpdateMode (global::Google.AR.Core.Config.UpdateMode updateMode)
		{
			if (id_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ == IntPtr.Zero)
				id_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_ = JNIEnv.GetMethodID (class_ref, "setUpdateMode", "(Lcom/google/ar/core/Config$UpdateMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (updateMode);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateMode_Lcom_google_ar_core_Config_UpdateMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdateMode", "(Lcom/google/ar/core/Config$UpdateMode;)V"), __args);
			} finally {
			}
		}

	}
}
