**Note:** There is a bug with the github DownloadZIP(".map" asset file are Git LFS file, Github DownloadZIP results in the ".map" file only 1KB).  **You should clone this repository by HTTPs of this git, Not by Github DownloadZIP.**

# PRODUCT TITLE：

**UE-TCP (UETCP, TCP Blueprint For UE)**

**UE Marketplace:** https://www.unrealengine.com/marketplace/en-US/product/ue-tcp-uetcp-tcp-blueprint-for-ue

# SHORT DESCRIPTION：

Only need to use the blueprints, you can send and receive TCP(Transmission Control Protocol) messages. It is cross-platform and supports Unicode characters. The most important thing is that it is very easy to use.

# LONG DESCRIPTION：

This plugin encapsulates the implementation of TCP. 

Only need to use the blueprints, you can send and receive TCP messages. 

This plugin supports multiple platforms: iOS, Windows, Mac, etc. 

It supports Unicode characters. 

After using this plugin, you will find that it is so simple to receive and send TCP messages. 

# Blueprint nodes overview of "UE-TCP"

**Level Blueprint Of This Map**:`'./UETCPDemo/MAPs/MAP_UETCPDemo_Overview'`

![image-20230813095838442](README/00_Res/01_Images/image-20230813095838442.png)

![BPGraphScreenshot_2023Y-08M-13D-09h-58m-47s-612_00](README/00_Res/01_Images/BPGraphScreenshot_2023Y-08M-13D-09h-58m-47s-612_00.png)

## Detailed description of each node

### UE-TCP Blueprint Library Nodes:

![image-20230813095940899](README/00_Res/01_Images/image-20230813095940899.png)

**"1"**: **CreateUETCPObject**, Instantiates a new UETCP Object for the current platform.

**"2"**: **BytesToString**, Converts bytes to string.

**"3"**: **StringToBytes**, Converts string to bytes.

![image-20230813100024767](README/00_Res/01_Images/image-20230813100024767.png)

**"1"**: **SetMaxBacklog**

> 	Server Only.
> 	MaxBacklog: The number of connections to queue before refusing them.
> 	Call this function before calling "Listen(ServerOnly)".

**"2"**: **Listen(ServerOnly)**, Listen for incoming connections. Server Only.

**"3"**: **GetServerClientConnections(ServerOnly)**,  Get the "UUETCPServerClientConnection" Objects.

**"4"**: **GetServerListenPort(ServerOnly)**, Get server listen port. Server Only.

**"5"**: **GetLocalBindAddress**, Get local IP to bind to.

**"6"**: **GetLocalHostAddress**, Uses the platform specific look up to determine the host address.

**"7"**: **BindEventTo OnReceivedNewTCPConnectionRequest(ServerOnly)**, Delegate called when new TCP Connection Request is received. ServerOnly.

![image-20230813100100590](README/00_Res/01_Images/image-20230813100100590.png)

**"1"**: **SendDataToClient(ServerOnly)**, Use the Server "UETCPServerClientConnection" Object to Send data to client.

**"2"**: **GetServerAddressInfo(ServerOnly)**, Use the Server "UETCPServerClientConnection" Object to get Server Address Info.

**"3"**: **GetConnectionState(ServerOnly)**, Use the Server "UETCPServerClientConnection" Object to get  Connection State.

**"4"**: **GetClientAddressInfo(ServerOnly)**, Use the Server "UETCPServerClientConnection" Object to get Client Address Info.

**"5"**: **Close**, Close the Connection fo Server "UETCPServerClientConnection" Object.

**"6"**: **BindEventTo OnReceivedNewTCPDataFromClient(ServerOnly)**, Delegate called when new TCP data is received by Server.

![image-20230813100136179](README/00_Res/01_Images/image-20230813100136179.png)

**"1"**: **ConnectTo(ClientOnly)**, This Client Connects to server. Client Only.

**"2"**: **SendDataToServer(ClientOnly)**, On client, use the "UUETCPObject"  Object to Send Data To Server.

**"3"**: **GetClientConnectionState(ClientOnly)**, On client, use the "UUETCPObject"  Object to get Client Connection State.

**"4"**: **GetLocalBindAddress**, Get local IP to bind to.

**"5"**: **GetLocalHostAddress**, Uses the platform specific look up to determine the host address.

**"6"**: **BindEventTo OnReceivedNewTCPDataFromServer(ClientOnly)**, Delegate called when new TCP data is received by Client. Client Only.

# Example Introduction

Two TCP client Actors connect to one TCP server Actor. In each frame, the TCP server sends messages containing Unicode characters to the TCP clients, and each TCP client sends messages containing Unicode characters to the TCP server.

![image-20230813095634362](README/00_Res/01_Images/image-20230813095634362.png)

## “BPA_UETCP_Client”

**Actor**:`./UETCPDemo/BPs/BPAs/BPA_UETCP_Client'`

![image-20230813100335818](README/00_Res/01_Images/image-20230813100335818.png)

![BPGraphScreenshot_2023Y-08M-13D-10h-03m-47s-122_00](README/00_Res/01_Images/BPGraphScreenshot_2023Y-08M-13D-10h-03m-47s-122_00.png)

## “BPA_UETCP_Server”

**Actor**:`./UETCPDemo/BPs/BPAs/BPA_UETCP_Server'`

![image-20230813100457734](README/00_Res/01_Images/image-20230813100457734.png)

![BPGraphScreenshot_2023Y-08M-13D-10h-05m-13s-690_00](README/00_Res/01_Images/BPGraphScreenshot_2023Y-08M-13D-10h-05m-13s-690_00.png)