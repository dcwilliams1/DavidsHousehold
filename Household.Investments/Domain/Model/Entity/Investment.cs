using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Household.SharedKernel.Domain.Model.ValueObject;
using Household.SharedKernel.Domain.Model.Entity;

namespace Household.Investments.Domain.Model.Entity
{
    public class Investment : EntityBase
    {
        public int AccountId { 
            get
            {
                if (this.investmentAccount != null)
                {
                    return this.investmentAccount.AccountId;
                }
                else
                {
                    throw new Exception("Error: no account set for this investment");
                }
            }
        }

        //public string AccountName
        //{
        //    get
        //    {
        //        if (this.investmentAccount != null)
        //        {
        //            return this.investmentAccount.;
        //        }
        //        else
        //        {
        //            throw new Exception("Error: no account set for this investment");
        //        }
        //    }

        //    private set;
        //}

        public int FundId
        {
            get
            {
                if (this.investmentFund != null)
                {
                    return this.investmentFund.FundId;
                }
                else
                {
                    throw new Exception("Error: no fund set for this investment");
                }
            }
        }

        public decimal Principle { get; protected set; }
        public decimal Balance { get; }
        public string AccountName { get; private set; }
        public string FundName { get; private set; }
        

        private readonly Account investmentAccount;
        private readonly Fund investmentFund;

        public Investment(int accountId, int fundId)
        {
            this.investmentAccount = new Account(accountId);
            this.investmentFund = new Fund(fundId);
            this.Balance = 0.00M;
        }

        public void UdatePrinciple(decimal amount)
        {
            this.Principle += amount;
        }
    }
}
