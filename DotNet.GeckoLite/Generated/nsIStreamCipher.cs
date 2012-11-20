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
// Generated by IDLImporter from file nsIStreamCipher.idl
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
    /// Stream cipher interface.  We're basically copying the interface from
    /// nsICryptoHash interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1d507cd6-1630-4710-af1b-4012dbcc514c")]
	public interface nsIStreamCipher
	{
		
		/// <summary>
        /// Initialize a stream cipher.
        /// @param aKey nsIKeyObject
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIKeyObject aKey);
		
		/// <summary>
        /// Initialize a stream cipher with an initialization vector.
        /// @param aKey nsIKeyObject
        /// @param aIV the initialization vector
        /// @param aIVLen the length of the initialization vector
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithIV([MarshalAs(UnmanagedType.Interface)] nsIKeyObject aKey, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aIV, uint aIVLen);
		
		/// <summary>
        /// Update from an array of bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Update([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] aData, uint aLen);
		
		/// <summary>
        /// Update from a stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, int aLen);
		
		/// <summary>
        /// A more script friendly method (not in nsICryptoHash interface).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateFromString([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aInput);
		
		/// <summary>
        /// @param aASCII if true then the returned value is a base-64
        /// encoded string.  if false, then the returned value is
        /// binary data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish([MarshalAs(UnmanagedType.U1)] bool aASCII, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Discard aLen bytes of the keystream.
        /// These days 1536 is considered a decent amount to drop to get
        /// the key state warmed-up enough for secure usage.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Discard(int aLen);
	}
}
