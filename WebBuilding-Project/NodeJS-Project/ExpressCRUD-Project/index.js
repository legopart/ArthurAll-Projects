const express = require('express');
const bodyParser = require('body-parser');
//const router = express.Router();
const app = express();
//app.use("/", router);
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());
const port = process.env.PORT || 3000; //5000
const Joi = require('joi');
//app.get();
//app.post();
//app.put();
//app.delete();
//https://expressjs.com/en/4x/api.html#req

let courses = [ {id : 1, name: 'course1'}, {id : 2, name: 'course2'}, {id : 3, name: 'course3'}, ];

app.get('/api/courses', (req, res) => { res.send(courses); });

app.get('/api/courses/:year/:month', (req, res) => { //http://localhost:3000/api/courses/2008/5?query=55
    res.send( {
        year : req.params['year'],
        month : req.params.month,
        query  : req.query['query'], /*?query*/
    } );
} );

app.get('/api/courses/:id', (req, res) => {
    course = findCourse(req.params.id, res);
    if(!course) return; //404
    res.send(course);
} );

app.post('/api/courses', (req, res) => { //https://www.npmjs.com/package/joi
    const course = { 
        "id": courses.length + 1, 
        "name": req.body.name, };
    if(!isJson(req, res) || !validateCourse(course, res)) return;
    courses.push(course);
    res.send(req.body.name + ' Added!');    //console.log('Added', req.body);
} );

app.put('/api/courses/:id', (req, res) =>{
    let course = findCourse(req.params.id, res);
    if(!isJson(req, res) || !course || !validateCourse(course, res)) return;
    course.name = req.body.name;
    res.send('course updated ' + req.body.name)
} );

app.delete('/api/courses/:id', (req, res) => {
    course = findCourse(req.params.id, res);
    if(!course) return; //404
    const index = courses.indexOf(course);
    courses.splice(index, 1);
    res.send(course)
} );

app.listen(port, ()=> console.log(`listening on port ${port}`) );


function isJson(req, res){
    if (!req.body || Object.keys(req.body).length === 0 ) return res.status(601).send('no JSON body error!');   //return false
    return true;
}

function findCourse(id, res){ //req.params.id
    let course = courses.find(c => c.id == id); //if (!course) course = 'course not found';
    if (!course) return res.status(404).send(`course ${id} not found3`); //return null
    return course;
}

function validateCourse(course, res){
    //if(!req.body.name || req.body.name.length < 3){ res.status(400).send(`name is required 2+ chars`); } //Bad Request
    let schema = Joi.object({
        "id": Joi.required(),
        "name": Joi.string().min(3).required(),
    });   
    const {error} = schema.validate(course); //validationResult //req.body //return object
    //console.log(validationResult);
    if(error) return res.status(412).send('validation error! ' + error.message); //return false //validationResult.error
    return true;
}