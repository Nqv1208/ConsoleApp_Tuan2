

using System.Collections;
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

        MyGenericClass<int> myGeneric = new MyGenericClass<int>();

        int[] numbers = { 5, 2, 8, 1, 9 };

        MyGenericClass<int> intObj = new MyGenericClass<int>();

        Console.WriteLine("Mang ban dau:");
        intObj.display(numbers);

        intObj.sort(numbers);

        Console.WriteLine("\nMang sau khi sap xep:");
        intObj.display(numbers);

        string[] names = { "An", "Binh", "Cuong", "Dung" };

        MyGenericClass<string> stringObj = new MyGenericClass<string>();

        Console.WriteLine("\nDanh sach ten ban dau:");
        stringObj.display(names);

        stringObj.sort(names);

        Console.WriteLine("\nDanh sach ten sau khi sap xep:");
        stringObj.display(names);

        Console.ReadLine();

    }
}