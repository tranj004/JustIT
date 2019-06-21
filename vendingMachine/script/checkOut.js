function calculated() {

    var userInput = parseFloat(document.getElementsByName("clientMoney")[0].value);
    var itemCost = parseFloat(document.getElementById("totalPrice").innerHTML);
    var inputfix = userInput.toFixed(2);
    console.log(inputfix);
    console.log(itemCost);
    if (inputfix < itemCost || isNaN(inputfix) == true) {
        alert("Not enough money please enter money again.");
        return;
    } else if (itemCost == 0) {
        alert("No item purchase.");
        return;
    }else {
        var input = inputfix - itemCost;
    }
    var money = [50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01];
    var change = [];
    var i = 0;
    var result = [];
    while (input >= 0.01) {
        if (input >= money[i]) {
            change.push(money[i]);
            input -= money[i];
        } else {
            i++;
        }
    }
    for (var j = 0; change.length > j; j++)
        if (change[j] >= 1) {
            result.push("£" + change[j]);
        } else {
            result.push((change[j] * 100) + "p ");
        }
    document.getElementById("price").innerHTML = "Amount paid £" + inputfix + "<br> Your change: ";
    var current = null;
    var cnt = 0;
    for (var l = 0; l < result.length; l++) {
        if (result[l] != current) {
            if (cnt > 0) {
                document.getElementById("price").innerHTML += cnt + 'x ' + current + '<br>';
            }
            current = result[l];
            cnt = 1;
        } else {
            cnt++;
        }
    }
}
