using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']"
	[global::Android.Runtime.Register ("com/google/ar/core/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Session", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Session); }
		}

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/constructor[@name='Session' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Session ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Session)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/constructor[@name='Session' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Session (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (Session)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAllAnchors;
#pragma warning disable 0169
		static Delegate GetGetAllAnchorsHandler ()
		{
			if (cb_getAllAnchors == null)
				cb_getAllAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllAnchors);
			return cb_getAllAnchors;
		}

		static IntPtr n_GetAllAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.AllAnchors);
		}
#pragma warning restore 0169

		static IntPtr id_getAllAnchors;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> AllAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getAllAnchors' and count(parameter)=0]"
			[Register ("getAllAnchors", "()Ljava/util/Collection;", "GetGetAllAnchorsHandler")]
			get {
				if (id_getAllAnchors == IntPtr.Zero)
					id_getAllAnchors = JNIEnv.GetMethodID (class_ref, "getAllAnchors", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllAnchors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllAnchors", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_configure_Lcom_google_ar_core_Config_;
#pragma warning disable 0169
		static Delegate GetConfigure_Lcom_google_ar_core_Config_Handler ()
		{
			if (cb_configure_Lcom_google_ar_core_Config_ == null)
				cb_configure_Lcom_google_ar_core_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Configure_Lcom_google_ar_core_Config_);
			return cb_configure_Lcom_google_ar_core_Config_;
		}

		static void n_Configure_Lcom_google_ar_core_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config config = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.Configure (config);
		}
#pragma warning restore 0169

		static IntPtr id_configure_Lcom_google_ar_core_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config']]"
		[Register ("configure", "(Lcom/google/ar/core/Config;)V", "GetConfigure_Lcom_google_ar_core_Config_Handler")]
		public virtual unsafe void Configure (global::Google.AR.Core.Config config)
		{
			if (id_configure_Lcom_google_ar_core_Config_ == IntPtr.Zero)
				id_configure_Lcom_google_ar_core_Config_ = JNIEnv.GetMethodID (class_ref, "configure", "(Lcom/google/ar/core/Config;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configure_Lcom_google_ar_core_Config_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configure", "(Lcom/google/ar/core/Config;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createAnchor_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCreateAnchor_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_createAnchor_Lcom_google_ar_core_Pose_ == null)
				cb_createAnchor_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnchor_Lcom_google_ar_core_Pose_);
			return cb_createAnchor_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_CreateAnchor_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pose)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose pose = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_pose, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAnchor (pose));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAnchor_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='createAnchor' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;", "GetCreateAnchor_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe global::Google.AR.Core.Anchor CreateAnchor (global::Google.AR.Core.Pose pose)
		{
			if (id_createAnchor_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_createAnchor_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pose);

				global::Google.AR.Core.Anchor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAnchor_Lcom_google_ar_core_Pose_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Anchor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAnchor", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Anchor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAllTrackables_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAllTrackables_Ljava_lang_Class_Handler ()
		{
			if (cb_getAllTrackables_Ljava_lang_Class_ == null)
				cb_getAllTrackables_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAllTrackables_Ljava_lang_Class_);
			return cb_getAllTrackables_Ljava_lang_Class_;
		}

		static IntPtr n_GetAllTrackables_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filterType)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class filterType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_filterType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.GetAllTrackables (filterType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAllTrackables_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='getAllTrackables' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAllTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;", "GetGetAllTrackables_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.google.ar.core.Trackable"})]
		public virtual unsafe global::System.Collections.ICollection GetAllTrackables (global::Java.Lang.Class filterType)
		{
			if (id_getAllTrackables_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAllTrackables_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAllTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filterType);

				global::System.Collections.ICollection __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllTrackables_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isSupported_Lcom_google_ar_core_Config_;
#pragma warning disable 0169
		static Delegate GetIsSupported_Lcom_google_ar_core_Config_Handler ()
		{
			if (cb_isSupported_Lcom_google_ar_core_Config_ == null)
				cb_isSupported_Lcom_google_ar_core_Config_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupported_Lcom_google_ar_core_Config_);
			return cb_isSupported_Lcom_google_ar_core_Config_;
		}

		static bool n_IsSupported_Lcom_google_ar_core_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Config config = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupported (config);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSupported_Lcom_google_ar_core_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Config']]"
		[Register ("isSupported", "(Lcom/google/ar/core/Config;)Z", "GetIsSupported_Lcom_google_ar_core_Config_Handler")]
		public virtual unsafe bool IsSupported (global::Google.AR.Core.Config config)
		{
			if (id_isSupported_Lcom_google_ar_core_Config_ == IntPtr.Zero)
				id_isSupported_Lcom_google_ar_core_Config_ = JNIEnv.GetMethodID (class_ref, "isSupported", "(Lcom/google/ar/core/Config;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (config);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupported_Lcom_google_ar_core_Config_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupported", "(Lcom/google/ar/core/Config;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCameraTextureName_I;
#pragma warning disable 0169
		static Delegate GetSetCameraTextureName_IHandler ()
		{
			if (cb_setCameraTextureName_I == null)
				cb_setCameraTextureName_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCameraTextureName_I);
			return cb_setCameraTextureName_I;
		}

		static void n_SetCameraTextureName_I (IntPtr jnienv, IntPtr native__this, int textureId)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraTextureName (textureId);
		}
#pragma warning restore 0169

		static IntPtr id_setCameraTextureName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='setCameraTextureName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCameraTextureName", "(I)V", "GetSetCameraTextureName_IHandler")]
		public virtual unsafe void SetCameraTextureName (int textureId)
		{
			if (id_setCameraTextureName_I == IntPtr.Zero)
				id_setCameraTextureName_I = JNIEnv.GetMethodID (class_ref, "setCameraTextureName", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (textureId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCameraTextureName_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCameraTextureName", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisplayGeometry_III;
#pragma warning disable 0169
		static Delegate GetSetDisplayGeometry_IIIHandler ()
		{
			if (cb_setDisplayGeometry_III == null)
				cb_setDisplayGeometry_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_SetDisplayGeometry_III);
			return cb_setDisplayGeometry_III;
		}

		static void n_SetDisplayGeometry_III (IntPtr jnienv, IntPtr native__this, int displayRotation, int widthPx, int heightPx)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayGeometry (displayRotation, widthPx, heightPx);
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayGeometry_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='setDisplayGeometry' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setDisplayGeometry", "(III)V", "GetSetDisplayGeometry_IIIHandler")]
		public virtual unsafe void SetDisplayGeometry (int displayRotation, int widthPx, int heightPx)
		{
			if (id_setDisplayGeometry_III == IntPtr.Zero)
				id_setDisplayGeometry_III = JNIEnv.GetMethodID (class_ref, "setDisplayGeometry", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (displayRotation);
				__args [1] = new JValue (widthPx);
				__args [2] = new JValue (heightPx);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayGeometry_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayGeometry", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_update;
#pragma warning disable 0169
		static Delegate GetUpdateHandler ()
		{
			if (cb_update == null)
				cb_update = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Update);
			return cb_update;
		}

		static IntPtr n_Update (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Session __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Update ());
		}
#pragma warning restore 0169

		static IntPtr id_update;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Session']/method[@name='update' and count(parameter)=0]"
		[Register ("update", "()Lcom/google/ar/core/Frame;", "GetUpdateHandler")]
		public virtual unsafe global::Google.AR.Core.Frame Update ()
		{
			if (id_update == IntPtr.Zero)
				id_update = JNIEnv.GetMethodID (class_ref, "update", "()Lcom/google/ar/core/Frame;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_update), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "()Lcom/google/ar/core/Frame;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
