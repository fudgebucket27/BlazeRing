import { EthereumClient, w3mConnectors, w3mProvider } from '@web3modal/ethereum'
import { Web3Modal } from '@web3modal/html'
import { configureChains, createConfig } from '@wagmi/core'
import { mainnet } from '@wagmi/core/chains'
import { getAccount } from '@wagmi/core'
import { signMessage } from '@wagmi/core'

const chains = [mainnet]
const projectId = '0a0b4427350974a116cebee8c20bb61b'

const { publicClient } = configureChains(chains, [w3mProvider({ projectId })])
const wagmiConfig = createConfig({
    autoConnect: true,
    connectors: w3mConnectors({ projectId, version: 1, chains }),
    publicClient
})
const ethereumClient = new EthereumClient(wagmiConfig, chains)
const web3modal = new Web3Modal({ projectId }, ethereumClient)


window.walletConnectInterop = {
    getAccount: function () {
        const account = getAccount();
        console.log("Connected with address:" + account.address);
        return account.address;
    }
};

window.signWagmiMessage = async function (message) {
    const signature = await signMessage({
        message: message,
    })
    return signature;
}