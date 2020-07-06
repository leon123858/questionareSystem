function jumpto(goal,win){
    win.location.replace(goal);
}
function check(doc,n){
    var list = [];
    for(var i=1 ;i<=n;i++){
        var result = doc.getElementsByName("q" + i)[0].value;
        if(result == "")
            list.push(i);
    }
    if(list.length > 0)
        return list;
    else
        return 0;
}

