/* const num_1 = Number.parseFloat(prompt("Введите перове число"));
const num_2 = Number.parseFloat(prompt("Введите второе число"));

alert(`Результат сложения чисел ${num_1} и ${num_2} равен ${Sum_num(num_1, num_2)}.`);



function Sum_num(n_1, n_2) {
    return n_1 + n_2;
}
 */

/* if (confirm("Вам хорошо живется?")) {
    alert("Тогда мы идем к вам!");
}
else {
    alert("Ну вы держитесь там!");
}
 */




/* const product = "Бананы";

switch (product) {
    case "Мандарины":
        alert("Мандарины стоят 100 руб/кг.");
        break;

    case "Бананы":

    case "Груши":
        alert("Бананы и груши стоят 70 руб/кг.");
        break;

    default:
        alert('Нат такого продукта');
}
 */


/* 
function getMaxEvenElement(arr) {
    let max = arr[0];
    for (let i = 2; i < arr.length; i = i + 2) {
        if (max < arr[i]) {
            max = arr[i];
        }
    }
    return max;
}

console.log(getMaxEvenElement([5, 7, -1, 12, 3, 0])); //5
console.log(getMaxEvenElement([4, -12, 29, 6, 31, 92, -50])); //31
console.log(getMaxEvenElement([-4, -12, -29, -6, -31, -92, -50])); //-4 */



/* Один покупатель старинных часов хочет приобрести для музея двое часов. В магазине у хозяйки есть n разных часов с соответствующими ценами [p1, ..., pn]. Покупатель хочет полностью использовать свой бюджет. Необходимо выяснить получится ли ему это.
 */

function f(clock_arr, money) {
    
}


console.log(f([8.74, 3.12, 9.50, 2.35], 2.35)); //false
console.log(f([1.1, 4.2, 7.5, 0.4], 8.4)); //false
console.log(f([54.10, 20.00, 18.51, 97.75, 35.20, 76.42], 89.3)); //true

