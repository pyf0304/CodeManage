﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// 多重树结点，即一个树结点有多棵子树
/// </summary>
public class MultTreeNode
{
    #region members
    /// <summary>
    /// 父结点Id
    /// </summary>
    private int parentId;
    /// <summary>
    /// 当前结点Id
    /// </summary>
    private int selfId;
    /// <summary>
    /// 结点名
    /// </summary>
    protected String nodeName;
    /// <summary>
    /// 当前结点的数据对象
    /// </summary>
    protected Object obj;
    /// <summary>
    /// 父结点
    /// </summary>
    protected MultTreeNode parentNode;
    /// <summary>
    /// 子结点列表
    /// </summary>
    protected List<MultTreeNode> childList;
    #endregion members

    #region contrustion
    public MultTreeNode()
    {
        init();
    }

    public MultTreeNode(MultTreeNode parentNode)
    {
        init(parentNode);
    }
    public void init(MultTreeNode pNode = null)
    {
        if (childList == null)
            childList = new List<MultTreeNode>();
        parentId = 0;
        selfId = 0;
        nodeName = "";
        obj = null;

        if (pNode != null)
        {
            //复制提供的结点
            //复制名称
            nodeName = pNode.getNodeName();
            //复制结点数据对象
            if (pNode.getObj() != null)
                obj = new Hashtable((Hashtable)pNode.getObj());
            //复制父结点
            parentNode = pNode.getParentNode();
            //复制子结点
            if (pNode.getChildList() != null)
                childList = new List<MultTreeNode>(pNode.getChildList());
        }

    }
    #endregion contrustion

    #region check node
    /// <summary>
    /// 是否是叶子结点
    /// </summary>
    /// <returns></returns>
    public bool isLeaf()
    {
        return childList == null || childList.Count == 0;
    }
    /// <summary>
    /// 是否是根结点
    /// </summary>
    /// <returns></returns>
    public bool isRoot()
    {
        return parentNode == null;
    }
    /// <summary>
    /// 检查是否一个子结点，根据名称。check exist of child node.
    /// </summary>
    /// <param name="name">结点名称</param>
    /// <returns>存在就返回true,不存在就返回false</returns>
    public bool ExistChildNode(string name)//,bool IgnoreCase = false
    {
        bool bRet = false;
        foreach (MultTreeNode node in childList)
        {
            if (node.nodeName == name)
            {
                bRet = true;
                break;
            }
        }
        return bRet;
    }

    #endregion check node

    #region insert
    /// <summary>
    ///在一个结点（可能是当前结点）下面插入一个子结点。 insert child node to one node(this).
    /// </summary>
    /// <param name="name">新子结点的名称。new child node name.</param>
    /// <param name="path">路径</param>
    /// <param name="newnode">新结点。can be null. no use I think.</param>
    /// <returns>所插入的新结点</returns>
    virtual public MultTreeNode InsertNode(string name, string path = "", MultTreeNode newnode = null)
    {
        //被插根结点，首先设置为当前子结点
        MultTreeNode pntnode = this;
        if (newnode == null) newnode = new MultTreeNode();
        //路径不为空，就查找所给路径的子结点
        if (path.Length > 0)
        {
            pntnode = findNodeByPath(path);
        }
        //若被插根结点为空，就返回空
        if (pntnode == null) return null;
        // check if has same node with same name.
        // can not insert two same name node under one parent node.
        // 2016-03-04 09:38:33
        //检查是否存在同名新结点
        if (pntnode.ExistChildNode(name))
            return pntnode;
        //设置新结点名称
        newnode.setNodeName(name);
        //设置新结点的父结点
        newnode.parentNode = pntnode;
        //把新结点插入到被插根结点的子结点集合中
        pntnode.InsertChildNode(newnode);
        //返回新插入的子结点
        return newnode;           
    }


    /** 插入一个child节点到当前节点中 */
    /// <summary>
    /// 插入一个child节点到当前节点中
    /// </summary>
    /// <param name="treeNode"></param>
    virtual public void InsertChildNode(MultTreeNode treeNode)
    {
        if (childList == null)
            childList = new List<MultTreeNode>();
        treeNode.setParentNode(this);
        childList.Add(treeNode);
    }
    #endregion insert

