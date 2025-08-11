
// // old way
// var name ='Ramesh';
// console.log(name);

// // new way
// let name2 = "Girish";
// console.log(name2);
// let age;
// age = 25;
// age = 26;

// const code = 123;
// //code = 345;


// function add(a, b){
//     return a+b;
// }
// console.log(add(10,20));

// const sum = function(a,b){return a+b} // Anonymous functions
// console.log(sum(10,20));

// // Arrow functions
// const sum2 = (a,b) => {return a+b}
// console.log(sum2(10,20));

// const sum3 = (a,b) =>  a+b;
// const a = 10;
// const b = 20;
// const result = sum3(a,b);

// console.log("the sum of " + a + " and "+ b +" is "+ result  )
// console.log(`the sum of ${a} and ${b} is ${result}`)
// //console.log(sum3(10,20));

// // Destructuring

// const names = ['Rajesh','Girish','Somesh'];
// const name1 = names[0];
// const name2 = names[1];
// const country = names[0].country
// console.log(name1,name2);

// const [name11,name22,name33] = names;
// console.log(name11, name22, name33);

// objects

// const person = {
//     name:'Ramesh',
//     age:25,
    
//     address: {
//         location:'Bangalore',
//         country:'India'
//     }
// }
// // const name = person.name;
// // const age = person.age;
// // const location = person.location;

// const {name,age,address:{location,country}} = person;

// console.log(name, age, location,country);

// spread operation, rest

// const numbers = [1,2,3];
// numbers.push(4);
// const newNumbers = [...numbers,5];
// console.log("normal ", numbers)
// console.log("Spread operation " ,...newNumbers);

//

// let number1 = [1,2,3];
// let number2 = [4,5,6];

//let number4 = number1.concat(number2);
// let number4 = [...number1,...number2];
// console.log(...number4);

// function sum(a,b){
//     return a+b;
// }
// function sum(a,b,c){
//     return a+b+c;
// }
// function sum(a,b,c,d){
//     return a+b+c+d;
// }

// function sum(a,b,c,...numbers){
//     console.log(numbers)
// }
// console.log(sum(1,2,3,4,5,6,7,8,9));

// map reduce, filter...

// const names = ['Rajesh','Girish','Somesh'];

// let nameslist = [];
// for(let i=0;i<names.length;i++)
//     {
//         nameslist.push(convertToUpper(names[i]))
//     } 


// const upperNames = names.map(convertToUpper)
// const upperNames = names.map(function(name) {return name.toUpperCase();});
// const upperNames = names.map(name => {return name.toUpperCase();});
// const upperNames = names.map(name => name.toUpperCase());
// console.log(upperNames)

// function convertToUpper(name){
//     return name.toUpperCase()
// }


 const numbers = [1,2,3,4,5];

// let sum = 0;
// numbers.forEach(n => sum = sum + n);

// console.log(sum);

// const tot = numbers.reduce((total,value) => total = total * value,1);
// console.log(tot);

// const bigger = numbers.filter(currentValue => {return currentValue >= 3});
// const bigger = numbers.filter(currentValue => currentValue >= 3);
// console.log(bigger);

// Array map, reduce, forEach, filter
// function greet(name='unknown') {
//   console.log(`Hello ${name}`);
// }

// greet();


// let person = {};

// console.log(person);
// class Person {
//   constructor(name) 
//   { this.name = name; }
//   greet() { console.log(`Hi, I'm ${this.name}`); }
// }

// class Product
// {
//     //name=''
//     //price=0
//     constructor(name,price){
//        this.name = name;
//        this.price = price; 
//     }
// }
// let p = new Product('I Phone',60000);
// console.log(p.name, p.price);
