using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace com.taishsoft.file
{
    /// <summary>
    /// 上传文件信息类
    /// </summary>
    /// 
    [Serializable]
    public class UserFile
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        public UserFile()
        {

        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strFileName"></param>
        public UserFile(string strFileName)
        {
            if (File.Exists(strFileName) == false)
            {
                string strMsg = string.Format("文件：{0}不存在！请检查！（或者与管理员联系！）",
                   strFileName);
                throw new Exception(strMsg);
            }
            FileInfo objFile = new FileInfo(strFileName);
            this.FileName = objFile.Name;
            this.FileSize = objFile.Length;
            this.Extension = objFile.Extension;
            this.LastWriteTime = objFile.LastWriteTime;
            this.CreationTime = objFile.CreationTime;

            this.FullDirName = clsFile.GetDirName_S(strFileName);
            // objUserFile.ResourceTypeName = strResourceTypeLsts;
            this.UploadDate = clsDateTime.ChangeDateToDate10(clsDateTime.ChangeDateToDate8(objFile.CreationTime));
        
        }
        /// <summary>
        /// 上传文件名称
        /// </summary>
        private string _fileName;
        /// <summary>
        /// 目录名称
        /// </summary>
        private string _dirName;
        /// <summary>
        /// 完全目录名称
        /// </summary>
        private string _fullDirName;
        /// <summary>
        /// 是否取消上传该文件
        /// </summary>
        private bool _isDeleted = false;
        /// <summary>
        /// 上传文件的流信息
        /// </summary>
        private Stream _fileStream;
        /// <summary>
        /// 当前上传文件状态
        /// </summary>
        private FileConstants.FileStates _state = FileConstants.FileStates.Pending;
        /// <summary>
        /// 当前已上传的字节数（这里与FileCollection中的同名属性意义不同，FileCollection中的是已上传的所有文件的字节总数）
        /// </summary>
        private double _bytesUploaded = 0;
        /// <summary>
        /// 当前文件大小
        /// </summary>
        private long _fileSize = 0;

        private DateTime _LastWriteTime;
        private DateTime _CreationTime;

        /// <summary>
        /// 已上传文件的百分比
        /// </summary>
        private int _percentage = 0;

        private string mstrResourceTypeName;
        /// <summary>
        /// 资源类型名
        /// </summary>
        public string ResourceTypeName
        {
            get { return mstrResourceTypeName; }
            set { mstrResourceTypeName = value; }
        }
        public const string con_ResourceTypeName = "ResourceTypeName";

        private string mstrExtension = "";
        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string Extension
        {
            get { return mstrExtension; }
            set
            {
                mstrExtension = value;

            }
        }
        public const string con_Extension = "Extension";
        private int mintOrderNum;

        public int OrderNum
        {
            get { return mintOrderNum; }
            set { mintOrderNum = value; }
        }
        private bool mbolIsAccess = false;
        /// <summary>
        /// 是否处理
        /// </summary>
        public bool IsAccess
        {
            get { return mbolIsAccess; }
            set { mbolIsAccess = value; }
        }

        private string mstrUploadDate;
        /// <summary>
        /// 上传日期
        /// </summary>
        public string UploadDate
        {
            get { return mstrUploadDate; }
            set { mstrUploadDate = value; }
        }
        public const string con_UploadDate = "UploadDate";
        /// <summary>
        /// 上传文件名称
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                NotifyPropertyChanged("FileName");
            }
        }
        public const string con_FileName = "FileName";

        /// <summary>
        /// 当前上传文件的状态，注意这时使用了NotifyPropertyChanged来通知FileRowControl控件中的FileRowControl_PropertyChanged事件
        /// </summary>
        public FileConstants.FileStates State
        {
            get { return _state; }
            set
            {
                _state = value;

                NotifyPropertyChanged("State");
            }
        }

        /// <summary>
        /// 当前上传文件是否已被移除，注意这时使用了NotifyPropertyChanged来通知FileCollection类中的item_PropertyChanged事件
        /// </summary>
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set
            {
                _isDeleted = value;



                NotifyPropertyChanged("IsDeleted");
            }
        }

        /// <summary>
        /// 上传文件的流信息
        /// </summary>
        public Stream FileStream
        {
            get { return _fileStream; }
            set
            {
                _fileStream = value;

                if (_fileStream != null)
                    _fileSize = _fileStream.Length;

            }
        }

        /// <summary>
        /// 当前文件大小
        /// </summary>
        public long FileSize
        {
            get
            {
                return _fileSize;
            }
            set
            {
                _fileSize = value;
            }
        }
        public const string con_FileSize = "FileSize";
        /// <summary>
        /// 当前已上传的字节数（这里与FileCollection中的同名属性意义不同，FileCollection中的是已上传的所有文件的字节总数）
        /// </summary>
        public double BytesUploaded
        {
            get { return _bytesUploaded; }
            set
            {
                _bytesUploaded = value;

                NotifyPropertyChanged("BytesUploaded");

                Percentage = (int)((value * 100) / _fileStream.Length);

            }
        }

        /// <summary>
        /// 已上传文件的百分比（这里与FileCollection中的同名属性意义不同，FileCollection中的是已上传字符数占全部字节数的百分比,该字段的修改事件通知会发给page.xmal中的TotalProgress）
        /// </summary>
        public int Percentage
        {
            get { return _percentage; }
            set
            {
                _percentage = value;
                NotifyPropertyChanged("Percentage");
            }
        }

        /// <summary>
        /// 目录名称
        /// </summary>
        public string DirName
        {
            get
            {
                return _dirName;
            }

            set
            {
                _dirName = value;
            }
        }
        /// <summary>
        /// 完全目录名称
        /// </summary>
        public string FullDirName
        {
            get
            {
                return _fullDirName;
            }

            set
            {
                _fullDirName = value;
            }
        }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime LastWriteTime
        {
            get
            {
                return _LastWriteTime;
            }

            set
            {
                _LastWriteTime = value;
            }
        }
        /// <summary>
        /// 建立时间
        /// </summary>
        public DateTime CreationTime
        {
            get
            {
                return _CreationTime;
            }

            set
            {
                _CreationTime = value;
            }
        }





        #region INotifyPropertyChanged Members

        private void NotifyPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
