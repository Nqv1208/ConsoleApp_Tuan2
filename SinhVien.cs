using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp_Tuan2
{
    public class SinhVien
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public int tuoi { get; set; }
        public string lop { get; set; }
        public string khoa { get; set; }
        public Boolean namCuoi { get; set; }
        public double diemTB { get; set; }

        public SinhVien(string maSV, string hoTen, int tuoi, string lop, string khoa, Boolean namCuoi, double diemTB)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.lop = lop;
            this.khoa = khoa;
            this.namCuoi = namCuoi;
            this.diemTB = diemTB;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Mã SV: {maSV}, Họ tên: {hoTen}, Tuổi: {tuoi}, Lớp: {lop}, Khoa: {khoa}, Năm cuối: {namCuoi}, Điểm TB: {diemTB}");
        }

    }
}