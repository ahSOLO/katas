import copy
from enum import Enum
class Direction(Enum):
  	NORTH = 1
  	EAST = 2
  	SOUTH = 3
  	WEST = 4

def removeIslands(matrix):
	height = len(matrix)
	width = len(matrix[0])
	output = copy.deepcopy(matrix)
	
	if (width < 2 or height < 2):
		return matrix
	
	checkEdges(output)
		
	i = 0
	j = 0
	while (i < height):
		while (j < width):
			if (output[i][j] == 2):
        output[i][j] = 1
      else:
        output[i][j] = 0
			j += 1
		i += 1
		j = 0
	return output

def checkEdges(matrix):
	height = len(matrix)
	width = len(matrix[0])
	i = 0
	while (i < height):
			checkNeighbors(matrix, i, 0, 2, None)
			checkNeighbors(matrix, i, width - 1, 2, None)
			i += 1
	j = 1
	while (j < width - 1):
			checkNeighbors(matrix, 0, j, 2, None)
			checkNeighbors(matrix, height - 1, j, 2, None)
			j += 1
		

def checkNeighbors(matrix, i, j, outputVal, checkDirection):
	if (matrix[i][j] == 1):
		matrix[i][j] = outputVal
    print(f"cell at {i}, {j} has been modified to have value {outputVal}")
	else:
		return
	#North
	if (checkDirection != Direction.SOUTH and i - 1 >= 0):
    	checkNeighbors(matrix, i - 1, j, outputVal, Direction.NORTH)
	#East
	if (checkDirection != Direction.WEST and j + 1 < len(matrix[i])):
    	checkNeighbors(matrix, i, j + 1, outputVal, Direction.EAST)
	#South
	if (checkDirection != Direction.NORTH and i + 1 < len(matrix)):
		checkNeighbors(matrix, i + 1, j, outputVal, Direction.SOUTH)
	#West
	if (checkDirection != Direction.EAST and j - 1 >= 0):
		checkNeighbors(matrix, i, j - 1, outputVal, Direction.WEST)
