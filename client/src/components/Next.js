import React from 'react';

const Next = (props) => {
  return <div className="next"><span className="chevron right" onClick={() => props.onNext()}></span></div>
}

export default Next
