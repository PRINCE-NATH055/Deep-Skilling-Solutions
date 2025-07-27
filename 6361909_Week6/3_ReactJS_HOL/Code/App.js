import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name={"Prince Nath"} 
        School={"KIIT"} 
        total={284} 
        goal={3} 
      />
    </div>
  );
}

export default App;
