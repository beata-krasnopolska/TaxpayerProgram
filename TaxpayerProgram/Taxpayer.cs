namespace TaxpayerProgram
{
    class Taxpayer
    {
        private string socSecurNumb;
        private double income;
        private double taxOwed;
        
        public string SocSecurNumb
        {
            get
            {
                return socSecurNumb;
            }
            set
            {
                socSecurNumb = value;
            }
        }
        public double Income
        {
            get
            {
                return income;
            }
            set
            {
                income = value;
                TaxCalc();
            }
        }
        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }
        private void TaxCalc()
        {
            if (income < 30000)
            {
                taxOwed = income * .15;
            }
            else
            {
                taxOwed = income * .28;
            }
        }
    }
}