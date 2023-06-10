using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Tai_khoanBLL
    {
        PBL_3Entities et = new PBL_3Entities();

        public List<Tai_khoan> GetAllTK()
        {
            var s = et.Tai_khoan.ToList();
            return s;
        }
        public Tai_khoan GetTK(int m)
        {
            var s = et.Tai_khoan.Find(m);
            return s;
        }
        public dynamic Search(string search)
        {
            
            var tk = et.Tai_khoan.Where(p => (p.Ten_TK.Contains(search))).Select(p => new { p.Ma_TK, p.Ten_TK, p.Mat_khau, p.Loai_TK }).ToList();
            return tk;
        }

        public void SaveTK(Tai_khoan ca)
        {
            et.Tai_khoan.AddOrUpdate(ca);
            et.SaveChanges();
        }
        public void DeleteTK(Tai_khoan ca)
        {
            et.Tai_khoan.Remove(ca);
            et.SaveChanges();
        }
        public bool CheckLogin(int ten, string matKhau)
        {
            try
            {
                Tai_khoan ca = new Tai_khoan();
                ca = et.Tai_khoan.Find(ten);
                if (ca != null)//có mã tài khoản đó
                {
                    bool passwordMatch = BCrypt.Net.BCrypt.Verify(matKhau, ca.Mat_khau);
                    if (passwordMatch)
                    {
                        Const.taiKhoan = ca;
                        Const.taiKhoan.Loai_TK = ca.Loai_TK;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else//ko có mã tk đã nhập
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
