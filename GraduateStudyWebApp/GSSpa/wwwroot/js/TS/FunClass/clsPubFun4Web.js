/*
 * 功能：为Web提供一些几个公共的功能函数
 * 版本：2019-08-07-01
 * 作者：潘以锋
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
    exports.clsPubFun4Web = void 0;
    class clsPubFun4Web {
        /*
        * 重新转向本项目新的Url地址
        */
        static GetRegionId(strViewId, strRegionTypeId) {
            return 0;
        }
        /*
      * 获取当前时间
      */
        static getNowDate() {
            const date = new Date();
            let strMonth = date.getMonth() + 1;
            let strDate = date.getDate();
            let strHours = date.getHours();
            let strMinutes = date.getMinutes();
            let strSeconds = date.getSeconds();
            if (strMonth <= 9) {
                strMonth = "0" + strMonth;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            if (strHours <= 9) {
                strHours = "0" + strHours;
            }
            if (strMinutes <= 9) {
                strMinutes = "0" + strMinutes;
            }
            if (strSeconds <= 9) {
                strSeconds = "0" + strSeconds;
            }
            return date.getFullYear().toString() + "-" + strMonth + "-" + strDate + " " + strHours + ":" + strMinutes + ":" + strSeconds;
        }
        /*
      * 获取当前时间的年月日
      */
        static getNowDate_ymd() {
            const date = new Date();
            let strMonth = date.getMonth() + 1;
            let strDate = date.getDate();
            let strHours = date.getHours();
            let strMinutes = date.getMinutes();
            let strSeconds = date.getSeconds();
            if (strMonth <= 9) {
                strMonth = "0" + strMonth;
            }
            if (strDate <= 9) {
                strDate = "0" + strDate;
            }
            return date.getFullYear().toString() + "-" + strMonth + "-" + strDate;
        }
        //日期转换
        static substrDate(strDate) {
            var strUpdDate = strDate.substr(2, 14);
            return strUpdDate;
        }
    }
    exports.clsPubFun4Web = clsPubFun4Web;
});
