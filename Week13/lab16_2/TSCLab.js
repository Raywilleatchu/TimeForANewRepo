var allMountains = [
    { name: 'Kilimanjaro', height: 19341 },
    { name: 'Everest', height: 29029 },
    { name: 'Denali', height: 20310 }
];
function findNameOfTallestMountain(mounts) {
    var tallest = 0;
    var nameOfTallest = '';
    for (var i = 0; i < mounts.length; i++) {
        if (mounts[i].height > tallest) {
            tallest = mounts[i].height;
            nameOfTallest = mounts[i].name;
        }
    }
    return nameOfTallest;
}
var tallestMountain = findNameOfTallestMountain(allMountains);
console.log(tallestMountain);
var allProducts = [
    { name: 'Keyboard', price: 39.99 },
    { name: 'Mouse', price: 25.99 },
    { name: 'Monitor', price: 43.00 }
];
function calcAverageProductPrice(prods) {
    var avgPrice;
    var current = 0;
    prods.forEach(function (p) {
        current = p.price + current;
    });
    avgPrice = current / prods.length;
    return avgPrice;
}
var avgPrice = calcAverageProductPrice(allProducts);
console.log(avgPrice); //Should return 36.3...
var allInventory = [
    { product: allProducts[0], quantity: 10 },
    { product: allProducts[1], quantity: 15 },
    { product: allProducts[2], quantity: 20 }
];
function calcInventoryValue(inv) {
    var totalVal = 0;
    inv.forEach(function (i) {
        totalVal = totalVal + (i.product.price * i.quantity);
    });
    return totalVal;
}
var inventoryValue = calcInventoryValue(allInventory);
console.log(inventoryValue); //should return 1649.75
