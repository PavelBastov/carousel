import React from 'react';

import DotNavigation from './components/DotNavigation';
import Picture from './components/Picture';

import Previous from './components/Previous';
import Next from './components/Next';

class App extends React.Component {

  constructor() {
    super();

    this.state =  {
      selectedIndex: 0,
      pictures: []
    }

    this.onChange = this.onChange.bind(this);
    this.onPrevious = this.onPrevious.bind(this);
    this.onNext = this.onNext.bind(this);
    this.onTimer = this.onTimer.bind(this);
  }

  render() {
    if (this.state.pictures && this.state.pictures.length > 0)
    {
      let url = this.state.pictures[this.state.selectedIndex].url;
      return (
        <div id="container">
          <Picture pictureUrl={url}/>

          <Previous onPrevious={this.onPrevious} />
          <Next onNext={this.onNext} />

          <DotNavigation count={this.state.pictures.length} selectedIndex={this.state.selectedIndex} onChange={this.onChange} />
        </div>
      )
    } else {
      return <h1>loading</h1>
    }
  }

  componentDidMount() {
    fetch("/api/pictures")
      .then(response => response.json())
      .then(data => this.setState({ pictures: data }));

    this.timer = setInterval(this.onTimer, 10 * 1000);
  }

  componentWillUnmount() {
    clearInterval(this.timer);
  }

  onChange(newIndex) {
    if (this.state.selectedIndex === newIndex) return;

    this.setState({ selectedIndex: newIndex });
  }

  onPrevious() {
    let index = this.state.selectedIndex === 0 ? this.state.pictures.length - 1 : this.state.selectedIndex - 1;
    this.setState({ selectedIndex: index });
  }

  onNext() {
    let index = this.state.selectedIndex === this.state.pictures.length - 1 ? 0 : this.state.selectedIndex + 1;
    this.setState({ selectedIndex: index });
  }

  onTimer() {
    this.onNext();
  }
}

export default App
