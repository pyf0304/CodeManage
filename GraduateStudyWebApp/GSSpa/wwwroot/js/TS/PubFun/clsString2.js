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
    exports.clsString = void 0;
    class clsString {
        constructor() {
            this.mstrContent = "";
        }
        Append(strAppend) {
            this.mstrContent += strAppend;
        }
        AppendFormat(strFormat, Para1, Para2, Para3, Para4, Para5, Para6, Para7, Para8, Para9) {
            if (arguments.length === 0)
                return "";
            var str = arguments[0];
            for (var i = 1; i < arguments.length; i++) {
                var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
                str = str.replace(re, arguments[i]);
            }
            this.mstrContent += str;
        }
        ToString() {
            return this.mstrContent;
        }
        /// <summary>
        /// 把单词的第一个字母变成大写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        static FirstUcaseS(mStr) {
            if (mStr.length == 0)
                return "";
            var strResult = "";
            if (mStr.length > 1) {
                strResult = mStr.substring(0, 1).toUpperCase() + mStr.substring(1, mStr.length - 1);
            }
            else {
                strResult = mStr.substring(0, 1).toUpperCase();
            }
            return strResult;
        }
        /// <summary>
        /// 把单词的第一个字母变成小写
        /// </summary>
        /// <param name="mStr"></param>
        /// <returns></returns>
        static FstLcaseS(mStr) {
            if (mStr.length == 0)
                return "";
            var strResult = "";
            if (mStr.length > 1) {
                strResult = mStr.substring(0, 1).toLowerCase() + mStr.substring(1, mStr.length - 1);
            }
            else {
                mStr = mStr.substring(0, 1).toLowerCase();
            }
            return strResult;
        }
        /// <summary>
        /// 组装字符串，
        /// </summary>
        /// <param name="mStr">原来的字符串</param>
        /// <param name="count">该字符串的重复次数</param>
        /// <returns>组装好的字符串</returns>
        static combineStrS(mStr, count) {
            var strTemp = "";
            for (var i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }
        /// <summary>
        /// 随机生成n位字符
        /// </summary>
        /// <returns></returns>
        static MakeRandom2() {
            var randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            var tmpstr = "";
            var iRandNum = Math.random() * randomchars.length;
            //Random rnd = new Random();
            for (var i = 0; i < 5; i++) {
                iRandNum = Math.random() * randomchars.length;
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        /// <summary>
        /// 随机生成n位字符
        /// </summary>
        /// <param name="intNumOfCharacters">字符数</param>
        /// <param name="intAdditionalSeed">附加种子</param>
        /// <returns>返回n位字符</returns>
        static MakeRandom(intNumOfCharacters, intAdditionalSeed) {
            var randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            var tmpstr = "";
            var jsTicks = new Date().getTime();
            var intSeed = jsTicks;
            var iRandNum = Math.random() * (intSeed + intAdditionalSeed);
            for (var i = 0; i < intNumOfCharacters; i++) {
                iRandNum = Math.random() * randomchars.length;
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        static IsNullOrEmpty(strValue) {
            if (strValue == null)
                return true;
            if (strValue.length == 0)
                return true;
            //使用字符截取指定字符
            return false;
        }
        ;
        static FormatBak() {
            if (arguments.length === 0)
                return "";
            var str = arguments[0];
            for (var i = 1; i < arguments.length; i++) {
                var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
                str = str.replace(re, arguments[i]);
            }
            return str;
        }
        static Format(strFormat, Para1, Para2, Para3, Para4, Para5, Para6, Para7, Para8, Para9) {
            if (arguments.length === 0)
                return "";
            var str = arguments[0];
            for (var i = 1; i < arguments.length; i++) {
                var re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
                str = str.replace(re, arguments[i]);
            }
            return str;
        }
    }
    exports.clsString = clsString;
});
