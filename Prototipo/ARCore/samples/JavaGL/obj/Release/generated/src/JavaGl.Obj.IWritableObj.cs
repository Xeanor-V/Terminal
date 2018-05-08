using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']"
	[Register ("de/javagl/obj/WritableObj", "", "JavaGl.Obj.IWritableObjInvoker")]
	public partial interface IWritableObj : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("addFace", "(Lde/javagl/obj/ObjFace;)V", "GetAddFace_Lde_javagl_obj_ObjFace_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFace (global::JavaGl.Obj.IObjFace p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFace", "([I)V", "GetAddFace_arrayIHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFace (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFace' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("addFace", "([I[I[I)V", "GetAddFace_arrayIarrayIarrayIHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFace (int[] p0, int[] p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFaceWithAll' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithAll", "([I)V", "GetAddFaceWithAll_arrayIHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFaceWithAll (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFaceWithNormals' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithNormals", "([I)V", "GetAddFaceWithNormals_arrayIHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFaceWithNormals (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addFaceWithTexCoords' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithTexCoords", "([I)V", "GetAddFaceWithTexCoords_arrayIHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddFaceWithTexCoords (params  int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addNormal' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addNormal", "(Lde/javagl/obj/FloatTuple;)V", "GetAddNormal_Lde_javagl_obj_FloatTuple_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddNormal (global::JavaGl.Obj.IFloatTuple p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addNormal' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addNormal", "(FFF)V", "GetAddNormal_FFFHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddNormal (float p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addTexCoord", "(Lde/javagl/obj/FloatTuple;)V", "GetAddTexCoord_Lde_javagl_obj_FloatTuple_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddTexCoord (global::JavaGl.Obj.IFloatTuple p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("addTexCoord", "(F)V", "GetAddTexCoord_FHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddTexCoord (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addTexCoord' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("addTexCoord", "(FF)V", "GetAddTexCoord_FFHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddTexCoord (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addTexCoord' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addTexCoord", "(FFF)V", "GetAddTexCoord_FFFHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddTexCoord (float p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addVertex' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addVertex", "(Lde/javagl/obj/FloatTuple;)V", "GetAddVertex_Lde_javagl_obj_FloatTuple_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddVertex (global::JavaGl.Obj.IFloatTuple p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='addVertex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addVertex", "(FFF)V", "GetAddVertex_FFFHandler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void AddVertex (float p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='setActiveGroupNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setActiveGroupNames", "(Ljava/util/Collection;)V", "GetSetActiveGroupNames_Ljava_util_Collection_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void SetActiveGroupNames (global::System.Collections.Generic.ICollection<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='setActiveMaterialGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActiveMaterialGroupName", "(Ljava/lang/String;)V", "GetSetActiveMaterialGroupName_Ljava_lang_String_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void SetActiveMaterialGroupName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='WritableObj']/method[@name='setMtlFileNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setMtlFileNames", "(Ljava/util/Collection;)V", "GetSetMtlFileNames_Ljava_util_Collection_Handler:JavaGl.Obj.IWritableObjInvoker, JavaGL")]
		void SetMtlFileNames (global::System.Collections.Generic.ICollection<string> p0);

	}

	[global::Android.Runtime.Register ("de/javagl/obj/WritableObj", DoNotGenerateAcw=true)]
	internal class IWritableObjInvoker : global::Java.Lang.Object, IWritableObj {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/WritableObj");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWritableObjInvoker); }
		}

		IntPtr class_ref;

		public static IWritableObj GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWritableObj> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.WritableObj"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWritableObjInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addFace_Lde_javagl_obj_ObjFace_;
#pragma warning disable 0169
		static Delegate GetAddFace_Lde_javagl_obj_ObjFace_Handler ()
		{
			if (cb_addFace_Lde_javagl_obj_ObjFace_ == null)
				cb_addFace_Lde_javagl_obj_ObjFace_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFace_Lde_javagl_obj_ObjFace_);
			return cb_addFace_Lde_javagl_obj_ObjFace_;
		}

		static void n_AddFace_Lde_javagl_obj_ObjFace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IObjFace p0 = (global::JavaGl.Obj.IObjFace)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddFace (p0);
		}
#pragma warning restore 0169

		IntPtr id_addFace_Lde_javagl_obj_ObjFace_;
		public unsafe void AddFace (global::JavaGl.Obj.IObjFace p0)
		{
			if (id_addFace_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_addFace_Lde_javagl_obj_ObjFace_ = JNIEnv.GetMethodID (class_ref, "addFace", "(Lde/javagl/obj/ObjFace;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_Lde_javagl_obj_ObjFace_, __args);
		}

		static Delegate cb_addFace_arrayI;
#pragma warning disable 0169
		static Delegate GetAddFace_arrayIHandler ()
		{
			if (cb_addFace_arrayI == null)
				cb_addFace_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFace_arrayI);
			return cb_addFace_arrayI;
		}

		static void n_AddFace_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddFace (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_addFace_arrayI;
		public unsafe void AddFace (params  int[] p0)
		{
			if (id_addFace_arrayI == IntPtr.Zero)
				id_addFace_arrayI = JNIEnv.GetMethodID (class_ref, "addFace", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addFace_arrayIarrayIarrayI;
#pragma warning disable 0169
		static Delegate GetAddFace_arrayIarrayIarrayIHandler ()
		{
			if (cb_addFace_arrayIarrayIarrayI == null)
				cb_addFace_arrayIarrayIarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFace_arrayIarrayIarrayI);
			return cb_addFace_arrayIarrayIarrayI;
		}

		static void n_AddFace_arrayIarrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddFace (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_addFace_arrayIarrayIarrayI;
		public unsafe void AddFace (int[] p0, int[] p1, int[] p2)
		{
			if (id_addFace_arrayIarrayIarrayI == IntPtr.Zero)
				id_addFace_arrayIarrayIarrayI = JNIEnv.GetMethodID (class_ref, "addFace", "([I[I[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_arrayIarrayIarrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addFaceWithAll_arrayI;
#pragma warning disable 0169
		static Delegate GetAddFaceWithAll_arrayIHandler ()
		{
			if (cb_addFaceWithAll_arrayI == null)
				cb_addFaceWithAll_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFaceWithAll_arrayI);
			return cb_addFaceWithAll_arrayI;
		}

		static void n_AddFaceWithAll_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddFaceWithAll (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_addFaceWithAll_arrayI;
		public unsafe void AddFaceWithAll (params  int[] p0)
		{
			if (id_addFaceWithAll_arrayI == IntPtr.Zero)
				id_addFaceWithAll_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithAll", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithAll_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addFaceWithNormals_arrayI;
#pragma warning disable 0169
		static Delegate GetAddFaceWithNormals_arrayIHandler ()
		{
			if (cb_addFaceWithNormals_arrayI == null)
				cb_addFaceWithNormals_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFaceWithNormals_arrayI);
			return cb_addFaceWithNormals_arrayI;
		}

		static void n_AddFaceWithNormals_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddFaceWithNormals (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_addFaceWithNormals_arrayI;
		public unsafe void AddFaceWithNormals (params  int[] p0)
		{
			if (id_addFaceWithNormals_arrayI == IntPtr.Zero)
				id_addFaceWithNormals_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithNormals", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithNormals_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addFaceWithTexCoords_arrayI;
#pragma warning disable 0169
		static Delegate GetAddFaceWithTexCoords_arrayIHandler ()
		{
			if (cb_addFaceWithTexCoords_arrayI == null)
				cb_addFaceWithTexCoords_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFaceWithTexCoords_arrayI);
			return cb_addFaceWithTexCoords_arrayI;
		}

		static void n_AddFaceWithTexCoords_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AddFaceWithTexCoords (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_addFaceWithTexCoords_arrayI;
		public unsafe void AddFaceWithTexCoords (params  int[] p0)
		{
			if (id_addFaceWithTexCoords_arrayI == IntPtr.Zero)
				id_addFaceWithTexCoords_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithTexCoords", "([I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithTexCoords_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addNormal_Lde_javagl_obj_FloatTuple_;
#pragma warning disable 0169
		static Delegate GetAddNormal_Lde_javagl_obj_FloatTuple_Handler ()
		{
			if (cb_addNormal_Lde_javagl_obj_FloatTuple_ == null)
				cb_addNormal_Lde_javagl_obj_FloatTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddNormal_Lde_javagl_obj_FloatTuple_);
			return cb_addNormal_Lde_javagl_obj_FloatTuple_;
		}

		static void n_AddNormal_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple p0 = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddNormal (p0);
		}
#pragma warning restore 0169

		IntPtr id_addNormal_Lde_javagl_obj_FloatTuple_;
		public unsafe void AddNormal (global::JavaGl.Obj.IFloatTuple p0)
		{
			if (id_addNormal_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addNormal_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addNormal", "(Lde/javagl/obj/FloatTuple;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNormal_Lde_javagl_obj_FloatTuple_, __args);
		}

		static Delegate cb_addNormal_FFF;
#pragma warning disable 0169
		static Delegate GetAddNormal_FFFHandler ()
		{
			if (cb_addNormal_FFF == null)
				cb_addNormal_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_AddNormal_FFF);
			return cb_addNormal_FFF;
		}

		static void n_AddNormal_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddNormal (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addNormal_FFF;
		public unsafe void AddNormal (float p0, float p1, float p2)
		{
			if (id_addNormal_FFF == IntPtr.Zero)
				id_addNormal_FFF = JNIEnv.GetMethodID (class_ref, "addNormal", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNormal_FFF, __args);
		}

		static Delegate cb_addTexCoord_Lde_javagl_obj_FloatTuple_;
#pragma warning disable 0169
		static Delegate GetAddTexCoord_Lde_javagl_obj_FloatTuple_Handler ()
		{
			if (cb_addTexCoord_Lde_javagl_obj_FloatTuple_ == null)
				cb_addTexCoord_Lde_javagl_obj_FloatTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTexCoord_Lde_javagl_obj_FloatTuple_);
			return cb_addTexCoord_Lde_javagl_obj_FloatTuple_;
		}

		static void n_AddTexCoord_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple p0 = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddTexCoord (p0);
		}
#pragma warning restore 0169

		IntPtr id_addTexCoord_Lde_javagl_obj_FloatTuple_;
		public unsafe void AddTexCoord (global::JavaGl.Obj.IFloatTuple p0)
		{
			if (id_addTexCoord_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addTexCoord_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(Lde/javagl/obj/FloatTuple;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_Lde_javagl_obj_FloatTuple_, __args);
		}

		static Delegate cb_addTexCoord_F;
#pragma warning disable 0169
		static Delegate GetAddTexCoord_FHandler ()
		{
			if (cb_addTexCoord_F == null)
				cb_addTexCoord_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_AddTexCoord_F);
			return cb_addTexCoord_F;
		}

		static void n_AddTexCoord_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddTexCoord (p0);
		}
#pragma warning restore 0169

		IntPtr id_addTexCoord_F;
		public unsafe void AddTexCoord (float p0)
		{
			if (id_addTexCoord_F == IntPtr.Zero)
				id_addTexCoord_F = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_F, __args);
		}

		static Delegate cb_addTexCoord_FF;
#pragma warning disable 0169
		static Delegate GetAddTexCoord_FFHandler ()
		{
			if (cb_addTexCoord_FF == null)
				cb_addTexCoord_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_AddTexCoord_FF);
			return cb_addTexCoord_FF;
		}

		static void n_AddTexCoord_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddTexCoord (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_addTexCoord_FF;
		public unsafe void AddTexCoord (float p0, float p1)
		{
			if (id_addTexCoord_FF == IntPtr.Zero)
				id_addTexCoord_FF = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_FF, __args);
		}

		static Delegate cb_addTexCoord_FFF;
#pragma warning disable 0169
		static Delegate GetAddTexCoord_FFFHandler ()
		{
			if (cb_addTexCoord_FFF == null)
				cb_addTexCoord_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_AddTexCoord_FFF);
			return cb_addTexCoord_FFF;
		}

		static void n_AddTexCoord_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddTexCoord (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addTexCoord_FFF;
		public unsafe void AddTexCoord (float p0, float p1, float p2)
		{
			if (id_addTexCoord_FFF == IntPtr.Zero)
				id_addTexCoord_FFF = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_FFF, __args);
		}

		static Delegate cb_addVertex_Lde_javagl_obj_FloatTuple_;
#pragma warning disable 0169
		static Delegate GetAddVertex_Lde_javagl_obj_FloatTuple_Handler ()
		{
			if (cb_addVertex_Lde_javagl_obj_FloatTuple_ == null)
				cb_addVertex_Lde_javagl_obj_FloatTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddVertex_Lde_javagl_obj_FloatTuple_);
			return cb_addVertex_Lde_javagl_obj_FloatTuple_;
		}

		static void n_AddVertex_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple p0 = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddVertex (p0);
		}
#pragma warning restore 0169

		IntPtr id_addVertex_Lde_javagl_obj_FloatTuple_;
		public unsafe void AddVertex (global::JavaGl.Obj.IFloatTuple p0)
		{
			if (id_addVertex_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addVertex_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addVertex", "(Lde/javagl/obj/FloatTuple;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVertex_Lde_javagl_obj_FloatTuple_, __args);
		}

		static Delegate cb_addVertex_FFF;
#pragma warning disable 0169
		static Delegate GetAddVertex_FFFHandler ()
		{
			if (cb_addVertex_FFF == null)
				cb_addVertex_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_AddVertex_FFF);
			return cb_addVertex_FFF;
		}

		static void n_AddVertex_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddVertex (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addVertex_FFF;
		public unsafe void AddVertex (float p0, float p1, float p2)
		{
			if (id_addVertex_FFF == IntPtr.Zero)
				id_addVertex_FFF = JNIEnv.GetMethodID (class_ref, "addVertex", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVertex_FFF, __args);
		}

		static Delegate cb_setActiveGroupNames_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetActiveGroupNames_Ljava_util_Collection_Handler ()
		{
			if (cb_setActiveGroupNames_Ljava_util_Collection_ == null)
				cb_setActiveGroupNames_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActiveGroupNames_Ljava_util_Collection_);
			return cb_setActiveGroupNames_Ljava_util_Collection_;
		}

		static void n_SetActiveGroupNames_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveGroupNames (p0);
		}
#pragma warning restore 0169

		IntPtr id_setActiveGroupNames_Ljava_util_Collection_;
		public unsafe void SetActiveGroupNames (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_setActiveGroupNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setActiveGroupNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setActiveGroupNames", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveGroupNames_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setActiveMaterialGroupName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActiveMaterialGroupName_Ljava_lang_String_Handler ()
		{
			if (cb_setActiveMaterialGroupName_Ljava_lang_String_ == null)
				cb_setActiveMaterialGroupName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActiveMaterialGroupName_Ljava_lang_String_);
			return cb_setActiveMaterialGroupName_Ljava_lang_String_;
		}

		static void n_SetActiveMaterialGroupName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveMaterialGroupName (p0);
		}
#pragma warning restore 0169

		IntPtr id_setActiveMaterialGroupName_Ljava_lang_String_;
		public unsafe void SetActiveMaterialGroupName (string p0)
		{
			if (id_setActiveMaterialGroupName_Ljava_lang_String_ == IntPtr.Zero)
				id_setActiveMaterialGroupName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActiveMaterialGroupName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveMaterialGroupName_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setMtlFileNames_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetMtlFileNames_Ljava_util_Collection_Handler ()
		{
			if (cb_setMtlFileNames_Ljava_util_Collection_ == null)
				cb_setMtlFileNames_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMtlFileNames_Ljava_util_Collection_);
			return cb_setMtlFileNames_Ljava_util_Collection_;
		}

		static void n_SetMtlFileNames_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMtlFileNames (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMtlFileNames_Ljava_util_Collection_;
		public unsafe void SetMtlFileNames (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_setMtlFileNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setMtlFileNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setMtlFileNames", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMtlFileNames_Ljava_util_Collection_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
