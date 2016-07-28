document.getElementById("submit").onclick = function () {

    var firstName = document.getElementById('firstName').value;

    var lastName = document.getElementById('lastName').value;

    var fullName = firstName + '  ' + lastName;

    document.getElementById('fullName').innerText = fullName;

};

