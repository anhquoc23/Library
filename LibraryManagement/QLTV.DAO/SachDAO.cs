using QLTV.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace QLTV.DAO
{
    public class SachDAO
    {
        public SachDAO() { }
        public IEnumerable SachList()
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong,
                        s.MaNCC
                    }).Join(db.NhaCungCaps, c => c.MaNCC, n => n.MaNCC, (s, n) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        s.TenTacGia,
                        s.SoLuong,
                        n.TenNCC
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong,
                        NhaCungCap = s.TenNCC
                    });
                return query.ToList();
            }
        }

        public IEnumerable LoadSachByID(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong,
                        s.MaNCC
                    }).Join(db.NhaCungCaps, c => c.MaNCC, n => n.MaNCC, (s, n) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        s.TenTacGia,
                        s.SoLuong,
                        n.TenNCC
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong,
                        NhaCungCap = s.TenNCC
                    }).Where(q => q.MaSach.ToLower().Contains(key.ToLower()) || q.MaSach.ToLower().StartsWith(key.ToLower()) ||
                    q.MaSach.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable LoadSachBySach(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong,
                        s.MaNCC
                    }).Join(db.NhaCungCaps, c => c.MaNCC, n => n.MaNCC, (s, n) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        s.TenTacGia,
                        s.SoLuong,
                        n.TenNCC
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong,
                        NhaCungCap = s.TenNCC
                    }).Where(q => q.TenSach.ToLower().Contains(key.ToLower()) || q.MaSach.ToLower().StartsWith(key.ToLower()) ||
                    q.MaSach.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable LoadSachByTacGia(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong,
                        s.MaNCC
                    }).Join(db.NhaCungCaps, c => c.MaNCC, n => n.MaNCC, (s, n) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        s.TenTacGia,
                        s.SoLuong,
                        n.TenNCC
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong,
                        NhaCungCap = s.TenNCC
                    }).Where(q => q.TenTacGia.ToLower().Contains(key.ToLower()) || q.MaSach.ToLower().StartsWith(key.ToLower()) ||
                    q.MaSach.ToLower().EndsWith(key.ToLower()));
                return query.ToList();
            }
        }

        public IEnumerable ListSachMuon()
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong
                    }).Where(s => s.SoLuong >= 1);
                return query.ToList();
            }
        }
        public IEnumerable ListSachMuonByID(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong
                    }).Where(q => q.SoLuong >= 1 && (q.MaSach.ToLower().Contains(key.ToLower()) || q.MaSach.ToLower().StartsWith(key.ToLower()) ||
                    q.MaSach.ToLower().EndsWith(key.ToLower())));
                return query.ToList();
            }
        }
        public IEnumerable ListSachMuonByName(string key)
        {
            using (var db = new QLTVEntities())
            {
                var query = db.Saches.Join(db.TacGias, s => s.MaTacGia, t => t.MaTacGia,
                    (s, t) => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        s.GiaNhap,
                        t.TenTacGia,
                        s.SoLuong
                    }).ToList().Select(s => new
                    {
                        s.MaSach,
                        s.TenSach,
                        s.TheLoai,
                        GiaNhap = s.GiaNhap.ToString("#,##0.00"),
                        s.TenTacGia,
                        s.SoLuong
                    }).Where(q => q.SoLuong >= 1 && (q.TenSach.ToLower().Contains(key.ToLower()) || q.MaSach.ToLower().StartsWith(key.ToLower()) ||
                    q.MaSach.ToLower().EndsWith(key.ToLower())));
                return query.ToList();
            }
        }

        public int AddSach(Sach s)
        {
            using (var db = new QLTVEntities())
            {
                db.Saches.Add(s);
                return db.SaveChanges();
            }
        }

        public int EditSach(Sach s)
        {
            using (var db = new QLTVEntities())
            {
                var sach = db.Saches.Find(s.MaSach);
                if (sach != null)
                {
                    sach.TenSach = s.TenSach;
                    sach.TheLoai = s.MaSach;
                    sach.GiaNhap = s.GiaNhap;
                    sach.MaTacGia = s.MaTacGia;
                    sach.MaNCC = s.MaNCC;
                    sach.SoLuong = s.SoLuong;
                }
                return db.SaveChanges();
            }
        }

        public int DeleteSach(string id)
        {
            using (var db = new QLTVEntities())
            {
                var sach = db.Saches.First(s => s.MaSach == id);
                if (sach != null)
                {
                    bool canDelete = true;
                    int SoLanMuon = db.PhieuMuons
                                    .Join(db.ChiTietPhieuMuons, pm => pm.MaPM, ctpm => ctpm.MaPM,
                                    (pm, ctpm) => new { pm, ctpm })
                                    .Join(db.Saches, c => c.ctpm.MaSach, s => s.MaSach,
                                    (c, s) => new { c, s }).Where(q => q.s.MaSach == id).Count();
                    int SoLanTra = db.PhieuMuons
                                    .Join(db.ChiTietPhieuMuons, pm => pm.MaPM, ctpm => ctpm.MaPM,
                                    (pm, ctpm) => new { pm, ctpm })
                                    .Join(db.Saches, c => c.ctpm.MaSach, s => s.MaSach,
                                    (c, s) => new { c, s })
                                    .Join(db.HoaDonTraSaches, p => p.c.pm.MaPM, h => h.MaPM,
                                    (p, h) => new { p, h }).Where(q => q.p.s.MaSach == id).Count();
                    if (SoLanMuon > SoLanTra)
                        canDelete = false;
                    if (canDelete)
                    {
                        db.Saches.Remove(sach);
                        return db.SaveChanges();
                    }
                }
                return 0;
            }
        }
    }
}
