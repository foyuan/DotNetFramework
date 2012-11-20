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
// Generated by IDLImporter from file nsIGlobalHistory2.idl
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
	
	
	/// <summary>
    /// Provides information about global history to gecko.
    ///
    /// @note  This interface replaces and deprecates nsIGlobalHistory.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cf777d42-1270-4b34-be7b-2931c93feda5")]
	public interface nsIGlobalHistory2
	{
		
		/// <summary>
        /// Add a URI to global history
        ///
        /// @param aURI      the URI of the page
        /// @param aRedirect whether the URI was redirected to another location;
        /// this is 'true' for the original URI which is
        /// redirected.
        /// @param aToplevel whether the URI is loaded in a top-level window
        /// @param aReferrer the URI of the referring page
        ///
        /// @note  Docshell will not filter out URI schemes like chrome: data:
        /// about: and view-source:.  Embedders should consider filtering out
        /// these schemes and others, e.g. mailbox: for the main URI and the
        /// referrer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.U1)] bool aRedirect, [MarshalAs(UnmanagedType.U1)] bool aToplevel, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
		
		/// <summary>
        /// Checks to see whether the given URI is in history.
        ///
        /// @param aURI the uri to the page
        /// @return true if a URI has been visited
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsVisited([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Set the page title for the given uri. URIs that are not already in
        /// global history will not be added.
        ///
        /// @param aURI    the URI for which to set to the title
        /// @param aTitle  the page title
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageTitle([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
	}
}
