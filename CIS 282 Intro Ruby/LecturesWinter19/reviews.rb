#     Create a 8x8 playing grid(double array)
#     Print out the playing board
#     Print out the players menu to choose a token.
#     Once the menu is printed user picks what column it goes into 1 - 8
#     The token slides to the bottom of the playing grid.(row/column/cell)
#     Once the user picks create a random number 1-8 for the computer to select a token.
#     Then we clear the screen and reprint the board so they can choose again to place a token.
#     Once the players have played we need to check each time for a win and tokens placed outside of the game.(1-8)
#     Users can win by going diagonal / horizontal / vertical.
#     Once the player wins the game display the win.


# clears the screen, joins the array and prints the grid.
# Join returns a string created by converting each element of the array to a string.

def print_grid(grid)
  system('cls')
  puts "1 2 3 4 5 6 7 8"
  grid.each do |row|
    puts row.join(" ")
  end
end


# While loop is false to get into the while loop if user selected less than 1 or greater than 8
# reprints the selection for the user to select correct number. Once correct number selected return - 1

def player_input
  correct_input = false
  puts "Please select a column number 1 - 8:"
  user_selected = gets.to_i
  while correct_input === false
    if user_selected < 1 || user_selected > 8
      puts "You selected #{user_selected}. Please select a column number 1 - 8:"
      user_selected = gets.to_i
    else
      return user_selected - 1
    end
  end
end


# token = player and user_selection = selection can actually not be used same result will occur because they are args


def position_check(selection, player, connect_four)
  # Didn't need to declare this variable check_winner but it made it easier to follow the code.
  check_winner = false
  # Didn't need to declare token = player because player would suffice made it easier to follow in the code.
  token = player
  # taken = true set to true so it gets us in the while loop.
  taken = true
  # set the row to 7 so the piece can drop to the bottom of the array game.
  row = 7
  # User_selection = selection declared this variable to make it easier to follow in the code.
  user_selection = selection
  # If token is 1 then that is the first player any other player would be O
  if token == 1
    token = "X"
  else
    token = "O"
  end
  # Taken = true get us into the while loop.
  while taken == true
    # if user selection is less than 0 call on player input to reprint selection and reset the row to 7.
    # Checks for an error
    if row < 0
      user_selection = player_input
      row = 7
      # If the user places a piece and a token(X or O) exists move up the row.
      # If it is "." (empty spot) move to the else.
      # checks for a token
    elsif connect_four[row][user_selection] != "."
      row -= 1
    else
      # So if user selects a spot in which a token can go place the token.
      # place token
      connect_four[row][user_selection] = token
      # breaks out of the while loop
      taken = false
      # checks for winner so the game doesn't infinitely loop.
      check_winner = check_win(user_selection, token, connect_four, row)
    end
  end
  # If this is false then in the main loop continue the game if true end game.
  return check_winner
end


def check_horizontal(selection, token, connect_four, row)
  left_select = selection
  right_select = selection
  # This is just to follow the code.
  horizontal_win = false
  # After checking for winner it always ended on 3 so I just did -1 and it worked.
  total_tokens = -1
  # Gets us in the while loop
  equals_token_left = true
  # Gets us in the while loop
  equals_token_right = true
  while equals_token_left == true
    # checks to see if it is outside of the array.
    # if the first piece player enters is 5 selection would = 4 because we - 1 the piece.
    # Which is not less than 0 moves to the else statement. And since token exists run the code in the if statement.
    # It will go back to the selection at this point it is so it goes to the else statement. If token is yours and
    # exists run code again. If token is not yours or doesn't exist go to else equal_token_left false. And
    # exit the while loop.
    if selection < 0
      # if it's out of the array -1 for example then it moves out of this while loop entirely.
      # if selection is greater than 0 then move to the else statement.
      equals_token_left = false
    else
      # Looks at the array / row / selection to check if tokens match to the left.
      if connect_four[row][left_select] == token
        left_select -= 1
        total_tokens += 1
      else
        equals_token_left = false
      end
    end

    # checks to see if it is outside of the array.
    # if the first piece player enters is 5 selection would = 4 because we - 1 the piece.
    # Which is not less than 0 moves to the else statement. And since token exists run the code in the if statement.
    # It will go back to the selection at this point it is so it goes to the else statement. If token is yours and
    # exists run code again. If token is not yours or doesn't exist go to else equal_token_right false. And
    # exit the while loop.

    while equals_token_right == true
      if selection > 7
        equals_token_right = false
      else
        # This will look to see if the tokens are the same if they are increment + 1 if not jump out of the if statement.
        if connect_four[row][right_select] == token
          right_select += 1
          total_tokens += 1
        else
          equals_token_right = false
        end
      end
    end
  end
  # checks to see if 4 tokens in a row.
  if total_tokens >= 4
    horizontal_win = true
    return horizontal_win
  else
    return horizontal_win
  end
end


