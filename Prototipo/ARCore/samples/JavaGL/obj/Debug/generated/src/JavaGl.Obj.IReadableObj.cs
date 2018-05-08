using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']"
	[Register ("de/javagl/obj/ReadableObj", "", "JavaGl.Obj.IReadableObjInvoker")]
	public partial interface IReadableObj : IJavaObject {

		global::System.Collections.Generic.IList<string> MtlFileNames {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getMtlFileNames' and count(parameter)=0]"
			[Register ("getMtlFileNames", "()Ljava/util/List;", "GetGetMtlFileNamesHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumFaces {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumFaces' and count(parameter)=0]"
			[Register ("getNumFaces", "()I", "GetGetNumFacesHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumGroups' and count(parameter)=0]"
			[Register ("getNumGroups", "()I", "GetGetNumGroupsHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumMaterialGroups {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumMaterialGroups' and count(parameter)=0]"
			[Register ("getNumMaterialGroups", "()I", "GetGetNumMaterialGroupsHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumNormals {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumNormals' and count(parameter)=0]"
			[Register ("getNumNormals", "()I", "GetGetNumNormalsHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumTexCoords {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumTexCoords' and count(parameter)=0]"
			[Register ("getNumTexCoords", "()I", "GetGetNumTexCoordsHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		int NumVertices {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNumVertices' and count(parameter)=0]"
			[Register ("getNumVertices", "()I", "GetGetNumVerticesHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getActivatedGroupNames' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("getActivatedGroupNames", "(Lde/javagl/obj/ObjFace;)Ljava/util/Set;", "GetGetActivatedGroupNames_Lde_javagl_obj_ObjFace_Handler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::System.Collections.Generic.ICollection<string> GetActivatedGroupNames (global::JavaGl.Obj.IObjFace p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getActivatedMaterialGroupName' and count(parameter)=1 and parameter[1][@type='de.javagl.obj.ObjFace']]"
		[Register ("getActivatedMaterialGroupName", "(Lde/javagl/obj/ObjFace;)Ljava/lang/String;", "GetGetActivatedMaterialGroupName_Lde_javagl_obj_ObjFace_Handler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		string GetActivatedMaterialGroupName (global::JavaGl.Obj.IObjFace p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getFace' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFace", "(I)Lde/javagl/obj/ObjFace;", "GetGetFace_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IObjFace GetFace (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGroup", "(I)Lde/javagl/obj/ObjGroup;", "GetGetGroup_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IObjGroup GetGroup (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getGroup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getGroup", "(Ljava/lang/String;)Lde/javagl/obj/ObjGroup;", "GetGetGroup_Ljava_lang_String_Handler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IObjGroup GetGroup (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getMaterialGroup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMaterialGroup", "(I)Lde/javagl/obj/ObjGroup;", "GetGetMaterialGroup_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IObjGroup GetMaterialGroup (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getMaterialGroup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMaterialGroup", "(Ljava/lang/String;)Lde/javagl/obj/ObjGroup;", "GetGetMaterialGroup_Ljava_lang_String_Handler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IObjGroup GetMaterialGroup (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getNormal' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNormal", "(I)Lde/javagl/obj/FloatTuple;", "GetGetNormal_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IFloatTuple GetNormal (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getTexCoord' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTexCoord", "(I)Lde/javagl/obj/FloatTuple;", "GetGetTexCoord_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IFloatTuple GetTexCoord (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='ReadableObj']/method[@name='getVertex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getVertex", "(I)Lde/javagl/obj/FloatTuple;", "GetGetVertex_IHandler:JavaGl.Obj.IReadableObjInvoker, JavaGL")]
		global::JavaGl.Obj.IFloatTuple GetVertex (int p0);

	}

	[global::Android.Runtime.Register ("de/javagl/obj/ReadableObj", DoNotGenerateAcw=true)]
	internal class IReadableObjInvoker : global::Java.Lang.Object, IReadableObj {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/ReadableObj");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IReadableObjInvoker); }
		}

		IntPtr class_ref;

		public static IReadableObj GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReadableObj> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.ReadableObj"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReadableObjInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::JavaGl.Obj.IReadableObj __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IReadableObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
