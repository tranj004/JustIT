function total() {
    var apple = 3.99;
    var banana = 2.99;
    var cherry = 1.99;
    var appleItems = 0;
    var bananaItems = 0;
    var chreeyItems = 0;
    if (document.getElementsByName("appleAmount")[0].value == null || document.getElementsByName("appleAmount")[0].value < 0) {
        alert("Invalid amount please re-enter.")
        return;
    } else {
        appleItems = document.getElementsByName("appleAmount")[0].value * apple;
    }

    if (document.getElementsByName("bananaAmount")[0].value == null || document.getElementsByName("bananaAmount")[0].value < 0) {
        alert("Invalid amount please re-enter.")
        return;
    } else {
        bananaItems = document.getElementsByName("bananaAmount")[0].value * banana;
    }
    if (document.getElementsByName("cherryAmount")[0].value == null || document.getElementsByName("cherryAmount")[0].value < 0) {
        alert("Invalid amount please re-enter.")
        return;
    } else {
        chreeyItems = document.getElementsByName("cherryAmount")[0].value * cherry;
    }
    var totalPrice = appleItems + bananaItems + chreeyItems;
    document.getElementById("appleTotal").innerHTML = "£" + appleItems.toFixed(2);
    document.getElementById("bananaTotal").innerHTML = "£" + bananaItems.toFixed(2);
    document.getElementById("cherryTotal").innerHTML = "£" + chreeyItems.toFixed(2);
    document.getElementById("totalPrice").innerHTML = totalPrice.toFixed(2);
}
