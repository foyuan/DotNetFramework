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
// Generated by IDLImporter from file nsIIndexedDatabaseManager.idl
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
	
	
	/// <summary>nsIIndexedDatabaseUsageCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ef1795ec-7050-4658-b80f-0e48cbe1d64b")]
	public interface nsIIndexedDatabaseUsageCallback
	{
		
		/// <summary>
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnUsageResult([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ulong aUsage, ulong aFileUsage);
	}
	
	/// <summary>nsIIndexedDatabaseManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("02256aa7-70d8-473f-bf3b-8cb35d28fd75")]
	public interface nsIIndexedDatabaseManager
	{
		
		/// <summary>
        /// Schedules an asynchronous callback that will return the total amount of
        /// disk space being used by databases for the given origin.
        ///
        /// @param aURI
        /// The URI whose usage is being queried.
        /// @param aCallback
        /// The callback that will be called when the usage is available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsageForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIIndexedDatabaseUsageCallback aCallback);
		
		/// <summary>
        /// Cancels an asynchronous usage check initiated by a previous call to
        /// getUsageForURI().
        ///
        /// @param aURI
        /// The URI whose usage is being queried.
        /// @param aCallback
        /// The callback that will be called when the usage is available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelGetUsageForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIIndexedDatabaseUsageCallback aCallback);
		
		/// <summary>
        /// Removes all databases stored for the given URI. The files may not be
        /// deleted immediately depending on prohibitive concurrent operations.
        ///
        /// @param aURI
        /// The URI whose databases are to be cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearDatabasesForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Defines mozIndexedDB and IDBKeyrange with its static functions on
        /// aObject and initializes DOM exception providers if needed.
        ///
        /// @param aObject
        /// The object, mozIndexedDB and IDBKeyrange should be defined on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWindowless(Gecko.JsVal aObject, System.IntPtr jsContext);
	}
}
