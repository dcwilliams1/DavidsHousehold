import React, { useContext, useState } from "react";
import budgetContext from "../context/budgetContext";
import BudgetLineItem from "./BudgetLineItem";
import EditBudgetLineItem from "./EditBudgetLineItem";

const BudgetLedger = () => {
  const budgetLineItems = useContext(budgetContext);
  const [editingLine, setEditingLine] = useState(0);
  const saveBudgetLineItem = (savedBudgetLineItem) => {
    const budgetLineItem = {
      ...savedBudgetLineItem,
    };
    console.log("Saved!!", budgetLineItem);
  };

  const showEditingForm = (lineItemEvent) => {
    setEditingLine(lineItemEvent.target.parentElement.id);
  };

  const hideEditingForm = () => {
    setEditingLine(0)
  }

  const newBudgetLineItem = {
    id:'',
    date:'',
    amount:'',
    category:'',
    description:'',
    formErrors:{}
  }

  return (
    <React.Fragment>
      <div className="center-subheading"><h3>Expenses</h3></div>
      <div className="row mt-2">
        <div className="column-header col-2">Date</div>
        <div className="column-header col-2">Amount</div>
        <div className="column-header col-3">Category</div>
        <div className="column-header col-5">Description</div>
      </div>
      <div onMouseLeave={hideEditingForm}>
      {budgetLineItems.map((item) =>
        item.id == editingLine ? (
          <EditBudgetLineItem
            budgetLineItem={item}
            key={item.id}
            onHideEditing={hideEditingForm}
            editMode="Update"
            ></EditBudgetLineItem>
        ) : (
          <BudgetLineItem
            isEditing={item.id == editingLine}
            budgetLineItemDetails={item}
            key={item.id}
            onSaveBudgetLineItem={saveBudgetLineItem}
            onShowEditing={showEditingForm}
          ></BudgetLineItem>
        )
      )}
      {
        editingLine == 0 ? (
        <EditBudgetLineItem 
          budgetLineItem={newBudgetLineItem}
          key="new"
          onHideEditing={hideEditingForm} 
          editMode="Add"
        ></EditBudgetLineItem>) : (<p></p>)
      }
      </div>
    </React.Fragment>
  );
};

export default BudgetLedger;
