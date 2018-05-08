using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.Android.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']"
	[global::Android.Runtime.Register ("com/google/android/aidl/BaseProxy", DoNotGenerateAcw=true)]
	public abstract partial class BaseProxy : global::Java.Lang.Object, global::Android.OS.IInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/aidl/BaseProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseProxy); }
		}

		protected BaseProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_IBinder_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/constructor[@name='BaseProxy' and count(parameter)=2 and parameter[1][@type='android.os.IBinder'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/os/IBinder;Ljava/lang/String;)V", "")]
		protected unsafe BaseProxy (global::Android.OS.IBinder remote, string descriptor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_descriptor = JNIEnv.NewString (descriptor);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (remote);
				__args [1] = new JValue (native_descriptor);
				if (((object) this).GetType () != typeof (BaseProxy)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/IBinder;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/IBinder;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_IBinder_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_os_IBinder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/IBinder;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_IBinder_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_IBinder_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_descriptor);
			}
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
			global::Google.Android.Aidl.BaseProxy __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_obtainAndWriteInterfaceToken;
#pragma warning disable 0169
		static Delegate GetObtainAndWriteInterfaceTokenHandler ()
		{
			if (cb_obtainAndWriteInterfaceToken == null)
				cb_obtainAndWriteInterfaceToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ObtainAndWriteInterfaceToken);
			return cb_obtainAndWriteInterfaceToken;
		}

		static IntPtr n_ObtainAndWriteInterfaceToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.Android.Aidl.BaseProxy __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainAndWriteInterfaceToken ());
		}
#pragma warning restore 0169

		static IntPtr id_obtainAndWriteInterfaceToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/method[@name='obtainAndWriteInterfaceToken' and count(parameter)=0]"
		[Register ("obtainAndWriteInterfaceToken", "()Landroid/os/Parcel;", "GetObtainAndWriteInterfaceTokenHandler")]
		protected virtual unsafe global::Android.OS.Parcel ObtainAndWriteInterfaceToken ()
		{
			if (id_obtainAndWriteInterfaceToken == IntPtr.Zero)
				id_obtainAndWriteInterfaceToken = JNIEnv.GetMethodID (class_ref, "obtainAndWriteInterfaceToken", "()Landroid/os/Parcel;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_obtainAndWriteInterfaceToken), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainAndWriteInterfaceToken", "()Landroid/os/Parcel;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transactAndReadException_ILandroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetTransactAndReadException_ILandroid_os_Parcel_Handler ()
		{
			if (cb_transactAndReadException_ILandroid_os_Parcel_ == null)
				cb_transactAndReadException_ILandroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_TransactAndReadException_ILandroid_os_Parcel_);
			return cb_transactAndReadException_ILandroid_os_Parcel_;
		}

		static IntPtr n_TransactAndReadException_ILandroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native__in)
		{
			global::Google.Android.Aidl.BaseProxy __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @in = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TransactAndReadException (code, @in));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transactAndReadException_ILandroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/method[@name='transactAndReadException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel']]"
		[Register ("transactAndReadException", "(ILandroid/os/Parcel;)Landroid/os/Parcel;", "GetTransactAndReadException_ILandroid_os_Parcel_Handler")]
		protected virtual unsafe global::Android.OS.Parcel TransactAndReadException (int code, global::Android.OS.Parcel @in)
		{
			if (id_transactAndReadException_ILandroid_os_Parcel_ == IntPtr.Zero)
				id_transactAndReadException_ILandroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "transactAndReadException", "(ILandroid/os/Parcel;)Landroid/os/Parcel;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (@in);

				global::Android.OS.Parcel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transactAndReadException_ILandroid_os_Parcel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transactAndReadException", "(ILandroid/os/Parcel;)Landroid/os/Parcel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetTransactAndReadExceptionReturnVoid_ILandroid_os_Parcel_Handler ()
		{
			if (cb_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_ == null)
				cb_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_TransactAndReadExceptionReturnVoid_ILandroid_os_Parcel_);
			return cb_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_;
		}

		static void n_TransactAndReadExceptionReturnVoid_ILandroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native__in)
		{
			global::Google.Android.Aidl.BaseProxy __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @in = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.TransactAndReadExceptionReturnVoid (code, @in);
		}
#pragma warning restore 0169

		static IntPtr id_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/method[@name='transactAndReadExceptionReturnVoid' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel']]"
		[Register ("transactAndReadExceptionReturnVoid", "(ILandroid/os/Parcel;)V", "GetTransactAndReadExceptionReturnVoid_ILandroid_os_Parcel_Handler")]
		protected virtual unsafe void TransactAndReadExceptionReturnVoid (int code, global::Android.OS.Parcel @in)
		{
			if (id_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_ == IntPtr.Zero)
				id_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "transactAndReadExceptionReturnVoid", "(ILandroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (@in);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transactAndReadExceptionReturnVoid_ILandroid_os_Parcel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transactAndReadExceptionReturnVoid", "(ILandroid/os/Parcel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_transactOneway_ILandroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetTransactOneway_ILandroid_os_Parcel_Handler ()
		{
			if (cb_transactOneway_ILandroid_os_Parcel_ == null)
				cb_transactOneway_ILandroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_TransactOneway_ILandroid_os_Parcel_);
			return cb_transactOneway_ILandroid_os_Parcel_;
		}

		static void n_TransactOneway_ILandroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native__in)
		{
			global::Google.Android.Aidl.BaseProxy __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @in = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.TransactOneway (code, @in);
		}
#pragma warning restore 0169

		static IntPtr id_transactOneway_ILandroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseProxy']/method[@name='transactOneway' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel']]"
		[Register ("transactOneway", "(ILandroid/os/Parcel;)V", "GetTransactOneway_ILandroid_os_Parcel_Handler")]
		protected virtual unsafe void TransactOneway (int code, global::Android.OS.Parcel @in)
		{
			if (id_transactOneway_ILandroid_os_Parcel_ == IntPtr.Zero)
				id_transactOneway_ILandroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "transactOneway", "(ILandroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (code);
				__args [1] = new JValue (@in);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transactOneway_ILandroid_os_Parcel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transactOneway", "(ILandroid/os/Parcel;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/aidl/BaseProxy", DoNotGenerateAcw=true)]
	internal partial class BaseProxyInvoker : BaseProxy {

		public BaseProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseProxyInvoker); }
		}

	}

}
