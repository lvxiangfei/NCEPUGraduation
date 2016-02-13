using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCEPUGraduation.Models
{
    public class Academy
    {
        /// <summary>
        /// 学院Id
        /// </summary>
        [Key]
        public int AcademyId { get; set; }
        /// <summary>
        /// 学院
        /// </summary>
        public string AcademyName{ get; set; }
    }
}