using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']"
	[global::Android.Runtime.Register ("de/javagl/obj/FloatTuples", DoNotGenerateAcw=true)]
	public partial class FloatTuples : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/FloatTuples", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FloatTuples); }
		}

		protected FloatTuples (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_copy_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("copy", "(Lde/javagl/obj/FloatTuple;)Lde/javagl/obj/FloatTuple;", "")]
		public static unsafe global::JavaGl.Obj.IFloatTuple Copy (global::JavaGl.Obj.IFloatTuple other)
		{
			if (id_copy_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_copy_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Lde/javagl/obj/FloatTuple;)Lde/javagl/obj/FloatTuple;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (other);
				global::JavaGl.Obj.IFloatTuple __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_copy_Lde_javagl_obj_FloatTuple_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='create' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("create", "(F)Lde/javagl/obj/FloatTuple;", "")]
		public static unsafe global::JavaGl.Obj.IFloatTuple Create (float x)
		{
			if (id_create_F == IntPtr.Zero)
				id_create_F = JNIEnv.GetStaticMethodID (class_ref, "create", "(F)Lde/javagl/obj/FloatTuple;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (x);
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_F, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='create' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("create", "(FF)Lde/javagl/obj/FloatTuple;", "")]
		public static unsafe global::JavaGl.Obj.IFloatTuple Create (float x, float y)
		{
			if (id_create_FF == IntPtr.Zero)
				id_create_FF = JNIEnv.GetStaticMethodID (class_ref, "create", "(FF)Lde/javagl/obj/FloatTuple;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_FF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='create' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("create", "(FFF)Lde/javagl/obj/FloatTuple;", "")]
		public static unsafe global::JavaGl.Obj.IFloatTuple Create (float x, float y, float z)
		{
			if (id_create_FFF == IntPtr.Zero)
				id_create_FFF = JNIEnv.GetStaticMethodID (class_ref, "create", "(FFF)Lde/javagl/obj/FloatTuple;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_FFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='create' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("create", "(FFFF)Lde/javagl/obj/FloatTuple;", "")]
		public static unsafe global::JavaGl.Obj.IFloatTuple Create (float x, float y, float z, float w)
		{
			if (id_create_FFFF == IntPtr.Zero)
				id_create_FFFF = JNIEnv.GetStaticMethodID (class_ref, "create", "(FFFF)Lde/javagl/obj/FloatTuple;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				__args [3] = new JValue (w);
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_FFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createString_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='FloatTuples']/method[@name='createString' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("createString", "(Lde/javagl/obj/FloatTuple;)Ljava/lang/String;", "")]
		public static unsafe string CreateString (global::JavaGl.Obj.IFloatTuple tuple)
		{
			if (id_createString_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_createString_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetStaticMethodID (class_ref, "createString", "(Lde/javagl/obj/FloatTuple;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (tuple);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_createString_Lde_javagl_obj_FloatTuple_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
