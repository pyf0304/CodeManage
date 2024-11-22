declare var requirejs: any;
declare var strWebRoot: string;
requirejs.config({
    baseUrl: '../',
    paths: {
        app: 'js/src/app',
        jquery: 'lib/jquery/dist/jquery',
        axios: 'lib/axios/dist/axios',
        bootstrap: 'lib/bootstrap/dist/js/bootstrap',
        popper: 'lib/bootstrap/dist/js/popper-utils',
        clscommfunc4web: 'js/ts/PubFun/clsCommFunc4Web',
        wapiTaskType_qudi_ts: 'js/Pages/BaseInfo/WApiTaskType_QUDI_TS.js'
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