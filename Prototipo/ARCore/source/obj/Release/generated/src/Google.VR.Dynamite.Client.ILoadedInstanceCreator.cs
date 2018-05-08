using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub", DoNotGenerateAcw=true)]
	public abstract partial class LoadedInstanceCreatorStub : global::Google.Android.Aidl.BaseStub, global::Google.VR.Dynamite.Client.ILoadedInstanceCreator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Google.Android.Aidl.BaseProxy, global::Google.VR.Dynamite.Client.ILoadedInstanceCreator {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
#pragma warning disable 0169
			static Delegate GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler ()
			{
				if (cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == null)
					cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_);
				return cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
			}

			static IntPtr n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteContextWrapper, IntPtr native_clientContextWrapper)
			{
				global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_remoteContextWrapper, JniHandleOwnership.DoNotTransfer);
				global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_clientContextWrapper, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewNativeLibraryLoader (remoteContextWrapper, clientContextWrapper));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub.Proxy']/method[@name='newNativeLibraryLoader' and count(parameter)=2 and parameter[1][@type='com.google.vr.dynamite.client.IObjectWrapper'] and parameter[2][@type='com.google.vr.dynamite.client.IObjectWrapper']]"
			[Register ("newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler")]
			public virtual unsafe global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper, global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper)
			{
				if (id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == IntPtr.Zero)
					id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNIEnv.GetMethodID (class_ref, "newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (remoteContextWrapper);
					__args [1] = new JValue (clientContextWrapper);

					global::Google.VR.Dynamite.Client.INativeLibraryLoader __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoadedInstanceCreatorStub); }
		}

		protected LoadedInstanceCreatorStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub']/constructor[@name='ILoadedInstanceCreator.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoadedInstanceCreatorStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LoadedInstanceCreatorStub)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/ILoadedInstanceCreator;", "")]
		public static unsafe global::Google.VR.Dynamite.Client.ILoadedInstanceCreator AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/ILoadedInstanceCreator;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Google.VR.Dynamite.Client.ILoadedInstanceCreator __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.ILoadedInstanceCreator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='ILoadedInstanceCreator.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
#pragma warning disable 0169
		static Delegate GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler ()
		{
			if (cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == null)
				cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_);
			return cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		}

		static IntPtr n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteContextWrapper, IntPtr native_clientContextWrapper)
		{
			global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.LoadedInstanceCreatorStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_remoteContextWrapper, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_clientContextWrapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewNativeLibraryLoader (remoteContextWrapper, clientContextWrapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']/method[@name='newNativeLibraryLoader' and count(parameter)=2 and parameter[1][@type='com.google.vr.dynamite.client.IObjectWrapper'] and parameter[2][@type='com.google.vr.dynamite.client.IObjectWrapper']]"
		[Register ("newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler")]
		public abstract global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper, global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub", DoNotGenerateAcw=true)]
	internal partial class LoadedInstanceCreatorStubInvoker : LoadedInstanceCreatorStub {

		public LoadedInstanceCreatorStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoadedInstanceCreatorStubInvoker); }
		}

		static IntPtr id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']/method[@name='newNativeLibraryLoader' and count(parameter)=2 and parameter[1][@type='com.google.vr.dynamite.client.IObjectWrapper'] and parameter[2][@type='com.google.vr.dynamite.client.IObjectWrapper']]"
		[Register ("newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler")]
		public override unsafe global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper, global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper)
		{
			if (id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == IntPtr.Zero)
				id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNIEnv.GetMethodID (class_ref, "newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (remoteContextWrapper);
				__args [1] = new JValue (clientContextWrapper);
				global::Google.VR.Dynamite.Client.INativeLibraryLoader __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']"
	[Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator", "", "Google.VR.Dynamite.Client.ILoadedInstanceCreatorInvoker")]
	public partial interface ILoadedInstanceCreator : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='ILoadedInstanceCreator']/method[@name='newNativeLibraryLoader' and count(parameter)=2 and parameter[1][@type='com.google.vr.dynamite.client.IObjectWrapper'] and parameter[2][@type='com.google.vr.dynamite.client.IObjectWrapper']]"
		[Register ("newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;", "GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler:Google.VR.Dynamite.Client.ILoadedInstanceCreatorInvoker, Xamarin.Google.ARCore")]
		global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper, global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper);

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/ILoadedInstanceCreator", DoNotGenerateAcw=true)]
	internal class ILoadedInstanceCreatorInvoker : global::Java.Lang.Object, ILoadedInstanceCreator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/vr/dynamite/client/ILoadedInstanceCreator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoadedInstanceCreatorInvoker); }
		}

		IntPtr class_ref;

		public static ILoadedInstanceCreator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadedInstanceCreator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.vr.dynamite.client.ILoadedInstanceCreator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadedInstanceCreatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
#pragma warning disable 0169
		static Delegate GetNewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_Handler ()
		{
			if (cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == null)
				cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_);
			return cb_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		}

		static IntPtr n_NewNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_remoteContextWrapper, IntPtr native_clientContextWrapper)
		{
			global::Google.VR.Dynamite.Client.ILoadedInstanceCreator __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.ILoadedInstanceCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_remoteContextWrapper, JniHandleOwnership.DoNotTransfer);
			global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper = (global::Google.VR.Dynamite.Client.IObjectWrapper)global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (native_clientContextWrapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewNativeLibraryLoader (remoteContextWrapper, clientContextWrapper));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_;
		public unsafe global::Google.VR.Dynamite.Client.INativeLibraryLoader NewNativeLibraryLoader (global::Google.VR.Dynamite.Client.IObjectWrapper remoteContextWrapper, global::Google.VR.Dynamite.Client.IObjectWrapper clientContextWrapper)
		{
			if (id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ == IntPtr.Zero)
				id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_ = JNIEnv.GetMethodID (class_ref, "newNativeLibraryLoader", "(Lcom/google/vr/dynamite/client/IObjectWrapper;Lcom/google/vr/dynamite/client/IObjectWrapper;)Lcom/google/vr/dynamite/client/INativeLibraryLoader;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (remoteContextWrapper);
			__args [1] = new JValue (clientContextWrapper);
			global::Google.VR.Dynamite.Client.INativeLibraryLoader __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.INativeLibraryLoader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newNativeLibraryLoader_Lcom_google_vr_dynamite_client_IObjectWrapper_Lcom_google_vr_dynamite_client_IObjectWrapper_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Google.VR.Dynamite.Client.ILoadedInstanceCreator __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.ILoadedInstanceCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
