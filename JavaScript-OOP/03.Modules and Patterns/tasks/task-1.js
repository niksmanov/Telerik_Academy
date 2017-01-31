/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    "use strict";

    let Presentation = {
        init: function (title, homework) {
            this.title = title;
            this.homework = homework;

            let input = this.title.split(' ');
            if (this.title.length === 0 || input.length > 2 || title.length < 2) {
                throw new Error();
            }
            return this;
        }

    };

    let Student = {
        init: function (firstName, lastName, ID) {

            this.firstName = firstName;
            this.lastName = lastName;
            this.ID = ID;

            return this;
        }
    };


    let Course = {

        init: function (title, presentation) {
            let oldTitle = title;
            if (oldTitle.trim().length !== title.length && oldTitle.length > 0) {
                throw new Error();
            }
            if (presentation === undefined) {
                throw new Error();
            }
            if (this.examResults.length === 0) {
                throw new Error();
            }

            this.title = title;
            this.presentations = presentation;
            this.students = [];
            this.homeworks = [];
            this.examResults = [];

        },
        addStudent: function (name) {
            let input = name.split(' ');
            if (input[0][0] === input[0][0].toLowerCase()) {
                throw new Error();
            }
            if (input.length > 2 || input.length < 2) {
                throw new Error();
            }
            let id = 0;
            id += 1;
            let student = Object.create(Student).init(input[0], input[1], id);
            this.students.push(student);
            return this;
        },

        getAllStudents: function () {
            return this.students;
        },
        submitHomework: function (studentID, homeworkID) {
            studentID = this.students.some(function (Student) {
                return Student.ID === studentID;
            });
            homeworkID = studentID + 1;
        },
        pushExamResults: function (results) {
            Student.ID = results.StudentID;
            Student.score = results.score;
            for (let student of this.students) {
                for (let prop in student) {
                    if (id !== prop.ID) {
                        throw new Error();
                    }
                }
            }
            if (Student.score.length === 0 && isNaN(Student.score)) {
                throw new Error();
            }
            this.examResults.push(results);

        },
        getTopStudents: function () {
            let topStudents = this.students.sort(function (a, b) {
                return a.score - b.score;
            });

            let output = [];
            if (topStudents.length > 10) {
                for (let i = 0; i < 10; i += 1) {
                    output.push(topStudents[i]);
                }
                return output;
            }
            else if (topStudents.length < 10) {
                for (let i = 0; i < topStudents.length; i += 1) {
                    output.push(topStudents[i]);
                }
                return output;
            }
        }
    };

    return Course;
}


module.exports = solve;
