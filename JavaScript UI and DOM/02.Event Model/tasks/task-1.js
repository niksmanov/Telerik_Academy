/* 
 Create a function that takes an id or DOM element and:

 * If an id is provided, select the element
 * Finds all elements with class button or content within the provided element
 * Change the content of all .button elements with "hide"
 * When a .button is clicked:
 * Find the topmost .content element, that is before another .button and:
 * If the .content is visible:
 * Hide the .content
 * Change the content of the .button to "show"
 * If the .content is hidden:
 * Show the .content
 * Change the content of the .button to "hide"
 * If there isn't a .content element after the clicked .button and before other .button, do nothing
 * Throws if:
 * The provided DOM element is non-existant
 * The id is neither a string nor a DOM element
 */

function solve() {
    function task(element) {
        "use strict";

        if (typeof element === 'string') {
            element = document.getElementById(element);
        }

        let elements = element.children;

        for (let i = 0; i < elements.length; i += 1) {
            if (elements[i].className === 'button') {
                elements[i].innerHTML = 'hide';
            }
        }

        function clickItem(el) {
            let item = el.target;

            let nextItem = item.nextElementSibling;

            if (nextItem.className !== 'button') {
                nextItem = nextItem.nextElementSibling;
            }

            if (nextItem.className === 'content') {
                if (nextItem.style.display === '') {
                    nextItem.style.display = 'none';
                    item.innerHTML = 'show';
                }
                else {
                    nextItem.style.display = '';
                    item.innerHTML = 'hide';
                }
            }
        }

        for (let i = 0; i < elements.length; i += 1) {
            if (elements[i].className === 'button') {
                elements[i].addEventListener('click', clickItem);
            }
        }
    }

    return task;
}

module.exports = solve;