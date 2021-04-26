using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIEclass.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Accounts = new HashSet<Accounts>();
            Employees = new HashSet<Employees>();
            Subjects = new HashSet<Subjects>();
        }

        [Key]
        [Column("DepartmentID")]
        [StringLength(10)]
        public string DepartmentId { get; set; }
        [Column("FacultyID")]
        [StringLength(10)]
        public string FacultyId { get; set; }
        [StringLength(250)]
        public string DepartmentName { get; set; }
        [StringLength(250)]
        public string Description { get; set; }

        [ForeignKey(nameof(FacultyId))]
        [InverseProperty(nameof(Faculties.Departments))]
        public virtual Faculties Faculty { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Accounts> Accounts { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Employees> Employees { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
