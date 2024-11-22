using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.comm_db_obj
{
    /// <summary>
    /// 用于添加记录时事件代理定义
    /// </summary>
    /// <param name="objNewObject4Add">添加的新对象</param>
    public delegate void OnAddNewRecord(object objNewObject4Add);

    /// <summary>
    /// 用于修改记录(存数据库时)时事件代理定义
    /// </summary>
    /// <param name="objObject4Update">修改的对象</param>
    public delegate void OnUpdateRecord(object objObject4Update);

    /// <summary>
    /// 用于删除记录时事件代理定义
    /// </summary>
    /// <param name="objKeyId4Delete">删除记录的关键字</param>
    public delegate void OnDeleteRecord(object objKeyId4Delete);

}
