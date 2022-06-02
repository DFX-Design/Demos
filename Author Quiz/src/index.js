import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import AuthorQuiz from './AuthorQuiz';
import { shuffle, sample } from 'underscore';

//import reportWebVitals from './reportWebVitals';
//import registerServiceWorker from './registerServiceWorker';


const authors = [
    {
        name: 'Mark Twain',
        imageUrl: 'images/authors/marktwain.jpg',
        imageSource: 'Wikimedia Commons',
        books: ['The Adventures of Huckleberry Finn', 'Life on the Mississippi', 'Roughing It']
    },
    {
        name: 'Charles Dickens',
        imageUrl: 'images/authors/charlesdickens.jpg',
        imageSource: 'Wikimedia Commons',
        books: ['Oliver Twist', 'A Christmas Carol', 'Great Expectations']
    },
    {
        name: 'JK Rowling',
        imageUrl: 'images/authors/jkrowling.jpg',
        imageSource: 'Wikimedia Commons',
        books: ['Harry Potter', 'The Ickabog', 'The Christmas Pig']
    },
    {
        name: 'Joseph Conrad',
        imageUrl: 'images/authors/josephconrad.png',
        imageSource: 'Wikimedia Commons',
        books: ['Lord Jim', 'Heart of Darkness', 'The Shadow-Line']
    },
    {
        name: 'Stephen King',
        imageUrl: 'images/authors/stephenking.jpg',
        imageSource: 'Wikimedia Commons',
        books: ['IT', 'The Shining', 'The Green Mile']
    },
    {
        name: 'William Shakespear',
        imageUrl: 'images/authors/williamshakespear.jpg',
        imageSource: 'Wikimedia Commons',
        books: ['Hamlet', 'Macbeth', 'Romeo and Juliet']
    }
];

function getTurnData(authors) {
    const allBooks = authors.reduce(function (p, c, i) {
        return p.concat(c.books);
    }, []);
    const fourRandomBooks = shuffle(allBooks).slice(0, 4);
    const answer = sample(fourRandomBooks);

    return {
        books: fourRandomBooks,
        author: authors.find((author) =>
            author.books.some((title) =>
                title === answer))
    }

}
const state = {
    turnData: getTurnData(authors),
    highlight: ''
    
};


function onAnswerSelected(answer) {
    const isCorrect = state.turnData.author.books.some((book) =>
        book === answer);
    state.highlight = isCorrect ? 'correct' : 'wrong';
    render();
}

function render() {
    const root = ReactDOM.createRoot(document.getElementById('root'));
    root.render(
        <React.StrictMode>
            <AuthorQuiz {...state} onAnswerSelected={onAnswerSelected} />
        </React.StrictMode>
    );
}
render();




//registerServiceWorker();
// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
//reportWebVitals();
