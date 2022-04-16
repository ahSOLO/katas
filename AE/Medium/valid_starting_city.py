def validStartingCity(distances, fuel, mpg):
    potentialCities = [True] * len(distances)
    cityIdx = 0
    currentSupply = 0
    
    for i, val in enumerate(fuel):
        cityFuel = val * mpg
        citySurplus = cityFuel - distances[i];
        currentSupply = currentSupply + cityFuel - distances[i]
        print(f"Current City: {cityIdx}, traveling through city {i}, current supply:{currentSupply}")
        if (citySurplus < 0):
            potentialCities[i] = False
            print(f"Omitting city {i} since it does not have a positive surplus")
        if (currentSupply < 0):
            citiesTraversed = i - cityIdx
            i = 0;
            while i < citiesTraversed:
                potentialCities[cityIdx + i] = False
                i += 1
            print(f"Omitting city {cityIdx} since its route resulted in a negative supply")
            cityIdx = next(i for i, city in enumerate(potentialCities) if city == True)
            currentSupply = 0
        
    return cityIdx