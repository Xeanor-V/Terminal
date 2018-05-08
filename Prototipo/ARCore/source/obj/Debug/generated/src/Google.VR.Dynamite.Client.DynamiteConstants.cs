using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/DynamiteConstants", DoNotGenerateAcw=true)]
	public partial class DynamiteConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/field[@name='DYNAMITE_LOAD_RESULT_ERROR']"
		[Register ("DYNAMITE_LOAD_RESULT_ERROR")]
		public const int DynamiteLoadResultError = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/field[@name='DYNAMITE_LOAD_RESULT_FAILED_APK_TOO_OLD']"
		[Register ("DYNAMITE_LOAD_RESULT_FAILED_APK_TOO_OLD")]
		public const int DynamiteLoadResultFailedApkTooOld = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/field[@name='DYNAMITE_LOAD_RESULT_FAILED_NOT_INSTALLED']"
		[Register ("DYNAMITE_LOAD_RESULT_FAILED_NOT_INSTALLED")]
		public const int DynamiteLoadResultFailedNotInstalled = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/field[@name='DYNAMITE_LOAD_RESULT_FAILED_SDK_TOO_OLD']"
		[Register ("DYNAMITE_LOAD_RESULT_FAILED_SDK_TOO_OLD")]
		public const int DynamiteLoadResultFailedSdkTooOld = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/field[@name='DYNAMITE_LOAD_RESULT_OK']"
		[Register ("DYNAMITE_LOAD_RESULT_OK")]
		public const int DynamiteLoadResultOk = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/DynamiteConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamiteConstants); }
		}

		protected DynamiteConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteConstants']/constructor[@name='DynamiteConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DynamiteConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DynamiteConstants)) {
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

	}
}
