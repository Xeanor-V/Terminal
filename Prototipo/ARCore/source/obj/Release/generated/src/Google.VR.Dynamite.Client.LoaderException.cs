using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='LoaderException']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/LoaderException", DoNotGenerateAcw=true)]
	public partial class LoaderException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='LoaderException']/field[@name='ERROR_PACKAGE_NOT_AVAILABLE']"
		[Register ("ERROR_PACKAGE_NOT_AVAILABLE")]
		public const int ErrorPackageNotAvailable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='LoaderException']/field[@name='ERROR_PACKAGE_OBSOLETE']"
		[Register ("ERROR_PACKAGE_OBSOLETE")]
		public const int ErrorPackageObsolete = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/LoaderException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoaderException); }
		}

		protected LoaderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='LoaderException']/constructor[@name='LoaderException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LoaderException (int errorCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorCode);
				if (((object) this).GetType () != typeof (LoaderException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
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
			global::Google.VR.Dynamite.Client.LoaderException __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.LoaderException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='LoaderException']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
