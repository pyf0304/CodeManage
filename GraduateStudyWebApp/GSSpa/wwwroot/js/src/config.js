"use strict";
requirejs.config({
    baseUrl: '../',
    paths: {
        app: 'js/src/app',
        jquery: 'lib/jquery/dist/jquery',
        bootstrap: 'lib/bootstrap/dist/js/bootstrap',
        popper: 'lib/bootstrap/dist/js/popper-utils',
        clscommonfunc4web: 'js/ts/PubFun/clsCommonFunc4Web',
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
