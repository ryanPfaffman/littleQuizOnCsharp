// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const button = document.getElementById("button");
const numCorrect1 = document.getElementById("numCorrect1");

let numCorrect = 0;

let allQuestions = false;

const quizOver = () => {
    alert("Quiz Over");
}

const quiz = () => {
    if (document.querySelector('input[name="question1"]:checked') === null || document.querySelector('input[name="question2"]:checked') === null || document.querySelector('input[name="question3"]:checked') === null || document.querySelector('input[name="question4"]:checked') === null || document.querySelector('input[name="question5"]:checked') === null) {
        alert("All questions not answered");
    } else {
        allQuestions = true;
    }
    
    if (document.querySelector('input[name="question1"]:checked').value == 'null' && allQuestions === true) {
        alert("Not all question answered");
    }
    if (document.querySelector('input[name="question1"]:checked').value === "t" && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question2"]:checked').value === "t" && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question3"]:checked').value === "f" && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question4"]:checked').value === "f" && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question5"]:checked').value === "t" && allQuestions === true) {
        numCorrect++;
    }

    if (allQuestions === true) {
        button.removeEventListener('click', quiz);
        button.addEventListener('click', quizOver);
    }

    numCorrect1.innerHTML = "Correct: " + numCorrect.toString() + "<br>" 
    + "Questions: 5<br>" 
    + "Grade: " + Math.round(numCorrect / 5 * 100).toString() + "%";
}

button.addEventListener('click', quiz);