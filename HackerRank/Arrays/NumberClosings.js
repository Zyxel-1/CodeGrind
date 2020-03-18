const countClosings = (q) => {
    let counter = 0;
    let arr = q.toString(10).split('').map(Number)
    arr.forEach(element => {
        if(element === 0 || element === 4 || element === 6 || element === 9){
            counter += 1
        }else if(element === 8){
            counter += 2
        }
    });
    return counter;
    
};

console.log(`Result: ${countClosings(649578)}`)