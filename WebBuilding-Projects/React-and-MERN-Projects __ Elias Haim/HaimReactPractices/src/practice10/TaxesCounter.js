import React, { Component } from "react";
class TaxesCounter extends Component {
  state = {
    name: "",
    phone: "",
    email: "",
    carsQuantity: 0,
    monthIncome: 0,
    result: ""
  };
  render() {
    const { name, phone, carsQuantity, monthIncome } = this.state;
    return (
      <div>
        <label for="name">Name:</label>{" "}
        <input
          onChange={(e) => {
            this.setState({ name: e.target.value });
          }}
          y
          id="name"
          type="text"
        />
        <br />
        <label for="phone">Phone:</label>{" "}
        <input
          onChange={(e) => {
            this.setState({ name: e.target.value });
          }}
          id="phone"
          type="tel"
        />
        <br />
        <label for="email">Email:</label>{" "}
        <input
          onChange={(e) => {
            this.setState({ phone: e.target.value });
          }}
          id="email"
          type="email"
        />
        <br />
        <label for="cars">Cars Quantity:</label>{" "}
        <input
          onChange={(e) => {
            this.setState({ carsQuantity: e.target.value });
          }}
          id="cars"
          type="number"
          min="0"
        />
        <br />
        <label for="income">Mounth Income:</label>{" "}
        <input
          onChange={(e) => {
            this.setState({ monthIncome: e.target.value });
          }}
          id="income"
          type="number"
          min="0"
        />
        <br />
        <button
          onClick={(e) => {
            this.setState({ result: resultReturn() });
          }}
        >
          Calculate
        </button>
        <hr />
        {this.state.result}
      </div>
    );

    function resultReturn() {
      return monthIncome <= 0 ? (
        <div>
          Sorry, you not having any incomes
          <br />
          <img alt="sorry" src="https://i.imgur.com/o3nXWTy.jpg" />
        </div>
      ) : (
        `Greetings ,${name}, ` +
          `Phone number ${phone} ` +
          `Your mounth income report  ${monthIncome}$ ` +
          `Taxes You have to pay ${
            monthIncome * (carsQuantity >= 2 ? 0.3 : 0.1)
          }$ `
      );
    }
  }
}

export default TaxesCounter;
