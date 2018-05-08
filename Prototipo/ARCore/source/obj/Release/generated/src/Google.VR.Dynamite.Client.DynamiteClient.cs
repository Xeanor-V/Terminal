using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteClient']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/DynamiteClient", DoNotGenerateAcw=true)]
	public sealed partial class DynamiteClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/DynamiteClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DynamiteClient); }
		}

		internal DynamiteClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkVersion_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteClient']/method[@name='checkVersion' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("checkVersion", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int CheckVersion (global::Android.Content.Context context, string remotePackageName, string libraryName, string clientVersionString)
		{
			if (id_checkVersion_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_checkVersion_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkVersion", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_remotePackageName = JNIEnv.NewString (remotePackageName);
			IntPtr native_libraryName = JNIEnv.NewString (libraryName);
			IntPtr native_clientVersionString = JNIEnv.NewString (clientVersionString);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_remotePackageName);
				__args [2] = new JValue (native_libraryName);
				__args [3] = new JValue (native_clientVersionString);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_checkVersion_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_remotePackageName);
				JNIEnv.DeleteLocalRef (native_libraryName);
				JNIEnv.DeleteLocalRef (native_clientVersionString);
			}
		}

		static IntPtr id_getRemoteClassLoader_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteClient']/method[@name='getRemoteClassLoader' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getRemoteClassLoader", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/ClassLoader;", "")]
		public static unsafe global::Java.Lang.ClassLoader GetRemoteClassLoader (global::Android.Content.Context context, string remotePackageName, string libraryName)
		{
			if (id_getRemoteClassLoader_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getRemoteClassLoader_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getRemoteClassLoader", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/ClassLoader;");
			IntPtr native_remotePackageName = JNIEnv.NewString (remotePackageName);
			IntPtr native_libraryName = JNIEnv.NewString (libraryName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_remotePackageName);
				__args [2] = new JValue (native_libraryName);
				global::Java.Lang.ClassLoader __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRemoteClassLoader_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_remotePackageName);
				JNIEnv.DeleteLocalRef (native_libraryName);
			}
		}

		static IntPtr id_loadNativeRemoteLibrary_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='DynamiteClient']/method[@name='loadNativeRemoteLibrary' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("loadNativeRemoteLibrary", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)J", "")]
		public static unsafe long LoadNativeRemoteLibrary (global::Android.Content.Context context, string remotePackageName, string libraryName)
		{
			if (id_loadNativeRemoteLibrary_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_loadNativeRemoteLibrary_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadNativeRemoteLibrary", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)J");
			IntPtr native_remotePackageName = JNIEnv.NewString (remotePackageName);
			IntPtr native_libraryName = JNIEnv.NewString (libraryName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_remotePackageName);
				__args [2] = new JValue (native_libraryName);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_loadNativeRemoteLibrary_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_remotePackageName);
				JNIEnv.DeleteLocalRef (native_libraryName);
			}
		}

	}
}
