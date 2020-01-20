$.get("/Profile/GetUsers", null, function (res) {
    var users = JSON.parse(res);
    for (var i = 0; i < users.length; i++) {
        var newOption = "<option value='" + users[i].Id + "'>" + users[i].Email + " - " + users[i].PhoneNumber + "</option>";
        $("#select-user").append(newOption);
    }
});

$.get("/Profile/GetPositions", null, function (res) {
    var positions = JSON.parse(res);
    for (var i = 0; i < positions.length; i++) {
        var newOption = "<option value='" + positions[i].Id + "'>" + positions[i].Name + "</option>";
        $("#select-position").append(newOption);
    }
});