using QLTV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    public class NhaCCDAO
    {
        public NhaCCDAO() { }
        public IEnumerable NhaCCList()
        {
            using (var db = new QLTVEntities())
            {
                var query = db.NhaCungCaps.Select(n => new
                {
                    n.MaNCC,
                    n.TenNCC,
                    n.SDT,
                    n.Email
                });
                return query.ToList();
            }
        }

        public IEnumerable LoadNCCByID(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.NhaCungCaps.Select(n => new
                {
                    n.MaNCC,
                    n.TenNCC,
                    n.SDT,
                    n.Email
                }).Where(n => n.MaNCC.ToLower().Contains(key.ToLower()) ||
                n.MaNCC.ToLower().StartsWith(key.ToLower()) ||
                n.MaNCC.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable LoadNCCByName(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.NhaCungCaps.Select(n => new
                {
                    n.MaNCC,
                    n.TenNCC,
                    n.SDT,
                    n.Email
                }).Where(n => n.TenNCC.ToLower().Contains(key.ToLower()) ||
                n.TenNCC.ToLower().StartsWith(key.ToLower()) ||
                n.TenNCC.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public int AddNCC(NhaCungCap nhacungcap)
        {

            using (var db = new QLTVEntities())
            {
                db.NhaCungCaps.Add(nhacungcap);
                return db.SaveChanges();
            }
        }

        public int EditNCC(NhaCungCap ncc)
        {
            using (var db = new QLTVEntities())
            {
                var nhacc = db.NhaCungCaps.Find(ncc.MaNCC);
                if (nhacc != null)
                {
                    nhacc.TenNCC = ncc.TenNCC;
                    nhacc.SDT = ncc.SDT;
                    nhacc.Email = ncc.Email;
                    return db.SaveChanges();
                }
                return 0;
            }
        }

        public int DeleteNCC(string primarykey)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.NhaCungCaps.Where(n => n.MaNCC == primarykey
                             && db.Saches.All(s => s.MaNCC != primarykey)).Select(n => n);
                db.NhaCungCaps.Remove(query.FirstOrDefault());
                return db.SaveChanges();
            }
        }
    }
}
