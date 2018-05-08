using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']"
	[global::Android.Runtime.Register ("de/javagl/obj/AbstractWritableObj", DoNotGenerateAcw=true)]
	public partial class AbstractWritableObj : global::Java.Lang.Object, global::JavaGl.Obj.IWritableObj {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/AbstractWritableObj", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractWritableObj); }
		}

		protected AbstractWritableObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/constructor[@name='AbstractWritableObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe AbstractWritableObj ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractWritableObj)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_addFace_Lde_javagl_obj_ObjFace_;
#pragma warning disable 0169
		static Delegate GetAddFace_Lde_javagl_obj_ObjFace_Handler ()
		{
			if (cb_addFace_Lde_javagl_obj_ObjFace_ == null)
				cb_addFace_Lde_javagl_obj_ObjFace_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFace_Lde_javagl_obj_ObjFace_);
			return cb_addFace_Lde_javagl_obj_ObjFace_;
		}

		static void n_AddFace_Lde_javagl_obj_ObjFace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_face)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IObjFace face = (global::JavaGl.Obj.IObjFace)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (native_face, JniHandleOwnership.DoNotTransfer);
			__this.AddFace (face);
		}
#pragma warning restore 0169

		static IntPtr id_addFace_Lde_javagl_obj_ObjFace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("addFace", "(Lde/javagl/obj/ObjFace;)V", "GetAddFace_Lde_javagl_obj_ObjFace_Handler")]
		public virtual unsafe void AddFace (global::JavaGl.Obj.IObjFace face)
		{
			if (id_addFace_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_addFace_Lde_javagl_obj_ObjFace_ = JNIEnv.GetMethodID (class_ref, "addFace", "(Lde/javagl/obj/ObjFace;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (face);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_Lde_javagl_obj_ObjFace_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFace", "(Lde/javagl/obj/ObjFace;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_addFace_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFace", "([I)V", "")]
		public unsafe void AddFace (params  int[] v)
		{
			if (id_addFace_arrayI == IntPtr.Zero)
				id_addFace_arrayI = JNIEnv.GetMethodID (class_ref, "addFace", "([I)V");
			IntPtr native_v = JNIEnv.NewArray (v);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_v);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_arrayI, __args);
			} finally {
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
			}
		}

		static IntPtr id_addFace_arrayIarrayIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFace' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register ("addFace", "([I[I[I)V", "")]
		public unsafe void AddFace (int[] v, int[] vt, int[] vn)
		{
			if (id_addFace_arrayIarrayIarrayI == IntPtr.Zero)
				id_addFace_arrayIarrayIarrayI = JNIEnv.GetMethodID (class_ref, "addFace", "([I[I[I)V");
			IntPtr native_v = JNIEnv.NewArray (v);
			IntPtr native_vt = JNIEnv.NewArray (vt);
			IntPtr native_vn = JNIEnv.NewArray (vn);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_v);
				__args [1] = new JValue (native_vt);
				__args [2] = new JValue (native_vn);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_arrayIarrayIarrayI, __args);
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

		static IntPtr id_addFaceWithAll_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFaceWithAll' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithAll", "([I)V", "")]
		public unsafe void AddFaceWithAll (params  int[] v)
		{
			if (id_addFaceWithAll_arrayI == IntPtr.Zero)
				id_addFaceWithAll_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithAll", "([I)V");
			IntPtr native_v = JNIEnv.NewArray (v);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_v);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithAll_arrayI, __args);
			} finally {
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
			}
		}

		static IntPtr id_addFaceWithNormals_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFaceWithNormals' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithNormals", "([I)V", "")]
		public unsafe void AddFaceWithNormals (params  int[] v)
		{
			if (id_addFaceWithNormals_arrayI == IntPtr.Zero)
				id_addFaceWithNormals_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithNormals", "([I)V");
			IntPtr native_v = JNIEnv.NewArray (v);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_v);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithNormals_arrayI, __args);
			} finally {
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
			}
		}

		static IntPtr id_addFaceWithTexCoords_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addFaceWithTexCoords' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("addFaceWithTexCoords", "([I)V", "")]
		public unsafe void AddFaceWithTexCoords (params  int[] v)
		{
			if (id_addFaceWithTexCoords_arrayI == IntPtr.Zero)
				id_addFaceWithTexCoords_arrayI = JNIEnv.GetMethodID (class_ref, "addFaceWithTexCoords", "([I)V");
			IntPtr native_v = JNIEnv.NewArray (v);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_v);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFaceWithTexCoords_arrayI, __args);
			} finally {
				if (v != null) {
					JNIEnv.CopyArray (native_v, v);
					JNIEnv.DeleteLocalRef (native_v);
				}
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

		static void n_AddNormal_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normal)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple normal = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_normal, JniHandleOwnership.DoNotTransfer);
			__this.AddNormal (normal);
		}
