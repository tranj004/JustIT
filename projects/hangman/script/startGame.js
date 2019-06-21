function startGame() {
    //Lives set and display
    var lives = 7;
    document.getElementById("lifes").innerHTML = "You have " + lives + " lives left!"

    // canvas setup
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");
    ctx.clearRect(0, 0, 300, 300)
    ctx.lineWidth = 2;
    ctx.moveTo(0, 300);
    ctx.lineTo(50, 250);
    ctx.lineTo(100, 300);
    ctx.moveTo(50, 250);
    ctx.lineTo(50, 25);
    ctx.moveTo(50, 75);
    ctx.lineTo(100, 25);
    ctx.moveTo(50, 25)
    ctx.lineTo(180, 25);
    ctx.lineTo(180, 50);
    ctx.moveTo(180, 75);
    ctx.stroke();

    function head() {
        ctx.lineWidth = 2;
        ctx.beginPath();
        ctx.arc(180, 80, 30, 0, 2 * Math.PI);
        ctx.stroke()
    }

    function draw(mx, my, lx, ly) {
        ctx.moveTo(mx, my)
        ctx.lineTo(lx, ly)
        ctx.stroke()
    }

    function chest() {
        draw(180, 110, 180, 200);
    }

    function rightArm() {
        draw(180, 130, 220, 170);
    }

    function leftArm() {
        draw(180, 130, 140, 170);
    }

    function rightLeg() {
        draw(180, 200, 140, 240);
    }

    function leftLeg() {
        draw(180, 200, 220, 240);
    }

    var hangman = [leftLeg, rightLeg, leftArm, rightArm, chest, head];
    
    //button setup
    document.getElementById("buttons").innerHTML = "";
    var alphabet = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
        'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
        'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];
    for (var i = 0; i < alphabet.length; i++) {
        document.getElementById("buttons").innerHTML += "<button>" + alphabet[i];
    }

    //random word setup
    var words = ["competition", "scrap", "recognize", "desk", "vigorous", "eat", "betray", "mess", "tape", "single"];
    var chosenWord = words[Math.floor(Math.random() * words.length)];
    console.log(words);
    console.log(chosenWord);
    var answer = [];
    for (var j = 0; j < chosenWord.length; j++) {
        answer[j] = "_";
    }
    document.getElementById("word").innerHTML = answer.join(" ");
    var remainLetters = chosenWord.length;
    
    //play
    while (remainLetters > 0) {



        if (lives <= 0) {
            alert("You have been hanged. <br> GAME OVER!");
            break;
        } else {
            for (; lives > 0; lives - 1) {
                hangman[lives - 2]
            }

        }
    }
}
