const ROLES_LIST = {
  Owner: 8771,
  Admin: 7495,
  Editor: 5628,
  User: 4684,
};

const allowedOrigins = [
  "https://www.yoursite.com",
  "http://127.0.0.1:3000",
  "http://localhost:3000",
  "http://localhost:3001",
];

const corsOptions = {
  origin: (origin, callback) => {
    if (allowedOrigins.indexOf(origin) !== -1 || !origin) {
      callback(null, true);
    } else {
      callback(new Error("Not allowed by CORS"));
    }
  },
  optionsSuccessStatus: 200,
};

const credentials = (req, res, next) => {
  const origin = req.headers.origin;
  if (allowedOrigins.includes(origin)) {
    res.header("Access-Control-Allow-Credentials", true);
  }
  next();
};

module.exports = { credentials, corsOptions, ROLES_LIST };
