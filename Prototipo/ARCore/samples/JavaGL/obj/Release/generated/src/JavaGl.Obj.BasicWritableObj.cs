using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']"
	[global::Android.Runtime.Register ("de/javagl/obj/BasicWritableObj", DoNotGenerateAcw=true)]
	public partial class BasicWritableObj : global::Java.Lang.Object, global::JavaGl.Obj.IWritableObj {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("de/javagl/obj/BasicWritableObj", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicWritableObj); }
		}

		protected BasicWritableObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/constructor[@name='BasicWritableObj' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasicWritableObj ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BasicWritableObj)) {
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

		static IntPtr id_addFace_Lde_javagl_obj_ObjFace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("addFace", "(Lde/javagl/obj/ObjFace;)V", "")]
		public unsafe void AddFace (global::JavaGl.Obj.IObjFace face)
		{
			if (id_addFace_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_addFace_Lde_javagl_obj_ObjFace_ = JNIEnv.GetMethodID (class_ref, "addFace", "(Lde/javagl/obj/ObjFace;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (face);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFace_Lde_javagl_obj_ObjFace_, __args);
			} finally {
			}
		}

		static IntPtr id_addFace_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFace' and count(parameter)=1 and parameter[1][@type='int...']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFace' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFaceWithAll' and count(parameter)=1 and parameter[1][@type='int...']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFaceWithNormals' and count(parameter)=1 and parameter[1][@type='int...']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addFaceWithTexCoords' and count(parameter)=1 and parameter[1][@type='int...']]"
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

		static IntPtr id_addNormal_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addNormal' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addNormal", "(Lde/javagl/obj/FloatTuple;)V", "")]
		public unsafe void AddNormal (global::JavaGl.Obj.IFloatTuple normal)
		{
			if (id_addNormal_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addNormal_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addNormal", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (normal);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addNormal_Lde_javagl_obj_FloatTuple_, __args);
			} finally {
			}
		}

		static IntPtr id_addNormal_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addNormal' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

		static IntPtr id_addTexCoord_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addTexCoord", "(Lde/javagl/obj/FloatTuple;)V", "")]
		public unsafe void AddTexCoord (global::JavaGl.Obj.IFloatTuple texCoord)
		{
			if (id_addTexCoord_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addTexCoord_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addTexCoord", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (texCoord);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addTexCoord_Lde_javagl_obj_FloatTuple_, __args);
			} finally {
			}
		}

		static IntPtr id_addTexCoord_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addTexCoord' and count(parameter)=1 and parameter[1][@type='float']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addTexCoord' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addTexCoord' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

		static IntPtr id_addVertex_Lde_javagl_obj_FloatTuple_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addVertex' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.FloatTuple']]"
		[Register ("addVertex", "(Lde/javagl/obj/FloatTuple;)V", "")]
		public unsafe void AddVertex (global::JavaGl.Obj.IFloatTuple vertex)
		{
			if (id_addVertex_Lde_javagl_obj_FloatTuple_ == IntPtr.Zero)
				id_addVertex_Lde_javagl_obj_FloatTuple_ = JNIEnv.GetMethodID (class_ref, "addVertex", "(Lde/javagl/obj/FloatTuple;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vertex);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addVertex_Lde_javagl_obj_FloatTuple_, __args);
			} finally {
			}
		}

		static IntPtr id_addVertex_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='addVertex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

		static IntPtr id_setActiveGroupNames_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setActiveGroupNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setActiveGroupNames", "(Ljava/util/Collection;)V", "")]
		public unsafe void SetActiveGroupNames (global::System.Collections.Generic.ICollection<string> groupNames)
		{
			if (id_setActiveGroupNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setActiveGroupNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setActiveGroupNames", "(Ljava/util/Collection;)V");
			IntPtr native_groupNames = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (groupNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_groupNames);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveGroupNames_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_groupNames);
			}
		}

		static IntPtr id_setActiveMaterialGroupName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setActiveMaterialGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActiveMaterialGroupName", "(Ljava/lang/String;)V", "")]
		public unsafe void SetActiveMaterialGroupName (string materialGroupName)
		{
			if (id_setActiveMaterialGroupName_Ljava_lang_String_ == IntPtr.Zero)
				id_setActiveMaterialGroupName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActiveMaterialGroupName", "(Ljava/lang/String;)V");
			IntPtr native_materialGroupName = JNIEnv.NewString (materialGroupName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_materialGroupName);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActiveMaterialGroupName_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_materialGroupName);
			}
		}

		static Delegate cb_setFaceConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetFaceConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setFaceConsumer_Ljava_util_function_Consumer_ == null)
				cb_setFaceConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFaceConsumer_Ljava_util_function_Consumer_);
			return cb_setFaceConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetFaceConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_faceConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer faceConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_faceConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetFaceConsumer (faceConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setFaceConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setFaceConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super de.javagl.obj.ObjFace&gt;']]"
		[Register ("setFaceConsumer", "(Ljava/util/function/Consumer;)V", "GetSetFaceConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetFaceConsumer (global::Java.Util.Functions.IConsumer faceConsumer)
		{
			if (id_setFaceConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setFaceConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setFaceConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (faceConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFaceConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFaceConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGroupNamesConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetGroupNamesConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setGroupNamesConsumer_Ljava_util_function_Consumer_ == null)
				cb_setGroupNamesConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupNamesConsumer_Ljava_util_function_Consumer_);
			return cb_setGroupNamesConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetGroupNamesConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_groupNamesConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer groupNamesConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_groupNamesConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetGroupNamesConsumer (groupNamesConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setGroupNamesConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setGroupNamesConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.util.Collection&lt;? extends java.lang.String&gt;&gt;']]"
		[Register ("setGroupNamesConsumer", "(Ljava/util/function/Consumer;)V", "GetSetGroupNamesConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetGroupNamesConsumer (global::Java.Util.Functions.IConsumer groupNamesConsumer)
		{
			if (id_setGroupNamesConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setGroupNamesConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setGroupNamesConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (groupNamesConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupNamesConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupNamesConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetMaterialGroupNameConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_ == null)
				cb_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaterialGroupNameConsumer_Ljava_util_function_Consumer_);
			return cb_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetMaterialGroupNameConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_materialGroupNameConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer materialGroupNameConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_materialGroupNameConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetMaterialGroupNameConsumer (materialGroupNameConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setMaterialGroupNameConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.lang.String&gt;']]"
		[Register ("setMaterialGroupNameConsumer", "(Ljava/util/function/Consumer;)V", "GetSetMaterialGroupNameConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetMaterialGroupNameConsumer (global::Java.Util.Functions.IConsumer materialGroupNameConsumer)
		{
			if (id_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setMaterialGroupNameConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (materialGroupNameConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaterialGroupNameConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaterialGroupNameConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setMtlFileNames_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setMtlFileNames' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends java.lang.String&gt;']]"
		[Register ("setMtlFileNames", "(Ljava/util/Collection;)V", "")]
		public unsafe void SetMtlFileNames (global::System.Collections.Generic.ICollection<string> mtlFileNames)
		{
			if (id_setMtlFileNames_Ljava_util_Collection_ == IntPtr.Zero)
				id_setMtlFileNames_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "setMtlFileNames", "(Ljava/util/Collection;)V");
			IntPtr native_mtlFileNames = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (mtlFileNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_mtlFileNames);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMtlFileNames_Ljava_util_Collection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mtlFileNames);
			}
		}

		static Delegate cb_setMtlFileNamesConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetMtlFileNamesConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setMtlFileNamesConsumer_Ljava_util_function_Consumer_ == null)
				cb_setMtlFileNamesConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMtlFileNamesConsumer_Ljava_util_function_Consumer_);
			return cb_setMtlFileNamesConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetMtlFileNamesConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mtlFileNamesConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer mtlFileNamesConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_mtlFileNamesConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetMtlFileNamesConsumer (mtlFileNamesConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setMtlFileNamesConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setMtlFileNamesConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super java.util.Collection&lt;? extends java.lang.String&gt;&gt;']]"
		[Register ("setMtlFileNamesConsumer", "(Ljava/util/function/Consumer;)V", "GetSetMtlFileNamesConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetMtlFileNamesConsumer (global::Java.Util.Functions.IConsumer mtlFileNamesConsumer)
		{
			if (id_setMtlFileNamesConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setMtlFileNamesConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setMtlFileNamesConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mtlFileNamesConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMtlFileNamesConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMtlFileNamesConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNormalConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetNormalConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setNormalConsumer_Ljava_util_function_Consumer_ == null)
				cb_setNormalConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNormalConsumer_Ljava_util_function_Consumer_);
			return cb_setNormalConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetNormalConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_normalConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer normalConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_normalConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetNormalConsumer (normalConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setNormalConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setNormalConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super de.javagl.obj.FloatTuple&gt;']]"
		[Register ("setNormalConsumer", "(Ljava/util/function/Consumer;)V", "GetSetNormalConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetNormalConsumer (global::Java.Util.Functions.IConsumer normalConsumer)
		{
			if (id_setNormalConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setNormalConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setNormalConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (normalConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNormalConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNormalConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTexCoordConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetTexCoordConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setTexCoordConsumer_Ljava_util_function_Consumer_ == null)
				cb_setTexCoordConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTexCoordConsumer_Ljava_util_function_Consumer_);
			return cb_setTexCoordConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetTexCoordConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_texCoordConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer texCoordConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_texCoordConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetTexCoordConsumer (texCoordConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setTexCoordConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setTexCoordConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super de.javagl.obj.FloatTuple&gt;']]"
		[Register ("setTexCoordConsumer", "(Ljava/util/function/Consumer;)V", "GetSetTexCoordConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetTexCoordConsumer (global::Java.Util.Functions.IConsumer texCoordConsumer)
		{
			if (id_setTexCoordConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setTexCoordConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setTexCoordConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (texCoordConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexCoordConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexCoordConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVertexConsumer_Ljava_util_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetSetVertexConsumer_Ljava_util_function_Consumer_Handler ()
		{
			if (cb_setVertexConsumer_Ljava_util_function_Consumer_ == null)
				cb_setVertexConsumer_Ljava_util_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVertexConsumer_Ljava_util_function_Consumer_);
			return cb_setVertexConsumer_Ljava_util_function_Consumer_;
		}

		static void n_SetVertexConsumer_Ljava_util_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vertexConsumer)
		{
			global::JavaGl.Obj.BasicWritableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.BasicWritableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Functions.IConsumer vertexConsumer = (global::Java.Util.Functions.IConsumer)global::Java.Lang.Object.GetObject<global::Java.Util.Functions.IConsumer> (native_vertexConsumer, JniHandleOwnership.DoNotTransfer);
			__this.SetVertexConsumer (vertexConsumer);
		}
#pragma warning restore 0169

		static IntPtr id_setVertexConsumer_Ljava_util_function_Consumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/class[@name='BasicWritableObj']/method[@name='setVertexConsumer' and count(parameter)=1 and parameter[1][@type='java.util.function.Consumer&lt;? super de.javagl.obj.FloatTuple&gt;']]"
		[Register ("setVertexConsumer", "(Ljava/util/function/Consumer;)V", "GetSetVertexConsumer_Ljava_util_function_Consumer_Handler")]
		public virtual unsafe void SetVertexConsumer (global::Java.Util.Functions.IConsumer vertexConsumer)
		{
			if (id_setVertexConsumer_Ljava_util_function_Consumer_ == IntPtr.Zero)
				id_setVertexConsumer_Ljava_util_function_Consumer_ = JNIEnv.GetMethodID (class_ref, "setVertexConsumer", "(Ljava/util/function/Consumer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vertexConsumer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVertexConsumer_Ljava_util_function_Consumer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVertexConsumer", "(Ljava/util/function/Consumer;)V"), __args);
			} finally {
			}
		}

	}
}
