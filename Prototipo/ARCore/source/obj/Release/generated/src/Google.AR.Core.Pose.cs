using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']"
	[global::Android.Runtime.Register ("com/google/ar/core/Pose", DoNotGenerateAcw=true)]
	public partial class Pose : global::Java.Lang.Object {


		static IntPtr IDENTITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/field[@name='IDENTITY']"
		[Register ("IDENTITY")]
		public static global::Google.AR.Core.Pose Identity {
			get {
				if (IDENTITY_jfieldId == IntPtr.Zero)
					IDENTITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTITY", "Lcom/google/ar/core/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDENTITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/Pose", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pose); }
		}

		protected Pose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayFarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/constructor[@name='Pose' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "([F[F)V", "")]
		public unsafe Pose (float[] translation, float[] rotation)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_translation = JNIEnv.NewArray (translation);
			IntPtr native_rotation = JNIEnv.NewArray (rotation);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_translation);
				__args [1] = new JValue (native_rotation);
				if (((object) this).GetType () != typeof (Pose)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([F[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([F[F)V", __args);
					return;
				}

				if (id_ctor_arrayFarrayF == IntPtr.Zero)
					id_ctor_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "([F[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayFarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayFarrayF, __args);
			} finally {
				if (translation != null) {
					JNIEnv.CopyArray (native_translation, translation);
					JNIEnv.DeleteLocalRef (native_translation);
				}
				if (rotation != null) {
					JNIEnv.CopyArray (native_rotation, rotation);
					JNIEnv.DeleteLocalRef (native_rotation);
				}
			}
		}

		static Delegate cb_compose_Lcom_google_ar_core_Pose_;
#pragma warning disable 0169
		static Delegate GetCompose_Lcom_google_ar_core_Pose_Handler ()
		{
			if (cb_compose_Lcom_google_ar_core_Pose_ == null)
				cb_compose_Lcom_google_ar_core_Pose_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Compose_Lcom_google_ar_core_Pose_);
			return cb_compose_Lcom_google_ar_core_Pose_;
		}

		static IntPtr n_Compose_Lcom_google_ar_core_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rhs)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Google.AR.Core.Pose rhs = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (native_rhs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Compose (rhs));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compose_Lcom_google_ar_core_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='compose' and count(parameter)=1 and parameter[1][@type='com.google.ar.core.Pose']]"
		[Register ("compose", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Pose;", "GetCompose_Lcom_google_ar_core_Pose_Handler")]
		public virtual unsafe global::Google.AR.Core.Pose Compose (global::Google.AR.Core.Pose rhs)
		{
			if (id_compose_Lcom_google_ar_core_Pose_ == IntPtr.Zero)
				id_compose_Lcom_google_ar_core_Pose_ = JNIEnv.GetMethodID (class_ref, "compose", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Pose;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (rhs);

				global::Google.AR.Core.Pose __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compose_Lcom_google_ar_core_Pose_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compose", "(Lcom/google/ar/core/Pose;)Lcom/google/ar/core/Pose;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_extractRotation;
#pragma warning disable 0169
		static Delegate GetExtractRotationHandler ()
		{
			if (cb_extractRotation == null)
				cb_extractRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractRotation);
			return cb_extractRotation;
		}

		static IntPtr n_ExtractRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtractRotation ());
		}
#pragma warning restore 0169

		static IntPtr id_extractRotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='extractRotation' and count(parameter)=0]"
		[Register ("extractRotation", "()Lcom/google/ar/core/Pose;", "GetExtractRotationHandler")]
		public virtual unsafe global::Google.AR.Core.Pose ExtractRotation ()
		{
			if (id_extractRotation == IntPtr.Zero)
				id_extractRotation = JNIEnv.GetMethodID (class_ref, "extractRotation", "()Lcom/google/ar/core/Pose;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractRotation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractRotation", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_extractTranslation;
#pragma warning disable 0169
		static Delegate GetExtractTranslationHandler ()
		{
			if (cb_extractTranslation == null)
				cb_extractTranslation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtractTranslation);
			return cb_extractTranslation;
		}

		static IntPtr n_ExtractTranslation (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtractTranslation ());
		}
