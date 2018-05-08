using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Google.Android.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']"
	[global::Android.Runtime.Register ("com/google/android/aidl/Codecs", DoNotGenerateAcw=true)]
	public partial class Codecs : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/aidl/Codecs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Codecs); }
		}

		protected Codecs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createBoolean_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='createBoolean' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createBoolean", "(Landroid/os/Parcel;)Z", "")]
		public static unsafe bool CreateBoolean (global::Android.OS.Parcel parcel)
		{
			if (id_createBoolean_Landroid_os_Parcel_ == IntPtr.Zero)
				id_createBoolean_Landroid_os_Parcel_ = JNIEnv.GetStaticMethodID (class_ref, "createBoolean", "(Landroid/os/Parcel;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parcel);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_createBoolean_Landroid_os_Parcel_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createCharSequence_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='createCharSequence' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createCharSequence", "(Landroid/os/Parcel;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence CreateCharSequenceFormatted (global::Android.OS.Parcel parcel)
		{
			if (id_createCharSequence_Landroid_os_Parcel_ == IntPtr.Zero)
				id_createCharSequence_Landroid_os_Parcel_ = JNIEnv.GetStaticMethodID (class_ref, "createCharSequence", "(Landroid/os/Parcel;)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parcel);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCharSequence_Landroid_os_Parcel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		public static string CreateCharSequence (global::Android.OS.Parcel parcel)
		{
			global::Java.Lang.ICharSequence __result = CreateCharSequenceFormatted (parcel);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_createList_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='createList' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createList", "(Landroid/os/Parcel;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.IList CreateList (global::Android.OS.Parcel parcel)
		{
			if (id_createList_Landroid_os_Parcel_ == IntPtr.Zero)
				id_createList_Landroid_os_Parcel_ = JNIEnv.GetStaticMethodID (class_ref, "createList", "(Landroid/os/Parcel;)Ljava/util/ArrayList;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parcel);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_createList_Landroid_os_Parcel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createMap_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='createMap' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("createMap", "(Landroid/os/Parcel;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.IDictionary CreateMap (global::Android.OS.Parcel parcel)
		{
			if (id_createMap_Landroid_os_Parcel_ == IntPtr.Zero)
				id_createMap_Landroid_os_Parcel_ = JNIEnv.GetStaticMethodID (class_ref, "createMap", "(Landroid/os/Parcel;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parcel);
				global::System.Collections.IDictionary __ret = global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_createMap_Landroid_os_Parcel_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_Creator_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='createParcelable' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='android.os.Parcelable.Creator&lt;T&gt;']]"
		[Register ("createParcelable", "(Landroid/os/Parcel;Landroid/os/Parcelable$Creator;)Landroid/os/Parcelable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends android.os.Parcelable"})]
		public static unsafe global::Java.Lang.Object CreateParcelable (global::Android.OS.Parcel parcel, global::Android.OS.IParcelableCreator creator)
		{
			if (id_createParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_Creator_ == IntPtr.Zero)
				id_createParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_Creator_ = JNIEnv.GetStaticMethodID (class_ref, "createParcelable", "(Landroid/os/Parcel;Landroid/os/Parcelable$Creator;)Landroid/os/Parcelable;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (creator);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_Creator_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readList_Landroid_os_Parcel_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='readList' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='java.util.List&lt;?&gt;']]"
		[Register ("readList", "(Landroid/os/Parcel;Ljava/util/List;)V", "")]
		public static unsafe void ReadList (global::Android.OS.Parcel parcel, global::System.Collections.Generic.IList<object> list)
		{
			if (id_readList_Landroid_os_Parcel_Ljava_util_List_ == IntPtr.Zero)
				id_readList_Landroid_os_Parcel_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "readList", "(Landroid/os/Parcel;Ljava/util/List;)V");
			IntPtr native_list = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (list);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (native_list);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readList_Landroid_os_Parcel_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		static IntPtr id_readMap_Landroid_os_Parcel_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='readMap' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='java.util.Map&lt;?, ?&gt;']]"
		[Register ("readMap", "(Landroid/os/Parcel;Ljava/util/Map;)V", "")]
		public static unsafe void ReadMap (global::Android.OS.Parcel parcel, global::System.Collections.Generic.IDictionary<object, object> map)
		{
			if (id_readMap_Landroid_os_Parcel_Ljava_util_Map_ == IntPtr.Zero)
				id_readMap_Landroid_os_Parcel_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "readMap", "(Landroid/os/Parcel;Ljava/util/Map;)V");
			IntPtr native_map = global::Android.Runtime.JavaDictionary<object, object>.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (native_map);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_readMap_Landroid_os_Parcel_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static IntPtr id_writeBoolean_Landroid_os_Parcel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeBoolean' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='boolean']]"
		[Register ("writeBoolean", "(Landroid/os/Parcel;Z)V", "")]
		public static unsafe void WriteBoolean (global::Android.OS.Parcel parcel, bool value)
		{
			if (id_writeBoolean_Landroid_os_Parcel_Z == IntPtr.Zero)
				id_writeBoolean_Landroid_os_Parcel_Z = JNIEnv.GetStaticMethodID (class_ref, "writeBoolean", "(Landroid/os/Parcel;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (value);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeBoolean_Landroid_os_Parcel_Z, __args);
			} finally {
			}
		}

		static IntPtr id_writeCharSequence_Landroid_os_Parcel_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeCharSequence' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("writeCharSequence", "(Landroid/os/Parcel;Ljava/lang/CharSequence;)V", "")]
		public static unsafe void WriteCharSequence (global::Android.OS.Parcel parcel, global::Java.Lang.ICharSequence charSequence)
		{
			if (id_writeCharSequence_Landroid_os_Parcel_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_writeCharSequence_Landroid_os_Parcel_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "writeCharSequence", "(Landroid/os/Parcel;Ljava/lang/CharSequence;)V");
			IntPtr native_charSequence = CharSequence.ToLocalJniHandle (charSequence);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (native_charSequence);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeCharSequence_Landroid_os_Parcel_Ljava_lang_CharSequence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_charSequence);
			}
		}

		public static void WriteCharSequence (global::Android.OS.Parcel parcel, string charSequence)
		{
			global::Java.Lang.String jls_charSequence = charSequence == null ? null : new global::Java.Lang.String (charSequence);
			WriteCharSequence (parcel, jls_charSequence);
			if (jls_charSequence != null) jls_charSequence.Dispose ();
		}

		static IntPtr id_writeCharSequenceAsReturnValue_Landroid_os_Parcel_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeCharSequenceAsReturnValue' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("writeCharSequenceAsReturnValue", "(Landroid/os/Parcel;Ljava/lang/CharSequence;)V", "")]
		public static unsafe void WriteCharSequenceAsReturnValue (global::Android.OS.Parcel parcel, global::Java.Lang.ICharSequence charSequence)
		{
			if (id_writeCharSequenceAsReturnValue_Landroid_os_Parcel_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_writeCharSequenceAsReturnValue_Landroid_os_Parcel_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "writeCharSequenceAsReturnValue", "(Landroid/os/Parcel;Ljava/lang/CharSequence;)V");
			IntPtr native_charSequence = CharSequence.ToLocalJniHandle (charSequence);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (native_charSequence);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeCharSequenceAsReturnValue_Landroid_os_Parcel_Ljava_lang_CharSequence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_charSequence);
			}
		}

		public static void WriteCharSequenceAsReturnValue (global::Android.OS.Parcel parcel, string charSequence)
		{
			global::Java.Lang.String jls_charSequence = charSequence == null ? null : new global::Java.Lang.String (charSequence);
			WriteCharSequenceAsReturnValue (parcel, jls_charSequence);
			if (jls_charSequence != null) jls_charSequence.Dispose ();
		}

		static IntPtr id_writeParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeParcelable' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='android.os.Parcelable']]"
		[Register ("writeParcelable", "(Landroid/os/Parcel;Landroid/os/Parcelable;)V", "")]
		public static unsafe void WriteParcelable (global::Android.OS.Parcel parcel, global::Android.OS.IParcelable parcelable)
		{
			if (id_writeParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_writeParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_ = JNIEnv.GetStaticMethodID (class_ref, "writeParcelable", "(Landroid/os/Parcel;Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (parcelable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeParcelable_Landroid_os_Parcel_Landroid_os_Parcelable_, __args);
			} finally {
			}
		}

		static IntPtr id_writeParcelableAsReturnValue_Landroid_os_Parcel_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeParcelableAsReturnValue' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='android.os.Parcelable']]"
		[Register ("writeParcelableAsReturnValue", "(Landroid/os/Parcel;Landroid/os/Parcelable;)V", "")]
		public static unsafe void WriteParcelableAsReturnValue (global::Android.OS.Parcel parcel, global::Android.OS.IParcelable parcelable)
		{
			if (id_writeParcelableAsReturnValue_Landroid_os_Parcel_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_writeParcelableAsReturnValue_Landroid_os_Parcel_Landroid_os_Parcelable_ = JNIEnv.GetStaticMethodID (class_ref, "writeParcelableAsReturnValue", "(Landroid/os/Parcel;Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (parcelable);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeParcelableAsReturnValue_Landroid_os_Parcel_Landroid_os_Parcelable_, __args);
			} finally {
			}
		}

		static IntPtr id_writeStrongBinder_Landroid_os_Parcel_Landroid_os_IInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.aidl']/class[@name='Codecs']/method[@name='writeStrongBinder' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='android.os.IInterface']]"
		[Register ("writeStrongBinder", "(Landroid/os/Parcel;Landroid/os/IInterface;)V", "")]
		public static unsafe void WriteStrongBinder (global::Android.OS.Parcel parcel, global::Android.OS.IInterface iinterface)
		{
			if (id_writeStrongBinder_Landroid_os_Parcel_Landroid_os_IInterface_ == IntPtr.Zero)
				id_writeStrongBinder_Landroid_os_Parcel_Landroid_os_IInterface_ = JNIEnv.GetStaticMethodID (class_ref, "writeStrongBinder", "(Landroid/os/Parcel;Landroid/os/IInterface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue (iinterface);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStrongBinder_Landroid_os_Parcel_Landroid_os_IInterface_, __args);
			} finally {
			}
		}

	}
}
