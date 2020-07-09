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

function insertpersonall_update(parameters) {
    MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
        if (err) throw err;
        console.log("It's person update start");
        var table = db.db("personq").collection("personall");
        var num = parameters[1];
        var str = "abcdefghi";
        var int_str = [19, 28, 31, 21, 18, 25, 14, 16, 76];
        var goal = { num: num };
        var obj = { $set: {  }};
        var first = str[parseInt(parameters[0])];
        var count = int_str[parseInt(parameters[0])];
        for (var i = 1; i <= count; i++) {
            obj.$set[first + i] = parameters[i + 1];
        }
        table.updateOne(goal, obj, function (err, red) { // insertMany 是插入多個用的
            if (err) throw err;
            console.log("It's person update end");
            db.close();
        });
    });
}

function insertpersonall_insert(parameters) {
    MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
        if (err) throw err;
        console.log("It's person insert start");
        var table = db.db("personq").collection("personall");
        var num = parameters[1];
        var str = "abcdefghi";
        var int_str = [19, 28, 31, 21, 18, 25, 14, 16, 76];
        var obj = { num: num, a1: 'NA', a2: 'NA', a3: 'NA', a4: 'NA', a5: 'NA', a6: 'NA', a7: 'NA', a8: 'NA', a9: 'NA', a10: 'NA', a11: 'NA', a12: 'NA', a13: 'NA', a14: 'NA', a15: 'NA', a16: 'NA', a17: 'NA', a18: 'NA', a19: 'NA', b1: 'NA', b2: 'NA', b3: 'NA', b4: 'NA', b5: 'NA', b6: 'NA', b7: 'NA', b8: 'NA', b9: 'NA', b10: 'NA', b11: 'NA', b12: 'NA', b13: 'NA', b14: 'NA', b15: 'NA', b16: 'NA', b17: 'NA', b18: 'NA', b19: 'NA', b20: 'NA', b21: 'NA', b22: 'NA', b23: 'NA', b24: 'NA', b25: 'NA', b26: 'NA', b27: 'NA', b28: 'NA', c1: 'NA', c2: 'NA', c3: 'NA', c4: 'NA', c5: 'NA', c6: 'NA', c7: 'NA', c8: 'NA', c9: 'NA', c10: 'NA', c11: 'NA', c12: 'NA', c13: 'NA', c14: 'NA', c15: 'NA', c16: 'NA', c17: 'NA', c18: 'NA', c19: 'NA', c20: 'NA', c21: 'NA', c22: 'NA', c23: 'NA', c24: 'NA', c25: 'NA', c26: 'NA', c27: 'NA', c28: 'NA', c29: 'NA', c30: 'NA', c31: 'NA', d1: 'NA', d2: 'NA', d3: 'NA', d4: 'NA', d5: 'NA', d6: 'NA', d7: 'NA', d8: 'NA', d9: 'NA', d10: 'NA', d11: 'NA', d12: 'NA', d13: 'NA', d14: 'NA', d15: 'NA', d16: 'NA', d17: 'NA', d18: 'NA', d19: 'NA', d20: 'NA', d21: 'NA', e1: 'NA', e2: 'NA', e3: 'NA', e4: 'NA', e5: 'NA', e6: 'NA', e7: 'NA', e8: 'NA', e9: 'NA', e10: 'NA', e11: 'NA', e12: 'NA', e13: 'NA', e14: 'NA', e15: 'NA', e16: 'NA', e17: 'NA', e18: 'NA', f1: 'NA', f2: 'NA', f3: 'NA', f4: 'NA', f5: 'NA', f6: 'NA', f7: 'NA', f8: 'NA', f9: 'NA', f10: 'NA', f11: 'NA', f12: 'NA', f13: 'NA', f14: 'NA', f15: 'NA', f16: 'NA', f17: 'NA', f18: 'NA', f19: 'NA', f20: 'NA', f21: 'NA', f22: 'NA', f23: 'NA', f24: 'NA', f25: 'NA', g1: 'NA', g2: 'NA', g3: 'NA', g4: 'NA', g5: 'NA', g6: 'NA', g7: 'NA', g8: 'NA', g9: 'NA', g10: 'NA', g11: 'NA', g12: 'NA', g13: 'NA', g14: 'NA', h1: 'NA', h2: 'NA', h3: 'NA', h4: 'NA', h5: 'NA', h6: 'NA', h7: 'NA', h8: 'NA', h9: 'NA', h10: 'NA', h11: 'NA', h12: 'NA', h13: 'NA', h14: 'NA', h15: 'NA', h16: 'NA', i1: 'NA', i2: 'NA', i3: 'NA', i4: 'NA', i5: 'NA', i6: 'NA', i7: 'NA', i8: 'NA', i9: 'NA', i10: 'NA', i11: 'NA', i12: 'NA', i13: 'NA', i14: 'NA', i15: 'NA', i16: 'NA', i17: 'NA', i18: 'NA', i19: 'NA', i20: 'NA', i21: 'NA', i22: 'NA', i23: 'NA', i24: 'NA', i25: 'NA', i26: 'NA', i27: 'NA', i28: 'NA', i29: 'NA', i30: 'NA', i31: 'NA', i32: 'NA', i33: 'NA', i34: 'NA', i35: 'NA', i36: 'NA', i37: 'NA', i38: 'NA', i39: 'NA', i40: 'NA', i41: 'NA', i42: 'NA', i43: 'NA', i44: 'NA', i45: 'NA', i46: 'NA', i47: 'NA', i48: 'NA', i49: 'NA', i50: 'NA', i51: 'NA', i52: 'NA', i53: 'NA', i54: 'NA', i55: 'NA', i56: 'NA', i57: 'NA', i58: 'NA', i59: 'NA', i60: 'NA', i61: 'NA', i62: 'NA', i63: 'NA', i64: 'NA', i65: 'NA', i66: 'NA', i67: 'NA', i68: 'NA', i69: 'NA', i70: 'NA', i71: 'NA', i72: 'NA', i73: 'NA', i74: 'NA', i75: 'NA', i76: 'NA' };
        var first = str[parseInt(parameters[0])];
        var count = int_str[parseInt(parameters[0])];
        for (var i = 1; i <= count; i++) {
            obj[first + i] = parameters[i+1];
        }
        table.insertOne(obj, function (err, red) { // insertMany 是插入多個用的
            if (err) throw err;
            console.log("It's person insert end");
            db.close();
        });
    });
}

function insertpersonall(parameters) {
    MongoClient.connect(uri, { useNewUrlParser: true }, function (err, db) {
        if (err) throw err;
        console.log("It's person add start");
        var table = db.db("personq").collection("personall");
        var num = parameters[1];
        console.log(num);
        var obj = { num: num };
        table.findOne(obj, function (err, red) { // insertMany 是插入多個用的
            if (err) throw err;
            console.log("It's person add end");
            db.close();
            if (red) {
                insertpersonall_update(parameters);
            }
            else {
                insertpersonall_insert(parameters);
            }
        });
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
            if (parameter.length > 0) {
                var table = db.db("qn").collection("qn" + parameter[0]);
                console.log(parameter);
                var obj = { num: parameter[1] };
                for (var i = 2; i < parameter.length; i++) {
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
                    insertpersonall(parameter);
                });
            }
            else {
                obj.result = 'fail';
                var json = JSON.stringify(obj);
                res.end(json);
            }
        });
    }
}).listen(process.env.PORT || 8080, () => {
    console.log('started web process');
});