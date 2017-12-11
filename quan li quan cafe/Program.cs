using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    class Program
    {
        static List<LoaiKhach> dsLoaiKhach = new List<LoaiKhach>();
        static List<Khach> dsKhach = new List<Khach>();
        static List<ViTri> dsViTri = new List<ViTri>();
        static List<Ban> dsBan = new List<Ban>();
        static List<NhanVien> dsNhanVien = new List<NhanVien>();
        static List<LichTrucNhanVien> dsLichTrucNhanVien = new List<LichTrucNhanVien>();
        static List<ChonBan> dsChonBan = new List<ChonBan>();
        static List<HoaDon> dsHoaDon = new List<HoaDon>();
        static List<HoaDonMuaVe> dsHoaDonMuaVe = new List<HoaDonMuaVe>();
        static List<LoaiNguyenLieu> dsLoaiNguyenLieu = new List<LoaiNguyenLieu>();
        static List<NguyenLieu> dsNguyenLieu = new List<NguyenLieu>();
        static List<NhaCungCap> dsNhaCungCap = new List<NhaCungCap>();
        static List<HopDongCungCap> dsHopDongCungCap = new List<HopDongCungCap>();
        static List<NhomThucUong> dsNhomThucUong = new List<NhomThucUong>();
        static List<PhaChe> dsPhaChe = new List<PhaChe>();
        static List<ChiTietHopDongCungCap> dsChiTietHopDongCungCap = new List<ChiTietHopDongCungCap>();
        static List<ChiTietHopDongMuaVe> dsChiTietHopDongMuaVe = new List<ChiTietHopDongMuaVe>();
        static List<ChiTietHopDong> dsChiTietHopDong = new List<ChiTietHopDong>();
        static List<ThucUong> dsThucUong = new List<ThucUong>();
        static List<PhieuChi> dsPhieuChi = new List<PhieuChi>();
        static List<BangGia> dsBangGia = new List<BangGia>();
        static List<LamGia> dsLamGia = new List<LamGia>();

        public static void TaoDanhSachLoaiKhach()
        {
            dsLoaiKhach.Add(new LoaiKhach(2, "Khach Vang Lai"));
            dsLoaiKhach.Add(new LoaiKhach(1, "Khach VIP"));
        }
        public static void TaoDanhSachKhach()
        {
            dsKhach.Add(new Khach(1, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(2, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(3, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(4, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(5, dsLoaiKhach[1]));
            dsKhach.Add(new Khach(6, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(7, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(8, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(9, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(10, dsLoaiKhach[1]));
            dsKhach.Add(new Khach(11, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(12, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(13, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(14, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(15, dsLoaiKhach[1]));
            dsKhach.Add(new Khach(16, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(17, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(18, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(19, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(20, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(21, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(22, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(23, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(24, dsLoaiKhach[0]));
            dsKhach.Add(new Khach(25, dsLoaiKhach[1]));
        }
        public static void TaoDanhSachViTriBan()
        {
            dsViTri.Add(new ViTri(1));
            dsViTri.Add(new ViTri(2));
            dsViTri.Add(new ViTri(3));
            dsViTri.Add(new ViTri(4));
            dsViTri.Add(new ViTri(5));
            dsViTri.Add(new ViTri(6));
        }
        public static void TaoDanhSachBan()
        {
            //VITRI 1
            dsBan.Add(new Ban(1, "A", dsViTri[0]));
            dsBan.Add(new Ban(2, "B", dsViTri[0]));
            dsBan.Add(new Ban(3, "C", dsViTri[0]));
            dsBan.Add(new Ban(4, "D", dsViTri[0]));
            //VITRI 2
            dsBan.Add(new Ban(5, "E", dsViTri[1]));
            dsBan.Add(new Ban(6, "F", dsViTri[1]));
            dsBan.Add(new Ban(7, "G", dsViTri[1]));
            dsBan.Add(new Ban(8, "H", dsViTri[1]));
            //vitri 3
            dsBan.Add(new Ban(9, "I", dsViTri[2]));
            dsBan.Add(new Ban(10, "J", dsViTri[2]));
            dsBan.Add(new Ban(11, "K", dsViTri[2]));
            dsBan.Add(new Ban(12, "L", dsViTri[2]));
            //VITRI 4
            dsBan.Add(new Ban(13, "M", dsViTri[3]));
            dsBan.Add(new Ban(14, "N", dsViTri[3]));
            dsBan.Add(new Ban(15, "O", dsViTri[3]));
            dsBan.Add(new Ban(16, "P", dsViTri[3]));
            //VITRI 5
            dsBan.Add(new Ban(17, "Q", dsViTri[4]));
            dsBan.Add(new Ban(18, "R", dsViTri[4]));
            dsBan.Add(new Ban(19, "S", dsViTri[4]));
            dsBan.Add(new Ban(20, "T", dsViTri[4]));
            //VITRI 6
            dsBan.Add(new Ban(21, "W", dsViTri[5]));
            dsBan.Add(new Ban(22, "X", dsViTri[5]));
            dsBan.Add(new Ban(23, "Y", dsViTri[5]));
            dsBan.Add(new Ban(24, "Z", dsViTri[5]));
        }
        public static void TaoDanhSachNhanVien()
        {
            dsNhanVien.Add(new NhanVien("Mot", 1,true));
            dsNhanVien.Add(new NhanVien("Hai", 2));
            dsNhanVien.Add(new NhanVien("Ba", 3));
            dsNhanVien.Add(new NhanVien("Bon", 4));
            dsNhanVien.Add(new NhanVien("Nam", 5));
            dsNhanVien.Add(new NhanVien("Sau", 6));
            dsNhanVien.Add(new NhanVien("Bay", 7));
            dsNhanVien.Add(new NhanVien("Tam", 8));
            dsNhanVien.Add(new NhanVien("Chin", 9));
            dsNhanVien.Add(new NhanVien("Muoi", 10));

        }
        public static void TaoDanhSachLichTrucNhanVien()
        {
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "23/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "23/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "23/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "23/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "23/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "23/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "23/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "23/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "23/11/2016", 2, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "23/11/2016", 2, dsViTri[3]));
            //
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "24/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "24/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "24/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "24/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "24/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "24/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "24/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "24/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "24/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "24/11/2016", 2, dsViTri[3]));
            //
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "25/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "25/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "25/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "25/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "25/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "25/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "25/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "25/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "25/11/2016", 2, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "25/11/2016", 2, dsViTri[3]));
            //
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "26/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "26/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "26/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "26/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "26/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "26/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "26/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "26/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "26/11/2016", 2, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "26/11/2016", 2, dsViTri[3]));
            //
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "27/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "27/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "27/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "27/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "27/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "27/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "27/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "27/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "27/11/2016", 2, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "27/11/2016", 2, dsViTri[3]));
            //
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[0], "28/11/2016", 1, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[1], "28/11/2016", 1, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[2], "28/11/2016", 1, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[3], "28/11/2016", 1, dsViTri[3]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[4], "28/11/2016", 1, dsViTri[4]));
            //
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[5], "28/11/2016", 2, dsViTri[5]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[6], "28/11/2016", 2, dsViTri[0]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[7], "28/11/2016", 2, dsViTri[1]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[8], "28/11/2016", 2, dsViTri[2]));
            dsLichTrucNhanVien.Add(new LichTrucNhanVien(dsNhanVien[9], "28/11/2016", 2, dsViTri[3]));
        }
        public static void TaoDanhSachHoaDon()
        {
            dsHoaDon.Add(new HoaDon(1,  dsChonBan[0],dsLichTrucNhanVien[0], 20000));
            dsHoaDon.Add(new HoaDon(2, dsChonBan[1], dsLichTrucNhanVien[1], 36000));
            dsHoaDon.Add(new HoaDon(3, dsChonBan[2], dsLichTrucNhanVien[2], 78000));
            dsHoaDon.Add(new HoaDon(4, dsChonBan[3], dsLichTrucNhanVien[3], 105000));
            dsHoaDon.Add(new HoaDon(5, dsChonBan[4], dsLichTrucNhanVien[4], 12000));
            dsHoaDon.Add(new HoaDon(6, dsChonBan[5], dsLichTrucNhanVien[5], 30000));
            dsHoaDon.Add(new HoaDon(7, dsChonBan[6], dsLichTrucNhanVien[6], 15000));
            dsHoaDon.Add(new HoaDon(8, dsChonBan[7], dsLichTrucNhanVien[7], 20000));
            dsHoaDon.Add(new HoaDon(9, dsChonBan[8], dsLichTrucNhanVien[8], 20000));
            dsHoaDon.Add(new HoaDon(10, dsChonBan[9], dsLichTrucNhanVien[9], 50000));
            //
            dsHoaDon.Add(new HoaDon(11, dsChonBan[10], dsLichTrucNhanVien[10], 20000));
            dsHoaDon.Add(new HoaDon(12, dsChonBan[11], dsLichTrucNhanVien[11], 36000));
            dsHoaDon.Add(new HoaDon(13, dsChonBan[12], dsLichTrucNhanVien[12], 78000));
            dsHoaDon.Add(new HoaDon(14, dsChonBan[13], dsLichTrucNhanVien[13], 105000));
            dsHoaDon.Add(new HoaDon(15, dsChonBan[14], dsLichTrucNhanVien[14], 12000));
            dsHoaDon.Add(new HoaDon(16, dsChonBan[15], dsLichTrucNhanVien[15], 30000));
            dsHoaDon.Add(new HoaDon(17, dsChonBan[16], dsLichTrucNhanVien[16], 15000));
            dsHoaDon.Add(new HoaDon(18, dsChonBan[17], dsLichTrucNhanVien[17], 20000));
            dsHoaDon.Add(new HoaDon(19, dsChonBan[18], dsLichTrucNhanVien[18], 20000));
            dsHoaDon.Add(new HoaDon(20, dsChonBan[19], dsLichTrucNhanVien[19], 50000));
            //
            dsHoaDon.Add(new HoaDon(21, dsChonBan[20], dsLichTrucNhanVien[20], 20000));
            dsHoaDon.Add(new HoaDon(22, dsChonBan[21], dsLichTrucNhanVien[21], 36000));
            dsHoaDon.Add(new HoaDon(23, dsChonBan[22], dsLichTrucNhanVien[22], 78000));
            dsHoaDon.Add(new HoaDon(24, dsChonBan[23], dsLichTrucNhanVien[23], 105000));
            dsHoaDon.Add(new HoaDon(25, dsChonBan[24], dsLichTrucNhanVien[24], 12000));
            dsHoaDon.Add(new HoaDon(26, dsChonBan[0], dsLichTrucNhanVien[25], 30000));
            dsHoaDon.Add(new HoaDon(27, dsChonBan[1], dsLichTrucNhanVien[26], 15000));
            dsHoaDon.Add(new HoaDon(28, dsChonBan[1], dsLichTrucNhanVien[27], 20000));
            dsHoaDon.Add(new HoaDon(29, dsChonBan[1], dsLichTrucNhanVien[28], 20000));
            dsHoaDon.Add(new HoaDon(30, dsChonBan[2], dsLichTrucNhanVien[29], 50000));
            //
            dsHoaDon.Add(new HoaDon(31, dsChonBan[10], dsLichTrucNhanVien[30], 20000));
            dsHoaDon.Add(new HoaDon(32, dsChonBan[11], dsLichTrucNhanVien[31], 36000));
            dsHoaDon.Add(new HoaDon(33, dsChonBan[22], dsLichTrucNhanVien[32], 78000));
            dsHoaDon.Add(new HoaDon(34, dsChonBan[23], dsLichTrucNhanVien[33], 105000));
            dsHoaDon.Add(new HoaDon(35, dsChonBan[24], dsLichTrucNhanVien[34], 12000));
            dsHoaDon.Add(new HoaDon(36, dsChonBan[5], dsLichTrucNhanVien[35], 30000));
            dsHoaDon.Add(new HoaDon(37, dsChonBan[6], dsLichTrucNhanVien[36], 15000));
            dsHoaDon.Add(new HoaDon(38, dsChonBan[7], dsLichTrucNhanVien[37], 20000));
            dsHoaDon.Add(new HoaDon(39, dsChonBan[8], dsLichTrucNhanVien[38], 20000));
            dsHoaDon.Add(new HoaDon(40, dsChonBan[9], dsLichTrucNhanVien[39], 50000));
            //
            dsHoaDon.Add(new HoaDon(41, dsChonBan[0], dsLichTrucNhanVien[40], 20000));
            dsHoaDon.Add(new HoaDon(42, dsChonBan[1], dsLichTrucNhanVien[41], 36000));
            dsHoaDon.Add(new HoaDon(43, dsChonBan[2], dsLichTrucNhanVien[42], 78000));
            dsHoaDon.Add(new HoaDon(44, dsChonBan[3], dsLichTrucNhanVien[43], 105000));
            dsHoaDon.Add(new HoaDon(45, dsChonBan[4], dsLichTrucNhanVien[44], 12000));
            dsHoaDon.Add(new HoaDon(46, dsChonBan[5], dsLichTrucNhanVien[45], 30000));
            dsHoaDon.Add(new HoaDon(47, dsChonBan[6], dsLichTrucNhanVien[46], 15000));
            dsHoaDon.Add(new HoaDon(48, dsChonBan[7], dsLichTrucNhanVien[47], 20000));
            dsHoaDon.Add(new HoaDon(49, dsChonBan[8], dsLichTrucNhanVien[48], 20000));
            dsHoaDon.Add(new HoaDon(50, dsChonBan[9], dsLichTrucNhanVien[49], 50000));
            //
            dsHoaDon.Add(new HoaDon(51, dsChonBan[0], dsLichTrucNhanVien[50], 20000));
            dsHoaDon.Add(new HoaDon(52, dsChonBan[1], dsLichTrucNhanVien[51], 36000));
            dsHoaDon.Add(new HoaDon(53, dsChonBan[0], dsLichTrucNhanVien[52], 78000));
            dsHoaDon.Add(new HoaDon(54, dsChonBan[0], dsLichTrucNhanVien[53], 105000));
            dsHoaDon.Add(new HoaDon(55, dsChonBan[0], dsLichTrucNhanVien[54], 12000));
            dsHoaDon.Add(new HoaDon(56, dsChonBan[0], dsLichTrucNhanVien[55], 30000));
            dsHoaDon.Add(new HoaDon(57, dsChonBan[0], dsLichTrucNhanVien[56], 15000));
            dsHoaDon.Add(new HoaDon(58, dsChonBan[7], dsLichTrucNhanVien[57], 20000));
            dsHoaDon.Add(new HoaDon(59, dsChonBan[8], dsLichTrucNhanVien[58], 20000));
            dsHoaDon.Add(new HoaDon(60, dsChonBan[9], dsLichTrucNhanVien[59], 50000));
        }
        public static void TaoDanhSachHoaDonMuaVe()
        {
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(1, dsKhach[6], 15000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(2, dsKhach[17], 30000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(3, dsKhach[18], 12000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(4, dsKhach[19], 18000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(5, dsKhach[20], 18000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(6, dsKhach[21], 30000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(7, dsKhach[22], 78000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(8, dsKhach[23], 50000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(9, dsKhach[24], 20000));
            dsHoaDonMuaVe.Add(new HoaDonMuaVe(10, dsKhach[16], 25000));
        }
        public static void TaoDanhSachLoaiNguyenLieu()
        {
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(1, "Ca phe"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(2, "Sua"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(3, "Huong trai cay"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(4, "Trai cay"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(5, "Nuoc loc"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(6, "Hat tran chau"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(7, "Tra"));
            dsLoaiNguyenLieu.Add(new LoaiNguyenLieu(8, "Thach trai cay"));
        }
        public static void TaoDanhSachNguyenLieu()
        {
            dsNguyenLieu.Add(new NguyenLieu(1, "Ca phe Moka", dsLoaiNguyenLieu[0]));
            dsNguyenLieu.Add(new NguyenLieu(2, "Ca phe Gia Lai", dsLoaiNguyenLieu[0]));
            dsNguyenLieu.Add(new NguyenLieu(3, "Sua Hoan Hao", dsLoaiNguyenLieu[1]));
            dsNguyenLieu.Add(new NguyenLieu(4, "Sua Co gai Ha Lan", dsLoaiNguyenLieu[1]));
            dsNguyenLieu.Add(new NguyenLieu(5, "Huong Socola", dsLoaiNguyenLieu[2]));
            dsNguyenLieu.Add(new NguyenLieu(6, "Huong Xa", dsLoaiNguyenLieu[2]));
            dsNguyenLieu.Add(new NguyenLieu(7, "Dao", dsLoaiNguyenLieu[3]));
            dsNguyenLieu.Add(new NguyenLieu(8, "Cam", dsLoaiNguyenLieu[3]));
            dsNguyenLieu.Add(new NguyenLieu(9, "Nuoc loc Thanh Xuan", dsLoaiNguyenLieu[4]));
            dsNguyenLieu.Add(new NguyenLieu(10, "Hat tran chau tron", dsLoaiNguyenLieu[5]));
            dsNguyenLieu.Add(new NguyenLieu(11, "Hat tran chau vuong", dsLoaiNguyenLieu[5]));
            dsNguyenLieu.Add(new NguyenLieu(12, "Tra O Long", dsLoaiNguyenLieu[6]));
            dsNguyenLieu.Add(new NguyenLieu(13, "Thach trai cay vi dau", dsLoaiNguyenLieu[7]));
            dsNguyenLieu.Add(new NguyenLieu(14, "Thach trai cay vi kiwi", dsLoaiNguyenLieu[7]));
        }
        public static void TaoDanhSachNhomThucUong()
        {
            dsNhomThucUong.Add(new NhomThucUong(1, "Ca Phe"));
            dsNhomThucUong.Add(new NhomThucUong(2, "Tra"));
            dsNhomThucUong.Add(new NhomThucUong(3, "Tra Sua"));
            dsNhomThucUong.Add(new NhomThucUong(4, "Nuoc Giai Khat"));
        }
        public static void TaoDanhSachThucUong()
        {
            dsThucUong.Add(new ThucUong(1, "Ca Phe Den", dsNhomThucUong[0]));
            dsThucUong.Add(new ThucUong(2, "Ca Phe Sua", dsNhomThucUong[0]));
            dsThucUong.Add(new ThucUong(3, "Bach Xiu", dsNhomThucUong[0]));
            dsThucUong.Add(new ThucUong(4, "Cappuccion", dsNhomThucUong[0]));
            dsThucUong.Add(new ThucUong(5, "Tra Dao", dsNhomThucUong[1]));
            dsThucUong.Add(new ThucUong(6, "Tra Chanh", dsNhomThucUong[1]));
            dsThucUong.Add(new ThucUong(7, "Tra Sua Tran Chau", dsNhomThucUong[2]));
            dsThucUong.Add(new ThucUong(8, "Tra Sua Thach Trai Cay", dsNhomThucUong[2]));
            dsThucUong.Add(new ThucUong(9, "CoCaCoLa", dsNhomThucUong[3]));
        }
        public static void TaoDanhSachHopDongCungCap()
        {
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[0], 282));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[0], 382));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[0], 482));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[1], 242));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[1], 342));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[2], 439));
            dsHopDongCungCap.Add(new HopDongCungCap(dsNhaCungCap[2], 539));
        }
        public static void TaoDanhSachChiTietHopDongCungCap()
        {
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[0], dsNguyenLieu[0]));          
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[1], dsNguyenLieu[1]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[2], dsNguyenLieu[2]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[3], dsNguyenLieu[3]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[3], dsNguyenLieu[0]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[4], dsNguyenLieu[4]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[5], dsNguyenLieu[5]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[5], dsNguyenLieu[0]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[6], dsNguyenLieu[6]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[0], dsNguyenLieu[7]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[1], dsNguyenLieu[8]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[2], dsNguyenLieu[9]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[3], dsNguyenLieu[10]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[4], dsNguyenLieu[11]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[5], dsNguyenLieu[12]));
            dsChiTietHopDongCungCap.Add(new ChiTietHopDongCungCap(dsHopDongCungCap[6], dsNguyenLieu[13]));
        }
        public static void TaoDanhSachChiTietHopDongMuaVe()
        {
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[0], dsThucUong[0], "28/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[1], dsThucUong[1], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[2], dsThucUong[2], "25/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[3], dsThucUong[3], "26/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[4], dsThucUong[4], "27/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[5], dsThucUong[5], "28/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[6], dsThucUong[6], "23/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[7], dsThucUong[7], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[8], dsThucUong[7], "23/11/2016"));
            //
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[0], dsThucUong[2], "23/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[1], dsThucUong[1], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[2], dsThucUong[2], "25/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[3], dsThucUong[3], "26/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[4], dsThucUong[4], "27/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[5], dsThucUong[6], "28/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[6], dsThucUong[6], "23/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[7], dsThucUong[7], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[8], dsThucUong[7], "23/11/2016"));
            //
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[0], dsThucUong[0], "25/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[1], dsThucUong[1], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[2], dsThucUong[2], "25/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[3], dsThucUong[3], "26/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[4], dsThucUong[4], "25/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[5], dsThucUong[5], "28/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[6], dsThucUong[6], "24/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[7], dsThucUong[7], "23/11/2016"));
            dsChiTietHopDongMuaVe.Add(new ChiTietHopDongMuaVe(dsHoaDonMuaVe[8], dsThucUong[7], "23/11/2016"));
        }
        public static void TaoDanhSachChiTietHopDong()
        {
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[0], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[1], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[2], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[3], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[4], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[5], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[6], dsThucUong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[7], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[8], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[9], dsThucUong[0]));
            //
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[10], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[11], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[12], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[13], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[14], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[15], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[16], dsThucUong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[17], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[18], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[19], dsThucUong[7]));
            //
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[20], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[21], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[22], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[23], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[24], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[25], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[26], dsThucUong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[27], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[28], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[29], dsThucUong[5]));
            //
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[30], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[31], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[32], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[33], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[34], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[35], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[36], dsThucUong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[37], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[38], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[39], dsThucUong[3]));
            //
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[40], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[41], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[42], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[43], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[44], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[45], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[46], dsThucUong[6]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[47], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[48], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[49], dsThucUong[1]));
            //
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[50], dsThucUong[0]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[51], dsThucUong[1]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[52], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[53], dsThucUong[3]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[54], dsThucUong[4]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[55], dsThucUong[5]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[56], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[57], dsThucUong[7]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[58], dsThucUong[2]));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHoaDon[59], dsThucUong[2]));
        }
        public static void TaoDanhSachNhaCungCap()
        {
            dsNhaCungCap.Add(new NhaCungCap(1, "Phuc"));
            dsNhaCungCap.Add(new NhaCungCap(2, "Tri"));
            dsNhaCungCap.Add(new NhaCungCap(3, "Trieu"));
        }
        public static void TaoDanhSachChonBan()
        {
            dsChonBan.Add(new ChonBan(dsKhach[0], "25/11/2016", "8h10", dsBan[0]));
            dsChonBan.Add(new ChonBan(dsKhach[1], "27/11/2016", "16h20", dsBan[1]));
            dsChonBan.Add(new ChonBan(dsKhach[2], "23/11/2016", "15h30", dsBan[2]));
            dsChonBan.Add(new ChonBan(dsKhach[3], "27/11/2016", "14h40", dsBan[3]));
            dsChonBan.Add(new ChonBan(dsKhach[4], "23/11/2016", "13h50", dsBan[4]));
            dsChonBan.Add(new ChonBan(dsKhach[5], "26/11/2016", "12h20", dsBan[5]));
            dsChonBan.Add(new ChonBan(dsKhach[6], "28/11/2016", "7h52", dsBan[6]));
            dsChonBan.Add(new ChonBan(dsKhach[7], "23/11/2016", "14h40", dsBan[7]));
            dsChonBan.Add(new ChonBan(dsKhach[8], "24/11/2016", "9h55", dsBan[8]));
            dsChonBan.Add(new ChonBan(dsKhach[9], "25/11/2016", "10h40", dsBan[9]));
            //
            dsChonBan.Add(new ChonBan(dsKhach[10], "25/11/2016","8h10", dsBan[10]));
            dsChonBan.Add(new ChonBan(dsKhach[11], "25/11/2016","7h50", dsBan[11]));
            dsChonBan.Add(new ChonBan(dsKhach[12], "23/11/2016","9h25", dsBan[12]));
            dsChonBan.Add(new ChonBan(dsKhach[13], "25/11/2016","10h", dsBan[13]));
            dsChonBan.Add(new ChonBan(dsKhach[14], "26/11/2016","11h05", dsBan[14]));
            dsChonBan.Add(new ChonBan(dsKhach[15], "27/11/2016","15h30", dsBan[15]));
            dsChonBan.Add(new ChonBan(dsKhach[16], "25/11/2016","17h55", dsBan[16]));
            dsChonBan.Add(new ChonBan(dsKhach[17], "28/11/2016", "17h25", dsBan[17]));
            dsChonBan.Add(new ChonBan(dsKhach[18], "21/11/2016", "19h55", dsBan[18]));
            dsChonBan.Add(new ChonBan(dsKhach[19], "15/11/2016", "17h51", dsBan[19]));
            //
            dsChonBan.Add(new ChonBan(dsKhach[20], "24/11/2016", "20h55", dsBan[20]));
            dsChonBan.Add(new ChonBan(dsKhach[21], "25/11/2016", "21h35", dsBan[21]));
            dsChonBan.Add(new ChonBan(dsKhach[22], "26/11/2016", "7h55", dsBan[22]));
            dsChonBan.Add(new ChonBan(dsKhach[23], "27/11/2016", "11h55", dsBan[23]));
            dsChonBan.Add(new ChonBan(dsKhach[24], "28/11/2016", "17h25", dsBan[0]));
        }
        public static void TaoDanhSachPhieuChi()
        {
            dsPhieuChi.Add(new PhieuChi(1, dsHopDongCungCap[0]));
            dsPhieuChi.Add(new PhieuChi(2, dsHopDongCungCap[1]));
            dsPhieuChi.Add(new PhieuChi(3, dsHopDongCungCap[2]));
            dsPhieuChi.Add(new PhieuChi(4, dsHopDongCungCap[3]));
            dsPhieuChi.Add(new PhieuChi(5, dsHopDongCungCap[4]));
            dsPhieuChi.Add(new PhieuChi(6, dsHopDongCungCap[5]));
            dsPhieuChi.Add(new PhieuChi(7, dsHopDongCungCap[6]));

        }
        public static void TaoDanhSachPhaChe()
        {
            //cf den
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[0], dsThucUong[0]));
            //cf sua
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[1], dsThucUong[1]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[2], dsThucUong[1]));
            //bach xiu
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[0], dsThucUong[2]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[2], dsThucUong[2]));
            //Cappuccion
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[1], dsThucUong[3]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[2], dsThucUong[3]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[3], dsThucUong[3]));
            //tra dao cam xa
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[6], dsThucUong[4]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[5], dsThucUong[4]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[7], dsThucUong[4]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[11], dsThucUong[4]));
            //tra Chanh
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[7], dsThucUong[5]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[8], dsThucUong[5]));
            //tra sua hat tran chau
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[11], dsThucUong[6]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[9], dsThucUong[6]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[10], dsThucUong[6]));
            //tra sua thach trai cay
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[11], dsThucUong[7]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[12], dsThucUong[7]));
            dsPhaChe.Add(new PhaChe(dsNguyenLieu[13], dsThucUong[7]));

        }
        public static void TaoDanhSachBangGia()
        {
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[0],7000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[1], 17000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[2], 6000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[3], 5000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[4], 4000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[5], 8000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[6], 9000));
            dsBangGia.Add(new BangGia("23/11/2016", dsThucUong[7], 4000));
            //
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[0],7000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[1], 17000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[2], 26000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[3], 25000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[4], 14000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[5], 8000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[6], 9000));
            dsBangGia.Add(new BangGia("24/11/2016", dsThucUong[7], 4000));
            //
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[0],27000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[1], 17000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[2], 6000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[3], 35000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[4], 4000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[5], 28000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[6], 39000));
            dsBangGia.Add(new BangGia("25/11/2016", dsThucUong[7], 4000));
            //
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[0], 27000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[1], 17000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[2], 9000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[3], 3000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[4], 4000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[5], 28000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[6], 32000));
            dsBangGia.Add(new BangGia("26/11/2016", dsThucUong[7], 4000));
            //
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[0], 27000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[1], 17000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[2], 6000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[3], 35000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[4], 4000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[5], 28000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[6], 39000));
            dsBangGia.Add(new BangGia("27/11/2016", dsThucUong[7], 4000));
            //
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[0], 8000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[1], 12000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[2], 15000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[3], 7000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[4], 7000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[5], 17000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[6], 27000));
            dsBangGia.Add(new BangGia("28/11/2016", dsThucUong[7], 25000));                    
        }
        //public static void TaoDanhSachLamGia()
        //{
        //    dsLamGia.Add(new LamGia(dsBangGia[0], dsThucUong[0]));
        //    dsLamGia.Add(new LamGia(dsBangGia[1], dsThucUong[0]));
        //    dsLamGia.Add(new LamGia(dsBangGia[1], dsThucUong[1]));
        //    dsLamGia.Add(new LamGia(dsBangGia[2], dsThucUong[1]));
        //    dsLamGia.Add(new LamGia(dsBangGia[2], dsThucUong[2]));
        //    dsLamGia.Add(new LamGia(dsBangGia[3], dsThucUong[2]));
        //    dsLamGia.Add(new LamGia(dsBangGia[3], dsThucUong[3]));
        //    dsLamGia.Add(new LamGia(dsBangGia[4], dsThucUong[3]));
        //    dsLamGia.Add(new LamGia(dsBangGia[4], dsThucUong[4]));
        //    dsLamGia.Add(new LamGia(dsBangGia[5], dsThucUong[4]));
        //    dsLamGia.Add(new LamGia(dsBangGia[5], dsThucUong[5]));
        //    dsLamGia.Add(new LamGia(dsBangGia[6], dsThucUong[5]));
        //    dsLamGia.Add(new LamGia(dsBangGia[6], dsThucUong[6]));
        //    dsLamGia.Add(new LamGia(dsBangGia[7], dsThucUong[7]));
            
            
        //}
            
        static void Main(string[] args)
        {
            //tao data
            TaoDanhSachLoaiKhach();
            TaoDanhSachKhach();
            TaoDanhSachViTriBan();
            TaoDanhSachBan();
            TaoDanhSachNhanVien();
            TaoDanhSachLichTrucNhanVien();
            TaoDanhSachChonBan();
            TaoDanhSachHoaDon();
            TaoDanhSachHoaDonMuaVe();
            TaoDanhSachLoaiNguyenLieu();
            TaoDanhSachNguyenLieu();
            TaoDanhSachNhomThucUong();
            TaoDanhSachThucUong();
            TaoDanhSachBangGia();
            TaoDanhSachNhaCungCap();
            TaoDanhSachHopDongCungCap();
            TaoDanhSachPhieuChi();
            TaoDanhSachPhaChe();
            TaoDanhSachChiTietHopDongCungCap();
            TaoDanhSachChiTietHopDongMuaVe();
            TaoDanhSachChiTietHopDong();

            //1.Cho biết 1 loại thức được uống nhiều nhất  và tổng số tiền bán thức uống này trong này 25/11/2016 .
            //Cau1("25/11/2016");

            //2.Tinh Doanh Thu Ngày 25/11/2016.
            //Cau2();

            //3.Liệt kê thức uống khách đã chọn trong ngày 25/11/2016
            //Cau3();

            //4.Tinh số tiền bán cho khách víp ngày 27/11/2016.
            //Cau4();

            //5.Tìm những hóa đơn mua về có số tiền lớn nhất và cho biết trong từng hóa đơn có thức uống gì 
            //Cau5();

            //6.Tìm thức uống được pha chế từ nhiều nguyên liệu nhất và cho biết cách pha chế thức uống này .
            //Cau6();

            //7.Tìm vị trí bàn được chọn nhiều nhất ngày 25/11/2016 và cho biết bàn đó khách hàng đã gọi những món gì .
            //Cau7();

            //8.Liệt kê danh sách thuc uong khách hàng mua ở quán ngày 23/11/2016 .
            //Cau8();

            //9.Nhà Cung cấp nào có nhiều phiếu chi nhất và cho biết nhà cung cấp đó cung cấp những nguyên liệu gì .
            //Cau9();

            //10.Liệt kê lịch trực của nhân viên ngày 24/11/2016 ,
            //cho biết nhân viên nào trực nhiều nhất và nhan vien đó đã thanh toán bao nhiêu tiền cho khách .
            //Cau10();

            //11. nhom thuc uong co nhieu thuc uong nhat
            //Cau11();

            //12.Tìm những vị trí bàn được chọn nhiều nhất .
            //Cau12();

            //13.Danh sách những khách hàng có hóa đơn cao nhất 
            //Cau13();

            //14.Tính tổng nhân viên của cữa hàng và in ra .
            //Cau14();

            //15.Tính tổng số khách hàng vảng lai và tổng số tiền trên những biên lai của họ đến cữa hàng trong ngay 28/11/2016.
            //Cau15("28/11/2016");

            //16.Tìm nguyên liệu được sử dụng nhiều nhất để tạo ra thức uống của cữa hàng và liệt kê những thức uống này.
            //Cau16();

            //17.Danh sách những khách hàng đến cửa hàng vào 17h25 ngày 28/11/2016 và thức uống những khách đó mua
            //Cau17("28/11/2016", "17h25");

            //18.Cho biết danh sách các nguyên liệu có nhiều nhà cung cấp nhất 
            //và các nguyên liệu này thuộc những nhóm nguyên liệu nào .
            //Cau18();

            //19.Cho biết loại khách hàng nào chiếm đa số trong những khách hàng có hóa đơn thấp nhất 
            //và loại thức uống nào được mua nhiều nhất trong những hóa đơn này .
            //Cau19();

            //20.Loại khách hàng nào vào cữa hàng nhiều nhất ngày 26/11/2016.
            //Cau20();

            //21.Những vị trí bàn được nhiều nhân viên trực nhất .
            //Cau21();

            //22.Danh Sách khách hàng mua về ngày 27/11/2016.
            //Cau22();

            //23.Danh Sách nhân viên có lịch trực nhiều nhất .
            //Cau23();

            //24.Tổng số hóa đơn xuất ra từ ngày 23/11/2016-28/11/2016.
            //Cau24();

            //25.Số lượng cà phê đen bán được từ ngày 23/11/2016-28/11/2016 
            //và liệt kê những khách hàng đã mua cà phê đen vào ngày này
            //Cau25();

            //26.Danh sách những nhân viên trực những bàn có gọi thức uống có giá cao nhất .
            //Cau26();

            //27.Tìm loại thức uống có giá cao nhất và cho biết cách pha chế của nó .
            //Cau27();


            //28.Những thức uống nào không được ưa thích nhất cửa hàng tại quán (Thức uống được uống ít nhất ), 
            //cho biết có bao nhiêu khách hàng đã uống những thức uống này ( từ ngày 23/11/2016-28/11/2016) 
            //và cách pha chế những thức uống này.
            Cau28();

            //29.Liệt kê những thức uống khách hàng mua ngày 26/11/2016 và cho biết 
            //nguyên liệu nào được sử dụng nhiều nhất để chế biến ra những thức uống này.
            //Cau29();

            //30.Tính số tiền trung bình mỗi ngày bán hàng của cữa hàng từ ngày 23/11/2016-28/11/2016.
            //Cau30();


            Console.ReadKey();
        }
        //1.Thức uống nào được uống nhiều nhất  và tổng số tiền bán thức uống này trong này 25/11/2016 .

        public static void Cau1(string Ngay)
        {
            var dsThucUongTaiQuan =
                dsChiTietHopDong
                .Where(p => p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == Ngay)
                .GroupBy(p => p.THUCUONG.tenThucUong)
                .Select(p => new { tenthucuong = p.Key, soluong = p.Count() });
            Console.WriteLine("-----------Danh sach thuc uong tai quan ngay {0}------------", Ngay);
            foreach (var p in dsThucUongTaiQuan)
            {
                Console.WriteLine("ten thuc uong {0}, so luong tieu thu {1}", p.tenthucuong, p.soluong);
            }
            Console.WriteLine();


            var dsThucUongMuaVe =
                dsChiTietHopDongMuaVe
                .Where(p => p.Ngay == Ngay)
                .GroupBy(p => p.THUCUONG.tenThucUong)
                .Select(p => new { tenthucuong = p.Key, soluong = p.Count() });
            var dsBangGiaNgay =
                from p in dsBangGia
                where p.Ngay == Ngay
                select p;
            Console.WriteLine("-----------Danh sach thuc uong mua ve ngay {0}------------", Ngay);
            foreach (var p in dsThucUongMuaVe)
            {
                Console.WriteLine("ten thuc uong {0}, so luong tieu thu {1}", p.tenthucuong, p.soluong);
            }
            Console.WriteLine();
            string Name = null;
            int max = 0;
            double gia = 0;
            foreach (var i in dsThucUongMuaVe)
            {
                foreach (var j in dsThucUongTaiQuan)
                {
                    if (i.tenthucuong == j.tenthucuong)
                    {
                        if (i.soluong + j.soluong > max)
                        {
                            max = i.soluong + j.soluong;
                            Name = i.tenthucuong;
                        }
                    }
                    else
                    {
                        if (i.soluong > max)
                        {
                            max = i.soluong;
                            Name = i.tenthucuong;
                        }
                        if (j.soluong > max)
                        {
                            max = j.soluong;
                            Name = j.tenthucuong;
                        }
                    }
                }
            }

            //so tien ban duoc
            foreach (var p in dsBangGiaNgay)
            {
                if (Name == p.THUCUONG.tenThucUong)
                    gia = max * p.Gia;
            }
            Console.WriteLine("--------Thuoc uong duoc uong nhieu nhat trong ngay ---------------");
            Console.WriteLine("ten thuc uong : {0}, so luong {1}, doanh thu {2}", Name, max, gia);


        }
    
                
        //2.Tinh Doanh Thu Ngày 25/11/2016.

        public static void Cau2()
        {
            var dsThucUongMua =
                from p in dsChiTietHopDong
                where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == "25/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { tenthucuong = k.Key, soluong = k.Count() };

            var dsThucUongMangve =
                from p in dsChiTietHopDongMuaVe
                where p.Ngay == "25/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { tenthucuong = k.Key, soluong = k.Count() };

            //foreach (var p in dsThucUongMua)
            //{
            //    Console.WriteLine("ten thuc uong {0} so luong {1}", p.tenthucuong, p.soluong);
            //}
            //foreach (var p in dsThucUongMangve)
            //{
            //    Console.WriteLine("ten thuc uong {0} so luong {1}", p.tenthucuong, p.soluong);
            //}
            Console.WriteLine();
            var dsGiaThucUong25 =
               from p in dsBangGia
               where p.Ngay == "25/11/2016"
               select p;
            double doanhthu = 0;
            Console.WriteLine("Danh Sach Thuc Uong Ngay 25/11/2016 :");
            foreach(var p in dsGiaThucUong25)
            {
                foreach (var q in dsThucUongMua)
                {
                    if(q.tenthucuong==p.THUCUONG.tenThucUong)
                    {
                        doanhthu =doanhthu + q.soluong * p.Gia;
                        Console.WriteLine("Ten thuc uong tai cua hang {0} - so luong : {1}! Tong  gia :{2}", q.tenthucuong, q.soluong,q.soluong*p.Gia);
                    }
                }
                foreach (var e in dsThucUongMangve)
                {
                    if (e.tenthucuong == p.THUCUONG.tenThucUong)
                    {
                        doanhthu =doanhthu+ e.soluong * p.Gia;
                        Console.WriteLine("Ten thuc uong mang ve {0} so luong {1} !Tong gia : {2}", e.tenthucuong, e.soluong,e.soluong*p.Gia);
                    }
                }
            }
            Console.WriteLine("\nTong doanh thu ngay 25/11/2016 la : {0}",doanhthu);
        }

        //3.Liệt kê thức uống khách chọn trong ngày 25/11/2016
        public static void Cau3()
        {
            var dsThucUongMua =
                from p in dsChiTietHopDong
                where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == "25/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { tenthucuong = k.Key, soluong = k.Count() };
            Console.WriteLine("Danh sach Thuc Uong Khach Hang Chon Tai Quan Ngay 25/11/2016 :");
            foreach (var p in dsThucUongMua)
            {
                Console.WriteLine("     +{0}",p.tenthucuong);
            }
            var dsThucUongMangve =
                from p in dsChiTietHopDongMuaVe
                where p.Ngay == "25/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { tenthucuong = k.Key, soluong = k.Count() };
            Console.WriteLine("Danh sach Thuc Uong Khach Hang Chon Mang Ve Ngay 25/11/2016 :");
            foreach (var p in dsThucUongMangve)
            {
                Console.WriteLine("     +{0}", p.tenthucuong);
            }
            Console.WriteLine("/nDanh sach Thuc Uong Khach Hang Chon Ngay 25/11/2016 :");
            foreach (var p in dsThucUongMua)
            {
                Console.WriteLine("     +{0} ", p.tenthucuong);
            }
            foreach (var q in dsThucUongMangve)
            {
                int flag = 0;
                foreach(var e in dsThucUongMua)
                {
                    if (q.tenthucuong == e.tenthucuong)
                        flag = 1;
                }
                if(flag==0)
                    Console.WriteLine("     +{0}",q.tenthucuong);
            }
        }


        //4.Tinh số tiền bán cho khách víp ngày 27/11/2016.
        public static void Cau4()
        {
            var dsHoaDonKhachVip =
                from p in dsChiTietHopDong
                where p.HOADON.CHONBAN.KHACH.LOAIKHACH.tenLoaiKhach == "Khach VIP" && p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == "27/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { TenThucUong = k.Key, soLuong = k.Count() };
            var dsGiaNgay_27 =
               from p in dsBangGia
               where p.Ngay == "27/11/2016"
               select p;
            double doanhthu27VIP = 0;
            foreach (var p in dsHoaDonKhachVip)
            {
                foreach(var q in dsGiaNgay_27)
                {
                    if(p.TenThucUong==q.THUCUONG.tenThucUong)
                    {
                        doanhthu27VIP = doanhthu27VIP + p.soLuong * q.Gia; 
                    }
                }
            }
            Console.WriteLine("Tong tien ban cho Khach VIP ngay 27/11/2016 : {0}",doanhthu27VIP);
        }
        //5.Tìm những hóa đơn mua về có số tiền lớn nhất và cho biết trong từng hóa đơn có thức uống gì .
        public static void Cau5()
        {

            var dsHoaDonMuaVeChiTietLonNhat =
                from p in dsChiTietHopDongMuaVe
                where p.so_HD_MuaVe.SoTien == dsChiTietHopDongMuaVe.Max(tien => tien.so_HD_MuaVe.SoTien)
                select p;
            string TenThucUong = null;
           foreach(var p in dsHoaDonMuaVeChiTietLonNhat)
            {
                if (TenThucUong != p.THUCUONG.tenThucUong)
                {
                    Console.WriteLine("Hoa Don So {0} So Tien {1}", p.so_HD_MuaVe.soHoaDonMuaVe, p.so_HD_MuaVe.SoTien);
                    Console.WriteLine(" + Thuc Uong {0}", p.THUCUONG.tenThucUong);
                    TenThucUong = p.THUCUONG.tenThucUong;
                }
            }

              
        }
        //6.Tìm thức uống được pha chế từ nhiều nguyên liệu nhất và cho biết cách pha chế thức uống này .
        public static void Cau6()
        {
            var dsThucUongPhaChe =
                from p in dsPhaChe
                group p by p.THUCUONG.tenThucUong into k
                select new { TenThucUong = k.Key, SoLuongNguyenLieu = k.Count() };
            var dsThucUongPhaCheTuNhieuNguyenLieuNhat =
                from p in dsThucUongPhaChe
                where p.SoLuongNguyenLieu == dsThucUongPhaChe.Max(sl => sl.SoLuongNguyenLieu)
                select p;
            foreach(var p in dsThucUongPhaCheTuNhieuNguyenLieuNhat)
            {
                Console.WriteLine("Cach Pha Che Thuc Uong : {0}",p.TenThucUong);
                foreach(var q in dsPhaChe)
                {
                    if(p.TenThucUong==q.THUCUONG.tenThucUong)
                    {
                        Console.Write(" {0}  ",q.NGUYENLIEU.tenNguyenLieu);
                    }
                }
            }
                
        }
        //7.Tìm vị trí bàn được chọn nhiều nhất ngày 25/11/2016 
        //và cho biết vị trí này khách hàng đã uống những thức uống nào vào số lượng của những thức uống đó.
        public static void Cau7()
        {
            var dsViTriVaSoBan =
                from p in dsChonBan
                where p.Ngay == "25/11/2016"
                group p by p.BAN.VITRI.maViTri into k
                select new
                {
                    VitriBan = k.Key,
                    SoLuongBan = k.Count()
                };
            Console.WriteLine("---------------Danh sach vi tri ban duoc khach chon --------------");
            foreach (var i in dsViTriVaSoBan)
            {
                Console.WriteLine("vi tri ban : {0} - so lan chon : {1}", i.VitriBan, i.SoLuongBan);
            }
            Console.WriteLine();
            var dsViTriNhieuBanDuocChonNhat =
                from p in dsViTriVaSoBan
                where p.SoLuongBan == dsViTriVaSoBan.Max(sl => sl.SoLuongBan)
                group p by p.VitriBan into k
                select new { vitriban = k.Key, dsthucuong = 
                                                    from p in k
                                                    join q in dsChiTietHopDong on p.VitriBan equals q.HOADON.CHONBAN.BAN.VITRI.maViTri into u
                                                    from t in u
                                                    group t by t.THUCUONG.tenThucUong into h
                                                    select new { tenthucuong = h.Key, soluong = h.Count() }
                };
        
            
            foreach(var p in dsViTriNhieuBanDuocChonNhat)
            {
                Console.WriteLine("Ban duoc chon nhieu nhat ngay 25/11/2016 o vi tri {0}",p.vitriban);
                foreach(var q in p.dsthucuong )
                {
                    Console.WriteLine("ten thuc uong : {0} - soluong : {1}",q.tenthucuong,q.soluong);
                }
            }
        }
        //8.Liệt kê danh sách thuc uong va so luong tung thuc uong khách hàng mua ở quán ngày 23/11/2016
        public static void Cau8()
        {
            var dsThucUong23 =
                from p in dsChiTietHopDong
                where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == "23/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { TenThucUong = k.Key, SoLuong = k.Count() };
            var dsThucUongMuaVe23 =
                from p in dsChiTietHopDongMuaVe
                where p.Ngay == "23/11/2016"
                group p by p.THUCUONG.tenThucUong into k
                select new { TenThucUong = k.Key, SoLuong = k.Count() };
            int flag = 0, flag1=0;
            Console.WriteLine("Nhung thuc uong khach hang uong trong ngay 23/11/2016 va so luong :\n");
            foreach(var p in dsThucUong23)
            {
                flag = 0;
                foreach(var q in dsThucUongMuaVe23)
                {
                    if(p.TenThucUong==q.TenThucUong)
                    {
                        Console.WriteLine("+{0} so luong {1}.",q.TenThucUong,p.SoLuong+q.SoLuong);
                        flag = 1;
                    }
                    flag1 = 0;
                    foreach(var v in dsThucUong23)
                    {
                        if(q.TenThucUong==v.TenThucUong)
                        {
                            flag1 = 1;
                        }
                    }
                    if(flag1 ==0)
                        Console.WriteLine("+{0} so luong {1}",q.TenThucUong,q.SoLuong);
                }
                if (flag == 0)
                    Console.WriteLine("+{0} so luong {1}.", p.TenThucUong,p.SoLuong);
            }
            
        }
        //9.Nhà Cung cấp nào có nhiều phiếu chi nhất và cho biết nhà cung cấp đó cung cấp những nguyên liệu gì .
        public static void Cau9()
        {
            var DsNhaCungCapCoNhieuPhieuChiNhat =
                from p in dsPhieuChi
                where p.soPhieuChi == dsPhieuChi.Max(sl => sl.soPhieuChi)
                select p;
            foreach(var p in DsNhaCungCapCoNhieuPhieuChiNhat)
            {
                Console.WriteLine("Nha cung cap {0} phieu chi {1}",p.HOP_DONG_CUNG_CAP.NHACUNGCAP.tenNhaCungCap,p.soPhieuChi);
                Console.WriteLine("-Nguyen Lieu nha cung cap {0} cung cap cho cua hang :", p.HOP_DONG_CUNG_CAP.NHACUNGCAP.tenNhaCungCap);
                foreach (var q in dsChiTietHopDongCungCap)
                {
                    if(p.HOP_DONG_CUNG_CAP.NHACUNGCAP.tenNhaCungCap==q.HOP_DONG_CUNG_CAP.NHACUNGCAP.tenNhaCungCap)
                    {
                        Console.WriteLine("+{0}",q.NGUYENLIEU.tenNguyenLieu);
                    }
                }
            }
        }
        //10.Liệt kê lịch trực của nhân viên ngày 24/11/2016 ,liệt kê những nhân viên trực vị trí đc nhiều nhân viên trực nhất vào ngày 24/11/2016
        //và những nhân viên đó đã thanh toán bao nhiêu tiền cho khách .
        public static void Cau10()
        {
            var dsLichTruc24 =
               from p in dsLichTrucNhanVien
               where p.Ngay == "24/11/2016"
               select p;
            var dsViTriVaSoLuongChonViTri =
                from p in dsLichTruc24
                group p by p.VITRI.maViTri into k
                select new { vitri = k.Key, SoluongVitri = k.Count() };
            var ViTriChonNhieuNhat =
                from p in dsViTriVaSoLuongChonViTri
                where p.SoluongVitri == dsViTriVaSoLuongChonViTri.Max(sl => sl.SoluongVitri)
                select p;
            var dsThanhToan24 =
                from p in dsChiTietHopDong
                where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay == "24/11/2016"
                select p;

            uint TongTien = 0;
            foreach (var p in ViTriChonNhieuNhat)
            {
                Console.WriteLine("vi tri {0} so luong chon vi tri {1}", p.vitri, p.SoluongVitri);
                foreach (var q in dsLichTruc24)
                {
                    if (p.vitri == q.VITRI.maViTri)
                    {
                        Console.WriteLine("+Nhan Vien {0}", q.NHANVIEN.tenNhanVien);

                    }
                }
                foreach (var e in dsThanhToan24)
                {
                    if (p.vitri == e.HOADON.LICH_TRUC_NHAN_VIEN.VITRI.maViTri)
                    {
                        TongTien = TongTien + e.HOADON.SoTien;
                    }
                }
            }
            Console.WriteLine("So Tien Thanh Toan {0}", TongTien);
        }
        //cau 11 nhom thuc uong co nhieu thuc uong nhat
        public static void Cau11()
        {
            Console.WriteLine("-----------danh sach cac nhom thuc uong va so luong thuc uon trong nhom---------");
            var nhom =
                from p in dsThucUong
                group p by p.NHOMTHUCUONG.tenNhomThucUong into k
                select new { tennhom = k.Key, soluong = k.Count() };
            //lambda
            //var nhom = dsThucUong
            //    .GroupBy(p => p.NHOMTHUCUONG.tenNhomThucUong)
            //    .Select(p => new { tennhom = p.Key, soluong = p.Count() });
            foreach (var i in nhom)
            {
                Console.WriteLine("ten nhom {0}, so luong thuc trong nhom {1}",i.tennhom,i.soluong);
            }
            Console.WriteLine();
            Console.WriteLine("----------Nhom co nhieu thuc uong nhat-------------");
            var nhomMax =
                from p in nhom
                where p.soluong == nhom.Max(q => q.soluong)
                select p;
            //lambda
            //var nhomMax = nhom.Where(p => p.soluong == nhom.Max(q => q.soluong)).Select(p => p);
            foreach (var i in nhomMax)
            {
                Console.WriteLine("ten nhom : {0}, so luong {1}", i.tennhom, i.soluong);
            }

        }
        //12.Tìm những vị trí bàn được chọn nhiều nhất .
        public static void Cau12()
        {
            //var dsvitri =
            //    from p in dsHoaDon
            //    group p by p.CHONBAN.BAN.VITRI.maViTri into k
            //    select new { vitri = k.Key, solan = k.Count() };
            //lambda
            var dsvitri = dsHoaDon
                .GroupBy(p => p.CHONBAN.BAN.VITRI.maViTri)
                .Select(p => new { vitri = p.Key, solan = p.Count() });
            Console.WriteLine("----------danh sach hoa hon chon ban----------");
            foreach (var i in dsHoaDon)
            {
                Console.WriteLine("so hoa don {0}, ma ban {1},vi tri ban {2}",
                    i.soHoaDon,i.CHONBAN.BAN.maBan,i.CHONBAN.BAN.VITRI.maViTri);
            }
            Console.WriteLine();
            Console.WriteLine("------------vi tri duoc khach chon nhieu nhat---------");
            var dsvitrimax =
                from p in dsvitri
                where p.solan == dsvitri.Max(q => q.solan)
                select p;
            //lambda
            //var dsvitrimax = dsvitri
            //    .Where(p => p.solan == dsvitri.Max(t => t.solan))
            //    .Select(p => p);
            foreach (var i in dsvitrimax)
            {
                Console.WriteLine("ma vi tri {0}, so lan chon {1}", i.vitri, i.solan);
            }
        }
        // 13.Danh sách những khách hàng có hóa đơn cao nhất và những loại thức uống trong mỗi hóa đơn đó .
        public static void Cau13()
        {
            var dskhachmuave =
                from p in dsHoaDonMuaVe
                group p by p.KHACH.maKhach into k
                select new
                {
                    makhach = k.Key,
                    sotien = k.Sum(p => p.SoTien)
                };
            Console.WriteLine("----------danh sach khach mua ve ---------------");
            foreach (var i in dskhachmuave)
            {
                Console.WriteLine("ma khach {0} - so tien khach mua {1}", i.makhach, i.sotien);
            }
            Console.WriteLine();
            var dskhachtaiquan =
                from p in dsHoaDon
                group p by p.CHONBAN.KHACH.maKhach into k
                select new
                {
                    makhach = k.Key,
                    sotien = k.Sum(q => q.SoTien)                   
                };
            Console.WriteLine("----------danh sach khach mua ve ---------------");
            foreach (var i in dskhachtaiquan)
            {
                Console.WriteLine("ma khach {0} - so tien khach mua {1}", i.makhach, i.sotien);
            }
            Console.WriteLine();
            Console.WriteLine("----------Danh sach khach co hoa don cao nhat-------------");
            long tienmax = 0;
            
            //tim so tien lon nhat ma khach mua
            foreach (var i in dskhachmuave)
            {
                foreach (var j in dskhachtaiquan)
                {
                    //tim trong nhung khach vua uong tai quan vua mua ve
                    if (i.makhach == j.makhach)
                    {
                        if (tienmax < (long)i.sotien + (long)j.sotien)
                        {
                            tienmax = (long)i.sotien + j.sotien;
                        }
                    }
                    //tim trong nhung khach chi mua ve hoac chi uong tai quan
                    else
                    {
                        if (tienmax < (long)i.sotien)
                        {
                            tienmax = (long)i.sotien;
                        }
                        if (tienmax < (long)j.sotien)
                        {
                            tienmax = (long)j.sotien;
                        }
                    }
                }
            }
            //
            foreach (var i in dskhachmuave)
            {
                foreach (var j in dskhachtaiquan)
                {
                    if (i.makhach == j.makhach)
                    {
                        if (tienmax == (long)i.sotien + (long)j.sotien)
                        {
                            Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, tienmax);
                        }
                    }
                }
            }
            foreach (var i in dskhachmuave)
            {
                if ((long)i.sotien == tienmax)
                {
                    Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, tienmax);
                }
            }
            foreach (var i in dskhachtaiquan)
            {
                if ((long)i.sotien == tienmax)
                {
                    Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, tienmax);
                }
            }            
        }
        //14.Tính tổng nhân viên của cữa hàng và in ra .
        public static void Cau14()
        {
            Console.WriteLine("-----------------Danh sach nhan vien trong cua hang--------------");
            foreach (var i in dsNhanVien)
                Console.WriteLine("ten nhan vien : {0} - Ma so : {1}", i.tenNhanVien, i.maNhanVien);
            Console.WriteLine();
            int soluongnhanvien = dsNhanVien.Count();
            Console.WriteLine("nhan vien co trong cua hang {0} ", soluongnhanvien);
        }
        //15.Tính tổng số khách hàng vảng lai và tổng số tiền trên những biên lai của họ đến cữa hàng trong ngay 28/11/2016.
        public static void Cau15(string Ngay)
        {
            Console.WriteLine("------------Danh sach khach vang lai mua ve ngay {0}------------",Ngay);
            var dskhachvanglaimuave =
                from p in dsChiTietHopDongMuaVe
                where p.Ngay == Ngay && p.so_HD_MuaVe.KHACH.LOAIKHACH.maLoaiKhach == 2
                group p by p.so_HD_MuaVe.KHACH.maKhach into k
                select new { makhach = k.Key, sotien = k.Sum(t => t.so_HD_MuaVe.SoTien) };
            foreach (var i in dskhachvanglaimuave)
            {
                Console.WriteLine("ma khach  {0} - so tien mua ve {1}",
                    i.makhach,i.sotien);
            }
            Console.WriteLine();
            Console.WriteLine("tong so khach vang lai mua ve trong ngay {1} : {0}\n", dskhachvanglaimuave.Count(), Ngay);
           

            Console.WriteLine("----------Danh sach khach vang lai tai quan ngay {0}--------------",Ngay);
            var dskhachvanglaitaiquan =
                from p in dsChiTietHopDong
                where p.HOADON.CHONBAN.Ngay == Ngay && p.HOADON.CHONBAN.KHACH.LOAIKHACH.maLoaiKhach == 2
                group p by p.HOADON.CHONBAN.KHACH.maKhach into k
                select new { makhach = k.Key, sotien = k.Sum(t => t.HOADON.SoTien) };
            foreach (var i in dskhachvanglaitaiquan)
            {
                Console.WriteLine("ma khach  {0} - so tien mua ve {1}",
                    i.makhach,i.sotien);
            }
            Console.WriteLine();
            Console.WriteLine("tong so khach vang lai tai quan trong ngay {1} : {0}\n", dskhachvanglaitaiquan.Count(), Ngay);

            Console.WriteLine("---------------Danh sach khach vua uong vua mua ve------------------");
            var dskhachvanglaiuongmangve =
                from p in dskhachvanglaimuave
                join q in dskhachvanglaitaiquan on p.makhach equals q.makhach
                select new { makhach = p.makhach, sotien = p.sotien + q.sotien };
            foreach (var i in dskhachvanglaiuongmangve)
            {
                Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, i.sotien);
            }
            Console.WriteLine();

            Console.WriteLine("-------------Danh sach khach vang lai trong ngay-------------");
            foreach (var i in dskhachvanglaimuave)
            {
                if (dskhachvanglaiuongmangve.Count() != 0)
                {
                    foreach (var j in dskhachvanglaiuongmangve)
                    {
                        if (i.makhach == j.makhach)
                        {
                            Console.WriteLine("ma khach {0} - so tien {1}", j.makhach, j.sotien);
                        }
                        else Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, i.sotien);
                    }
                }
                else
                {               
                     Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, i.sotien);       
                }
            }
            foreach (var i in dskhachvanglaitaiquan)
            {
                if (dskhachvanglaiuongmangve.Count() != 0)
                {
                    foreach (var j in dskhachvanglaiuongmangve)
                    {
                        if (i.makhach != j.makhach)
                        {
                            Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, i.sotien);
                        }    
                    }
                }
                else
                {
                  Console.WriteLine("ma khach {0} - so tien {1}", i.makhach, i.sotien);                  
                }
            }
            int soluongkhachvanglai = (int)(dskhachvanglaimuave.Count() + dskhachvanglaitaiquan.Count()
                - dskhachvanglaiuongmangve.Count());
            Console.WriteLine("so luong khach vang lai trong ngay {0} : {1}\n", Ngay, soluongkhachvanglai);   
        }
        //16.Tìm nguyên liệu được sử dụng nhiều nhất để tạo ra thức uống của cữa hàng và liệt kê những thức uống này.
        public static void Cau16()
        {
            var dsnguyenlieu =
                from p in dsPhaChe
                group p by p.NGUYENLIEU.tenNguyenLieu into k
                select new
                {
                    tennguyenlieu = k.Key,
                    dsthucuong = from q in k
                                 group q by q.THUCUONG.tenThucUong into h
                                 select new { tenthucuong = h.Key }
                };
            foreach (var i in dsnguyenlieu)
            {
                Console.WriteLine("ten nguyen lieu : {0}", i.tennguyenlieu);
                Console.WriteLine("ten thuc uong su dung nguyen lieu tren : ");
                foreach (var j in i.dsthucuong)
                {
                    Console.WriteLine("- {0}", j.tenthucuong);
                }
                Console.WriteLine("So luong thuc uong su dung nguyen lieu nay : {0}", i.dsthucuong.Count());
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("---------------Danh sach nguyen lieu duoc su dung pha che nhieu thuc uong nhat----------");
            var dsnguyenlieuMax =
                from p in dsnguyenlieu
                where p.dsthucuong.Count() == dsnguyenlieu.Max(t => t.dsthucuong.Count())
                select p;
            foreach (var i in dsnguyenlieuMax)
            {
                Console.WriteLine("ten nguyen lieu : {0}", i.tennguyenlieu);
                Console.WriteLine("ten thuc uong su dung nguyen lieu tren : ");
                foreach (var j in i.dsthucuong)
                {
                    Console.WriteLine("- {0}", j.tenthucuong);
                }
                Console.WriteLine("So luong thuc uong su dung nguyen lieu nay : {0}", i.dsthucuong.Count());
                Console.WriteLine();
            }

        }
        //17.Danh sách những khách hàng đến cửa hàng vào 17h25 ngày 28/11/2016
        //và thức uống và số lượng thưc uông mànhững khách đó mua
        public static void Cau17(string Ngay,string Gio)
        {
            var dskhach = from p in dsChiTietHopDong
                          where p.HOADON.CHONBAN.Gio == Gio && p.HOADON.CHONBAN.Ngay == Ngay
                          group p by p.HOADON.CHONBAN.KHACH.maKhach into k
                          select new
                          {
                              makhach = k.Key,
                              dsthucuong = from q in k
                                           group q by q.THUCUONG.tenThucUong into h
                                           select new { tenthucuong = h.Key ,soluong = h.Count()}
                          };
            Console.WriteLine("Danh sach khach hang den quan luc {0} - ngay : {1}", Gio, Ngay);
            foreach (var i in dskhach)
            {
                Console.WriteLine("- Ma khach : {0}", i.makhach);
                Console.WriteLine("Danh sach thuc uong khach mua : ");
                foreach (var j in i.dsthucuong)
                {
                    Console.WriteLine("ten thuc uong : {0} - Soluong : {1}", j.tenthucuong,j.soluong);
                }
                Console.WriteLine();
            }
        }

        //18.Cho biết danh sách các nguyên liệu có nhiều nhà cung cấp nhất 
        //và các nguyên liệu này thuộc những nhóm nguyên liệu nào .
        public static void Cau18()
        {
            var dsnguyenlieu = from p in dsChiTietHopDongCungCap
                               group p by p.NGUYENLIEU.tenNguyenLieu into k
                               select new
                               {
                                   tennguyenlieu = k.Key,
                                   dsnhacungnhap = from q in k
                                                   group q by q.HOP_DONG_CUNG_CAP.NHACUNGCAP.tenNhaCungCap into h
                                                   select new { tennhacungcap = h.Key }
                               };
            Console.WriteLine("----------------Danh sach nguyen lieu va cac nha cung cap nguyen lieu do----------------");
            foreach (var i in dsnguyenlieu)
            {
                Console.WriteLine("ten nguyen lieu : {0} - so luong nha cung cap :  {1}", i.tennguyenlieu, i.dsnhacungnhap.Count());
                Console.WriteLine("Danh sach cac nha cung cap nguyen lieu tren : ");
                foreach (var j in i.dsnhacungnhap)
                {
                    Console.WriteLine("ten nha cung cap : {0}", j.tennhacungcap);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            var dsnguyenlieuMax = from p in dsnguyenlieu
                                  where p.dsnhacungnhap.Count() == dsnguyenlieu.Max(t => t.dsnhacungnhap.Count())
                                  select p;
            Console.WriteLine("---------------Nguyen Lieu co nhieu nha cung cap nhat ----------------");
            foreach (var i in dsnguyenlieuMax)
            {
                Console.WriteLine("ten nguyen lieu : {0} - so luong nha cung cap :  {1}", i.tennguyenlieu, i.dsnhacungnhap.Count());
                Console.WriteLine("Danh sach cac nha cung cap nguyen lieu tren : ");
                foreach (var j in i.dsnhacungnhap)
                {
                    Console.WriteLine("ten nha cung cap : {0}", j.tennhacungcap);
                }
                Console.WriteLine();
            }

            var dsnhomnguyenlieu = (from p in dsnguyenlieuMax
                                   join q in dsChiTietHopDongCungCap on p.tennguyenlieu equals q.NGUYENLIEU.tenNguyenLieu
                                   select new
                                   {
                                       tennguyenlieu = p.tennguyenlieu,
                                       nhomnguyenlieu = q.NGUYENLIEU.LOAINGUYENLIEU.tenLoaiNL
                                   }).Distinct();
            Console.WriteLine("Cac nguyen lieu do thuoc cac nhom nguyen lieu :");
            foreach (var i in dsnhomnguyenlieu)
            {
                Console.WriteLine("ten nguyen lieu : {0} - nhom : {1}", i.tennguyenlieu, i.nhomnguyenlieu);
            }
                                   
        }
        //19.Cho biết loại khách hàng nào chiếm đa số trong những khách hàng có hóa đơn thấp nhất 
        //và loại thức uống nào được mua nhiều nhất trong những hóa đơn này .
        public static void Cau19()
        {
            var dshoadonthapnhat = from p in dsChiTietHopDong
                                   where p.HOADON.SoTien == dsChiTietHopDong.Min(t => t.HOADON.SoTien)
                                   select p;
            Console.WriteLine("-----------Danh sach hoa don thap nhat -----------------");
            foreach (var i in dshoadonthapnhat)
            {
                Console.WriteLine("so hoa don : {0} - so tien {1}", i.HOADON.soHoaDon, i.HOADON.SoTien);
            }
            Console.WriteLine();

            var dskhachvip = from p in dshoadonthapnhat
                             where p.HOADON.CHONBAN.KHACH.LOAIKHACH.maLoaiKhach == 1
                             group p by p.HOADON.CHONBAN.KHACH.maKhach into k
                             select new { makhach = k.Key };
            Console.WriteLine("-------------Danh sach khach vip--------------");
            foreach (var i in dskhachvip)
            {
                Console.WriteLine("ma khach : {0}",i.makhach);
            }
            Console.WriteLine("so luong khach VIP : {0}", dskhachvip.Count());
            Console.WriteLine();

            var dskhachvanglai = from p in dshoadonthapnhat
                             where p.HOADON.CHONBAN.KHACH.LOAIKHACH.maLoaiKhach == 2
                             group p by p.HOADON.CHONBAN.KHACH.maKhach into k
                             select new { makhach = k.Key };
            Console.WriteLine("-------------Danh sach khach vang lai--------------");
            foreach (var i in dskhachvanglai)
            {
                Console.WriteLine("ma khach : {0}", i.makhach);
            }
            Console.WriteLine("so luong khach vang lai {0}", dskhachvanglai.Count());
            Console.WriteLine();

            if (dskhachvip.Count() > dskhachvanglai.Count())
                Console.WriteLine("khach vuot troi la khach VIP");
            else Console.WriteLine("Khach vuot troi la khach vang lai");

            Console.WriteLine();
            var dsthucuong = from p in dshoadonthapnhat
                              group p by p.THUCUONG.tenThucUong into k
                              select new { tenthucong = k.Key, soluong = k.Count() };
            Console.WriteLine("Danh sach thuc uong duoc mua nhieu nhat trong cac ds thap nhat");
            foreach (var i in dsthucuong)
            {
                Console.WriteLine("ten thuc uong {0}, soluong {1}", i.tenthucong, i.soluong);
            }
        }

        //20.Loại khách hàng nào vào cữa hàng nhiều nhất ngày 26/11/2016.
        public static void Cau20()
        {
            var loaikhach1 = from p in dsChonBan
                             where p.Ngay.Equals("26/11/2016")
                             group p by p.KHACH.LOAIKHACH.tenLoaiKhach into k
                             select new { loaikhach = k.Key, soluotvao = k.Count() };
            var loaikhach2 = from p in dsChiTietHopDongMuaVe
                             where p.Ngay.Equals("26/11/2016")
                             group p by p.so_HD_MuaVe.KHACH.LOAIKHACH.tenLoaiKhach into k
                             select new { loaikhach = k.Key, soluotvao = k.Count() };
            var loaikhach3 = from p in loaikhach1
                             join c in loaikhach2 on p.loaikhach equals c.loaikhach
                             select new
                             {
                                 tenloaikhach = p.loaikhach,
                                 soluotvao = p.soluotvao + c.soluotvao
                             };
            Console.WriteLine("-----------Danh sach loai khach uong tai quan !!!------------");
            foreach (var p in loaikhach1)
                Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
            Console.WriteLine();

            Console.WriteLine("-----------Danh sach loai khach mua ve !!!-------------------");
            foreach (var p in loaikhach2)
                Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
            Console.WriteLine();

            var loaikhach1max = from p in loaikhach1
                                where p.soluotvao == loaikhach1.Max(sl => sl.soluotvao)
                                select new { loaikhach = p.loaikhach, soluotvao = p.soluotvao };
            var loaikhach2max = from p in loaikhach2
                                where p.soluotvao == loaikhach2.Max(sl => sl.soluotvao)
                                select new { loaikhach = p.loaikhach, soluotvao = p.soluotvao };
            var loaikhach3max = from p in loaikhach3
                                where p.soluotvao == loaikhach3.Max(sl => sl.soluotvao)
                                select new { loaikhach = p.tenloaikhach, soluotvao = p.soluotvao };

            int t1 = 0, t2 = 0, t3 = 0;
            foreach (var p in loaikhach1max)
            {
                t1 = p.soluotvao;
            }
            foreach (var p in loaikhach2max)
            {
                t2 = p.soluotvao;
            }
            foreach (var p in loaikhach3max)
            {
                t3 = p.soluotvao;
            }

            Console.WriteLine("----------Loai khach vao cua hang nhieu nhat ngay 26/11/2016 !!!---------");

            if (t1 > t2 && t1 > t3)
            {
                foreach (var p in loaikhach1max)
                    Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
            }
            if (t3 > t2 && t3 > t1)
            {
                foreach (var p in loaikhach3max)
                    Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
            }
            else
            {
                if (t1 == t2 && t1 == t3)
                {
                    foreach (var p in loaikhach1max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                    foreach (var p in loaikhach2max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                    foreach (var p in loaikhach3max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                }
                if (t1 == t2)
                {
                    foreach (var p in loaikhach1max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                    foreach (var p in loaikhach2max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                }
                if (t2 == t3)
                {
                    foreach (var p in loaikhach2max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                    foreach (var p in loaikhach3max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                }
                if (t1 == t3)
                {
                    foreach (var p in loaikhach1max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                    foreach (var p in loaikhach3max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
                }
                else
                    foreach (var p in loaikhach2max)
                        Console.WriteLine("{0}, so luot vao: {1}", p.loaikhach, p.soluotvao);
            }
        }

        //30.Tính số tiền trung bình mỗi ngày bán hàng của cữa hàng từ ngày 23/11/2016-28/11/2016.
        public static void Cau30()
        {
            double TongTien = 0;
            int q = 0;
            for (int i = 23; i <= 28; i++)
            {
                double Tienmoingay = 0;
                var tienuongtaiquan = from p in dsChiTietHopDong
                                      where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay.Equals(i.ToString() + "/11/2016")
                                      group p by p.HOADON.SoTien into k
                                      select new { sotien = k.Key };
                var tienmuave = from p in dsChiTietHopDongMuaVe
                                where p.Ngay.Equals(i.ToString() + "/11/2016")
                                group p by p.so_HD_MuaVe.SoTien into k
                                select new { sotien = k.Key };

                foreach (var p in tienuongtaiquan)
                {
                    Tienmoingay += p.sotien;
                    TongTien += p.sotien;
                }
                foreach (var p in tienmuave)
                {
                    Tienmoingay += p.sotien;
                    TongTien += p.sotien;
                }
                q++;
                Console.WriteLine("Thu nhap ngay {0} la: {1}", i, Tienmoingay);
            }

            Console.WriteLine("Thu nhap trung moi ngay cua quan tinh tu ngay 23 - 28 la: {0}", TongTien / q);
        }


        //29.Liệt kê những thức uống khách hàng mua ngày 26/11/2016 và cho biết 
        //nguyên liệu nào được sử dụng nhiều nhất để chế biến ra những thức uống này.
        public static void Cau29()
        {
            var dsthucuongtaiquan = from p in dsChiTietHopDong
                                    where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay.Equals("26/11/2016")
                                    group p by p.THUCUONG.tenThucUong into k
                                    select new
                                    {
                                        tenthucuong = k.Key
                                    };
            var dsthucuongmuave = from p in dsChiTietHopDongMuaVe
                                  where p.Ngay.Equals("26/11/2016")
                                  group p by p.THUCUONG.tenThucUong into k
                                  select new
                                  {
                                      tenthucuong = k.Key
                                  };

            Console.WriteLine("-------------Danh sach thuc uong tai quan khach hang mua ngay 26/11/2016---------------------");
            foreach (var p in dsthucuongtaiquan)
                Console.WriteLine("Ten thuc uong: {0}", p.tenthucuong);
            Console.WriteLine();

            var dsnguyenlieutaiquan = from p in dsthucuongtaiquan
                                      join q in dsPhaChe on p.tenthucuong equals q.THUCUONG.tenThucUong into k
                                      from t in k
                                      group t by t.NGUYENLIEU.tenNguyenLieu into h
                                      select new { tennguyenlieu = h.Key, soluong = h.Count() };
            Console.WriteLine("------------Danh sach nguyen lieu pha che nhung thuc uong tai quan-------------------");

            foreach (var i in dsnguyenlieutaiquan)
                Console.WriteLine("ten nguyen lieu : {0} - so luong : {1}", i.tennguyenlieu, i.soluong);
            Console.WriteLine();


            var dsnguyenlieumuave = from p in dsthucuongmuave
                                    join q in dsPhaChe on p.tenthucuong equals q.THUCUONG.tenThucUong into k
                                    from t in k
                                    group t by t.NGUYENLIEU.tenNguyenLieu into h
                                    select new { tennguyenlieu = h.Key, soluong = h.Count() };

            Console.WriteLine("-------------Danh sach thuc uong mua ve khach hang mua ngay 26/11/2016---------------------");
            foreach (var p in dsthucuongmuave)
                Console.WriteLine("Ten thuc uong: {0}", p.tenthucuong);
            Console.WriteLine();

            Console.WriteLine("-----------------Danh sach nguyen lieu pha che cac thuc uong mang ve ---------------------");
            foreach (var i in dsnguyenlieumuave)
                Console.WriteLine("ten nguyen lieu : {0} - so luong : {1}", i.tennguyenlieu, i.soluong);
            Console.WriteLine();

            var dsnguyenlieuchung = from p in dsnguyenlieutaiquan
                                    join q in dsnguyenlieumuave on p.tennguyenlieu equals q.tennguyenlieu
                                    select new
                                    {
                                        tennguyenlieu = p.tennguyenlieu,
                                        soluong = p.soluong + q.soluong
                                    };

            var dsnguyenlieutaiquanmax = from p in dsnguyenlieutaiquan
                                         where p.soluong == dsnguyenlieutaiquan.Max(sl => sl.soluong)
                                         select p;

            var dsnguyenlieumuavemax = from p in dsnguyenlieumuave
                                       where p.soluong == dsnguyenlieumuave.Max(sl => sl.soluong)
                                       select p;

            var dsnguyenlieuchungmax = from p in dsnguyenlieuchung
                                       where p.soluong == dsnguyenlieuchung.Max(sl => sl.soluong)
                                       select p;

            Console.WriteLine("----------------Danh sach nguyen lieu duoc su dung nhieu nhat !!!----------------------");
            int t1 = 0, t2 = 0, t3 = 0;
            foreach (var p in dsnguyenlieutaiquanmax)
            {
                t1 = p.soluong;
            }
            foreach (var p in dsnguyenlieumuavemax)
            {
                t2 = p.soluong;
            }
            foreach (var p in dsnguyenlieuchungmax)
            {
                t3 = p.soluong;
            }

            if (t1 > t2 && t1 > t3)
            {
                foreach (var p in dsnguyenlieutaiquanmax)
                    Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
            }
            if (t3 > t2 && t3 > t1)
            {
                foreach (var p in dsnguyenlieuchungmax)
                    Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
            }
            else
            {
                if (t1 == t2 && t1 == t3)
                {
                    foreach (var p in dsnguyenlieutaiquanmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                    foreach (var p in dsnguyenlieumuavemax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                    foreach (var p in dsnguyenlieuchungmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                }
                if (t1 == t2)
                {
                    foreach (var p in dsnguyenlieutaiquanmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                    foreach (var p in dsnguyenlieumuavemax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                }
                if (t2 == t3)
                {
                    foreach (var p in dsnguyenlieumuavemax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                    foreach (var p in dsnguyenlieuchungmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                }
                if (t1 == t3)
                {
                    foreach (var p in dsnguyenlieutaiquanmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                    foreach (var p in dsnguyenlieuchungmax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
                }
                else
                    foreach (var p in dsnguyenlieumuavemax)
                        Console.WriteLine("Ten nguyen lieu: {0}, so luong: {1}", p.tennguyenlieu, p.soluong);
            }

        }

        //28.Những thức uống nào không được ưa thích nhất cửa hàng tại quán (Thức uống được uống ít nhất ), 
        //cho biết có bao nhiêu khách hàng đã uống những thức uống này ( từ ngày 23/11/2016-28/11/2016) 
        //và cách pha chế những thức uống này.
        public static void Cau28()
        {
            var thucuong = from p in dsChiTietHopDong
                           group p by p.THUCUONG.tenThucUong into k
                           select new { tenthucuong = k.Key, soluotmua = k.Count() };

            Console.WriteLine("--------Danh sach thuc uong va so luot mua cua chung tai cua hang !!!---------");
            foreach (var p in thucuong)
                Console.WriteLine("{0}, so luot mua: {1}", p.tenthucuong, p.soluotmua);
            Console.WriteLine();
            var thucuongmin = from p in thucuong
                              where p.soluotmua == thucuong.Min(sl => sl.soluotmua)
                              select p;

            Console.WriteLine("--------Thuc uong khong duoc ua thich tai cua hang !!!------------");
            foreach (var p in thucuongmin)
            {
                Console.Write("{0}, nguyen lieu: ", p.tenthucuong);
                var phache = from q in dsPhaChe
                             where q.THUCUONG.tenThucUong == p.tenthucuong
                             group q by q.NGUYENLIEU into k
                             select new { tennguyenlieu = k.Key.tenNguyenLieu };
                foreach (var k in phache)
                {
                    Console.Write("{0},", k.tennguyenlieu);
                }
                Console.WriteLine();
                Console.WriteLine("So luot mua: {0}", p.soluotmua);
            }
        }


        //27.Tìm loại thức uống có giá cao nhất và cho biết cách pha chế của nó .
        public static void Cau27()
        {
            var dsthucuongmax = from p in dsBangGia
                                where p.Gia == dsBangGia.Max(gia => gia.Gia)
                                group p by p.THUCUONG into k
                                select new { thucuong = k.Key };

            Console.WriteLine("---------Danh sach thuc uong va gia cua chung !!!----------");
            foreach (var p in dsBangGia)
                Console.WriteLine("{0}, {1}", p.THUCUONG.tenThucUong, p.Gia);
            Console.WriteLine();

            Console.WriteLine("---------Danh sach thuc uong gia cao nhat !!!--------------");
            foreach (var p in dsthucuongmax)
            {
                Console.Write("{0}, nguyen lieu: ", p.thucuong.tenThucUong);
                var phache = from q in dsPhaChe
                             where q.THUCUONG.tenThucUong == p.thucuong.tenThucUong
                             group q by q.NGUYENLIEU into k
                             select new { tennguyenlieu = k.Key.tenNguyenLieu };
                foreach (var k in phache)
                {
                    Console.Write("{0},", k.tennguyenlieu);
                }
                Console.WriteLine();
            }
        }


        //26.Danh sách những nhân viên trực những bàn có gọi thức uống có giá cao nhất .
        public static void Cau26()
        {
            var dsthucuongmax = from p in dsBangGia
                                where p.Gia == dsBangGia.Max(sl => sl.Gia)
                                group p by p.THUCUONG into k
                                select new { thucuong = k.Key };

            Console.WriteLine("Danh sach nhan vien truc nhung ban co goi thuc uong co gia tri cao nhat !!!");
            foreach (var p in dsthucuongmax)
            {
                var dsnhanvientruc = (from q in dsChiTietHopDong
                                      where q.THUCUONG.tenThucUong == p.thucuong.tenThucUong
                                      group q by q.HOADON.LICH_TRUC_NHAN_VIEN into k
                                      select new { tennhanvien = k.Key.NHANVIEN.tenNhanVien, vitiriban = k.Key.VITRI.maViTri }).Distinct();

                foreach (var k in dsnhanvientruc)
                    Console.WriteLine("Ten nhan vien: {0}, ma ban: {1}", k.tennhanvien, k.vitiriban);
            }
        }


        //25.Số lượng cà phê đen bán được từ ngày 23/11/2016-28/11/2016 và liệt kê những khách hàng đã mua cà phê đen vào ngày này.
        public static void Cau25()
        {
            int soluongcapheden = 0;
            for (int i = 23; i <= 28; i++)
            {
                var hoadon1 = from p in dsChiTietHopDong
                              where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay.Equals(i.ToString() + "/11/2016")
                              select p;
                int soluongcfdentaiquan = (from p in hoadon1
                                           where p.THUCUONG.tenThucUong.Equals("Ca Phe Den")
                                           select p).Count();

                var hoadonmuave1 = from q in dsChiTietHopDongMuaVe
                                   where q.Ngay.Equals(i.ToString() + "/11/2016")
                                   group q by q into k
                                   select new { tenthucuong = k.Key.THUCUONG.tenThucUong };
                int soluongcfdenmuave = (from q in hoadonmuave1
                                         where q.tenthucuong.Equals("Ca Phe Den")
                                         select q).Count();

                Console.WriteLine("So luong ca phe den tai quan ngay {0} la: {1}", i, soluongcfdentaiquan);
                Console.WriteLine("So luong ca phe den mua ve ngay {0} la:   {1}", i, soluongcfdenmuave);

                soluongcapheden += soluongcfdentaiquan + soluongcfdenmuave;
            }

            Console.WriteLine("\nSo luong ca phe den ban tu ngay 23-28: {0}", soluongcapheden);
        }


        //24.Tổng số hóa đơn xuất ra từ ngày 23/11/2016-28/11/2016.
        public static void Cau24()
        {
            int soluonghoadon = 0;
            int sohoadon = 0;
            int sohoadonmuave = 0;
            for (int i = 23; i <= 28; i++)
            {
                sohoadon = (from p in dsChiTietHopDong
                            where p.HOADON.LICH_TRUC_NHAN_VIEN.Ngay.Equals(i.ToString() + "/11/2016")
                            select p).Count();
                sohoadonmuave = (from q in dsChiTietHopDongMuaVe
                                 where q.Ngay.Equals(i.ToString() + "/11/2016")
                                 group q by q into k
                                 select new { sohoadon = k.Key.so_HD_MuaVe.soHoaDonMuaVe }).Count();
                Console.WriteLine("So hoa don tai quan ngay {0} la: {1}", i, sohoadon);
                Console.WriteLine("So hoa don mua ve ngay {0} la:   {1}", i, sohoadonmuave);
                soluonghoadon += sohoadon + sohoadonmuave;
            }
            Console.WriteLine("\nTong so hoa don tư ngay 23-28: {0}", soluonghoadon);
        }


        //23.Danh Sách nhân viên có lịch trực nhiều nhất .
        public static void Cau23()
        {
            var dsnhanvientruc = from p in dsLichTrucNhanVien
                                 group p by p.NHANVIEN.tenNhanVien into k
                                 select new { tennhanvien = k.Key, soluottruc = k.Count() };

            Console.WriteLine("-------------Danh sach nhan vien va so luot truc cua ho !!!--------------");
            foreach (var p in dsnhanvientruc)
                Console.WriteLine("Ten nhan vien: {0}, so luot truc: {1}", p.tennhanvien, p.soluottruc);
            Console.WriteLine();

            var dsnhanvientrucmax = from p in dsnhanvientruc
                                    where p.soluottruc == dsnhanvientruc.Max(sl => sl.soluottruc)
                                    select p;

            Console.WriteLine("-------------Danh sach nhan vien co lich truc nhieu nhat !!!-------------");
            foreach (var p in dsnhanvientrucmax)
                Console.WriteLine("Ten nhan vien: {0}, so luot truc: {1}", p.tennhanvien, p.soluottruc);
        }


        //22.Danh Sách khách hàng mua về ngày 27/11/2016.
        public static void Cau22()
        {
            var dskhachhangmuave = from p in dsChiTietHopDongMuaVe
                                   where p.Ngay.Equals("27/11/2016")
                                   group p by p.so_HD_MuaVe.KHACH into k
                                   select new { makhach = k.Key.maKhach, loaikhach = k.Key.LOAIKHACH.tenLoaiKhach };

            Console.WriteLine("-----------Danh sach khach hang mua ve ngay 27/11/2016 !!!----------");
            foreach (var p in dskhachhangmuave)
                Console.WriteLine("Ma khach: {0}, loai khach: {1}", p.makhach, p.loaikhach);
        }


        //21.Những vị trí bàn được nhiều nhân viên trực nhất .
        public static void Cau21()
        {
            var dsvitriban1 = (from p in dsLichTrucNhanVien
                               group p by p into k
                               select new { mavitri = k.Key.VITRI.maViTri, manhanvien = k.Key.NHANVIEN.maNhanVien, sonhanvien = k.Count() }).Distinct();
            var dsvitriban2 = from p in dsvitriban1
                              group p by p into k
                              select new { mavitri = k.Key.mavitri, sonhanvien = k.Count() };
            var dsvitriban3 = from p in dsvitriban2
                              group p by p into k
                              select new { mavitri = k.Key.mavitri, sonhanvien = k.Count() };

            Console.WriteLine("-------------Danh sach vi tri va so nhan vien truc tai vi tri do !!!-------------");
            foreach (var p in dsvitriban3)
                Console.WriteLine("Ma vi tri: {0}, so nhan vien truc: {1}", p.mavitri, p.sonhanvien);
            Console.WriteLine();
            var dsvitribanmaxnhanvien = from p in dsvitriban3
                                        where p.sonhanvien == dsvitriban3.Max(a => a.sonhanvien)
                                        select p;

            Console.WriteLine("-------------Nhung vi tri ban duoc nhieu nhan vien truc nhat !!!-----------------");
            foreach (var p in dsvitribanmaxnhanvien)
                Console.WriteLine("Ma vi tri: {0}, so nhan vien truc: {1}", p.mavitri, p.sonhanvien);
        }


        
    }
}