const express = require("express");
const loginRouter = express.Router();
const passport = require('passport');
const bcrypt = require('bcrypt');
const flash = require('express-flash');
const methodOverride = require('method-override');

loginRouter.use(express.urlencoded({ extended: false }));   //
loginRouter.use(flash());
loginRouter.use(methodOverride('_method'));

const users = require('./database_users');

loginRouter.route('/login')
    .get((req, res) => res.render('login.ejs') )
    .post(passport.authenticate('local', {
        successRedirect: '/',
        failureRedirect: '/login',
        failureFlash: true  //message
    }));

loginRouter.route('/register')
    .get((req, res) =>  res.render('register.ejs') )
    .post(async (req, res) => {
        try {
            const hashedPassword = await bcrypt.hash(req.body.password, 10)
            users.push({
            id: Date.now().toString(),
            name: req.body.name,
            email: req.body.email,
            password: hashedPassword
            })
            res.redirect('/login')
        } catch {
            res.redirect('/register')
        }
    })
    ;

loginRouter.route('/logout')
    .delete((req, res) => req.logOut().redirect('/login') )

module.exports = loginRouter;