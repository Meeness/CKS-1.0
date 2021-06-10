
const timeremaining = document.querySelector('.timeremaining');
const countDown = document.querySelector('.countdown');


/* global variables and constants*/
// variable to store setInterval
let countDownInterval;
// secondsLeft in millisecond
let secondsLeftms;
// end time
let endTime;


window.onload = function() {
  if(timeremaining!=null){
    const now = Date.now();
    endTime = now + Math.floor(timeremaining.value/10000);
    setCountDown(endTime);
    countDownInterval = setInterval(() => {
      setCountDown(endTime);
    }, 1000);
  }
}
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
  countDown.innerHTML = `${hours} : ${minutes} : ${seconds}`;
};
