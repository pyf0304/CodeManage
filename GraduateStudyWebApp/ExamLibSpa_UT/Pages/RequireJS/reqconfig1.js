//declare var requirejs: any;
requirejs.config({
    baseUrl: '/',
    paths: {
        app: 'js/src/app',
        jquery: 'lib/jquery/dist/jquery',
        bootstrap: 'lib/bootstrap/dist/js/bootstrap',
        popper: 'lib/bootstrap/dist/js/popper',
        wapicollege_qudi_ts: 'js/Pages/BaseInfo/WApiCollege_QUDI_TS.js',
        clscommonfunc4web: 'js/TS/PubFun/clsCommonFunc4Web.js'

    },
    shim: {
        'bootstrap': ['jquery']
    },
    map: {
        '*': {
            'popper.js': 'popper'
        }
    }
});
requirejs(['jquery'],
    function ($) {
        $("#Text1").val("初始化成功 In Index");
        //examtype.WApiExamType_QUDI_TS.QueryExamTypeLst('divList');
        //Test4.InvokeTT44();
        //var objTest2 = new Test2.Test22();
        //var intBB = objTest2.TT1();
        //alert(intBB.toString());

    });