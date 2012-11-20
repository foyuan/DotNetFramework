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
// Generated by IDLImporter from file nsIXSLTProcessorPrivate.idl
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
	
	
	/// <summary>nsIXSLTProcessorPrivate </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b8d727f7-67f4-4dc1-a318-ec0c87280816")]
	public interface nsIXSLTProcessorPrivate
	{
		
		/// <summary>
        /// Flags for this processor. Defaults to 0. See individual flags above
        /// for documentation for effect of reset()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlagsAttribute();
		
		/// <summary>
        /// Flags for this processor. Defaults to 0. See individual flags above
        /// for documentation for effect of reset()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFlagsAttribute(uint aFlags);
	}
	
	/// <summary>nsIXSLTProcessorPrivateConsts </summary>
	public class nsIXSLTProcessorPrivateConsts
	{
		
		// <summary>
        // Disables all loading of external documents, such as from
        // <xsl:import> and document()
        // Defaults to off and is *not* reset by calls to reset()
        // </summary>
		public const ulong DISABLE_ALL_LOADS = 1;
	}
}
