var gulp        = require('gulp');
var deploy      = require('gulp-gh-pages');
var http = require('http');
var fs = require('fs');


// Get comments data from Poole
gulp.task("comments", function() {
  
  // set up the request to get comments as YAML
  var options = {
    hostname: 'pooleapp.com',
    port: 80,
    path: '/data/e6a52fdd-8dee-4095-805a-3ea6189fc135.yaml',
    method: 'GET',
  };

  // Go and get data
  http.get(options, function(res) {
    
    var body = '';
    res.on('data', function(chunk) {
        body += chunk;
    });
    res.on('end', function() {
      
      // Save the comments for jekyll to use as a data source
      fs.writeFile('_data/comments.yml', body, function(err) {
        if(err) {
          console.log(err);
        } else {
          console.log("Comments data saved.");
        }
      });

    });
  });
});