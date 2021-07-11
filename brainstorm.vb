'brainstorm file

function gameOver() as boolean

end function

sub drawBoardOnScreen() 
  'grid is 64 squares (8x8)
  ' how draw on console
end sub

sub initializePieces()
  '12 pieces per player
end sub

sub movePiece()
  'player 1 moves up
  'player 2 moves down
  
  'pieces 'move diagonal
  'p1 moves y - 1 x +- 1
  'p2 moves y + 1 x +- 1
  'unless x is zero or x is 7
  'p1 can move unless y is zero
  'p2 can move unless y is 7
  'king can move x +- 1 and y +- 1
end sub

sub eatEnemy()
  'if p1 then if y - 1 and (x - 1 or x + 1) is enemy
  'then if y - 2 and (x - 2 or x + 2) is free
  'then can eat and have to discard enemy
end sub

sub eatEnemyByKing()
  'if p1 then if y - 1
end sub

function squareEmpty(piece(,) as int) as boolean
  'for the piece, the x and y are specified
  'or a pice can be specified as an instance
end function

class grid
  class square() 
    dim xLocation as integer = 0 
    dim yLocation as integer = 0
    dim occupied as boolean = false
    dim belongsToP1 as boolean = false
  sub new(xLocation, yLocation, occupied, belongsToP1)
      xLocation
      yLocation
      occupied
      belongsToP1
  end sub
  end class 'sqwuare
  
  dim row as new list(of square)
  dim rows as new list(of row)
  
end class
