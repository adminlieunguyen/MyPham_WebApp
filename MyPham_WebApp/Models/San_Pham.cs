using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPham_Client_WebApp.Models
{
    public class San_Pham
    {
        public string ID_SP { get; set; }
        public string ID_Loai { get; set; }
        public string Ten_SP { get; set; }
        public string Hinh_Anh { get; set; }
        public Nullable<int> So_Luong { get; set; }
        public string Mota { get; set; }
        public string NoiDung { get; set; }
    }
}