﻿using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsTabStateBLEx : clsTabStateBL
    {
        /// <summary>
        /// 获取相关对象列表, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns>获取相关对象列表</returns>
        public static List<clsTabStateEN> GetTabStateObjLstForBindDdl()
        {
            List<clsTabStateEN> arrObjLstCache = clsTabStateBL.GetObjLstCache();

            return arrObjLstCache;
        }
    }
}
