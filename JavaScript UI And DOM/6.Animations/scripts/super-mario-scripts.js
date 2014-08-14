window.onload = function() {
    var stage = new Kinetic.Stage({
        container: 'body',
        width: 800,
        height: 480
    });
    var layer = new Kinetic.Layer();
    var marioImg = new Image();
    var xcoord = 200;
    marioImg.src = 'imgs/mario-flipped.png';
    {
        var mario = new Kinetic.Sprite({
            x: ++xcoord,
            y: 100,
            image: marioImg,
            animation: 'walk',
            animations: {
                walk: [
                    435, 400, 95, 155,
//                    413,600,148,150,
                    745, 585, 135, 155

                ],
                jump: [

                ]
            },
            frameRate: 5,
            update: function () {

                this.x++;
            }
        });

        function bla() {
            mario.x++
        }

        layer.add(mario);
        stage.add(layer);

        mario.animation('walk');
        mario.start();

//        var animation = new Kinetic.Animation(layer, function () {
//            console.log(mario.x)
//        });
        animation.start();

    }
}
