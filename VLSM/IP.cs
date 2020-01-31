using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class IP
    {
        public Octet FirstOctet { get; set; }
        public Octet SecondOctet { get; set; }
        public Octet ThirdOctet { get; set; }
        public Octet FourthOctet { get; set; }

        public char NetworkClass { get; set; }
        public SubnetMask SubnetMask { get; set; }
        public IP NetAddress { get; set; }
        public int Suffix { get; set; }
        public string DecimalStringValue { get; set; }



        public IP(Octet FirstOctet = null, Octet SecondOctet = null, Octet ThirdOctet = null, Octet FourthOctet = null, int suffix = 0)
        {
            this.FirstOctet     =   (FirstOctet == null ? new Octet() : FirstOctet);
            this.SecondOctet    =   (SecondOctet == null ? new Octet() : SecondOctet);
            this.ThirdOctet     =   (ThirdOctet == null ? new Octet() : ThirdOctet);
            this.FourthOctet    =   (FourthOctet == null ? new Octet() : FourthOctet);

            this.Suffix = suffix;


            if (FirstOctet != null)
                this.NetworkClass = GetNetWorkClass();
        }


        protected char GetNetWorkClass()
        {
            char result = '?';


            //  Lấy trị thập phân của Octet đầu tiên để xét lớp mạng
            int firstOctetValue = this.FirstOctet.ToDecimal();



            if (firstOctetValue >= 1 && firstOctetValue <= 126)
            {
                result = 'A';
            }
            else
            {
                if (firstOctetValue >= 128 && firstOctetValue <= 191)
                {
                    result = 'B';
                }
                else
                {
                    if (firstOctetValue >= 192 && firstOctetValue <= 223)
                    {
                        result = 'C';
                    }
                }
            }

            return result;
        }

        

        public string ToDecimalString()
        {
            return $"{FirstOctet.ToDecimal()}.{SecondOctet.ToDecimal()}.{ThirdOctet.ToDecimal()}.{FourthOctet.ToDecimal()}";
        }

        public List<int> ToBinaryList()
        {
            List<int> listBits = new List<int>();


            for (int i = 0; i < FirstOctet.ListBits.Count; ++i)
                listBits.Add(FirstOctet.ListBits[i]);

            for (int i = 0; i < SecondOctet.ListBits.Count; ++i)
                listBits.Add(SecondOctet.ListBits[i]);

            for (int i = 0; i < ThirdOctet.ListBits.Count; ++i)
                listBits.Add(ThirdOctet.ListBits[i]);

            for (int i = 0; i < FourthOctet.ListBits.Count; ++i)
                listBits.Add(FourthOctet.ListBits[i]);


            return listBits;

        }

        public string ToBinaryString()
        {
            return $"{FirstOctet.ToBinaryString()}.{SecondOctet.ToBinaryString()}.{ThirdOctet.ToBinaryString()}.{FourthOctet.ToBinaryString()}";
        }
        


    }
}
