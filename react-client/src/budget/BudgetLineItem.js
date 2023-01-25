const BudgetLineItem = (props) => {
    return (
        <div className="row tableRow" onClick={props.onShowEditing} id={props.budgetLineItemDetails.id}>
            <div className="col-2">{props.budgetLineItemDetails.date}</div>
            <div className="col-2">{props.budgetLineItemDetails.amount}</div>
            <div className="col-3">{props.budgetLineItemDetails.category}</div>
            <div className="col-5">{props.budgetLineItemDetails.description}</div>
        </div>
    )
}
//https://www.geeksforgeeks.org/how-to-create-an-editable-table-with-add-delete-and-search-filter-using-reactjs/
//onClick should pass props.onSaveBudgetLineItem along to the editing component
export default BudgetLineItem;