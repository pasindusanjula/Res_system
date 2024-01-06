using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class UserInfo : CommonProps
    {
        public int UsertId { get; set; } = 0;
        public string Username { get; set; } = "";
        public string Contact { get; set; } = "";
        public string UserPassWord { get; set; } = "";
    }
}
