let aInput = document.querySelector('#a')
let bInput = document.querySelector('#b')
let cInput = document.querySelector('#c')
let btn = document.querySelector('#btn')
let div = document.querySelector('#res')


function calcular() {

    let a = parseFloat(aInput.value)
    let b = parseFloat(bInput.value)
    let c = parseFloat(cInput.value)

    let delta = b ** 2 - 4*a*c

    let x1 = (-b + Math.sqrt(delta)) / (2 * a)

    let x2 = (-b - Math.sqrt(delta)) / (2 * a)

    if (a === 0 || delta < 0) {
        div.innerHTML = 'Impossível calcular!'
    } else {
        div.innerHTML = `X1 = ${x1.toFixed(2)} <br> X2 = ${x2.toFixed(2)}`
    }
}

btn.addEventListener('click', calcular)