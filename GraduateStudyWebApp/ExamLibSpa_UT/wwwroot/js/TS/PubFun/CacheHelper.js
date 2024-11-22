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
    var CacheHelper = /** @class */ (function () {
        function CacheHelper() {
        }
        Object.defineProperty(CacheHelper, "CacheLength1", {
            get: function () {
                return CacheHelper.CacheDictionary.length;
            },
            enumerable: true,
            configurable: true
        });
        CacheHelper.CacheLength = function () {
            var intCount = 0;
            for (var k in CacheHelper.CacheDictionary) {
                intCount++;
            }
            return intCount;
        };
        ;
        /// <summary>
        /// 获取缓存
        /// </summary>
        CacheHelper.Key = function (index) {
            var rlt = "";
            if (index >= 0 && index < CacheHelper.CacheDictionary.length) {
                rlt = CacheHelper.CacheDictionary[index];
            }
            return rlt;
        };
        /// <summary>
        /// 添加缓存
        /// </summary>
        CacheHelper.Add = function (key, value) {
            CacheHelper.CacheDictionary[key] = value;
        };
        /// <summary>
        /// 删除给定关键
        /// </summary>
        /// <param name="key"></param>
        CacheHelper.Remove = function (key) {
            if (CacheHelper.Exsits(key)) {
                delete CacheHelper.CacheDictionary[key];
            }
        };
        /// <summary>
        /// 获取缓存
        /// </summary>
        CacheHelper.Get = function (key) {
            return CacheHelper.CacheDictionary[key];
        };
        /// <summary>
        /// 判断缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        CacheHelper.Exsits = function (key) {
            return CacheHelper.CacheDictionary.hasOwnProperty(key);
        };
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        CacheHelper.GetCache = function (key, func) {
            //T t = default (T);
            var t;
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
        };
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        CacheHelper.GetCacheByCondition = function (key, strCondition, func) {
            //T t = default (T);
            var t;
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
        };
        CacheHelper.GetCacheByConditionAsync = function (key, strCondition, func) {
            //T t = default (T);
            var t;
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
        };
        //缓存容器 
        CacheHelper.CacheDictionary = {};
        return CacheHelper;
    }());
    exports.CacheHelper = CacheHelper;
});
//export class CacheHelper {
//    //缓存容器 
//    private static CacheDictionary: { [index: string]: any } = {};
//    /// <summary>
//    /// 添加缓存
//    /// </summary>
//    public static Add(key: string, value: any) {
//        CacheHelper.CacheDictionary[key] = value;
//    }
//    /// <summary>
//    /// 删除给定关键
//    /// </summary>
//    /// <param name="key"></param>
//    public static Remove(key: string) {
//        if (CacheHelper.Exsits(key)) {
//            delete CacheHelper.CacheDictionary[key];
//        }
//    }
//    /// <summary>
//    /// 获取缓存
//    /// </summary>
//    public static Get(key: string) {
//        return CacheHelper.CacheDictionary[key];
//    }
//    /// <summary>
//    /// 判断缓存是否存在
//    /// </summary>
//    /// <param name="key"></param>
//    /// <returns></returns>
//    public static Exsits(key: string): boolean {
//        return CacheHelper.CacheDictionary.hasOwnProperty(key);
//    }
//    /// <summary>
//    /// 缓存获取方法
//    /// </summary>
//    /// <typeparam name="T"></typeparam>
//    /// <param name="key">缓存字典容器对应key</param>
//    /// <param name="func">委托方法 传入操作对象</param>
//    /// <returns></returns>
//    public static GetCache(key: string, func: (strKey: string) => any) {
//        //T t = default (T);
//        var t: any;
//        if (CacheHelper.Exsits(key)) {
//            //缓存存在，直接获取原数据
//            t = CacheHelper.Get(key);
//        }
//        else {
//            //缓存不存在，去生成缓存，并加入容器
//            console.log(key);
//            console.log(func);
//            t = func(key);
//            CacheHelper.Add(key, t);
//        }
//        return t;
//    }
//    /// <summary>
//    /// 缓存获取方法
//    /// </summary>
//    /// <typeparam name="T"></typeparam>
//    /// <param name="key">缓存字典容器对应key</param>
//    /// <param name="func">委托方法 传入操作对象</param>
//    /// <returns></returns>
//    public static GetCacheByCondition(key: string, strCondition: string, func: (strCondition: string) => any) {
//        //T t = default (T);
//        var t: any;
//        if (CacheHelper.Exsits(key)) {
//            //缓存存在，直接获取原数据
//            t = CacheHelper.Get(key);
//        }
//        else {
//            //缓存不存在，去生成缓存，并加入容器
//            console.log(key);
//            console.log(func);
//            t = func(strCondition);
//            CacheHelper.Add(key, t);
//        }
//        return t;
//    }
//    public static GetCacheByConditionAsync(key: string, strCondition: string, func: (strCondition: string) => any): Promise<any> {
//        //T t = default (T);
//        var t: any;
//        if (CacheHelper.Exsits(key)) {
//            //缓存存在，直接获取原数据
//            t = CacheHelper.Get(key);
//        }
//        else {
//            //缓存不存在，去生成缓存，并加入容器
//            console.log(key);
//            console.log(func);
//            t = func(strCondition);
//            CacheHelper.Add(key, t);
//        }
//        return t;
//    }
//}
