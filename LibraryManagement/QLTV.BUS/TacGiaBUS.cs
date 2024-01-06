using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV.DAO;
using QLTV.DTO;

namespace QLTV.BUS
{
    public class TacGiaBUS
    {
        TacGiaDAO tacgia;
        public TacGiaBUS() 
        {
            tacgia = new TacGiaDAO();
        }
        public IEnumerable TacGiaList()
        {
            return tacgia.TacGiaList();
        }

        public IEnumerable LoadTacGiaByID(string key)
        {
            return tacgia.LoadTacGiaByID(key);
        }

        public IEnumerable LoadTacGiaByName(string key) 
        {
            return tacgia.LoadTacGiaByName(key);
        }

        public bool AddTacGia(String MaTacGia, String TenTacGia, String sdt, String email)
        {
            if (TenTacGia == "" || sdt == "" || email == "")
                return false;
            else
            {
                TacGia tg = new TacGia()
                {
                    MaTacGia = MaTacGia,
                    TenTacGia = TenTacGia,
                    SDT = sdt,
                    Email = email
                };
                try
                {
                    tacgia.AddTacGia(tg);
                    return true;
                }
                catch (Exception ex) { return false; }
            }
        }

        public bool EditTacGia(String MaTacGia, String TenTacGia, String sdt, String email)
        {
            if (MaTacGia == "" || TenTacGia == "" || sdt == "" || email == "")
                return false;
            else
            {
                TacGia tg = new TacGia()
                {
                    MaTacGia = MaTacGia,
                    TenTacGia = TenTacGia,
                    SDT = sdt,
                    Email = email
                };
                try
                {
                    tacgia.EditTacGia(tg);
                    return true;
                }
                catch { return false; }
            }
        }

        public bool DeleteTacGia(string id)
        {
            if (id == "")
                return false;
            else
            {
                try
                {
                    tacgia.DeleteTacGia(id);
                    return true;
                }
                catch { return false; }
            }
        }
    }
}
