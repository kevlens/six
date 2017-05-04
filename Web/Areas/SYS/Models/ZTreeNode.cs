using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SxShWeb.Areas.Models
{
    public class ZTreeNode
    {
        public string id { set; get; }
        public string name { set; get; }
        public string open { set; get; }
        public string iconSkin { set; get; }
        public bool Checked { set; get; }
        public object attributes { set; get; }
        public List<ZTreeNode> children { set; get; }
    }
}