﻿using System;
using System.Formats.Tar;
using System.Runtime.InteropServices;

namespace DotNetAutomationBinding
{
    public class Session

    {

        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern void DotNet_automationapi_Session_InitializeSession();

        [DllImport("DotNetAutomationNative", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        static extern int DotNet_automationapi_Session_MakePart(string partPath);


        private Session()
        {
            DotNet_automationapi_Session_InitializeSession();
        }


        private static readonly Lazy<Session> lazy = new Lazy<Session>(() => new Session());
        public static Session GetSession
        {
            get
            {
                return lazy.Value;
            }
        }


        public Part MakePart(string pathName)
        {
            int guid = DotNet_automationapi_Session_MakePart(pathName);
            Part partpart = new Part(guid);
            return partpart;
        }

    }
}