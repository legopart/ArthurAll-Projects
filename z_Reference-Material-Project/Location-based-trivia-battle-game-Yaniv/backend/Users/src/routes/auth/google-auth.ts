import express, { Request, Response } from 'express';
import { OAuth2Client } from "google-auth-library";
import jwt from "jsonwebtoken";
import  {User} from '../../models/user'
import { body } from 'express-validator';
import { validateRequest } from '../../middlewares/validate-request';
import { BadRequestError } from '../../errors/bad-request-error';

const router = express.Router();
const client = new OAuth2Client( "197031847913-ikgmujluer7f5bjng4bfpee43hsipl1q.apps.googleusercontent.com" );
router.post("/api/users/googlelogin", (req, res) => {
    const { tokenId } = req.body;
console.log(res)
console.log("dsf")
async (req: Request, res: Response) => {
  const { tokenId } = req.body;

  client.verifyIdToken({ idToken: tokenId, audience: "197031847913-ikgmujluer7f5bjng4bfpee43hsipl1q.apps.googleusercontent.com", })
  .then (async(response:any) => {
    const { email_verified, email } = response.payload;
    console.log({email})
    const googleUser = await User.findOne({ email });    

        // console.log(googleUser);
        if (!email_verified) 
          return res.status(400).json({ error: "Something went wrong", });

          if (googleUser) {
        const token = jwt.sign({ userId: googleUser.id }
          , "token"
          , { expiresIn: "5h", }
          );
        
          console.log("User has login!");
          return res.json({ token, userId: googleUser.id });
          }

        let password = email + "123";
        let newUser = new User({ email, password }).save();

        
        // Store it on session object
    

      });
    };  
  });

export {router as authGoogleRouter}