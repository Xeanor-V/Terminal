using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Play.Core.Install.Protocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub']"
	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class InstallServiceStub : global::Google.Android.Aidl.BaseStub, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallService$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Google.Android.Aidl.BaseProxy, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallService$Stub$Proxy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Proxy); }
			}

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
			static Delegate GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
			{
				if (cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
					cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
				return cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
			}

			static void n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_requestedPackage, IntPtr native__callback)
			{
				global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle requestedPackage = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_requestedPackage, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.RequestInfo (callingPackageName, requestedPackage, @callback);
			}
#pragma warning restore 0169

			static IntPtr id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub.Proxy']/method[@name='requestInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
			[Register ("requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
			public virtual unsafe void RequestInfo (string callingPackageName, global::Android.OS.Bundle requestedPackage, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
			{
				if (id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
					id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
				IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_callingPackageName);
					__args [1] = new JValue (requestedPackage);
					__args [2] = new JValue (@callback);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_callingPackageName);
				}
			}

			static Delegate cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
			static Delegate GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
			{
				if (cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
					cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
				return cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
			}

			static void n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_packages, IntPtr native_options, IntPtr native__callback)
			{
				global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub.Proxy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub.Proxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
				var packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.FromJniHandle (native_packages, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
				__this.RequestInstall (callingPackageName, packages, options, @callback);
			}
#pragma warning restore 0169

			static IntPtr id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub.Proxy']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.os.Bundle&gt;'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
			[Register ("requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
			public virtual unsafe void RequestInstall (string callingPackageName, global::System.Collections.Generic.IList<global::Android.OS.Bundle> packages, global::Android.OS.Bundle options, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
			{
				if (id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
					id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
				IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
				IntPtr native_packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.ToLocalJniHandle (packages);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_callingPackageName);
					__args [1] = new JValue (native_packages);
					__args [2] = new JValue (options);
					__args [3] = new JValue (@callback);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_callingPackageName);
					JNIEnv.DeleteLocalRef (native_packages);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallService$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstallServiceStub); }
		}

		protected InstallServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub']/constructor[@name='IInstallService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstallServiceStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstallServiceStub)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/android/play/core/install/protocol/IInstallService;", "")]
		public static unsafe global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/android/play/core/install/protocol/IInstallService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/class[@name='IInstallService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
		{
			if (cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
				cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
			return cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		}

		static void n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_requestedPackage, IntPtr native__callback)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle requestedPackage = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_requestedPackage, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RequestInfo (callingPackageName, requestedPackage, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
		public abstract void RequestInfo (string callingPackageName, global::Android.OS.Bundle requestedPackage, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback);

		static Delegate cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
		{
			if (cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
				cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
			return cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		}

		static void n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_packages, IntPtr native_options, IntPtr native__callback)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
			var packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.FromJniHandle (native_packages, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RequestInstall (callingPackageName, packages, options, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.os.Bundle&gt;'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
		public abstract void RequestInstall (string callingPackageName, global::System.Collections.Generic.IList<global::Android.OS.Bundle> packages, global::Android.OS.Bundle options, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback);

	}

	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallService$Stub", DoNotGenerateAcw=true)]
	internal partial class InstallServiceStubInvoker : InstallServiceStub {

		public InstallServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstallServiceStubInvoker); }
		}

		static IntPtr id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
		public override unsafe void RequestInfo (string callingPackageName, global::Android.OS.Bundle requestedPackage, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
		{
			if (id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
				id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
			IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_callingPackageName);
				__args [1] = new JValue (requestedPackage);
				__args [2] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_callingPackageName);
			}
		}

		static IntPtr id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.os.Bundle&gt;'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler")]
		public override unsafe void RequestInstall (string callingPackageName, global::System.Collections.Generic.IList<global::Android.OS.Bundle> packages, global::Android.OS.Bundle options, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
		{
			if (id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
				id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
			IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
			IntPtr native_packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.ToLocalJniHandle (packages);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_callingPackageName);
				__args [1] = new JValue (native_packages);
				__args [2] = new JValue (options);
				__args [3] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_callingPackageName);
				JNIEnv.DeleteLocalRef (native_packages);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']"
	[Register ("com/google/android/play/core/install/protocol/IInstallService", "", "Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceInvoker")]
	public partial interface IInstallService : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler:Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceInvoker, Xamarin.Google.ARCore")]
		void RequestInfo (string callingPackageName, global::Android.OS.Bundle requestedPackage, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.play.core.install.protocol']/interface[@name='IInstallService']/method[@name='requestInstall' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;android.os.Bundle&gt;'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='com.google.android.play.core.install.protocol.IInstallServiceCallback']]"
		[Register ("requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V", "GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler:Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceInvoker, Xamarin.Google.ARCore")]
		void RequestInstall (string callingPackageName, global::System.Collections.Generic.IList<global::Android.OS.Bundle> packages, global::Android.OS.Bundle options, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback);

	}

	[global::Android.Runtime.Register ("com/google/android/play/core/install/protocol/IInstallService", DoNotGenerateAcw=true)]
	internal class IInstallServiceInvoker : global::Java.Lang.Object, IInstallService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/play/core/install/protocol/IInstallService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInstallServiceInvoker); }
		}

		IntPtr class_ref;

		public static IInstallService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstallService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.play.core.install.protocol.IInstallService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstallServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
		{
			if (cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
				cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
			return cb_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		}

		static void n_RequestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_requestedPackage, IntPtr native__callback)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle requestedPackage = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_requestedPackage, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RequestInfo (callingPackageName, requestedPackage, @callback);
		}
