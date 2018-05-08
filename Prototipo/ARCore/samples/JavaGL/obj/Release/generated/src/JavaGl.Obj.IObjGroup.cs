using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjGroup']"
	[Register ("de/javagl/obj/ObjGroup", "", "JavaGl.Obj.IObjGroupInvoker")]
	public partial interface IObjGroup : IJavaObject {

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjGroup']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:JavaGl.Obj.IObjGroupInvoker, JavaGL")] get;
		}

		int NumFaces {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjGroup']/method[@name='getNumFaces' and count(parameter)=0]"
			[Register ("getNumFaces", "()I", "GetGetNumFacesHandler:JavaGl.Obj.IObjGroupInvoker, JavaGL")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjGroup']/method[@name='getFace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFace", "(I)Lde/javagl/obj/ObjFace;", "GetGetFace_IHandler:JavaGl.Obj.IObjGroupInvoker, JavaGL")]
		global::JavaGl.Obj.IObjFace GetFace (int p0);

	}

	[global::Android.Runtime.Register ("de/javagl/obj/ObjGroup", DoNotGenerateAcw=true)]
	internal class IObjGroupInvoker : global::Java.Lang.Object, IObjGroup {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/ObjGroup");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObjGroupInvoker); }
		}

		IntPtr class_ref;

		public static IObjGroup GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjGroup> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.ObjGroup"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjGroupInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObjGroup __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumFaces;
#pragma warning disable 0169
		static Delegate GetGetNumFacesHandler ()
		{
			if (cb_getNumFaces == null)
				cb_getNumFaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFaces);
			return cb_getNumFaces;
		}

		static int n_GetNumFaces (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObjGroup __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumFaces;
		}
#pragma warning restore 0169

		IntPtr id_getNumFaces;
		public unsafe int NumFaces {
			get {
				if (id_getNumFaces == IntPtr.Zero)
					id_getNumFaces = JNIEnv.GetMethodID (class_ref, "getNumFaces", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumFaces);
			}
		}

		static Delegate cb_getFace_I;
#pragma warning disable 0169
		static Delegate GetGetFace_IHandler ()
		{
			if (cb_getFace_I == null)
				cb_getFace_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFace_I);
			return cb_getFace_I;
		}

		static IntPtr n_GetFace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObjGroup __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFace (p0));
		}
#pragma warning restore 0169

		IntPtr id_getFace_I;
		public unsafe global::JavaGl.Obj.IObjFace GetFace (int p0)
		{
			if (id_getFace_I == IntPtr.Zero)
				id_getFace_I = JNIEnv.GetMethodID (class_ref, "getFace", "(I)Lde/javagl/obj/ObjFace;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFace_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
