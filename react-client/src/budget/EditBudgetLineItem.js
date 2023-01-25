
import React, { useEffect, useState } from "react"; 
import FormErrors from "../commonComponents/FormErrors";

const EditBudgetLineItem = (props) => {
  console.log("budget line props", props);
  const [currentBudgetLineItem, setCurrentBudgetLineItem] = useState({
    id: props.budgetLineItem.id,
    date: props.budgetLineItem.date,
    amount: props.budgetLineItem.amount,
    category: props.budgetLineItem.category,
    description: props.budgetLineItem.description, 
    formErrors: {
        date: '', 
        amount: '',
        category: '',
        description: '',
        missing: ''
    },
    formIsValid: true
  }) ;

  const validateField = (fieldName, value) => {
    let fieldValidationErrors = currentBudgetLineItem.formErrors;
    let fieldIsValid = value.length > 0;
    if (!fieldIsValid) {
      fieldValidationErrors.missing = ' ' + fieldName
    } else {
      fieldValidationErrors.missing = '';
    }
    console.log('errors', fieldValidationErrors)
    switch(fieldName) {
        case 'amount':
            fieldIsValid = !isNaN(value);
            fieldValidationErrors.amount = fieldIsValid ? '' : ' is not a number'
            break;
        default:
            break;
    }
    setCurrentBudgetLineItem({...currentBudgetLineItem, formErrors: fieldValidationErrors})
    return fieldIsValid;
  }

  useEffect(() => {
    console.log("Current Budget Line Iteam ", currentBudgetLineItem);
    console.log("formErrors ", currentBudgetLineItem.formErrors);
    const validateForm = () =>{
      setCurrentBudgetLineItem({...currentBudgetLineItem, formIsValid: currentBudgetLineItem.formErrors.date.length  === 0 &&
      currentBudgetLineItem.formErrors.amount.length === 0 &&
      currentBudgetLineItem.formErrors.category.length === 0 &&
      currentBudgetLineItem.formErrors.description.length === 0 &&
      currentBudgetLineItem.formErrors.missing.length === 0})
    }
    validateForm();
  }, [currentBudgetLineItem.formErrors.amount, currentBudgetLineItem.formErrors.date, currentBudgetLineItem.formErrors.category, currentBudgetLineItem.formErrors.description, currentBudgetLineItem.formErrors.missing])

  // https://learnetto.com/blog/react-form-validation
  // https://stackoverflow.com/questions/41296668/reactjs-form-input-validation

  const changeHandler = (e) => {
      const name = e.target.name;
      const value = e.target.value;
      console.log('validating field ', e.target.name);
      setCurrentBudgetLineItem(
          {...currentBudgetLineItem, [name]:value},
          validateField(name, value)
      )
  }

  const submitHandler = (submitEvent) => {
    submitEvent.preventDefault();
    props.onHideEditing();
    console.log('Data Saved!', currentBudgetLineItem)
    clearForm();
  }

  const clearForm = () => {
    currentBudgetLineItem.id = '';
    currentBudgetLineItem.date = '';
    currentBudgetLineItem.amount = '';
    currentBudgetLineItem.category = '';
    currentBudgetLineItem.description = '';
    currentBudgetLineItem.formErrors = {};
  }

  return (
    <React.Fragment className="row">
      <form onSubmit={submitHandler}>
        <div className="row">
          <div className="col-md-2">
            <input
              type="text"
              className="formControl"
              placeholder="Date"
              id="transactionDate"
              value={currentBudgetLineItem.date}
              onChange={changeHandler}
              name="date"
            />
          </div>
          <div className="col-md-2">
            <input
              type="text"
              className="formControl"
              placeholder="Amount"
              id="transactionAmount"
              value={currentBudgetLineItem.amount}
              onChange={changeHandler}
              name="amount"
            />
          </div>
          <div className="col-md-3">
            <input
              type="text"
              className="formControl"
              placeholder="Category"
              id="transactionCategory"
              value={currentBudgetLineItem.category}
              onChange={changeHandler}
              name="category"
            />
          </div>
          <div className="col-md-4">
            <input
              type="text"
              className="formControl"
              placeholder="Description"
              id="transactionDescription"
              value={currentBudgetLineItem.description}
              onChange={changeHandler}
              name="description"
            />
          </div>
          <button
          className="btn btn-primary col-md-1"
          disabled={!currentBudgetLineItem.formIsValid}
          onClick={submitHandler}
          type="submit"
        >
          {props.editMode}
        </button>
        </div>
      </form>
      <FormErrors className="errorMessages" formErrors={currentBudgetLineItem.formErrors}></FormErrors>
    </React.Fragment>
  );
};

export default EditBudgetLineItem;
