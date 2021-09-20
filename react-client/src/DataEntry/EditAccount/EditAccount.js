import AccountFilter from "../../account/accountFilter";
import AccountDetail from "../../account/accountDetail"
import { useParams } from "react-router-dom";
import { useState, useContext } from "react";
import investmentsContext from "../../context/investmentsContext";

const EditAccount = () => {
    const investments = useContext(investmentsContext);
    const accounts = investments.accounts;
    const {accountName} = useParams();
    let currentAccount = accounts.find((acct) => acct.name == accountName );
    const [updateAccount, setUpdateAcount] = useState({
        name: "", 
        balance: ""
    })
    let props = {
        accounts : accounts,
        selectedAccount : currentAccount.name
    }

    const onSubmit = (e) => {
        e.preventDefault();
        console.log("Update Account", updateAccount);
    }

    const onChange = (e) => {
        console.log("changing", e.target.id);
        setUpdateAcount({...updateAccount, [e.target.id]: e.target.value});
    }

    return (
        <div>
            <AccountFilter props={props}></AccountFilter>
            <AccountDetail account={currentAccount}></AccountDetail>
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
    )
};

export default (EditAccount);