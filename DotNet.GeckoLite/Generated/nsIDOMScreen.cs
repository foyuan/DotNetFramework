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
// Generated by IDLImporter from file nsIDOMScreen.idl
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
	
	
	/// <summary>nsIDOMScreen </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4507e43f-097c-452a-bfc4-dbb99748f6fd")]
	public interface nsIDOMScreen
	{
		
		/// <summary>Member GetTopAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTopAttribute();
		
		/// <summary>Member GetLeftAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLeftAttribute();
		
		/// <summary>Member GetWidthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWidthAttribute();
		
		/// <summary>Member GetHeightAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHeightAttribute();
		
		/// <summary>Member GetPixelDepthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPixelDepthAttribute();
		
		/// <summary>Member GetColorDepthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetColorDepthAttribute();
		
		/// <summary>Member GetAvailWidthAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAvailWidthAttribute();
		
		/// <summary>Member GetAvailHeightAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAvailHeightAttribute();
		
		/// <summary>Member GetAvailLeftAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAvailLeftAttribute();
		
		/// <summary>Member GetAvailTopAttribute </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetAvailTopAttribute();
		
		/// <summary>
        /// Is the device's screen currently enabled?  This attribute controls the
        /// device's screen, so setting it to false will turn off the screen.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozEnabledAttribute();
		
		/// <summary>
        /// Is the device's screen currently enabled?  This attribute controls the
        /// device's screen, so setting it to false will turn off the screen.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aMozEnabled);
		
		/// <summary>
        /// How bright is the screen's backlight, on a scale from 0 (very dim) to 1
        /// (full brightness)?  Setting this attribute modifies the screen's
        /// brightness.
        ///
        /// You can read and write this attribute even when the screen is disabled,
        /// but the backlight is off while the screen is disabled.
        ///
        /// If you write a value of X into this attribute, the attribute may not have
        /// the same value X when you later read it.  Most screens don't support as
        /// many different brightness levels as there are doubles between 0 and 1, so
        /// we may reduce the value's precision before storing it.
        ///
        /// @throw NS_ERROR_INVALID_ARG if brightness is not in the range [0, 1].
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMozBrightnessAttribute();
		
		/// <summary>
        /// How bright is the screen's backlight, on a scale from 0 (very dim) to 1
        /// (full brightness)?  Setting this attribute modifies the screen's
        /// brightness.
        ///
        /// You can read and write this attribute even when the screen is disabled,
        /// but the backlight is off while the screen is disabled.
        ///
        /// If you write a value of X into this attribute, the attribute may not have
        /// the same value X when you later read it.  Most screens don't support as
        /// many different brightness levels as there are doubles between 0 and 1, so
        /// we may reduce the value's precision before storing it.
        ///
        /// @throw NS_ERROR_INVALID_ARG if brightness is not in the range [0, 1].
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozBrightnessAttribute(double aMozBrightness);
	}
}