#pragma warning restore 0169

		static IntPtr id_extractTranslation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='extractTranslation' and count(parameter)=0]"
		[Register ("extractTranslation", "()Lcom/google/ar/core/Pose;", "GetExtractTranslationHandler")]
		public virtual unsafe global::Google.AR.Core.Pose ExtractTranslation ()
		{
			if (id_extractTranslation == IntPtr.Zero)
				id_extractTranslation = JNIEnv.GetMethodID (class_ref, "extractTranslation", "()Lcom/google/ar/core/Pose;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractTranslation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractTranslation", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRotationQuaternion_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetRotationQuaternion_arrayFIHandler ()
		{
			if (cb_getRotationQuaternion_arrayFI == null)
				cb_getRotationQuaternion_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetRotationQuaternion_arrayFI);
			return cb_getRotationQuaternion_arrayFI;
		}

		static void n_GetRotationQuaternion_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int offset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] dest = (float[]) JNIEnv.GetArray (native_dest, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetRotationQuaternion (dest, offset);
			if (dest != null)
				JNIEnv.CopyArray (dest, native_dest);
		}
#pragma warning restore 0169

		static IntPtr id_getRotationQuaternion_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getRotationQuaternion' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getRotationQuaternion", "([FI)V", "GetGetRotationQuaternion_arrayFIHandler")]
		public virtual unsafe void GetRotationQuaternion (float[] dest, int offset)
		{
			if (id_getRotationQuaternion_arrayFI == IntPtr.Zero)
				id_getRotationQuaternion_arrayFI = JNIEnv.GetMethodID (class_ref, "getRotationQuaternion", "([FI)V");
			IntPtr native_dest = JNIEnv.NewArray (dest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dest);
				__args [1] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getRotationQuaternion_arrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotationQuaternion", "([FI)V"), __args);
			} finally {
				if (dest != null) {
					JNIEnv.CopyArray (native_dest, dest);
					JNIEnv.DeleteLocalRef (native_dest);
				}
			}
		}

		static Delegate cb_getTransformedAxis_IF;
#pragma warning disable 0169
		static Delegate GetGetTransformedAxis_IFHandler ()
		{
			if (cb_getTransformedAxis_IF == null)
				cb_getTransformedAxis_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, IntPtr>) n_GetTransformedAxis_IF);
			return cb_getTransformedAxis_IF;
		}

		static IntPtr n_GetTransformedAxis_IF (IntPtr jnienv, IntPtr native__this, int axis, float scale)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTransformedAxis (axis, scale));
		}
#pragma warning restore 0169

		static IntPtr id_getTransformedAxis_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTransformedAxis' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("getTransformedAxis", "(IF)[F", "GetGetTransformedAxis_IFHandler")]
		public virtual unsafe float[] GetTransformedAxis (int axis, float scale)
		{
			if (id_getTransformedAxis_IF == IntPtr.Zero)
				id_getTransformedAxis_IF = JNIEnv.GetMethodID (class_ref, "getTransformedAxis", "(IF)[F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (axis);
				__args [1] = new JValue (scale);

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransformedAxis_IF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransformedAxis", "(IF)[F"), __args), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getTransformedAxis_IFarrayFI;
#pragma warning disable 0169
		static Delegate GetGetTransformedAxis_IFarrayFIHandler ()
		{
			if (cb_getTransformedAxis_IFarrayFI == null)
				cb_getTransformedAxis_IFarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float, IntPtr, int>) n_GetTransformedAxis_IFarrayFI);
			return cb_getTransformedAxis_IFarrayFI;
		}

		static void n_GetTransformedAxis_IFarrayFI (IntPtr jnienv, IntPtr native__this, int axis, float scale, IntPtr native_dest, int offset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] dest = (float[]) JNIEnv.GetArray (native_dest, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetTransformedAxis (axis, scale, dest, offset);
			if (dest != null)
				JNIEnv.CopyArray (dest, native_dest);
		}
#pragma warning restore 0169

		static IntPtr id_getTransformedAxis_IFarrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTransformedAxis' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("getTransformedAxis", "(IF[FI)V", "GetGetTransformedAxis_IFarrayFIHandler")]
		public virtual unsafe void GetTransformedAxis (int axis, float scale, float[] dest, int offset)
		{
			if (id_getTransformedAxis_IFarrayFI == IntPtr.Zero)
				id_getTransformedAxis_IFarrayFI = JNIEnv.GetMethodID (class_ref, "getTransformedAxis", "(IF[FI)V");
			IntPtr native_dest = JNIEnv.NewArray (dest);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (axis);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (native_dest);
				__args [3] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTransformedAxis_IFarrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransformedAxis", "(IF[FI)V"), __args);
			} finally {
				if (dest != null) {
					JNIEnv.CopyArray (native_dest, dest);
					JNIEnv.DeleteLocalRef (native_dest);
				}
			}
		}

		static Delegate cb_getTranslation_arrayFI;
#pragma warning disable 0169
		static Delegate GetGetTranslation_arrayFIHandler ()
		{
			if (cb_getTranslation_arrayFI == null)
				cb_getTranslation_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_GetTranslation_arrayFI);
			return cb_getTranslation_arrayFI;
		}

		static void n_GetTranslation_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int offset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] dest = (float[]) JNIEnv.GetArray (native_dest, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.GetTranslation (dest, offset);
			if (dest != null)
				JNIEnv.CopyArray (dest, native_dest);
		}
