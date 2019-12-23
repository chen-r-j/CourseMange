namespace WebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        public int id { get; set; }

        [StringLength(10)]
        public string name { get; set; }

        [StringLength(10)]
        public string xuehao { get; set; }
    }
}
