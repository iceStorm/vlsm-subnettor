using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class BinaryNumber
    {
        public List<int> ListBits { get; set; }
        public int Length { get { return this.ListBits.Count; } }
        public bool IsToggleAll
        {
            get
            {
                int oneValueCounter = 0;

                foreach (int bitValue in this.ListBits)
                    if (bitValue == 1)
                        ++oneValueCounter;

                return oneValueCounter == this.Length ? true : false;
            }
        }


        public BinaryNumber(int bitsAmount)
        {
            this.ListBits = new List<int>();

            for (int i = 0; i < bitsAmount; ++i)
                this.ListBits.Add(0);
        }

        public BinaryNumber(Decimal decimalNumber)
        {
            Octet o = new Octet((int)decimalNumber);
            this.ListBits = o.ListBits;
        }


        //  Cộng nhị phân với 1
        public void Increase()
        {
            int remainder = 1;  //  Số dư


            for (int i = this.Length - 1; i >= 0; --i)
            {
                int currBitValue = this.ListBits[i];


                if (currBitValue == 1)
                {
                    if (remainder == 1)
                    {
                        this.ListBits[i] = 0;
                    }
                    else
                    {
                        this.ListBits[i] = 1;
                    }
                }
                else
                {
                    if (remainder == 1)
                    {
                        this.ListBits[i] = 1;
                        remainder = 0;
                    }
                    else
                    {
                        this.ListBits[i] = 0;
                    }
                }
                
            }

        }


        public int ToDecimal()
        {
            return Octet.ToDecimal(this.ListBits);
        }

    }
}
