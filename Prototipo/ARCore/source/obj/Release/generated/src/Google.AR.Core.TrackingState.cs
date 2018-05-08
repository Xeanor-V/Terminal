using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.AR.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']"
	[global::Android.Runtime.Register ("com/google/ar/core/TrackingState", DoNotGenerateAcw=true)]
	public sealed partial class TrackingState : global::Java.Lang.Enum {


		static IntPtr PAUSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Google.AR.Core.TrackingState Paused {
			get {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/google/ar/core/TrackingState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STOPPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='STOPPED']"
		[Register ("STOPPED")]
		public static global::Google.AR.Core.TrackingState Stopped {
			get {
				if (STOPPED_jfieldId == IntPtr.Zero)
					STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/google/ar/core/TrackingState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TRACKING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/field[@name='TRACKING']"
		[Register ("TRACKING")]
		public static global::Google.AR.Core.TrackingState Tracking {
			get {
				if (TRACKING_jfieldId == IntPtr.Zero)
					TRACKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACKING", "Lcom/google/ar/core/TrackingState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACKING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ar/core/TrackingState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackingState); }
		}

		internal TrackingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/TrackingState;", "")]
		public static unsafe global::Google.AR.Core.TrackingState ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ar/core/TrackingState;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Google.AR.Core.TrackingState __ret = global::Java.Lang.Object.GetObject<global::Google.AR.Core.TrackingState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ar.core']/class[@name='TrackingState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/ar/core/TrackingState;", "")]
		public static unsafe global::Google.AR.Core.TrackingState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ar/core/TrackingState;");
			try {
				return (global::Google.AR.Core.TrackingState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Google.AR.Core.TrackingState));
			} finally {
			}
		}

	}
}
