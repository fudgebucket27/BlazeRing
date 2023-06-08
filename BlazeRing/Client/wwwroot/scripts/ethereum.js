export function connect() {
    if (window.ethereum) {
        window.ethereum.request({ method: 'eth_requestAccounts' });
    } else {
        console.log('Non-Ethereum browser detected. Consider installing MetaMask.');
    }
}