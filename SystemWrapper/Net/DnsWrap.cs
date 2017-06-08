using System;
using System.Net;
using System.Threading.Tasks;
using SystemInterface.Net;

namespace SystemWrapper.Net
{
    public sealed class DnsWrap : IDns
    {
        public IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state)
        {
            return Dns.BeginGetHostAddresses(hostNameOrAddress, requestCallback, state);
        }

        public IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject)
        {
            return Dns.BeginGetHostByName(hostName, requestCallback, stateObject);
        }

        public IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject)
        {
            return Dns.BeginGetHostEntry(address, requestCallback, stateObject);
        }

        public IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject)
        {
            return Dns.BeginGetHostEntry(hostNameOrAddress, requestCallback, stateObject);
        }

        public IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject)
        {
            return Dns.BeginResolve(hostName, requestCallback, stateObject);
        }

        public IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult)
        {
            return Dns.EndGetHostAddresses(asyncResult);
        }

        public IPHostEntry EndGetHostByName(IAsyncResult asyncResult)
        {
            return Dns.EndGetHostByName(asyncResult);
        }

        public IPHostEntry EndGetHostEntry(IAsyncResult asyncResult)
        {
            return Dns.EndGetHostEntry(asyncResult);
        }

        public IPHostEntry EndResolve(IAsyncResult asyncResult)
        {
            return Dns.EndResolve(asyncResult);
        }

        public IPAddress[] GetHostAddresses(string hostNameOrAddress)
        {
            return Dns.GetHostAddresses(hostNameOrAddress);
        }

        public async Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress)
        {
            return await Dns.GetHostAddressesAsync(hostNameOrAddress).ConfigureAwait(false);
        }

        public IPHostEntry GetHostByAddress(IPAddress address)
        {
            return GetHostByAddress(address);
        }

        public IPHostEntry GetHostByAddress(string address)
        {
            return GetHostByAddress(address);
        }

        public IPHostEntry GetHostByName(string hostName)
        {
            return GetHostByName(hostName);
        }

        public IPHostEntry GetHostEntry(string hostNameOrAddress)
        {
            return GetHostEntry(hostNameOrAddress);
        }

        public IPHostEntry GetHostEntry(IPAddress address)
        {
            return GetHostEntry(address);
        }

        public async Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress)
        {
            return await Dns.GetHostEntryAsync(hostNameOrAddress).ConfigureAwait(false);
        }

        public async Task<IPHostEntry> GetHostEntryAsync(IPAddress address)
        {
            return await Dns.GetHostEntryAsync(address).ConfigureAwait(false);
        }

        public string GetHostName()
        {
            return Dns.GetHostName();
        }

        public IPHostEntry Resolve(string hostName)
        {
            return Dns.Resolve(hostName);
        }
    }
}