#pragma warning restore 0169

		static IntPtr id_getTranslation_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getTranslation' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("getTranslation", "([FI)V", "GetGetTranslation_arrayFIHandler")]
		public virtual unsafe void GetTranslation (float[] dest, int offset)
		{
			if (id_getTranslation_arrayFI == IntPtr.Zero)
				id_getTranslation_arrayFI = JNIEnv.GetMethodID (class_ref, "getTranslation", "([FI)V");
			IntPtr native_dest = JNIEnv.NewArray (dest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dest);
				__args [1] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTranslation_arrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTranslation", "([FI)V"), __args);
			} finally {
				if (dest != null) {
					JNIEnv.CopyArray (native_dest, dest);
					JNIEnv.DeleteLocalRef (native_dest);
				}
			}
		}

		static Delegate cb_getXAxis;
#pragma warning disable 0169
		static Delegate GetGetXAxisHandler ()
		{
			if (cb_getXAxis == null)
				cb_getXAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXAxis);
			return cb_getXAxis;
		}

		static IntPtr n_GetXAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetXAxis ());
		}
#pragma warning restore 0169

		static IntPtr id_getXAxis;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getXAxis' and count(parameter)=0]"
		[Register ("getXAxis", "()[F", "GetGetXAxisHandler")]
		public virtual unsafe float[] GetXAxis ()
		{
			if (id_getXAxis == IntPtr.Zero)
				id_getXAxis = JNIEnv.GetMethodID (class_ref, "getXAxis", "()[F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getXAxis), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXAxis", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getYAxis;
#pragma warning disable 0169
		static Delegate GetGetYAxisHandler ()
		{
			if (cb_getYAxis == null)
				cb_getYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYAxis);
			return cb_getYAxis;
		}

		static IntPtr n_GetYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYAxis ());
		}
#pragma warning restore 0169

		static IntPtr id_getYAxis;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getYAxis' and count(parameter)=0]"
		[Register ("getYAxis", "()[F", "GetGetYAxisHandler")]
		public virtual unsafe float[] GetYAxis ()
		{
			if (id_getYAxis == IntPtr.Zero)
				id_getYAxis = JNIEnv.GetMethodID (class_ref, "getYAxis", "()[F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getYAxis), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYAxis", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getZAxis;
#pragma warning disable 0169
		static Delegate GetGetZAxisHandler ()
		{
			if (cb_getZAxis == null)
				cb_getZAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZAxis);
			return cb_getZAxis;
		}

		static IntPtr n_GetZAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetZAxis ());
		}
#pragma warning restore 0169

		static IntPtr id_getZAxis;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='getZAxis' and count(parameter)=0]"
		[Register ("getZAxis", "()[F", "GetGetZAxisHandler")]
		public virtual unsafe float[] GetZAxis ()
		{
			if (id_getZAxis == IntPtr.Zero)
				id_getZAxis = JNIEnv.GetMethodID (class_ref, "getZAxis", "()[F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZAxis), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZAxis", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_inverse;
#pragma warning disable 0169
		static Delegate GetInverseHandler ()
		{
			if (cb_inverse == null)
				cb_inverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Inverse);
			return cb_inverse;
		}

		static IntPtr n_Inverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inverse ());
		}
