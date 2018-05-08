using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjReader']"
	[global::Android.Runtime.Register ("de/javagl/obj/ObjReader", DoNotGenerateAcw=true)]
	public partial class ObjReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/ObjReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjReader); }
		}

		protected ObjReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_read_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("read", "(Ljava/io/InputStream;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj Read (global::System.IO.Stream inputStream)
		{
			if (id_read_Ljava_io_InputStream_ == IntPtr.Zero)
				id_read_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/InputStream;)Lde/javagl/obj/Obj;");
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inputStream);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
			}
		}

		static IntPtr id_read_Ljava_io_InputStream_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjReader']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='T']]"
		[Register ("read", "(Ljava/io/InputStream;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object Read (global::System.IO.Stream inputStream, global::Java.Lang.Object output)
		{
			if (id_read_Ljava_io_InputStream_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_read_Ljava_io_InputStream_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/InputStream;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_inputStream);
				__args [1] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_InputStream_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

		static IntPtr id_read_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("read", "(Ljava/io/Reader;)Lde/javagl/obj/Obj;", "")]
		public static unsafe global::JavaGl.Obj.IObj Read (global::Java.IO.Reader reader)
		{
			if (id_read_Ljava_io_Reader_ == IntPtr.Zero)
				id_read_Ljava_io_Reader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/Reader;)Lde/javagl/obj/Obj;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reader);
				global::JavaGl.Obj.IObj __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_Reader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_read_Ljava_io_Reader_Lde_javagl_obj_WritableObj_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjReader']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='T']]"
		[Register ("read", "(Ljava/io/Reader;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends de.javagl.obj.WritableObj"})]
		public static unsafe global::Java.Lang.Object Read (global::Java.IO.Reader reader, global::Java.Lang.Object output)
		{
			if (id_read_Ljava_io_Reader_Lde_javagl_obj_WritableObj_ == IntPtr.Zero)
				id_read_Ljava_io_Reader_Lde_javagl_obj_WritableObj_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/Reader;Lde/javagl/obj/WritableObj;)Lde/javagl/obj/WritableObj;");
			IntPtr native_output = JNIEnv.ToLocalJniHandle (output);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (reader);
				__args [1] = new JValue (native_output);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_Reader_Lde_javagl_obj_WritableObj_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_output);
			}
		}

	}
}
