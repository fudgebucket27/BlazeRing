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
You will find unlocking is very slow when debugging, this is due to the fact that PoseidonSharp underperforms without AOT. When publishing a release, it will take under a few seconds to unlock.

# What is working?
Metamask unlock and retrieving Loopring API key

# To Do
Better Error Handling

Handle Rejections

WalletConnect

GameStopWallet

# How to Deploy to Azure
Fork this repo and delete the .github/workflows folder

Configure a deployment in Azure and point to your fork repo, this will recreate the .github/workflows folder and a new .yml file.

You then need to modify the .yml file to install wasm-tools. Add the following before the build action in the workflow:

```bash
      - name: Install WASM Tools
        run: dotnet workload install wasm-tools
```


