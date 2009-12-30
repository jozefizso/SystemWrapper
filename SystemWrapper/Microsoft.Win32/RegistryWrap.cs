using System;
using Microsoft.Win32;

namespace SystemWrapper.Microsoft.Win32
{
    public class RegistryWrap : IRegistryWrap
    {
        public IRegistryKeyWrap LocalMachine
        {
            get { return new RegistryKeyWrap(Registry.LocalMachine); }
        }
    }
}