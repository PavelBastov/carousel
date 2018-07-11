import React from 'react';

const Picture = (props) => {
  var divStyle = {
    backgroundImage: 'url(' + props.pictureUrl + ')'
  };
  return <div className="picture" style={divStyle}></div>
}

export default Picture
