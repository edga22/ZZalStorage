var formidable = require('formidable');
var fs = require('fs');

// Form type file Upload 요청 처리
var filereciever = function(req) {
    var fileform = new formidable.IncomingForm();

    fileform.encoding = 'utf-8';

	fileform.parse(req, function (err, fields, files){
		var fileType = files.type.split('/').pop();
		if(fileType === 'jpg' || fileType === 'png' || fileType === 'jpeg' || fileType === 'gif'){
            var oldpath = files.filetoupload.path;
            var newpath = './imgs/' + files.filetoupload.name;
            fs.rename(oldpath, newpath, function (err) {
                if (err) throw err;
            });
        }
        else {
            fs.unlink(files.files.name);
            throw 'Invaild File Type';
        }
	});
};