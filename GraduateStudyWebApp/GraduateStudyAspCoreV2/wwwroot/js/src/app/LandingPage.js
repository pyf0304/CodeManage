(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LandingPage = void 0;
    class LandingPage {
        constructor() {
            console.log("This message is comming from Landing Page!");
        }
    }
    exports.LandingPage = LandingPage;
    //requirejs(['jquery', 'clscommonfunc4web'], function ($, commfunc) {
    //    var Test1: string = commfunc.clsCommonFunc4Web.Test1();
    //    $("#Text1").text("This message is comming from Landing Page!" + Test1);
    //});  
    requirejs(['jquery'], function ($) {
        //var Test1: string = commfunc.clsCommonFunc4Web.Test1();
        var Test1 = "Test1";
        $("#Text1").text("This message is comming from Landing Page!" + Test1);
    });
});
