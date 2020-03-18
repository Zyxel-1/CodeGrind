function repeatedStrings(s,n){

  if(s === []){
    return 0;
  }
  if (s.length === 1 && s[0]==='a'){
    return n;
  }
  let arrayString = s.split('');
  let counter = 0;
  counter += arrayString.filter((letter)=>{return letter === 'a'}).length
  console.log(counter);
  // At this point we know how many occurances are in the substring with the letter 'a'
  counter = counter * Math.floor(n/arrayString.length);
  let charsLeft = n - Math.floor(n/arrayString.length) * arrayString.length;
  for(let i = 0; i < charsLeft; i++){
    if(arrayString[i] === 'a'){
      counter++;
    }
  }
  return counter;
}
console.log(`Result ${repeatedStrings('kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm',736778906400)}`)
