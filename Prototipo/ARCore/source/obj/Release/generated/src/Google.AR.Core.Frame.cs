using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']"
	[global::Android.Runtime.Register ("com/google/ar/core/Frame", DoNotGenerateAcw=true)]
	public partial class Frame : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Frame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Frame); }
		}

		protected Frame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/constructor[@name='Frame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Frame ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Frame)) {
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

		static Delegate cb_getCamera;
#pragma warning disable 0169
		static Delegate GetGetCameraHandler ()
		{
			if (cb_getCamera == null)
				cb_getCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCamera);
			return cb_getCamera;
		}

		static IntPtr n_GetCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Camera);
		}
#pragma warning restore 0169

		static IntPtr id_getCamera;
		public virtual unsafe global::Google.AR.Core.Camera Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()Lcom/google/ar/core/Camera;", "GetGetCameraHandler")]
			get {
				if (id_getCamera == IntPtr.Zero)
					id_getCamera = JNIEnv.GetMethodID (class_ref, "getCamera", "()Lcom/google/ar/core/Camera;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCamera), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Camera> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCamera", "()Lcom/google/ar/core/Camera;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasDisplayGeometryChanged;
#pragma warning disable 0169
		static Delegate GetHasDisplayGeometryChangedHandler ()
		{
			if (cb_hasDisplayGeometryChanged == null)
				cb_hasDisplayGeometryChanged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDisplayGeometryChanged);
			return cb_hasDisplayGeometryChanged;
		}

		static bool n_HasDisplayGeometryChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDisplayGeometryChanged;
		}
#pragma warning restore 0169

		static IntPtr id_hasDisplayGeometryChanged;
		public virtual unsafe bool HasDisplayGeometryChanged {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hasDisplayGeometryChanged' and count(parameter)=0]"
			[Register ("hasDisplayGeometryChanged", "()Z", "GetHasDisplayGeometryChangedHandler")]
			get {
				if (id_hasDisplayGeometryChanged == IntPtr.Zero)
					id_hasDisplayGeometryChanged = JNIEnv.GetMethodID (class_ref, "hasDisplayGeometryChanged", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDisplayGeometryChanged);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasDisplayGeometryChanged", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageMetadata;
#pragma warning disable 0169
		static Delegate GetGetImageMetadataHandler ()
		{
			if (cb_getImageMetadata == null)
				cb_getImageMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageMetadata);
			return cb_getImageMetadata;
		}

		static IntPtr n_GetImageMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageMetadata);
		}
#pragma warning restore 0169

		static IntPtr id_getImageMetadata;
		public virtual unsafe global::Google.AR.Core.ImageMetadata ImageMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getImageMetadata' and count(parameter)=0]"
			[Register ("getImageMetadata", "()Lcom/google/ar/core/ImageMetadata;", "GetGetImageMetadataHandler")]
			get {
				if (id_getImageMetadata == IntPtr.Zero)
					id_getImageMetadata = JNIEnv.GetMethodID (class_ref, "getImageMetadata", "()Lcom/google/ar/core/ImageMetadata;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.ImageMetadata> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageMetadata", "()Lcom/google/ar/core/ImageMetadata;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLightEstimate;
#pragma warning disable 0169
		static Delegate GetGetLightEstimateHandler ()
		{
			if (cb_getLightEstimate == null)
				cb_getLightEstimate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLightEstimate);
			return cb_getLightEstimate;
		}

		static IntPtr n_GetLightEstimate (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LightEstimate);
		}
