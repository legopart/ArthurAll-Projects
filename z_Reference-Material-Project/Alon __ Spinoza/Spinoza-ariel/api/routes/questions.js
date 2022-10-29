const express = require("express");
const router = express.Router();
const {
  getAllQuestions,
  createQuestion,
  getQuestion,
  updateQuestion,
  deleteQuestion,
} = require("../controllers/questions");

router.get("/", getAllQuestions);
router.get("/:questionId", getQuestion);

router.post("/", createQuestion);
router.patch("/:questionId", updateQuestion);
router.delete("/:questionId", deleteQuestion);

module.exports = router;
