$(document).ready(function () {
  $('[pallet]').click(function () {
    let selectedColor = this.style.backgroundColor
    //alert(selectedColor)
    sessionStorage.setItem('color', selectedColor)
  })

  $('#ret').click(function () {
    let color = sessionStorage.getItem('color')
    console.log(color)
    $('#ret').css('background-color', color)
  })

  $('#btn').click(function () {
    $('#ret').css({ backgroundColor: 'white' })
    sessionStorage.clear()
  })

  function load() {
    let color = sessionStorage.getItem('color')
    console.log(color)
    $('#ret').css('background-color', color)
  }
  window.onload = load
})
