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
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern void DotNet_automationapi_Part_Save(int guid);


        public void Save()
        {
            //TODO
            DotNet_automationapi_Part_Save(m_guid);

        }

        public Part(int guid)  
        {
            m_guid = guid;
        }

        private int m_guid;

    }
}
