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
    exports.CacheHelper = void 0;
    class CacheHelper {
        static get CacheLength1() {
            return CacheHelper.CacheDictionary.length;
        }
        static CacheLength() {
            var intCount = 0;
            for (let k in CacheHelper.CacheDictionary) {
                intCount++;
            }
            return intCount;
        }
        ;
        /// <summary>
        /// 获取缓存
        /// </summary>
        static Key(index) {
            var rlt = "";
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
            return CacheHelper.CacheDictionary.hasOwnProperty(key);
        }
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        static GetCache(key, func) {
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
        }
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        static GetCacheByCondition(key, strCondition, func) {
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
        }
        static GetCacheByConditionAsync(key, strCondition, func) {
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
        }
    }
    exports.CacheHelper = CacheHelper;
    //缓存容器 
    CacheHelper.CacheDictionary = {};
});
