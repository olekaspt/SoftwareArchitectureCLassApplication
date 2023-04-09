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
        //Path is C:\Users\Gaurav\source\repos\SoftwareArchitectureCLassApplication07\x64\Debug\DotNetAutomationNative.dll
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern int DotNet_automationapi_Part_Save(int guid);

        public void Save()
        {
            DotNet_automationapi_Part_Save(m_guid);
        }

        public Part(int guid)  
        {
            m_guid = guid;
        }

        private int m_guid;

    }
}
