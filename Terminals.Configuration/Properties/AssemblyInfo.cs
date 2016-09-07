﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Terminals.Configuration")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Oliver Kohl D.Sc.")]
[assembly: AssemblyProduct("Terminals.Configuration")]
[assembly: AssemblyCopyright("Copyright © Oliver Kohl D.Sc. 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("ad1b8ebd-0d22-47fd-b607-9c186ea0724d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//

[assembly: AssemblyVersion("2.3.1.0")]
[assembly: AssemblyFileVersion("2.3.1.0")]
[assembly: AssemblyInformationalVersion("2.3.1 RTM")]

/*
AssemblyVersion

Where other assemblies that reference your assembly will look. If this number changes, other assemblies have to update their references to your assembly! The AssemblyVersion is required.

I use the format: major.minor. This would result in:
[assembly: AssemblyVersion("1.0")] 

 AssemblyFileVersion

Used for deployment. You can increase this number for every deployment. It is used by setup programs. Use it to mark assemblies that have the same AssemblyVersion, but are generated from different builds.

In Windows, it can be viewed in the file properties.

If possible, let it be generated by MSBuild. The AssemblyFileVersion is optional. If not given, the AssemblyVersion is used.

I use the format: major.minor.revision.build, where I use revision for development stage (Alpha, Beta, RC and RTM), service packs and hot fixes. This would result in:
[assembly: AssemblyFileVersion("1.0.3100.1242")] 

 AssemblyInformationalVersion

The Product version of the assembly. This is the version you would use when talking to customers or for display on your website. This version can be a string, like '1.0 Release Candidate'. Unfortunately, when you use a string, it will generate a false warning -- already reported to Microsoft (fixed in VS2010). The AssemblyInformationalVersion is optional. If not given, the AssemblyVersion is used.

I use the format: major.minor [revision as string]. This would result in:
[assembly: AssemblyInformationalVersion("1.0 RC1")] 
*/