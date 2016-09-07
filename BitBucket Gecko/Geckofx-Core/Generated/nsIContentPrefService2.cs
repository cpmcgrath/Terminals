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
// Generated by IDLImporter from file nsIContentPrefService2.idl
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
    /// Content Preferences
    ///
    /// Content preferences allow the application to associate arbitrary data, or
    /// "preferences", with specific domains, or web "content".  Specifically, a
    /// content preference is a structure with three values: a domain with which the
    /// preference is associated, a name that identifies the preference within its
    /// domain, and a value.  (See nsIContentPref below.)
    ///
    /// For example, if you want to remember the user's preference for a certain zoom
    /// level on www.mozilla.org pages, you might store a preference whose domain is
    /// "www.mozilla.org", whose name is "zoomLevel", and whose value is the numeric
    /// zoom level.
    ///
    /// A preference need not have a domain, and in that case the preference is
    /// called a "global" preference.  This interface doesn't impart any special
    /// significance to global preferences; they're simply name-value pairs that
    /// aren't associated with any particular domain.  As a consumer of this
    /// interface, you might choose to let a global preference override all non-
    /// global preferences of the same name, for example, for whatever definition of
    /// "override" is appropriate for your use case.
    ///
    ///
    /// Domain Parameters
    ///
    /// Many methods of this interface accept a "domain" parameter.  Domains may be
    /// specified either exactly, like "example.com", or as full URLs, like
    /// "http://example.com/foo/bar".  In the latter case the API extracts the full
    /// domain from the URL, so if you specify "http://foo.bar.example.com/baz", the
    /// domain is taken to be "foo.bar.example.com", not "example.com".
    ///
    ///
    /// Private-Browsing Context Parameters
    ///
    /// Many methods also accept a "context" parameter.  This parameter relates to
    /// private browsing and determines the kind of storage that a method uses,
    /// either the usual permanent storage or temporary storage set aside for private
    /// browsing sessions.
    ///
    /// Pass null to unconditionally use permanent storage.  Pass an nsILoadContext
    /// to use storage appropriate to the context's usePrivateBrowsing attribute: if
    /// usePrivateBrowsing is true, temporary private-browsing storage is used, and
    /// otherwise permanent storage is used.  A context can be obtained from the
    /// window or channel whose content pertains to the preferences being modified or
    /// retrieved.
    ///
    ///
    /// Callbacks
    ///
    /// The methods of callback objects are always called asynchronously.
    ///
    /// Observers are called after callbacks are called, but they are called in the
    /// same turn of the event loop as callbacks.
    ///
    /// See nsIContentPrefCallback2 below for more information about callbacks.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("86279644-6b86-4875-a228-2d2ff2f3e33b")]
	public interface nsIContentPrefService2
	{
		
		/// <summary>
        /// Gets the preference with the given domain and name.
        ///
        /// @param domain    The preference's domain.
        /// @param name      The preference's name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleResult is called once unless no such preference
        /// exists, in which case handleResult is not called at all.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetByDomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Gets all preferences with the given name whose domains are either the same
        /// as or subdomains of the given domain.
        ///
        /// @param domain    The preferences' domain.
        /// @param name      The preferences' name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleResult is called once for each preference.  If no
        /// such preferences exist, handleResult is not called at all.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBySubdomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Gets the preference with no domain and the given name.
        ///
        /// @param name      The preference's name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleResult is called once unless no such preference
        /// exists, in which case handleResult is not called at all.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGlobal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Synchronously retrieves from the in-memory cache the preference with the
        /// given domain and name.
        ///
        /// In addition to caching preference values, the cache also keeps track of
        /// preferences that are known not to exist.  If the preference is known not to
        /// exist, the value attribute of the returned object will be undefined
        /// (nsIDataType::VTYPE_VOID).
        ///
        /// If the preference is neither cached nor known not to exist, then null is
        /// returned, and get() must be called to determine whether the preference
        /// exists.
        ///
        /// @param domain   The preference's domain.
        /// @param name     The preference's name.
        /// @param context  The private-browsing context, if any.
        /// @return         The preference, or null if no such preference is known to
        /// exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentPref GetCachedByDomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context);
		
		/// <summary>
        /// Synchronously retrieves from the in-memory cache all preferences with the
        /// given name whose domains are either the same as or subdomains of the given
        /// domain.
        ///
        /// The preferences are returned in an array through the out-parameter.  If a
        /// preference for a particular subdomain is known not to exist, then an object
        /// corresponding to that preference will be present in the array, and, as with
        /// getCachedByDomainAndName, its value attribute will be undefined.
        ///
        /// @param domain   The preferences' domain.
        /// @param name     The preferences' name.
        /// @param context  The private-browsing context, if any.
        /// @param len      The length of the returned array.
        /// @param prefs    The array of preferences.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCachedBySubdomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, ref uint len, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=3)] ref nsIContentPref[] prefs);
		
		/// <summary>
        /// Synchronously retrieves from the in-memory cache the preference with no
        /// domain and the given name.
        ///
        /// As with getCachedByDomainAndName, if the preference is cached then it is
        /// returned; if the preference is known not to exist, then the value attribute
        /// of the returned object will be undefined; if the preference is neither
        /// cached nor known not to exist, then null is returned.
        ///
        /// @param name     The preference's name.
        /// @param context  The private-browsing context, if any.
        /// @return         The preference, or null if no such preference is known to
        /// exist.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIContentPref GetCachedGlobal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context);
		
		/// <summary>
        /// Sets a preference.
        ///
        /// @param domain    The preference's domain.
        /// @param name      The preference's name.
        /// @param value     The preference's value.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the preference has been
        /// stored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIVariant value, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Sets a preference with no domain.
        ///
        /// @param name      The preference's name.
        /// @param value     The preference's value.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the preference has been
        /// stored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGlobal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsIVariant value, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes the preference with the given domain and name.
        ///
        /// @param domain    The preference's domain.
        /// @param name      The preference's name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveByDomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all the preferences with the given name whose domains are either
        /// the same as or subdomains of the given domain.
        ///
        /// @param domain    The preferences' domain.
        /// @param name      The preferences' name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveBySubdomainAndName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes the preference with no domain and the given name.
        ///
        /// @param name      The preference's name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveGlobal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all preferences with the given domain.
        ///
        /// @param domain    The preferences' domain.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveByDomain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all preferences whose domains are either the same as or subdomains
        /// of the given domain.
        ///
        /// @param domain    The preferences' domain.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveBySubdomain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase domain, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all preferences with the given name regardless of domain, including
        /// global preferences with the given name.
        ///
        /// @param name      The preferences' name.
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all non-global preferences -- in other words, all preferences that
        /// have a domain.
        ///
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllDomains([MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Removes all global preferences -- in other words, all preferences that have
        /// no domain.
        ///
        /// @param context   The private-browsing context, if any.
        /// @param callback  handleCompletion is called when the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllGlobals([MarshalAs(UnmanagedType.Interface)] nsILoadContext context, [MarshalAs(UnmanagedType.Interface)] nsIContentPrefCallback2 callback);
		
		/// <summary>
        /// Registers an observer that will be notified whenever a preference with the
        /// given name is set or removed.
        ///
        /// When a set or remove method is called, observers are called after the set
        /// or removal completes and after the method's callback is called, and they
        /// are called in the same turn of the event loop as the callback.
        ///
        /// The service holds a strong reference to the observer, so the observer must
        /// be removed later to avoid leaking it.
        ///
        /// @param name      The name of the preferences to observe.  Pass null to
        /// observe all preference changes regardless of name.
        /// @param observer  The observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserverForName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, System.IntPtr observer);
		
		/// <summary>
        /// Unregisters an observer for the given name.
        ///
        /// @param name      The name for which the observer was registered.  Pass null
        /// if the observer was added with a null name.
        /// @param observer  The observer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserverForName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase name, System.IntPtr observer);
		
		/// <summary>
        /// Extracts and returns the domain from the given string representation of a
        /// URI.  This is how the API extracts domains from URIs passed to it.
        ///
        /// @param str  The string representation of a URI, like
        /// "http://example.com/foo/bar".
        /// @return     If the given string is a valid URI, the domain of that URI is
        /// returned.  Otherwise, the string itself is returned.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExtractDomain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase str, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
	}
	
	/// <summary>
    /// The callback used by the above methods.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1a12cf41-79e8-4d0f-9899-2f7b27c5d9a1")]
	public interface nsIContentPrefCallback2
	{
		
		/// <summary>
        /// For the retrieval methods, this is called once for each retrieved
        /// preference.  It is not called for other methods.
        ///
        /// @param pref  The retrieved preference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleResult([MarshalAs(UnmanagedType.Interface)] nsIContentPref pref);
		
		/// <summary>
        /// Called when an error occurs.  This may be called multiple times before
        /// handleCompletion is called.
        ///
        /// @param error  A number in Components.results describing the error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleError(int error);
		
		/// <summary>
        /// Called when the method finishes.  This will be called exactly once for
        /// each method invocation, and afterward no other callback methods will be
        /// called.
        ///
        /// @param reason  One of the COMPLETE_* values indicating the manner in which
        /// the method completed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleCompletion(ushort reason);
	}
	
	/// <summary>nsIContentPrefCallback2Consts </summary>
	public class nsIContentPrefCallback2Consts
	{
		
		// 
		public const ushort COMPLETE_OK = 0;
		
		// 
		public const ushort COMPLETE_ERROR = 1;
	}
	
	/// <summary>nsIContentPref </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f24948d-24b5-4b1b-b554-7dbd58c1d792")]
	public interface nsIContentPref
	{
		
		/// <summary>Member GetDomainAttribute </summary>
		/// <param name='aDomain'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomainAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDomain);
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);
		
		/// <summary>Member GetValueAttribute </summary>
		/// <returns>A nsIVariant</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetValueAttribute();
	}
}
