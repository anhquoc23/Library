using QLTV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    public class TacGiaDAO
    {
        public TacGiaDAO() { }
        public IEnumerable TacGiaList()
        {
            using (var db = new QLTVEntities())
            {
                var query = db.TacGias.Select(tg => new
                {
                    tg.MaTacGia,
                    tg.TenTacGia,
                    tg.SDT,
                    tg.Email
                });
                return query.ToList();
            }
        }
        public IEnumerable LoadTacGiaByID(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.TacGias.Select(tg => new
                {
                    tg.MaTacGia,
                    tg.TenTacGia,
                    tg.SDT,
                    tg.Email
                }).Where(q => q.MaTacGia.ToLower().Contains(key.ToLower()) ||
                q.MaTacGia.ToLower().StartsWith(key.ToLower()) ||
                q.MaTacGia.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable LoadTacGiaByName(string key) 
        {
            using (var db = new QLTVEntities())
            {
                var query = db.TacGias.Select(tg => new
                {
                    tg.MaTacGia,
                    tg.TenTacGia,
                    tg.SDT,
                    tg.Email
                }).Where(q => q.TenTacGia.ToLower().Contains(key.ToLower()) ||
                q.TenTacGia.ToLower().StartsWith(key.ToLower()) ||
                q.TenTacGia.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public int AddTacGia(TacGia tg)
        {
            using (var db = new QLTVEntities())
            {
                db.TacGias.Add(tg);
                return db.SaveChanges();
            }
        }

        public int EditTacGia(TacGia tg)
        {
            using (var db = new QLTVEntities())
            {
                var tacgia = db.TacGias.Find(tg.MaTacGia);
                if (tacgia != null) 
                {
                    tacgia.TenTacGia = tg.TenTacGia;
                    tacgia.SDT = tg.SDT;
                    tacgia.Email = tg.Email;
                }
                return db.SaveChanges();
            }
        }

        public int DeleteTacGia(string primarykey)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.TacGias.Where(tg => tg.MaTacGia == primarykey
                            && db.Saches.All(s => s.MaTacGia != primarykey)).Select(t => t);
                db.TacGias.Remove(query.FirstOrDefault());
                return db.SaveChanges();
            }
        }
    }
}
