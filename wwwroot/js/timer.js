
const timeremaining = document.querySelector('.timeremaining');
const stoppedtimeremaining = document.querySelector('.stoppedtimeremaining');
const countDown = document.querySelector('.countdown');


/* global variables and constants*/
// variable to store setInterval
let countDownInterval;
// secondsLeft in millisecond
let secondsLeftms;
// end time
let endTime;


window.addEventListener("load", function(){
  GulagStart();
},false);
window.addEventListener("load", function(){
  TimerStart();
},false);

function TimerStart() {
  if(timeremaining!=null){
    const now = Date.now();
    endTime = now + Math.floor(timeremaining.value/10000);
    setCountDown(endTime);
    countDownInterval = setInterval(() => {
      setCountDown(endTime);
    }, 1000);
  }else if(stoppedtimeremaining!=null){
    const endTime = Math.floor(stoppedtimeremaining.value/10000);
    showTime(endTime);
  }
}

const showTime = (endTime) => {

  const secondsLeft = Math.round(endTime / 1000);

  // calculate the hours, minutes and seconds
  let hours = Math.floor(secondsLeft / 3600);
  let minutes = Math.floor(secondsLeft / 60) - (hours * 60);
  let seconds = secondsLeft % 60;

  // adding an extra zero infront of digits if it is < 10
  if (hours < 10) {
    hours = `0${hours}`;
  }
  if (minutes < 10) {
    minutes = `0${minutes}`;
  }
  if (seconds < 10) {
    seconds = `0${seconds}`;
  }
  countDown.innerHTML = `${hours} : ${minutes} : ${seconds}`;
};

const setCountDown = (endTime) => {
  // calculate how many milliseconds is left to reach endTime from now
  secondsLeftms = endTime - Date.now();
  
  // convert it to seconds
  const secondsLeft = Math.round(secondsLeftms / 1000);

  // calculate the hours, minutes and seconds
  let hours = Math.floor(secondsLeft / 3600);
  let minutes = Math.floor(secondsLeft / 60) - (hours * 60);
  let seconds = secondsLeft % 60;

  // adding an extra zero infront of digits if it is < 10
  if (hours < 10) {
    hours = `0${hours}`;
  }
  if (minutes < 10) {
    minutes = `0${minutes}`;
  }
  if (seconds < 10) {
    seconds = `0${seconds}`;
  }
  if (secondsLeft < 0) {
    return;
  }
  countDown.innerHTML = `${hours} : ${minutes} : ${seconds}`;
};

/*** ENTER DE 36 CHAMBERS OF GULAG ***/

var keys = ["g", "u", "l", "a", "g"];
var keyCodes = [71, 85, 76, 65, 71];
var counter = 0;

function GulagStart(){
  document.addEventListener('keyup', checkArr)
}
function checkArr(e){
  if(keyCodes[counter]==e.keyCode){
    counter++
    if(counter==keys.length){
      var ele = document.createElement("input");
      ele.setAttribute("type", "hidden");
      ele.setAttribute("value", "engage");
      ele.setAttribute("name", "testmode");
      var testmode = document.getElementById("testmode");
      testmode.appendChild(ele);
      testmode.submit();
    }
  }
  else{
    counter=0;
  }
}
