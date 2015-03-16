using System;
using System.Runtime.InteropServices;
using System.Drawing;

#if UNIFIED
using ObjCRuntime;
using Foundation;
using CoreGraphics;
#else
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;
#endif

namespace GoogleAdMobAds
{
	public partial class GADRequest
	{
		public static readonly string GADGoogleAdMobNetworkName = "GoogleAdMobAds";
	}
	
	public partial class GADRequestError
	{
		private static string kGADErrorDomain;
		
		public static string ErrorDomain
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGADErrorDomain = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kGADErrorDomain");
				
				return kGADErrorDomain;
			}
			set 
			{
				kGADErrorDomain = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kGADErrorDomain");
				
				Marshal.WriteIntPtr(ptr, new NSString(kGADErrorDomain).Handle);

			}
		}
	}
}

