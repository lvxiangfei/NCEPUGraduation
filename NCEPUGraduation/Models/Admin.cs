using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class Admin
    {
        /// <summary>
        /// 管理员用户Id
        /// </summary>
        [Key]
        public int AdminId { get; set; }
        /// <summary>
        /// 管理员用户名
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPwd { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public string Power { get; set; }
        /// <summary>
        /// 用户描述
        /// </summary>
        public string UserDes { get; set; }
    }
}