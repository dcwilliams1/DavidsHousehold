import { useEffect, useState } from "react";

const useBudget = () => {
  const [allBudgetLineItems, setAllBudgetLineItems] = useState();
  useEffect(() => {
    const fetchLineItems = async () => {
      const rawData = await fetch("./budgetLineItems.json");
      const lineItems = await rawData.json();
      setAllBudgetLineItems(lineItems);
    };
    fetchLineItems();
  }, []);

  return allBudgetLineItems;
};

export default useBudget;
