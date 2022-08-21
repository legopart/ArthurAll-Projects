import React, { Component } from "react"
import NavBar from "./components/navbar"
import Counters from "./components/counters.jsx"

class App extends Component {

    constructor(props){
        super(props);
        this.state = {
          counters: [
            { id: 1, value: 12 },
            { id: 2, value: 0 },
            { id: 3, value: 0 },
            { id: 4, value: 0 },
            { id: 5, value: 0 },
          ],
        }
        this.handleIncrement = (counter1) => {
          const counters = [...this.state.counters];
          const index = counters.indexOf(counter1);
          counters[index] = { ...counter1 } //add {id: *, value: *,
          counters[index].value++
          console.log("counter", counters[index])
          this.setState({ counters })
        }
        this.handleDelete = (counterId) => {
          const counters = this.state.counters.filter((c) => c.id !== counterId)
          this.setState( {counters} ) //counters: counters
          console.log("Event Handler Called", counterId)
        }
        this.handleReset = () => {
          const counters = this.state.counters.map((c) => { c.value = 0; return c; });
          this.setState( {counters} ); //counters: counters
        }
    }

  render() {
    return (
      <React.Fragment>
        <NavBar totalCounters={this.state.counters.filter((c) => c.value > 0).length} />
        <main className="container">
          <Counters
            data={{
              onReset: this.handleReset,
              onIncrement: this.handleIncrement,
              onDelete: this.handleDelete,
              counters: this.state.counters
            }}
          />
        </main>
      </React.Fragment>
    )
  }
}

export default App
