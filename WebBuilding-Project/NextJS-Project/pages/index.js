import React, { Fragment } from "react";
import { MongoClient } from 'mongodb';  // execute only on the server 


//domain/
export default function HomePage(props){
    return (<Fragment>
        <h1>Hello World! - index ({props.data})</h1>
    </Fragment>);
}


/* Example *
export async function getStaticPaths(){     //for [path] route
    // paths goes from database
    return ({
        fallback: false //false == all paths contain supported values, for 'm3' user will receive error
        , paths: [
            { params:  {  meetupId: 'm1' } }
            , { params:  {  meetupId: 'm2' } }
        ]
    });
}
/* */

/* */
export async function getStaticProps(context){ //Static Generation //faster, cashier
    const {params} = context;
    const sportExampleId = params?.sportExampleId;
    

    const client = await MongoClient.connect(
        'mongodb+srv://legopart:WfHIGKcxMGsllNS4@cluster0.uwlwx.mongodb.net/deleteme'
    )
    const db = client.db();
    const meetupCollection = db.collection('meetups');
    const data = meetupCollection.find().toArray();


    // fetch or Api
    return ({
        props: {
            data: 'data' //"get data from Static Generation"
        }
        , revalidate: 10 //sec , 1hour == 3600 or 1 sec //incremental static generation
            //generate during the Build! + revalidate at least each 10 sec in the server if there is request for this page
 });
}
/* */


/* *
export async function getServerSideProps(context){ //SSR   //always on the server after deployment
    const {req, res} = context; //like auth !
    // fetch or Api
    return ({  props: {
            data: "get data from Server Side Rendering"
     }  });
}
/* */