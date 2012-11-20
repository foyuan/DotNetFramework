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
// Generated by IDLImporter from file nsIScriptableRegion.idl
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
	
	
	/// <summary>nsIScriptableRegion </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a5f44cc7-2820-489b-b817-ae8a08506ff6")]
	public interface nsIScriptableRegion
	{
		
		/// <summary>Member Init </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// copy operator equivalent that takes another region
        ///
        /// @param      region to copy
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetToRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);
		
		/// <summary>
        /// copy operator equivalent that takes a rect
        ///
        /// @param      aX xoffset of rect to set region to
        /// @param      aY yoffset of rect to set region to
        /// @param      aWidth width of rect to set region to
        /// @param      aHeight height of rect to set region to
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetToRect(int aX, int aY, int aWidth, int aHeight);
		
		/// <summary>
        /// destructively intersect another region with this one
        ///
        /// @param      region to intersect
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IntersectRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);
		
		/// <summary>
        /// destructively intersect a rect with this region
        ///
        /// @param      aX xoffset of rect to intersect with region
        /// @param      aY yoffset of rect to intersect with region
        /// @param      aWidth width of rect to intersect with region
        /// @param      aHeight height of rect to intersect with region
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IntersectRect(int aX, int aY, int aWidth, int aHeight);
		
		/// <summary>
        /// destructively union another region with this one
        ///
        /// @param      region to union
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnionRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);
		
		/// <summary>
        /// destructively union a rect with this region
        ///
        /// @param      aX xoffset of rect to union with region
        /// @param      aY yoffset of rect to union with region
        /// @param      aWidth width of rect to union with region
        /// @param      aHeight height of rect to union with region
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnionRect(int aX, int aY, int aWidth, int aHeight);
		
		/// <summary>
        /// destructively subtract another region with this one
        ///
        /// @param      region to subtract
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SubtractRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);
		
		/// <summary>
        /// destructively subtract a rect from this region
        ///
        /// @param      aX xoffset of rect to subtract with region
        /// @param      aY yoffset of rect to subtract with region
        /// @param      aWidth width of rect to subtract with region
        /// @param      aHeight height of rect to subtract with region
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SubtractRect(int aX, int aY, int aWidth, int aHeight);
		
		/// <summary>
        /// is this region empty? i.e. does it contain any pixels
        ///
        /// @param      none
        /// @return     returns whether the region is empty
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEmpty();
		
		/// <summary>
        /// == operator equivalent i.e. do the regions contain exactly
        /// the same pixels
        ///
        /// @param      region to compare
        /// @return     whether the regions are identical
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEqualRegion([MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion aRegion);
		
		/// <summary>
        /// returns the bounding box of the region i.e. the smallest
        /// rectangle that completely contains the region.
        ///
        /// @param      aX out parameter for xoffset of bounding rect for region
        /// @param      aY out parameter for yoffset of bounding rect for region
        /// @param      aWidth out parameter for width of bounding rect for region
        /// @param      aHeight out parameter for height of bounding rect for region
        /// @return     void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBoundingBox(ref int aX, ref int aY, ref int aWidth, ref int aHeight);
		
		/// <summary>
        /// offsets the region in x and y
        ///
        /// @param  xoffset  pixel offset in x
        /// @param  yoffset  pixel offset in y
        /// @return          void
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Offset(int aXOffset, int aYOffset);
		
		/// <summary>
        /// @return null if there are no rects,
        /// @return flat array of rects,ie [x1,y1,width1,height1,x2...].
        /// The result will contain bogus data if values don't fit in 31 bit
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRects(System.IntPtr jsContext);
		
		/// <summary>
        /// does the region intersect the rectangle?
        ///
        /// @param      rect to check for containment
        /// @return     true if the region intersects the rect
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ContainsRect(int aX, int aY, int aWidth, int aHeight);
		
		/// <summary>Member GetRegionAttribute </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetRegionAttribute();
	}
}
