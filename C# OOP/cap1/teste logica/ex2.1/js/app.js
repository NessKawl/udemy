let codInput = document.querySelector('#cod')
let quantInput = document.querySelector('#quant')
let btn = document.querySelector('#btn')
let div = document.querySelector('#res')

let arr = [0, 4, 4.5, 5, 2, 1.5]

function calcular() {
    let cod = parseFloat(codInput.value)
    let quant = parseFloat(quantInput.value)

    let valor = quant * arr[cod]

    div.innerHTML = valor
}

btn.addEventListener('click', calcular)