using System;
using System.Runtime.InteropServices;

namespace DotNetAutomationBinding
{
    public class Session

    {
        // Import the native function for initializing the session
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern void DotNet_automationapi_Session_InitializeSession();

        // Import the native function for creating a part and return its guid
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern int DotNet_automationapi_Session_MakePart(string partPath);

        // Constructor that initializes the session by calling the native function
        private Session()
        {
            DotNet_automationapi_Session_InitializeSession();
        }

        // A lazy-initialized instance of the session object
        private static readonly Lazy<Session> lazy = new Lazy<Session>(() => new Session());
        // Get the session object instance
        public static Session GetSession
        {
            get
            {
                return lazy.Value;
            }
        }

        // Create a new part and return a Part object instance
        public Part MakePart(string pathName)
        {
            // Part partpart = null;
            // Call the native function to create a part and get its guid
            int guid = DotNet_automationapi_Session_MakePart(pathName);
            // Return a new Part object instance with the guid
            return new Part(guid);
            // return partpart;
        }

    }
}