function change() {
  // get value from control
  let out = document.getElementById('input').value
  console.log(out)
  localStorage.setItem('o', out)
}

function load() {
  let out = localStorage.getItem('o')
  console.log(out)
  document.getElementById('output').value = out
}
