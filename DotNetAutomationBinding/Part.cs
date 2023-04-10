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
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern bool DotNet_automationapi_Part_Save(int guid);
        private int m_guid;

        public Part(int guid)
        {
            m_guid = guid;
        }

        public void Save()
        {
            DotNet_automationapi_Part_Save(m_guid);
        }
    }
}