USE Citizens
SELECT
	 p.FirstName + ' ' + p.LastName AS Name, a.AddressText AS Address, t.Name AS Town, c.Name AS Country, cont.Name AS Continent
		FROM People p
			JOIN Addresses a
				ON p.AddressID = a.AddressID
			JOIN Towns t							
				ON a.TownID = t.TownID				
			JOIN Countries c						
				ON t.CountryID = c.CountryID		
			JOIN Continents cont					
				ON c.ContinentID = cont.ContinentID	
													