const mongoose = require("mongoose");

const testSchema = mongoose.Schema({
  messageType: { type: String, required: true },
  id: { type: String, required: true },
  title: { type: String, required: true },
  schemaVersion: { type: String, required: true },
  testVersion: { type: String, required: true },
  previousVersionId: { type: String, required: true },
  authorId: { type: String, required: true },
  description: { type: String, required: true },
  tags: { type: [String], required: true },
  questions: { type: [String], required: true },
  creationTimeUTC: { type: Date, default: Date.now },
  lastUpdateCreationTimeUTC: { type: Date, default: Date.now },
  status: { type: String, default: "Draft" },
});

module.exports = mongoose.model("Test", testSchema);
