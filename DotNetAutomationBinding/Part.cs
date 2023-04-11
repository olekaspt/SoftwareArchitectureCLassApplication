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
        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl)]
        static extern void DotNet_automationapi_Part_Save(int id);

        public void Save()
        {
            DotNet_automationapi_Part_Save(dankID);
        }

        public Part(int id)
        {
            dankID = id;
        }

        private int dankID;

    }
}
