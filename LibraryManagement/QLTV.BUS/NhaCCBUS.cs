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
    public class NhaCCBUS
    {
        NhaCCDAO ncc;
        public NhaCCBUS()
        {
            ncc = new NhaCCDAO();
        }
        public IEnumerable NhaCCList()
        {
            return new NhaCCDAO().NhaCCList();
        }

        public IEnumerable LoadNCCByID(string key)
        {
            return ncc.LoadNCCByID(key);
        }

        public IEnumerable LoadNCCByName(string key)
        {
            return ncc.LoadNCCByName(key);
        }

        public bool AddNCC(string maNCC, string tenNCC, string sdt, string email)
        {
            if (tenNCC == "" || sdt == "" || email == "")
                return false;
            else
            {
                try
                {
                    NhaCungCap nhacc = new NhaCungCap()
                    {
                        MaNCC = maNCC,
                        TenNCC = tenNCC,
                        SDT = sdt,
                        Email = email
                    };
                    ncc.AddNCC(nhacc);
                    return true;
                }
                catch { return false; }
            }
        }

        public bool EditNCC(string maNCC, string tenNCC, string sdt, string email)
        {
            if (maNCC == "" || tenNCC == "" || sdt == "" || email == "")
                return false;
            else
            {
                try
                {
                    NhaCungCap nhacc = new NhaCungCap()
                    {
                        MaNCC = maNCC,
                        TenNCC = tenNCC,
                        SDT = sdt,
                        Email = email
                    };
                    ncc.EditNCC(nhacc);
                    return true;
                }
                catch { return false; }
            }
        }

        public bool DeleteNCC(string id)
        {
            if (id == "")
                return false;
            else
            {
                try
                {
                    ncc.DeleteNCC(id);
                    return true;
                }
                catch { return false; }
            }
        }
    }
}
