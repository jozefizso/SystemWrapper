using System;
using System.Net;
using System.Threading.Tasks;

namespace SystemInterface.Net
{
    public interface IDns
    {
        //
        // Summary:
        //     Asynchronously returns the Internet Protocol (IP) addresses for the specified
        //     host.
        //
        // Parameters:
        //   hostNameOrAddress:
        //     The host name or IP address to resolve.
        //
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   state:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the requestCallback delegate when the operation is complete.
        //
        // Returns:
        //     An System.IAsyncResult instance that references the asynchronous request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostNameOrAddress is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostNameOrAddress is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving hostNameOrAddress.
        //
        //   T:System.ArgumentException:
        //     hostNameOrAddress is an invalid IP address.
        IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state);
        //
        // Summary:
        //     Begins an asynchronous request for System.Net.IPHostEntry information about the
        //     specified DNS host name.
        //
        // Parameters:
        //   hostName:
        //     The DNS name of the host.
        //
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   stateObject:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the requestCallback delegate when the operation is complete.
        //
        // Returns:
        //     An System.IAsyncResult instance that references the asynchronous request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostName is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error was encountered executing the DNS query.
        [Obsolete("BeginGetHostByName is obsoleted for this type, please use BeginGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IAsyncResult BeginGetHostByName(string hostName, AsyncCallback requestCallback, object stateObject);
        //
        // Summary:
        //     Asynchronously resolves a host name or IP address to an System.Net.IPHostEntry
        //     instance.
        //
        // Parameters:
        //   hostNameOrAddress:
        //     The host name or IP address to resolve.
        //
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   stateObject:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the requestCallback delegate when the operation is complete.
        //
        // Returns:
        //     An System.IAsyncResult instance that references the asynchronous request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostNameOrAddress is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostNameOrAddress is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving hostNameOrAddress.
        //
        //   T:System.ArgumentException:
        //     hostNameOrAddress is an invalid IP address.
        IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject);
        //
        // Summary:
        //     Asynchronously resolves an IP address to an System.Net.IPHostEntry instance.
        //
        // Parameters:
        //   address:
        //     The IP address to resolve.
        //
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   stateObject:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the requestCallback delegate when the operation is complete.
        //
        // Returns:
        //     An System.IAsyncResult instance that references the asynchronous request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     address is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving address.
        //
        //   T:System.ArgumentException:
        //     address is an invalid IP address.
        IAsyncResult BeginGetHostEntry(IPAddress address, AsyncCallback requestCallback, object stateObject);
        //
        // Summary:
        //     Begins an asynchronous request to resolve a DNS host name or IP address to an
        //     System.Net.IPAddress instance.
        //
        // Parameters:
        //   hostName:
        //     The DNS name of the host.
        //
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   stateObject:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the requestCallback delegate when the operation is complete.
        //
        // Returns:
        //     An System.IAsyncResult instance that references the asynchronous request.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostName is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     The caller does not have permission to access DNS information.
        [Obsolete("BeginResolve is obsoleted for this type, please use BeginGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IAsyncResult BeginResolve(string hostName, AsyncCallback requestCallback, object stateObject);
        //
        // Summary:
        //     Ends an asynchronous request for DNS information.
        //
        // Parameters:
        //   asyncResult:
        //     An System.IAsyncResult instance returned by a call to the System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object)
        //     method.
        //
        // Returns:
        //     An array of type System.Net.IPAddress that holds the IP addresses for the host
        //     specified by the hostNameOrAddress parameter of System.Net.Dns.BeginGetHostAddresses(System.String,System.AsyncCallback,System.Object).
        IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult);
        //
        // Summary:
        //     Ends an asynchronous request for DNS information.
        //
        // Parameters:
        //   asyncResult:
        //     An System.IAsyncResult instance that is returned by a call to the System.Net.Dns.BeginGetHostByName(System.String,System.AsyncCallback,System.Object)
        //     method.
        //
        // Returns:
        //     An System.Net.IPHostEntry object that contains DNS information about a host.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     asyncResult is null.
        [Obsolete("EndGetHostByName is obsoleted for this type, please use EndGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry EndGetHostByName(IAsyncResult asyncResult);
        //
        // Summary:
        //     Ends an asynchronous request for DNS information.
        //
        // Parameters:
        //   asyncResult:
        //     An System.IAsyncResult instance returned by a call to an Overload:System.Net.Dns.BeginGetHostEntry
        //     method.
        //
        // Returns:
        //     An System.Net.IPHostEntry instance that contains address information about the
        //     host.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     asyncResult is null.
        IPHostEntry EndGetHostEntry(IAsyncResult asyncResult);
        //
        // Summary:
        //     Ends an asynchronous request for DNS information.
        //
        // Parameters:
        //   asyncResult:
        //     An System.IAsyncResult instance that is returned by a call to the System.Net.Dns.BeginResolve(System.String,System.AsyncCallback,System.Object)
        //     method.
        //
        // Returns:
        //     An System.Net.IPHostEntry object that contains DNS information about a host.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     asyncResult is null.
        [Obsolete("EndResolve is obsoleted for this type, please use EndGetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry EndResolve(IAsyncResult asyncResult);
        //
        // Summary:
        //     Returns the Internet Protocol (IP) addresses for the specified host.
        //
        // Parameters:
        //   hostNameOrAddress:
        //     The host name or IP address to resolve.
        //
        // Returns:
        //     An array of type System.Net.IPAddress that holds the IP addresses for the host
        //     that is specified by the hostNameOrAddress parameter.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostNameOrAddress is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostNameOrAddress is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving hostNameOrAddress.
        //
        //   T:System.ArgumentException:
        //     hostNameOrAddress is an invalid IP address.
        IPAddress[] GetHostAddresses(string hostNameOrAddress);
        Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress);
        //
        // Summary:
        //     Creates an System.Net.IPHostEntry instance from an IP address.
        //
        // Parameters:
        //   address:
        //     An IP address.
        //
        // Returns:
        //     An System.Net.IPHostEntry instance.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     address is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving address.
        //
        //   T:System.FormatException:
        //     address is not a valid IP address.
        [Obsolete("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry GetHostByAddress(string address);
        //
        // Summary:
        //     Creates an System.Net.IPHostEntry instance from the specified System.Net.IPAddress.
        //
        // Parameters:
        //   address:
        //     An System.Net.IPAddress.
        //
        // Returns:
        //     An System.Net.IPHostEntry.An System.Net.IPHostEntry instance.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     address is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving address.
        [Obsolete("GetHostByAddress is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry GetHostByAddress(IPAddress address);
        //
        // Summary:
        //     Gets the DNS information for the specified DNS host name.
        //
        // Parameters:
        //   hostName:
        //     The DNS name of the host.
        //
        // Returns:
        //     An System.Net.IPHostEntry object that contains host information for the address
        //     specified in hostName.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostName is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostName is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving hostName.
        [Obsolete("GetHostByName is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry GetHostByName(string hostName);
        //
        // Summary:
        //     Resolves an IP address to an System.Net.IPHostEntry instance.
        //
        // Parameters:
        //   address:
        //     An IP address.
        //
        // Returns:
        //     An System.Net.IPHostEntry instance that contains address information about the
        //     host specified in address.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     address is null.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving address.
        //
        //   T:System.ArgumentException:
        //     address is an invalid IP address.
        IPHostEntry GetHostEntry(IPAddress address);
        //
        // Summary:
        //     Resolves a host name or IP address to an System.Net.IPHostEntry instance.
        //
        // Parameters:
        //   hostNameOrAddress:
        //     The host name or IP address to resolve.
        //
        // Returns:
        //     An System.Net.IPHostEntry instance that contains address information about the
        //     host specified in hostNameOrAddress.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The hostNameOrAddress parameter is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostNameOrAddress parameter is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error was encountered when resolving the hostNameOrAddress parameter.
        //
        //   T:System.ArgumentException:
        //     The hostNameOrAddress parameter is an invalid IP address.
        IPHostEntry GetHostEntry(string hostNameOrAddress);
        Task<IPHostEntry> GetHostEntryAsync(IPAddress address);
        Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress);
        string GetHostName();
        //
        // Summary:
        //     Resolves a DNS host name or IP address to an System.Net.IPHostEntry instance.
        //
        // Parameters:
        //   hostName:
        //     A DNS-style host name or IP address.
        //
        // Returns:
        //     An System.Net.IPHostEntry instance that contains address information about the
        //     host specified in hostName.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     hostName is null.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of hostName is greater than 255 characters.
        //
        //   T:System.Net.Sockets.SocketException:
        //     An error is encountered when resolving hostName.
        [Obsolete("Resolve is obsoleted for this type, please use GetHostEntry instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        IPHostEntry Resolve(string hostName);
    }
}
