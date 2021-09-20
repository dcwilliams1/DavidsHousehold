import "./investments.css";
import Header from "./header";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import NetWorth from "./netWorth";
import EditAccount from "../DataEntry/EditAccount/EditAccount";
import useInvestments from "../data/investments";
import investmentsContext from "../context/investmentsContext";

function App() {
  const allInvestments = useInvestments();
  let investments = {};

  if (allInvestments) {
    investments = allInvestments;

    return (
      <Router>
        <investmentsContext.Provider value={allInvestments}>
          <div className="container">
            <Header subtitle="Making money for later!" />
            <Switch>
              <Route path="/EditAccount/:accountName">
                <EditAccount></EditAccount>
              </Route>
              <Route path="/EditAccount">
                <EditAccount></EditAccount>
              </Route>
              <Route path="/">
                <NetWorth></NetWorth>
              </Route>
            </Switch>
          </div>
        </investmentsContext.Provider>
      </Router>
    );
  }
  return null;
}

export default App;
