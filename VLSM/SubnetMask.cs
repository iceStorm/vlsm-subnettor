using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class SubnetMask : IP  //  Inherited from the "IP" class
    {
        public SubnetMask(int suffix):base()
        {
            //  Bật các bit lên 1 cho các Octet, dựa trên Suffix (số bit phần Net)


            for (int i = 0; i < FirstOctet.ListBits.Count && suffix > 0; ++i, --suffix)
                FirstOctet.ListBits[i] = 1;

            for (int i = 0; i < SecondOctet.ListBits.Count && suffix > 0; ++i, --suffix)
                SecondOctet.ListBits[i] = 1;

            for (int i = 0; i < ThirdOctet.ListBits.Count && suffix > 0; ++i, --suffix)
                ThirdOctet.ListBits[i] = 1;

            for (int i = 0; i < FourthOctet.ListBits.Count && suffix > 0; ++i, --suffix)
                FourthOctet.ListBits[i] = 1;


            this.NetworkClass = GetNetWorkClass();
            this.DecimalStringValue = this.ToDecimalString();
        }

    }
}

