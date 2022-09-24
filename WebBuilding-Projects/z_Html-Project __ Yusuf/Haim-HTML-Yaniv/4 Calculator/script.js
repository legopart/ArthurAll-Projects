const numberButton = document.querySelectorAll('[data-number]')
const operatorButton = document.querySelectorAll('[data-operator]')
const equal = document.querySelector('[data-equal]')
const del = document.querySelector('[data-delete]')
const clear = document.querySelector('[data-clear]')
var previousoperand = document.querySelector('[data-previousoperand')
var currentoperand = document.querySelector('[data-currentoperand')
var operatorchoosed
var computed

document.body.addEventListener('keydown', keypress)

numberButton.forEach((div) =>
  div.addEventListener('click', () => {
    appendNumber(div.innerText)
  })
)

function appendNumber(number) {
  if (number === '.' && currentoperand.innerText.includes('.')) return

  currentoperand.innerText =
    currentoperand.innerText.toString() + number.toString()
}

operatorButton.forEach((div) =>
  div.addEventListener('click', () => {
    varassign(div.innerText)
  })
)

equal.addEventListener('click', () => {
  if (previousoperand.innerText != '' && currentoperand.innerText != '') {
    computed()
  }

  previousoperand.innerText =
    previousoperand.innerText + currentoperand.innerText

  previousoperand.innerText = ''
})

del.addEventListener('click', () => {
  currentoperand.innerText = currentoperand.innerText.toString().slice(0, -1)
})

clear.addEventListener('click', () => {
  currentoperand.innerText = null
  previousoperand.innerText = null
})

function varassign(operator) {
  if (previousoperand.innerText != '' && currentoperand.innerText != '') {
    computed()
  }

  previousoperand.innerText =
    previousoperand.innerText + currentoperand.innerText + operator
  currentoperand.innerText = ''
  operatorchoosed = operator
}

function computed() {
  if (operatorchoosed == '+') {
    compute =
      parseFloat(previousoperand.innerText) +
      parseFloat(currentoperand.innerText)
    previousoperand.innerText = ''
    currentoperand.innerText = compute
  } else if (operatorchoosed == '-') {
    compute =
      parseFloat(previousoperand.innerText) -
      parseFloat(currentoperand.innerText)
    previousoperand.innerText = ''
    currentoperand.innerText = compute
  } else if (operatorchoosed == '*') {
    compute =
      parseFloat(previousoperand.innerText) *
      parseFloat(currentoperand.innerText)
    previousoperand.innerText = ''
    currentoperand.innerText = compute
  } else if (operatorchoosed == '÷') {
    compute =
      parseFloat(previousoperand.innerText) /
      parseFloat(currentoperand.innerText)
    previousoperand.innerText = ''
    currentoperand.innerText = compute
  } else {
    return
  }
}

function keypress(e) {
  let char = e.keyCode
  if (char < 58 && char > 47) {
    currentoperand.innerText =
      currentoperand.innerText.toString() + String.fromCharCode(char)
  } else if (char < 106 && char > 95) {
    char = char - 48
    currentoperand.innerText =
      currentoperand.innerText.toString() + String.fromCharCode(char)
  } else {
    return
  }
}
