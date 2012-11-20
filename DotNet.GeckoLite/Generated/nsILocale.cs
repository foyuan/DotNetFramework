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
// Generated by IDLImporter from file nsILocale.idl
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
    /// Represents one locale, which can be used for things like sorting text strings
    /// and formatting numbers, dates and times.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21035ee0-4556-11d3-91cd-00105aa3f7dc")]
	public interface nsILocale
	{
		
		/// <summary>
        /// Get the locale code for a given category.
        ///
        /// A locale code is of the form language[-COUNTRY[-region]], where
        /// "language" is an ISO 639 language code (two letter codes preferred over
        /// three letter codes when available), "COUNTRY" is an ISO 3166 two letter
        /// country code, and "region" is a string of up to 5 letters.
        ///
        /// A category is one of the following:
        /// NSILOCALE_CTYPE: Character classification and case conversion.
        /// NSILOCALE_COLLATE: Collation order. How strings are sorted.
        /// NSILOCALE_MONETARY: Monetary formatting.
        /// NSILOCALE_NUMERIC: Numeric, non-monetary formatting.
        /// NSILOCALE_TIME: Date and time formats.
        /// NSILOCALE_MESSAGES: Related to fonts, character encodings etc.
        ///
        /// @param category
        /// The category of interest.
        /// @return The locale code to be used for the given category.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCategory([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase category, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
}
