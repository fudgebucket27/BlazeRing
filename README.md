# BlazeRing
Blazor WASM App Template for Loopring Wallet Connections

# Requirements
This was made using Visual Studio 2022.

.NET 7.0 must be installed as well.

AOT compilation is used for release publishing as PoseidonSharp is slow without AOT. Run this command in the same folder as the project to install the workload

```bash
dotnet workload install wasm-tools
```

# What is working?
Metamask unlock and retrieving Loopring API key

# To Do
Handle Rejections
WalletConnect
GamestopWallet
