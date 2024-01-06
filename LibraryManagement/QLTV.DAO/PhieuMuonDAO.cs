using QLTV.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV.DAO
{
    public class PhieuMuonDAO
    {
        public PhieuMuonDAO() { }

        public void luuPhieuMuon(DateTime ngaylapphieu, string madocgia)
        {
            using (var db = new QLTVEntities())
            {
                var phieumuon = new PhieuMuon()
                {
                    NgayLapPhieu = ngaylapphieu,
                    MaDocGia = madocgia
                };
                db.PhieuMuons.Add(phieumuon);
                db.SaveChanges();
            }
        }
        public void luuCTPM(string masach, int soluong, int maphieumuon, decimal tiendatcoc)
        {
            using (var db = new QLTVEntities())
            {
                var ctpm = new ChiTietPhieuMuon()
                {
                    MaSach = masach,
                    SoLuong = soluong,
                    MaPM = maphieumuon,
                    TienDatCoc = tiendatcoc
                };
                db.ChiTietPhieuMuons.Add(ctpm);
                db.SaveChanges();
            }
        }
        public void setSoLuongSachTrongCTPM(string masach, int soluong)
        {
            using (var db = new QLTVEntities())
            {
                var sach = db.Saches.Find(masach);
                if (sach != null)
                {
                    sach.SoLuong = soluong - 1;
                    db.SaveChanges();
                }
            }
        }
        public int layIDPhieuMuonLonNhat()
        {
            using (var db = new QLTVEntities())
            {
                int maxid = db.PhieuMuons.Max(pm => pm.MaPM);
                return maxid;
            }
        }
        public IEnumerable LoadPhieuMuon()
        {
            using (var db = new QLTVEntities())
            {
                var query = db.PhieuMuons.Select(pm => new
                {
                    pm.MaPM,
                    pm.NgayLapPhieu,
                    pm.MaDocGia
                }).Where(pm => db.HoaDonTraSaches.All(h => h.MaPM != pm.MaPM));
                return query.ToList();
            }
        }
        public IEnumerable LoadPMByIDDG(string id)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.PhieuMuons.Select(pm => new
                {
                    pm.MaPM,
                    pm.NgayLapPhieu,
                    pm.MaDocGia
                }).Where(p => p.MaDocGia.ToLower().Contains(id.ToLower()) ||
                p.MaDocGia.ToLower().StartsWith(id.ToLower()) ||
                p.MaDocGia.ToLower().EndsWith(id.ToLower()));
                return query.ToList();
            }
        }
        public DocGia LoadDocGiaByIDPM(string id)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.DocGias.ToList().Where(dg => dg.MaDocGia == id).First();
                return query;
            }
        }
        public int SoLuongSachTrongCTPM(int id)
        {
            using (var db = new QLTVEntities())
            {
                return db.ChiTietPhieuMuons.Where(c => c.MaPM == id).Count();
            }
        }

        public decimal TongTienDatCoc(int id)
        {
            using (var db = new QLTVEntities())
            {
                return db.ChiTietPhieuMuons.Where(c => c.MaPM == id).Sum(c => c.SoLuong * c.TienDatCoc);
            }
        }
        public DateTime NgayLapHoaDon(int id)
        {
            using (var db = new QLTVEntities())
            {
                var pm = db.PhieuMuons.FirstOrDefault(p => p.MaPM == id);
                return pm.NgayLapPhieu;
            }
        }
        public void LuuHoaDon(DateTime ngaylaphoadon, int mapm, decimal tienthanhtoan)
        {
            using (var db = new QLTVEntities())
            {
                var hd = new HoaDonTraSach()
                {
                    NgayLapHD = ngaylaphoadon,
                    MaPM = mapm,
                    TienThanhToan = tienthanhtoan
                };
                db.HoaDonTraSaches.Add(hd);
                db.SaveChanges();
            }
        }
    }
}