    #region get
    /// <summary>
    /// 获取当前结点的兄弟数get current node 's brother node count.
    /// = parent node 's childlist size.
    /// </summary>
    /// <returns>current node 's brother node count</returns>
    public int GetBrotherNodeCount()
    {
        if (parentNode != null)
        {
            return parentNode.getChildList() != null ? parentNode.getChildList().Count : 1;
        }
        else
        {
            return 1;
        }
    }
    /// <summary>
    /// 获取当前结点的子结点数 get current node 's childlist count.
    /// </summary>
    /// <returns></returns>
    public int GetChildNodeCount()
    {
        return childList == null ? 0 : childList.Count;

    }
    /// <summary>
    /// 根据Id找到一颗树中某个节点 按节点ID
    /// </summary>
    /// <param name="id">所给的Id</param>
    /// <returns>返回找到结点</returns>
    public MultTreeNode findNodeById(int id)
    {
        /** 找到一颗树中某个节点 按节点ID */
        if (this.selfId == id)
            return this;
        if (isLeaf())
        {
            return null;
        }
        else
        {
            //使用递归法，查找Id的子结点
            int childNumber = childList.Count;
            for (int i = 0; i < childNumber; i++)
            {
                MultTreeNode child = childList.ElementAt(i);
                MultTreeNode resultNode = child.findNodeById(id);
                if (resultNode != null)
                {
                    return resultNode;
                }
            }
            return null;
        }
    }


