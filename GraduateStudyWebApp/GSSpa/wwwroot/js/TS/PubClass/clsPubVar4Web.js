/*
 * 功能:为Web提供一些几个公共的功能函数
 * 版本:2019-08-07-01
 * 作者:潘以锋
 * */
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
    exports.GetLst_TabCacheAdditionCondition = exports.clsPubVar4Web = void 0;
    class clsPubVar4Web {
        static SortFun() { }
        /*
        * 重新转向本项目新的Url地址
        */
        static GetRegionId(strViewId, strRegionTypeId) {
            return 0;
        }
    }
    exports.clsPubVar4Web = clsPubVar4Web;
    function GetLst_TabCacheAdditionCondition() {
        const arrTabCacheAdditionCondition = [
            {
                tabName: "vFieldTab_Sim",
                cacheAdditionCondition: "FldId in (select fldid from prjtabfld)"
            },
            {
                tabName: "vPrjTab_Sim",
                cacheAdditionCondition: "TabStateId='01'"
            },
        ];
        return arrTabCacheAdditionCondition;
    }
    exports.GetLst_TabCacheAdditionCondition = GetLst_TabCacheAdditionCondition;
});
