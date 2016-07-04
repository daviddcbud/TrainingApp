console.log("We are working");

var x = 1;
var y = 2;
var result = x + y;
console.log('x + y = ' + result);

var name = "david";
console.log(name.toUpperCase());
console.log(name);

var index = name.indexOf("v");
console.log(index);

var names = [];
names.push('david');
names.push('alaina');
console.log('names has a length of ', names.length);
console.log('the name at pos 1 is ', names[1]);

LogArray(names);
names.push('devan');
LogArray(names);
var num = 10;
if (num <= 5) {
    console.log(' less than 5');
}
else if (num <= 7) {
    console.log(' less than 7');
}
else {
    console.log(' > than 5');
}

function LogArray(array) {
    for (var i = 0; i <= array.length - 1; i++) {
        console.log(array[i]);
    }

}

var name = "David Freeman";
document.getElementById('name').value = name;

document.getElementById('submit').onclick = function () {
    var name = document.getElementById("name").value;
    var age = document.getElementById("age").value;
    var favFood = document.getElementById("favFood").value;
    var emailMe = document.getElementById("emailMe").value;

    var resultHtml = "Name : " + name + "<br/>";

    resultHtml += " Age :" + age + "<br/>";
    resultHtml += " FavFood " + favFood + "<br/>";
    resultHtml += "Email Me " + emailMe + "<br/>";
    document.getElementById("result").innerHTML = resultHtml;
};