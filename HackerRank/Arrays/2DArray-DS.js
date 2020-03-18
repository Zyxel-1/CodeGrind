const hourglassSum = (arr) => {
    let sum = [];
    for(let i = 1; i < 5; i++){
        for(let j = 1; j < 5; j++){
            let topSum = arr[i-1][j-1]+ arr[i-1][j]+ arr[i-1][j+1];
            let bottomSum = arr[i+1][j-1] + arr[i+1][j]+ arr[i+1][j+1];
            let middle = arr[i][j]
            sum.push(topSum+middle+bottomSum)
        }
    }
    return sum.reduce((acc,current)=> acc < current ? current: acc);
};
let x = 1;
let matrix = [
    [1,1,1,0,0,0],
    [0,1,0,0,0,0],
    [1,1,1,0,0,0],
    [0,0,2,4,4,0],
    [0,0,0,2,0,0],
    [0,0,1,2,4,0]
]
console.log(`Result: ${hourglassSum(matrix)}`)