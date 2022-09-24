const id = document.getElementById('userId').value
const userName = document.getElementById('userName').value
const age = document.getElementById('age').value
const school = document.getElementById('school-select').value

function validateForm() {
  if (id.length !== 9 || isNaN(id)) {
    alert('invalid id input id ')
    document.getElementById('userId').parentElement.style.backgroundColor = red
  } else if (isNaN(userName)) {
    alert('invalid id input')
  } else if ((age > 3 && age < 120) || isNaN(id)) {
    alert('invalid id input')
  } else {
    alert('sign up is successful')
  }
}
