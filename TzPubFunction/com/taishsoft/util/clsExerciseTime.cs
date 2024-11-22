using System;
using System.Collections.Generic;

namespace com.taishsoft.util
{
    /// <summary>
    /// 练习时间类
    /// </summary>
    public class clsExerciseTime
    {
        private int mintIndex;//序号()
        /// <summary>
        /// 序号
        /// </summary>
        public int Index
        {
            get { return mintIndex; }
            set { mintIndex = value; }
        }
        private string mstrExerciseId;//题Id()
        /// <summary>
        /// 练习题的关键字
        /// </summary>
        public string ExerciseId
        {
            get { return mstrExerciseId; }
            set { mstrExerciseId = value; }
        }
        private double mdblPopupSeconds;//弹出秒（时间）
        /// <summary>
        /// 弹出练习的时间（秒）
        /// </summary>
        public double PopupSeconds
        {
            get { return mdblPopupSeconds; }
            set { mdblPopupSeconds = value; }
        }
    }
}