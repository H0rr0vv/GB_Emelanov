const tempC = Number.parseFloat(prompt('Введите температуру'));
alert(`Цельсий: ${tempC}, Фаренгейт: ${ConvertTempCToTempF(tempC)}`);

function ConvertTempCToTempF(tempC) {
    let tempF = Math.round(((9 / 5) * tempC + 32) * 100) / 100;
    return tempF;
}