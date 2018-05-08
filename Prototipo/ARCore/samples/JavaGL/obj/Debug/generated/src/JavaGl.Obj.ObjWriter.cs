using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjWriter']"
	[global::Android.Runtime.Register ("de/javagl/obj/ObjWriter", DoNotGenerateAcw=true)]
	public partial class ObjWriter : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/ObjWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ObjWriter); }
		}

		protected ObjWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_write_Lde_javagl_obj_ReadableObj_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjWriter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("write", "(Lde/javagl/obj/ReadableObj;Ljava/io/OutputStream;)V", "")]
		public static unsafe void Write (global::JavaGl.Obj.IReadableObj input, global::System.IO.Stream outputStream)
		{
			if (id_write_Lde_javagl_obj_ReadableObj_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_write_Lde_javagl_obj_ReadableObj_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "write", "(Lde/javagl/obj/ReadableObj;Ljava/io/OutputStream;)V");
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (input);
				__args [1] = new JValue (native_outputStream);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_write_Lde_javagl_obj_ReadableObj_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputStream);
			}
		}

		static IntPtr id_write_Lde_javagl_obj_ReadableObj_Ljava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='ObjWriter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='de.javagl.obj.ReadableObj'] and parameter[2][@type='java.io.Writer']]"
		[Register ("write", "(Lde/javagl/obj/ReadableObj;Ljava/io/Writer;)V", "")]
		public static unsafe void Write (global::JavaGl.Obj.IReadableObj input, global::Java.IO.Writer writer)
		{
			if (id_write_Lde_javagl_obj_ReadableObj_Ljava_io_Writer_ == IntPtr.Zero)
				id_write_Lde_javagl_obj_ReadableObj_Ljava_io_Writer_ = JNIEnv.GetStaticMethodID (class_ref, "write", "(Lde/javagl/obj/ReadableObj;Ljava/io/Writer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (input);
				__args [1] = new JValue (writer);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_write_Lde_javagl_obj_ReadableObj_Ljava_io_Writer_, __args);
			} finally {
			}
		}

	}
}
