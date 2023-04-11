// This code defines the Part class, which provides a C# interface to the DotNetAutomationNative DLL.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAutomationBinding
{
public class Part
{
// Import the DotNet_automationapi_Part_Save function from the DotNetAutomationNative DLL.
//Path is C:\Badri\SoftwareArchitectureCLassApplication\SoftwareArchitectureCLassApplication\x64\DotNetAutomationNative.dll
[DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
static extern int DotNet_automationapi_Part_Save(int guid);
    // Save the current part file.
    public void Save()
    {
        // Call DotNet_automationapi_Part_Save to save the current part file in the DotNetAutomationNative DLL.
        DotNet_automationapi_Part_Save(m_guid);
    }

    // Constructor that takes a GUID representing the part file.
    public Part(int guid)
    {
        m_guid = guid;
    }

    // Private field that stores the GUID representing the part file.
    private int m_guid;

}
}