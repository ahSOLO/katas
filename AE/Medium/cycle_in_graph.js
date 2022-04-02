function cycleInGraph(edges) {
  let checkedVertices = new Set();
  let cycleFound = false;

  for (let i = 0; i < edges.length; i++) {
    if (!checkedVertices.has(i)) {
      let inPotentialCycle = new Array(edges.length).fill(false);
      console.log(`Initial traversal of vertex ${i}`);
      cycleFound = traverse(edges, checkedVertices, inPotentialCycle, i, 0);
      if (cycleFound) {
        console.log("Cycle found, breaking initial loop.");
        break;
      }
    }
  }
  return cycleFound;
}

function traverse(edges, checkedVertices, inPotentialCycle, start, pathLength) {
  console.log(`Adding vertex ${start} to checked vertices`);

  checkedVertices.add(start);
  inPotentialCycle[start] = true;

  const vertex = edges[start];
  let cycleFound = false;
  vertex.some(edge => {
    if (inPotentialCycle[edge]){
      console.log(`Cycle has been found with vertex ${edge}`);
      cycleFound = true;
      return true;
    }
    else if (!checkedVertices.has(edge)) { // Check for this second to catch self loops
      console.log(`Recursive traversal from vertex ${start} to vertex ${edge}`);
      cycleFound = traverse(edges, checkedVertices, inPotentialCycle, edge, pathLength + 1);
      if (cycleFound) {
        return true;
      } else {
        inPotentialCycle[edge] = false;
        return false;
      }
    }
  });
  return cycleFound;
}

// Do not edit the line below.
exports.cycleInGraph = cycleInGraph;
