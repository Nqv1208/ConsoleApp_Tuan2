using ConsoleApp_Tuan2;
public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("=== Bài 1: Chuẩn hoá chuỗi họ tên ===");
        // Console.Write("Nhập vào họ tên: ");
        // string input = Console.ReadLine();
        
        // Bai1 bai1 = new Bai1(input);
        // string result = bai1.ChuanHoaChuoi(input);
        // Console.WriteLine("Kết quả: " + result);
        
        // Console.WriteLine("\n=== Bài 2: Đếm số từ trong chuỗi ===");
        // Console.Write("Nhập vào chuỗi: ");
        // string input2 = Console.ReadLine();
        
        // Bai2 bai2 = new Bai2();
        // int wordCount = bai2.DemSoTu(input2);
        // Console.WriteLine("Số từ: " + wordCount);
        
        // Console.WriteLine("\n=== Bài 3: Kiểm tra chuỗi đối xứng ===");
        // Console.Write("Nhập vào chuỗi: ");
        // string input3 = Console.ReadLine();
        
        // Bai3 bai3 = new Bai3();
        // bool isSymmetric = bai3.KiemTraDoiXung(input3);
        // Console.WriteLine("Kết quả: " + (isSymmetric ? "Chuỗi đối xứng" : "Chuỗi không đối xứng"));

        // int? luachon = null;
        // string chuoi;
        // do
        // {
        //     Console.WriteLine("\n=== MENU ===");
        //     Console.WriteLine("1. ChuanHoaChuoi");
        //     Console.WriteLine("2. DemSoTu");
        //     Console.WriteLine("3. KiemTraDoiXung");
        //     Console.WriteLine("0. Thoat");
        //     Console.Write("Nhap lua chon: ");
        //     luachon = int.Parse(Console.ReadLine());
        //     switch (luachon)
        //     {
        //         case 1:
        //             Console.Write("Nhap chuoi: ");
        //             chuoi = Console.ReadLine();
        //             Bai1 bai1 = new Bai1();
        //             Console.WriteLine("Chuỗi được chuẩn hóa: " + bai1.ChuanHoaChuoi(chuoi));
        //             break;
        //         case 2:
        //             Console.Write("Nhap chuoi: ");
        //             chuoi = Console.ReadLine();
        //             Bai2 bai2 = new Bai2();
        //             Console.WriteLine("So tu trong chuoi: " + bai2.DemSoTu(chuoi));
        //             break;
        //         case 3:
        //             Console.Write("Nhap chuoi: ");
        //             chuoi = Console.ReadLine();
        //             Bai3 bai3 = new Bai3();
        //             Console.WriteLine("Ket qua: " + (bai3.KiemTraDoiXung(chuoi) ? "Chuỗi đối xứng" : "Chuỗi không đối xứng"));
        //             break;
        //         case 0:
        //             Console.WriteLine("Thoát chương trình.");
        //             break;
        //         default:
        //             Console.WriteLine("Lựa chọn không hợp lệ.");
        //             break;
        //     }
        // } while (luachon != 0);

        // Console.WriteLine("\n=== Bài 6: Đếm số chẵn trong mảng ===");
        // int length = 0;
        // int[] arr;
        
        // Console.Write("Nhập độ dài mảng: ");
        // length = int.Parse(Console.ReadLine());
        // arr = new int[length];

        // for(int i = 0; i < length; i++) {
        //     Console.Write("Nhập phần tử thứ " + (i + 1) + ": ");
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // Bai6 bai6 = new Bai6();
        // int demChan = bai6.DemSoChan(arr);
        // Console.WriteLine("Số lượng số chẵn trong mảng: " + demChan);

        // ArrayList mang = new ArrayList();
        // mang.Add(3);
        // mang.Add("Vinh");

        // foreach (var idex in mang)
        //     Console.WriteLine(idex);

        // var arr = new List<int>();
        // arr.Add(1);
        // arr.Add(2);
        // arr.Add(3);

        // MyGenericClass<int> myGeneric = new MyGenericClass<int>();

        // int[] numbers = { 5, 2, 8, 1, 9 };

        // MyGenericClass<int> intObj = new MyGenericClass<int>();

        // Console.WriteLine("Mang ban dau:");
        // intObj.display(numbers);

        // intObj.sort(numbers);

        // Console.WriteLine("\nMang sau khi sap xep:");
        // intObj.display(numbers);

        // string[] names = { "An", "Binh", "Cuong", "Dung" };

        // MyGenericClass<string> stringObj = new MyGenericClass<string>();

        // Console.WriteLine("\nDanh sach ten ban dau:");
        // stringObj.display(names);

        // stringObj.sort(names);

        // Console.WriteLine("\nDanh sach ten sau khi sap xep:");
        // stringObj.display(names);

        // Console.ReadLine();

        List<SinhVien> sinhVienList = new List<SinhVien>();

        sinhVienList.Add(new SinhVien("SV001", "Nguyen Van A", 20, "23T3", "Cong nghe so", false, 3.5));
        sinhVienList.Add(new SinhVien("SV002", "Le Thi B", 21, "22T1", "Cong nghe so", true, 3.2));
        sinhVienList.Add(new SinhVien("SV003", "Tran Van C", 19, "24DT1", "Dien - Dien tu", false, 3.0));
        sinhVienList.Add(new SinhVien("SV004", "Pham Thi D", 22, "23T2", "Cong nghe so", true, 3.6));
        sinhVienList.Add(new SinhVien("SV005", "Hoang Van E", 20, "23T3", "Cong nghe so", false, 3.1));
        sinhVienList.Add(new SinhVien("SV006", "Nguyen Thi F", 21, "22T1", "Cong nghe so", true, 3.4));
        sinhVienList.Add(new SinhVien("SV007", "Tran Van G", 20, "24DT1", "Dien - Dien tu", false, 2.9));
        sinhVienList.Add(new SinhVien("SV008", "Le Thi H", 19, "23T2", "Cong nghe so", false, 3.3));
        sinhVienList.Add(new SinhVien("SV009", "Pham Van I", 22, "23T3", "Cong nghe so", true, 3.7));
        sinhVienList.Add(new SinhVien("SV010", "Hoang Thi J", 20, "22T1", "Cong nghe so", false, 3.0));

        sinhVienList.Add(new SinhVien("SV011", "Nguyen Van K", 21, "24DT1", "Dien - Dien tu", true, 3.2));
        sinhVienList.Add(new SinhVien("SV012", "Tran Thi L", 20, "23T2", "Cong nghe so", false, 3.4));
        sinhVienList.Add(new SinhVien("SV013", "Le Van M", 19, "23T3", "Cong nghe so", false, 2.8));
        sinhVienList.Add(new SinhVien("SV014", "Pham Thi N", 22, "22T1", "Cong nghe so", true, 3.6));
        sinhVienList.Add(new SinhVien("SV015", "Hoang Van O", 21, "24DT1", "Dien - Dien tu", false, 3.1));
        sinhVienList.Add(new SinhVien("SV016", "Nguyen Thi P", 20, "23T2", "Cong nghe so", false, 3.3));
        sinhVienList.Add(new SinhVien("SV017", "Tran Van Q", 19, "23T3", "Cong nghe so", false, 2.7));
        sinhVienList.Add(new SinhVien("SV018", "Le Thi R", 21, "22T1", "Cong nghe so", true, 3.5));
        sinhVienList.Add(new SinhVien("SV019", "Pham Van S", 20, "24DT1", "Dien - Dien tu", false, 3.0));
        sinhVienList.Add(new SinhVien("SV020", "Hoang Thi T", 22, "23T2", "Cong nghe so", true, 3.8));


        // 1 Max tuoi vaf min tuoi
        int maxTuoi = sinhVienList.Max(sv => sv.tuoi);
        int minTuoi = sinhVienList.Min(sv => sv.tuoi);
        Console.WriteLine("Tuổi lớn nhất: " + maxTuoi);
        Console.WriteLine("Tuổi nhỏ nhất: " + minTuoi);
        Console.WriteLine();

        // 2 Kiem tra sinh vien thuoc khoa cong nghe so
        foreach (var sv in sinhVienList)
        {
            if (sv.khoa == "Cong nghe so")
            {
                Console.WriteLine("Sinh viên thuộc khoa Công nghệ số: " + sv.hoTen);
            }
        }
        Console.WriteLine();

        // 3 Lay 10 sinh vien co diem cao nhat
        foreach (var sv in sinhVienList.OrderByDescending(sv => sv.diemTB).Take(10))
        {
            Console.WriteLine("Sinh viên có điểm trung bình cao: " + sv.maSV + " - " + sv.hoTen + " - Điểm TB: " + sv.diemTB);
        }
        Console.WriteLine();

        // 4 Bo qua sinh vien nam cuoi va lay ra toan bo sinh vien con lai
        Console.WriteLine("Sinh viên không phải năm cuối:");
        foreach (var sv in sinhVienList.Where(sv => !sv.namCuoi))
        {
            sv.InThongTin();
        }

    }
}