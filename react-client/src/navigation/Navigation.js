import React from "react"

const Menu = () => {
    return (
        <div>
            <h3>Menu</h3>
            <p><a href="/">Home</a></p>
            <p><a href="/BudgetLedger">Expenses</a></p>
            <p><a href="/SupplementPurchases">Supplements</a></p>
        </div>
    )
}
const Nav = () => {
return (
    <React.Fragment>
        <Menu className="col-3"/>
    </React.Fragment>
)
}

export default Nav;