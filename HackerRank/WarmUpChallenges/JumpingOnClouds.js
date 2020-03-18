const jumpingOnClouds = (c) => {
    let numberOfJumps = 0;
    for(let i = 0; i< c.length-1;){
        if (i < c.length && c[i+2] !== 1) {
            numberOfJumps++;
            i += 2;
        } else if(c[i+1] !== 1){
            numberOfJumps++;
            i++;
        }
    }
    return numberOfJumps;
}
console.log(`Result: ${jumpingOnClouds([0,0,0,0,1,0])}`);``