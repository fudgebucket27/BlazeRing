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