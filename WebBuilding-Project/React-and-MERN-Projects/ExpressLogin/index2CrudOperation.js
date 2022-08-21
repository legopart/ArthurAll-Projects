const mongoose = require("mongoose");
const express = require('express')
const app = express()
const cors = require('cors');

//

app.use(cors());
app.listen(3000)

//Get Request

mongoose.connect("mongodb://127.0.0.1:27017/playgroundwithstudents")  //
.then(() => {
    console.log("connected to db\n")
})
.catch((err) => {
    console.log("could not connect to mongo\n", err)
});


const courseSchema = new mongoose.Schema({
    name: String,
    author: String,
    tags: [String],
    date: {type: Date, default: Date.now },
    isPublish: Boolean,
    price: Number
});

const Course = mongoose.model("Course", courseSchema); // will saved as courses






async function getAllCourses(){
    let courses = await Course.find();
    console.log(courses);
    return courses;
}
app.route('/').get(async function (req, res) {        //ASYNC!
    let courses =await getAllCourses();//Course.find();
  res.send(courses);
})






/* *
async function createCourse(name, author, price){   //Save (add)
    const courseElias = new Course({
        name: name,
        author: author,
        tags: ["node", "backend", "express"],
        isPublish: true,
        price: price
    })
    let result = await courseElias.save();
    console.log('result', result);
}

createCourse("c#", "Alon", 5);
createCourse("react", "Haim", 1);
createCourse("docker", "Elias", 15);
/* */

/* */
async function getCourse(){             //Select
    const courses = await Course.find()
        .limit(5)
        .sort({ name: 1})   //sort by name
        .select({ name: 1}) //show only name
        console.log(courses);
        return courses;
}
//getCourse();
/* */


/* */

/* *
async function getCourse(){
    const courses = await Course.find()
        .and([{author : "Alon"}, {isPublish: true}]);   //Which data to show
        console.log(courses);
}
getCourse();
/* */

/* *
async function getCourse(){
    const courses = await Course.find()
        .and([{author : "Alon"}, {isPublish: true}]).count();   //count
        console.log(courses);
}
getCourse();
/* */

/* *
async function getCourse(pageNumber){
    const pageSize = 3;
    const courses = await Course.find()
    .skip((pageNumber-1) * pageSize)
    .limit(pageSize)   //.count()
    .select({ name: 1});    //only name
        console.log(courses);
}
getCourse(1);   //3 results for each page
/* */



/* *
async function findByIdAndDelete(id){
    let res = Course.findByIdAndDelete(id);
    console.log(res);
}

findByIdAndDelete('retne46s4n46t');
/* */

/* *
async function updateCourse2(name){
    let result = await Course.updateOne(
        {author: name}, //{id: id},
        { $set: { author: "Joey " } }
        );
}

updateCourse2("Alon");
/* */


/* *
async function updateCourse3(id){       //By Schema
    let course = await Course.findById(id);
    if(!course) return;
    course.isPublish = false;
    course.author = "Sam";
    let result = await course.save();
    console.log(result);
}
updateCourse3(...);

/* */


