'use strict';

class Node {
    constructor(value) {
        this._data = value;
        this._next = null;
    }

    get data() {
        return this._data;
    }
}

class LinkedList {
    constructor() {
        this._length = 0;
        this._head = null;

        return this;
    }

    get first() {
        return this._head.data;
    }

    get last() {
        return this.at(this._length - 1);
    }

    get length() {
        return this._length;
    }

    append(...elements) {
        for (let element of elements) {
            let node = new Node(element);

            if (this._head === null) {
                this._head = node;
            }
            else {
                let current = this._head;

                while (current._next) {
                    current = current._next;
                }
                current._next = node;
            }
            this._length += 1;
        }
        return this;
    }

    prepend(...elements) {
        elements = elements.reverse();
        for (let element of elements) {
            let node = this._head;
            let newNode = new Node(element);

            this._head = newNode;
            this._head._next = node;

            this._length += 1;
        }
        return this;
    }

    insert(index, ...elements) {
        if (index === 0) {
            this.prepend(...elements);
        }
        else {
            let i = 0;
            let current = this._head;
            let previous = 0;

            while (i++ < index) {
                previous = current;
                current = current._next;
            }

            for (let element of elements) {
                let newNode = new Node(element);
                previous._next = newNode;
                newNode._next = current;

                previous = newNode;

                this._length += 1;
            }
        }
        return this;
    }

    [Symbol.iterator]() {
        let current = this._head;

        return {
            i: 0,
            next() {
                if (current) {
                    this.i += 1;
                    let now = current;
                    current = current._next;

                    return {
                        value: now.data,
                        done: false
                    }
                }
                else {
                    return {
                        value: undefined,
                        done: true
                    }
                }
            }
        }
    }

    removeAt(index) {
        if (index === 0) {
            let node = this._head;
            this._head = this._head._next;
            this._length -= 1;

            return node.data;
        }
        else if (index > 0 && index < this.length) {
            let previous = this._head;
            let current = previous._next;
            let i = 1;

            while (i !== index) {
                previous = current;
                current = previous._next;

                i += 1;
            }
            previous._next = current._next;
            this._length -= 1;
            return current.data;
        }
        else {
            return null;
        }
    }

    at(index, value) {
        if (value !== undefined) {
            this.insert(index, value);
            this.removeAt(index + 1);
        }
        else {
            if (index >= 0 && index < this._length) {
                let current = this._head;
                let i = 0;

                while (i++ < index) {
                    current = current._next;
                }

                return current.data;
            }
            else {
                return null;
            }
        }
    }

    toArray() {
        let result = [];
        let current = this._head;
        result.push(current.data);

        while (current._next) {
            current = current._next;
            result.push(current.data);
        }

        return result;
    }

    toString() {
        return this.toArray().join(' -> ');
    }
}

module.exports = LinkedList;