import { useHistory } from "react-router-dom";
import { useState } from "react";

const AccountFilter = ({props}) => {
    const history = useHistory();
    const accounts = props.accounts;
    const accountNames = {accounts} ? Array.from(new Set(accounts.map((acct) => acct.name)))
    :[];
    const [selectedAccount, setSelectedAccount] = useState(props.selectedAccount);
    const onAccountChanged = (e) => {
        setSelectedAccount(e.target.value);
        history.push(`/EditAccount/${e.target.value}`);
    }
    return (
        <div className="row mt-3">
            <div className="offset-md-2 col-md-4">
                Choose an account:
            </div>
            <div className="col-md-4 mb-3">
                <select className="form-select" onChange={onAccountChanged} value={selectedAccount}>
                    {accountNames.map((acct) =>(
                        <option key={acct} value={acct}>
                            {acct}
                        </option>
                    ))}
                </select>
            </div>
        </div>
    );
};

export default (AccountFilter);