using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='UnavailableSdkTooOldException']"
	[global::Android.Runtime.Register ("com/google/ar/core/exceptions/UnavailableSdkTooOldException", DoNotGenerateAcw=true)]
	public partial class UnavailableSdkTooOldException : global::Google.AR.Core.Exceptions.UnavailableException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/exceptions/UnavailableSdkTooOldException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnavailableSdkTooOldException); }
		}

		protected UnavailableSdkTooOldException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='UnavailableSdkTooOldException']/constructor[@name='UnavailableSdkTooOldException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnavailableSdkTooOldException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnavailableSdkTooOldException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
