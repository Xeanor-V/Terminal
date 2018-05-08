using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"de/javagl/obj",
					},
					new Converter<string, Type>[]{
						lookup_de_javagl_obj_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_de_javagl_obj_mappings;
		static Type lookup_de_javagl_obj_package (string klass)
		{
			if (package_de_javagl_obj_mappings == null) {
				package_de_javagl_obj_mappings = new string[]{
					"de/javagl/obj/AbstractWritableObj:JavaGl.Obj.AbstractWritableObj",
					"de/javagl/obj/BasicWritableObj:JavaGl.Obj.BasicWritableObj",
					"de/javagl/obj/FloatTuples:JavaGl.Obj.FloatTuples",
					"de/javagl/obj/MtlReader:JavaGl.Obj.MtlReader",
					"de/javagl/obj/Mtls:JavaGl.Obj.Mtls",
					"de/javagl/obj/MtlWriter:JavaGl.Obj.MtlWriter",
					"de/javagl/obj/ObjData:JavaGl.Obj.ObjData",
					"de/javagl/obj/ObjFaces:JavaGl.Obj.ObjFaces",
					"de/javagl/obj/ObjReader:JavaGl.Obj.ObjReader",
					"de/javagl/obj/Objs:JavaGl.Obj.Objs",
					"de/javagl/obj/ObjUtils:JavaGl.Obj.ObjUtils",
					"de/javagl/obj/ObjWriter:JavaGl.Obj.ObjWriter",
				};
			}

			return Lookup (package_de_javagl_obj_mappings, klass);
		}
	}
}
