using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Command
    {
        [Key]
        public int CommandID { get; set; }
        public string CommandUserName { get; set; }
        public string CommandTitler { get; set; }
        public string CommandContent { get; set; }  
        public DateTime CommentDate { get; set; } 
        public bool CommandStatus { get; set; }
        public int BlogId { get; set; } 
        public Blog Blog { get; set;}

    }
}
