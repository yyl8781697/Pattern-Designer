using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Cache
    {
        private static Cache _cache;
        private static Object obj = new Object();
        private IDictionary<string, string> _cacheDict = new Dictionary<string, string>();

        /// <summary>
        /// 将实例化函数私有
        /// </summary>
        private Cache()
        { }

        /// <summary>
        /// 最简单的单例
        /// </summary>
        /// <returns></returns>
        public static Cache Create1()
        {
            if (_cache == null)
                _cache = new Cache();
            return _cache;
        }

        /// <summary>
        /// 加锁
        /// </summary>
        /// <returns></returns>
        public static Cache Create2()
        {
            if (_cache == null)
            {
                lock (obj)
                {
                    _cache = new Cache();
                }
            }

            return _cache;
            
        }

        /// <summary>
        /// 双重锁
        /// </summary>
        /// <returns></returns>
        public static Cache Create3()
        {
            lock (obj)
            {
                if (_cache == null)
                {
                    lock (obj)
                    {
                        _cache = new Cache();
                    }
                }
            }

            return _cache;
        }



        public void Set(string key,string value)
        {
            _cacheDict.Add(key, value);
        }

        public string Get(string key)
        {
            if (this._cacheDict.ContainsKey(key))
            {
                return this._cacheDict[key];
            }
            return "";
        }
    }
}