#pragma warning restore 0169

		static IntPtr id_addNormal_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addNormal' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addNormal", "(Lde/javagl/obj/FloatTuple;)V", "GetAddNormal_Lde_javagl_obj_FloatTuple_Handler")]
		public virtual unsafe void AddNormal (global::JavaGl.Obj.IFloatTuple normal)
		{
			if (id_addNormal_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addNormal_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addNormal", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (normal);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNormal_Lde_javagl_obj_FloatTuple_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addNormal", "(Lde/javagl/obj/FloatTuple;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_addNormal_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addNormal' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addNormal", "(FFF)V", "")]
		public unsafe void AddNormal (float x, float y, float z)
		{
			if (id_addNormal_FFF == IntPtr.Zero)
				id_addNormal_FFF = JNIEnv.GetMethodID (class_ref, "addNormal", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNormal_FFF, __args);
			} finally {
			}
		}

		static Delegate cb_addTexCoord_Lde_javagl_obj_FloatTuple_;
#pragma warning disable 0169
		static Delegate GetAddTexCoord_Lde_javagl_obj_FloatTuple_Handler ()
		{
			if (cb_addTexCoord_Lde_javagl_obj_FloatTuple_ == null)
				cb_addTexCoord_Lde_javagl_obj_FloatTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddTexCoord_Lde_javagl_obj_FloatTuple_);
			return cb_addTexCoord_Lde_javagl_obj_FloatTuple_;
		}

		static void n_AddTexCoord_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_texCoord)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple texCoord = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_texCoord, JniHandleOwnership.DoNotTransfer);
			__this.AddTexCoord (texCoord);
		}
#pragma warning restore 0169

		static IntPtr id_addTexCoord_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addTexCoord", "(Lde/javagl/obj/FloatTuple;)V", "GetAddTexCoord_Lde_javagl_obj_FloatTuple_Handler")]
		public virtual unsafe void AddTexCoord (global::JavaGl.Obj.IFloatTuple texCoord)
		{
			if (id_addTexCoord_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addTexCoord_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (texCoord);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_Lde_javagl_obj_FloatTuple_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTexCoord", "(Lde/javagl/obj/FloatTuple;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_addTexCoord_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("addTexCoord", "(F)V", "")]
		public unsafe void AddTexCoord (float x)
		{
			if (id_addTexCoord_F == IntPtr.Zero)
				id_addTexCoord_F = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (x);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_F, __args);
			} finally {
			}
		}

		static IntPtr id_addTexCoord_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addTexCoord' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("addTexCoord", "(FF)V", "")]
		public unsafe void AddTexCoord (float x, float y)
		{
			if (id_addTexCoord_FF == IntPtr.Zero)
				id_addTexCoord_FF = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_FF, __args);
			} finally {
			}
		}

		static IntPtr id_addTexCoord_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addTexCoord' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addTexCoord", "(FFF)V", "")]
		public unsafe void AddTexCoord (float x, float y, float z)
		{
			if (id_addTexCoord_FFF == IntPtr.Zero)
				id_addTexCoord_FFF = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_FFF, __args);
			} finally {
			}
		}

		static Delegate cb_addVertex_Lde_javagl_obj_FloatTuple_;
#pragma warning disable 0169
		static Delegate GetAddVertex_Lde_javagl_obj_FloatTuple_Handler ()
		{
			if (cb_addVertex_Lde_javagl_obj_FloatTuple_ == null)
				cb_addVertex_Lde_javagl_obj_FloatTuple_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddVertex_Lde_javagl_obj_FloatTuple_);
			return cb_addVertex_Lde_javagl_obj_FloatTuple_;
		}

		static void n_AddVertex_Lde_javagl_obj_FloatTuple_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vertex)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IFloatTuple vertex = (global::JavaGl.Obj.IFloatTuple)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (native_vertex, JniHandleOwnership.DoNotTransfer);
			__this.AddVertex (vertex);
		}
