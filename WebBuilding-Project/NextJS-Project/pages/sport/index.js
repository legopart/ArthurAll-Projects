import React, { Fragment } from "react";
import  Link  from 'next/link';
import { useRouter } from 'next/router';

//domain/sport/
export default function HomePage(){
    const router = useRouter();
    function redirect(){ router.push('/'+'/sport/'+'item_dsgsdgsd'); }
    return (<Fragment>
        <h1>Hello World! - sport</h1>
        <Link href='sport/details'>Details</Link>   {/* single page application link */}
        {/*
        
            inside function can use:
            router.push('/')    for redirect without back button
            router.replace('/') can back with button <-
        */}


    <button onClick={() => redirect()}>Details</button>
    </Fragment>);
}
