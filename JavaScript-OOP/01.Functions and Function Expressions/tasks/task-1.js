/*
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number

 */

function solve() {
    return function sum(numbers) {
        "use strict";
        if (numbers === undefined) {
            throw new Error('Input is not declared!');
        }
        else if (numbers.length === 0) {
            return null;
        }
        else {
            let sum = 0;
            for (let element of numbers) {
                sum += Number(element);
                if (isNaN(Number(element))) {
                    throw new Error('Some of the elements is not a number!');
                }
            }
            return sum;
        }
    }
}

module.exports = solve;