#pragma warning restore 0169

		static IntPtr id_addVertex_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addVertex' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addVertex", "(Lde/javagl/obj/FloatTuple;)V", "GetAddVertex_Lde_javagl_obj_FloatTuple_Handler")]
		public virtual unsafe void AddVertex (global::JavaGl.Obj.IFloatTuple vertex)
		{
			if (id_addVertex_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addVertex_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addVertex", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vertex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVertex_Lde_javagl_obj_FloatTuple_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addVertex", "(Lde/javagl/obj/FloatTuple;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_addVertex_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='addVertex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("addVertex", "(FFF)V", "")]
		public unsafe void AddVertex (float x, float y, float z)
		{
			if (id_addVertex_FFF == IntPtr.Zero)
				id_addVertex_FFF = JNIEnv.GetMethodID (class_ref, "addVertex", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVertex_FFF, __args);
			} finally {
			}
		}

		static Delegate cb_setActiveGroupNames_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetActiveGroupNames_Ljava_util_Collection_Handler ()
		{
			if (cb_setActiveGroupNames_Ljava_util_Collection_ == null)
				cb_setActiveGroupNames_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActiveGroupNames_Ljava_util_Collection_);
			return cb_setActiveGroupNames_Ljava_util_Collection_;
		}

		static void n_SetActiveGroupNames_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupNames)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var groupNames = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_groupNames, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveGroupNames (groupNames);
		}
#pragma warning restore 0169

		static IntPtr id_setActiveGroupNames_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='setActiveGroupNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setActiveGroupNames", "(Ljava/util/Collection;)V", "GetSetActiveGroupNames_Ljava_util_Collection_Handler")]
		public virtual unsafe void SetActiveGroupNames (global::System.Collections.Generic.ICollection<string> groupNames)
		{
			if (id_setActiveGroupNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setActiveGroupNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setActiveGroupNames", "(Ljava/util/Collection;)V");
			IntPtr native_groupNames = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (groupNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_groupNames);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveGroupNames_Ljava_util_Collection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveGroupNames", "(Ljava/util/Collection;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_groupNames);
			}
		}

		static Delegate cb_setActiveMaterialGroupName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActiveMaterialGroupName_Ljava_lang_String_Handler ()
		{
			if (cb_setActiveMaterialGroupName_Ljava_lang_String_ == null)
				cb_setActiveMaterialGroupName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActiveMaterialGroupName_Ljava_lang_String_);
			return cb_setActiveMaterialGroupName_Ljava_lang_String_;
		}

		static void n_SetActiveMaterialGroupName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_materialGroupName)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string materialGroupName = JNIEnv.GetString (native_materialGroupName, JniHandleOwnership.DoNotTransfer);
			__this.SetActiveMaterialGroupName (materialGroupName);
		}
#pragma warning restore 0169

		static IntPtr id_setActiveMaterialGroupName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='setActiveMaterialGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActiveMaterialGroupName", "(Ljava/lang/String;)V", "GetSetActiveMaterialGroupName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetActiveMaterialGroupName (string materialGroupName)
		{
			if (id_setActiveMaterialGroupName_Ljava_lang_String_ == IntPtr.Zero)
				id_setActiveMaterialGroupName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActiveMaterialGroupName", "(Ljava/lang/String;)V");
			IntPtr native_materialGroupName = JNIEnv.NewString (materialGroupName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_materialGroupName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveMaterialGroupName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActiveMaterialGroupName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_materialGroupName);
			}
		}

		static Delegate cb_setMtlFileNames_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetSetMtlFileNames_Ljava_util_Collection_Handler ()
		{
			if (cb_setMtlFileNames_Ljava_util_Collection_ == null)
				cb_setMtlFileNames_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMtlFileNames_Ljava_util_Collection_);
			return cb_setMtlFileNames_Ljava_util_Collection_;
		}

		static void n_SetMtlFileNames_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mtlFileNames)
		{
			global::JavaGl.Obj.AbstractWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.AbstractWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mtlFileNames = global::Android.Runtime.JavaCollection<string>.FromJniHandle (native_mtlFileNames, JniHandleOwnership.DoNotTransfer);
			__this.SetMtlFileNames (mtlFileNames);
		}
#pragma warning restore 0169

		static IntPtr id_setMtlFileNames_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='AbstractWritableObj']/method[@name='setMtlFileNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setMtlFileNames", "(Ljava/util/Collection;)V", "GetSetMtlFileNames_Ljava_util_Collection_Handler")]
		public virtual unsafe void SetMtlFileNames (global::System.Collections.Generic.ICollection<string> mtlFileNames)
		{
			if (id_setMtlFileNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setMtlFileNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setMtlFileNames", "(Ljava/util/Collection;)V");
			IntPtr native_mtlFileNames = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (mtlFileNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mtlFileNames);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMtlFileNames_Ljava_util_Collection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMtlFileNames", "(Ljava/util/Collection;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mtlFileNames);
			}
		}

	}
}
