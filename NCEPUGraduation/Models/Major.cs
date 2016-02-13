using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class Major
    {
        /// <summary>
        /// 专业Id
        /// </summary>
        [Key]
        public int MajorId { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public string MajorName { get; set; }
        /// <summary>
        /// 专业代码
        /// </summary>
        public string MajorCode { get; set; }
        /// <summary>
        /// 系Id
        /// </summary>
        public int DepartmentId { get; set; }
    }
}