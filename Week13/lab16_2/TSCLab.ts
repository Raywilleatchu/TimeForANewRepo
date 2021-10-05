//Mountains
interface Mountain{
    name:string;
    height:number;
}

let allMountains:Mountain[] = 
[
    {name: 'Kilimanjaro', height: 19341},
    {name: 'Everest', height:29029},
    {name: 'Denali', height: 20310}
];

function findNameOfTallestMountain(mounts:Mountain[]):string{
    let tallest = 0;
    let nameOfTallest = '';
    for(let i = 0; i < mounts.length; i++)
    {
        if(mounts[i].height > tallest)
        {
            tallest = mounts[i].height;
            nameOfTallest = mounts[i].name;
        }
    }
    return nameOfTallest;
}

let tallestMountain = findNameOfTallestMountain(allMountains);
console.log(tallestMountain);

//Products
interface Product{
    name:string;
    price:number;
}

let allProducts:Product[] = 
[
    {name:'Keyboard', price: 39.99},
    {name:'Mouse', price: 25.99},
    {name: 'Monitor', price: 43.00}
]

function calcAverageProductPrice(prods:Product[]):number
{  
    let avgPrice:number;
    let current = 0;
    prods.forEach(p => 
    {
        current = p.price + current;
    });
    avgPrice = current/prods.length;
    return avgPrice;
}

let avgPrice = calcAverageProductPrice(allProducts);
console.log(avgPrice); //Should return 36.3...

//Inventory
interface InventoryItem{
    product:Product;
    quantity:number;
}

let allInventory:InventoryItem[] = 
[
    {product:allProducts[0], quantity: 10},
    {product:allProducts[1], quantity: 15},
    {product:allProducts[2], quantity: 20}
];


function calcInventoryValue(inv:InventoryItem[]):number
{
    let totalVal = 0;
    inv.forEach(i => 
        {
            totalVal = totalVal + (i.product.price * i.quantity);
        });
    return totalVal;
}


let inventoryValue = calcInventoryValue(allInventory);

console.log(inventoryValue); //should return 1649.75

