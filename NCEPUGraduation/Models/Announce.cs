using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class Announce
    {
        /// <summary>
        /// 公告Id
        /// </summary>
        [Key]
        public int AnnounceId { get; set; }
        /// <summary>
        /// 公告标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 公告内容
        /// </summary>
        public string Message { get; set; }
    }
}