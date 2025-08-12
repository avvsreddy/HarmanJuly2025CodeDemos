import { useState } from "react";

function Counter()
{
    //let counter = 10;
    let [counter,setCounter] = useState(1);
    console.log("usestate returns: ",counter);
    function increment()
    {
        //counter = counter + 1;
        setCounter(c => c = c + 1)
        console.log("counter: ",counter)
    }
    function decreament()
    {
      setCounter(c => c = c - 1);
    }

  return (
    <div>
      <h1>Welcome to Counter App</h1>
        <h1>{counter}</h1>
        <button onClick={increment}>+1</button>
        <button onClick={decreament}>-1</button>
    </div>
  )
}

export default Counter