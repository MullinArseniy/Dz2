using Dz_Tumakov.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumakov.Structures
{
    public struct BankAccount
    {
        public int id;
        public BankAccountType type;
        public decimal balance;
    }

    public struct worker
    {
        public string name;
        public University university;
    }
}
