'grid sample for input
'_____________
'| 7 | 8 | 9 |
'| 4 | 5 | 6 |
'| 1 | 2 | 3 |
'------------



dim isP1Turn as boolean = true

dim fullGrid(2,2) as int 'values for grid: 0 = empty, 1 = player1, 2 = player 2

sub resetGrid()
	console.writeline("starting game")
	 for i = 0 to 2
    for k = 0 to 2
		fullGrid(i,k) = 0
		next 
  next
end sub

sub Main()
	while true
		console.writeline("tic tac toe game")
		if someoneWon() <> 0 then
			resetGrid()
		end if
		if allSquaresOccupied() then
			resetGrid()
		end if
console.write("is ")
if isP1Turn then
	console.writeline("P1")
else
	console.writeline("P2")
end if
console.writeline("'s turn")
			Playerturn()
	end while
end sub

function someoneWon() as int '0 = no one, 1 = player1, 2 = player 2
'check vertical horizontal diagonal
'vertical comparison 3 times
'horizontal comparison 3 times
'diagonal comparison 2 times
'check 1st square value of comparison and check if the other 2 are the same
	 dim current = 0 'know which player has 1 space filled to start comparing
	 dim points = 0 'must be 2 points to win
	
	'vertical comparison
		for x = 0 to 2 'horizontal
	 if fullGrid(x,0) = 0 then continue for 'first block in column is empty
	 current = fullGrid(x,0) 
	 for y = 1 to 2 'vertical
	  if fullGrid(x,y) = current then points += 1
	 next
	 if points = 2 then
	  console.writeline($"won {current}")
	  return current
	 end if
	 
	points = 0 ' reset because didn't won
	next
	
	
	'horizontal comparison
	for y = 0 to 2 'vertical
	 if fullGrid(0,y) = 0 then continue for 'first block in row is empty
	 current = fullGrid(0,x) 
	 for x = 1 to 2 'horizontal
	  if fullGrid(x,y) = current then points += 1
	 next
	 if points = 2 then
			console.writeline($"won {current}")
	 return current
	 end if
	 
		points = 0 ' reset because didn't won
	next
	
	'diagonal comparison
	
	 if fullGrid(0,0) = 0 then
	 current = fullGrid(0,0)
	 for xy = 1 to 2 'diagonal
	  if fullGrid(xy,xy) = current then points += 1
	 next
	 if points = 2 then
	  console.writeline($"won {current}")
	  return current
	 end if
	 
	points = 0 ' reset because didn't won
	
	'diagonal comparison 2
	 if fullGrid(0,2) = 0 then
	 current = fullGrid(0,2) 1,1 2,0
	 for xy = 1 to 2 'diagonal
	  if fullGrid(xy,2 - xy) = current then points += 1
	 next
	 if points = 2 then
	  console.writeline($"won {current}")
	  return current
	 end if
	 
	return 0 'no one won
end function


sub Playerturn()
	
  ' enter digit to specify block,  input 1-9
	' if not 1-9 then goto readKey()
	' check if specified not is occupied
	' if occupied then go back to enter digit
	'else mark block with player icon: assign 1 for P1, 2 for P2 in grid specified
	'
	while true
		if getKeySuccessful() then exit while
	end while
end sub
  
function getKeySuccessful() as boolean
	'mark grid: values entered
	' 1-3 y: 2 
	' 4-6 y: 1
	' 7-9 y: 0
	' 1,4,7 x: 0
	' 2,5,8 x: 1
	' 3,6,9 x: 2
					
console.writeline("enter digit for block: ")
dim keyEntered as int = console.readKey()
keyEntered -= 48 'to match with numbers
					
1select case keyEntered
					case 1 to 3 
		y = 2	
					case 4 to 6
		y = 1
					case 7 to 9
		y = 0
end select
	
select case keyEntered
case 1,4,7 
 x = 0	
case 2,5,8
 x = 1
case 3,6,9
 x = 2
end select
	
	if fullGrid(x,y) <> 0 then
						'wrong entry already occupied
			return false
	else
			if isP1Turn then
							fullGrid(x,y) = 1 'mark block for P1
			 else
							fullGrid(x,y) = 2 'mark block for P2
	end if
			 return true
	end if
end function

  function  allSquaresOccupied() as boolean
   for i = 0 to 2
    for k = 0 to 2
		if fullGrid(i,k) = 0 then return false
		next 
  next
				console.writeline("all squares were occupied")
  return true
  end function
  
  
