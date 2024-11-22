(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SessionStorage_GetKeyByPrefix = exports.LocalStorage_GetKeyByPrefix = exports.CacheHelper = void 0;
    const clsString_js_1 = require("./clsString.js");
    class CacheHelper {
        static get CacheLength1() {
            return CacheHelper.CacheDictionary.length;
        }
        static CacheLength() {
            let intCount = 0;
            for (const k in CacheHelper.CacheDictionary) {
                intCount++;
            }
            return intCount;
        }
        ;
        /// <summary>
        /// 获取缓存
        /// </summary>
        static Key(index) {
            let rlt = "";
            if (index >= 0 && index < CacheHelper.CacheDictionary.length) {
                rlt = CacheHelper.CacheDictionary[index];
            }
            return rlt;
        }
        /// <summary>
        /// 添加缓存
        /// </summary>
        static Add(key, value) {
            CacheHelper.CacheDictionary[key] = value;
        }
        /// <summary>
        /// 删除给定关键
        /// </summary>
        /// <param name="key"></param>
        static Remove(key) {
            if (CacheHelper.Exsits(key)) {
                delete CacheHelper.CacheDictionary[key];
            }
        }
        /// <summary>
        /// 获取缓存
        /// </summary>
        static Get(key) {
            return CacheHelper.CacheDictionary[key];
        }
        /// <summary>
        /// 判断缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        static Exsits(key) {
            return Object.prototype.hasOwnProperty.call(CacheHelper.CacheDictionary, key);
        }
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        static GetCache(key, func) {
            let t;
            if (CacheHelper.Exsits(key)) {
                //缓存存在，直接获取原数据
                t = CacheHelper.Get(key);
            }
            else {
                //缓存不存在，去生成缓存，并加入容器
                console.log(key);
                console.log(func);
                t = func(key);
                CacheHelper.Add(key, t);
            }
            return t;
        }
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        static GetCacheByCondition(key, strCondition, func) {
            let t;
            if (CacheHelper.Exsits(key)) {
                //缓存存在，直接获取原数据
                t = CacheHelper.Get(key);
            }
            else {
                //缓存不存在，去生成缓存，并加入容器
                console.log(key);
                console.log(func);
                t = func(strCondition);
                CacheHelper.Add(key, t);
            }
            return t;
        }
        static GetCacheByConditionAsync(key, strCondition, func) {
            let t;
            if (CacheHelper.Exsits(key)) {
                //缓存存在，直接获取原数据
                t = CacheHelper.Get(key);
            }
            else {
                //缓存不存在，去生成缓存，并加入容器
                console.log(key);
                console.log(func);
                t = func(strCondition);
                CacheHelper.Add(key, t);
            }
            return t;
        }
        static getBytes(str) {
            const len = str.length;
            let bytes = len;
            for (let i = 0; i < len; i++) {
                if (str.charCodeAt(i) > 255)
                    bytes++;
            }
            return bytes;
        }
        static localStorageSubTotals() {
            let strKey;
            let myCache;
            let strCacheKeyLst = "";
            let intTotals = 0;
            for (let i = 0; i < localStorage.length; i++) {
                strKey = localStorage.key(i);
                if (strKey == null)
                    continue;
                if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
                    continue;
                strCacheKeyLst += (0, clsString_js_1.Format)("{0},", strKey);
                //拿到所有含u-的key
                myCache = localStorage.getItem(strKey);
                if (myCache == null) {
                    //objCacheUseState.cacheSize = 0;
                }
                else {
                    intTotals += this.getBytes(myCache);
                }
            }
            intTotals = intTotals / 1024;
            const strTotals = (0, clsString_js_1.Format)("{0}KB", intTotals.toFixed(2));
            return intTotals;
        }
        static sessionStorageSubTotals() {
            let strKey;
            let myCache;
            let strCacheKeyLst = "";
            let intTotals = 0;
            for (let i = 0; i < sessionStorage.length; i++) {
                strKey = sessionStorage.key(i);
                if (strKey == null)
                    continue;
                if ((0, clsString_js_1.IsNullOrEmpty)(strKey) == true)
                    continue;
                strCacheKeyLst += (0, clsString_js_1.Format)("{0},", strKey);
                //拿到所有含u-的key
                myCache = sessionStorage.getItem(strKey);
                if (myCache == null) {
                    //objCacheUseState.cacheSize = 0;
                }
                else {
                    intTotals += this.getBytes(myCache);
                }
            }
            intTotals = intTotals / 1024;
            const strTotals = (0, clsString_js_1.Format)("{0}KB", intTotals.toFixed(2));
            return intTotals;
        }
        static ClearLocalStorage() {
            const arrCacheKeyLst = new Array();
            for (let i = 0; i < localStorage.length; i++) {
                const strKey = localStorage.key(i);
                if (strKey != null) {
                    arrCacheKeyLst.push(strKey);
                }
                //拿到所有含u-的key
            }
            //        alert(strCacheKeyLst);
            arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
        }
        static ClearSessionStorage() {
            const arrCacheKeyLst = new Array();
            for (let i = 0; i < sessionStorage.length; i++) {
                const strKey = sessionStorage.key(i);
                if (strKey != null) {
                    arrCacheKeyLst.push(strKey);
                }
                //拿到所有含u-的key
            }
            //        alert(strCacheKeyLst);
            arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
        }
        static ClearLocalStorage4Head(strHead) {
            const arrCacheKeyLst = new Array();
            for (let i = 0; i < localStorage.length; i++) {
                const strKey = localStorage.key(i);
                if (strKey != null) {
                    if (strKey.indexOf(strHead) == 0) {
                        arrCacheKeyLst.push(strKey);
                    }
                }
                //拿到所有含u-的key
            }
            //        alert(strCacheKeyLst);
            arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
        }
        static ClearSessionStorage4Head(strHead) {
            const arrCacheKeyLst = new Array();
            for (let i = 0; i < sessionStorage.length; i++) {
                const strKey = sessionStorage.key(i);
                if (strKey != null) {
                    if (strKey.indexOf(strHead) == 0) {
                        arrCacheKeyLst.push(strKey);
                    }
                }
                //拿到所有含u-的key
            }
            //        alert(strCacheKeyLst);
            arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
        }
    }
    exports.CacheHelper = CacheHelper;
    //缓存容器 
    CacheHelper.CacheDictionary = {};
    //export function GetSession_CacheAdditionCondition(strTabName: string) {
    //    const arrTabCacheAdditionCondition = GetLst_TabCacheAdditionCondition();
    //    const objCacheAdditionCondition = arrTabCacheAdditionCondition.find(x => x.tabName == strTabName);
    //    if (objCacheAdditionCondition == null) return "";
    //    return objCacheAdditionCondition.cacheAdditionCondition;
    //}
    /**
     * 在LocalStorage中查找某前缀的关键字
     * @param strPrefix：前缀
     */
    function LocalStorage_GetKeyByPrefix(strPrefix) {
        const arrCacheKeyLst = new Array();
        for (let i = 0; i < localStorage.length; i++) {
            const strKey = localStorage.key(i);
            if (strKey != null) {
                if (strKey.indexOf(strPrefix) >= 0)
                    arrCacheKeyLst.push(strKey);
            }
            //拿到所有含u-的key
        }
        //        alert(strCacheKeyLst);
        return arrCacheKeyLst;
    }
    exports.LocalStorage_GetKeyByPrefix = LocalStorage_GetKeyByPrefix;
    /**
     * 在LocalStorage中查找某前缀的关键字
     * @param strPrefix：前缀
     */
    function SessionStorage_GetKeyByPrefix(strPrefix) {
        const arrCacheKeyLst = new Array();
        for (let i = 0; i < sessionStorage.length; i++) {
            const strKey = sessionStorage.key(i);
            if (strKey != null) {
                if (strKey.indexOf(strPrefix) >= 0)
                    arrCacheKeyLst.push(strKey);
            }
            //拿到所有含u-的key
        }
        //        alert(strCacheKeyLst);
        return arrCacheKeyLst;
    }
    exports.SessionStorage_GetKeyByPrefix = SessionStorage_GetKeyByPrefix;
});
