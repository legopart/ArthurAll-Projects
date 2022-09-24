document.querySelector('.get-jokes').addEventListener('click', getJokes)

function getJokes(e) {
  const xhr = new XMLHttpRequest()

  xhr.open('GET', `https://v2.jokeapi.dev/joke/Any`, true)

  xhr.onload = function () {
    if (this.status === 200) {
      const response = JSON.parse(this.responseText)
      console.log(response)

      let output = ''
      if (response.flags.political === true) {
        output += `<del>`
      }

      if (response.type === 'single') {
        output += `<li>${response.joke}</li>`
      } else {
        output += `<li>${response.setup}</li>`
        output += `<li>${response.delivery}</li>`
      }

      if (response.flags.political === true) {
        output += `</del>`
      }

      document.querySelector('.jokes').innerHTML = output
    }
  }

  xhr.send()

  e.preventDefault()
}
