export class LandingPage {
    constructor() {
        console.log("This message is comming from Landing Page!");
    }
}
//requirejs(['jquery', 'clscommonfunc4web'], function ($, commfunc) {
//    var Test1: string = commfunc.clsCommonFunc4Web.Test1();
//    $("#Text1").text("This message is comming from Landing Page!" + Test1);
   
//});  

requirejs(['jquery'], function ($) {
    //var Test1: string = commfunc.clsCommonFunc4Web.Test1();
    var Test1 = "Test1";
    $("#Text1").text("This message is comming from Landing Page!" + Test1);

});  