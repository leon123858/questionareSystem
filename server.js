'use strict';
var http = require('http');
var MongoClient = require('mongodb').MongoClient;

// Read in keys and secrets. Using nconf use can set secrets via
// environment variables, command-line arguments, or a keys.json file.
var uri = "mongodb+srv://leon1234858:8ntscpal@cluster0.gyixj.gcp.mongodb.net/?retryWrites=true&w=majority";
console.log(uri);

MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
    if (err) throw err;
    console.log("It's test start");
    db.close();
    console.log("It's test end");
});

http.createServer(function (req, res) {
    res.writeHeader(200, {
        'Content-Type': 'text/html;charset=utf-8'
    });
    var obj = {
        say: '抱歉，找不到您的網頁。',
    };
    var list = req.url.split('?');
    var pathname = list[0];
    var parameter = [];
    if (list.length > 1) {
        var paraList = list[1].split('&');
        for (var i = 0; i < paraList.length; i++) {
            if (paraList[i] == '') break;
            parameter[i] = paraList[i].split('=')[1];
        }
        for (var i = 0; i < parameter.length; i++) {
            console.log(parameter[i]);
        }
    }
    if (pathname == '/') {
        obj.say = '歡迎來到我們首頁。';
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/about') {
        obj.say = '歡迎來到關於我們。';
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/delete') {
        MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
            if (err) throw err;
            console.log("It's delete start");
            var table = db.db("testdb").collection("a");
            var whereStr = { name: "baby", value: parameter[0] };
            table.deleteMany(whereStr, function (err, res) { // insertMany 是插入多個用的
                if (err) throw err;
                console.log(res.result + " delete success");
            });
            console.log("It's delete end");
            db.close();
        });
        obj.say = "in delete";
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/add') {
        MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
            if (err) throw err;
            console.log("It's add start");
            var table = db.db("testdb").collection("a");
            var obj = { name: "baby", value: "it is cute" };
            table.insertOne(obj, function (err, res) { // insertMany 是插入多個用的
                if (err) throw err;
                console.log("insert success");
            });
            console.log("It's add end");
            db.close();
        });
        obj.say = '增加數據成功';
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/edit') {
        MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
            if (err) throw err;
            console.log("It's edit start");
            var table = db.db("testdb").collection("a");
            var whereStr = { "name": 'baby' };  // 查询条件
            var updateStr = { $set: { "value": "CCCCCUUUUUTTTTTEEEEE" } };
            table.updateMany(whereStr, updateStr, function (err, res) {
                if (err) throw err;
                console.log(res.result.nModified + " line been set");
            });
            console.log("It's edit end");
            db.close();
        });
        obj.say = '編輯成功';
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/find') {
        if (parameter.length > 0) {
            MongoClient.connect(uri, function (err, db) {
                if (err) throw err;
                var table = db.db("testdb").collection("a");
                var findThing = { name: parameter[0] };
                table.find(findThing, { projection: { _id: 0, name: 1, value: 1 } }).toArray(function (err, result) {
                    if (err) throw err;
                    var relist = [];
                    if (result != null) {
                        for (var i = 0; i < result.length; i++)
                            relist[i] = result[i];
                    }
                    console.log(relist);
                    //console.log(relist[1].value); //直接呼叫特定回傳值
                    var json = JSON.stringify(relist);
                    res.end(json);
                    db.close();
                });
            });
        }
        else {
            obj.say = '沒填參數';
            var json = JSON.stringify(obj);
            res.end(json);
        }
    }
}).listen(process.env.PORT || 8080, () => {
    console.log('started web process');
});