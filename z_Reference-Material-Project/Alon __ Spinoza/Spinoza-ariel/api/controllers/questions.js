const mongoose = require("mongoose");
const Question = require("../models/question");

module.exports = {
  getQuestion: (req, res) => {
    const questionId = req.params.questionId;
    Question.findById(questionId)
      .then((question) => {
        res.status(200).json({
          question,
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  getAllQuestions: (req, res) => {
    Question.find()
      .then((questions) => {
        res.status(200).json({
          questions,
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  createQuestion: (req, res) => {
    const {
      messageType,
      id,
      name,
      schemaVersion,
      questionVersion,
      previousVersionId,
      authorId,
      type,
      difficultyLevel,
      tags,
      content,
    } = req.body;

    const question = new Question({
      messageType,
      id,
      name,
      schemaVersion,
      questionVersion,
      previousVersionId,
      authorId,
      type,
      difficultyLevel,
      tags,
      content,
    });
    return question
      .save()
      .then(() => {
        res.status(200).json({
          message: "Created question",
        });
      })
      .catch((error) => {
        res.status(500).json({
          error,
        });
      });
  },
  updateQuestion: (req, res) => {
    const questionId = req.params.questionId;
    Question.findById(questionId)
      .then((question) => {
        if (!question) {
          return res.status(404).json({
            message: "Question not found",
          });
        } else {
          Question.updateOne({ _id: questionId }, req.body).then(() => {
            res.status(200).json({
              message: `Question Updated ${questionId}`,
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
  deleteQuestion: (req, res) => {
    const questionId = req.params.questionId;

    Question.findById(questionId)
      .then((question) => {
        if (!question) {
          return res.status(404).json({
            message: "Question not found",
          });
        } else {
          Question.deleteOne({ _id: questionId }).then(() => {
            res.status(200).json({
              message: `Question deleted ${questionId}`,
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
