using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']"
	[Register ("de/javagl/obj/FloatTuple", "", "JavaGl.Obj.IFloatTupleInvoker")]
	public partial interface IFloatTuple : IJavaObject {

		int Dimensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='getDimensions' and count(parameter)=0]"
			[Register ("getDimensions", "()I", "GetGetDimensionsHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)F", "GetGet_IHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")]
		float Get (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='getW' and count(parameter)=0]"
		[Register ("getW", "()F", "GetGetWHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")]
		float GetW ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")]
		float GetX ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")]
		float GetY ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='FloatTuple']/method[@name='getZ' and count(parameter)=0]"
		[Register ("getZ", "()F", "GetGetZHandler:JavaGl.Obj.IFloatTupleInvoker, JavaGL")]
		float GetZ ();

	}

	[global::Android.Runtime.Register ("de/javagl/obj/FloatTuple", DoNotGenerateAcw=true)]
	internal class IFloatTupleInvoker : global::Java.Lang.Object, IFloatTuple {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/FloatTuple");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFloatTupleInvoker); }
		}

		IntPtr class_ref;

		public static IFloatTuple GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFloatTuple> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.FloatTuple"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFloatTupleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDimensions;
#pragma warning disable 0169
		static Delegate GetGetDimensionsHandler ()
		{
			if (cb_getDimensions == null)
				cb_getDimensions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDimensions);
			return cb_getDimensions;
		}

		static int n_GetDimensions (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dimensions;
		}
#pragma warning restore 0169

		IntPtr id_getDimensions;
		public unsafe int Dimensions {
			get {
				if (id_getDimensions == IntPtr.Zero)
					id_getDimensions = JNIEnv.GetMethodID (class_ref, "getDimensions", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDimensions);
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_Get_I);
			return cb_get_I;
		}

		static float n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (p0);
		}
#pragma warning restore 0169

		IntPtr id_get_I;
		public unsafe float Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)F");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args);
		}

		static Delegate cb_getW;
#pragma warning disable 0169
		static Delegate GetGetWHandler ()
		{
			if (cb_getW == null)
				cb_getW = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetW);
			return cb_getW;
		}

		static float n_GetW (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetW ();
		}
#pragma warning restore 0169

		IntPtr id_getW;
		public unsafe float GetW ()
		{
			if (id_getW == IntPtr.Zero)
				id_getW = JNIEnv.GetMethodID (class_ref, "getW", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getW);
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		IntPtr id_getX;
		public unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getX);
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		IntPtr id_getY;
		public unsafe float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getY);
		}

		static Delegate cb_getZ;
#pragma warning disable 0169
		static Delegate GetGetZHandler ()
		{
			if (cb_getZ == null)
				cb_getZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZ);
			return cb_getZ;
		}

		static float n_GetZ (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IFloatTuple __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetZ ();
		}
#pragma warning restore 0169

		IntPtr id_getZ;
		public unsafe float GetZ ()
		{
			if (id_getZ == IntPtr.Zero)
				id_getZ = JNIEnv.GetMethodID (class_ref, "getZ", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getZ);
		}

	}

}
