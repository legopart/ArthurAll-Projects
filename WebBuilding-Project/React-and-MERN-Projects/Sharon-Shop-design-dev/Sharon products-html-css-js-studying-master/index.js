import { Product } from "./product.js";
import { productsList } from "./productsLis.js";
import { carsList } from "./carsLis.js";

$(document).ready(function () {
  setItems();

  $(".form-select").click(function(){
    setCarsBrands();
  })

  $("#addBtn").click(function () {
    addNewItem();
  });
});

function setItems() {
  let itemsContainer = $("#itemsArea");
  itemsContainer.empty();

  itemsContainer.append("<div class='row'></div>");
  let row = $(".row");
  row.append(buildItemsElement(productsList));
}

function buildItemsElement(itemsList) {
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

function validate() {}

function addNewItem() {
  let name = $("#name").val();
  // let brand = $("#brand").val();
  let brand = $(".form-select").val();
  let price = $("#price").val();
  let category = $("#category").val();
  let img = $("#img-url").val();
  const newProduct = new Product(name, brand, price, category, img);
  productsList.push(newProduct);
  setItems();
}

function setCarsBrands() {
  $.each(carsList, function (index, value) {
    $(".form-select").append($("<option/>", {
      value: value,
      text: value,
      })
    );
  });
}
