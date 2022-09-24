if (process.env.NODE_ENV !== 'production') require('dotenv').config();
const _serverSession = 'aaa';

const express = require('express');
const passport = require('passport');
const session = require('express-session');

const app = express();
app.set('view-engine', 'ejs')
app.use(session({ secret: process.env.SESSION_SECRET || _serverSession, resave: false, saveUninitialized: false }));

const users = require('./database_users');

const initializePassport = require('./passport-config');
initializePassport(
  passport,
  email => users.find(user => user.email === email),
  id => users.find(user => user.id === id)
);
app.use(passport.initialize());
app.use(passport.session());


app.route('/').get( checkAuthenticated, (req, res) =>  res.render('index.ejs', { name: req.user.name }) );

function checkAuthenticated(req, res, next) {
    if (req.isAuthenticated()) return next();
    return res.redirect('/login');
}

app.use(checkNotAuthenticated); //middleWhere
app.use('/', require('./loginRouter'));

function checkNotAuthenticated(req, res, next) {
    if (req.isAuthenticated()) return res.redirect('/');
    next();
}

app.listen(3000)