    /// <summary>
    /// 根据路径查找一个结点。find one node in tree.
    /// 2016-03-04 16:21:34
    /// modify when empty path .return this instead of null.
    /// </summary>
    /// <param name="path">路径</param>
    /// <returns>返回找到的结点</returns>
    public MultTreeNode findNodeByPath(string path)
    {
        if (string.IsNullOrEmpty(path)) return this;
        path = StrUtils.FormatPath(path);
        path = StrUtils.GetSDirString(path);
        //把路径根据“\\”分割分，成一个个路径名称列表
        string[] pathArr = StrUtils.Split(path, "\\");//path.Split('\\');
        if (pathArr[0] == null) pathArr[0] = path;

        // make sure this is root path.
        //确保当前结点是根路径
        if (nodeName != pathArr[0]) return null;

        MultTreeNode node = this;
        for (int i = 0; i < pathArr.Count(); i++)
        {
            // 说明：注释。不知道为什么要加这句 可能会影响代码生成。需要注意
            // 修改为 break; => continue; \ 查找具有 相同节点名称的 子节点 逻辑
            // 短暂测试是正常的。
            // 修改日期：2014-8-5 14:20:28
            if (string.IsNullOrEmpty(pathArr[i]))
            {
                List<MultTreeNode> list = node.getChildList();
                if (i < pathArr.Count() - 1)
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j].getNodeName() == pathArr[i + 1])
                        {
                            node = list[j];
                        }
                    }
                continue;
            }
            // use path to avoid error like 0\0\0
            // 2016-07-11 21:34:54
            string nodePath = node.getPath();
            string testPath = StrUtils.FromArr(ArrayUtils.SplitArray<string>(pathArr, 0, i - 1), "\\");

            if (node.getNodeName() == pathArr[i] && nodePath == testPath)
            {
                List<MultTreeNode> list = node.getChildList();
                for (int j = 0; j < list.Count; j++)
                {
                    if (i + 1 < pathArr.Length && list[j].getNodeName() == pathArr[i + 1])
                    {
                        node = list[j];
                    }
                }
            }
            else
            {
                node = null;
                break;
            }
        }
        return node;
    }
    /// <summary>
    /// 构造一个结点的路径。 build one path by node name
    /// </summary>
    /// <returns>path like directory</returns>
    public string getPath()
    {
        List<MultTreeNode> list = getElders();
        string path = "";
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != null)
            {
                if (path.Length > 0) path += "\\";
                path += list[i].getNodeName();
            }
        }
        return path;
    }

    /// <summary>
    /// 返回当前节点的父辈节点集合 形成路径使用
    /// </summary>
    /// <returns></returns>
    public List<MultTreeNode> getElders()
    {
        /** 返回当前节点的父辈节点集合 形成路径使用 */
        ListExtA<MultTreeNode> elderList = new ListExtA<MultTreeNode>();
        MultTreeNode parentNode = this.getParentNode();
        if (parentNode == null)
        {
            return elderList;
        }
        else
        {
            elderList.AddAll(parentNode.getElders());
            elderList.Add(parentNode);
            return elderList;
        }
    }

    /// <summary>
    /// 返回当前节点的晚辈集合
    /// </summary>
    /// <returns></returns>
    public List<MultTreeNode> getJuniors()
    {
        /** 返回当前节点的晚辈集合 */
        ListExtA<MultTreeNode> juniorList = new ListExtA<MultTreeNode>();
        List<MultTreeNode> childList = this.getChildList();
        if (childList == null)
        {
            return juniorList;
        }
        else
        {
            int childNumber = childList.Count;
            for (int i = 0; i < childNumber; i++)
            {
                MultTreeNode junior = childList.ElementAt(i);
                juniorList.Add(junior);
                juniorList.AddAll(junior.getJuniors());
            }
            return juniorList;
        }
    }


    /// <summary>
    /// 返回当前节点的孩子集合
    /// </summary>
    /// <returns></returns>
    public List<MultTreeNode> getChildList()
    {
        /** 返回当前节点的孩子集合 */
        return childList;
    }
    #endregion get

    #region delete

    /// <summary>
    /// 删除节点和它下面的晚辈
    /// </summary>
    public void deleteNode()
    {
        /** 删除节点和它下面的晚辈 */
        MultTreeNode parentNode = this.getParentNode();
        int id = this.getSelfId();

        if (parentNode != null)
        {
            parentNode.deleteChildNode(id);
        }
    }

    /// <summary>
    /// 删除当前节点的某个子节点
    /// childId=0时删除所有子节点
    /// </summary>
    /// <param name="childId"></param>
    public void deleteChildNode(int childId = 0)
    {
         /** 删除当前节点的某个子节点
     *  childId=0时删除所有子节点
     */
        List<MultTreeNode> childList = this.getChildList();
        int childNumber = childList.Count;
        for (int i = 0; i < childNumber; i++)
        {
            MultTreeNode child = childList.ElementAt(i);
            if (child.getSelfId() == childId || childId == 0)
            {
                childList.RemoveAt(i);
                return;
            }
        }
    }
    #endregion delete

    #region loop

    public delegate int OneStepTravers(MultTreeNode node);

    /// <summary>
    /// 遍历一棵树，深度遍历
    /// </summary>
    /// <param name="stepbef"></param>
    /// <param name="stepafter"></param>
    public void depthtraverse(OneStepTravers stepbef, OneStepTravers stepafter)
    {
        /** 遍历一棵树，深度遍历 */
        if (stepbef != null)
            stepbef(this);

        if (childList != null)
        {
            int childNumber = childList.Count;
            for (int i = 0; i < childNumber; i++)
            {
                MultTreeNode child = childList.ElementAt(i);
                child.depthtraverse(stepbef, stepafter);
            }
        }
        if (stepafter != null)
            stepafter(this);
    }
    #endregion loop

    #region node test
    public void print(String content)
    {
        System.Diagnostics.Debug.WriteLine(content);
    }

    public void print(int content)
    {
        System.Diagnostics.Debug.WriteLine(content.ToString());
    }
    #endregion node test

    #region attribute

    /// <summary>
    /// 设置子结点
    /// </summary>
    /// <param name="childList"></param>
    public void setChildList(List<MultTreeNode> childList)
    {
        this.childList = childList;
    }
    /// <summary>
    /// 获取父结点Id
    /// </summary>
    /// <returns></returns>
    public int getParentId()
    {
        return parentId;
    }
    /// <summary>
    /// 设置父结点Id
    /// </summary>
    /// <param name="parentId"></param>
    public void setParentId(int parentId)
    {
        this.parentId = parentId;
    }

    /// <summary>
    /// 获取当前结点Id
    /// </summary>
    /// <returns></returns>
    public int getSelfId()
    {
        return selfId;
    }

    /// <summary>
    /// 设置当前结点Id
    /// </summary>
    /// <param name="selfId"></param>
    public void setSelfId(int selfId)
    {
        this.selfId = selfId;
    }
    /// <summary>
    /// 获取父结点
    /// </summary>
    /// <returns></returns>
    public MultTreeNode getParentNode()
    {
        return parentNode;
    }
    /// <summary>
    /// 设置父结点
    /// </summary>
    /// <param name="parentNode"></param>
    public void setParentNode(MultTreeNode parentNode)
    {
        this.parentNode = parentNode;
    }
    /// <summary>
    /// 获取当前结点名
    /// </summary>
    /// <returns></returns>
    public String getNodeName()
    {
        return nodeName;
    }
    /// <summary>
    /// 设置结点名称
    /// </summary>
    /// <param name="nodeName"></param>
    public void setNodeName(String nodeName)
    {
        this.nodeName = nodeName;
    }
    /// <summary>
    /// 获取当前结点的数据对象
    /// </summary>
    /// <returns></returns>
    public Object getObj()
    {
        return obj;
    }
    /// <summary>
    /// 设置当前结点的数据对象
    /// </summary>
    /// <param name="obj"></param>
    public void setObj(Object obj)
    {
        this.obj = obj;
    }
    #endregion attribute

}
public class ListExtA<T> : System.Collections.Generic.List<T>
{
    public void AddAll(List<T> addlist)
    {
        for (int i = 0; i < addlist.Count; i++)
            Add(addlist.ElementAt(i));
    }

