var db = [];
function onChange(e, value) {
    // get animation object
    var searchBtn = $(this).jellyboSearchButton003();
    db.push(value);
    if (db.length > 3) {
        db.shift();
    }
    if (value.length < 1) {
        db = [];
    }
    //first empty suggestion list
    searchBtn.emptyList();
    for (var i in db) {
        // added new suggestions
        searchBtn.addListItem(db[i]);
    }
}