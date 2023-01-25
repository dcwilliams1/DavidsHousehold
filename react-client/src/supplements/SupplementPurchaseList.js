import React, { useContext, useState } from "react";
import supplementContext from "../context/supplementContext";
import SupplementPurchase from "./SupplementPurchase";
import EditSupplementPurchase from "./EditSupplementPurchase";

const SupplementPurchaseList = () => {
  const supplementPurchases = useContext(supplementContext);
  console.log('supplement purchases in list', supplementPurchases);
  const [editingPurchase, setEditingPurchase] = useState(0);
  const saveSupplementPurchase = (savedSupplementPurchase) => {
    const supplementPurchase = {
      ...savedSupplementPurchase,
    };
    console.log("Saved!!", supplementPurchase);
  };

  const showEditingForm = (purchaseEvent) => {
    setEditingPurchase(purchaseEvent.target.parentElement.id);
  };

  const hideEditingForm = () => {
    setEditingPurchase(0)
  }

  const newSupplementPurchase = {
    id:'',
    date:'',
    company:'',
    product:'',
    price:'',
    quantity:'',
    supplement:'',
    strengthMg:'',
    dose:'',
    formErrors:{}
  }

  return (
    <React.Fragment>
      <div className="center-subheading"><h3>Supplements</h3></div>
      <div className="row mt-2">
        <div className="column-header col-sm-1">Date</div>
        <div className="column-header col-sm-2">Company</div>
        <div className="column-header col-sm-2">Product</div>
        <div className="column-header col-sm-1">Price</div>
        <div className="column-header col-sm-1">Quantity</div>
        <div className="column-header col-sm-2">Supplement</div>
        <div className="column-header col-sm-1">Strength (mg)</div>
        <div className="column-header col-sm-1">Dose</div>
      </div>
      <div onMouseLeave={hideEditingForm}>
      {supplementPurchases.map((purchase) =>
        purchase.id == editingPurchase ? (
          <EditSupplementPurchase
            supplementPurchase={purchase}
            key={purchase.id}
            onHideEditing={hideEditingForm}
            editMode="Update"
            ></EditSupplementPurchase>
        ) : (
          <SupplementPurchase
            isEditing={purchase.id === editingPurchase}
            supplementPurchaseDetails={purchase}
            key={purchase.id}
            onSaveSupplementPurchase={saveSupplementPurchase}
            onShowEditing={showEditingForm}
          ></SupplementPurchase>
        )
      )}
      {
        editingPurchase === 0 ? (
        <EditSupplementPurchase 
          supplementPurchase={newSupplementPurchase}
          key="new"
          onHideEditing={hideEditingForm} 
          editMode="Add"
        ></EditSupplementPurchase>) : (<p></p>)
      }
      </div>
    </React.Fragment>
  );
};

export default SupplementPurchaseList;