    public static T Get(List<T> list, int nIndex = 0)
    {
        if (nIndex >= list.Count || nIndex < 0) return default(T);
        return list.ElementAt(nIndex);
    }
}

/// <summary>
/// 数组功能--工具
/// </summary>
public class ArrayUtils
{

    static public T Get<T>(T[] arr, int n, T Default)
    {
        if (arr == null) return Default;
        if (n < 0) return Default;
        T value = Default;
        if (arr.Count() > n)
            try
            {
                value = arr[n];
                if (value == null) value = Default;
            }
            catch
            {
            }
        return value;
    }
    /// <summary>
    /// 从数组中截取一部分成新的数组
    /// </summary>
    /// <param name="Source">原数组</param>
    /// <param name="StartIndex">原数组的起始位置</param>
    /// <param name="EndIndex">原数组的截止位置</param>
    /// <returns></returns>
    public static T[] SplitArray<T>(T[] Source, int StartIndex, int EndIndex)
    {
        if (Source.Length <= StartIndex)
        {
            return new T[0];
        }
        if (StartIndex < 0) StartIndex = 0;
        if (EndIndex > Source.Length - 1) EndIndex = Source.Length - 1;
        try
        {

            T[] result = new T[EndIndex - StartIndex + 1];
            for (int i = 0; i <= EndIndex - StartIndex; i++) result[i] = Get<T>(Source, i + StartIndex, default(T));
            return result;
        }
        catch (IndexOutOfRangeException ex)
        {
            //Common.WriteException(ex);
            return new T[0];
        }
        catch (Exception ex)
        {
            //Common.WriteException(ex);
            return new T[0];
        }
    }
    /// <summary>
    /// check string is null or empty.
    /// </summary>
    /// <param name="Arr"></param>
    /// <returns></returns>
    public static bool IsNullOrEmpty<T>(T[] Arr)
    {
        return Arr == null || Arr.Length == 0;
    }

    /// <summary>
    /// check if arr index is in arr
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Arr"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public static bool IsValidIndex<T>(T[] Arr, int n)
    {
        if (IsNullOrEmpty(Arr)) return false;
        return n >= 0 && n < Arr.Length - 1;
    }
    public static bool IsBetweenIndex<T>(T[] Arr, int n, int nStartIndex, int nEndIndex)
    {
        if ((IsValidIndex<T>(Arr, nStartIndex) && n < nStartIndex) ||
                (IsValidIndex<T>(Arr, nEndIndex) && n > nEndIndex))
        {
            return false;
        }
        return true;
    }
}
public class HashTableUtils
{
    static public bool IsNullOrEmpty(Hashtable ht)
    {
        if (ht == null) return true;
        if (ht.Count == 0) return true;
        return false;
    }
    static public bool Equal(Hashtable ht1, Hashtable ht2)
    {
        if (ht1 == null || ht2 == null) return false;
        if (ht1.Count != ht2.Count) return false;
        foreach (DictionaryEntry item in ht1)
        {
            object obj = GetValue<object>(ht2, item.Key.ToString(), null);
            if (!obj.Equals(item.Value))
                return false;
        }
        return true;
    }
    static public int Add(ref Hashtable ht, object key, object value)
    {
        if (ht == null) ht = new Hashtable();
        if (key != null && value != null)
        {
            if (!ht.ContainsKey(key)) ht.Add(key, value);
        }
        return 0;
    }
    static public string GetString(Hashtable ht, string key, string Default = "")
    {
        object obj = GetValue(ht, key, Default);
        return obj == null && Default == null ? null : obj.ToString();
    }

