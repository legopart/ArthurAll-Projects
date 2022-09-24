const mongoose = require("mongoose");
const Test = require("../models/test");

module.exports = {
  getTest: (req, res) => {
    const testId = req.params.testId;
    Test.findById(testId)
      .then((test) => {
        res.status(200).json({
          test,
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  getAllTests: (req, res) => {
    Test.find()
      .then((tests) => {
        res.status(200).json({
          tests,
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  createTest: (req, res) => {
    const {
      messageType,
      id,
      title,
      schemaVersion,
      testVersion,
      previousVersionId,
      authorId,
      description,
      tags,
      questions,
    } = req.body;

    const test = new Test({
      messageType,
      id,
      title,
      schemaVersion,
      testVersion,
      previousVersionId,
      authorId,
      description,
      tags,
      questions,
    });
    return test
      .save()
      .then(() => {
        res.status(200).json({
          message: "Created test",
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  updateTest: (req, res) => {
    const testId = req.params.testId;

    Test.findById(testId)
      .then((test) => {
        if (!test) {
          return res.status(404).json({
            message: "Test not found",
          });
        } else {
          Test.updateOne({ _id: testId }, req.body).then(() => {
            res.status(200).json({
              message: `Test Updated ${testId}`,
            });
          });
        }
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  deleteTest: (req, res) => {
    const testId = req.params.testId;

    Test.findById(testId)
      .then((test) => {
        if (!test) {
          return res.status(404).json({
            message: "Test not found",
          });
        } else {
          Test.deleteOne({ _id: testId }).then(() => {
            res.status(200).json({
              message: `Test deleted ${testId}`,
            });
          });
        }
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
};
