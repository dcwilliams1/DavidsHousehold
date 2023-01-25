import { useEffect, useState } from "react";

const useSupplements = () => {
  const [allSupplementPurchases, setAllSupplementPurchases] = useState();
  useEffect(() => {
    const fetchPurchases = async () => {
      const rawData = await fetch("./supplementPurchases.json");
      const purchases = await rawData.json();
      setAllSupplementPurchases(purchases);
    };
    fetchPurchases();
  }, []);

  return allSupplementPurchases;
};

export default useSupplements;
