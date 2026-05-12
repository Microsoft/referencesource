//------------------------------------------------------------------------------
// <copyright file="SocketErrors.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

namespace System.Net.Sockets {
    using System;
    using System.Net;

    /// <devdoc>
    ///    <para>
    ///       Defines socket error constants.
    ///    </para>
    /// </devdoc>


    public enum SocketError : int {
        /// <devdoc>
        ///    <para>
        ///       The operation completed succesfully.
        ///    </para>
        /// </devdoc>
        Success                =  0,
        
        /// <devdoc>
        ///    <para>
        ///       The socket has an error.
        ///    </para>
        /// </devdoc>
        SocketError            = (-1),


        /*
         * All Windows Sockets error constants are biased by WSABASEERR from
         * the "normal"
         */
        /// <devdoc>
        ///    <para>
        ///       The base value of all socket error constants. All other socket errors are
        ///       offset from this value.
        ///    </para>
        /// </devdoc>
        

        ///WSABASEERR = 10000;

        /*
         * Windows Sockets definitions of regular Microsoft C error constants
         */
        /// <devdoc>
        ///    <para>
        ///       A blocking socket call was canceled.
        ///    </para>
        /// </devdoc>
        Interrupted               = 10004,      //WSAEINTR
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
        //WSAEBADF               = 10009,   //
        /// <devdoc>
        ///    <para>
        ///       Permission denied.
        ///    </para>
        /// </devdoc>
        AccessDenied              = 10013,      //WSAEACCES
        /// <devdoc>
        ///    <para>
        ///       Bad address.
        ///    </para>
        /// </devdoc>
        Fault              = 10014,        //WSAEFAULT
        /// <devdoc>
        ///    <para>
        ///       Invalid argument.
        ///    </para>
        /// </devdoc>
        InvalidArgument              = 10022,    //WSAEINVAL
        /// <devdoc>
        ///    <para>
        ///       Too many open
        ///       files.
        ///    </para>
        /// </devdoc>
        TooManyOpenSockets              = 10024,  //WSAEMFILE


        /*
         * Windows Sockets definitions of regular Berkeley error constants
         */
        /// <devdoc>
        ///    <para>
        ///       Resource temporarily unavailable.
        ///    </para>
        /// </devdoc>
        WouldBlock         = 10035,   //WSAEWOULDBLOCK
        /// <devdoc>
        ///    <para>
        ///       Operation now in progress.
        ///    </para>
        /// </devdoc>
        InProgress         = 10036,  // WSAEINPROGRESS
        /// <devdoc>
        ///    <para>
        ///       Operation already in progress.
        ///    </para>
        /// </devdoc>
        AlreadyInProgress            = 10037,  //WSAEALREADY
        /// <devdoc>
        ///    <para>
        ///       Socket operation on nonsocket.
        ///    </para>
        /// </devdoc>
        NotSocket            = 10038,   //WSAENOTSOCK
        /// <devdoc>
        ///    <para>
        ///       Destination address required.
        ///    </para>
        /// </devdoc>
        DestinationAddressRequired        = 10039, //WSAEDESTADDRREQ
        /// <devdoc>
        ///    <para>
        ///       Message too long.
        ///    </para>
        /// </devdoc>
        MessageSize            = 10040,  //WSAEMSGSIZE
        /// <devdoc>
        ///    <para>
        ///       Protocol wrong type for socket.
        ///    </para>
        /// </devdoc>
        ProtocolType          = 10041, //WSAEPROTOTYPE
        /// <devdoc>
        ///    <para>
        ///       Bad protocol option.
        ///    </para>
        /// </devdoc>
        ProtocolOption         = 10042, //WSAENOPROTOOPT
        /// <devdoc>
        ///    <para>
        ///       Protocol not supported.
        ///    </para>
        /// </devdoc>
        ProtocolNotSupported     = 10043, //WSAEPROTONOSUPPORT
        /// <devdoc>
        ///    <para>
        ///       Socket type not supported.
        ///    </para>
        /// </devdoc>
        SocketNotSupported     = 10044, //WSAESOCKTNOSUPPORT
        /// <devdoc>
        ///    <para>
        ///       Operation not supported.
        ///    </para>
        /// </devdoc>
        OperationNotSupported          = 10045, //WSAEOPNOTSUPP
        /// <devdoc>
        ///    <para>
        ///       Protocol family not supported.
        ///    </para>
        /// </devdoc>
        ProtocolFamilyNotSupported        = 10046, //WSAEPFNOSUPPORT
        /// <devdoc>
        ///    <para>
        ///       Address family not supported by protocol family.
        ///    </para>
        /// </devdoc>
        AddressFamilyNotSupported        = 10047, //WSAEAFNOSUPPORT
        /// <devdoc>
        ///    Address already in use.
        /// </devdoc>
        AddressAlreadyInUse          = 10048, // WSAEADDRINUSE
        /// <devdoc>
        ///    <para>
        ///       Cannot assign requested address.
        ///    </para>
        /// </devdoc>
        AddressNotAvailable       = 10049, //WSAEADDRNOTAVAIL
        /// <devdoc>
        ///    <para>
        ///       Network is down.
        ///    </para>
        /// </devdoc>
        NetworkDown            = 10050, //WSAENETDOWN
        /// <devdoc>
        ///    <para>
        ///       Network is unreachable.
        ///    </para>
        /// </devdoc>
        NetworkUnreachable         = 10051, //WSAENETUNREACH
        /// <devdoc>
        ///    <para>
        ///       Network dropped connection on reset.
        ///    </para>
        /// </devdoc>
        NetworkReset           = 10052, //WSAENETRESET
        /// <devdoc>
        ///    <para>
        ///       Software caused connection to abort.
        ///    </para>
        /// </devdoc>
        ConnectionAborted        = 10053, //WSAECONNABORTED
        /// <devdoc>
        ///    <para>
        ///       Connection reset by peer.
        ///    </para>
        /// </devdoc>
        ConnectionReset          = 10054, //WSAECONNRESET
        /// <devdoc>
        ///    No buffer space available.
        /// </devdoc>
        NoBufferSpaceAvailable             = 10055, //WSAENOBUFS
        /// <devdoc>
        ///    <para>
        ///       Socket is already connected.
        ///    </para>
        /// </devdoc>
        IsConnected             = 10056, //WSAEISCONN
        /// <devdoc>
        ///    <para>
        ///       Socket is not connected.
        ///    </para>
        /// </devdoc>
        NotConnected            = 10057, //WSAENOTCONN
        /// <devdoc>
        ///    <para>
        ///       Cannot send after socket shutdown.
        ///    </para>
        /// </devdoc>
        Shutdown           = 10058, //WSAESHUTDOWN
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
     //   WSAETOOMANYREFS        = 10059, //WSAETOOMANYREFS
        /// <devdoc>
        ///    <para>
        ///       Connection timed out.
        ///    </para>
        /// </devdoc>
        TimedOut           = 10060, //WSAETIMEDOUT
        /// <devdoc>
        ///    <para>
        ///       Connection refused.
        ///    </para>
        /// </devdoc>
        ConnectionRefused        = 10061, //WSAECONNREFUSED
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
      //  WSAELOOP               = 10062,
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
     //   WSAENAMETOOLONG        = 10063,
        /// <devdoc>
        ///    <para>
        ///       Host is down.
        ///    </para>
        /// </devdoc>
        HostDown           = 10064, //WSAEHOSTDOWN
        /// <devdoc>
        ///    <para>
        ///       No route to host.
        ///    </para>
        /// </devdoc>
        HostUnreachable        = 10065, //WSAEHOSTUNREACH
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
       // WSAENOTEMPTY           = 10066,
        /// <devdoc>
        ///    <para>
        ///       Too many processes.
        ///    </para>
        /// </devdoc>
        ProcessLimit            = 10067, //WSAEPROCLIM
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
      //  WSAEUSERS              = 10068,
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
      //  WSAEDQUOT              = 10069,
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
       // WSAESTALE              = 10070,
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
        /*
         * Extended Windows Sockets error constant definitions
         */
        /// <devdoc>
        ///    <para>
        ///       Network subsystem is unavailable.
        ///    </para>
        /// </devdoc>
        SystemNotReady         = 10091, //WSASYSNOTREADY
        /// <devdoc>
        ///    <para>
        ///       Winsock.dll out of range.
        ///    </para>
        /// </devdoc>
        VersionNotSupported     = 10092, //WSAVERNOTSUPPORTED
        /// <devdoc>
        ///    <para>
        ///       Successful startup not yet performed.
        ///    </para>
        /// </devdoc>
        NotInitialized      = 10093, //WSANOTINITIALISED


