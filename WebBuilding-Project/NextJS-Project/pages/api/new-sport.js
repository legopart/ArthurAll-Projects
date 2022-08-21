import { MongoClient } from 'mongodb';


// POST /api/new-meetup
async function handler(req, res){
    const { method } = req;
    if (method === 'POST' ){
        const data = req.body;
        const {title, image, address, description} = data;
            const client = MongoClient.connect('mongodb+srv://legopart:WfHIGKcxMGsllNS4@cluster0.uwlwx.mongodb.net/deleteme');
            const db = client.db();

            const sportsCollection = db.collection('sports');
            const result = await sportsCollection.insertOne({data})


            //add error handler!
            console.log(/*result*/)

            client.close();
            res.status(201).json({message: "ok ..."})
    }
}