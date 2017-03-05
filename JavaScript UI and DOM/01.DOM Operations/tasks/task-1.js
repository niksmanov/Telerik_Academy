/*
 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

function solve() {
    "use strict";
    function task(element, contents) {
        if (typeof element === 'string') {
            element = document.getElementById(element);

            if (element === null) {
                throw new Error();
            }
        }
        else if (element instanceof HTMLElement) {
            // pass the checking
        }
        else {
            throw new Error();
        }

        let output = '';
        for (let content of contents) {

            if (typeof content !== 'string' && typeof content !== 'number') {
                throw new Error();
            }

            output += '<div>' + content + '</div>';
        }
        element.innerHTML = output;
    }
    return task;
}

module.exports = solve;