using Dz_Tumakov.Enums;

namespace Dz_Tumakov.Structures
{
    public struct BankAccount
    {
        public long Id;
        public BankAccountType Type;
        public decimal Balance;
    }

    public struct Worker
    {
        public string Name;
        public University University;
    }
}
