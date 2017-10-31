var express = require('express');
var path = require('path');
var router = express.Router();
var fr = require('./FileStream/FileReceiver.js');

router.get('/', (req, res) => {
    res.send('node + express');
});

router.get('/test', (req, res) => {
    res.sendFile(path.join(__dirname, 'View', '/Test.html'));
});

router.post('/fileupload', (req, res) => {
    
    if (fr.filereceiver(req)) {
        res.send('upload ok');
    }
    else {
        res.send('upload fail');
    s}
    res.end();

});

module.exports = router;