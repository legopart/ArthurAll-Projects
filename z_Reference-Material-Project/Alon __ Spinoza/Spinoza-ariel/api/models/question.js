const mongoose = require("mongoose");

const questionSchema = mongoose.Schema({
  messageType: { type: String, required: true },
  id: { type: String, required: true },
  name: { type: String, required: true },
  schemaVersion: { type: String, required: true },
  questionVersion: { type: String, required: true },
  previousVersionId: { type: String, required: true },
  authorId: { type: String, required: true },
  type: { type: String, required: true },
  difficultyLevel: { type: String, required: true },
  tags: { type: [String], required: true },
  content: {
    type: [
      {
        questionText: { type: String, required: true },
        answerOptions: { type: Array },
      },
    ],
  },
  creationTimeUTC: { type: Date, default: Date.now },
  lastUpdateCreationTimeUTC: { type: Date, default: Date.now },
  status: { type: String, default: "Draft" },
});

module.exports = mongoose.model("Question", questionSchema);
