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
// Generated by IDLImporter from file nsIAccessibleEditableText.idl
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
	
	
	/// <summary>nsIAccessibleEditableText </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e242d495-5cde-4b1c-8c84-2525b14939f5")]
	public interface nsIAccessibleEditableText
	{
		
		/// <summary>
        /// Sets the attributes for the text between the two given indices. The old
        /// attributes are replaced by the new list of attributes. For example,
        /// sets font styles, such as italic, bold...
        ///
        /// @param startPos - start index of the text whose attributes are modified.
        /// @param endPos - end index of the text whose attributes are modified.
        /// @param attributes - set of attributes that replaces the old list of
        /// attributes of the specified text portion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributes(int startPos, int endPos, [MarshalAs(UnmanagedType.Interface)] nsISupports attributes);
		
		/// <summary>
        /// Replaces the text represented by this object by the given text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextContents([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase text);
		
		/// <summary>
        /// Inserts text at the specified position.
        ///
        /// @param text - text that is inserted.
        /// @param position - index at which to insert the text.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertText([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase text, int position);
		
		/// <summary>
        /// Copies the text range into the clipboard.
        ///
        /// @param startPos - start index of the text to moved into the clipboard.
        /// @param endPos - end index of the text to moved into the clipboard.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyText(int startPos, int endPos);
		
		/// <summary>
        /// Deletes a range of text and copies it to the clipboard.
        ///
        /// @param startPos - start index of the text to be deleted.
        /// @param endOffset - end index of the text to be deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CutText(int startPos, int endPos);
		
		/// <summary>
        /// Deletes a range of text.
        ///
        /// @param startPos - start index of the text to be deleted.
        /// @param endPos - end index of the text to be deleted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteText(int startPos, int endPos);
		
		/// <summary>
        /// Pastes text from the clipboard.
        ///
        /// @param position - index at which to insert the text from the system
        /// clipboard into the text represented by this object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PasteText(int position);
	}
}
