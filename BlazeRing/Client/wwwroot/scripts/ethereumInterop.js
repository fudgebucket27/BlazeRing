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

    signMessage: function (message) {
        if (typeof ethereum === 'undefined') {
            console.error('Ethereum provider not found');
            return Promise.reject(new Error('Ethereum provider not found'));
        }

        return ethereum.request({
            method: 'personal_sign',
            params: [message, ethereum.selectedAddress]
        })
            .catch(error => {
                console.error(error);
                throw error;
            });
    }
};