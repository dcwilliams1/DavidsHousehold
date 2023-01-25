import { render, unmountComponentAtNode } from "react-dom";
import {act} from "react-dom/test-utils"
import EditBudgetLineItem from "./EditBudgetLineItem"
import "@testing-library/jest-dom";

let testContainer = null;

beforeEach(() => {
testContainer = document.createElement("div");
document.body.appendChild(testContainer);
});

afterEach(() => {
    unmountComponentAtNode(testContainer);
    testContainer.remove();
    testContainer = null;
})

it('validates the editing form', () => {
    let budgetLineItemProps = {
        id: 1,
        date: new Date().toDateString(),
        amount: undefined,
        category: 2,
        description: 'test'
        }
    act(() => {
        render(<EditBudgetLineItem budgetLineItem={budgetLineItemProps}/>, testContainer)
    })

    
})