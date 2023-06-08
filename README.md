# BlazeRing
Blazor WASM App Template for Loopring Wallet Connections

![image](https://github.com/fudgebucket27/BlazeRing/assets/5258063/5a3b9528-4611-483e-a5b6-120524e39d95)


# Requirements
This was made using Visual Studio 2022.

.NET 7.0 must be installed as well.

AOT compilation is used for release publishing as PoseidonSharp is slow without AOT. Run this command in the same folder as the project to install the workload

```bash
dotnet workload install wasm-tools
```
# Caveats
You will find unlocking can be slow this is due to the fact PoseidonSharp is slow without AOT. On release it will be under a few seconds to unlock.

# What is working?
Metamask unlock and retrieving Loopring API key

# To Do
Handle Rejections

WalletConnect

GameStopWallet
