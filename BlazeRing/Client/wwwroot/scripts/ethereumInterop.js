window.ethereumInterop = {
    getAccount: async function () {
        const accounts = await ethereum.request({ method: 'eth_requestAccounts' });
        return accounts[0];
    },

    // You can define more methods to interact with Ethereum here...
};