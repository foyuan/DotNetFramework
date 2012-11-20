// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMNavigator.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIDOMNavigator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0737ed5-89c5-4fe3-891e-a75bf3a1bb55")]
	public interface nsIDOMNavigator
	{
		
		/// <summary>Member GetAppCodeNameAttribute </summary>
		/// <param name='aAppCodeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppCodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppCodeName);
		
		/// <summary>Member GetAppNameAttribute </summary>
		/// <param name='aAppName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppName);
		
		/// <summary>Member GetAppVersionAttribute </summary>
		/// <param name='aAppVersion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aAppVersion);
		
		/// <summary>Member GetLanguageAttribute </summary>
		/// <param name='aLanguage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLanguageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLanguage);
		
		/// <summary>Member GetMimeTypesAttribute </summary>
		/// <returns>A nsIDOMMimeTypeArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMimeTypeArray GetMimeTypesAttribute();
		
		/// <summary>Member GetPlatformAttribute </summary>
		/// <param name='aPlatform'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPlatformAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPlatform);
		
		/// <summary>Member GetOscpuAttribute </summary>
		/// <param name='aOscpu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOscpuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOscpu);
		
		/// <summary>Member GetVendorAttribute </summary>
		/// <param name='aVendor'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVendor);
		
		/// <summary>Member GetVendorSubAttribute </summary>
		/// <param name='aVendorSub'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVendorSubAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVendorSub);
		
		/// <summary>Member GetProductAttribute </summary>
		/// <param name='aProduct'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aProduct);
		
		/// <summary>Member GetProductSubAttribute </summary>
		/// <param name='aProductSub'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetProductSubAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aProductSub);
		
		/// <summary>Member GetPluginsAttribute </summary>
		/// <returns>A nsIDOMPluginArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMPluginArray GetPluginsAttribute();
		
		/// <summary>Member GetUserAgentAttribute </summary>
		/// <param name='aUserAgent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserAgentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aUserAgent);
		
		/// <summary>Member GetCookieEnabledAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCookieEnabledAttribute();
		
		/// <summary>Member GetOnLineAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOnLineAttribute();
		
		/// <summary>Member GetBuildIDAttribute </summary>
		/// <param name='aBuildID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBuildIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBuildID);
		
		/// <summary>Member GetDoNotTrackAttribute </summary>
		/// <param name='aDoNotTrack'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDoNotTrackAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDoNotTrack);
		
		/// <summary>Member GetMozPowerAttribute </summary>
		/// <returns>A nsIDOMMozPowerManager</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozPowerManager GetMozPowerAttribute();
		
		/// <summary>Member JavaEnabled </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool JavaEnabled();
		
		/// <summary>Member TaintEnabled </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool TaintEnabled();
		
		/// <summary>
        /// Pulse the device's vibrator, if it has one.  If the device does not have a
        /// vibrator, this function does nothing.  If the window is hidden, this
        /// function does nothing.
        ///
        /// mozVibrate takes one argument, which specifies either how long to vibrate
        /// for or gives a pattern of vibrator-on/vibrator-off timings.
        ///
        /// If a vibration pattern is in effect when this function is called, this
        /// call will overwrite the existing pattern, if this call successfully
        /// completes.
        ///
        /// We handle the argument to mozVibrate as follows.
        ///
        /// - If the argument is undefined or null, we throw
        /// NS_ERROR_DOM_NOT_SUPPORTED_ERR.
        ///
        /// - If the argument is 0, the empty list, or a list containing entirely 0s,
        /// we cancel any outstanding vibration pattern; that is, we stop the device
        /// from vibrating.
        ///
        /// - Otherwise, if the argument X is not a list, we treat it as though it's
        /// the singleton list [X] and then proceed as below.
        ///
        /// - If the argument is a list (or if we wrapped it as a list above), then we
        /// try to convert each element in the list to an integer, by first
        /// converting it to a number and then rounding.  If there is some element
        /// that we can't convert to an integer, or if any of the integers are
        /// negative, we throw NS_ERROR_DOM_NOT_SUPPORTED_ERR.
        ///
        /// This list of integers specifies a vibration pattern.  Given a list of
        /// numbers
        ///
        /// [a_1, b_1, a_2, b_2, ..., a_n]
        ///
        /// the device will vibrate for a_1 milliseconds, then be still for b_1
        /// milliseconds, then vibrate for a_2 milliseconds, and so on.
        ///
        /// The list may contain an even or an odd number of elements, but if you
        /// pass an even number of elements (that is, if your list ends with b_n
        /// instead of a_n), the final element doesn't specify anything meaningful.
        ///
        /// We may throw NS_ERROR_DOM_NOT_SUPPORTED_ERR if the vibration pattern is
        /// too long, or if any of its elements is too large.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozVibrate(Gecko.JsVal aPattern, System.IntPtr jsContext);
		
		/// <summary>
        /// Request a wake lock for a resource.
        ///
        /// A page holds a wake lock to request that a resource not be turned
        /// off (or otherwise made unavailable).
        ///
        /// The topic is the name of a resource that might be made unavailable for
        /// various reasons. For example, on a mobile device the power manager might
        /// decide to turn off the screen after a period of idle time to save power.
        ///
        /// The resource manager checks the lock state of a topic before turning off
        /// the associated resource. For example, a page could hold a lock on the
        /// "screen" topic to prevent the screensaver from appearing or the screen
        /// from turning off.
        ///
        /// The resource manager defines what each topic means and sets policy.  For
        /// example, the resource manager might decide to ignore 'screen' wake locks
        /// held by pages which are not visible.
        ///
        /// One topic can be locked multiple times; it is considered released only when
        /// all locks on the topic have been released.
        ///
        /// The returned nsIDOMMozWakeLock object is a token of the lock.  You can
        /// unlock the lock via the object's |unlock| method.  The lock is released
        /// automatically when its associated window is unloaded.
        ///
        /// @param aTopic resource name
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMozWakeLock RequestWakeLock([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTopic);
	}
}
