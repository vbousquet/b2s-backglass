﻿Imports System.Reflection
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.

' Review the values of the assembly attributes
#If B2S = "DLL" Then
<Assembly: AssemblyTitle("B2S Backglass Server")> 
<Assembly: AssemblyProduct("B2S Backglass Server")> 
#Else
<Assembly: AssemblyTitle("B2S Backglass Server EXE")>
<Assembly: AssemblyProduct("B2S Backglass Server EXE")>
#End If
<Assembly: AssemblyDescription("Display directb2s Backglass files for Visual Pinball")>
<Assembly: AssemblyCompany("Visual Pinball")>
<Assembly: AssemblyCopyright("Copyright (c) 2012-2025")>
<Assembly: AssemblyTrademark("A Herweh & B2S Team production")>
<Assembly: ComVisible(True)>

'The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("4e596935-cb6b-40d8-81f9-428397c654cf")> 

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("2.1.3")> 
<Assembly: AssemblyFileVersion("2.1.3")> 
<Assembly: AssemblyInformationalVersion("2.1.3")> 
