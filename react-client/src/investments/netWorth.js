import AccountDetail from "../account/AccountDetail";
import React, { useContext } from "react";
import investmentsContext from "../context/investmentsContext";
import "./investments.css";

const NetWorth = () => {
  const investments = useContext(investmentsContext);
  if (investments) {
    const accounts = investments.accounts;
    return (
      <React.Fragment>
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
      </React.Fragment>
    );
  }
  return <div>Net worth is unavailable at this time</div>;
};

export default NetWorth;
