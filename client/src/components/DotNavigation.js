import React from 'react';
import PropTypes from 'prop-types';

class DotNavigation extends React.Component {

  render() {
    let selectedIndex = this.props.selectedIndex;
    let arr = [...Array(this.props.count).keys()];
    let items = arr.map((index) => {
      return <li onClick={() => this.fireChange(index)} key={index.toString()} className={(selectedIndex === index) ? "current" : ""}><button>{index}</button></li>
    });

    return (
      <div className="dotnav">
        <ul>
          {items}
        </ul>
      </div>
    )
  }

  fireChange(index) {
    this.props.onChange(index);
  }

}

DotNavigation.propTypes = {
  count: PropTypes.number
}

export default DotNavigation
