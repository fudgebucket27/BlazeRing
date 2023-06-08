window.ethereumInterop = {
    getAccount: function () {
        if (typeof ethereum === 'undefined') {
            console.error('Ethereum provider not found');
            return;
        }

        return ethereum.request({ method: 'eth_requestAccounts' })
            .then(accounts => accounts[0])
            .catch(error => console.error(error));
    },

    // You can define more methods to interact with Ethereum here...
};