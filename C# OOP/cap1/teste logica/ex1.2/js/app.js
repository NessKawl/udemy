let numInput = document.querySelector('#numInput')
let div = document.querySelector('#res')
let btn = document.querySelector('#btn')

function calcular() {
    let raio = parseFloat(numInput.value)

    let area = (raio ** 2) * Math.PI

    div.innerHTML = `A área do círculo é: ${area.toFixed(4)}`
}

btn.addEventListener('click', calcular)