#pragma warning restore 0169

		static IntPtr id_inverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='inverse' and count(parameter)=0]"
		[Register ("inverse", "()Lcom/google/ar/core/Pose;", "GetInverseHandler")]
		public virtual unsafe global::Google.AR.Core.Pose Inverse ()
		{
			if (id_inverse == IntPtr.Zero)
				id_inverse = JNIEnv.GetMethodID (class_ref, "inverse", "()Lcom/google/ar/core/Pose;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inverse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inverse", "()Lcom/google/ar/core/Pose;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeInterpolated_Lcom_google_ar_core_Pose_Lcom_google_ar_core_Pose_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeInterpolated' and count(parameter)=3 and parameter[1][@type='com.google.ar.core.Pose'] and parameter[2][@type='com.google.ar.core.Pose'] and parameter[3][@type='float']]"
		[Register ("makeInterpolated", "(Lcom/google/ar/core/Pose;Lcom/google/ar/core/Pose;F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeInterpolated (global::Google.AR.Core.Pose a, global::Google.AR.Core.Pose b, float t)
		{
			if (id_makeInterpolated_Lcom_google_ar_core_Pose_Lcom_google_ar_core_Pose_F == IntPtr.Zero)
				id_makeInterpolated_Lcom_google_ar_core_Pose_Lcom_google_ar_core_Pose_F = JNIEnv.GetStaticMethodID (class_ref, "makeInterpolated", "(Lcom/google/ar/core/Pose;Lcom/google/ar/core/Pose;F)Lcom/google/ar/core/Pose;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (a);
				__args [1] = new JValue (b);
				__args [2] = new JValue (t);
				global::Google.AR.Core.Pose __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeInterpolated_Lcom_google_ar_core_Pose_Lcom_google_ar_core_Pose_F, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_makeRotation_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeRotation' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("makeRotation", "(FFFF)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeRotation (float x, float y, float z, float w)
		{
			if (id_makeRotation_FFFF == IntPtr.Zero)
				id_makeRotation_FFFF = JNIEnv.GetStaticMethodID (class_ref, "makeRotation", "(FFFF)Lcom/google/ar/core/Pose;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (x);
				__args [1] = new JValue (y);
				__args [2] = new JValue (z);
				__args [3] = new JValue (w);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeRotation_FFFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeRotation_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeRotation' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("makeRotation", "([F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeRotation (float[] quaternion)
		{
			if (id_makeRotation_arrayF == IntPtr.Zero)
				id_makeRotation_arrayF = JNIEnv.GetStaticMethodID (class_ref, "makeRotation", "([F)Lcom/google/ar/core/Pose;");
			IntPtr native_quaternion = JNIEnv.NewArray (quaternion);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_quaternion);
				global::Google.AR.Core.Pose __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeRotation_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (quaternion != null) {
					JNIEnv.CopyArray (native_quaternion, quaternion);
					JNIEnv.DeleteLocalRef (native_quaternion);
				}
			}
		}

		static IntPtr id_makeTranslation_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeTranslation' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("makeTranslation", "(FFF)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeTranslation (float tx, float ty, float tz)
		{
			if (id_makeTranslation_FFF == IntPtr.Zero)
				id_makeTranslation_FFF = JNIEnv.GetStaticMethodID (class_ref, "makeTranslation", "(FFF)Lcom/google/ar/core/Pose;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (tx);
				__args [1] = new JValue (ty);
				__args [2] = new JValue (tz);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeTranslation_FFF, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_makeTranslation_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='makeTranslation' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("makeTranslation", "([F)Lcom/google/ar/core/Pose;", "")]
		public static unsafe global::Google.AR.Core.Pose MakeTranslation (float[] translation)
		{
			if (id_makeTranslation_arrayF == IntPtr.Zero)
				id_makeTranslation_arrayF = JNIEnv.GetStaticMethodID (class_ref, "makeTranslation", "([F)Lcom/google/ar/core/Pose;");
			IntPtr native_translation = JNIEnv.NewArray (translation);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_translation);
				global::Google.AR.Core.Pose __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_makeTranslation_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (translation != null) {
					JNIEnv.CopyArray (native_translation, translation);
					JNIEnv.DeleteLocalRef (native_translation);
				}
			}
		}

		static Delegate cb_qw;
#pragma warning disable 0169
		static Delegate GetQwHandler ()
		{
			if (cb_qw == null)
				cb_qw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qw);
			return cb_qw;
		}

		static float n_Qw (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qw ();
		}
#pragma warning restore 0169

		static IntPtr id_qw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qw' and count(parameter)=0]"
		[Register ("qw", "()F", "GetQwHandler")]
		public virtual unsafe float Qw ()
		{
			if (id_qw == IntPtr.Zero)
				id_qw = JNIEnv.GetMethodID (class_ref, "qw", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_qw);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "qw", "()F"));
			} finally {
			}
		}

		static Delegate cb_qx;
#pragma warning disable 0169
		static Delegate GetQxHandler ()
		{
			if (cb_qx == null)
				cb_qx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qx);
			return cb_qx;
		}

		static float n_Qx (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qx ();
		}
