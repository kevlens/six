using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace SxShWeb.Areas.ViewModels
{
    public partial class VIEW_SYS_USER
    {
        public string ISUP_FLAG_EXT { get; set; }
        public List<string> ROLE_EXT { get; set; }
        public string MANAGE_DEPT_NAME { get; set; }
        public string GWD_NAME { get; set; }
        public string CJ_NAME { get; set; }
        public string ROLE_NAME { get; set; }
        public string SHOW_FLAG { get; set; }
        
    }
}