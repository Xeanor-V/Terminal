using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']"
	[global::Android.Runtime.Register ("de/javagl/obj/ObjUtils", DoNotGenerateAcw=true)]
	public partial class ObjUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/ObjUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjUtils); }
		}

		protected ObjUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_convertToRenderable_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='convertToRenderable' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("convertToRenderable", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj ConvertToRenderable (global::JavaGl.Obj.IReadableObj input)
		{
			if (id_convertToRenderable_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_convertToRenderable_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "convertToRenderable", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (input);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertToRenderable_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_convertToRenderable_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='convertToRenderable' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='T']]"
		[Register ("convertToRenderable", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object ConvertToRenderable (global::JavaGl.Obj.IReadableObj input, global::Java.Lang.Object output)
		{
			if (id_convertToRenderable_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_convertToRenderable_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "convertToRenderable", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertToRenderable_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_createInfoString_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='createInfoString' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("createInfoString", "(Lde/javagl/obj/ReadableObj;)Ljava/lang/String;", "")]
		public static unsafe string CreateInfoString (global::JavaGl.Obj.IReadableObj obj)
		{
			if (id_createInfoString_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_createInfoString_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "createInfoString", "(Lde/javagl/obj/ReadableObj;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createInfoString_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='groupToObj' and count(parameter)=3 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='de.javagl.obj.ObjGroup'] and parameter[3][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("groupToObj", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/ObjGroup;Ljava/util/List;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj GroupToObj (global::JavaGl.Obj.IReadableObj input, global::JavaGl.Obj.IObjGroup inputGroup, global::System.Collections.Generic.IList<global::Java.Lang.Integer> vertexIndexMapping)
		{
			if (id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_ == IntPtr.Zero)
				id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "groupToObj", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/ObjGroup;Ljava/util/List;)Lde/javagl/obj/Obj;");
			IntPtr native_vertexIndexMapping = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (vertexIndexMapping);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (input);
				__args [1] = new JValue (inputGroup);
				__args [2] = new JValue (native_vertexIndexMapping);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexIndexMapping);
			}
		}

		static IntPtr id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='groupToObj' and count(parameter)=4 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='de.javagl.obj.ObjGroup'] and parameter[3][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[4][@type='T']]"
		[Register ("groupToObj", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/ObjGroup;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object GroupToObj (global::JavaGl.Obj.IReadableObj input, global::JavaGl.Obj.IObjGroup inputGroup, global::System.Collections.Generic.IList<global::Java.Lang.Integer> vertexIndexMapping, global::Java.Lang.Object output)
		{
			if (id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "groupToObj", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/ObjGroup;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_vertexIndexMapping = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (vertexIndexMapping);
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (input);
				__args [1] = new JValue (inputGroup);
				__args [2] = new JValue (native_vertexIndexMapping);
				__args [3] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_groupToObj_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_ObjGroup_Ljava_util_List_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexIndexMapping);
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeNormalsUnique' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("makeNormalsUnique", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj MakeNormalsUnique (global::JavaGl.Obj.IReadableObj input)
		{
			if (id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeNormalsUnique", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (input);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeNormalsUnique' and count(parameter)=3 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[3][@type='T']]"
		[Register ("makeNormalsUnique", "(Lde/javagl/obj/ReadableObj;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object MakeNormalsUnique (global::JavaGl.Obj.IReadableObj input, global::System.Collections.Generic.IList<global::Java.Lang.Integer> indexMapping, global::Java.Lang.Object output)
		{
			if (id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeNormalsUnique", "(Lde/javagl/obj/ReadableObj;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_indexMapping = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (indexMapping);
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_indexMapping);
				__args [2] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeNormalsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_indexMapping);
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeTexCoordsUnique' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("makeTexCoordsUnique", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj MakeTexCoordsUnique (global::JavaGl.Obj.IReadableObj input)
		{
			if (id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeTexCoordsUnique", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (input);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeTexCoordsUnique' and count(parameter)=3 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[3][@type='T']]"
		[Register ("makeTexCoordsUnique", "(Lde/javagl/obj/ReadableObj;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object MakeTexCoordsUnique (global::JavaGl.Obj.IReadableObj input, global::System.Collections.Generic.IList<global::Java.Lang.Integer> indexMapping, global::Java.Lang.Object output)
		{
			if (id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeTexCoordsUnique", "(Lde/javagl/obj/ReadableObj;Ljava/util/List;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_indexMapping = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (indexMapping);
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_indexMapping);
				__args [2] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeTexCoordsUnique_Lde_javagl_obj_ReadableObj_Ljava_util_List_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_indexMapping);
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeVertexIndexed' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("makeVertexIndexed", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj MakeVertexIndexed (global::JavaGl.Obj.IReadableObj input)
		{
			if (id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeVertexIndexed", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (input);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='makeVertexIndexed' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='T']]"
		[Register ("makeVertexIndexed", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object MakeVertexIndexed (global::JavaGl.Obj.IReadableObj input, global::Java.Lang.Object output)
		{
			if (id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "makeVertexIndexed", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeVertexIndexed_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_triangulate_Lde_javagl_obj_ReadableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='triangulate' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ReadableObj']]"
		[Register ("triangulate", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj Triangulate (global::JavaGl.Obj.IReadableObj input)
		{
			if (id_triangulate_Lde_javagl_obj_ReadableObj_ == IntPtr.Zero)
				id_triangulate_Lde_javagl_obj_ReadableObj_ = JNIEnv.GetStaticMethodID (class_ref, "triangulate", "(Lde/javagl/obj/ReadableObj;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (input);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_triangulate_Lde_javagl_obj_ReadableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_triangulate_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjUtils']/method[@name='triangulate' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='T']]"
		[Register ("triangulate", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object Triangulate (global::JavaGl.Obj.IReadableObj input, global::Java.Lang.Object output)
		{
			if (id_triangulate_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_triangulate_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "triangulate", "(Lde/javagl/obj/ReadableObj;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_triangulate_Lde_javagl_obj_ReadableObj_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

	}
}
