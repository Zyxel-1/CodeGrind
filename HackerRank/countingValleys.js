const countingValleys = (n, s) => {
  let elevation = 0;
  let valleys = 0;
  let track = [];
  for(let i = 0; i < n; i++){
    if(s[i] === 'U'){
      elevation++;
    } else{
      elevation--;
    }
    if(elevation < 0){
      if(track[track.length-1] !== 'V'){
        track.push('V');
      }
    }else{
      if(track[track.length-1] !== 'M'){
        track.push('M')
      }
    }
  }
  console.log(track)
  return track.filter((valley)=> valley === 'V').length;
}
console.log(`Number of valleys: ${countingValleys(12,'DDUUDDUDUUUD')}`)
