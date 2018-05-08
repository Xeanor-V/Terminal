using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JavaGl.Obj {

	// Metadata.xml XPath interface reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']"
	[Register ("de/javagl/obj/Mtl", "", "JavaGl.Obj.IMtlInvoker")]
	public partial interface IMtl : IJavaObject {

		global::JavaGl.Obj.IFloatTuple Ka {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getKa' and count(parameter)=0]"
			[Register ("getKa", "()Lde/javagl/obj/FloatTuple;", "GetGetKaHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
		}

		global::JavaGl.Obj.IFloatTuple Kd {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getKd' and count(parameter)=0]"
			[Register ("getKd", "()Lde/javagl/obj/FloatTuple;", "GetGetKdHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
		}

		global::JavaGl.Obj.IFloatTuple Ks {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getKs' and count(parameter)=0]"
			[Register ("getKs", "()Lde/javagl/obj/FloatTuple;", "GetGetKsHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
		}

		string MapKd {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getMapKd' and count(parameter)=0]"
			[Register ("getMapKd", "()Ljava/lang/String;", "GetGetMapKdHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setMapKd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMapKd", "(Ljava/lang/String;)V", "GetSetMapKd_Ljava_lang_String_Handler:JavaGl.Obj.IMtlInvoker, JavaGL")] set;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
		}

		float Ns {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getNs' and count(parameter)=0]"
			[Register ("getNs", "()F", "GetGetNsHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setNs' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setNs", "(F)V", "GetSetNs_FHandler:JavaGl.Obj.IMtlInvoker, JavaGL")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='getD' and count(parameter)=0]"
		[Register ("getD", "()F", "GetGetDHandler:JavaGl.Obj.IMtlInvoker, JavaGL")]
		float GetD ();

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setD' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setD", "(F)V", "GetSetD_FHandler:JavaGl.Obj.IMtlInvoker, JavaGL")]
		void SetD (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setKa' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setKa", "(FFF)V", "GetSetKa_FFFHandler:JavaGl.Obj.IMtlInvoker, JavaGL")]
		void SetKa (float p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setKd' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setKd", "(FFF)V", "GetSetKd_FFFHandler:JavaGl.Obj.IMtlInvoker, JavaGL")]
		void SetKd (float p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='de.javagl.obj']/interface[@name='Mtl']/method[@name='setKs' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setKs", "(FFF)V", "GetSetKs_FFFHandler:JavaGl.Obj.IMtlInvoker, JavaGL")]
		void SetKs (float p0, float p1, float p2);

	}

	[global::Android.Runtime.Register ("de/javagl/obj/Mtl", DoNotGenerateAcw=true)]
	internal class IMtlInvoker : global::Java.Lang.Object, IMtl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("de/javagl/obj/Mtl");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMtlInvoker); }
		}

		IntPtr class_ref;

		public static IMtl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMtl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "de.javagl.obj.Mtl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMtlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getKa;
#pragma warning disable 0169
		static Delegate GetGetKaHandler ()
		{
			if (cb_getKa == null)
				cb_getKa = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKa);
			return cb_getKa;
		}

		static IntPtr n_GetKa (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ka);
		}
#pragma warning restore 0169

		IntPtr id_getKa;
		public unsafe global::JavaGl.Obj.IFloatTuple Ka {
			get {
				if (id_getKa == IntPtr.Zero)
					id_getKa = JNIEnv.GetMethodID (class_ref, "getKa", "()Lde/javagl/obj/FloatTuple;");
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKa), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKd;
#pragma warning disable 0169
		static Delegate GetGetKdHandler ()
		{
			if (cb_getKd == null)
				cb_getKd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKd);
			return cb_getKd;
		}

		static IntPtr n_GetKd (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Kd);
		}
#pragma warning restore 0169

		IntPtr id_getKd;
		public unsafe global::JavaGl.Obj.IFloatTuple Kd {
			get {
				if (id_getKd == IntPtr.Zero)
					id_getKd = JNIEnv.GetMethodID (class_ref, "getKd", "()Lde/javagl/obj/FloatTuple;");
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKd), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKs;
#pragma warning disable 0169
		static Delegate GetGetKsHandler ()
		{
			if (cb_getKs == null)
				cb_getKs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKs);
			return cb_getKs;
		}

		static IntPtr n_GetKs (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ks);
		}
#pragma warning restore 0169

		IntPtr id_getKs;
		public unsafe global::JavaGl.Obj.IFloatTuple Ks {
			get {
				if (id_getKs == IntPtr.Zero)
					id_getKs = JNIEnv.GetMethodID (class_ref, "getKs", "()Lde/javagl/obj/FloatTuple;");
				return global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IFloatTuple> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKs), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapKd;
#pragma warning disable 0169
		static Delegate GetGetMapKdHandler ()
		{
			if (cb_getMapKd == null)
				cb_getMapKd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapKd);
			return cb_getMapKd;
		}

		static IntPtr n_GetMapKd (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MapKd);
		}
#pragma warning restore 0169

		static Delegate cb_setMapKd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapKd_Ljava_lang_String_Handler ()
		{
			if (cb_setMapKd_Ljava_lang_String_ == null)
				cb_setMapKd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapKd_Ljava_lang_String_);
			return cb_setMapKd_Ljava_lang_String_;
		}

		static void n_SetMapKd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MapKd = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMapKd;
		IntPtr id_setMapKd_Ljava_lang_String_;
		public unsafe string MapKd {
			get {
				if (id_getMapKd == IntPtr.Zero)
					id_getMapKd = JNIEnv.GetMethodID (class_ref, "getMapKd", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapKd), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMapKd_Ljava_lang_String_ == IntPtr.Zero)
					id_setMapKd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMapKd", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapKd_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNs;
#pragma warning disable 0169
		static Delegate GetGetNsHandler ()
		{
			if (cb_getNs == null)
				cb_getNs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetNs);
			return cb_getNs;
		}

		static float n_GetNs (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ns;
		}
#pragma warning restore 0169

		static Delegate cb_setNs_F;
#pragma warning disable 0169
		static Delegate GetSetNs_FHandler ()
		{
			if (cb_setNs_F == null)
				cb_setNs_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetNs_F);
			return cb_setNs_F;
		}

		static void n_SetNs_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ns = p0;
		}
