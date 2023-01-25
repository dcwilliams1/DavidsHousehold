
import React, { useEffect, useState } from "react"; 
import FormErrors from "../commonComponents/FormErrors";
import  "./Supplements.css"

const EditSupplementPurchase = (props) => {
  console.log("supplement props for EditSupplementPurchase", props);
  const [currentSupplementPurchase, setCurrentSupplementPurchase] = useState({
    id: props.supplementPurchase.id,
    date: props.supplementPurchase.date,
    company: props.supplementPurchase.company,
    product: props.supplementPurchase.product,
    price: props.supplementPurchase.price, 
    quantity: props.supplementPurchase.quantity,
    supplement: props.supplementPurchase.supplement, 
    strengthMg: props.supplementPurchase.strengthMg, 
    dose: props.supplementPurchase.dose, 
    formErrors: {
        date: '', 
        company: '',
        product: '',
        price: '',
        quantity: '',
        supplement: '',
        strengthMg: '',
        dose: ''
    },
    formIsValid: true
  }) ;

  const validateField = (fieldName, value) => {
    console.log('validating ', fieldName);
    let fieldValidationErrors = currentSupplementPurchase.formErrors;
    let fieldIsValid = value.length > 0;
    if (!fieldIsValid) {
      fieldValidationErrors.missing = ' ' + fieldName
    } else {
      fieldValidationErrors.missing = '';
    }
    console.log('errors', fieldValidationErrors)
    switch(fieldName) {
        case 'price':
            fieldIsValid = !isNaN(value);
            fieldValidationErrors.amount = fieldIsValid ? '' : ' is not a number'
            break;
        case 'quantity':
          fieldIsValid = !isNaN(value);
          fieldValidationErrors.amount = fieldIsValid ? '' : ' is not a number'
          break;
        case 'strengthMg':
          fieldIsValid = !isNaN(value);
          fieldValidationErrors.amount = fieldIsValid ? '' : ' is not a number'
          break;
        case 'dose':
          fieldIsValid = !isNaN(value);
          fieldValidationErrors.amount = fieldIsValid ? '' : ' is not a number'
          break;
        default:
            break;
    }
    setCurrentSupplementPurchase({...currentSupplementPurchase, formErrors: fieldValidationErrors})
    return fieldIsValid;
  }

  useEffect(() => {
    console.log("Current supplement purchase ", currentSupplementPurchase);
    console.log("formErrors ", currentSupplementPurchase.formErrors);
    const validateForm = () =>{
      // setCurrentSupplementPurchase({...currentSupplementPurchase, formIsValid: currentSupplementPurchase.formErrors.date.length  == 0 &&
      // currentSupplementPurchase.formErrors.company.length === 0 &&
      // currentSupplementPurchase.formErrors.product.length === 0 &&
      // currentSupplementPurchase.formErrors.price.length === 0 &&
      // currentSupplementPurchase.formErrors.quantity.length === 0 &&
      // currentSupplementPurchase.formErrors.supplement.length === 0 &&
      // currentSupplementPurchase.formErrors.strengthMg.length === 0 &&
      // currentSupplementPurchase.formErrors.dose.length === 0 &&
      // currentSupplementPurchase.formErrors.missing.length === 0})
      setCurrentSupplementPurchase({...currentSupplementPurchase, formIsValid: true})
    }
    validateForm();
  }, [currentSupplementPurchase.formErrors.company, currentSupplementPurchase.formErrors.date, currentSupplementPurchase.formErrors.product, currentSupplementPurchase.formErrors.price, currentSupplementPurchase.formErrors.quantity, currentSupplementPurchase.formErrors.supplement, currentSupplementPurchase.formErrors.strengthMg, currentSupplementPurchase.formErrors.dose, currentSupplementPurchase.formErrors.missing])

  // https://learnetto.com/blog/react-form-validation
  // https://stackoverflow.com/questions/41296668/reactjs-form-input-validation

  const changeHandler = (e) => {
      const name = e.target.name;
      const value = e.target.value;
      console.log('validating field ', e.target.name);
      setCurrentSupplementPurchase(
          {...currentSupplementPurchase, [name]:value},
          validateField(name, value)
      )
  }

  const submitHandler = (submitEvent) => {
    submitEvent.preventDefault();
    props.onHideEditing();
    console.log('Data Saved!', currentSupplementPurchase)
    clearForm();
  }

  const clearForm = () => {
    currentSupplementPurchase.id = '';
    currentSupplementPurchase.date = '';
    currentSupplementPurchase.company = '';
    currentSupplementPurchase.product = '';
    currentSupplementPurchase.price = '';
    currentSupplementPurchase.quantity = '';
    currentSupplementPurchase.supplement = '';
    currentSupplementPurchase.strengthMg = '';
    currentSupplementPurchase.dose = '';
    currentSupplementPurchase.formErrors = {};
  }

  return (
    <React.Fragment className="row">
      <form onSubmit={submitHandler}>
        <div className="row">
          <div className="col-sm-1">
            <input
              type="text"
              className="formControl number-text"
              placeholder="Date"
              id="purchaseDate"
              value={currentSupplementPurchase.date}
              onChange={changeHandler}
              name="date"
            />
          </div>
          <div className="col-sm-2">
            <input
              type="text"
              className="formControl"
              placeholder="Company"
              id="company"
              value={currentSupplementPurchase.company}
              onChange={changeHandler}
              name="company"
            />
          </div>
          <div className="col-sm-2">
            <input
              type="text"
              className="formControl"
              placeholder="Product"
              id="product"
              value={currentSupplementPurchase.product}
              onChange={changeHandler}
              name="product"
            />
          </div>
          <div className="col-sm-1">
            <input
              type="text"
              className="formControl number-text"
              placeholder="Price"
              id="price"
              value={currentSupplementPurchase.price}
              onChange={changeHandler}
              name="price"
            />
          </div>
          <div className="col-sm-1">
            <input
              type="text"
              className="formControl number-text"
              placeholder="Quantity"
              id="quantity"
              value={currentSupplementPurchase.quantity}
              onChange={changeHandler}
              name="quantity"
            />
          </div>
          <div className="col-sm-2">
            <input
              type="text"
              className="formControl"
              placeholder="Supplement"
              id="supplement"
              value={currentSupplementPurchase.supplement}
              onChange={changeHandler}
              name="supplement"
            />
          </div>
          <div className="col-sm-1">
            <input
              type="text"
              className="formControl number-text"
              placeholder="Strength"
              id="strengthMg"
              value={currentSupplementPurchase.strengthMg}
              onChange={changeHandler}
              name="strengthMg"
            />
          </div>
          <div className="col-sm-1">
            <input
              type="text"
              className="formControl number-text"
              placeholder="Daily Dose"
              id="dose"
              value={currentSupplementPurchase.dose}
              onChange={changeHandler}
              name="dose"
            />
          </div>
          <button
          className="btn btn-primary col-md-1"
          disabled={!currentSupplementPurchase.formIsValid}
          onClick={submitHandler}
          type="submit"
        >
          {props.editMode}
        </button>
        </div>
      </form>
      <FormErrors className="errorMessages" formErrors={currentSupplementPurchase.formErrors}></FormErrors>
    </React.Fragment>
  );
};

export default EditSupplementPurchase;
