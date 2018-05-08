using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Play.Core.Install.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub']"
	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub", DoNotGenerateAcw=true)]
	public abstract partial class InstallServiceCallbackStub : global::Google.Android.Aidl.BaseStub, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Google.Android.Aidl.BaseProxy, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onRequestInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnRequestInfo_Landroid_os_Bundle_Handler ()
			{
				if (cb_onRequestInfo_Landroid_os_Bundle_ == null)
					cb_onRequestInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInfo_Landroid_os_Bundle_);
				return cb_onRequestInfo_Landroid_os_Bundle_;
			}

			static void n_OnRequestInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnRequestInfo (result);
			}
#pragma warning restore 0169

			static IntPtr id_onRequestInfo_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub.Proxy']/method[@name='onRequestInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onRequestInfo", "(Landroid/os/Bundle;)V", "GetOnRequestInfo_Landroid_os_Bundle_Handler")]
			public virtual unsafe void OnRequestInfo (global::Android.OS.Bundle result)
			{
				if (id_onRequestInfo_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onRequestInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInfo", "(Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (result);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInfo_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestInfo", "(Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onRequestInstall_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnRequestInstall_Landroid_os_Bundle_Handler ()
			{
				if (cb_onRequestInstall_Landroid_os_Bundle_ == null)
					cb_onRequestInstall_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInstall_Landroid_os_Bundle_);
				return cb_onRequestInstall_Landroid_os_Bundle_;
			}

			static void n_OnRequestInstall_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
			{
				global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
				__this.OnRequestInstall (result);
			}
#pragma warning restore 0169

			static IntPtr id_onRequestInstall_Landroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub.Proxy']/method[@name='onRequestInstall' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("onRequestInstall", "(Landroid/os/Bundle;)V", "GetOnRequestInstall_Landroid_os_Bundle_Handler")]
			public virtual unsafe void OnRequestInstall (global::Android.OS.Bundle result)
			{
				if (id_onRequestInstall_Landroid_os_Bundle_ == IntPtr.Zero)
					id_onRequestInstall_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInstall", "(Landroid/os/Bundle;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (result);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInstall_Landroid_os_Bundle_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRequestInstall", "(Landroid/os/Bundle;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstallServiceCallbackStub); }
		}

		protected InstallServiceCallbackStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub']/constructor[@name='IInstallServiceCallback.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstallServiceCallbackStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstallServiceCallbackStub)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;", "")]
		public static unsafe global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallServiceCallback.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onRequestInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRequestInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRequestInfo_Landroid_os_Bundle_ == null)
				cb_onRequestInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInfo_Landroid_os_Bundle_);
			return cb_onRequestInfo_Landroid_os_Bundle_;
		}

		static void n_OnRequestInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestInfo (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInfo", "(Landroid/os/Bundle;)V", "GetOnRequestInfo_Landroid_os_Bundle_Handler")]
		public abstract void OnRequestInfo (global::Android.OS.Bundle result);

		static Delegate cb_onRequestInstall_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRequestInstall_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRequestInstall_Landroid_os_Bundle_ == null)
				cb_onRequestInstall_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInstall_Landroid_os_Bundle_);
			return cb_onRequestInstall_Landroid_os_Bundle_;
		}

		static void n_OnRequestInstall_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestInstall (result);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInstall' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInstall", "(Landroid/os/Bundle;)V", "GetOnRequestInstall_Landroid_os_Bundle_Handler")]
		public abstract void OnRequestInstall (global::Android.OS.Bundle result);

	}

	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub", DoNotGenerateAcw=true)]
	internal partial class InstallServiceCallbackStubInvoker : InstallServiceCallbackStub {

		public InstallServiceCallbackStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstallServiceCallbackStubInvoker); }
		}

		static IntPtr id_onRequestInfo_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInfo", "(Landroid/os/Bundle;)V", "GetOnRequestInfo_Landroid_os_Bundle_Handler")]
		public override unsafe void OnRequestInfo (global::Android.OS.Bundle result)
		{
			if (id_onRequestInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRequestInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInfo", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (result);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInfo_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_onRequestInstall_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInstall' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInstall", "(Landroid/os/Bundle;)V", "GetOnRequestInstall_Landroid_os_Bundle_Handler")]
		public override unsafe void OnRequestInstall (global::Android.OS.Bundle result)
		{
			if (id_onRequestInstall_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRequestInstall_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInstall", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (result);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInstall_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']"
	[Register ("com/google/android/play/core/install/protocol/IInstallServiceCallback", "", "Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallbackInvoker")]
	public partial interface IInstallServiceCallback : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInfo", "(Landroid/os/Bundle;)V", "GetOnRequestInfo_Landroid_os_Bundle_Handler:Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallbackInvoker, Xamarin.Google.ARCore")]
		void OnRequestInfo (global::Android.OS.Bundle result);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallServiceCallback']/method[@name='onRequestInstall' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onRequestInstall", "(Landroid/os/Bundle;)V", "GetOnRequestInstall_Landroid_os_Bundle_Handler:Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallbackInvoker, Xamarin.Google.ARCore")]
		void OnRequestInstall (global::Android.OS.Bundle result);

	}

	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallServiceCallback", DoNotGenerateAcw=true)]
	internal class IInstallServiceCallbackInvoker : global::Java.Lang.Object, IInstallServiceCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallServiceCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInstallServiceCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IInstallServiceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstallServiceCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.play.core.install.protocol.IInstallServiceCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstallServiceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRequestInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRequestInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRequestInfo_Landroid_os_Bundle_ == null)
				cb_onRequestInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInfo_Landroid_os_Bundle_);
			return cb_onRequestInfo_Landroid_os_Bundle_;
		}

		static void n_OnRequestInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestInfo (result);
		}
#pragma warning restore 0169

		IntPtr id_onRequestInfo_Landroid_os_Bundle_;
		public unsafe void OnRequestInfo (global::Android.OS.Bundle result)
		{
			if (id_onRequestInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRequestInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInfo", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (result);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInfo_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_onRequestInstall_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnRequestInstall_Landroid_os_Bundle_Handler ()
		{
			if (cb_onRequestInstall_Landroid_os_Bundle_ == null)
				cb_onRequestInstall_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRequestInstall_Landroid_os_Bundle_);
			return cb_onRequestInstall_Landroid_os_Bundle_;
		}

		static void n_OnRequestInstall_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle result = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestInstall (result);
		}
#pragma warning restore 0169

		IntPtr id_onRequestInstall_Landroid_os_Bundle_;
		public unsafe void OnRequestInstall (global::Android.OS.Bundle result)
		{
			if (id_onRequestInstall_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onRequestInstall_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onRequestInstall", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (result);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestInstall_Landroid_os_Bundle_, __args);
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
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
