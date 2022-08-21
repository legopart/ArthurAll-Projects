const express = require("express");
const cors = require("cors");
const mongoose = require("mongoose");
const config = require("config");
const morgan = require("morgan");
const { corsOptions, credentials } = require("./api/middlewares/credentials");
const testsRoutes = require("./api/routes/tests");
const questionsRoutes = require("./api/routes/questions");

const app = express();

app.use(credentials);

mongoose.connect(
  `mongodb+srv://${config.get("env.MONGO_USERNAME")}:${config.get(
    "env.MONGO_PASSWORD"
  )}@articels-api.m2w2c.mongodb.net/myFirstDatabase?retryWrites=true&w=majority`,
  {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  }
);

mongoose.connection.on(`connected`, () => {
  console.log("MongoDB Connected!");
});

app.use(
  express.urlencoded({
    extended: false,
  })
);

app.use(express.json());

app.use(morgan("dev"));

app.use(cors(corsOptions));

app.use("/tests", testsRoutes);
app.use("/questions", questionsRoutes);

app.use((req, res, next) => {
  const error = new Error("Not Found");
  error.status = 404;
  next(error);
});

app.listen(5777);
