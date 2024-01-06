using QLTV.DAO;
using QLTV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.BUS
{
    public class DocGiaBUS
    {
        DocGiaDAO docgia;
        public DocGiaBUS() 
        {
            docgia = new DocGiaDAO();
        }
        public IEnumerable DocGiaList()
        {
            return docgia.DocGiaList();
        }

        public IEnumerable LoadDocGiaByID(string key)
        {
            return docgia.LoadDocGiaByID(key);
        }

        public IEnumerable LoadDocGiaByName(string key)
        {
            return docgia.LoadDocGiaByName(key);
        }

        public bool AddDocGia(string madocgia, string tendocgia, string sdt, DateTime ngaysinh)
        {
            if (madocgia == "" || tendocgia == "" || sdt == "")
                return false;
            else
            {
                DocGia d = new DocGia()
                {
                    MaDocGia = madocgia,
                    TenDocGia = tendocgia,
                    SDT = sdt,
                    NgaySinh = ngaysinh
                };
                try
                {
                    return docgia.AddDocGia(d) > 0 ? true : false;
                } catch { return false; }
            }
        }

        public bool EditDocGia(string madocgia, string tendocgia, string sdt, DateTime ngaysinh)
        {
            if (madocgia == "" || tendocgia == "" || sdt == "")
                return false;
            else
            {
                DocGia d = new DocGia()
                {
                    MaDocGia = madocgia,
                    TenDocGia = tendocgia,
                    SDT = sdt,
                    NgaySinh = ngaysinh
                };
                try
                {
                    return docgia.EditDocGia(d) > 0 ? true : false;
                } catch { return false; }
            }
        }

        public bool DeleteDocGia(String id)
        {
            if (id == "")
                return false;
            else
            {
                try
                {
                    return docgia.DeleteDocGia(id) > 0 ? true : false;
                } catch { return false; }
            }
        }
    }
}
