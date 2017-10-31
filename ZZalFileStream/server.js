var route = require('./route.js');
var express = require('express');
var app = express();

// imgs �������� �ִ� ���ϵ��� ���� ���� ������
app.use('/imgs', express.static(__dirname + '/imgs'));

app.use('/', route);

app.use((req, res, next) => {
    res.status(404).send('�߸��� �ּ� ��û�Դϴ�');
});

app.use((err, req, res, next) => {
    console.error(err.stack);
    res.status(500).send('Server Error');
});

app.listen(3000, function () {
    console.log('app started , listen to 3000 port');
});