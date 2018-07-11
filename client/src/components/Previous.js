import React from 'react';

const Previous = (props) => {
  return <div className="previous"><span className="chevron left" onClick={() => props.onPrevious()}></span></div>
}

export default Previous
