import React, { Component } from "react"
//import logo from './logo.svg';
//import './App.css';
import NavBar from "./components/navbar"
//import 'bootstrap/dist/css/bootstrap.min.css';  //done on index!!!!
import Counters from "./components/counters.jsx"
//import { render } from '@testing-library/react';

class App extends Component {
  state = {
    counters: [
      { id: 1, value: 12 }, //, onDelete: this.id do foreach for each onDelete Add
      { id: 2, value: 0 },
      { id: 3, value: 0 },
      { id: 4, value: 0 },
      { id: 5, value: 0 },
    ],
  }

  handleIncreament = (counter) => {
    const counters = [...this.state.counters]
    const index = counters.indexOf(counter)
    counters[index] = { ...counter } //add {id: *, value: *,
    counters[index].value++
    console.log("counter", counters[index])
    this.setState({ counters })
  }

  handleDelete = (counterId) => {
    const counters = this.state.counters.filter((c) => c.id !== counterId)
    this.setState({ counters }) //counters: counters
    console.log("Event Handler Called", counterId)
  }

  handleReset = () => {
    const counters = this.state.counters.map((c) => {
      c.value = 0
      return c
    }) //לחזור
    this.setState({ counters }) //counters: counters
  }

  render() {
    return (
      //<Counters></Counters>

      <React.Fragment>
        <NavBar
          totalCounters={this.state.counters.filter((c) => c.value > 0).length}
        />
        <main className="container">
          <Counters
            onReset={this.handleReset}
            counters={this.state.counters}
            onIncrement={this.handleIncreament}
            onDelete={this.handleDelete}
          />
        </main>
      </React.Fragment>
    )
  }
}

export default App
