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
// Generated by IDLImporter from file nsIDirectoryEnumerator.idl
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
	
	
	/// <summary>
    /// This interface provides a means for enumerating the contents of a directory.
    /// It is similar to nsISimpleEnumerator except the retrieved entries are QI'ed
    /// to nsIFile, and there is a mechanism for closing the directory when the
    /// enumeration is complete.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31f7f4ae-6916-4f2d-a81e-926a4e3022ee")]
	public interface nsIDirectoryEnumerator
	{
		
		/// <summary>
        /// Retrieves the next file in the sequence. The "nextFile" element is the
        /// first element upon the first call. This attribute is null if there is no
        /// next element.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetNextFileAttribute();
		
		/// <summary>
        /// Closes the directory being enumerated, releasing the system resource.
        /// @throws NS_OK if the call succeeded and the directory was closed.
        /// NS_ERROR_FAILURE if the directory close failed.
        /// It is safe to call this function many times.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
	}
}
