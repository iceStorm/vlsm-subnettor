using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class IPv4 : IP  //  Inherited from the "IP" class
    {
        public IPv4(Octet FirstOctet = null, Octet SecondOctet = null, Octet ThirdOctet = null, Octet FourthOctet = null, int suffix = 0)
            : base(FirstOctet, SecondOctet, ThirdOctet, FourthOctet, suffix)
        {
            this.SubnetMask = new SubnetMask(this.Suffix);
            this.DecimalStringValue = $"{this.ToDecimalString()}/{this.Suffix}";
            this.NetworkClass = GetNetWorkClass();
            this.NetAddress = GetNetAddress();
        }
        


        public IPv4(string text)
        {
            //  format: x.x.x.x/x       -   Ex: 192.168.0.1/24

            text = text.Replace('/', '.');
            string[] segments = text.TrimEnd().Split('.');


            this.FirstOctet.ListBits = Octet.DecimalToBinary(int.Parse(segments[0]));
            this.SecondOctet.ListBits = Octet.DecimalToBinary(int.Parse(segments[1]));
            this.ThirdOctet.ListBits = Octet.DecimalToBinary(int.Parse(segments[2]));
            this.FourthOctet.ListBits = Octet.DecimalToBinary(int.Parse(segments[3]));


            this.Suffix = int.Parse(segments.Last());
            this.SubnetMask = new SubnetMask(this.Suffix);
            this.DecimalStringValue = $"{this.ToDecimalString()}/{this.Suffix}";
            this.NetAddress = GetNetAddress();
            this.NetworkClass = GetNetWorkClass();
        }

        public IPv4(List<int> listBits, int suffix):base(suffix: suffix)    //  Chuyển listBits thành IPv4
        {
            for (int i = 0; i < listBits.Count; ++i)
            {
                int bitIndex = i % 8;       //  Vị trí của bit trong octet
                int octetIndex = i / 8;     //  Octet thứ mấy


                switch (octetIndex)
                {
                    case 0:  //  Bắt đầu tại Octet thứ 1
                        {
                            this.FirstOctet.ListBits[bitIndex] = listBits[i];
                            break;
                        }

                    case 1: //  Bắt đầu tại Octet thứ 2
                        {
                            this.SecondOctet.ListBits[bitIndex] = listBits[i];
                            break;
                        }

                    case 2: //  Bắt đầu tại Octet thứ 3
                        {
                            this.ThirdOctet.ListBits[bitIndex] = listBits[i];
                            break;
                        }

                    case 3: //  Bắt đầu tại Octet thứ 4
                        {
                            this.FourthOctet.ListBits[bitIndex] = listBits[i];
                            break;
                        }
                }
            }


            this.SubnetMask = new SubnetMask(this.Suffix);
            this.NetworkClass = GetNetWorkClass();
            this.NetAddress = GetNetAddress();
            this.DecimalStringValue = $"{this.ToDecimalString()}/{this.Suffix}";
        }



        //  Lấy địa chỉ đường mạng gốc của IP
        private IP GetNetAddress()
        {
            IP netAdd = new IP(suffix: this.Suffix);
            netAdd.SubnetMask = this.SubnetMask;


            //  Thực hiện "AND BIT" cho các Octet
            for (int i = 0; i < 8; ++i)
            {
                netAdd.FirstOctet.ListBits[i] = (this.FirstOctet.ListBits[i] & this.SubnetMask.FirstOctet.ListBits[i]);
                netAdd.SecondOctet.ListBits[i] = (this.SecondOctet.ListBits[i] & this.SubnetMask.SecondOctet.ListBits[i]);
                netAdd.ThirdOctet.ListBits[i] = (this.ThirdOctet.ListBits[i] & this.SubnetMask.ThirdOctet.ListBits[i]);
                netAdd.FourthOctet.ListBits[i] = (this.FourthOctet.ListBits[i] & this.SubnetMask.FourthOctet.ListBits[i]);
            }


            return netAdd;
        }
        

        public List<IPv4> GetIPRange(VLSM.VLSM_Units vlsm_units)
        {
            List<IPv4> listIPs = new List<IPv4>();
            List<int> listCurrBits = this.ToBinaryList();
            BinaryNumber borrowedBits = new BinaryNumber(bitsAmount: 32 - this.Suffix);
            int startHostIndex = this.Suffix;

            
            for (int i = 0; i < vlsm_units.Hop; ++i)
            {
                int assignedCounter = 0;
                for (int j = 0; j < 32; ++j)
                {
                    if (j >= startHostIndex)
                        listCurrBits[j] = borrowedBits.ListBits[assignedCounter++];


                    if (assignedCounter == borrowedBits.ListBits.Count)
                        break;
                }


                listIPs.Add(new IPv4(listCurrBits, this.Suffix));
                borrowedBits.Increase();


                
                //  Giới hạn khi có quá nhiều Subnets
                if (listIPs.Count == 2 && vlsm_units.Hop > 4)
                {
                    for (int j = 0; j < borrowedBits.Length - 1; ++j)
                        borrowedBits.ListBits[j] = 1;

                    borrowedBits.ListBits[borrowedBits.Length - 1] = 0;
                    i = vlsm_units.Hop - 3;
                }
            }


            return listIPs;
        }


    }
}
