using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class ControlTime
    {
        /// <summary>
        /// 时间Id
        /// </summary>
        [Key]
        public int TimeId { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 时间类型
        /// </summary>
        public string TimeType { get; set; }
    }
}