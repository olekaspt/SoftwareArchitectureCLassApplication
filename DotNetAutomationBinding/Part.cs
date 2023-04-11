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
        //TODO to setup the PINVOKE for save
        // Import the native function for saving a part by its guid
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern void DotNet_automationapi_Part_Save(int guid);

        // Save the Part object instance by calling the native function
        public void Save()
        {
            //TODO
            DotNet_automationapi_Part_Save(m_guid);
        }

        // Constructor that sets the guid of the Part object instance
        public Part(int guid)  
        {
            m_guid = guid;
        }

        // The guid of the Part object instance
        private int m_guid;

    }
}
