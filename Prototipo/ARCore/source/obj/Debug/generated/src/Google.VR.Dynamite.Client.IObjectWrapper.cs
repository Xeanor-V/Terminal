using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.VR.Dynamite.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='IObjectWrapper.Stub']"
	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/IObjectWrapper$Stub", DoNotGenerateAcw=true)]
	public abstract partial class ObjectWrapperStub : global::Google.Android.Aidl.BaseStub, global::Google.VR.Dynamite.Client.IObjectWrapper {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='IObjectWrapper.Stub.Proxy']"
		[global::Android.Runtime.Register ("com/google/vr/dynamite/client/IObjectWrapper$Stub$Proxy", DoNotGenerateAcw=true)]
		public partial class Proxy : global::Google.Android.Aidl.BaseProxy, global::Google.VR.Dynamite.Client.IObjectWrapper {

			protected Proxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/vr/dynamite/client/IObjectWrapper$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectWrapperStub); }
		}

		protected ObjectWrapperStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='IObjectWrapper.Stub']/constructor[@name='IObjectWrapper.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ObjectWrapperStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ObjectWrapperStub)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.vr.dynamite.client']/class[@name='IObjectWrapper.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/IObjectWrapper;", "")]
		public static unsafe global::Google.VR.Dynamite.Client.IObjectWrapper AsInterface (global::Android.OS.IBinder obj)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/google/vr/dynamite/client/IObjectWrapper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Google.VR.Dynamite.Client.IObjectWrapper __ret = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/IObjectWrapper$Stub", DoNotGenerateAcw=true)]
	internal partial class ObjectWrapperStubInvoker : ObjectWrapperStub {

		public ObjectWrapperStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjectWrapperStubInvoker); }
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.vr.dynamite.client']/interface[@name='IObjectWrapper']"
	[Register ("com/google/vr/dynamite/client/IObjectWrapper", "", "Google.VR.Dynamite.Client.IObjectWrapperInvoker")]
	public partial interface IObjectWrapper : global::Android.OS.IInterface {

	}

	[global::Android.Runtime.Register ("com/google/vr/dynamite/client/IObjectWrapper", DoNotGenerateAcw=true)]
	internal class IObjectWrapperInvoker : global::Java.Lang.Object, IObjectWrapper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/vr/dynamite/client/IObjectWrapper");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObjectWrapperInvoker); }
		}

		IntPtr class_ref;

		public static IObjectWrapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjectWrapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.vr.dynamite.client.IObjectWrapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjectWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Google.VR.Dynamite.Client.IObjectWrapper __this = global::Java.Lang.Object.GetObject<global::Google.VR.Dynamite.Client.IObjectWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
