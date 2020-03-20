using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPF.Model
{
    [Table("TB_M_Supplier")]
    public class supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public supplier() { }

        public supplier(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
