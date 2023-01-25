const SupplementPurchase = (props) => {
    return (
        <div className="row tableRow" onClick={props.onShowEditing} id={props.supplementPurchaseDetails.id}>
            <div className="col-sm-1  number-text">{props.supplementPurchaseDetails.date}</div>
            <div className="col-sm-2">{props.supplementPurchaseDetails.company}</div>
            <div className="col-sm-2">{props.supplementPurchaseDetails.product}</div>
            <div className="col-sm-1  number-text">{props.supplementPurchaseDetails.price}</div>
            <div className="col-sm-1  number-text">{props.supplementPurchaseDetails.quantity}</div>
            <div className="col-sm-2">{props.supplementPurchaseDetails.supplement}</div>
            <div className="col-sm-1  number-text">{props.supplementPurchaseDetails.strengthMg}</div>
            <div className="col-sm-1  number-text">{props.supplementPurchaseDetails.dose}</div>
        </div>
    )
}
//https://www.geeksforgeeks.org/how-to-create-an-editable-table-with-add-delete-and-search-filter-using-reactjs/
//onClick should pass props.onSaveBudgetLineItem along to the editing component
export default SupplementPurchase;