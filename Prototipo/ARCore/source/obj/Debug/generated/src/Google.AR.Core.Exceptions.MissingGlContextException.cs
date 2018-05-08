using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='MissingGlContextException']"
	[global::Android.Runtime.Register ("com/google/ar/core/exceptions/MissingGlContextException", DoNotGenerateAcw=true)]
	public partial class MissingGlContextException : global::Java.Lang.IllegalStateException {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/exceptions/MissingGlContextException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MissingGlContextException); }
		}

		protected MissingGlContextException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core.exceptions']/class[@name='MissingGlContextException']/constructor[@name='MissingGlContextException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MissingGlContextException ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MissingGlContextException)) {
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
