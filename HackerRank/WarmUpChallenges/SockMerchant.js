function sockMerchant(n, ar) {
    let counter = 0;
    let pairs = [];
    // Go left to right scanning each element
    console.log(drawer)
    for(let i = 0; i < drawer.length; i++){
        pairs.push({color: drawer[i], index: i});
        if(pairs.length === 2){
          if(pairs[0].color === pairs[1].color){
              counter++;
              drawer.splice(pairs[0].index,1)
              drawer.splice(pairs[1].index-1,1)
              pairs = [];
              i = -1
          } else {
            pairs.splice(1)
          }
        }
        if(i === drawer.length-1){
          drawer.splice(0,1)
          pairs = []
          i = -1
        }
    }
    return counter;
}
console.log(`Counter = ${sockMerchant(10,[1,1,3,1,2,1,3,3,3])}`)
