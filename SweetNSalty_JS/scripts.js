"use strict";

// create variables rather than hard coding values
let startCount = 1;
let endCount = 1000;
let firstCheck = 3;
let secondCheck = 5;
let numberPerLine = 10;

// create the constants for the strings
const sweet = "sweet";
const salty = "salty";
const sweetNSalty = "sweet'nSalty";

// create counter variables
let sweetCount = 0;
let saltyCount = 0;
let sweetSaltyCount = 0;
let counter = 1;

// create string to concatenate to
let toPrint = "";

function sweetNSalty()
{
    for (var i = startCount; i <= endCount; i += 1)
    {
        // check if the number is divisible by both 3 and 5
        if (i % firstCheck == 0 && i % secondCheck == 0)
        {
            toPrint += (sweetNSalty + " ");
            sweetSaltyCount += 1;
        }
        // check if the number is only divisible by 3
        else if (i % firstCheck == 0)
        {
            toPrint += (sweet + " ");
            sweetCount += 1;
        }
        //check if the number is only divisible by 5
        else if (i % secondCheck == 0)
        {
            toPrint += (salty + " ");
            saltyCount += 1;
        }
        // otherwise just add the number
        else 
        {
            toPrint += (i + " ");
        }

        // check if the proper number per line has been reached and print those values
        if (counter % numberPerLine == 0)
        {
            console.log(toPrint);
            toPrint = "";
        }
        // increment the counter to check for number per line
        counter += 1;
    }
}

// print number of times each string was printed
function printNumber()
{
    console.log();
    console.log("Number of sweet: " + sweetCount);
    console.log("Number of salty: " + saltyCount);
    console.log("Number of sweet'nSalty: " + sweetSaltyCount);
}

// run code
sweetNSalty();
printNumber();