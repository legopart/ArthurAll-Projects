import { productsList } from "./productsLis.js";
import { Product } from "./product.js";

$(document).ready(function () {
  $("#addBtn").click(function () {
    addItem();
  });

  setItems();
});

// function setItems() {
//   let itemsContainer = $("#itemsArea");
//   itemsContainer.empty();

//   let counter = 0;
//   let currentRowNumber = 0;
//   let selectedRowDiv = "";

//   for (let item of productsList) {
//     let img = "<img class='item' src='" + item.image + "'>";
//     let name = "<p>" + item.name + "</p>";
//     let brand = "<p>" + item.brand + "</p>";
//     let price = "<p>" + item.price + "</p>";
//     let category = "<p>" + item.category + "</p>";
//     let p = img + name + brand + price + category;
//     let newItem = "<div class='col-3'>".concat(p, "</div>");

//     if (counter === 0 || counter === 4) {
//       currentRowNumber++;
//       let rowId = "row" + currentRowNumber;
//       let createdRow = "<div id='" + rowId + "' class='row'></div>";
//       selectedRowDiv = "#" + rowId;
//       itemsContainer.append(createdRow);

//       if (counter === 3) {
//         counter = 0;
//       }
//     }

//     $(selectedRowDiv).append(newItem);
//     counter++;
//   }
// }

function setItems() {
  let itemsContainer = $("#itemsArea");
  itemsContainer.empty();

  itemsContainer.append("<div class='row'></div>");
  let row = $(".row");
  row.append(buildItemElement(productsList));

  // for (let item of productsList) {
  //   let img = "<img class='item' src='" + item.image + "'>";
  //   let name = "<p>" + item.name + "</p>";
  //   let brand = "<p>" + item.brand + "</p>";
  //   let price = "<p>" + item.price + "</p>";
  //   let category = "<p>" + item.category + "</p>";
  //   let p = img + name + brand + price + category;
  //   let newItem = "<div class='col-3'>".concat(p, "</div>");

  //   row.append(newItem);
  // }
}

function buildItemElement(itemsList) {
  let elemetsList = "";

  for (let item of itemsList) {
    let img = "<img class='item' src='" + item.image + "'>";
    let name = "<p>" + item.name + "</p>";
    let brand = "<p>" + item.brand + "</p>";
    let price = "<p>" + item.price + "</p>";
    let category = "<p>" + item.category + "</p>";
    let p = img + name + brand + price + category;
    let newItem = "<div class='col-3'>".concat(p, "</div>");
    elemetsList += newItem;
  }
  return elemetsList;
}

function addItem() {
  let name = $("#name").val();
  let brand = $("#brand").val();
  let price = $("#price").val();
  let category = $("#category").val();
  let img = $("#img-url").val();
  let itemsContainer = $("#itemsArea");
  const newProduct = new Product(name, brand, price, category, img);
  productsList.push(newProduct);
  setItems();
}