#pragma warning restore 0169

		static IntPtr id_qx;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qx' and count(parameter)=0]"
		[Register ("qx", "()F", "GetQxHandler")]
		public virtual unsafe float Qx ()
		{
			if (id_qx == IntPtr.Zero)
				id_qx = JNIEnv.GetMethodID (class_ref, "qx", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_qx);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "qx", "()F"));
			} finally {
			}
		}

		static Delegate cb_qy;
#pragma warning disable 0169
		static Delegate GetQyHandler ()
		{
			if (cb_qy == null)
				cb_qy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qy);
			return cb_qy;
		}

		static float n_Qy (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qy ();
		}
#pragma warning restore 0169

		static IntPtr id_qy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qy' and count(parameter)=0]"
		[Register ("qy", "()F", "GetQyHandler")]
		public virtual unsafe float Qy ()
		{
			if (id_qy == IntPtr.Zero)
				id_qy = JNIEnv.GetMethodID (class_ref, "qy", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_qy);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "qy", "()F"));
			} finally {
			}
		}

		static Delegate cb_qz;
#pragma warning disable 0169
		static Delegate GetQzHandler ()
		{
			if (cb_qz == null)
				cb_qz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Qz);
			return cb_qz;
		}

		static float n_Qz (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qz ();
		}
#pragma warning restore 0169

		static IntPtr id_qz;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='qz' and count(parameter)=0]"
		[Register ("qz", "()F", "GetQzHandler")]
		public virtual unsafe float Qz ()
		{
			if (id_qz == IntPtr.Zero)
				id_qz = JNIEnv.GetMethodID (class_ref, "qz", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_qz);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "qz", "()F"));
			} finally {
			}
		}

		static Delegate cb_rotateVector_arrayFIarrayFI;
#pragma warning disable 0169
		static Delegate GetRotateVector_arrayFIarrayFIHandler ()
		{
			if (cb_rotateVector_arrayFIarrayFI == null)
				cb_rotateVector_arrayFIarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_RotateVector_arrayFIarrayFI);
			return cb_rotateVector_arrayFIarrayFI;
		}

		static void n_RotateVector_arrayFIarrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_vectorIn, int inOffset, IntPtr native_vectorOut, int outOffset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] vectorIn = (float[]) JNIEnv.GetArray (native_vectorIn, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] vectorOut = (float[]) JNIEnv.GetArray (native_vectorOut, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.RotateVector (vectorIn, inOffset, vectorOut, outOffset);
			if (vectorIn != null)
				JNIEnv.CopyArray (vectorIn, native_vectorIn);
			if (vectorOut != null)
				JNIEnv.CopyArray (vectorOut, native_vectorOut);
		}
