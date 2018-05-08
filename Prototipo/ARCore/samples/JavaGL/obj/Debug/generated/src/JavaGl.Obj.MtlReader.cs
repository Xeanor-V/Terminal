using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='MtlReader']"
	[global::Android.Runtime.Register ("de/javagl/obj/MtlReader", DoNotGenerateAcw=true)]
	public partial class MtlReader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/MtlReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MtlReader); }
		}

		protected MtlReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_read_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='MtlReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("read", "(Ljava/io/InputStream;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::JavaGl.Obj.IMtl> Read (global::System.IO.Stream inputStream)
		{
			if (id_read_Ljava_io_InputStream_ == IntPtr.Zero)
				id_read_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/InputStream;)Ljava/util/List;");
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_inputStream);
				global::System.Collections.Generic.IList<global::JavaGl.Obj.IMtl> __ret = global::Android.Runtime.JavaList<global::JavaGl.Obj.IMtl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
			}
		}

		static IntPtr id_read_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='MtlReader']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("read", "(Ljava/io/Reader;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::JavaGl.Obj.IMtl> Read (global::Java.IO.Reader reader)
		{
			if (id_read_Ljava_io_Reader_ == IntPtr.Zero)
				id_read_Ljava_io_Reader_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/io/Reader;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (reader);
				global::System.Collections.Generic.IList<global::JavaGl.Obj.IMtl> __ret = global::Android.Runtime.JavaList<global::JavaGl.Obj.IMtl>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_io_Reader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
