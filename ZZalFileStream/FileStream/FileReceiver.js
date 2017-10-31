var formidable = require('formidable');
var fs = require('fs');
var mv = require('mv');

// Form type file Upload 요청 처리
exports.filereceiver = function(req) {
    var fileform = new formidable.IncomingForm();

    fileform.encoding = 'utf-8';

    fileform.parse(req, function (err, fields, files) {
        var oldpath = files.filetoupload.path;
        var newpath = './imgs/' + files.filetoupload.name;
        
        mv(oldpath, newpath, function (err) {
            if (err) throw err;
        });
        return true;

		//var fileType = files.type.split('/').pop();
		//if(fileType === 'jpg' || fileType === 'png' || fileType === 'jpeg' || fileType === 'gif'){
  //          var oldpath = files.filetoupload.path;
  //          var newpath = './imgs/' + files.filetoupload.name;
  //          fs.rename(oldpath, newpath, function (err) {
  //              if (err) throw err;
  //          });
  //          return true;
  //      }
  //      else {
  //          for (file in files.files){
  //              fs.unlink(file.path);
  //          }
            
  //          return false;
  //      }
	});
};