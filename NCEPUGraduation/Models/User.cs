using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class User
    {
       /// <summary>
       /// 主键
       /// </summary>
       [Key]
        public int StudentId { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 照片
        /// </summary>
        public string ImgPath { get; set; }
        /// <summary>
        /// 学生类型
        /// </summary>
        public string StudentType { get; set; }
    }
}