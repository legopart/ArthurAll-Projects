import React, { Fragment } from "react";
import { useRouter } from 'next/router';


//domain/sport/[dynamic page]           ,[dynamic page] === m1& m2
export default function HomePage(){
    const router = useRouter();
    const sportId = router.query.sportId;
    return (<Fragment>
        <h1>Hello World! - sport - {sportId}</h1>
    </Fragment>);
}


export async function getStaticPaths(){     //for [path] route
    // paths goes from database
    return ({
        fallback: false //false == all paths contain supported values, for 'm3' user will receive error
        , paths: [
            { params:  {  sportId: 'm1' } }
            , { params:  {  sportId: 'm2' } }
        ]
    });
}

export async function getStaticProps(context){ //Static Generation //faster, cashier
    const {params} = context;
    const sportExampleId = params?.sportExampleId;
    // fetch or Api
    return ({
        props: {
            data: "get data from Static Generation"
        }
        , revalidate: 10 //sec , 1hour == 3600 or 1 sec //incremental static generation
            //generate during the Build! + revalidate at least each 10 sec in the server if there is request for this page
 });
}