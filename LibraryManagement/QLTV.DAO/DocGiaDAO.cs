using QLTV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    public class DocGiaDAO
    {
        public DocGiaDAO() { }
        public IEnumerable DocGiaList()
        {

            using (var db = new QLTVEntities())
            {
                var query = db.DocGias.Select(s => new
                {
                    s.MaDocGia,
                    s.TenDocGia,
                    s.NgaySinh,
                    s.SDT
                });
                return query.ToList();
            }
        }

        public IEnumerable LoadDocGiaByID(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.DocGias.Select(s => new
                {
                    s.MaDocGia,
                    s.TenDocGia,
                    s.NgaySinh,
                    s.SDT
                }).Where(d => d.MaDocGia.ToLower().Contains(key.ToLower()) ||
                d.MaDocGia.ToLower().StartsWith(key.ToLower()) ||
                d.MaDocGia.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable LoadDocGiaByName(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.DocGias.Select(s => new
                {
                    s.MaDocGia,
                    s.TenDocGia,
                    s.NgaySinh,
                    s.SDT
                }).Where(d => d.TenDocGia.ToLower().Contains(key.ToLower()) ||
                d.TenDocGia.ToLower().StartsWith(key.ToLower()) ||
                d.TenDocGia.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public int AddDocGia(DocGia d)
        {

            using (var db = new QLTVEntities())
            {
                db.DocGias.Add(d);
                return db.SaveChanges();

            }
        }

        public int EditDocGia(DocGia d)
        {
            using (var db = new QLTVEntities())
            {
                var docgia = db.DocGias.Find(d.MaDocGia);
                if (docgia != null)
                {
                    docgia.TenDocGia = d.TenDocGia;
                    docgia.SDT = d.SDT;
                    docgia.NgaySinh = d.NgaySinh;
                    return db.SaveChanges();
                }
                else return 0;
            }
        }

        public int DeleteDocGia(string id)
        {
            using (var db = new QLTVEntities())
            {
                var docGia = db.DocGias.FirstOrDefault(d => d.MaDocGia == id);
                if (docGia != null)
                {
                    bool canDelete = true;

                    // Kiểm tra xem độc giả có phiếu mượn hay không
                    // Kiểm tra xem độc giả đã trả hết sách chưa
                    int pm = db.PhieuMuons.Count(p => p.MaDocGia == id);
                    int hd = db.HoaDonTraSaches.Join(db.PhieuMuons, h => h.MaPM, p => p.MaPM,
                    (h, p) => new { HoaDonTraSach = h, PhieuMuon = p })
                    .Count(h => h.PhieuMuon.MaDocGia == id);
                    // Nếu chưa trả hết không cho xoá
                    if (pm > hd)
                    {
                        canDelete = false;
                    }

                    if (canDelete)
                    {
                        db.DocGias.Remove(docGia);
                        return db.SaveChanges();
                    }
                }
                return 0;
            }


        }
    }
}
