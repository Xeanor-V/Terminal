using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']"
	[global::Android.Runtime.Register ("de/javagl/obj/ObjData", DoNotGenerateAcw=true)]
	public partial class ObjData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/ObjData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjData); }
		}

		protected ObjData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceNormalIndices' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceNormalIndices (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceNormalIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceNormalIndices (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceNormalIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.IntBuffer']]"
		[Register ("getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V", "")]
		public static unsafe void GetFaceNormalIndices (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.IntBuffer target)
		{
			if (id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ == IntPtr.Zero)
				id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceNormalIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getFaceNormalIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceNormalIndicesArray' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceNormalIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I", "")]
		public static unsafe int[] GetFaceNormalIndicesArray (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceNormalIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceNormalIndicesArray' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceNormalIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I", "")]
		public static unsafe int[] GetFaceNormalIndicesArray (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceNormalIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceNormalIndicesArray_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceTexCoordIndices' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceTexCoordIndices (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceTexCoordIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceTexCoordIndices (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceTexCoordIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.IntBuffer']]"
		[Register ("getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V", "")]
		public static unsafe void GetFaceTexCoordIndices (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.IntBuffer target)
		{
			if (id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ == IntPtr.Zero)
				id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceTexCoordIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getFaceTexCoordIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceTexCoordIndicesArray' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceTexCoordIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I", "")]
		public static unsafe int[] GetFaceTexCoordIndicesArray (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceTexCoordIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceTexCoordIndicesArray' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceTexCoordIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I", "")]
		public static unsafe int[] GetFaceTexCoordIndicesArray (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceTexCoordIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceTexCoordIndicesArray_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceVertexIndices' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceVertexIndices (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceVertexIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer GetFaceVertexIndices (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/IntBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				global::Java.Nio.IntBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceVertexIndices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.IntBuffer']]"
		[Register ("getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V", "")]
		public static unsafe void GetFaceVertexIndices (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.IntBuffer target)
		{
			if (id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ == IntPtr.Zero)
				id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceVertexIndices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/IntBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getFaceVertexIndices_Lde_javagl_obj_ReadableObj_Ljava_nio_IntBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceVertexIndicesArray' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getFaceVertexIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I", "")]
		public static unsafe int[] GetFaceVertexIndicesArray (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getFaceVertexIndicesArray", "(Lde/javagl/obj/ReadableObj;)[I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getFaceVertexIndicesArray' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getFaceVertexIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I", "")]
		public static unsafe int[] GetFaceVertexIndicesArray (global::JavaGl.Obj.IReadableObj obj, int numVerticesPerFace)
		{
			if (id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getFaceVertexIndicesArray", "(Lde/javagl/obj/ReadableObj;I)[I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (numVerticesPerFace);
				int[] __ret = (int[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFaceVertexIndicesArray_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef, typeof (int));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNormals_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getNormals' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getNormals", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer GetNormals (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getNormals_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getNormals_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getNormals", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/FloatBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Nio.FloatBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNormals_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNormals_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getNormals' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Register ("getNormals", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;)V", "")]
		public static unsafe void GetNormals (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.FloatBuffer target)
		{
			if (id_getNormals_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_getNormals_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getNormals", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getNormals_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getNormalsArray_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getNormalsArray' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getNormalsArray", "(Lde/javagl/obj/ReadableObj;)[F", "")]
		public static unsafe float[] GetNormalsArray (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getNormalsArray_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getNormalsArray_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getNormalsArray", "(Lde/javagl/obj/ReadableObj;)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNormalsArray_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTexCoords_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getTexCoords' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getTexCoords", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer GetTexCoords (global::JavaGl.Obj.IReadableObj obj, int dimensions)
		{
			if (id_getTexCoords_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getTexCoords_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getTexCoords", "(Lde/javagl/obj/ReadableObj;I)Ljava/nio/FloatBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (dimensions);
				global::Java.Nio.FloatBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTexCoords_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTexCoords_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getTexCoords' and count(parameter)=3 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.FloatBuffer'] and parameter[3][@type='int']]"
		[Register ("getTexCoords", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;I)V", "")]
		public static unsafe void GetTexCoords (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.FloatBuffer target, int dimensions)
		{
			if (id_getTexCoords_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_I == IntPtr.Zero)
				id_getTexCoords_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "getTexCoords", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				__args [2] = new JValue (dimensions);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getTexCoords_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_I, __args);
			} finally {
			}
		}

		static IntPtr id_getTexCoordsArray_Lde_javagl_obj_ReadableObj_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getTexCoordsArray' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='int']]"
		[Register ("getTexCoordsArray", "(Lde/javagl/obj/ReadableObj;I)[F", "")]
		public static unsafe float[] GetTexCoordsArray (global::JavaGl.Obj.IReadableObj obj, int dimensions)
		{
			if (id_getTexCoordsArray_Lde_javagl_obj_ReadableObj_I == IntPtr.Zero)
				id_getTexCoordsArray_Lde_javagl_obj_ReadableObj_I = JNIEnv.GetStaticMethodID (class_ref, "getTexCoordsArray", "(Lde/javagl/obj/ReadableObj;I)[F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (dimensions);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTexCoordsArray_Lde_javagl_obj_ReadableObj_I, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTotalNumFaceVertices_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getTotalNumFaceVertices' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getTotalNumFaceVertices", "(Lde/javagl/obj/ReadableObj;)I", "")]
		public static unsafe int GetTotalNumFaceVertices (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getTotalNumFaceVertices_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getTotalNumFaceVertices_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getTotalNumFaceVertices", "(Lde/javagl/obj/ReadableObj;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getTotalNumFaceVertices_Lde_javagl_obj_ReadableObj_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getVertices_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getVertices' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getVertices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer GetVertices (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getVertices_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getVertices_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getVertices", "(Lde/javagl/obj/ReadableObj;)Ljava/nio/FloatBuffer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::Java.Nio.FloatBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVertices_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getVertices_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getVertices' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Register ("getVertices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;)V", "")]
		public static unsafe void GetVertices (global::JavaGl.Obj.IReadableObj obj, global::Java.Nio.FloatBuffer target)
		{
			if (id_getVertices_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_getVertices_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getVertices", "(Lde/javagl/obj/ReadableObj;Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (obj);
				__args [1] = new JValue (target);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getVertices_Lde_javagl_obj_ReadableObj_Ljava_nio_FloatBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_getVerticesArray_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjData']/method[@name='getVerticesArray' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("getVerticesArray", "(Lde/javagl/obj/ReadableObj;)[F", "")]
		public static unsafe float[] GetVerticesArray (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_getVerticesArray_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_getVerticesArray_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "getVerticesArray", "(Lde/javagl/obj/ReadableObj;)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVerticesArray_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

	}
}