#pragma warning restore 0169

		IntPtr id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		public unsafe void RequestInfo (string callingPackageName, global::Android.OS.Bundle requestedPackage, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
		{
			if (id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
				id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInfo", "(Ljava/lang/String;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
			IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_callingPackageName);
			__args [1] = new JValue (requestedPackage);
			__args [2] = new JValue (@callback);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInfo_Ljava_lang_String_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
			JNIEnv.DeleteLocalRef (native_callingPackageName);
		}

		static Delegate cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_Handler ()
		{
			if (cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == null)
				cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_);
			return cb_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		}

		static void n_RequestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callingPackageName, IntPtr native_packages, IntPtr native_options, IntPtr native__callback)
		{
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string callingPackageName = JNIEnv.GetString (native_callingPackageName, JniHandleOwnership.DoNotTransfer);
			var packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.FromJniHandle (native_packages, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback = (global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RequestInstall (callingPackageName, packages, options, @callback);
		}
#pragma warning restore 0169

		IntPtr id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_;
		public unsafe void RequestInstall (string callingPackageName, global::System.Collections.Generic.IList<global::Android.OS.Bundle> packages, global::Android.OS.Bundle options, global::Com.Google.Android.Play.Core.Install.Protocol.IInstallServiceCallback @callback)
		{
			if (id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ == IntPtr.Zero)
				id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_ = JNIEnv.GetMethodID (class_ref, "requestInstall", "(Ljava/lang/String;Ljava/util/List;Landroid/os/Bundle;Lcom/google/android/play/core/install/protocol/IInstallServiceCallback;)V");
			IntPtr native_callingPackageName = JNIEnv.NewString (callingPackageName);
			IntPtr native_packages = global::Android.Runtime.JavaList<global::Android.OS.Bundle>.ToLocalJniHandle (packages);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_callingPackageName);
			__args [1] = new JValue (native_packages);
			__args [2] = new JValue (options);
			__args [3] = new JValue (@callback);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestInstall_Ljava_lang_String_Ljava_util_List_Landroid_os_Bundle_Lcom_google_android_play_core_install_protocol_IInstallServiceCallback_, __args);
			JNIEnv.DeleteLocalRef (native_callingPackageName);
			JNIEnv.DeleteLocalRef (native_packages);
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
			global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Play.Core.Install.Protocol.IInstallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
