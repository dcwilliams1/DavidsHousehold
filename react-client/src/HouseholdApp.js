import Header from "./Header";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import NetWorth from "./investments/NetWorth";
import EditAccount from "./account/EditAccount";
import EditBudgetLineItem from "./budget/EditBudgetLineItem";
import useInvestments from "./data/investments";
import investmentsContext from "./context/investmentsContext";
import useBudget from "./data/budgetLineItems";
import budgetContext from "./context/budgetContext";
import BudgetLedger from "./budget/BudgetLedger";
import Nav from "./navigation/Navigation";
import EditSupplementPurchase from "./supplements/EditSupplementPurchase";
import SupplementPurchaseList from "./supplements/SupplementPurchaseList";
import supplementContext from "./context/supplementContext";
import useSupplements from "./data/supplementPurchases";

function App() {
  const allInvestments = useInvestments();
  const allBudgetLineItems = useBudget();
  const allSupplementPurchases = useSupplements();
  if (allInvestments && allBudgetLineItems && allSupplementPurchases) {
    return (
      <Router>
        <investmentsContext.Provider value={allInvestments}>
          <budgetContext.Provider value={allBudgetLineItems}>
            <supplementContext.Provider value={allSupplementPurchases}>
              <Nav className="container col-3"></Nav>
              <div className="container col-9">
                <Header subtitle="Making money for later!" />
                <Switch>
                  <Route path="/BudgetLedger/">
                    <BudgetLedger></BudgetLedger>
                  </Route>
                  <Route path="/SupplementPurchases/">
                    <SupplementPurchaseList></SupplementPurchaseList>
                  </Route>
                  <Route path="/EditAccount/:accountName">
                    <EditAccount></EditAccount>
                  </Route>
                  <Route path="/EditAccount">
                    <EditAccount></EditAccount>
                  </Route>
                  <Route path="/EditBudgetLineItem/:id">
                    <EditBudgetLineItem></EditBudgetLineItem>
                  </Route>
                  <Route path="/EditBudgetLineItem">
                    <EditBudgetLineItem></EditBudgetLineItem>
                  </Route>
                  <Route path="/EditSupplementPurchase/:id">
                    <EditSupplementPurchase></EditSupplementPurchase>
                  </Route>
                  <Route path="/EditSupplementPurchase">
                    <EditSupplementPurchase></EditSupplementPurchase>
                  </Route>
                  <Route path="/">
                    <NetWorth></NetWorth>
                  </Route>
                </Switch>
              </div>
            </supplementContext.Provider>
          </budgetContext.Provider>
        </investmentsContext.Provider>
      </Router>
    );
  }
  return null;
}
export default App;