def check_vertical(selection, token, connect_four, row)
  vertical_win = false
  total_tokens = 0
  equals_token_down = true
  while equals_token_down == true
    # checks to see if it is at the top of the array. If it is move on to the next statement.
    if row > 7
      equals_token_down = false
    else
      # This will look to see if the tokens are the same if they are increment + 1 if not jump out of the if statement.
      # The reason this works is because we are starting at the top of the row and looking down.
      if connect_four[row][selection] == token
        row += 1
        total_tokens += 1
      else
        equals_token_down = false
      end
    end
  end
  if total_tokens >= 4
    vertical_win = true
    return vertical_win
  else
    vertical_win
    return vertical_win
  end
end


def check_NW_SE(selection, token, connect_four, row)
  diagonal_win = false
  se_column = selection
  se_row = row
  nw_column = selection
  nw_row = row
  total_tokens = -1
  equals_token_down_right = true
  equals_token_up_left = true
  # checks to see if we are to far right or above the array.
  while equals_token_down_right == true
    if se_row > 7 || se_column > 7
      equals_token_down_right = false
    else
      # This will check two different positions. One will check down (south) the other will check (right)
      # If both are true we will increment + 1 if they are not true or out of bounds go to else statement.

      if connect_four[se_row][se_column] == token
        se_row += 1
        se_column += 1
        total_tokens += 1
      else
        equals_token_down_right = false
      end
    end
  end
  # checks to see if top or left is out of the array.
  while equals_token_up_left == true
    if nw_row < 0 || nw_column < 0
      equals_token_up_left = false
    else
      # This will check two different positions. One will check down (south) the other will check (left)
      # If both are true we will increment + 1 if they are not true or out of bounds go to else statement.
      if connect_four[nw_row][nw_column] == token
        nw_row -= 1
        nw_column -= 1
        total_tokens += 1
      else
        equals_token_up_left = false
      end
    end
  end
  if total_tokens >= 4
    diagonal_win = true
    return diagonal_win
  else
    return diagonal_win
  end
end



def check_NE_SW(selection, token, connect_four, row)
  diagonal_win = false
  ne_column = selection
  ne_row = row
  sw_column = selection
  sw_row = row
  total_tokens = -1
  equals_token_down_left = true
  equals_token_up_right = true
  while equals_token_down_left == true
    if sw_row > 7 || sw_column < 0
      equals_token_down_left = false
    else
      if connect_four[sw_row][sw_column] == token
        sw_row += 1
        sw_column -= 1
        total_tokens += 1
      else
        equals_token_down_left = false
      end
    end
  end

  while equals_token_up_right == true
    if ne_row < 0 || ne_column > 7
      equals_token_up_right = false
    else
      if connect_four[ne_row][ne_column] == token
        ne_row -= 1
        ne_column += 1
        total_tokens += 1
      else
        equals_token_up_right = false
      end
    end
  end
  if total_tokens >= 4
    diagonal_win = true
    return diagonal_win
  else
    return diagonal_win
  end
end

# When a piece is placed the first go around the values of horizontal , vertical etc. are going to be false values.
# Once a value is true then it will end the game within the main while loop.

def check_win(selection, token, connect_four, row)
  horizontal = check_horizontal(selection, token, connect_four, row)
  vertical = check_vertical(selection, token, connect_four, row)
  ne_sw = check_NE_SW(selection, token, connect_four, row)
  nw_se = check_NW_SE(selection, token, connect_four, row)
  if horizontal == true
    return true
  elsif vertical == true
    return true
  elsif ne_sw == true || nw_se == true
    return true
  else
    return false
  end
end

connect_four = [
# Col 1    2    3    4    5   6    7    8     # Rows
    [".", ".", ".", ".", ".", ".", ".", "."], # index 1
    [".", ".", ".", ".", ".", ".", ".", "."], # index 2
    [".", ".", ".", ".", ".", ".", ".", "."], # index 3
    [".", ".", ".", ".", ".", ".", ".", "."], # index 4
    [".", ".", ".", ".", ".", ".", ".", "."], # index 5
    [".", ".", ".", ".", ".", ".", ".", "."], # index 6
    [".", ".", ".", ".", ".", ".", ".", "."], # index 7
    [".", ".", ".", ".", ".", ".", ".", "."]  # index 8
]


puts "Would you like to play Connect Four? Y or N"
puts user_choice = gets.chomp
# This is being set so we have something to compare against for the first if.
player = 1
game_over = false

print_grid(connect_four)

# Gets us into the while loop because of the above variables.

while user_choice == "y" && game_over == false
  if player == 1
    # Calls on player input method or if we do a computer rand(1..8) would replace player_input
    user_selected = player_input
  else
    user_selected = player_input
  end
  if game_over == false
    # This will check method position_check to see if game is over (true or false)
    game_over = position_check(user_selected, player, connect_four)
    sleep(1)
    print_grid(connect_four)
    # If it is true then game ends print the winner.
    if game_over == true
      puts "Player #{player} wins."
    end
    # Changes the players back and forth if player 1 is true then player 2 else player 1
    # Although if game_over == true ends this still runs but because the game is true there is nothing else to do.
    if player == 1
      player = 2
    else
      player = 1
    end
  end
end