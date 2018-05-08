using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.Android.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseStub']"
	[global::Android.Runtime.Register ("com/google/android/aidl/BaseStub", DoNotGenerateAcw=true)]
	public abstract partial class BaseStub : global::Android.OS.Binder, global::Android.OS.IInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/aidl/BaseStub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseStub); }
		}

		protected BaseStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseStub']/constructor[@name='BaseStub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseStub)) {
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
			global::Google.Android.Aidl.BaseStub __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseStub']/method[@name='asBinder' and count(parameter)=0]"
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

		static Delegate cb_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetRouteToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_RouteToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_RouteToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Google.Android.Aidl.BaseStub __this = global::Java.Lang.Object.GetObject<global::Google.Android.Aidl.BaseStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RouteToSuperOrEnforceInterface (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='BaseStub']/method[@name='routeToSuperOrEnforceInterface' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("routeToSuperOrEnforceInterface", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetRouteToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		protected virtual unsafe bool RouteToSuperOrEnforceInterface (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			if (id_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "routeToSuperOrEnforceInterface", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (code);
				__args [1] = new JValue (data);
				__args [2] = new JValue (reply);
				__args [3] = new JValue (flags);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_routeToSuperOrEnforceInterface_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "routeToSuperOrEnforceInterface", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/aidl/BaseStub", DoNotGenerateAcw=true)]
	internal partial class BaseStubInvoker : BaseStub {

		public BaseStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseStubInvoker); }
		}

	}

}
