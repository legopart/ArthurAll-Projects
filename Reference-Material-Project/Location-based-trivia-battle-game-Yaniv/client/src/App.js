import { Suspense } from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import * as React from "react";
import HomeScreen from "./screens/HomeScreen";
import SignupScreen from "./screens/SignupScreen";
import LoginScreen from "./screens/LoginScreen";
import ProfileScreen from "./screens/ProfileScreen";
import GameLobbyScreen from "./screens/GameLobbyScreen";
import InviteUsers from "./screens/InviteUsers";
import BetweenQuestions from "./screens/BetweenQuestions";
import GameRoomScreen from "./screens/GameRoomScreen";
import WaitingRoomScreen from "./screens/WaitingRoomScreen";
import LoadingGameScreen from "./screens/LoadingGameScreen";
import EndGame from "./screens/EndGame";
import EndGameScreen from "./screens/EndGameScreen";
import ExpertApplication from "./components/ExpertApplication";
import SugestQuestion from "./screens/SugestQuestion";

function App() {
  return (
    <Suspense fallback={null}>
      <Router>
        <div className="container">
          <Routes>
            <Route path="/" element={<HomeScreen />} />
            <Route path="/login" element={<LoginScreen />} />
            <Route path="/signup" element={<SignupScreen />} />
            <Route path="/profile" element={<ProfileScreen />} />
            <Route path="/gamelobby" element={<GameLobbyScreen />} />
            <Route path="/waitingroom/:id" element={<WaitingRoomScreen />} />
            <Route path="/loadinggame/:id" element={<LoadingGameScreen />} />
            <Route path="/gameroom/:id" element={<GameRoomScreen />} />
            <Route path="/inviteUsers" element={<InviteUsers />} />
            <Route path="/betweenQuestions" element={<BetweenQuestions />} />
            <Route path="/endGame" element={<EndGame />} />
            <Route path="/endGamescreen" element={<EndGameScreen />} />
            <Route path="/ExpertApplication" element={<ExpertApplication />} />
            <Route path="/sugest" element={<SugestQuestion />} />
          </Routes>
        </div>
      </Router>
    </Suspense>
  );
}

export default App;
