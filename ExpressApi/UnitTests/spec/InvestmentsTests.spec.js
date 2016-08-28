describe('Investments', function(){
    //https://glebbahmutov.com/blog/how-to-correctly-unit-test-express-server/
    //https://www.codementor.io/nodejs/tutorial/unit-testing-nodejs-tdd-mocha-sinon
    //https://blog.risingstack.com/node-hero-node-js-unit-testing-tutorial/
    // to run tests
    //cd UnitTests
    //mocha spec --recursive --watch
      var chai = require("chai");
      var expect = chai.expect;
      var server= require('../../HouseholdApi.js');
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
      it('404 everything else', function testPath(done) {
        request(server)
          .get('/foo/bar')
          .expect(404)
          .end(done);
      });
      it('should fail', function () {
          expect(true).to.equal(true);
        });
});
