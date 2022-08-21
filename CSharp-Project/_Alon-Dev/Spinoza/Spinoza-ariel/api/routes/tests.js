const express = require("express");
const router = express.Router();
const {
  getAllTests,
  createTest,
  getTest,
  updateTest,
  deleteTest,
} = require("../controllers/tests");

router.get("/", getAllTests);
router.get("/:testId", getTest);

router.post("/", createTest);
router.patch("/:testId", updateTest);
router.delete("/:testId", deleteTest);

module.exports = router;
