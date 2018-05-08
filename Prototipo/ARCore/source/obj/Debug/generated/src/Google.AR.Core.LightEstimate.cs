using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']"
	[global::Android.Runtime.Register ("com/google/ar/core/LightEstimate", DoNotGenerateAcw=true)]
	public partial class LightEstimate : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']"
		[global::Android.Runtime.Register ("com/google/ar/core/LightEstimate$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr NOT_VALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/field[@name='NOT_VALID']"
			[Register ("NOT_VALID")]
			public static global::Google.AR.Core.LightEstimate.State NotValid {
				get {
					if (NOT_VALID_jfieldId == IntPtr.Zero)
						NOT_VALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_VALID", "Lcom/google/ar/core/LightEstimate$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_VALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/field[@name='VALID']"
			[Register ("VALID")]
			public static global::Google.AR.Core.LightEstimate.State Valid {
				get {
					if (VALID_jfieldId == IntPtr.Zero)
						VALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VALID", "Lcom/google/ar/core/LightEstimate$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/ar/core/LightEstimate$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/LightEstimate$State;", "")]
			public static unsafe global::Google.AR.Core.LightEstimate.State ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/LightEstimate$State;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Google.AR.Core.LightEstimate.State __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/google/ar/core/LightEstimate$State;", "")]
			public static unsafe global::Google.AR.Core.LightEstimate.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/LightEstimate$State;");
				try {
					return (global::Google.AR.Core.LightEstimate.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.LightEstimate.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/LightEstimate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightEstimate); }
		}

		protected LightEstimate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/constructor[@name='LightEstimate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe LightEstimate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LightEstimate)) {
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

		static Delegate cb_getPixelIntensity;
#pragma warning disable 0169
		static Delegate GetGetPixelIntensityHandler ()
		{
			if (cb_getPixelIntensity == null)
				cb_getPixelIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPixelIntensity);
			return cb_getPixelIntensity;
		}

		static float n_GetPixelIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PixelIntensity;
		}
#pragma warning restore 0169

		static IntPtr id_getPixelIntensity;
		public virtual unsafe float PixelIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getPixelIntensity' and count(parameter)=0]"
			[Register ("getPixelIntensity", "()F", "GetGetPixelIntensityHandler")]
			get {
				if (id_getPixelIntensity == IntPtr.Zero)
					id_getPixelIntensity = JNIEnv.GetMethodID (class_ref, "getPixelIntensity", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPixelIntensity);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelIntensity", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Google.AR.Core.LightEstimate __this = global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='LightEstimate']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/google/ar/core/LightEstimate$State;", "GetGetStateHandler")]
		public virtual unsafe global::Google.AR.Core.LightEstimate.State GetState ()
		{
			if (id_getState == IntPtr.Zero)
				id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()Lcom/google/ar/core/LightEstimate$State;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Google.AR.Core.LightEstimate.State> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()Lcom/google/ar/core/LightEstimate$State;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
