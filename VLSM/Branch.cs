using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM
{
    public class Branch
    {
        public string Name { get; set; }
        public int HostsAmount { get; set; }


        public Branch(string branchName, int hostsAmount)
        {
            this.Name = branchName;
            this.HostsAmount = hostsAmount;
        }

        

        //  Sắp xếp danh sách chi nhánh theo số lượng Host giảm dần
        public static void SortDescendantByHostsAmount(List<VLSM.Branch> listBranches)
        {
            for (int i = 0; i < listBranches.Count; ++i)
                for (int j = listBranches.Count - 1; j > i; --j)
                    if (listBranches[j].HostsAmount > listBranches[j - 1].HostsAmount)
                    {
                        Branch temp = listBranches[j];
                        listBranches[j] = listBranches[j - 1];
                        listBranches[j - 1] = temp;
                    }
        }


    }
}
