using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']"
	[Register ("de/javagl/obj/ObjFace", "", "JavaGl.Obj.IObjFaceInvoker")]
	public partial interface IObjFace : IJavaObject {

		int NumVertices {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='getNumVertices' and count(parameter)=0]"
			[Register ("getNumVertices", "()I", "GetGetNumVerticesHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='containsNormalIndices' and count(parameter)=0]"
		[Register ("containsNormalIndices", "()Z", "GetContainsNormalIndicesHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")]
		bool ContainsNormalIndices ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='containsTexCoordIndices' and count(parameter)=0]"
		[Register ("containsTexCoordIndices", "()Z", "GetContainsTexCoordIndicesHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")]
		bool ContainsTexCoordIndices ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='getNormalIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNormalIndex", "(I)I", "GetGetNormalIndex_IHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")]
		int GetNormalIndex (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='getTexCoordIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTexCoordIndex", "(I)I", "GetGetTexCoordIndex_IHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")]
		int GetTexCoordIndex (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ObjFace']/method[@name='getVertexIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVertexIndex", "(I)I", "GetGetVertexIndex_IHandler:JavaGl.Obj.IObjFaceInvoker, JavaGL")]
		int GetVertexIndex (int p0);

	}

	[global::Android.Runtime.Register ("de/javagl/obj/ObjFace", DoNotGenerateAcw=true)]
	internal class IObjFaceInvoker : global::Java.Lang.Object, IObjFace {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/ObjFace");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObjFaceInvoker); }
		}

		IntPtr class_ref;

		public static IObjFace GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjFace> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.ObjFace"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjFaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getNumVertices;
#pragma warning disable 0169
		static Delegate GetGetNumVerticesHandler ()
		{
			if (cb_getNumVertices == null)
				cb_getNumVertices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumVertices);
			return cb_getNumVertices;
		}

		static int n_GetNumVertices (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumVertices;
		}
#pragma warning restore 0169

		IntPtr id_getNumVertices;
		public unsafe int NumVertices {
			get {
				if (id_getNumVertices == IntPtr.Zero)
					id_getNumVertices = JNIEnv.GetMethodID (class_ref, "getNumVertices", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumVertices);
			}
		}

		static Delegate cb_containsNormalIndices;
#pragma warning disable 0169
		static Delegate GetContainsNormalIndicesHandler ()
		{
			if (cb_containsNormalIndices == null)
				cb_containsNormalIndices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ContainsNormalIndices);
			return cb_containsNormalIndices;
		}

		static bool n_ContainsNormalIndices (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsNormalIndices ();
		}
#pragma warning restore 0169

		IntPtr id_containsNormalIndices;
		public unsafe bool ContainsNormalIndices ()
		{
			if (id_containsNormalIndices == IntPtr.Zero)
				id_containsNormalIndices = JNIEnv.GetMethodID (class_ref, "containsNormalIndices", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsNormalIndices);
		}

		static Delegate cb_containsTexCoordIndices;
#pragma warning disable 0169
		static Delegate GetContainsTexCoordIndicesHandler ()
		{
			if (cb_containsTexCoordIndices == null)
				cb_containsTexCoordIndices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ContainsTexCoordIndices);
			return cb_containsTexCoordIndices;
		}

		static bool n_ContainsTexCoordIndices (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainsTexCoordIndices ();
		}
#pragma warning restore 0169

		IntPtr id_containsTexCoordIndices;
		public unsafe bool ContainsTexCoordIndices ()
		{
			if (id_containsTexCoordIndices == IntPtr.Zero)
				id_containsTexCoordIndices = JNIEnv.GetMethodID (class_ref, "containsTexCoordIndices", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_containsTexCoordIndices);
		}

		static Delegate cb_getNormalIndex_I;
#pragma warning disable 0169
		static Delegate GetGetNormalIndex_IHandler ()
		{
			if (cb_getNormalIndex_I == null)
				cb_getNormalIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetNormalIndex_I);
			return cb_getNormalIndex_I;
		}

		static int n_GetNormalIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetNormalIndex (p0);
		}
#pragma warning restore 0169

		IntPtr id_getNormalIndex_I;
		public unsafe int GetNormalIndex (int p0)
		{
			if (id_getNormalIndex_I == IntPtr.Zero)
				id_getNormalIndex_I = JNIEnv.GetMethodID (class_ref, "getNormalIndex", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNormalIndex_I, __args);
		}

		static Delegate cb_getTexCoordIndex_I;
#pragma warning disable 0169
		static Delegate GetGetTexCoordIndex_IHandler ()
		{
			if (cb_getTexCoordIndex_I == null)
				cb_getTexCoordIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetTexCoordIndex_I);
			return cb_getTexCoordIndex_I;
		}

		static int n_GetTexCoordIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTexCoordIndex (p0);
		}
#pragma warning restore 0169

		IntPtr id_getTexCoordIndex_I;
		public unsafe int GetTexCoordIndex (int p0)
		{
			if (id_getTexCoordIndex_I == IntPtr.Zero)
				id_getTexCoordIndex_I = JNIEnv.GetMethodID (class_ref, "getTexCoordIndex", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTexCoordIndex_I, __args);
		}

		static Delegate cb_getVertexIndex_I;
#pragma warning disable 0169
		static Delegate GetGetVertexIndex_IHandler ()
		{
			if (cb_getVertexIndex_I == null)
				cb_getVertexIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetVertexIndex_I);
			return cb_getVertexIndex_I;
		}

		static int n_GetVertexIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObjFace __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetVertexIndex (p0);
		}
#pragma warning restore 0169

		IntPtr id_getVertexIndex_I;
		public unsafe int GetVertexIndex (int p0)
		{
			if (id_getVertexIndex_I == IntPtr.Zero)
				id_getVertexIndex_I = JNIEnv.GetMethodID (class_ref, "getVertexIndex", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getVertexIndex_I, __args);
		}

	}

}
