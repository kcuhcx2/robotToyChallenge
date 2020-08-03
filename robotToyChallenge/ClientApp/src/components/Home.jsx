import React, { Component } from 'react';

export class Home extends Component {

  constructor(props){
      super(props);
  
      this.state = {
        robotCoordinates: {}
      };
  }

  componentDidMount(){
    fetch("https://localhost:5001/coordinate").then((response) =>
      this.state.robotCoordinates = response
    )
  }

  render () {
    return (
      <div>
        <p>{JSON.stringify(this.state.robotCoordinates)}</p>
      </div>
    );
  }
}
