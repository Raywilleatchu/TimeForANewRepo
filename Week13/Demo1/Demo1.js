var b = 'Hello';
console.log(b);
var pet1 = {
    name: 'Sally',
    age: 2
};
console.log(pet1);
var allPets = [
    { name: 'Fred', age: 3 },
    { name: 'Julie', age: 4 },
    { name: 'Dylan', age: 5 }
];
function showPet(thepet) {
    console.log("Name: " + thepet.name + " Age: " + thepet.age);
}
//showPet(allPets[1]);
function findOldest(pets) {
    var biggestAge = 0;
    var currentName = '';
    for (var i = 0; i < pets.length; i++) {
        if (pets[i].age > biggestAge) {
            biggestAge = pets[i].age;
            currentName = pets[i].name;
        }
    }
    return currentName;
}
console.log(findOldest(allPets));
//or//
var oldestName = findOldest(allPets);
console.log(oldestName);
