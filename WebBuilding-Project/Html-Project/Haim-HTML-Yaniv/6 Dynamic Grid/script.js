$(document).ready(function () {
  function printBoard(i_BoardSize) {
    let maxRow = parseInt(i_BoardSize)
    let maxCol = parseInt(i_BoardSize)
    let num = 1

    let myTable = $(
      '<table class="table table-bordered border-dark" ></table>'
    ).appendTo('#board')

    for (let row = maxRow - 1; row >= 0; row--) {
      let myRow = $('<tr></tr>').appendTo(myTable)
      for (let col = 0; col < maxCol; col++) {
        myRow.append(
          '<th box class="box p-4 m-2  border-1 border-dark " scope="col"></th>'
        )
        num++
      }
    }
  }

  $(function () {
    let boardSize = 0
    $('[size]').keyup(function () {
      console.log(this.value)
      let boardSize = this.value
      $('#board').empty()
      printBoard(boardSize)
      $('[box]').click(function () {
        console.log(this)
        $(this).css('background-color', '#007FFF')
      })
    })
  })
})
