let numInput = document.querySelector('#numInput')
let btn = document.querySelector('#btn')

let arr = []

function calcular () {

    let num = parseFloat(numInput.value)

    arr.push(num)

    let res = '';

    if (arr.length === 4) {
        numInput.classList.add('hidden')
        btn.classList.add('hidden')

        console.log('Ação impossível');
    }

    for(let i = 0; i < arr.length; i++) {

       if (arr[i] > 10 && arr[i] < 20) {
            console.log( res += arr[i] + ' in ');
       } else {
        console.log(res += arr[i] + ' out ');
       }

    }
    
}

btn.addEventListener('click', calcular)