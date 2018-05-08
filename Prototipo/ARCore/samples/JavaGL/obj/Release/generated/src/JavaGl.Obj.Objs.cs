using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='Objs']"
	[global::Android.Runtime.Register ("de/javagl/obj/Objs", DoNotGenerateAcw=true)]
	public partial class Objs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/Objs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Objs); }
		}

		protected Objs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='Objs']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lde/javagl/obj/Obj;");
			try {
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createFromIndexedTriangleData_Ljava_nio_IntBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='Objs']/method[@name='createFromIndexedTriangleData' and count(parameter)=4 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='java.nio.FloatBuffer'] and parameter[3][@type='java.nio.FloatBuffer'] and parameter[4][@type='java.nio.FloatBuffer']]"
		[Register ("createFromIndexedTriangleData", "(Ljava/nio/IntBuffer;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj CreateFromIndexedTriangleData (global::Java.Nio.IntBuffer indices, global::Java.Nio.FloatBuffer vertices, global::Java.Nio.FloatBuffer texCoords, global::Java.Nio.FloatBuffer normals)
		{
			if (id_createFromIndexedTriangleData_Ljava_nio_IntBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_createFromIndexedTriangleData_Ljava_nio_IntBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "createFromIndexedTriangleData", "(Ljava/nio/IntBuffer;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (indices);
				__args [1] = new JValue (vertices);
				__args [2] = new JValue (texCoords);
				__args [3] = new JValue (normals);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromIndexedTriangleData_Ljava_nio_IntBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
