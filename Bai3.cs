using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp_Tuan2
{
    public class Bai3
    {
        public bool KiemTraDoiXung(string chuoi)
        {
            if (chuoi == null)
            {
                return false;
            }
            
            chuoi = chuoi.Replace(" ", "").Trim();
            
            if (chuoi.Length == 0)
            {
                return false;
            }
            
            chuoi = chuoi.ToLower();
            
            int left = 0;
            int right = chuoi.Length - 1;
            
            while (left < right)
            {
                if (chuoi[left] != chuoi[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            
            return true;
        }
    }
}