// This code defines the Session class, which provides a C# interface to the DotNetAutomationNative DLL.

using System;
using System.Runtime.InteropServices;

namespace DotNetAutomationBinding
{
public class Session
{
// Import the DotNet_automationapi_Session_InitializeSession function from the DotNetAutomationNative DLL.
[DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
static extern void DotNet_automationapi_Session_InitializeSession();

    // Import the DotNet_automationapi_Session_MakePart function from the DotNetAutomationNative DLL.
    [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    static extern int DotNet_automationapi_Session_MakePart(string partPath);

    // Private constructor that initializes the DotNet automation session.
    private Session()
    {
        DotNet_automationapi_Session_InitializeSession();
    }

    // Singleton instance of the Session class.
    private static readonly Lazy<Session> lazy = new Lazy<Session>(() => new Session());

    // Public static property to access the singleton instance of the Session class.
    public static Session GetSession
    {
        get
        {
            return lazy.Value;
        }
    }

    // Create a new part file with the given path name and return a new Part object representing the part.
    public Part MakePart(string pathName)
    {
        // Call DotNet_automationapi_Session_MakePart to create a new part file in the DotNetAutomationNative DLL.
        int guid = DotNet_automationapi_Session_MakePart(pathName);

        // Create a new Part object with the GUID of the newly created part file.
        Part part = new Part(guid);

        return part;
    }
}
}