﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class San_phamBLL
    {
        San_pham_DAL dal; 
        public San_phamBLL()
        {
            dal = new San_pham_DAL();
        }
        public List<San_pham> GetSPCategory(string s)
        {
            List<San_pham> lt =new List<San_pham>();
            foreach(var i in dal.GetAllSP())
            {
                if (i.Ma_loai1.Ten == s) lt.Add(i);
            }
            return lt;
        }
    }
}
