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
// Generated by IDLImporter from file nsIURIFixup.idl
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
    /// Interface implemented by objects capable of fixing up strings into URIs
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("773081ac-9f81-4bdb-9e7a-5e87b4361f09")]
	public interface nsIURIFixup
	{
		
		/// <summary>
        /// Converts an internal URI (e.g. a wyciwyg URI) into one which we can
        /// expose to the user, for example on the URL bar.
        ///
        /// @param  aURI       The URI to be converted
        /// @return nsIURI     The converted, exposable URI
        /// @throws NS_ERROR_MALFORMED_URI when the exposable portion of aURI is malformed
        /// @throws NS_ERROR_UNKNOWN_PROTOCOL when we can't get a protocol handler service
        /// for the URI scheme.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI CreateExposableURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Converts the specified string into a URI, first attempting
        /// to correct any errors in the syntax or other vagaries. Returns
        /// a wellformed URI or nsnull if it can't.
        ///
        /// @param aURIText    Candidate URI.
        /// @param aFixupFlags Flags that govern ways the URI may be fixed up.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI CreateFixupURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIText, uint aFixupFlags);
		
		/// <summary>
        /// Converts the specified keyword string into a URI.  Note that it's the
        /// caller's responsibility to check whether keywords are enabled and
        /// whether aKeyword is a sensible keyword.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI KeywordToURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKeyword);
	}
	
	/// <summary>nsIURIFixupConsts </summary>
	public class nsIURIFixupConsts
	{
		
		// <summary>
        //No fixup flags. </summary>
		public const ulong FIXUP_FLAG_NONE = 0;
		
		// <summary>
        // Allow the fixup to use a keyword lookup service to complete the URI.
        // The fixup object implementer should honour this flag and only perform
        // any lengthy keyword (or search) operation if it is set.
        // </summary>
		public const ulong FIXUP_FLAG_ALLOW_KEYWORD_LOOKUP = 1;
		
		// <summary>
        // Tell the fixup to make an alternate URI from the input URI, for example
        // to turn foo into www.foo.com.
        // </summary>
		public const ulong FIXUP_FLAGS_MAKE_ALTERNATE_URI = 2;
		
		// <summary>
        // Use UTF-8 to encode the URI instead of platform charset.
        // </summary>
		public const ulong FIXUP_FLAG_USE_UTF8 = 4;
	}
}
