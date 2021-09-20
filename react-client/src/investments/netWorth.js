import AccountDetail from "../account/accountDetail";
import { useContext } from "react";
import investmentsContext from "../context/investmentsContext";

const NetWorth = () => {
  const investments = useContext(investmentsContext);
  if (investments) {
    const accounts = investments.accounts;
    return (
      <div>
        <div className="row mt-2 netWorth">
          <div className="netWorthLabel">Net Worth: ${investments.amount}</div>
        </div>
        <div className="row mt-2">
          <div className="column-header col-3">Account Name</div>
          <div className="column-header col-3">Percentage</div>
          <div className="column-header col-3">Balance</div>
        </div>
        {accounts.map((acct) => (
          <AccountDetail account={acct} key={acct.name}></AccountDetail>
        ))}
      </div>
    );
  }
  return <div>Net worth is unavailable at this time</div>;
};

export default NetWorth;
