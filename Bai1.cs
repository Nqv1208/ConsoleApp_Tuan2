using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp_Tuan2
{
    public class Bai1
    {
        public Bai1() {}
        
        public string ChuanHoaChuoi(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
            {
                return "Lỗi: Chuỗi rỗng hoặc null.";
            }
            
            chuoi = chuoi.Trim();
            
            while (chuoi.Contains("  "))
            {
                chuoi = chuoi.Replace("  ", " ");
            }
            
            string[] words = chuoi.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            
            return string.Join(" ", words);
        }
    }
}