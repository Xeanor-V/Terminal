using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Obj']"
	[Register ("de/javagl/obj/Obj", "", "JavaGl.Obj.IObjInvoker")]
	public partial interface IObj : global::JavaGl.Obj.IReadableObj, global::JavaGl.Obj.IWritableObj {

	}

	[global::Android.Runtime.Register ("de/javagl/obj/Obj", DoNotGenerateAcw=true)]
	internal class IObjInvoker : global::Java.Lang.Object, IObj {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/Obj");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObjInvoker); }
		}

		IntPtr class_ref;

		public static IObj GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObj> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.Obj"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMtlFileNames;
#pragma warning disable 0169
		static Delegate GetGetMtlFileNamesHandler ()
		{
			if (cb_getMtlFileNames == null)
				cb_getMtlFileNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMtlFileNames);
			return cb_getMtlFileNames;
		}

		static IntPtr n_GetMtlFileNames (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.MtlFileNames);
		}
#pragma warning restore 0169

		IntPtr id_getMtlFileNames;
		public unsafe global::System.Collections.Generic.IList<string> MtlFileNames {
			get {
				if (id_getMtlFileNames == IntPtr.Zero)
					id_getMtlFileNames = JNIEnv.GetMethodID (class_ref, "getMtlFileNames", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMtlFileNames), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNumFaces;
#pragma warning disable 0169
		static Delegate GetGetNumFacesHandler ()
		{
			if (cb_getNumFaces == null)
				cb_getNumFaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumFaces);
			return cb_getNumFaces;
		}

		static int n_GetNumFaces (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumFaces;
		}
#pragma warning restore 0169

		IntPtr id_getNumFaces;
		public unsafe int NumFaces {
			get {
				if (id_getNumFaces == IntPtr.Zero)
					id_getNumFaces = JNIEnv.GetMethodID (class_ref, "getNumFaces", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumFaces);
			}
		}

		static Delegate cb_getNumGroups;
#pragma warning disable 0169
		static Delegate GetGetNumGroupsHandler ()
		{
			if (cb_getNumGroups == null)
				cb_getNumGroups = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumGroups);
			return cb_getNumGroups;
		}

		static int n_GetNumGroups (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumGroups;
		}
#pragma warning restore 0169

		IntPtr id_getNumGroups;
		public unsafe int NumGroups {
			get {
				if (id_getNumGroups == IntPtr.Zero)
					id_getNumGroups = JNIEnv.GetMethodID (class_ref, "getNumGroups", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumGroups);
			}
		}

		static Delegate cb_getNumMaterialGroups;
#pragma warning disable 0169
		static Delegate GetGetNumMaterialGroupsHandler ()
		{
			if (cb_getNumMaterialGroups == null)
				cb_getNumMaterialGroups = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumMaterialGroups);
			return cb_getNumMaterialGroups;
		}

		static int n_GetNumMaterialGroups (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumMaterialGroups;
		}
#pragma warning restore 0169

		IntPtr id_getNumMaterialGroups;
		public unsafe int NumMaterialGroups {
			get {
				if (id_getNumMaterialGroups == IntPtr.Zero)
					id_getNumMaterialGroups = JNIEnv.GetMethodID (class_ref, "getNumMaterialGroups", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumMaterialGroups);
			}
		}

		static Delegate cb_getNumNormals;
#pragma warning disable 0169
		static Delegate GetGetNumNormalsHandler ()
		{
			if (cb_getNumNormals == null)
				cb_getNumNormals = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumNormals);
			return cb_getNumNormals;
		}

		static int n_GetNumNormals (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumNormals;
		}
#pragma warning restore 0169

		IntPtr id_getNumNormals;
		public unsafe int NumNormals {
			get {
				if (id_getNumNormals == IntPtr.Zero)
					id_getNumNormals = JNIEnv.GetMethodID (class_ref, "getNumNormals", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumNormals);
			}
		}

		static Delegate cb_getNumTexCoords;
#pragma warning disable 0169
		static Delegate GetGetNumTexCoordsHandler ()
		{
			if (cb_getNumTexCoords == null)
				cb_getNumTexCoords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumTexCoords);
			return cb_getNumTexCoords;
		}

		static int n_GetNumTexCoords (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumTexCoords;
		}
