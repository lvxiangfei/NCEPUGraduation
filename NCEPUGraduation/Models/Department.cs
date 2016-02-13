using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class Department
    {
        /// <summary>
        /// 系Id
        /// </summary>
        [Key]
        public int DepartmentId { get; set; }

        /// <summary>
        /// 系
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 系代码
        /// </summary>
        public string DepartmentCode { get; set; }
        /// <summary>
        /// 学院Id
        /// </summary>
        public int AcademyId { get; set; }
    }
}