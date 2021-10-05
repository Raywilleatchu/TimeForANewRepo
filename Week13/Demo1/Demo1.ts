interface Pet
{
    name: string;
    age: number;
}

let b = 'Hello';
console.log(b);

let pet1:Pet = {
    name: 'Sally',
    age: 2
}

console.log(pet1);


let allPets:Pet[] = [
    {name: 'Fred', age: 3},
    {name: 'Julie', age: 4},
    {name: 'Dylan', age: 5}
];

function showPet(thepet: Pet){
    console.log(`Name: ${thepet.name} Age: ${thepet.age}`);
}

//showPet(allPets[1]);

function findOldest(pets: Pet[]):string
{
    let biggestAge: number = 0;
    let currentName: string = '';
    for(let i = 0; i<pets.length; i++)
    {
        if(pets[i].age > biggestAge){
            biggestAge = pets[i].age;
            currentName = pets[i].name;
        }
    }
    return currentName;
}

console.log(findOldest(allPets));
//or//
let oldestName: string = findOldest(allPets);
console.log(oldestName);