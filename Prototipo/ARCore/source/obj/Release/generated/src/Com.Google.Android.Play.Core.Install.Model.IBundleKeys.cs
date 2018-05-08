using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Play.Core.Install.Model {

	[Register ("com/google/android/play/core/install/model/BundleKeys", DoNotGenerateAcw=true)]
	public abstract class BundleKeys : Java.Lang.Object {

		internal BundleKeys ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']/field[@name='KEY_ERROR_CODE']"
		[Register ("KEY_ERROR_CODE")]
		public const string KeyErrorCode = (string) "error.code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']/field[@name='KEY_INSTALL_STATUS']"
		[Register ("KEY_INSTALL_STATUS")]
		public const string KeyInstallStatus = (string) "install.status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']/field[@name='KEY_PACKAGE_NAME']"
		[Register ("KEY_PACKAGE_NAME")]
		public const string KeyPackageName = (string) "package.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']/field[@name='KEY_RESOLUTION_INTENT']"
		[Register ("KEY_RESOLUTION_INTENT")]
		public const string KeyResolutionIntent = (string) "resolution.intent";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']/field[@name='KEY_VERSION_CODE']"
		[Register ("KEY_VERSION_CODE")]
		public const string KeyVersionCode = (string) "version.code";

		// The following are fields from: java.lang.annotation.Annotation

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable
	}

	[Register ("com/google/android/play/core/install/model/BundleKeys", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BundleKeys' type. This type will be removed in a future release.")]
	public abstract class BundleKeysConsts : BundleKeys {

		private BundleKeysConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.play.core.install.model']/interface[@name='BundleKeys']"
	[Register ("com/google/android/play/core/install/model/BundleKeys", "", "Com.Google.Android.Play.Core.Install.Model.IBundleKeysInvoker")]
	public partial interface IBundleKeys : global::Java.Lang.Annotation.IAnnotation {

	}

	[global::Android.Runtime.Register ("com/google/android/play/core/install/model/BundleKeys", DoNotGenerateAcw=true)]
	internal class IBundleKeysInvoker : global::Java.Lang.Object, IBundleKeys {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/play/core/install/model/BundleKeys");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBundleKeysInvoker); }
		}

		IntPtr class_ref;

		public static IBundleKeys GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBundleKeys> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.play.core.install.model.BundleKeys"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBundleKeysInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (obj);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
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
			global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Model.IBundleKeys> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
