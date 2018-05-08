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
						"com/google/android/aidl",
						"com/google/android/play/core/install/protocol",
						"com/google/ar/core",
						"com/google/ar/core/exceptions",
						"com/google/vr/dynamite/client",
					},
					new Converter<string, Type>[]{
						lookup_com_google_android_aidl_package,
						lookup_com_google_android_play_core_install_protocol_package,
						lookup_com_google_ar_core_package,
						lookup_com_google_ar_core_exceptions_package,
						lookup_com_google_vr_dynamite_client_package,
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

		static string[] package_com_google_android_aidl_mappings;
		static Type lookup_com_google_android_aidl_package (string klass)
		{
			if (package_com_google_android_aidl_mappings == null) {
				package_com_google_android_aidl_mappings = new string[]{
					"com/google/android/aidl/BaseProxy:Google.Android.Aidl.BaseProxy",
					"com/google/android/aidl/BaseStub:Google.Android.Aidl.BaseStub",
					"com/google/android/aidl/Codecs:Google.Android.Aidl.Codecs",
				};
			}

			return Lookup (package_com_google_android_aidl_mappings, klass);
		}

		static string[] package_com_google_android_play_core_install_protocol_mappings;
		static Type lookup_com_google_android_play_core_install_protocol_package (string klass)
		{
			if (package_com_google_android_play_core_install_protocol_mappings == null) {
				package_com_google_android_play_core_install_protocol_mappings = new string[]{
					"com/google/android/play/core/install/protocol/IInstallService$Stub:Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub",
					"com/google/android/play/core/install/protocol/IInstallService$Stub$Proxy:Com.Google.Android.Play.Core.Install.Protocol.InstallServiceStub/Proxy",
					"com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub:Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub",
					"com/google/android/play/core/install/protocol/IInstallServiceCallback$Stub$Proxy:Com.Google.Android.Play.Core.Install.Protocol.InstallServiceCallbackStub/Proxy",
				};
			}

			return Lookup (package_com_google_android_play_core_install_protocol_mappings, klass);
		}

		static string[] package_com_google_ar_core_mappings;
		static Type lookup_com_google_ar_core_package (string klass)
		{
			if (package_com_google_ar_core_mappings == null) {
				package_com_google_ar_core_mappings = new string[]{
					"com/google/ar/core/Anchor:Google.AR.Core.Anchor",
					"com/google/ar/core/ArCoreApk:Google.AR.Core.ArCoreApk",
					"com/google/ar/core/ArCoreApk$Availability:Google.AR.Core.ArCoreApk/Availability",
					"com/google/ar/core/ArCoreApk$InstallBehavior:Google.AR.Core.ArCoreApk/InstallBehavior",
					"com/google/ar/core/ArCoreApk$InstallStatus:Google.AR.Core.ArCoreApk/InstallStatus",
					"com/google/ar/core/ArCoreApk$UserMessageType:Google.AR.Core.ArCoreApk/UserMessageType",
					"com/google/ar/core/Camera:Google.AR.Core.Camera",
					"com/google/ar/core/Config:Google.AR.Core.Config",
					"com/google/ar/core/Config$LightEstimationMode:Google.AR.Core.Config/LightEstimationMode",
					"com/google/ar/core/Config$PlaneFindingMode:Google.AR.Core.Config/PlaneFindingMode",
					"com/google/ar/core/Config$UpdateMode:Google.AR.Core.Config/UpdateMode",
					"com/google/ar/core/Frame:Google.AR.Core.Frame",
					"com/google/ar/core/HitResult:Google.AR.Core.HitResult",
					"com/google/ar/core/ImageMetadata:Google.AR.Core.ImageMetadata",
					"com/google/ar/core/ImageMetadata$MetadataEntry:Google.AR.Core.ImageMetadata/MetadataEntry",
					"com/google/ar/core/InstallActivity:Google.AR.Core.InstallActivity",
					"com/google/ar/core/LightEstimate:Google.AR.Core.LightEstimate",
					"com/google/ar/core/LightEstimate$State:Google.AR.Core.LightEstimate/State",
					"com/google/ar/core/Plane:Google.AR.Core.Plane",
					"com/google/ar/core/Plane$Type:Google.AR.Core.Plane/Type",
					"com/google/ar/core/Point:Google.AR.Core.Point",
					"com/google/ar/core/Point$OrientationMode:Google.AR.Core.Point/OrientationMode",
					"com/google/ar/core/PointCloud:Google.AR.Core.PointCloud",
					"com/google/ar/core/Pose:Google.AR.Core.Pose",
					"com/google/ar/core/Session:Google.AR.Core.Session",
					"com/google/ar/core/TrackableBase:Google.AR.Core.TrackableBase",
					"com/google/ar/core/TrackingState:Google.AR.Core.TrackingState",
				};
			}

			return Lookup (package_com_google_ar_core_mappings, klass);
		}

		static string[] package_com_google_ar_core_exceptions_mappings;
		static Type lookup_com_google_ar_core_exceptions_package (string klass)
		{
			if (package_com_google_ar_core_exceptions_mappings == null) {
				package_com_google_ar_core_exceptions_mappings = new string[]{
					"com/google/ar/core/exceptions/CameraNotAvailableException:Google.AR.Core.Exceptions.CameraNotAvailableException",
					"com/google/ar/core/exceptions/DeadlineExceededException:Google.AR.Core.Exceptions.DeadlineExceededException",
					"com/google/ar/core/exceptions/FatalException:Google.AR.Core.Exceptions.FatalException",
					"com/google/ar/core/exceptions/MissingGlContextException:Google.AR.Core.Exceptions.MissingGlContextException",
					"com/google/ar/core/exceptions/NotTrackingException:Google.AR.Core.Exceptions.NotTrackingException",
					"com/google/ar/core/exceptions/NotYetAvailableException:Google.AR.Core.Exceptions.NotYetAvailableException",
					"com/google/ar/core/exceptions/ResourceExhaustedException:Google.AR.Core.Exceptions.ResourceExhaustedException",
					"com/google/ar/core/exceptions/SessionNotPausedException:Google.AR.Core.Exceptions.SessionNotPausedException",
					"com/google/ar/core/exceptions/SessionPausedException:Google.AR.Core.Exceptions.SessionPausedException",
					"com/google/ar/core/exceptions/TextureNotSetException:Google.AR.Core.Exceptions.TextureNotSetException",
					"com/google/ar/core/exceptions/UnavailableApkTooOldException:Google.AR.Core.Exceptions.UnavailableApkTooOldException",
					"com/google/ar/core/exceptions/UnavailableArcoreNotInstalledException:Google.AR.Core.Exceptions.UnavailableArcoreNotInstalledException",
					"com/google/ar/core/exceptions/UnavailableDeviceNotCompatibleException:Google.AR.Core.Exceptions.UnavailableDeviceNotCompatibleException",
					"com/google/ar/core/exceptions/UnavailableException:Google.AR.Core.Exceptions.UnavailableException",
					"com/google/ar/core/exceptions/UnavailableSdkTooOldException:Google.AR.Core.Exceptions.UnavailableSdkTooOldException",
					"com/google/ar/core/exceptions/UnavailableUserDeclinedInstallationException:Google.AR.Core.Exceptions.UnavailableUserDeclinedInstallationException",
					"com/google/ar/core/exceptions/UnsupportedConfigurationException:Google.AR.Core.Exceptions.UnsupportedConfigurationException",
				};
			}

			return Lookup (package_com_google_ar_core_exceptions_mappings, klass);
		}

		static string[] package_com_google_vr_dynamite_client_mappings;
		static Type lookup_com_google_vr_dynamite_client_package (string klass)
		{
			if (package_com_google_vr_dynamite_client_mappings == null) {
				package_com_google_vr_dynamite_client_mappings = new string[]{
					"com/google/vr/dynamite/client/DynamiteClient:Google.VR.Dynamite.Client.DynamiteClient",
					"com/google/vr/dynamite/client/DynamiteConstants:Google.VR.Dynamite.Client.DynamiteConstants",
					"com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub:Google.VR.Dynamite.Client.LoadedInstanceCreatorStub",
					"com/google/vr/dynamite/client/ILoadedInstanceCreator$Stub$Proxy:Google.VR.Dynamite.Client.LoadedInstanceCreatorStub/Proxy",
					"com/google/vr/dynamite/client/INativeLibraryLoader$Stub:Google.VR.Dynamite.Client.NativeLibraryLoaderStub",
					"com/google/vr/dynamite/client/INativeLibraryLoader$Stub$Proxy:Google.VR.Dynamite.Client.NativeLibraryLoaderStub/Proxy",
					"com/google/vr/dynamite/client/IObjectWrapper$Stub:Google.VR.Dynamite.Client.ObjectWrapperStub",
					"com/google/vr/dynamite/client/IObjectWrapper$Stub$Proxy:Google.VR.Dynamite.Client.ObjectWrapperStub/Proxy",
					"com/google/vr/dynamite/client/LoaderException:Google.VR.Dynamite.Client.LoaderException",
					"com/google/vr/dynamite/client/ObjectWrapper:Google.VR.Dynamite.Client.ObjectWrapper",
					"com/google/vr/dynamite/client/Version:Google.VR.Dynamite.Client.Version",
				};
			}

			return Lookup (package_com_google_vr_dynamite_client_mappings, klass);
		}
	}
}
