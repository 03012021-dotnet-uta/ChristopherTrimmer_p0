function sweetSalty(arg1, arg2)
{
    let newStr = "";
    for (var i = arg1; i <= arg2; i++)
    {
        if (i % lineBreak == 0)
        {
            newStr = newStr + `\n`;
        }
        
        if (i % sweetInt == 0 && i % saltyInt == 0)
        {
            newStr = newStr + sweetSaltyString + sweetSaltySpace;
            countSweetSalty += 1;
        }
        else if (i % sweetInt == 0)
        {
            newStr = newStr + sweetString + sweetSaltySpace;
            countSweet += 1;
        }
        else if (i % saltyInt == 0)
        {
            newStr = newStr + saltyString + sweetSaltySpace;
            countSalty += 1;
        }
        else
        {
            newStr = newStr + i + ` `;
        }
    }

    console.log(newStr);
}

function displayTotals(arg1, arg2, arg3)
{
    console.log(`Sweet: ${arg1}`);
    console.log(`Salty: ${arg2}`);
    console.log(`SweetnSalty: ${arg3}`);
}

let smallNumber = 1;
let maxNumber = 1000;
let sweetString = "sweet";
let saltyString = "salty";
let sweetSaltyString = "sweet'nSalty";
let sweetInt = 3;
let saltyInt = 5;
let lineBreak = 10;
let sweetSaltySpace = " ";
let countSalty = 0;
let countSweet = 0;
let countSweetSalty = 0;
let countHeader = "Totals";
let newstr = "";

console.log();
sweetSalty(smallNumber, maxNumber);
console.log(`\n` + `${countHeader}`);
displayTotals(countSweet, countSalty, countSweetSalty);