#pragma warning restore 0169

		IntPtr id_getNs;
		IntPtr id_setNs_F;
		public unsafe float Ns {
			get {
				if (id_getNs == IntPtr.Zero)
					id_getNs = JNIEnv.GetMethodID (class_ref, "getNs", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getNs);
			}
			set {
				if (id_setNs_F == IntPtr.Zero)
					id_setNs_F = JNIEnv.GetMethodID (class_ref, "setNs", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNs_F, __args);
			}
		}

		static Delegate cb_getD;
#pragma warning disable 0169
		static Delegate GetGetDHandler ()
		{
			if (cb_getD == null)
				cb_getD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetD);
			return cb_getD;
		}

		static float n_GetD (IntPtr jnienv, IntPtr native__this)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetD ();
		}
#pragma warning restore 0169

		IntPtr id_getD;
		public unsafe float GetD ()
		{
			if (id_getD == IntPtr.Zero)
				id_getD = JNIEnv.GetMethodID (class_ref, "getD", "()F");
			return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getD);
		}

		static Delegate cb_setD_F;
#pragma warning disable 0169
		static Delegate GetSetD_FHandler ()
		{
			if (cb_setD_F == null)
				cb_setD_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetD_F);
			return cb_setD_F;
		}

		static void n_SetD_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetD (p0);
		}
#pragma warning restore 0169

		IntPtr id_setD_F;
		public unsafe void SetD (float p0)
		{
			if (id_setD_F == IntPtr.Zero)
				id_setD_F = JNIEnv.GetMethodID (class_ref, "setD", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setD_F, __args);
		}

		static Delegate cb_setKa_FFF;
#pragma warning disable 0169
		static Delegate GetSetKa_FFFHandler ()
		{
			if (cb_setKa_FFF == null)
				cb_setKa_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetKa_FFF);
			return cb_setKa_FFF;
		}

		static void n_SetKa_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKa (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setKa_FFF;
		public unsafe void SetKa (float p0, float p1, float p2)
		{
			if (id_setKa_FFF == IntPtr.Zero)
				id_setKa_FFF = JNIEnv.GetMethodID (class_ref, "setKa", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKa_FFF, __args);
		}

		static Delegate cb_setKd_FFF;
#pragma warning disable 0169
		static Delegate GetSetKd_FFFHandler ()
		{
			if (cb_setKd_FFF == null)
				cb_setKd_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetKd_FFF);
			return cb_setKd_FFF;
		}

		static void n_SetKd_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKd (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setKd_FFF;
		public unsafe void SetKd (float p0, float p1, float p2)
		{
			if (id_setKd_FFF == IntPtr.Zero)
				id_setKd_FFF = JNIEnv.GetMethodID (class_ref, "setKd", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKd_FFF, __args);
		}

		static Delegate cb_setKs_FFF;
#pragma warning disable 0169
		static Delegate GetSetKs_FFFHandler ()
		{
			if (cb_setKs_FFF == null)
				cb_setKs_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetKs_FFF);
			return cb_setKs_FFF;
		}

		static void n_SetKs_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::JavaGl.Obj.IMtl __this = global::Java.Lang.Object.GetObject<global::JavaGl.Obj.IMtl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKs (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setKs_FFF;
		public unsafe void SetKs (float p0, float p1, float p2)
		{
			if (id_setKs_FFF == IntPtr.Zero)
				id_setKs_FFF = JNIEnv.GetMethodID (class_ref, "setKs", "(FFF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKs_FFF, __args);
		}

	}

}
