'use strict'

console.log("ArroyFunction");

// 화살표 함수
const simplePrint = () => console.log("simplePrint");

// 화살표 함수 리턴형
const simplePrint2 = (a,b) =>{
    return a+b;
}

// 백택(`) + ${}로 표현식
const simplePrint3 = (a,b) => console.log(`a = ${a}, b = ${b}`);

simplePrint();

let addCalc = simplePrint2(1,2);
console.log(addCalc);

simplePrint3("1","2");

//var, let, const, hoisting => 




