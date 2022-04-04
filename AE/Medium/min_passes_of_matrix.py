from copy import deepcopy

def minimumPassesOfMatrix(matrix):
    # -2 = untraversed
    # -1 = traversed, negative
    # 1 = traversed, positive
    # 0 = zero 

    signMap = [[-2] * len(matrix[0]) for row in matrix]
    height = len(matrix)
    width = len(matrix[0])

    passes = 0
    foundNeg = False

    while (passes < 100): # prevent infinite loop
        conversions = []
        for i, row in enumerate(matrix):
            for j, val in enumerate(row):
                sign = -1 if val < 0 else (1 if val > 0 else 0)
                if (sign == -1): foundNeg = True
                signMap[i][j] = sign
                if (sign > 0):
                    # left
                    if j > 0 and matrix[i][j - 1] < 0:
                        signMap[i][j - 1] = 1
                        conversions.append([i, j - 1])
                        foundNeg = True
                    # top
                    if i > 0 and matrix[i - 1][j] < 0:
                        signMap[i - 1][j] = 1
                        conversions.append([i - 1, j])
                        foundNeg = True
                    # right
                    if j < width - 1 and matrix[i][j + 1] < 0:
                        signMap[i][j + 1] = 1
                        conversions.append([i, j + 1])
                        foundNeg = True
                    # bottom
                    if i < height - 1 and matrix[i + 1][j] < 0:
                        signMap[i + 1][j] = 1
                        conversions.append([i + 1, j])
                        foundNeg = True
        if (foundNeg == False):
            print(f"Conveted all negatives: {signMap}")
            return passes
        elif (len(conversions) > 0):
            passes += 1
            foundNeg = False
            for conversion in conversions:
                matrix[conversion[0]][conversion[1]] = abs(matrix[conversion[0]][conversion[1]])
            print(f"Discovered convertable cells conducted in pass #{passes}: {conversions}")
        else:
            print(f"Could not convert all negatives: {signMap}")
            return -1