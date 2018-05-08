using System;

namespace Google.VR.Dynamite.Client {

	[global::Android.Runtime.Annotation ("com.google.vr.dynamite.client.UsedByReflection")]
	public partial class UsedByReflectionAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