#pragma warning restore 0169

		static IntPtr id_rotateVector_arrayFIarrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='rotateVector' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("rotateVector", "([FI[FI)V", "GetRotateVector_arrayFIarrayFIHandler")]
		public virtual unsafe void RotateVector (float[] vectorIn, int inOffset, float[] vectorOut, int outOffset)
		{
			if (id_rotateVector_arrayFIarrayFI == IntPtr.Zero)
				id_rotateVector_arrayFIarrayFI = JNIEnv.GetMethodID (class_ref, "rotateVector", "([FI[FI)V");
			IntPtr native_vectorIn = JNIEnv.NewArray (vectorIn);
			IntPtr native_vectorOut = JNIEnv.NewArray (vectorOut);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_vectorIn);
				__args [1] = new JValue (inOffset);
				__args [2] = new JValue (native_vectorOut);
				__args [3] = new JValue (outOffset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rotateVector_arrayFIarrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateVector", "([FI[FI)V"), __args);
			} finally {
				if (vectorIn != null) {
					JNIEnv.CopyArray (native_vectorIn, vectorIn);
					JNIEnv.DeleteLocalRef (native_vectorIn);
				}
				if (vectorOut != null) {
					JNIEnv.CopyArray (native_vectorOut, vectorOut);
					JNIEnv.DeleteLocalRef (native_vectorOut);
				}
			}
		}

		static Delegate cb_toMatrix_arrayFI;
#pragma warning disable 0169
		static Delegate GetToMatrix_arrayFIHandler ()
		{
			if (cb_toMatrix_arrayFI == null)
				cb_toMatrix_arrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ToMatrix_arrayFI);
			return cb_toMatrix_arrayFI;
		}

		static void n_ToMatrix_arrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int offset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] dest = (float[]) JNIEnv.GetArray (native_dest, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.ToMatrix (dest, offset);
			if (dest != null)
				JNIEnv.CopyArray (dest, native_dest);
		}
#pragma warning restore 0169

		static IntPtr id_toMatrix_arrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='toMatrix' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register ("toMatrix", "([FI)V", "GetToMatrix_arrayFIHandler")]
		public virtual unsafe void ToMatrix (float[] dest, int offset)
		{
			if (id_toMatrix_arrayFI == IntPtr.Zero)
				id_toMatrix_arrayFI = JNIEnv.GetMethodID (class_ref, "toMatrix", "([FI)V");
			IntPtr native_dest = JNIEnv.NewArray (dest);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_dest);
				__args [1] = new JValue (offset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toMatrix_arrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toMatrix", "([FI)V"), __args);
			} finally {
				if (dest != null) {
					JNIEnv.CopyArray (native_dest, dest);
					JNIEnv.DeleteLocalRef (native_dest);
				}
			}
		}

		static Delegate cb_transformPoint_arrayF;
#pragma warning disable 0169
		static Delegate GetTransformPoint_arrayFHandler ()
		{
			if (cb_transformPoint_arrayF == null)
				cb_transformPoint_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TransformPoint_arrayF);
			return cb_transformPoint_arrayF;
		}

		static IntPtr n_TransformPoint_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_x)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] x = (float[]) JNIEnv.GetArray (native_x, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.NewArray (__this.TransformPoint (x));
			if (x != null)
				JNIEnv.CopyArray (x, native_x);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transformPoint_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='transformPoint' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("transformPoint", "([F)[F", "GetTransformPoint_arrayFHandler")]
		public virtual unsafe float[] TransformPoint (float[] x)
		{
			if (id_transformPoint_arrayF == IntPtr.Zero)
				id_transformPoint_arrayF = JNIEnv.GetMethodID (class_ref, "transformPoint", "([F)[F");
			IntPtr native_x = JNIEnv.NewArray (x);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_x);

				float[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transformPoint_arrayF, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					__ret = (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformPoint", "([F)[F"), __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
				if (x != null) {
					JNIEnv.CopyArray (native_x, x);
					JNIEnv.DeleteLocalRef (native_x);
				}
			}
		}

		static Delegate cb_transformPoint_arrayFIarrayFI;
#pragma warning disable 0169
		static Delegate GetTransformPoint_arrayFIarrayFIHandler ()
		{
			if (cb_transformPoint_arrayFIarrayFI == null)
				cb_transformPoint_arrayFIarrayFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_TransformPoint_arrayFIarrayFI);
			return cb_transformPoint_arrayFIarrayFI;
		}

		static void n_TransformPoint_arrayFIarrayFI (IntPtr jnienv, IntPtr native__this, IntPtr native_pointIn, int inOffset, IntPtr native_pointOut, int outOffset)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] pointIn = (float[]) JNIEnv.GetArray (native_pointIn, JniHandleOwnership.DoNotTransfer, typeof (float));
			float[] pointOut = (float[]) JNIEnv.GetArray (native_pointOut, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.TransformPoint (pointIn, inOffset, pointOut, outOffset);
			if (pointIn != null)
				JNIEnv.CopyArray (pointIn, native_pointIn);
			if (pointOut != null)
				JNIEnv.CopyArray (pointOut, native_pointOut);
		}
