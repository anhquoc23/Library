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
    public class PhieuMuonBUS
    {
        public PhieuMuonBUS() { }

        public bool LapPhieuMuon(DateTime ngaylapphieu, string madocgia)
        {
            if (madocgia.Equals(""))
                return false;
            else
            {
                new PhieuMuonDAO().luuPhieuMuon(ngaylapphieu, madocgia);
                return true;
            }
        }
        public void LapCTPM(string masach, int soluong, int maphieumuon, decimal tiendatcoc)
        {
            new PhieuMuonDAO().luuCTPM(masach, soluong, maphieumuon, tiendatcoc);
        }
        public void SetSoLuongSachTrongCTPM(string masach, int soluong)
        {
            new PhieuMuonDAO().setSoLuongSachTrongCTPM(masach, soluong);
        }
        public int LayIDPhieuMuonLonNhat()
        {
            return new PhieuMuonDAO().layIDPhieuMuonLonNhat();
        }
        public IEnumerable LoadPhieuMuon()
        {
            return new PhieuMuonDAO().LoadPhieuMuon();
        }
        public IEnumerable LoadPhieuMuonByIDDG(string id)
        {
            return new PhieuMuonDAO().LoadPMByIDDG(id);
        }
        public DocGia LoadDocGiaByIDPM(string id)
        {
            return new PhieuMuonDAO().LoadDocGiaByIDPM(id);
        }
        public int SoLuongSachTrongPM(int id)
        {
            return new PhieuMuonDAO().SoLuongSachTrongCTPM(id);
        }
        public decimal TongTienDatCoc(int id)
        {
            return new PhieuMuonDAO().TongTienDatCoc(id);
        }
        public DateTime NgayLapPhieu(int id)
        {
            return new PhieuMuonDAO().NgayLapHoaDon(id);
        }
        public void LapHoaDon(DateTime ngaylaphoadon, int mapm, decimal tienthanhtoan)
        {
            new PhieuMuonDAO().LuuHoaDon(ngaylaphoadon, mapm, tienthanhtoan);
        }
    }
}
