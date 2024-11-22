using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace com.taishsoft.file
{
/// <summary>
/// 按文件名升序排序
/// </summary>
    public class SortByFileNameAsc : IComparer<UserFile>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(UserFile x, UserFile y)
        {
            return x.FileName.CompareTo(y.FileName); // 按文件名排序
        }
    }
    //public class CComparer : IComparer<C>
    //{
    //    public int Compare(C left, C right)
    //    {
    //        if (left.n > right.n)
    //            return 1;
    //        else if (left.n == right.n)
    //            return 0;
    //        else
    //            return -1;
    //    }
    //}
    /// <summary>
    /// 按文件名降序排序
    /// </summary>
    public class SortByFileNameDesc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (y as UserFile).FileName.CompareTo((x as UserFile).FileName); // 按文件名降序排序
        }
    }

    /// <summary>
    /// 按上传日期升序排序
    /// </summary>
    public class SortByUploadDateAsc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (x as UserFile).UploadDate.CompareTo((y as UserFile).UploadDate); // 按上传日期排序
        }
    }
    /// <summary>
    /// 按上传日期降序排序
    /// </summary>
    public class SortByUploadDateDesc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (y as UserFile).UploadDate.CompareTo((x as UserFile).UploadDate); // 按上传日期降序排序
        }
    }
    public class SortByResourceTypeNameAsc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (x as UserFile).ResourceTypeName.CompareTo((y as UserFile).ResourceTypeName); // 按上传日期排序
        }
    }
    /// <summary>
    /// 按上传日期降序排序
    /// </summary>
    public class SortByResourceTypeNameDesc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (y as UserFile).ResourceTypeName.CompareTo((x as UserFile).ResourceTypeName); // 按上传日期降序排序
        }
    }

    public class SortByExtensionAsc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (x as UserFile).Extension.CompareTo((y as UserFile).Extension); // 按上传日期排序
        }
    }
    /// <summary>
    /// 按上传日期降序排序
    /// </summary>
    public class SortByExtensionDesc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            return (y as UserFile).Extension.CompareTo((x as UserFile).Extension); // 按上传日期降序排序
        }
    }
    /// <summary>
    /// 按上传日期升序排序
    /// </summary>
    public class SortByFileSizeAsc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            if (x.FileSize > y.FileSize)
                return 1;
            else if (x.FileSize == y.FileSize)
                return 0;
            else
                return -1;
        }

    }
    /// <summary>
    /// 按文件大小降序排序
    /// </summary>
    public class SortByFileSizeDesc : IComparer<UserFile>
    {
        public int Compare(UserFile x, UserFile y)
        {
            if (x.FileSize < y.FileSize)
                return  1;
            else if (x.FileSize == y.FileSize)
                return 0;
            else
                return -1;
        }
    }

    /// <summary>
    /// 文件集合管理类
    /// 注：ObservableCollection是个泛型集合类，往其中添加或去除条目时（或者其中的条目实现了INotifyPropertyChanged的话，在属性变动时），
    /// 它会发出变化通知事件（先执行集合类中的同名属性）。这在做数据绑定时会非常方便，因为UI控件可以使用这些通知来知道自动刷新它们的值，
    /// 而不用开发人员编写代码来显式地这么做。
    /// </summary>
    /// 
    [Serializable]
    public class FileCollection
    {
        List<UserFile> mlstFiles = null;

        public List<UserFile> FileLst
        {
            get {
                if (mlstFiles == null) return null;
                if (string.IsNullOrEmpty(mstrSortExpression) == true) return mlstFiles;
                //var list1 = (from s in mlstFiles
                //             orderby s.FileName descending
                //             select s).ToList();
                          
                if (mstrSortExpression.Contains(UserFile.con_FileName))
                {
                    if (mstrSortExpression.Contains("Desc"))
                    {
                        mlstFiles.Sort(new SortByFileNameDesc());
                    }
                    else
                    {
                        mlstFiles.Sort(new SortByFileNameAsc());
                    }
                }
                else if (mstrSortExpression.Contains(UserFile.con_UploadDate))
                {
                    if (mstrSortExpression.Contains("Desc"))
                    {
                        mlstFiles.Sort(new SortByUploadDateDesc());
                    }
                    else
                    {
                        mlstFiles.Sort(new SortByUploadDateAsc());
                    }
                }
                else if (mstrSortExpression.Contains(UserFile.con_FileSize))
                {
                    if (mstrSortExpression.Contains("Desc"))
                    {
                        mlstFiles.Sort(new SortByFileSizeDesc());
                    }
                    else
                    {
                        mlstFiles.Sort(new SortByFileSizeAsc());
                    }
                }
                else if (mstrSortExpression.Contains(UserFile.con_Extension))
                {
                    if (mstrSortExpression.Contains("Desc"))
                    {
                        mlstFiles.Sort(new SortByExtensionDesc());
                    }
                    else
                    {
                        mlstFiles.Sort(new SortByExtensionAsc());
                    }
                }
                else if (mstrSortExpression.Contains(UserFile.con_ResourceTypeName))
                {
                    if (mstrSortExpression.Contains("Desc"))
                    {
                        mlstFiles.Sort(new SortByResourceTypeNameDesc());
                    }
                    else
                    {
                        mlstFiles.Sort(new SortByResourceTypeNameAsc());
                    }
                }
                return mlstFiles;
            }
            set { mlstFiles = value; }
        }
        /// <summary>
        /// 排序表达式
        /// </summary>
        public string SortExpression
        {
            get
            {
                return mstrSortExpression;
            }

            set
            {
                mstrSortExpression = value;
            }
        }

        private string mstrSortExpression;//排序表达式
        /// <summary>
        /// 已上传的累计（多文件）字节数
        /// </summary>

        /// <summary>
        /// 已上传字符数占全部字节数的百分比
        /// </summary>

        /// <summary>
        /// 当前正在上传的文件序号
        /// </summary>
        private int _currentUpload = 0;
        /// <summary>
        /// 上传初始化参数，详情如下：
        /// MaxFileSizeKB:  File size in KBs.
        /// MaxUploads:  Maximum number of simultaneous uploads
        /// FileFilter: File filter, for example ony jpeg use: FileFilter=Jpeg (*.jpg) |*.jpg
        /// CustomParam: Your custom parameter, anything here will be available in the WCF webservice
        /// DefaultColor: The default color for the control, for example: LightBlue
        /// </summary>

        /// <summary>
        /// 最大上传字节数
        /// </summary>




        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="customParams"></param>
        /// <param name="maxUploads"></param>
        public FileCollection()
        {
            mlstFiles = new List<UserFile>();
        }


        /// <summary>
        /// 依次加入所选的上传文件信息
        /// </summary>
        /// <param name="item"></param>
        public void Add(UserFile item)
        {
            item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            mlstFiles.Add(item);
        }


        /// <summary>
        /// 依次加入所选的上传文件信息,按日期降序
        /// </summary>
        /// <param name="item"></param>
        public void AddByDateDesc(UserFile item)
        {
            item.PropertyChanged += new PropertyChangedEventHandler(item_PropertyChanged);
            if (mlstFiles.Count == 0)
            {
                mlstFiles.Add(item);
                return;
            }
            int intIndex = 0;
            int intPos = -1;
            for(intIndex = 0;intIndex<mlstFiles.Count; intIndex++)
            {
                UserFile objUserFile  = mlstFiles[intIndex];
                int intResult = item.UploadDate.CompareTo(objUserFile.UploadDate);
                if (intResult > 0)
                {
                    intPos = intIndex;
                    break;
                }
            }
            if (intPos == -1)
            {
                intPos = mlstFiles.Count;
            }
            mlstFiles.Insert(intPos, item);
        }
        /// <summary>
        /// 单个上传文件属性改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //当属性变化为“从上传列表中移除”
            if (e.PropertyName == "IsDeleted")
            {
                UserFile file = (UserFile)sender;

                if (file.IsDeleted)
                {
                    if (file.State == FileConstants.FileStates.Uploading)
                    {
                        _currentUpload--;

                    }

                    mlstFiles.Remove(file);

                    file = null;
                }
            }
            //当属性变化为“开始上传”
            else if (e.PropertyName == "State")
            {
                UserFile file = (UserFile)sender;
                //此时file.State状态为ploading
                if (file.State ==FileConstants.FileStates.Finished || file.State == FileConstants.FileStates.Error)
                {
                    _currentUpload--;

                }
            }
            //当属性变化为“上传进行中”
            else if (e.PropertyName == "BytesUploaded")
            {
                //重新计算上传数据

            }
        }






    }

}
