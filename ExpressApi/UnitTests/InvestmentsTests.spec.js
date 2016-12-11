describe('Investments', function(){
    //https://glebbahmutov.com/blog/how-to-correctly-unit-test-express-server/
    //https://www.codementor.io/nodejs/tutorial/unit-testing-nodejs-tdd-mocha-sinon
    //https://blog.risingstack.com/node-hero-node-js-unit-testing-tutorial/
    // https://www.codementor.io/nodejs/tutorial/testing-express-apis-with-supertest
    // https://github.com/visionmedia/supertest
    // https://github.com/M6Web/superagent-mock
    
    // to run tests
    //cd UnitTests
    //mocha spec --recursive --watch
      var chai = require("chai");
      var expect = chai.expect;


      var server= require('../HouseholdApi.js');
      var request = require('supertest');
      beforeEach(function () {
        // server = require('../../HouseholdApi.js').listen(3000);
      });
      afterEach(function (done) {
        server.close();
        done();
      });
      it('responds to /', function testSlash(done) {
      request(server)
        .get('/')
        .expect(200)
        .end(done);
       });
      it('404 not found', function testPath(done) {
        request(server)
          .get('/foo/bar')
          .expect(404)
          .end(done);
      });

      it('POST /transaction', function testTransactionsPost(done){
        request(server)
          .post('/investments/transaction')
          .expect(200, {
              id: '1'
          }, done)
          // .end(done);
          .end(function(err, res){
            if (err) return done(err);
            done();
          });

      });
});
