declare var requirejs: any;
declare var strWebRoot: string;
requirejs.config({
    baseUrl: '../',
    paths: {
        app: 'js/src/app',
        jquery: 'lib/jquery/dist/jquery',
        bootstrap: 'lib/bootstrap/dist/js/bootstrap',
        popper: 'lib/bootstrap/dist/js/popper',
        clscommonfunc4web: 'js/ts/PubFun/clsCommonFunc4Web',
        wapicollege_qudi_ts: 'js/Pages/BaseInfo/WApiCollege_QUDI_TS.js'
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
requirejs(['app'], function (app) { });  