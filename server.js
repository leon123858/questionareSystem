'use strict';
var http = require('http');
var MongoClient = require('mongodb').MongoClient;
var sd = require('silly-datetime');

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

function insertperson(parameters) {
    MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
        if (err) throw err;
        console.log("It's person add start");
        if (parameters.length > 0 && parseInt(parameters[0]) > 0) {
            var table = db.db("personq").collection(parameters[1]);
            console.log(parameters[1]);
            var obj = { qn: parameters[0] };
            for (var i = 2; i < parameters.length; i++) {
                obj[i - 1] = parameters[i];
            }
            obj['date'] = time;
            table.insertOne(obj, function (err, red) { // insertMany 是插入多個用的
                if (err) throw err;
                console.log("It's person add end");
                db.close();
            });
        }
    });
}

http.createServer(function (req, res) {
	res.setHeader('Access-Control-Allow-Origin', '*');
    res.writeHeader(200, {
        'Content-Type': 'text/html;charset=utf-8'
    });
    var obj = {
        say: '抱歉，找不到您的網頁。',
    };
    var time = sd.format(new Date(), 'YYYY-MM-DD HH:mm:ss');
    //console.log(time);
    var list = req.url.split('?');
    var pathname = list[0];
    var parameter = [];
    if (list.length > 1) {
        parameter = list[1].split('_');
    }
    if (pathname == '/') {
        obj.say = '歡迎來到我們首頁。';
        var json = JSON.stringify(obj);
        res.end(json);
    }
    else if (pathname == '/insert') {
        MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
            if (err) throw err;
            console.log("It's add start");
			if(parameter.length > 0){
				var table = db.db("qn").collection("qn" + parameter[0]);
				console.log(parameter);
                var obj = { num: parameter[1] };
				for(var i=2;i<parameter.length;i++){
                    obj[i - 1] = parameter[i];
                }
                obj['date'] = time;
				table.insertOne(obj, function (err, red) { // insertMany 是插入多個用的
					if (err) throw err;
					console.log("insert success");
					obj.result = 'success';
					var json = JSON.stringify(obj);
					res.end(json);
					console.log("It's add end");
                    db.close();
                    //insertperson(parameter);
				});
			}
			else{
				obj.result = 'fail';
				var json = JSON.stringify(obj);
				res.end(json);
			}
        });
    }
}).listen(process.env.PORT || 8080, () => {
    console.log('started web process');
});