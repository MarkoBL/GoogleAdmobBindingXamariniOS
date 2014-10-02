using System;
using System.Drawing;

#if UNIFIED
using CoreGraphics;
#endif

namespace GoogleAdMobAds
{
	//GADRequest file	
	public enum GADGender 
	{	
		Unknown,
		Male,
		Female
	}
	
	//GADRequestError file
	public enum GADErrorCode 
	{	
		InvalidRequest,
		NoFill,
		NetworkError,
		ServerError,
		OSVersionTooLow,
		Timeout,
		InterstitialAlreadyUsed,
		MediationDataError,
		MediationAdapterError,
		MediationNoFill,
		MediationInvalidAdSize
	}
	
	public enum GADSearchBorderType 
	{	
		None,
		Dashed,
		Dotted,
		Solid
	}
	
	public struct GADAdSize
	{
		#if UNIFIED
		public CGSize size;
		#else
		public SizeF size;
		#endif
		public uint flags;
	}

	public enum GADSearchCallButtonColor
	{
		Light,
		Medium,
		Dark
	}
}