var http = require('http');

var handleRequest = function (request, response) {
    response.writeHead(200);
    response.end('Hello World!');
};
var server = http.createServer(handleRequest);
console.log("39 ways to run a webserver: nodejs")
server.listen(8080);