using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']"
	[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk", DoNotGenerateAcw=true)]
	public partial class ArCoreApk : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$Availability", DoNotGenerateAcw=true)]
		public partial class Availability : global::Java.Lang.Enum {


			static IntPtr SUPPORTED_APK_TOO_OLD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_APK_TOO_OLD']"
			[Register ("SUPPORTED_APK_TOO_OLD")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedApkTooOld {
				get {
					if (SUPPORTED_APK_TOO_OLD_jfieldId == IntPtr.Zero)
						SUPPORTED_APK_TOO_OLD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORTED_APK_TOO_OLD", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORTED_APK_TOO_OLD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUPPORTED_INSTALLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_INSTALLED']"
			[Register ("SUPPORTED_INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedInstalled {
				get {
					if (SUPPORTED_INSTALLED_jfieldId == IntPtr.Zero)
						SUPPORTED_INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORTED_INSTALLED", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORTED_INSTALLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUPPORTED_NOT_INSTALLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='SUPPORTED_NOT_INSTALLED']"
			[Register ("SUPPORTED_NOT_INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.Availability SupportedNotInstalled {
				get {
					if (SUPPORTED_NOT_INSTALLED_jfieldId == IntPtr.Zero)
						SUPPORTED_NOT_INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORTED_NOT_INSTALLED", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORTED_NOT_INSTALLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_CHECKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_CHECKING']"
			[Register ("UNKNOWN_CHECKING")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownChecking {
				get {
					if (UNKNOWN_CHECKING_jfieldId == IntPtr.Zero)
						UNKNOWN_CHECKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_CHECKING", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_CHECKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_ERROR']"
			[Register ("UNKNOWN_ERROR")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownError {
				get {
					if (UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
						UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_ERROR", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_TIMED_OUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNKNOWN_TIMED_OUT']"
			[Register ("UNKNOWN_TIMED_OUT")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnknownTimedOut {
				get {
					if (UNKNOWN_TIMED_OUT_jfieldId == IntPtr.Zero)
						UNKNOWN_TIMED_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_TIMED_OUT", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_TIMED_OUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNSUPPORTED_DEVICE_NOT_CAPABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/field[@name='UNSUPPORTED_DEVICE_NOT_CAPABLE']"
			[Register ("UNSUPPORTED_DEVICE_NOT_CAPABLE")]
			public static global::Google.AR.Core.ArCoreApk.Availability UnsupportedDeviceNotCapable {
				get {
					if (UNSUPPORTED_DEVICE_NOT_CAPABLE_jfieldId == IntPtr.Zero)
						UNSUPPORTED_DEVICE_NOT_CAPABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSUPPORTED_DEVICE_NOT_CAPABLE", "Lcom/google/ar/core/ArCoreApk$Availability;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSUPPORTED_DEVICE_NOT_CAPABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/ArCoreApk$Availability", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Availability); }
			}

			protected Availability (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isSupported;
#pragma warning disable 0169
			static Delegate GetIsSupportedHandler ()
			{
				if (cb_isSupported == null)
					cb_isSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupported);
				return cb_isSupported;
			}

			static bool n_IsSupported (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSupported;
			}
#pragma warning restore 0169

			static IntPtr id_isSupported;
			public virtual unsafe bool IsSupported {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isSupported' and count(parameter)=0]"
				[Register ("isSupported", "()Z", "GetIsSupportedHandler")]
				get {
					if (id_isSupported == IntPtr.Zero)
						id_isSupported = JNIEnv.GetMethodID (class_ref, "isSupported", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupported);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupported", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isTransient;
#pragma warning disable 0169
			static Delegate GetIsTransientHandler ()
			{
				if (cb_isTransient == null)
					cb_isTransient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTransient);
				return cb_isTransient;
			}

			static bool n_IsTransient (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsTransient;
			}
#pragma warning restore 0169

			static IntPtr id_isTransient;
			public virtual unsafe bool IsTransient {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isTransient' and count(parameter)=0]"
				[Register ("isTransient", "()Z", "GetIsTransientHandler")]
				get {
					if (id_isTransient == IntPtr.Zero)
						id_isTransient = JNIEnv.GetMethodID (class_ref, "isTransient", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTransient);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTransient", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isUnknown;
#pragma warning disable 0169
			static Delegate GetIsUnknownHandler ()
			{
				if (cb_isUnknown == null)
					cb_isUnknown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnknown);
				return cb_isUnknown;
			}

			static bool n_IsUnknown (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsUnknown;
			}
#pragma warning restore 0169

			static IntPtr id_isUnknown;
			public virtual unsafe bool IsUnknown {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isUnknown' and count(parameter)=0]"
				[Register ("isUnknown", "()Z", "GetIsUnknownHandler")]
				get {
					if (id_isUnknown == IntPtr.Zero)
						id_isUnknown = JNIEnv.GetMethodID (class_ref, "isUnknown", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnknown);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnknown", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_isUnsupported;
#pragma warning disable 0169
			static Delegate GetIsUnsupportedHandler ()
			{
				if (cb_isUnsupported == null)
					cb_isUnsupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnsupported);
				return cb_isUnsupported;
			}

			static bool n_IsUnsupported (IntPtr jnienv, IntPtr native__this)
			{
				global::Google.AR.Core.ArCoreApk.Availability __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsUnsupported;
			}
#pragma warning restore 0169

			static IntPtr id_isUnsupported;
			public virtual unsafe bool IsUnsupported {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='isUnsupported' and count(parameter)=0]"
				[Register ("isUnsupported", "()Z", "GetIsUnsupportedHandler")]
				get {
					if (id_isUnsupported == IntPtr.Zero)
						id_isUnsupported = JNIEnv.GetMethodID (class_ref, "isUnsupported", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnsupported);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnsupported", "()Z"));
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$Availability;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.Availability ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$Availability;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.ArCoreApk.Availability __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.Availability']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$Availability;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.Availability[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/ArCoreApk$Availability;");
				try {
					return (global::Google.AR.Core.ArCoreApk.Availability[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.Availability));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ar.core']/interface[@name='ArCoreApk.ICheckAvailabilityCallback']"
		[Register ("com/google/ar/core/ArCoreApk$ICheckAvailabilityCallback", "", "Google.AR.Core.ArCoreApk/ICheckAvailabilityCallbackInvoker")]
		public partial interface ICheckAvailabilityCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/interface[@name='ArCoreApk.ICheckAvailabilityCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.ArCoreApk.Availability']]"
			[Register ("onResult", "(Lcom/google/ar/core/ArCoreApk$Availability;)V", "GetOnResult_Lcom_google_ar_core_ArCoreApk_Availability_Handler:Google.AR.Core.ArCoreApk/ICheckAvailabilityCallbackInvoker, Xamarin.Google.ARCore")]
			void OnResult (global::Google.AR.Core.ArCoreApk.Availability availability);

		}

		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$ICheckAvailabilityCallback", DoNotGenerateAcw=true)]
		internal class ICheckAvailabilityCallbackInvoker : global::Java.Lang.Object, ICheckAvailabilityCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ar/core/ArCoreApk$ICheckAvailabilityCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICheckAvailabilityCallbackInvoker); }
			}

			IntPtr class_ref;

			public static ICheckAvailabilityCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICheckAvailabilityCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.ar.core.ArCoreApk.ICheckAvailabilityCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICheckAvailabilityCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResult_Lcom_google_ar_core_ArCoreApk_Availability_;
#pragma warning disable 0169
			static Delegate GetOnResult_Lcom_google_ar_core_ArCoreApk_Availability_Handler ()
			{
				if (cb_onResult_Lcom_google_ar_core_ArCoreApk_Availability_ == null)
					cb_onResult_Lcom_google_ar_core_ArCoreApk_Availability_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_google_ar_core_ArCoreApk_Availability_);
				return cb_onResult_Lcom_google_ar_core_ArCoreApk_Availability_;
			}

			static void n_OnResult_Lcom_google_ar_core_ArCoreApk_Availability_ (IntPtr jnienv, IntPtr native__this, IntPtr native_availability)
			{
				global::Google.AR.Core.ArCoreApk.ICheckAvailabilityCallback __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.ICheckAvailabilityCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Google.AR.Core.ArCoreApk.Availability availability = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (native_availability, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (availability);
			}
#pragma warning restore 0169

			IntPtr id_onResult_Lcom_google_ar_core_ArCoreApk_Availability_;
			public unsafe void OnResult (global::Google.AR.Core.ArCoreApk.Availability availability)
			{
				if (id_onResult_Lcom_google_ar_core_ArCoreApk_Availability_ == IntPtr.Zero)
					id_onResult_Lcom_google_ar_core_ArCoreApk_Availability_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/google/ar/core/ArCoreApk$Availability;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (availability);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_google_ar_core_ArCoreApk_Availability_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$InstallBehavior", DoNotGenerateAcw=true)]
		public sealed partial class InstallBehavior : global::Java.Lang.Enum {


			static IntPtr OPTIONAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/field[@name='OPTIONAL']"
			[Register ("OPTIONAL")]
			public static global::Google.AR.Core.ArCoreApk.InstallBehavior Optional {
				get {
					if (OPTIONAL_jfieldId == IntPtr.Zero)
						OPTIONAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPTIONAL", "Lcom/google/ar/core/ArCoreApk$InstallBehavior;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPTIONAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/field[@name='REQUIRED']"
			[Register ("REQUIRED")]
			public static global::Google.AR.Core.ArCoreApk.InstallBehavior Required {
				get {
					if (REQUIRED_jfieldId == IntPtr.Zero)
						REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUIRED", "Lcom/google/ar/core/ArCoreApk$InstallBehavior;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/ArCoreApk$InstallBehavior", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InstallBehavior); }
			}

			internal InstallBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallBehavior;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallBehavior ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallBehavior;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.ArCoreApk.InstallBehavior __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallBehavior']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$InstallBehavior;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallBehavior[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/ArCoreApk$InstallBehavior;");
				try {
					return (global::Google.AR.Core.ArCoreApk.InstallBehavior[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.InstallBehavior));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$InstallStatus", DoNotGenerateAcw=true)]
		public sealed partial class InstallStatus : global::Java.Lang.Enum {


			static IntPtr INSTALLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/field[@name='INSTALLED']"
			[Register ("INSTALLED")]
			public static global::Google.AR.Core.ArCoreApk.InstallStatus Installed {
				get {
					if (INSTALLED_jfieldId == IntPtr.Zero)
						INSTALLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALLED", "Lcom/google/ar/core/ArCoreApk$InstallStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTALLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INSTALL_REQUESTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/field[@name='INSTALL_REQUESTED']"
			[Register ("INSTALL_REQUESTED")]
			public static global::Google.AR.Core.ArCoreApk.InstallStatus InstallRequested {
				get {
					if (INSTALL_REQUESTED_jfieldId == IntPtr.Zero)
						INSTALL_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTALL_REQUESTED", "Lcom/google/ar/core/ArCoreApk$InstallStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTALL_REQUESTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/ArCoreApk$InstallStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InstallStatus); }
			}

			internal InstallStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$InstallStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.ArCoreApk.InstallStatus __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.InstallStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$InstallStatus;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.InstallStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/ArCoreApk$InstallStatus;");
				try {
					return (global::Google.AR.Core.ArCoreApk.InstallStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.InstallStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']"
		[global::Android.Runtime.Register ("com/google/ar/core/ArCoreApk$UserMessageType", DoNotGenerateAcw=true)]
		public sealed partial class UserMessageType : global::Java.Lang.Enum {


			static IntPtr APPLICATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='APPLICATION']"
			[Register ("APPLICATION")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType Application {
				get {
					if (APPLICATION_jfieldId == IntPtr.Zero)
						APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Lcom/google/ar/core/ArCoreApk$UserMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FEATURE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='FEATURE']"
			[Register ("FEATURE")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType Feature {
				get {
					if (FEATURE_jfieldId == IntPtr.Zero)
						FEATURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEATURE", "Lcom/google/ar/core/ArCoreApk$UserMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEATURE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_ALREADY_INFORMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/field[@name='USER_ALREADY_INFORMED']"
			[Register ("USER_ALREADY_INFORMED")]
			public static global::Google.AR.Core.ArCoreApk.UserMessageType UserAlreadyInformed {
				get {
					if (USER_ALREADY_INFORMED_jfieldId == IntPtr.Zero)
						USER_ALREADY_INFORMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ALREADY_INFORMED", "Lcom/google/ar/core/ArCoreApk$UserMessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ALREADY_INFORMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/ArCoreApk$UserMessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UserMessageType); }
			}

			internal UserMessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$UserMessageType;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.UserMessageType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/ArCoreApk$UserMessageType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.ArCoreApk.UserMessageType __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk.UserMessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/ArCoreApk$UserMessageType;", "")]
			public static unsafe global::Google.AR.Core.ArCoreApk.UserMessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/ArCoreApk$UserMessageType;");
				try {
					return (global::Google.AR.Core.ArCoreApk.UserMessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.ArCoreApk.UserMessageType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/ArCoreApk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArCoreApk); }
		}

		protected ArCoreApk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/constructor[@name='ArCoreApk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ArCoreApk ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArCoreApk)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Google.AR.Core.ArCoreApk Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/google/ar/core/ArCoreApk;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/google/ar/core/ArCoreApk;");
				try {
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkAvailability_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCheckAvailability_Landroid_content_Context_Handler ()
		{
			if (cb_checkAvailability_Landroid_content_Context_ == null)
				cb_checkAvailability_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckAvailability_Landroid_content_Context_);
			return cb_checkAvailability_Landroid_content_Context_;
		}

		static IntPtr n_CheckAvailability_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationContext)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context applicationContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_applicationContext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckAvailability (applicationContext));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkAvailability_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='checkAvailability' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkAvailability", "(Landroid/content/Context;)Lcom/google/ar/core/ArCoreApk$Availability;", "GetCheckAvailability_Landroid_content_Context_Handler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.Availability CheckAvailability (global::Android.Content.Context applicationContext)
		{
			if (id_checkAvailability_Landroid_content_Context_ == IntPtr.Zero)
				id_checkAvailability_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "checkAvailability", "(Landroid/content/Context;)Lcom/google/ar/core/ArCoreApk$Availability;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (applicationContext);

				global::Google.AR.Core.ArCoreApk.Availability __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkAvailability_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.Availability> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAvailability", "(Landroid/content/Context;)Lcom/google/ar/core/ArCoreApk$Availability;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestInstall_Landroid_app_Activity_Z;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Landroid_app_Activity_ZHandler ()
		{
			if (cb_requestInstall_Landroid_app_Activity_Z == null)
				cb_requestInstall_Landroid_app_Activity_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_RequestInstall_Landroid_app_Activity_Z);
			return cb_requestInstall_Landroid_app_Activity_Z;
		}

		static IntPtr n_RequestInstall_Landroid_app_Activity_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationActivity, bool userRequestedInstall)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity applicationActivity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_applicationActivity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestInstall (applicationActivity, userRequestedInstall));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestInstall_Landroid_app_Activity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='requestInstall' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("requestInstall", "(Landroid/app/Activity;Z)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "GetRequestInstall_Landroid_app_Activity_ZHandler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.InstallStatus RequestInstall (global::Android.App.Activity applicationActivity, bool userRequestedInstall)
		{
			if (id_requestInstall_Landroid_app_Activity_Z == IntPtr.Zero)
				id_requestInstall_Landroid_app_Activity_Z = JNIEnv.GetMethodID (class_ref, "requestInstall", "(Landroid/app/Activity;Z)Lcom/google/ar/core/ArCoreApk$InstallStatus;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (applicationActivity);
				__args [1] = new JValue (userRequestedInstall);

				global::Google.AR.Core.ArCoreApk.InstallStatus __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestInstall_Landroid_app_Activity_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestInstall", "(Landroid/app/Activity;Z)Lcom/google/ar/core/ArCoreApk$InstallStatus;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_Handler ()
		{
			if (cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ == null)
				cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_RequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_);
			return cb_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_;
		}

		static IntPtr n_RequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_applicationActivity, bool userRequestedInstall, IntPtr native_installBehavior, IntPtr native_messageType)
		{
			global::Google.AR.Core.ArCoreApk __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity applicationActivity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_applicationActivity, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.ArCoreApk.InstallBehavior installBehavior = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallBehavior> (native_installBehavior, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.ArCoreApk.UserMessageType messageType = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.UserMessageType> (native_messageType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestInstall (applicationActivity, userRequestedInstall, installBehavior, messageType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='ArCoreApk']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='com.google.ar.core.ArCoreApk.InstallBehavior'] and parameter[4][@type='com.google.ar.core.ArCoreApk.UserMessageType']]"
		[Register ("requestInstall", "(Landroid/app/Activity;ZLcom/google/ar/core/ArCoreApk$InstallBehavior;Lcom/google/ar/core/ArCoreApk$UserMessageType;)Lcom/google/ar/core/ArCoreApk$InstallStatus;", "GetRequestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_Handler")]
		public virtual unsafe global::Google.AR.Core.ArCoreApk.InstallStatus RequestInstall (global::Android.App.Activity applicationActivity, bool userRequestedInstall, global::Google.AR.Core.ArCoreApk.InstallBehavior installBehavior, global::Google.AR.Core.ArCoreApk.UserMessageType messageType)
		{
			if (id_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ == IntPtr.Zero)
				id_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_ = JNIEnv.GetMethodID (class_ref, "requestInstall", "(Landroid/app/Activity;ZLcom/google/ar/core/ArCoreApk$InstallBehavior;Lcom/google/ar/core/ArCoreApk$UserMessageType;)Lcom/google/ar/core/ArCoreApk$InstallStatus;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (applicationActivity);
				__args [1] = new JValue (userRequestedInstall);
				__args [2] = new JValue (installBehavior);
				__args [3] = new JValue (messageType);

				global::Google.AR.Core.ArCoreApk.InstallStatus __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestInstall_Landroid_app_Activity_ZLcom_google_ar_core_ArCoreApk_InstallBehavior_Lcom_google_ar_core_ArCoreApk_UserMessageType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.ArCoreApk.InstallStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestInstall", "(Landroid/app/Activity;ZLcom/google/ar/core/ArCoreApk$InstallBehavior;Lcom/google/ar/core/ArCoreApk$UserMessageType;)Lcom/google/ar/core/ArCoreApk$InstallStatus;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
