function taskAssignment(k, tasks) {
    let output = [];
      let leftIdx = -1;
      let rightIdx = tasks.length;
      
      let sortedTaskIdxes = Array.from(Array(tasks.length).keys())
                    .sort((a, b) => tasks[a] < tasks[b] ? -1 : (tasks[b] < tasks[a]) | 0)
      
      for	(let i = 0; i < sortedTaskIdxes.length / 2; i++){
          leftIdx ++;
          rightIdx--;
          console.log(`The new indexes are: ${leftIdx}, ${rightIdx}`);
          output.push([sortedTaskIdxes[leftIdx], sortedTaskIdxes[rightIdx]])
      }
      console.log(output);
    return output;
  }
  
  // Do not edit the line below.
  exports.taskAssignment = taskAssignment;
  