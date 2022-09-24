const panels = document.querySelectorAll('.fruit')

let value = 0

function bananaClick() {
  this.value = 15
  console.log(this.value)
}

function orangeClick() {
  this.value = 10
  console.log(this.value)
}

function watermelonClick() {
  this.value = 5
  console.log(this.value)
}

function CheckPrice() {
  totalPrice = document.getElementById('quantity').value * this.value
  document.getElementById('value').value = totalPrice
}

panels.forEach((panel) => {
  panel.addEventListener('click', () => {
    removeActiveClasses()
    panel.classList.add('selected')
  })
})

function removeActiveClasses() {
  panels.forEach((panel) => {
    panel.classList.remove('selected')
  })
}
