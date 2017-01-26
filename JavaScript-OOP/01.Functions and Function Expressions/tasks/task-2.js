/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */
function solve() {
    return function findPrimes(a, b) {
        "use strict";

        // Eratosthenes algorithm to find all primes under n
        let array = [], upperLimit = Math.sqrt(b), output = [];

        if (isNaN(Number(a)) && isNaN(Number(b))) {
            throw new Error('Invalid input!');
        }
        else if (a && b === undefined) {
            throw new Error('Invalid input!');
        }
        else if (a % 2 === 0 && b % 2 === 0) {
            return output;
        }

        // Make an array from 2 to (n - 1)
        for (let i = 0; i <= b; i++) {
            array.push(true);
        }

        // Remove multiples of primes starting from 2, 3, 5,...
        for (let i = 2; i <= upperLimit; i++) {
            if (array[i]) {
                for (let j = i * i; j < b; j += i) {
                    array[j] = false;
                }
            }
        }

        // All array[i] set to true are primes
        for (let i = a; i <= b; i++) {
            if (i < 2) {
                i = 2
            }
            if (array[i]) {
                output.push(i);
            }
        }
        return output;
    }
}

module.exports = solve;
