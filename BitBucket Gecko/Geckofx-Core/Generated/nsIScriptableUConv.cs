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
// Generated by IDLImporter from file nsIScriptableUConv.idl
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
    /// This interface is a unicode encoder for use by scripts
    ///
    /// @created         8/Jun/2000
    /// @author          Makoto Kato [m_kato@ga2.so-net.ne.jp]
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f36ee324-5c1c-437f-ba10-2b4db7a18031")]
	public interface nsIScriptableUnicodeConverter
	{
		
		/// <summary>
        /// Converts the data from Unicode to one Charset.
        /// Returns the converted string. After converting, Finish should be called
        /// and its return value appended to this return value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertFromUnicode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSrc, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Returns the terminator string.
        /// Should be called after ConvertFromUnicode() and appended to that
        /// function's return value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Converts the data from one Charset to Unicode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertToUnicode([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aSrc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Converts an array of bytes to a unicode string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertFromByteArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] aData, uint aCount, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		/// <summary>
        /// Convert a unicode string to an array of bytes. Finish does not need to be
        /// called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConvertToByteArray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString, ref uint aLen, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref byte[] aData);
		
		/// <summary>
        /// Converts a unicode string to an input stream. The bytes in the stream are
        /// encoded according to the charset attribute.
        /// The returned stream will be nonblocking.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream ConvertToInputStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aString);
		
		/// <summary>
        /// Current character set.
        ///
        /// @throw NS_ERROR_UCONV_NOCONV
        /// The requested charset is not supported.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCharsetAttribute();
		
		/// <summary>
        /// Current character set.
        ///
        /// @throw NS_ERROR_UCONV_NOCONV
        /// The requested charset is not supported.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharsetAttribute([MarshalAs(UnmanagedType.LPStr)] string aCharset);
		
		/// <summary>
        /// Internal use
        ///
        /// When this attribute is set, all charsets may be accessed.
        /// When it is not set (the default), charsets with the isInternal flag
        /// may not be accessed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInternalAttribute();
		
		/// <summary>
        /// Internal use
        ///
        /// When this attribute is set, all charsets may be accessed.
        /// When it is not set (the default), charsets with the isInternal flag
        /// may not be accessed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInternalAttribute([MarshalAs(UnmanagedType.U1)] bool aIsInternal);
	}
}
