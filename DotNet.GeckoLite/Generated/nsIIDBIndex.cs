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
// Generated by IDLImporter from file nsIIDBIndex.idl
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
    /// IDBIndex interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBIndex for more
    /// information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a859747a-0f05-4dfb-8f42-05c61415d4e4")]
	public interface nsIIDBIndex
	{
		
		/// <summary>
        /// IDBIndex interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-IDBIndex for more
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStoreNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStoreName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetKeyPathAttribute(System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUniqueAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMultiEntryAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBObjectStore GetObjectStoreAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Get(Gecko.JsVal key, System.IntPtr jsContext);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetKey(Gecko.JsVal key, System.IntPtr jsContext);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAll(Gecko.JsVal key, uint limit, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAllKeys(Gecko.JsVal key, uint limit, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///"next" </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenCursor(Gecko.JsVal key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase direction, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///"next" </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenKeyCursor(Gecko.JsVal key, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase direction, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Accepts null, a key value, or a nsIIDBKeyRange object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Count(Gecko.JsVal key, System.IntPtr jsContext, int argc);
	}
}
