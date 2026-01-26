
namespace ConsoleApp_Tuan2
{
    public class Bai2
    {
        public int DemSoTu(string chuoi)
        {
            if (chuoi == null)
            {
                return 0;
            }
            
            chuoi = chuoi.Trim();
            if (chuoi.Length == 0)
            {
                return 0;
            }
            
            string[] words = chuoi.Split(' ');
            
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}