#pragma warning restore 0169

		IntPtr id_getNumTexCoords;
		public unsafe int NumTexCoords {
			get {
				if (id_getNumTexCoords == IntPtr.Zero)
					id_getNumTexCoords = JNIEnv.GetMethodID (class_ref, "getNumTexCoords", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumTexCoords);
			}
		}

		static Delegate cb_getNumVertices;
#pragma warning disable 0169
		static Delegate GetGetNumVerticesHandler ()
		{
			if (cb_getNumVertices == null)
				cb_getNumVertices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumVertices);
			return cb_getNumVertices;
		}

		static int n_GetNumVertices (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumVertices;
		}
#pragma warning restore 0169

		IntPtr id_getNumVertices;
		public unsafe int NumVertices {
			get {
				if (id_getNumVertices == IntPtr.Zero)
					id_getNumVertices = JNIEnv.GetMethodID (class_ref, "getNumVertices", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumVertices);
			}
		}

		static Delegate cb_getActivatedGroupNames_Lde_javagl_obj_ObjFace_;
#pragma warning disable 0169
		static Delegate GetGetActivatedGroupNames_Lde_javagl_obj_ObjFace_Handler ()
		{
			if (cb_getActivatedGroupNames_Lde_javagl_obj_ObjFace_ == null)
				cb_getActivatedGroupNames_Lde_javagl_obj_ObjFace_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActivatedGroupNames_Lde_javagl_obj_ObjFace_);
			return cb_getActivatedGroupNames_Lde_javagl_obj_ObjFace_;
		}

		static IntPtr n_GetActivatedGroupNames_Lde_javagl_obj_ObjFace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IObjFace p0 = (global::JavaGl.Obj.IObjFace)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.GetActivatedGroupNames (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getActivatedGroupNames_Lde_javagl_obj_ObjFace_;
		public unsafe global::System.Collections.Generic.ICollection<string> GetActivatedGroupNames (global::JavaGl.Obj.IObjFace p0)
		{
			if (id_getActivatedGroupNames_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_getActivatedGroupNames_Lde_javagl_obj_ObjFace_ = JNIEnv.GetMethodID (class_ref, "getActivatedGroupNames", "(Lde/javagl/obj/ObjFace;)Ljava/util/Set;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivatedGroupNames_Lde_javagl_obj_ObjFace_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_;
#pragma warning disable 0169
		static Delegate GetGetActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_Handler ()
		{
			if (cb_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_ == null)
				cb_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_);
			return cb_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_;
		}

		static IntPtr n_GetActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JavaGl.Obj.IObjFace p0 = (global::JavaGl.Obj.IObjFace)global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetActivatedMaterialGroupName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_;
		public unsafe string GetActivatedMaterialGroupName (global::JavaGl.Obj.IObjFace p0)
		{
			if (id_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_ == IntPtr.Zero)
				id_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_ = JNIEnv.GetMethodID (class_ref, "getActivatedMaterialGroupName", "(Lde/javagl/obj/ObjFace;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getFace_I;
#pragma warning disable 0169
		static Delegate GetGetFace_IHandler ()
		{
			if (cb_getFace_I == null)
				cb_getFace_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFace_I);
			return cb_getFace_I;
		}

		static IntPtr n_GetFace_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFace (p0));
		}
#pragma warning restore 0169

		IntPtr id_getFace_I;
		public unsafe global::JavaGl.Obj.IObjFace GetFace (int p0)
		{
			if (id_getFace_I == IntPtr.Zero)
				id_getFace_I = JNIEnv.GetMethodID (class_ref, "getFace", "(I)Lde/javagl/obj/ObjFace;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjFace> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFace_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getGroup_I;
#pragma warning disable 0169
		static Delegate GetGetGroup_IHandler ()
		{
			if (cb_getGroup_I == null)
				cb_getGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetGroup_I);
			return cb_getGroup_I;
		}

		static IntPtr n_GetGroup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGroup (p0));
		}
#pragma warning restore 0169

		IntPtr id_getGroup_I;
		public unsafe global::JavaGl.Obj.IObjGroup GetGroup (int p0)
		{
			if (id_getGroup_I == IntPtr.Zero)
				id_getGroup_I = JNIEnv.GetMethodID (class_ref, "getGroup", "(I)Lde/javagl/obj/ObjGroup;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroup_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getGroup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetGroup_Ljava_lang_String_Handler ()
		{
			if (cb_getGroup_Ljava_lang_String_ == null)
				cb_getGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroup_Ljava_lang_String_);
			return cb_getGroup_Ljava_lang_String_;
		}

		static IntPtr n_GetGroup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGroup (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getGroup_Ljava_lang_String_;
		public unsafe global::JavaGl.Obj.IObjGroup GetGroup (string p0)
		{
			if (id_getGroup_Ljava_lang_String_ == IntPtr.Zero)
				id_getGroup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getGroup", "(Ljava/lang/String;)Lde/javagl/obj/ObjGroup;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::JavaGl.Obj.IObjGroup __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getMaterialGroup_I;
#pragma warning disable 0169
		static Delegate GetGetMaterialGroup_IHandler ()
		{
			if (cb_getMaterialGroup_I == null)
				cb_getMaterialGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMaterialGroup_I);
			return cb_getMaterialGroup_I;
		}

		static IntPtr n_GetMaterialGroup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMaterialGroup (p0));
		}
#pragma warning restore 0169

		IntPtr id_getMaterialGroup_I;
		public unsafe global::JavaGl.Obj.IObjGroup GetMaterialGroup (int p0)
		{
			if (id_getMaterialGroup_I == IntPtr.Zero)
				id_getMaterialGroup_I = JNIEnv.GetMethodID (class_ref, "getMaterialGroup", "(I)Lde/javagl/obj/ObjGroup;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaterialGroup_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getMaterialGroup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMaterialGroup_Ljava_lang_String_Handler ()
		{
			if (cb_getMaterialGroup_Ljava_lang_String_ == null)
				cb_getMaterialGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMaterialGroup_Ljava_lang_String_);
			return cb_getMaterialGroup_Ljava_lang_String_;
		}

		static IntPtr n_GetMaterialGroup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMaterialGroup (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMaterialGroup_Ljava_lang_String_;
		public unsafe global::JavaGl.Obj.IObjGroup GetMaterialGroup (string p0)
		{
			if (id_getMaterialGroup_Ljava_lang_String_ == IntPtr.Zero)
				id_getMaterialGroup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMaterialGroup", "(Ljava/lang/String;)Lde/javagl/obj/ObjGroup;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::JavaGl.Obj.IObjGroup __ret = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObjGroup> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaterialGroup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getNormal_I;
#pragma warning disable 0169
		static Delegate GetGetNormal_IHandler ()
		{
			if (cb_getNormal_I == null)
				cb_getNormal_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetNormal_I);
			return cb_getNormal_I;
		}

		static IntPtr n_GetNormal_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetNormal (p0));
		}
#pragma warning restore 0169

		IntPtr id_getNormal_I;
		public unsafe global::JavaGl.Obj.IFloatTuple GetNormal (int p0)
		{
			if (id_getNormal_I == IntPtr.Zero)
				id_getNormal_I = JNIEnv.GetMethodID (class_ref, "getNormal", "(I)Lde/javagl/obj/FloatTuple;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNormal_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getTexCoord_I;
#pragma warning disable 0169
		static Delegate GetGetTexCoord_IHandler ()
		{
			if (cb_getTexCoord_I == null)
				cb_getTexCoord_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTexCoord_I);
			return cb_getTexCoord_I;
		}

		static IntPtr n_GetTexCoord_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTexCoord (p0));
		}
#pragma warning restore 0169

		IntPtr id_getTexCoord_I;
		public unsafe global::JavaGl.Obj.IFloatTuple GetTexCoord (int p0)
		{
			if (id_getTexCoord_I == IntPtr.Zero)
				id_getTexCoord_I = JNIEnv.GetMethodID (class_ref, "getTexCoord", "(I)Lde/javagl/obj/FloatTuple;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTexCoord_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getVertex_I;
#pragma warning disable 0169
		static Delegate GetGetVertex_IHandler ()
		{
			if (cb_getVertex_I == null)
				cb_getVertex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetVertex_I);
			return cb_getVertex_I;
		}

		static IntPtr n_GetVertex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVertex (p0));
		}
#pragma warning restore 0169

		IntPtr id_getVertex_I;
		public unsafe global::JavaGl.Obj.IFloatTuple GetVertex (int p0)
		{
			if (id_getVertex_I == IntPtr.Zero)
				id_getVertex_I = JNIEnv.GetMethodID (class_ref, "getVertex", "(I)Lde/javagl/obj/FloatTuple;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVertex_I, __args), JniHandleOwnership.TransferLocalRef);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
