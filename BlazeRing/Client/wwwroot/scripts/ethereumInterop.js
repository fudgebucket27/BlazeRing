window.ethereumInterop = {
    getAccount: function () {
        return ethereum.request({ method: 'eth_requestAccounts' })
            .then(accounts => accounts[0])
            .catch(error => console.error(error));
    },

    // You can define more methods to interact with Ethereum here...
};