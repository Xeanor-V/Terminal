using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/INativeLibraryLoader$Stub", DoNotGenerateAcw=true)]
	public abstract partial class NativeLibraryLoaderStub : global::Google.Android.Aidl.BaseStub, global::Google.VR.Dynamite.Client.INativeLibraryLoader {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/vr/dynamite/client/INativeLibraryLoader$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Google.Android.Aidl.BaseProxy, global::Google.VR.Dynamite.Client.INativeLibraryLoader {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/vr/dynamite/client/INativeLibraryLoader$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_checkVersion_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCheckVersion_Ljava_lang_String_Handler ()
			{
				if (cb_checkVersion_Ljava_lang_String_ == null)
					cb_checkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckVersion_Ljava_lang_String_);
				return cb_checkVersion_Ljava_lang_String_;
			}

			static int n_CheckVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientVersion)
			{
				global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string clientVersion = JNIEnv.GetString (native_clientVersion, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.CheckVersion (clientVersion);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_checkVersion_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub.Proxy']/method[@name='checkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("checkVersion", "(Ljava/lang/String;)I", "GetCheckVersion_Ljava_lang_String_Handler")]
			public virtual unsafe int CheckVersion (string clientVersion)
			{
				if (id_checkVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_checkVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkVersion", "(Ljava/lang/String;)I");
				IntPtr native_clientVersion = JNIEnv.NewString (clientVersion);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_clientVersion);

					int __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVersion_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkVersion", "(Ljava/lang/String;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_clientVersion);
				}
			}

			static Delegate cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler ()
			{
				if (cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ == null)
					cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InitializeAndLoadNativeLibrary_Ljava_lang_String_);
				return cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
			}

			static long n_InitializeAndLoadNativeLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_libraryName)
			{
				global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string libraryName = JNIEnv.GetString (native_libraryName, JniHandleOwnership.DoNotTransfer);
				long __ret = __this.InitializeAndLoadNativeLibrary (libraryName);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_initializeAndLoadNativeLibrary_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub.Proxy']/method[@name='initializeAndLoadNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J", "GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler")]
			public virtual unsafe long InitializeAndLoadNativeLibrary (string libraryName)
			{
				if (id_initializeAndLoadNativeLibrary_Ljava_lang_String_ == IntPtr.Zero)
					id_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J");
				IntPtr native_libraryName = JNIEnv.NewString (libraryName);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_libraryName);

					long __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_initializeAndLoadNativeLibrary_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_libraryName);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/INativeLibraryLoader$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeLibraryLoaderStub); }
		}

		protected NativeLibraryLoaderStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub']/constructor[@name='INativeLibraryLoader.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeLibraryLoaderStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NativeLibraryLoaderStub)) {
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

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "")]
		public static unsafe global::Google.VR.Dynamite.Client.INativeLibraryLoader AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Google.VR.Dynamite.Client.INativeLibraryLoader __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='INativeLibraryLoader.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (code);
				__args [1] = new JValue (data);
				__args [2] = new JValue (reply);
				__args [3] = new JValue (flags);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_checkVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckVersion_Ljava_lang_String_Handler ()
		{
			if (cb_checkVersion_Ljava_lang_String_ == null)
				cb_checkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckVersion_Ljava_lang_String_);
			return cb_checkVersion_Ljava_lang_String_;
		}

		static int n_CheckVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientVersion)
		{
			global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string clientVersion = JNIEnv.GetString (native_clientVersion, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckVersion (clientVersion);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='checkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkVersion", "(Ljava/lang/String;)I", "GetCheckVersion_Ljava_lang_String_Handler")]
		public abstract int CheckVersion (string clientVersion);

		static Delegate cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ == null)
				cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InitializeAndLoadNativeLibrary_Ljava_lang_String_);
			return cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		}

		static long n_InitializeAndLoadNativeLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_libraryName)
		{
			global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.NativeLibraryLoaderStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string libraryName = JNIEnv.GetString (native_libraryName, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InitializeAndLoadNativeLibrary (libraryName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='initializeAndLoadNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J", "GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler")]
		public abstract long InitializeAndLoadNativeLibrary (string libraryName);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/INativeLibraryLoader$Stub", DoNotGenerateAcw=true)]
	internal partial class NativeLibraryLoaderStubInvoker : NativeLibraryLoaderStub {

		public NativeLibraryLoaderStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeLibraryLoaderStubInvoker); }
		}

		static IntPtr id_checkVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='checkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkVersion", "(Ljava/lang/String;)I", "GetCheckVersion_Ljava_lang_String_Handler")]
		public override unsafe int CheckVersion (string clientVersion)
		{
			if (id_checkVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_checkVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkVersion", "(Ljava/lang/String;)I");
			IntPtr native_clientVersion = JNIEnv.NewString (clientVersion);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_clientVersion);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVersion_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_clientVersion);
			}
		}

		static IntPtr id_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='initializeAndLoadNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J", "GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler")]
		public override unsafe long InitializeAndLoadNativeLibrary (string libraryName)
		{
			if (id_initializeAndLoadNativeLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J");
			IntPtr native_libraryName = JNIEnv.NewString (libraryName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_libraryName);
				long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_initializeAndLoadNativeLibrary_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_libraryName);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']"
	[Register ("com/google/vr/dynamite/client/INativeLibraryLoader", "", "Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker")]
	public partial interface INativeLibraryLoader : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='checkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkVersion", "(Ljava/lang/String;)I", "GetCheckVersion_Ljava_lang_String_Handler:Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker, Xamarin.Google.ARCore")]
		int CheckVersion (string clientVersion);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='INativeLibraryLoader']/method[@name='initializeAndLoadNativeLibrary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J", "GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler:Google.VR.Dynamite.Client.INativeLibraryLoaderInvoker, Xamarin.Google.ARCore")]
		long InitializeAndLoadNativeLibrary (string libraryName);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/INativeLibraryLoader", DoNotGenerateAcw=true)]
	internal class INativeLibraryLoaderInvoker : global::Java.Lang.Object, INativeLibraryLoader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/vr/dynamite/client/INativeLibraryLoader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INativeLibraryLoaderInvoker); }
		}

		IntPtr class_ref;

		public static INativeLibraryLoader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeLibraryLoader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.vr.dynamite.client.INativeLibraryLoader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeLibraryLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_checkVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckVersion_Ljava_lang_String_Handler ()
		{
			if (cb_checkVersion_Ljava_lang_String_ == null)
				cb_checkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckVersion_Ljava_lang_String_);
			return cb_checkVersion_Ljava_lang_String_;
		}

		static int n_CheckVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientVersion)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string clientVersion = JNIEnv.GetString (native_clientVersion, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckVersion (clientVersion);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_checkVersion_Ljava_lang_String_;
		public unsafe int CheckVersion (string clientVersion)
		{
			if (id_checkVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_checkVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkVersion", "(Ljava/lang/String;)I");
			IntPtr native_clientVersion = JNIEnv.NewString (clientVersion);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_clientVersion);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_checkVersion_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_clientVersion);
			return __ret;
		}

		static Delegate cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitializeAndLoadNativeLibrary_Ljava_lang_String_Handler ()
		{
			if (cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ == null)
				cb_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InitializeAndLoadNativeLibrary_Ljava_lang_String_);
			return cb_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		}

		static long n_InitializeAndLoadNativeLibrary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_libraryName)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string libraryName = JNIEnv.GetString (native_libraryName, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InitializeAndLoadNativeLibrary (libraryName);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initializeAndLoadNativeLibrary_Ljava_lang_String_;
		public unsafe long InitializeAndLoadNativeLibrary (string libraryName)
		{
			if (id_initializeAndLoadNativeLibrary_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeAndLoadNativeLibrary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeAndLoadNativeLibrary", "(Ljava/lang/String;)J");
			IntPtr native_libraryName = JNIEnv.NewString (libraryName);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_libraryName);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_initializeAndLoadNativeLibrary_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_libraryName);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
