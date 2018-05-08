using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjFaces']"
	[global::Android.Runtime.Register ("de/javagl/obj/ObjFaces", DoNotGenerateAcw=true)]
	public partial class ObjFaces : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/ObjFaces", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjFaces); }
		}

		protected ObjFaces (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_create_arrayIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjFaces']/method[@name='create' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("create", "([I[I[I)Lde/javagl/obj/ObjFace;", "")]
		public static unsafe global::JavaGl.Obj.IObjFace Create (int[] v, int[] vt, int[] vn)
		{
			if (id_create_arrayIarrayIarrayI == IntPtr.Zero)
				id_create_arrayIarrayIarrayI = JNIEnv.GetStaticMethodID (class_ref, "create", "([I[I[I)Lde/javagl/obj/ObjFace;");
			IntPtr native_v = JNIEnv.NewArray (v);
			IntPtr native_vt = JNIEnv.NewArray (vt);
			IntPtr native_vn = JNIEnv.NewArray (vn);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_v);
				__args [1] = new JValue (native_vt);
				__args [2] = new JValue (native_vn);
				global::JavaGl.Obj.IObjFace __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_arrayIarrayIarrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
				if (vt != null) {
					JNIEnv.CopyArray (native_vt, vt);
					JNIEnv.DeleteLocalRef (native_vt);
				}
				if (vn != null) {
					JNIEnv.CopyArray (native_vn, vn);
					JNIEnv.DeleteLocalRef (native_vn);
				}
			}
		}

		static IntPtr id_createString_Lde_javagl_obj_ObjFace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjFaces']/method[@name='createString' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("createString", "(Lde/javagl/obj/ObjFace;)Ljava/lang/String;", "")]
		public static unsafe string CreateString (global::JavaGl.Obj.IObjFace face)
		{
			if (id_createString_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_createString_Lde_javagl_obj_ObjFace_ = JNIEnv.GetStaticMethodID (class_ref, "createString", "(Lde/javagl/obj/ObjFace;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (face);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createString_Lde_javagl_obj_ObjFace_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
