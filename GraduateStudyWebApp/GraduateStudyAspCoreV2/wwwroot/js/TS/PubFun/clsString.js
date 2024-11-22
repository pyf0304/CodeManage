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
    exports.GetStrByNumWithLen = exports.CombineStrS = exports.HtmlDecode = exports.HtmlEncode = exports.GetStrLen = exports.getBytes = exports.FstLcaseS = exports.FirstUcaseS = exports.MakeRandom = exports.tzDataType = exports.TransToBool = exports.Format = exports.IsNullOrEmpty = exports.clsStringBak = void 0;
    class clsStringBak {
        constructor() {
            this.mstrContent = "";
        }
        Append(strAppend) {
            this.mstrContent += strAppend;
        }
        // public AppendFormat(strFormat: string, Para1?: any, Para2?: any, Para3?: any, Para4?: any, Para5?: any, Para6?: any, Para7?: any, Para8?: any, Para9?: any) {
        //     if (arguments.length === 0)
        //         return "";
        //     let str = arguments[0];
        //     for (let i = 1; i < arguments.length; i++) {
        //         const re = new RegExp('\\{' + (i - 1) + '\\}', 'gm');
        //         str = str.replace(re, arguments[i]);
        //     }
        //     this.mstrContent += str;
        // }
        ToString() {
            return this.mstrContent;
        }
        /// <summary>
        /// 随机生成n位字符
        /// </summary>
        /// <returns></returns>
        static MakeRandom2() {
            const randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //			int pwdlen=5;
            let tmpstr = "";
            let iRandNum = Math.random() * randomchars.length;
            //Random rnd = new Random();
            for (let i = 0; i < 5; i++) {
                iRandNum = Math.random() * randomchars.length;
                tmpstr += randomchars[iRandNum];
            }
            return tmpstr;
        }
        static IsNullOrEmpty(strValue) {
            if (strValue == null)
                return true;
            //if (strValue == undefined) return true;
            if (strValue.length == 0)
                return true;
            //使用字符截取指定字符
            return false;
        }
        ;
    }
    exports.clsStringBak = clsStringBak;
    function IsNullOrEmpty(strValue) {
        if (strValue == null)
            return true;
        if (strValue.length == 0)
            return true;
        //使用字符截取指定字符
        return false;
    }
    exports.IsNullOrEmpty = IsNullOrEmpty;
    function Format(strFormat, ...theArgs) {
        if (arguments.length === 0)
            return "";
        let str = strFormat;
        for (let i = 0; i < theArgs.length; i++) {
            const re = new RegExp('\\{' + (i) + '\\}', 'gm');
            str = str.replace(re, theArgs[i]);
        }
        return str;
    }
    exports.Format = Format;
    function TransToBool(strValue) {
        var strValue_Lower = strValue.toLowerCase();
        if (strValue_Lower === "true")
            return true;
        if (strValue_Lower === "false")
            return false;
        if (strValue_Lower === "1")
            return true;
        if (strValue_Lower === "0")
            return false;
        return false;
    }
    exports.TransToBool = TransToBool;
    var gettype = Object.prototype.toString;
    exports.tzDataType = {
        isObj: function (o) {
            return gettype.call(o) == "[object Object]";
        },
        isArray: function (o) {
            return gettype.call(o) == "[object Array]";
        },
        isNULL: function (o) {
            return gettype.call(o) == "[object Null]";
        },
        isDocument: function (o) {
            return gettype.call(o) == "[object Document]" || "[object HTMLDocument]";
        },
        isNumber: function (o) {
            return gettype.call(o) == "[object Number]";
        },
        isString: function (o) {
            return gettype.call(o) == "[object String]";
        },
        isBoolean: function (o) {
            return gettype.call(o) == "[object Boolean]";
        }
        //         ........
    };
    /// <summary>
    /// 随机生成n位字符
    /// </summary>
    /// <param name="intNumOfCharacters">字符数</param>
    /// <param name="intAdditionalSeed">附加种子</param>
    /// <returns>返回n位字符</returns>
    function MakeRandom(intNumOfCharacters, intAdditionalSeed) {
        const randomchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //			int pwdlen=5;
        let tmpstr = "";
        const jsTicks = new Date().getTime();
        const intSeed = jsTicks;
        let iRandNum = Math.random() * (intSeed + intAdditionalSeed);
        for (let i = 0; i < intNumOfCharacters; i++) {
            iRandNum = Math.random() * randomchars.length;
            tmpstr += randomchars[iRandNum];
        }
        return tmpstr;
    }
    exports.MakeRandom = MakeRandom;
    /// <summary>
    /// 把单词的第一个字母变成大写
    /// </summary>
    /// <param name="mStr"></param>
    /// <returns></returns>
    function FirstUcaseS(mStr) {
        if (mStr.length == 0)
            return "";
        let strResult = "";
        if (mStr.length > 1) {
            strResult = mStr.substring(0, 1).toUpperCase() + mStr.substring(1, mStr.length);
        }
        else {
            strResult = mStr.substring(0, 1).toUpperCase();
        }
        return strResult;
    }
    exports.FirstUcaseS = FirstUcaseS;
    /// <summary>
    /// 把单词的第一个字母变成小写
    /// </summary>
    /// <param name="mStr"></param>
    /// <returns></returns>
    function FstLcaseS(mStr) {
        if (mStr.length == 0)
            return "";
        let strResult = "";
        if (mStr.length > 1) {
            strResult = mStr.substring(0, 1).toLowerCase() + mStr.substring(1, mStr.length);
        }
        else {
            mStr = mStr.substring(0, 1).toLowerCase();
        }
        return strResult;
    }
    exports.FstLcaseS = FstLcaseS;
    function getBytes(str) {
        const len = str.length;
        let bytes = len;
        for (let i = 0; i < len; i++) {
            if (str.charCodeAt(i) > 255)
                bytes++;
        }
        return bytes;
    }
    exports.getBytes = getBytes;
    function GetStrLen(strTemp) {
        //byte[] sarr = System.text.Encoding.Default.GetBytes(strTemp);
        const len = strTemp.length; //.characters.count; //will output as 3+3*2=9
        return len;
    }
    exports.GetStrLen = GetStrLen;
    /**
     * HTML编码
     * @param txtstr源串
     * @returns 生成不能进行HTML解释的字符串
     */
    function HtmlEncode(txtstr) {
        if (IsNullOrEmpty(txtstr) == false) {
            txtstr = txtstr.replace(">", "&gt;");
            txtstr = txtstr.replace("<", "&lt;");
            txtstr = txtstr.replace(" ", "&nbsp;");
            txtstr = txtstr.replace("\"", "&quot;");
            txtstr = txtstr.replace("\r\n", "<br>");
        }
        return txtstr;
    }
    exports.HtmlEncode = HtmlEncode;
    /**
     *  Html代码的解码
     * @param txtstr 源串
     * @returns 生成可以解释的HTML代码
     */
    function HtmlDecode(txtstr) {
        if (IsNullOrEmpty(txtstr) == false) {
            txtstr = txtstr.replace("&gt;", ">");
            txtstr = txtstr.replace("&lt;", "<");
            txtstr = txtstr.replace("&nbsp;", " ");
            txtstr = txtstr.replace("&quot;", "\"");
            txtstr = txtstr.replace("<br>", "\r\n");
        }
        return txtstr;
    }
    exports.HtmlDecode = HtmlDecode;
    /// <summary>
    /// 组装字符串，
    /// </summary>
    /// <param name="mStr">原来的字符串</param>
    /// <param name="count">该字符串的重复次数</param>
    /// <returns>组装好的字符串</returns>
    function CombineStrS(mStr, count) {
        let strTemp = "";
        for (let i = 0; i < count; i++)
            strTemp += mStr;
        return strTemp;
    }
    exports.CombineStrS = CombineStrS;
    function GetStrByNumWithLen(intNum, intLen) {
        let strTemp = intNum.toString();
        const intLen_Temp = strTemp.length;
        if (intLen_Temp > intLen) {
            const int1 = intLen_Temp - intLen;
            return strTemp.substring(0, intLen);
        }
        else if (intLen_Temp == intLen) {
            return strTemp;
        }
        else {
            const int1 = intLen - intLen_Temp;
            let mStr = Format("{0}{1}", CombineStrS("0", int1), strTemp);
            return mStr;
        }
    }
    exports.GetStrByNumWithLen = GetStrByNumWithLen;
});
