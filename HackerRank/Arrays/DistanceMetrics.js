function getDistanceMetrics (arr){
    let result = [];
    let counter = 0;
    const unique = (value,index,self) => {
        return self.indexOf(value) === index
    }
    
    let temp = arr.filter(unique);
    console.log(temp)
    if(arr.length === temp.length){
        return [0];
    }
    arr.map()
    for(let i = 0; i < arr.length;i++){
        for(let j =0; j< arr.length;j++){
            if(arr[i] == arr[j]){
                counter += Math.abs(i - j)
            }
        }
        result.push(counter);
        counter = 0
    }
    return result;
}
console.log(getDistanceMetrics([99,99,99,200,200,200]))