       // WSAEREMOTE             = 10071,
        /// <devdoc>
        ///    <para>
        ///       Graceful shutdown in progress.
        ///    </para>
        /// </devdoc>
        Disconnecting             = 10101, //WSAEDISCON


        TypeNotFound             = 10109, //WSATYPE_NOT_FOUND


        /*
         * Error return codes from gethostbyname() and gethostbyaddr()
         *              = (when using the resolver). Note that these errors are
         * retrieved via WSAGetLastError() and must therefore follow
         * the rules for avoiding clashes with error numbers from
         * specific implementations or language run-time systems.
         * For this reason the codes are based at 11001.
         * Note also that [WSA]NO_ADDRESS is defined only for
         * compatibility purposes.
         */



        /// <devdoc>
        ///    <para>
        ///       Host not found (Authoritative Answer: Host not found).
        ///    </para>
        /// </devdoc>
        HostNotFound      = 11001, //WSAHOST_NOT_FOUND
        /// <devdoc>
        ///    <para>
        ///       Nonauthoritative host not found (Non-Authoritative: Host not found, or SERVERFAIL).
        ///    </para>
        /// </devdoc>
        TryAgain           = 11002, //WSATRY_AGAIN
        /// <devdoc>
        ///    <para>
        ///       This is a nonrecoverable error (Non recoverable errors, FORMERR, REFUSED, NOTIMP).
        ///    </para>
        /// </devdoc>
        NoRecovery         = 11003, //WSANO_RECOVERY
        /// <devdoc>
        ///    <para>
        ///       Valid name, no data record of requested type.
        ///    </para>
        /// </devdoc>
        NoData             = 11004, //WSANO_DATA



        //OS dependent errors

        /// <devdoc>
        ///    <para>
        ///       Overlapped operations will complete later.
        ///    </para>
        /// </devdoc>
        IOPending             = (int) UnsafeNclNativeMethods.ErrorCodes.ERROR_IO_PENDING,          // 997
        /// <devdoc>
        ///    <para>
        ///       [To be supplied.]
        ///    </para>
        /// </devdoc>
        OperationAborted      = (int) UnsafeNclNativeMethods.ErrorCodes.ERROR_OPERATION_ABORTED,   // 995, WSA_OPERATION_ABORTED
    }
}
