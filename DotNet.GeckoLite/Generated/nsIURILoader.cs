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
// Generated by IDLImporter from file nsIURILoader.idl
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
    /// The uri dispatcher is responsible for taking uri's, determining
    /// the content and routing the opened url to the correct content
    /// handler.
    ///
    /// When you encounter a url you want to open, you typically call
    /// openURI, passing it the content listener for the window the uri is
    /// originating from. The uri dispatcher opens the url to discover the
    /// content type. It then gives the content listener first crack at
    /// handling the content. If it doesn't want it, the dispatcher tries
    /// to hand it off one of the registered content listeners. This allows
    /// running applications the chance to jump in and handle the content.
    ///
    /// If that also fails, then the uri dispatcher goes to the registry
    /// looking for the preferred content handler for the content type
    /// of the uri. The content handler may create an app instance
    /// or it may hand the contents off to a platform specific plugin
    /// or helper app. Or it may hand the url off to an OS registered
    /// application.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2f7e8051-f1c9-4bcc-8584-9cfd5849e343")]
	public interface nsIURILoader
	{
		
		/// <summary>
        /// As applications such as messenger and the browser are instantiated,
        /// they register content listener's with the uri dispatcher corresponding
        /// to content windows within that application.
        ///
        /// Note to self: we may want to optimize things a bit more by requiring
        /// the content types the registered content listener cares about.
        ///
        /// @param aContentListener
        /// The listener to register. This listener must implement
        /// nsISupportsWeakReference.
        ///
        /// @see the nsIURILoader class description
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aContentListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnRegisterContentListener([MarshalAs(UnmanagedType.Interface)] nsIURIContentListener aContentListener);
		
		/// <summary>
        /// OpenURI requires the following parameters.....
        /// @param aChannel
        /// The channel that should be opened. This must not be asyncOpen'd yet!
        /// If a loadgroup is set on the channel, it will get replaced with a
        /// different one.
        /// @param aIsContentPreferred
        /// Should the content be displayed in a container that prefers the
        /// content-type, or will any container do.
        /// @param aWindowContext
        /// If you are running the url from a doc shell or a web shell, this is
        /// your window context. If you have a content listener you want to
        /// give first crack to, the uri loader needs to be able to get it
        /// from the window context. We will also be using the window context
        /// to get at the progress event sink interface.
        /// <b>Must not be null!</b>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenURI([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.U1)] bool aIsContentPreferred, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>
        /// Loads data from a channel. This differs from openURI in that the channel
        /// may already be opened, and that it returns a stream listener into which the
        /// caller should pump data. The caller is responsible for opening the channel
        /// and pumping the channel's data into the returned stream listener.
        ///
        /// Note: If the channel already has a loadgroup, it will be replaced with the
        /// window context's load group, or null if the context doesn't have one.
        ///
        /// If the window context's nsIURIContentListener refuses the load immediately
        /// (e.g. in nsIURIContentListener::onStartURIOpen), this method will return
        /// NS_ERROR_WONT_HANDLE_CONTENT. At that point, the caller should probably
        /// cancel the channel if it's already open (this method will not cancel the
        /// channel).
        ///
        /// If flags include DONT_RETARGET, and the content listener refuses the load
        /// during onStartRequest (e.g. in canHandleContent/isPreferred), then the
        /// returned stream listener's onStartRequest method will return
        /// NS_ERROR_WONT_HANDLE_CONTENT.
        ///
        /// @param aChannel
        /// The channel that should be loaded. The channel may already be
        /// opened. It must not be closed (i.e. this must be called before the
        /// channel calls onStopRequest on its stream listener).
        /// @param aFlags
        /// Combination (bitwise OR) of the flags specified above. 0 indicates
        /// default handling.
        /// @param aWindowContext
        /// If you are running the url from a doc shell or a web shell, this is
        /// your window context. If you have a content listener you want to
        /// give first crack to, the uri loader needs to be able to get it
        /// from the window context. We will also be using the window context
        /// to get at the progress event sink interface.
        /// <b>Must not be null!</b>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener OpenChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext);
		
		/// <summary>
        /// Stops an in progress load
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop([MarshalAs(UnmanagedType.Interface)] nsISupports aLoadCookie);
	}
	
	/// <summary>nsIURILoaderConsts </summary>
	public class nsIURILoaderConsts
	{
		
		// <summary>
        // Should the content be displayed in a container that prefers the
        // content-type, or will any container do.
        // </summary>
		public const ulong IS_CONTENT_PREFERRED = 1<<0;
		
		// <summary>
        // If this flag is set, only the listener of the specified window context will
        // be considered for content handling; if it refuses the load, an error will
        // be indicated.
        // </summary>
		public const ulong DONT_RETARGET = 1<<1;
	}
}
