# BlazeRing
Blazor WASM App Template for Loopring Wallet Connections. Live Demo can be found at https://blazering.xyz

![image](https://github.com/fudgebucket27/BlazeRing/assets/5258063/e4c5413e-d293-4642-a6d1-c1a1acb9de64)

# Requirements to build from source yourself
This was made using Visual Studio 2022.

.NET 7.0 must be installed as well.

# What is working?
Browser wallet unlock and retrieving Loopring API key
WalletConnect unlock and retrieving Loopring API key

# How to Deploy to Azure
Fork this repo and delete the .github/workflows folder

I suggest changing the dappOptions with your own WalletConnect projectId and other details [here](https://github.com/fudgebucket27/BlazeRing/blob/f9666e8c2f527e99e0a76fdf7a0a730b2d4ef829/BlazeRing/Client/Shared/WalletConnect.razor#L57-L68). You can create a WalletConnect project and get it's projectId [here](https://cloud.walletconnect.com/).

Configure a deployment in Azure and point to your forked repo, this will recreate the .github/workflows folder and a new .yml file.

# To Do
Better Error Handling

Handle Rejections

Handling disconnects


