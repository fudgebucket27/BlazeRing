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

window.drawImageOnCanvas = (canvasId, imageBase64) => {
    var canvas = document.getElementById(canvasId);
    var context = canvas.getContext('2d');
    var img = new Image();
    img.onload = function () {
        canvas.width = img.width;
        canvas.height = img.height;
        context.drawImage(img, 0, 0, img.width, img.height);
    };
    img.src = 'data:image/png;base64,' + imageBase64;
};