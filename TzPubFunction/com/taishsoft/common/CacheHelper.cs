using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 
    /// </summary>
    public class CacheHelper
    {
        //缓存容器 
        private static Dictionary<string, object> CacheDictionary = new Dictionary<string, object>();
        /// <summary>
        /// 添加缓存
        /// </summary>
        public static void Add(string key, object value)
        {
            CacheDictionary.Add(key, value);
        }
        /// <summary>
        /// 删除给定关键
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            CacheDictionary.Remove(key);
        }
        /// <summary>
        /// 删除给定关键字前缀的多个关键字缓存
        /// </summary>
        /// <param name="strKeyPrefix">关键字前缀</param>
        public static void RemoveByKeyPrefix(string strKeyPrefix)
        {
            var arrKeys = GetKeysByPrefix(strKeyPrefix);
            arrKeys.ForEach(x=> CacheDictionary.Remove(x));
        }

        /// <summary>
        /// 获取缓存
        /// </summary>
        public static T Get<T>(string key)
        {
            return (T)CacheDictionary[key];
        }

        /// <summary>
        /// 判断缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Exsits(string key)
        {
            return CacheDictionary.ContainsKey(key);
        }

        /// <summary>
        /// 找到字典中所有以某前缀的关键字列表
        /// </summary>
        /// <param name="strPrefix">关键字的前缀</param>
        /// <returns>关键字列表，以List[string]返回</returns>
        public static List<string> GetKeysByPrefix(string strPrefix)
        {
            //string prefix = "b";
            IEnumerable<KeyValuePair<string, object>> matchingItems = CacheDictionary
                .Where(kvp => kvp.Key.StartsWith(strPrefix));

            var arrKeys = matchingItems.Select(x=>x.Key).ToList();
            return arrKeys;
        }
        /// <summary>
        /// 缓存获取方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">缓存字典容器对应key</param>
        /// <param name="func">委托方法 传入操作对象</param>
        /// <returns></returns>
        public static T GetCache<T>(string key, Func<T> func)
        {
            T t = default(T);
            if (CacheHelper.Exsits(key))
            {
                //缓存存在，直接获取原数据
                t = CacheHelper.Get<T>(key);
            }
            else
            {
                //缓存不存在，去生成缓存，并加入容器
                t = func.Invoke();
                CacheHelper.Add(key, t);
            }
            return t;
        }
    }
}
