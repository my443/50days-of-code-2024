using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freezer_console.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public int ContainerId{ get; set; }
        public int ContainsId {  get; set; }
        public int TypeId { get; set; }
    }
}
