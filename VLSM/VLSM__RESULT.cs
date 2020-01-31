using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public struct VLSM_Units
    {
        public int Hop;                         //  Bước nhảy giữa các subnet
        public int AfterHosts;                  //  Số host còn lại sau khi mượn bits
        public int BeforeHosts;                 //  Số host hiện tại (trước khi mượn bits)
        public int SubnetsAmount;               //  Số lượng các mạng con được sinh ra (2^số bit mượn)
        public int BorrowedBitsAmount;          //  Số lượng các bit mượn
    }


    public class VLSM__RESULT
    {
        public IP NetAddress { get; set; }
        public IPv4 BroadCastIP { get; set; }
        public IPv4 FirstIP { get; set; }
        public IPv4 LastIP { get; set; }   
        private List<IPv4> IPArea { get; set; }
        public VLSM.Branch Branch { get; set; }
        public SubnetMask SubnetMask { get; set; }

        public static string Guides = "";   //  Hướng dẫn bằng chữ từng bước
        private static int branchesAmount = 0;  //  Tổng số chi nhánh



        public VLSM__RESULT()
        {
            this.IPArea = new List<IPv4>();
        }
        
        

        public static List<VLSM__RESULT> GetQuickResult(List<VLSM.Branch> listBranches, VLSM.IPv4 rootIP)
        {
            branchesAmount = listBranches.Count;
            WriteInput(listBranches, rootIP);
            
            

            //  Sắp xếp danh sách các chi nhánh giảm dần theo số Hosts
            Branch.SortDescendantByHostsAmount(listBranches);


            //  List các mạng con được sinh ra
            List<IPv4> listSubnets = new List<VLSM.IPv4>();
            listSubnets.Add(rootIP);


            //  List kết quả
            List<VLSM__RESULT> listResult = new List<VLSM__RESULT>();
            


            //  Duyệt từng chi nhánh từ đầu đến cuối (host giảm dần)
            foreach (VLSM.Branch branch in listBranches)
            {
                Guides += $@"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}
————————————————————————————————————————————————————————————{Environment.NewLine}";
                Guides += $@">>>  {branch.Name} ({branch.HostsAmount}){Environment.NewLine}{Environment.NewLine}";


                //  Thêm một item kết quả
                VLSM__RESULT item = GetResult(listSubnets, branch);


                if (item == null)
                {
                    return null;
                }


                listResult.Add(item);
            }


            return listResult;
        }

        private static VLSM__RESULT GetResult(List<IPv4> listSubnets, Branch currBranch)
        {
            //  item kết quả
            VLSM__RESULT result = null;



            //  Lấy ra IP cuối cùng để xét (IP cuối cùng là đường mạng đầu tiên được chia)
            IPv4 currIP = listSubnets.Last();


            //  Lấy các đơn vị (số mạng con, bước nhảy, ...)
            VLSM_Units vlsm_units = GetVLSM_Units(currBranch, currIP);



            Guides += $@"       ——>  Net address:   {currIP.ToDecimalString()}/{currIP.Suffix}{Environment.NewLine}";
            Guides += $@"       ——>  2^h - 2 >= {currBranch.HostsAmount}  ——>  h = {vlsm_units.AfterHosts} (remainder bits of the host ID after borrowed){Environment.NewLine}";
            Guides += $@"       ——>  m = {vlsm_units.BorrowedBitsAmount} (the borrowed bits){Environment.NewLine}";
            if (vlsm_units.BorrowedBitsAmount > 0)
            {
                Guides += $@"       ——>  subnets amount:  2^m  =  2^{vlsm_units.BorrowedBitsAmount}  =  {vlsm_units.SubnetsAmount}{Environment.NewLine}";
                Guides += $@"       ——>  hop:  2^h  =  2^{vlsm_units.AfterHosts}  =  {vlsm_units.Hop}{Environment.NewLine}";
            }




            if (vlsm_units.BorrowedBitsAmount == 0)      //  Không mượn bit ==> chọn ngay đường mạng hiện tại
            {
                Guides += $@"{Environment.NewLine}       Because the borrowed bits (m) is equals to 0, so we'll directly pick up the current Net address without dividing !";
                WriteHostFormat(currIP, vlsm_units);


                //  Lấy item kết quả
                result = GetVLSM_Result_Item(currIP, currBranch, vlsm_units);
                WriteResultIPs(result);


                //  Xoá đi phần tử vừa chọn
                listSubnets.Remove(currIP);
            }
            else                                    //  Có mượn bit ==> phải chia tiếp
            {
                result = DivideNewSubnets(vlsm_units, listSubnets, currBranch);
            }



            return result;
        }

        private static VLSM__RESULT DivideNewSubnets(VLSM_Units vlsm_units, List<IPv4> listSubnets, Branch currBranch)
        {
            //  Lấy ra IP cuối cùng (đường mạng tiếp theo) để chia
            IPv4 currIP = listSubnets.Last();

            WriteNetAddressFormat(currIP, vlsm_units);
            Guides += Environment.NewLine;



            //  Các bit đã mượn để bật bit thành các đường mạng
            BinaryNumber borrowedBits = new BinaryNumber(bitsAmount: vlsm_units.BorrowedBitsAmount);


            //List các đường mạng con được sinh ra khi bật bit
            List<IPv4> listNewSubnets = new List<IPv4>();



            //  Xác định index của bit mượn đầu tiên trong IP (bắt đầu từ 1)
            int startBorrowingBitIndex = 32 - vlsm_units.BeforeHosts + 1;


            //  List các bit của IP hiện tại
            List<int> listCurrBits = currIP.ToBinaryList();


            //  Bật các bit mượn lên IP hiện tại để tính ra các đường mạng con
            for (int i = 0; i < vlsm_units.SubnetsAmount; ++i)
            {
                int assignedCounter = 0;
                for (int j = 0; j < 32; ++j)
                {
                    if (j + 1 >= startBorrowingBitIndex)
                        listCurrBits[j] = borrowedBits.ListBits[assignedCounter++];


                    if (assignedCounter == borrowedBits.ListBits.Count)
                        break;
                }



                //  Thêm mạng con mới vào list tạm thời
                listNewSubnets.Add(new IPv4(listCurrBits, currIP.Suffix + vlsm_units.BorrowedBitsAmount));
                Guides += $@"           M{listNewSubnets.Count}:    {listNewSubnets.Last().DecimalStringValue}";
                Guides += Environment.NewLine;


                //  Bật bit
                borrowedBits.Increase();



                //  Dừng lấy thêm đường mạng khi đã đủ
                if (listNewSubnets.Count == branchesAmount)
                {
                    if (branchesAmount < vlsm_units.SubnetsAmount)
                        Guides += $@"              ...{Environment.NewLine}";

                    break;
                }
            }


            if (listNewSubnets.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show($"An error just occured!  Don't enough HOST BITS to divide new subnets for {currBranch.Name}",
                    "Alert", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                return null;
            }
            else
            {
                //  Xoá phần tử đã được chia
                listSubnets.Remove(currIP);

                //  Đảo ngược thứ tự của các phần tử mới
                listNewSubnets.Reverse();

                //  Thêm các phần tử mới vào list
                listSubnets.AddRange(listNewSubnets);

                //  Chọn phần tử cuối cùng (tương đương với mạng con thứ nhất mới được chia)
                currIP = listSubnets.Last();

                //  Xoá phần tử được chọn
                listSubnets.Remove(currIP);
            }



            VLSM__RESULT result = listNewSubnets.Count == 0 ? null : GetVLSM_Result_Item(currIP, currBranch, vlsm_units);
            if (result != null)
            {
                Guides += $@"{Environment.NewLine}       Select M1 to apply:";
                WriteHostFormat(currIP, vlsm_units);
                WriteResultIPs(result);
            }



            //  Trả về item kết quả
            return result;
        }



        //  Tìm số mũ h phù hợp (2^h - 2 >= hosts)
        private static int FindTheExponent(int hosts)
        {
            int exponent = 0;

            for (int i = 0; i <= hosts; ++i)
                if (Math.Pow(2, i) - 2 >= hosts)
                {
                    exponent = i;
                    break;
                }


            return exponent;
        }

        private static VLSM__RESULT GetVLSM_Result_Item(IPv4 ip, Branch brch, VLSM_Units vlsm_units)
        {
            VLSM__RESULT item = new VLSM__RESULT();

            item.Branch = brch;
            item.IPArea = ip.GetIPRange(vlsm_units);
            item.NetAddress = item.IPArea.First();
            item.BroadCastIP = item.IPArea.Last();
            item.FirstIP = item.IPArea[1];
            item.LastIP = item.IPArea[2];
            item.SubnetMask = ip.SubnetMask;


            return item;
        }

        private static VLSM_Units GetVLSM_Units(Branch brch, IPv4 ip)
        {
            //  bit hiện tại của phần host
            int beforeHosts = 32 - ip.Suffix;

            //  Tính số bit host còn lại sau khi mượn
            int afterHosts = FindTheExponent(brch.HostsAmount);

            //  bước nhảy
            int hop = (int)Math.Pow(2, afterHosts);

            //  số bit đã mượn
            int borrowedBitsAmount = beforeHosts - afterHosts;

            //  số lượng subnets (số mạng con)
            int subnetsAmount = (int)Math.Pow(2, borrowedBitsAmount);

            


            return new VLSM_Units
            {
                BorrowedBitsAmount = borrowedBitsAmount,
                SubnetsAmount = subnetsAmount,
                BeforeHosts = beforeHosts,
                AfterHosts = afterHosts,
                Hop = hop
            };
        }
        


        private static void WriteHostFormat(VLSM.IPv4 ip, VLSM_Units vlsm_units)
        {
            Guides += $"{Environment.NewLine}";
            Guides += $@"       Host format:     ";


            List<int> listBits = ip.ToBinaryList();
            int hostOctetIndex = (32 - vlsm_units.AfterHosts) / 8;


            for (int i = 0; i < 32; ++i)
            {
                if (i / 8 >= hostOctetIndex)
                {
                    if (i >= 32 - vlsm_units.AfterHosts)
                        Guides += 'x';
                    else
                        Guides += listBits[i];
                }
                else
                {
                    if (((i + 1) % 8) == 0)
                        Guides += Octet.ToDecimal(listBits.GetRange(i - 7, 8));
                }


                if (((i + 1) % 8) == 0)
                {
                    if (i != 31)
                        Guides += ".";
                }
            }


            Guides += $"/{ip.Suffix}";
        }

        private static void WriteNetAddressFormat(VLSM.IPv4 ip, VLSM_Units vlsm_units)
        {
            Guides += $"{Environment.NewLine}";
            Guides += $@"       Subnet format:     ";


            List<int> listBits = ip.ToBinaryList();
            

            int startOctet = (32 - vlsm_units.BeforeHosts) / 8;
            int endOctet = (32 - vlsm_units.AfterHosts - 1) / 8;

            int startIndex = (32 - vlsm_units.BeforeHosts);
            int endIndex = (32 - vlsm_units.AfterHosts - 1);



            for (int i = 0; i < listBits.Count; ++i)
            {
                int currentOctetIndex = i / 8;


                if (currentOctetIndex >= startOctet && currentOctetIndex <= endOctet)
                {
                    if (i >= startIndex && i <= endIndex)
                        Guides += 'x';
                    else
                        Guides += $"{listBits[i]}";
                }
                else
                {
                    if ((i + 1) % 8 == 0)
                    {
                        Guides += $"{Octet.ToDecimal(listBits.GetRange(i - 7, 8))}";
                    }
                }


                if ((i + 1) % 8 == 0)
                {
                    if (i != 31)
                        Guides += '.';
                }
            }

            Guides += $"/{ip.Suffix + vlsm_units.BorrowedBitsAmount}";
        }

        private static void WriteResultIPs(VLSM__RESULT item)
        {
            Guides += $"{Environment.NewLine}";
            Guides += $@"             ——> Net address     : {item.NetAddress.DecimalStringValue}{Environment.NewLine}";
            Guides += $@"             ——> First IP              : {item.FirstIP.DecimalStringValue}{Environment.NewLine}";
            Guides += $@"             ——> Last IP              : {item.LastIP.DecimalStringValue}{Environment.NewLine}";
            Guides += $@"             ——> BroadCast IP    : {item.BroadCastIP.DecimalStringValue}{Environment.NewLine}";
        }

        private static void WriteInput(List<VLSM.Branch> listBranches, VLSM.IPv4 rootIP)
        {
            Guides = "";


            Guides += $"Root IP: {rootIP.ToDecimalString()}/{rootIP.Suffix}{Environment.NewLine}";
            Guides += $"Branch";
            Guides += branchesAmount <= 1 ? $": {Environment.NewLine}" :$"es (sorted descendant by hosts amount): {Environment.NewLine}";


            foreach (Branch brch in listBranches)
            {
                Guides += $"{brch.Name}:{brch.HostsAmount}{Environment.NewLine}";
            }


            Guides += Environment.NewLine;
            Guides += Environment.NewLine;


            Guides += $"Using the \"AND BIT\" operator foreach bit couple of the subnet mask & root IP:{Environment.NewLine}";
            Guides += $"Subnet mask: {rootIP.SubnetMask.ToBinaryString()}{Environment.NewLine}";
            Guides += $@"          Root IP: {rootIP.ToBinaryString()}{Environment.NewLine}";
            Guides += $@"  Net address: {rootIP.NetAddress.ToBinaryString()} ({rootIP.NetAddress.ToDecimalString()}/{rootIP.Suffix}){Environment.NewLine}";
        }

    }
}
