import AccountFilter from "./AccountFilter";
import AccountDetail from "./AccountDetail";
import { useParams } from "react-router-dom";
import { useState, useContext } from "react";
import investmentsContext from "../context/investmentsContext";

const EditAccount = () => {
  const investments = useContext(investmentsContext);
  const accounts = investments.accounts;
  const { accountName } = useParams();
  let currentAccount = accounts.find((acct) => acct.name === accountName);
  const [updateAccount, setUpdateAccount] = useState({
    name: "",
    balance: "",
  });
  let props = {
    accounts: accounts,
    selectedAccount: currentAccount.name,
    subtitle: "Edit Accounts",
  };

  const onSubmit = (e) => {
    e.preventDefault();
  };

  const onChange = (e) => {
    setUpdateAccount({ ...updateAccount, [e.target.id]: e.target.value });
  };

  return (
    <div>
      <AccountFilter props={props}></AccountFilter>
      <AccountDetail
        account={currentAccount}
        subtitle="Edit Accounts"
      ></AccountDetail>
      <form className="mt-2">
        <div className="formGroup row">
          <div className="col-md-6">
            <label htmlFor="accountName">New Account Name</label>
          </div>
          <div className="col-md-6">
            <input
              type="text"
              className="formControl"
              placeholder="accountName"
              id="name"
              value={currentAccount.name}
              onChange={onChange}
            />
          </div>
        </div>
        <div className="formGroup row">
          <div className="col-md-6">
            <label htmlFor="balance">New Balance</label>
          </div>
          <div className="col-md-6">
            <input
              type="text"
              className="formControl"
              placeholder="balance"
              id="balance"
              value={currentAccount.balance}
              onChange={onChange}
            />
          </div>
        </div>
        <button
          className="btn btn-primary mt-2"
          disabled={!currentAccount.balance}
          onClick={onSubmit}
        >
          Submit
        </button>
      </form>
    </div>
  );
};

export default EditAccount;
