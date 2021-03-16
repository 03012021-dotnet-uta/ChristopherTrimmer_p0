
/* This function performs the calculation to determine
    if current number is divisible by 3, 5, or both numbers.
    the result of the calculation is concatenated to the
    overall string where it is printed.*/
function sweetSalty(arg1, arg2)
{
    let newStr = "";
    for (var i = arg1; i <= arg2; i++)
    {

        // Print a line break after 10 numbers have been printed
        if (i % lineBreak == 0)
        {
            newStr = newStr + `\n`;
        }

        // Print sweet'nSalty if the number is divisible by 3 and 5
        if (i % sweetInt == 0 && i % saltyInt == 0)
        {
            newStr = newStr + sweetSaltyString + sweetSaltySpace;
            countSweetSalty += 1;
        }

        // Print sweet if the number is divisible by 3
        else if (i % sweetInt == 0)
        {
            newStr = newStr + sweetString + sweetSaltySpace;
            countSweet += 1;
        }

        // Print salty if the number is divisible by 5
        else if (i % saltyInt == 0)
        {
            newStr = newStr + saltyString + sweetSaltySpace;
            countSalty += 1;
        }

        // Print the actual number if it is not divisible by 3 or 5
        // or a combination of both
        else
        {
            newStr = newStr + i + ` `;
        }
    }

    // Print the final concatenated string
    console.log(newStr);
}

/* This function is used to print the count
    of the number times each variable
    has been incremented. */
function displayTotals(arg1, arg2, arg3)
{
    console.log(`Sweet: ${arg1}`);
    console.log(`Salty: ${arg2}`);
    console.log(`SweetnSalty: ${arg3}`);
}

// These are the variables used in the program
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

// Call to the function that perform the calculation
sweetSalty(smallNumber, maxNumber);
console.log(`\n` + `${countHeader}`);

// Call to the function that prints the totals
displayTotals(countSweet, countSalty, countSweetSalty);




