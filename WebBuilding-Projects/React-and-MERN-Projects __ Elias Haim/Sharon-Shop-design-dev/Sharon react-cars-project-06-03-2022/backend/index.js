const config = require("config");
const mongoose = require("mongoose");
const bodyParser = require('body-parser');

const express = require("express");
const products = require("./routers/products")
const app = express();
const cors = require("cors");

app.use(express.json());
app.use(cors());
// app.use(bodyParser.urlencoded({ extended: false }))


app.use("/products", products);

mongoose
  .connect(config.get("mongoDBStringUrl"))
  .then(() => {
    console.log("connected to mongoDB");
  })
  .catch((err) => {
    console.log("could not connect to mongoDB", err);
  });

const port = config.get("port");

app.listen(port, () => {
  console.log(`Listening on port ${port}`);
});
