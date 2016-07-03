describe('Investments', function(){
    //https://glebbahmutov.com/blog/how-to-correctly-unit-test-express-server/
    //https://www.npmjs.com/package/jasmine-node-karma
    // to run tests
    //jasmine-node-karma InvestmentsTests.spec.js
      var server;
      beforeEach(function () {
        server = require('../../HouseholdApi')();
      });
      afterEach(function () {
        server.close();
      });
      it('responds to /', function testSlash(done) {
      request(server)
        .get('/')
        .expect(200, done);
      });
      it('404 everything else', function testPath(done) {
        request(server)
          .get('/foo/bar')
          .expect(404, done);
      });
});
