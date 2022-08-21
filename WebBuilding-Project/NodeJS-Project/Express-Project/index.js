const express = require('express');
const app = express();
const Joi = require('joi');
//const router = express.Router();
//const bodyParser = require('body-parser');
//app.get();
//app.post();
//app.put();
//app.delete();

//https://expressjs.com/en/4x/api.html#req
app.get('/api/courses',
(req, res) => {
    //res.send('hello world');
    res.send([1, 2, 3,]);
});
/* *
app.get('/api/courses/:id', (req, res) => {
    res.send(req.params.id);
});
/* */
app.get('/api/courses/:year/:month', (req, res) => { //http://localhost:3000/api/courses/2008/5?query=55
    res.send(
        { year : req.params['year'],
        month : req.params.month,
        query  : req.query['query'], //?query
        }
    );
});


let courses = [
    {id : 1, name: 'course1'},
    {id : 2, name: 'course2'},
    {id : 3, name: 'course3'},
];

app.get('/api/courses/:id', (req, res) => {
    let course = courses.find(c => c.id == req.params.id);
    //if (!course) course = 'course not found';
    if (!course) res.status(404).send(`course ${req.params.id} not found2`);
    res.send(course);
});

app.post('/api/courses', (req, res) => { //fail // continue from 0:40 https://www.youtube.com/watch?v=pKd0Rpw7O48
    //if(!req.body.name || req.body.name.length < 3){ res.status(400).send(`name is required 2+ chars`); } //Bad Request
    const schema = {
        name: Joi.string().min(3).required(),
    }
    const result = Joi.validate(req.body, schema); //return object
    console.log(result);

    const course = {
        'id': courses.length + 1,
        'name': req.body.name
    };
    courses.push(course);
    if (!req.body ) res.status(601).send(`error!`);
    res.send(req.body.name + '1212');
    
});


app.post('/ping', (req, res) => {//fail
    if (!req.body ) res.status(601).send(`error!`);
    res.send(req.body.name + '1212');
});

//export/ set PORT=5000 change port to 5000
const port = process.env.PORT || 3000; //5000
app.listen(port, ()=> console.log(`listning on port ${port}`) );