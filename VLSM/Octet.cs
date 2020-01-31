using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class Octet
    {
        public List<int> ListBits { get; set; }


        public Octet(int decimalValue = 0)
        {
            this.ListBits = new List<int>();


            if (decimalValue == 0)
            {
                for (int i = 0; i < 8; ++i)
                    this.ListBits.Add(0);
            }
            else
            {
                //  Lấy mảng bit (chuyển hệ Thập phân —> Nhị phân)
                this.ListBits = DecimalToBinary(decimalValue);
            }
        }

        


        public static List<int> DecimalToBinary(int decimalValue)
        {
            List<int> result = new List<int>();


            while (decimalValue > 0)
            {
                result.Add(decimalValue % 2);
                decimalValue /= 2;
            }


            //  Thêm các số 0 đằng trước để đủ Octet
            while (result.Count < 8)
                result.Add(0);


            //  Đảo ngược list để lấy kết quả
            result.Reverse();
            return result;
        }

        public string ToBinaryString()
        {
            string result = "";
            this.ListBits.ToList().ForEach(bit => result += bit);
            return result;
        }

        public int ToDecimal()
        {
            int result = 0;
            int octetLength = this.ListBits.Count;


            for (int i = 0; i < octetLength; ++i)
                if (this.ListBits[i] == 1)
                    result += (int)(Math.Pow(2, octetLength - 1 - i));

            return result;
        }

        public static int ToDecimal(List<int> listBits)
        {
            int result = 0;
            int octetLength = listBits.Count;


            for (int i = 0; i < octetLength; ++i)
                if (listBits[i] == 1)
                    result += (int)(Math.Pow(2, octetLength - 1 - i));

            return result;
        }

        public string ToDecimalString()
        {
            return this.ToDecimal().ToString();
        }


    }
}
