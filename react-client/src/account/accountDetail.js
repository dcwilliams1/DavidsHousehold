import { useHistory } from "react-router-dom";

const AccountDetail = ({ account }) => {
  const accountName = account.name;
  const history = useHistory();
  const onAccountClicked = (e) => {
    history.push( `/EditAccount/${accountName}`);
  };
  return (
    <div className="row">
      <div className="netWorthAccountDetail col-3">
        <button onClick={onAccountClicked}>{account.name}</button>
      </div>
      <div className="netWorthAccountDetail col-3">{account.percentage}%</div>
      <div className="netWorthAccountDetail col-3">${account.balance}</div>
    </div>
  );
};

export default AccountDetail;
