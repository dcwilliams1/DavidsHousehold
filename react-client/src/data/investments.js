import {useEffect, useState} from "react";

const useInvestments = () => {
    const [allInvestments, setAllInvestments] = useState();
        useEffect(() => {
            const fetchInvestments = async () => {
                const rawData = await fetch("./investments.json");
                const investments = await rawData.json();
                setAllInvestments(investments);
            };
            fetchInvestments();
        }, []);
    
    return allInvestments;
}

export default useInvestments;