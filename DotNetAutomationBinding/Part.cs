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
        //Import the DLL for .NET automation
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl)]
        //Autmation API function to save the part
        static extern void AutomationAPISavePart(int guid);



        public void Save()
        {
            AutomationAPISavePart(m_guid); //call to save the part
        }

        public Part(int guid)  
        {
            m_guid = guid;
        }

        private int m_guid;

    }
}
