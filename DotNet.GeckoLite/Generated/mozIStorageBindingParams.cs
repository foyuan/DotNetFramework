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
// Generated by IDLImporter from file mozIStorageBindingParams.idl
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
	
	
	/// <summary>mozIStorageBindingParams </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a8d4827c-641c-45e3-a9ea-493570b4106b")]
	public interface mozIStorageBindingParams
	{
		
		/// <summary>
        /// Binds aValue to the parameter with the name aName.
        ///
        /// @param aName
        /// The name of the parameter to bind aValue to.
        /// @param aValue
        /// The value to bind.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);
		
		/// <summary>Member BindUTF8StringByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindUTF8StringByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);
		
		/// <summary>Member BindStringByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindStringByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>Member BindDoubleByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindDoubleByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, double aValue);
		
		/// <summary>Member BindInt32ByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt32ByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, int aValue);
		
		/// <summary>Member BindInt64ByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt64ByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, long aValue);
		
		/// <summary>Member BindNullByName </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindNullByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);
		
		/// <summary>Member BindBlobByName </summary>
		/// <param name='aName'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aValueSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindBlobByName([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aValue, uint aValueSize);
		
		/// <summary>
        /// Binds aValue to the parameter with the index aIndex.
        ///
        /// @param aIndex
        /// The zero-based index of the parameter to bind aValue to.
        /// @param aValue
        /// The value to bind.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindByIndex(uint aIndex, [MarshalAs(UnmanagedType.Interface)] nsIVariant aValue);
		
		/// <summary>Member BindUTF8StringByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindUTF8StringByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aValue);
		
		/// <summary>Member BindStringByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindStringByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>Member BindDoubleByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindDoubleByIndex(uint aIndex, double aValue);
		
		/// <summary>Member BindInt32ByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt32ByIndex(uint aIndex, int aValue);
		
		/// <summary>Member BindInt64ByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindInt64ByIndex(uint aIndex, long aValue);
		
		/// <summary>Member BindNullByIndex </summary>
		/// <param name='aIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindNullByIndex(uint aIndex);
		
		/// <summary>Member BindBlobByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aValue'> </param>
		/// <param name='aValueSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BindBlobByIndex(uint aIndex, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] byte[] aValue, uint aValueSize);
	}
}
