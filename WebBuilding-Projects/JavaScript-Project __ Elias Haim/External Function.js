
function add(x, y){return x + y;}
function multiple(x, y){return x * y;}

function action(data1, data2, externalFunction){
    return externalFunction(data1, data2);
}

console.log( 'returned: ', action.(2, 5, add) ); // 2 + 5 = 7

function actionCuring(data1, data2){
    return function(externalFunction){
            return externalFunction(data1, data2);
    }
}
console.log( 'returned: ', actionCuring(2, 5)(add) ); // 2 + 5 = 7



console.log( 'returned: ',
    action( 4, 5, function anonymous(x, y){return ( multiple(x, y) + add(x, 3) + ' Hello from External Anonymous');} )
     );     //returned 27 (4*5 + 4+3 + "Hello from Ext...")

let math = add;

console.log( 'returned: ',
    action( 4, 5, math )
     );     //returned 9 ( 4+5 )
