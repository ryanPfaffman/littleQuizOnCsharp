﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const button = document.getElementById("button");
const numCorrect1 = document.getElementById("numCorrect1");

const ansQ1 = document.getElementById("ansQ1").innerHTML;
const ansQ2 = document.getElementById("ansQ2").innerHTML;
const ansQ3 = document.getElementById("ansQ3").innerHTML;
const ansQ4 = document.getElementById("ansQ4").innerHTML;
const ansQ5 = document.getElementById("ansQ5").innerHTML;
const ansQ6 = document.getElementById("ansQ6").innerHTML;
const ansQ7 = document.getElementById("ansQ7").innerHTML;
const ansQ8 = document.getElementById("ansQ8").innerHTML;
const ansQ9 = document.getElementById("ansQ9").innerHTML;
const ansQ10 = document.getElementById("ansQ10").innerHTML;
const ansQ11 = document.getElementById("ansQ11").innerHTML;
const essay = document.getElementById("essay");
const form = document.getElementById("formQuizGui");

let numCorrect = 0;

let allQuestions = false;

const quizOver = () => {
    alert("Quiz Over");
}

const quiz = () => {
    let essayVal = essay.value;
    if (document.querySelector('input[name="question1"]:checked') === null || document.querySelector('input[name="question2"]:checked') === null || document.querySelector('input[name="question3"]:checked') === null || document.querySelector('input[name="question4"]:checked') === null || document.querySelector('input[name="question5"]:checked') === null || document.querySelector('input[name="question6"]:checked') === null || document.querySelector('input[name="question7"]:checked') === null || document.querySelector('input[name="question8"]:checked') === null || document.querySelector('input[name="question9"]:checked') === null || document.querySelector('input[name="question10"]:checked') === null || document.querySelector('input[name="question11"]:checked') === null) {
        alert("All questions not answered");
    } else {
        allQuestions = true;
    }

    if (document.querySelector('input[name="question1"]:checked').value === ansQ1 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question2"]:checked').value === ansQ2 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question3"]:checked').value === ansQ3 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question4"]:checked').value === ansQ4 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question5"]:checked').value === ansQ5 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question6"]:checked').value === ansQ6 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question7"]:checked').value === ansQ7 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question8"]:checked').value === ansQ8 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question9"]:checked').value === ansQ9 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question10"]:checked').value === ansQ10 && allQuestions === true) {
        numCorrect++;
    }
    if (document.querySelector('input[name="question11"]:checked').value === ansQ11 && allQuestions === true) {
        numCorrect++;
    }

    numCorrect1.innerHTML = "Correct: " + numCorrect.toString() + "<br>" 
    + "Questions: 11<br>" 
    + "Grade: " + Math.round(numCorrect / 11 * 100).toString() + "%";

    if (allQuestions === true) {
        button.removeEventListener('click', quiz);
        button.addEventListener('click', quizOver);
        formQuizGuiz.submit();
    }
}

button.addEventListener('click', quiz);