const rotLeft = (a,d) => {
    let temp = 0;
    for(let i = 0; i < d; i++){
        temp = a.shift();
        a.push(temp);
    }
    return a;
}

console.log(`Result: ${rotLeft([1,2,3,4,5],4)}`)