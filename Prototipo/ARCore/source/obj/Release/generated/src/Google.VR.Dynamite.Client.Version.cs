using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/Version", DoNotGenerateAcw=true)]
	public sealed partial class Version : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "Version";

		static IntPtr majorVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/field[@name='majorVersion']"
		[Register ("majorVersion")]
		public int MajorVersion {
			get {
				if (majorVersion_jfieldId == IntPtr.Zero)
					majorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "majorVersion", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, majorVersion_jfieldId);
			}
			set {
				if (majorVersion_jfieldId == IntPtr.Zero)
					majorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "majorVersion", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, majorVersion_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr minorVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/field[@name='minorVersion']"
		[Register ("minorVersion")]
		public int MinorVersion {
			get {
				if (minorVersion_jfieldId == IntPtr.Zero)
					minorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "minorVersion", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, minorVersion_jfieldId);
			}
			set {
				if (minorVersion_jfieldId == IntPtr.Zero)
					minorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "minorVersion", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minorVersion_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr patchVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/field[@name='patchVersion']"
		[Register ("patchVersion")]
		public int PatchVersion {
			get {
				if (patchVersion_jfieldId == IntPtr.Zero)
					patchVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "patchVersion", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, patchVersion_jfieldId);
			}
			set {
				if (patchVersion_jfieldId == IntPtr.Zero)
					patchVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "patchVersion", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, patchVersion_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/Version", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Version); }
		}

		internal Version (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/constructor[@name='Version' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe Version (int majorVersion, int minorVersion, int patchVersion)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (majorVersion);
				__args [1] = new JValue (minorVersion);
				__args [2] = new JValue (patchVersion);
				if (((object) this).GetType () != typeof (Version)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(III)V", __args);
					return;
				}

				if (id_ctor_III == IntPtr.Zero)
					id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_III, __args);
			} finally {
			}
		}

		static IntPtr id_isAtLeast_Lcom_google_vr_dynamite_client_Version_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/method[@name='isAtLeast' and count(parameter)=1 and parameter[1][@type='com.google.vr.dynamite.client.Version']]"
		[Register ("isAtLeast", "(Lcom/google/vr/dynamite/client/Version;)Z", "")]
		public unsafe bool IsAtLeast (global::Google.VR.Dynamite.Client.Version other)
		{
			if (id_isAtLeast_Lcom_google_vr_dynamite_client_Version_ == IntPtr.Zero)
				id_isAtLeast_Lcom_google_vr_dynamite_client_Version_ = JNIEnv.GetMethodID (class_ref, "isAtLeast", "(Lcom/google/vr/dynamite/client/Version;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAtLeast_Lcom_google_vr_dynamite_client_Version_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='Version']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/google/vr/dynamite/client/Version;", "")]
		public static unsafe global::Google.VR.Dynamite.Client.Version Parse (string versionString)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/google/vr/dynamite/client/Version;");
			IntPtr native_versionString = JNIEnv.NewString (versionString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_versionString);
				global::Google.VR.Dynamite.Client.Version __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.Version> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_versionString);
			}
		}

	}
}
