using System;

namespace TaxpayerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] payers = new Taxpayer[10];
            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new Taxpayer();
                Console.WriteLine("Enter payer #{0} Social Security Number", i + 1);
                payers[i].SocSecurNumb = Console.ReadLine();
                Console.WriteLine("Enter payer #{0} yearly income", i+1);
                payers[i].Income = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine("Tax Payer {0}, SSN {1}, income {2}, tax owed " +
                    "{3} ", i + 1, payers[i].SocSecurNumb, payers[i].Income, payers[i].TaxOwed);
                Console.ReadKey();
            }
        }
    }
}
