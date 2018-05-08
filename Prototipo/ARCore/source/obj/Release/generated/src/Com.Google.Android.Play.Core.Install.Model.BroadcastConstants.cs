using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Play.Core.Install.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.play.core.install.model']/class[@name='BroadcastConstants']"
	[global::Android.Runtime.Register ("com/google/android/play/core/install/model/BroadcastConstants", DoNotGenerateAcw=true)]
	public partial class BroadcastConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.play.core.install.model']/class[@name='BroadcastConstants']/field[@name='ACTION_INSTALL_STATUS']"
		[Register ("ACTION_INSTALL_STATUS")]
		public const string ActionInstallStatus = (string) "com.google.android.play.core.install.ACTION_INSTALL_STATUS";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/play/core/install/model/BroadcastConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BroadcastConstants); }
		}

		protected BroadcastConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.play.core.install.model']/class[@name='BroadcastConstants']/constructor[@name='BroadcastConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BroadcastConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BroadcastConstants)) {
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
