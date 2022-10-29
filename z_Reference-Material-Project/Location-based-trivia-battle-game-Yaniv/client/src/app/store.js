import { configureStore } from "@reduxjs/toolkit";
import authReducer from "../features/auth/authSlice";
import gameReducer from "../features/game/gameSlice";
import quizReducer from "../features/quiz/quizSlice";

export const store = configureStore({
  reducer: {
    auth: authReducer,
    game: gameReducer,
    quiz: quizReducer,
  },
});
