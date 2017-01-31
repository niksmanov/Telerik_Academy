/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    let library = (function () {
        "use strict";

        let books = [];
        let categories = [];

        function addCategory(category) {
            categories.push(category);
        }

        function listBooks(wanted) {
            if (wanted && wanted.category) {
                return books.filter(function (book) {
                    return book.category === wanted.category;
                });
            }

            if (wanted && wanted.author) {
                return books.filter(function (book) {
                    return book.author === wanted.author;
                });
            }
            return books;
        }

        function addBook(book) {
            checkBook(book);
            isBookUnique(book, books);

            if (categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;


    function checkBook(book) {

        if (book.title.length < 2 || book.title.length > 100) {
            throw new Error('Invalid title!');
        }
        else if (book.author.length === 0 || typeof(book.author) !== 'string') {
            throw new Error('Invalid author!');
        }
        else if (book.isbn.length !== 10 && book.isbn.length !== 13) {
            throw new Error('Invalid ISBN!');
        }
    }

    function isBookUnique(book, books) {

        for (let b of books) {
            if (b.title === book.title || b.isbn === book.isbn) {
                throw new Error('Invalid book!');
            }
        }
    }

}
module.exports = solve;