#pragma warning restore 0169

		static IntPtr id_transformPoint_arrayFIarrayFI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='transformPoint' and count(parameter)=4 and parameter[1][@type='float[]'] and parameter[2][@type='int'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
		[Register ("transformPoint", "([FI[FI)V", "GetTransformPoint_arrayFIarrayFIHandler")]
		public virtual unsafe void TransformPoint (float[] pointIn, int inOffset, float[] pointOut, int outOffset)
		{
			if (id_transformPoint_arrayFIarrayFI == IntPtr.Zero)
				id_transformPoint_arrayFIarrayFI = JNIEnv.GetMethodID (class_ref, "transformPoint", "([FI[FI)V");
			IntPtr native_pointIn = JNIEnv.NewArray (pointIn);
			IntPtr native_pointOut = JNIEnv.NewArray (pointOut);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_pointIn);
				__args [1] = new JValue (inOffset);
				__args [2] = new JValue (native_pointOut);
				__args [3] = new JValue (outOffset);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_transformPoint_arrayFIarrayFI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transformPoint", "([FI[FI)V"), __args);
			} finally {
				if (pointIn != null) {
					JNIEnv.CopyArray (native_pointIn, pointIn);
					JNIEnv.DeleteLocalRef (native_pointIn);
				}
				if (pointOut != null) {
					JNIEnv.CopyArray (native_pointOut, pointOut);
					JNIEnv.DeleteLocalRef (native_pointOut);
				}
			}
		}

		static Delegate cb_tx;
#pragma warning disable 0169
		static Delegate GetTxHandler ()
		{
			if (cb_tx == null)
				cb_tx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Tx);
			return cb_tx;
		}

		static float n_Tx (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tx ();
		}
#pragma warning restore 0169

		static IntPtr id_tx;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='tx' and count(parameter)=0]"
		[Register ("tx", "()F", "GetTxHandler")]
		public virtual unsafe float Tx ()
		{
			if (id_tx == IntPtr.Zero)
				id_tx = JNIEnv.GetMethodID (class_ref, "tx", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_tx);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tx", "()F"));
			} finally {
			}
		}

		static Delegate cb_ty;
#pragma warning disable 0169
		static Delegate GetTyHandler ()
		{
			if (cb_ty == null)
				cb_ty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Ty);
			return cb_ty;
		}

		static float n_Ty (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ty ();
		}
#pragma warning restore 0169

		static IntPtr id_ty;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='ty' and count(parameter)=0]"
		[Register ("ty", "()F", "GetTyHandler")]
		public virtual unsafe float Ty ()
		{
			if (id_ty == IntPtr.Zero)
				id_ty = JNIEnv.GetMethodID (class_ref, "ty", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_ty);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ty", "()F"));
			} finally {
			}
		}

		static Delegate cb_tz;
#pragma warning disable 0169
		static Delegate GetTzHandler ()
		{
			if (cb_tz == null)
				cb_tz = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Tz);
			return cb_tz;
		}

		static float n_Tz (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.Pose __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.Pose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tz ();
		}
#pragma warning restore 0169

		static IntPtr id_tz;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='Pose']/method[@name='tz' and count(parameter)=0]"
		[Register ("tz", "()F", "GetTzHandler")]
		public virtual unsafe float Tz ()
		{
			if (id_tz == IntPtr.Zero)
				id_tz = JNIEnv.GetMethodID (class_ref, "tz", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_tz);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tz", "()F"));
			} finally {
			}
		}

	}
}