#pragma warning restore 0169

		static IntPtr id_getLightEstimate;
		public virtual unsafe global::Google.AR.Core.LightEstimate LightEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getLightEstimate' and count(parameter)=0]"
			[Register ("getLightEstimate", "()Lcom/google/ar/core/LightEstimate;", "GetGetLightEstimateHandler")]
			get {
				if (id_getLightEstimate == IntPtr.Zero)
					id_getLightEstimate = JNIEnv.GetMethodID (class_ref, "getLightEstimate", "()Lcom/google/ar/core/LightEstimate;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLightEstimate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLightEstimate", "()Lcom/google/ar/core/LightEstimate;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		public virtual unsafe long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getUpdatedAnchors;
#pragma warning disable 0169
		static Delegate GetGetUpdatedAnchorsHandler ()
		{
			if (cb_getUpdatedAnchors == null)
				cb_getUpdatedAnchors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdatedAnchors);
			return cb_getUpdatedAnchors;
		}

		static IntPtr n_GetUpdatedAnchors (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.ToLocalJniHandle (__this.UpdatedAnchors);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdatedAnchors;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Google.AR.Core.Anchor> UpdatedAnchors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getUpdatedAnchors' and count(parameter)=0]"
			[Register ("getUpdatedAnchors", "()Ljava/util/Collection;", "GetGetUpdatedAnchorsHandler")]
			get {
				if (id_getUpdatedAnchors == IntPtr.Zero)
					id_getUpdatedAnchors = JNIEnv.GetMethodID (class_ref, "getUpdatedAnchors", "()Ljava/util/Collection;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatedAnchors), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Google.AR.Core.Anchor>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdatedAnchors", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acquirePointCloud;
#pragma warning disable 0169
		static Delegate GetAcquirePointCloudHandler ()
		{
			if (cb_acquirePointCloud == null)
				cb_acquirePointCloud = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AcquirePointCloud);
			return cb_acquirePointCloud;
		}

		static IntPtr n_AcquirePointCloud (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AcquirePointCloud ());
		}
#pragma warning restore 0169

		static IntPtr id_acquirePointCloud;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='acquirePointCloud' and count(parameter)=0]"
		[Register ("acquirePointCloud", "()Lcom/google/ar/core/PointCloud;", "GetAcquirePointCloudHandler")]
		public virtual unsafe global::Google.AR.Core.PointCloud AcquirePointCloud ()
		{
			if (id_acquirePointCloud == IntPtr.Zero)
				id_acquirePointCloud = JNIEnv.GetMethodID (class_ref, "acquirePointCloud", "()Lcom/google/ar/core/PointCloud;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_acquirePointCloud), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.PointCloud> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acquirePointCloud", "()Lcom/google/ar/core/PointCloud;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUpdatedTrackables_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetUpdatedTrackables_Ljava_lang_Class_Handler ()
		{
			if (cb_getUpdatedTrackables_Ljava_lang_Class_ == null)
				cb_getUpdatedTrackables_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUpdatedTrackables_Ljava_lang_Class_);
			return cb_getUpdatedTrackables_Ljava_lang_Class_;
		}

		static IntPtr n_GetUpdatedTrackables_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filterType)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class filterType = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_filterType, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaCollection.ToLocalJniHandle (__this.GetUpdatedTrackables (filterType));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdatedTrackables_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='getUpdatedTrackables' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getUpdatedTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;", "GetGetUpdatedTrackables_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.google.ar.core.Trackable"})]
		public virtual unsafe global::System.Collections.ICollection GetUpdatedTrackables (global::Java.Lang.Class filterType)
		{
			if (id_getUpdatedTrackables_Ljava_lang_Class_ == IntPtr.Zero)
				id_getUpdatedTrackables_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getUpdatedTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filterType);

				global::System.Collections.ICollection __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatedTrackables_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaCollection.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdatedTrackables", "(Ljava/lang/Class;)Ljava/util/Collection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hitTest_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetHitTest_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_hitTest_Landroid_view_MotionEvent_ == null)
				cb_hitTest_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HitTest_Landroid_view_MotionEvent_);
			return cb_hitTest_Landroid_view_MotionEvent_;
		}

		static IntPtr n_HitTest_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_motionEvent)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent motionEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_motionEvent, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.ToLocalJniHandle (__this.HitTest (motionEvent));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hitTest_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hitTest' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("hitTest", "(Landroid/view/MotionEvent;)Ljava/util/List;", "GetHitTest_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> HitTest (global::Android.Views.MotionEvent motionEvent)
		{
			if (id_hitTest_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_hitTest_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "hitTest", "(Landroid/view/MotionEvent;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (motionEvent);

				global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hitTest_Landroid_view_MotionEvent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hitTest", "(Landroid/view/MotionEvent;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hitTest_FF;
#pragma warning disable 0169
		static Delegate GetHitTest_FFHandler ()
		{
			if (cb_hitTest_FF == null)
				cb_hitTest_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_HitTest_FF);
			return cb_hitTest_FF;
		}

		static IntPtr n_HitTest_FF (IntPtr jnienv, IntPtr native__this, float xPx, float yPx)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.ToLocalJniHandle (__this.HitTest (xPx, yPx));
		}
#pragma warning restore 0169

		static IntPtr id_hitTest_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='hitTest' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("hitTest", "(FF)Ljava/util/List;", "GetHitTest_FFHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Google.AR.Core.HitResult> HitTest (float xPx, float yPx)
		{
			if (id_hitTest_FF == IntPtr.Zero)
				id_hitTest_FF = JNIEnv.GetMethodID (class_ref, "hitTest", "(FF)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (xPx);
				__args [1] = new JValue (yPx);

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hitTest_FF, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Google.AR.Core.HitResult>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hitTest", "(FF)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetTransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == null)
				cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_);
			return cb_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		}

		static void n_TransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uvCoords, IntPtr native_outUvCoords)
		{
			global::Google.AR.Core.Frame __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer uvCoords = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_uvCoords, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer outUvCoords = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_outUvCoords, JniHandleOwnership.DoNotTransfer);
			__this.TransformDisplayUvCoords (uvCoords, outUvCoords);
		}
#pragma warning restore 0169

		static IntPtr id_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Frame']/method[@name='transformDisplayUvCoords' and count(parameter)=2 and parameter[1][@type='java.nio.FloatBuffer'] and parameter[2][@type='java.nio.FloatBuffer']]"
		[Register ("transformDisplayUvCoords", "(Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V", "GetTransformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler")]
		public virtual unsafe void TransformDisplayUvCoords (global::Java.Nio.FloatBuffer uvCoords, global::Java.Nio.FloatBuffer outUvCoords)
		{
			if (id_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "transformDisplayUvCoords", "(Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (uvCoords);
				__args [1] = new JValue (outUvCoords);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transformDisplayUvCoords_Ljava_nio_FloatBuffer_Ljava_nio_FloatBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformDisplayUvCoords", "(Ljava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V"), __args);
			} finally {
			}
		}

	}
}
