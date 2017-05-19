
import { UserModel } from "../models/csharpUser";

let chai = require("chai");
chai.should();

describe("CsharpUser", function() {

  describe("GetList()", function () {
    it("should show a message", function () {
        console.log( new UserModel().GetList());
    });
  });
});