    static public T GetValue<T>(Hashtable ht, string key, T Default)
    {
        T value = Default;
        if (ht == null || ht.Count == 0) return value;
        try
        {
            value = (T)ht[key];
            if (value == null) value = Default;
        }
        catch
        {
        }
        return value;
    }
    static public int SetValue(ref Hashtable ht, object key, object value)
    {
        int nRet = 0;
        if (ht == null) ht = new Hashtable();
        if (key != null)
        {
            if (!ht.ContainsKey(key))
            {
                ht.Add(key, value);
            }
            else
            {
                ht[key] = value;
                nRet = -1;
            }

        }
        return nRet;
    }
}

public class ListUtils
{
    static public bool IsNullOrEmpty<T>(List<T> list)
    {
        if (list == null) return true;
        if (list.Count == 0) return true;
        return false;
    }
    static public T Get<T>(List<T> list, int n, T Default)
    {
        T value = Default;
        if (IsNullOrEmpty<T>(list)) return value;
        if (list.Count > n && n >= 0)
            try
            {
                value = list[n];
                if (value == null) value = Default;
            }
            catch
            {
            }
        return value;
    }
    static public T Pop<T>(ref List<T> list, T Default = default(T))
    {
        T res = Get<T>(list, 0, Default);
        Remove<T>(ref list, 0);
        return res;
    }
    public static int Remove<T>(ref List<T> list, int n)
    {
        if (IsNullOrEmpty(list))
            return -1;
        if (n < 0 || n > list.Count - 1)
            return -1;
        list.RemoveAt(n);
        return 0;
    }
}
public class StrUtils
{
    public static bool Exist(string str, string tar, bool IgnoreCase = false)
    {
        if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(tar)) return false;
        if (IgnoreCase)
        {
            if (str.ToUpper().Length > 0 && tar.ToUpper().Length > 0)
            {
                str = str.ToUpper();
                tar = tar.ToUpper();
            }
        }
        int pos = str.IndexOf(tar, 0);
        if (pos >= 0) return true;
        return false;
    }
    static public string ConDirs(string root, string dir)
    {
        if (!IsExistVisibleChar(root))
        {
            // 说明：not need to connect. if no root
            // 修改日期：2015-3-5 12:28:39
            root = "";
            return dir;
        }
        if (!IsExistVisibleChar(dir)) dir = "";
        bool IsRootDir = IsDirString(root);
        bool IsDirBgn = IsDirStringBgn(dir);
        if (!IsRootDir && !IsDirBgn) return root.Trim() + "\\" + dir.Trim();
        else if (IsRootDir && IsDirBgn) return Left(root, root.Length - 1).Trim() + "\\" + Mid(dir, 1, dir.Length - 1).Trim();
        else return root + dir;
    }
    public static string Mid(string str, int nStartIndex, int nlength)
    {
        if (str == null || nlength < 0) return "";
        nStartIndex = nStartIndex < 0 ? 0 : nStartIndex;
        if (str.Length <= Math.Abs(nStartIndex + nlength))
        {
            nlength = str.Length - nStartIndex;
        }
        if (nlength <= 0) return "";
        return Substring(str, nStartIndex, nlength);
    }
    static public bool IsDirStringBgn(string text)
    {
        if (text.Length < 1) return false;
        string lst = Substring(text, 0, 1);
        return lst == "\\" || lst == "/";
    }
    public static bool IsExistVisibleChar(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        Regex VisibleChar = new Regex(@"[^\r\n\t\s\v]+");
        return VisibleChar.IsMatch(str);
    }
    static public string GetDirPart(string text)
    {
        if (!IsExistVisibleChar(text)) text = "";
        text = GetSDirString(text);
        int lstInt = text.LastIndexOf("\\");
        int lstInt2 = text.LastIndexOf("/");
        if (lstInt < 0 && lstInt2 < 0)
        {
            // 说明：error logic return text.now return empty string.

            // 修改日期：2015-9-1 21:56:05
            //Logs.WriteError("path error: "+text);
            return "";
        }
        lstInt = lstInt > lstInt2 ? lstInt : lstInt2;
        return Substring(text, 0, lstInt + 1);
    }
    static public string GetFilePart(string text)
    {
        if (!IsExistVisibleChar(text)) text = "";
        text = text.Trim();
        int lstInt1 = text.LastIndexOf("\\");
        int lstInt2 = text.LastIndexOf("/");
        int lstInt = lstInt1 > lstInt2 ? lstInt1 : lstInt2;
        if (lstInt < 0) return text;
        return Substring(text, lstInt + 1, text.Length - lstInt - 1);
    }
    /// <summary>
    /// string array trans to string split with flg.
    /// 2016-02-18 13:24:47
    /// add startindex and endindex.
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="split"></param>
    /// <param name="surround1"></param>
    /// <param name="surround2"></param>
    /// <param name="nStartIndex"></param>
    /// <param name="nEndIndex"></param>
    /// <returns></returns>
    public static string FromArr(string[] arr, string split = ";", string surround1 = "", string surround2 = "", int nStartIndex = -1, int nEndIndex = -1)
    {
        string str = "";
        if (arr == null) return str;
        int nIndex = -1;
        foreach (string item in arr)
        {
            nIndex++;
            if (!ArrayUtils.IsBetweenIndex<string>(arr, nIndex, nStartIndex, nEndIndex))
            {
                continue;
            }
            if (str.Length > 0) str += split;
            str += surround1 + item + surround2;
        }
        return str;
    }
    public static string[] Split(string str, string splitflg)
    {
        if (string.IsNullOrEmpty(str)) return new string[] { };

        if (string.IsNullOrEmpty(splitflg))
        {
            return new string[] { str };
        }
        string[] strArr = null;

        RegexOptions ro = RegexOptions.Multiline | RegexOptions.ExplicitCapture;
        strArr = Regex.Split(str, splitflg, ro);
        //char[] splitflgArr = splitflg.ToArray();
        //strArr = str.Split(splitflgArr);

        return strArr;
    }
    /// <summary>
    /// 格式化、规范化的一个文件路径
    /// </summary>
    /// <param name="srcFilePath">源文件路径</param>
    /// <param name="IsWindows"></param>
    /// <returns></returns>
    public static string FormatPath(string srcFilePath, bool IsWindows = true)
    {
        string splitflg1 = "/", splitflg2 = "\\";
        if (string.IsNullOrEmpty(srcFilePath)) return "";
        srcFilePath = srcFilePath.Trim();
        if (!IsWindows)
        {
            splitflg1 = "\\";
            splitflg2 = "/";
        }
        srcFilePath.Replace(splitflg1, splitflg2);
        return srcFilePath;
    }
    /// <summary>
    /// 获取目录串
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    static public string GetSDirString(string text)
    {
        if (text.Length < 1) return text;
        if (IsDirString(text))
            text = Left(text, text.Length - 1);
        return text;
    }
    /// <summary>
    /// 是否是目录串，最后一个字符是“\\”或者“/”
    /// </summary>
    /// <param name="text">提供的文本</param>
    /// <returns>是目录串就返回true</returns>
    static public bool IsDirString(string text)
    {
        if (text.Length < 1) return false;
        string lst = Substring(text, text.Length - 1, 1);
        return lst == "\\" || lst == "/";
    }
    public static string Substring(string str, int nPos, int nlength = -1)
    {
        if (string.IsNullOrEmpty(str)) return "";
        if (nlength == -1) nlength = str.Length - nPos;
        char[] ch = new char[nlength];
        for (int i = 0; i < nlength; i++)
        {
            ch[i] = str[nPos + i];
        }
        return new string(ch);
    }
    public static string Left(string str, int nlength)
    {
        if (str == null || nlength < 0) return "";
        if (str.Length <= Math.Abs(nlength)) return str;
        return Substring(str, 0, nlength);
    }
}