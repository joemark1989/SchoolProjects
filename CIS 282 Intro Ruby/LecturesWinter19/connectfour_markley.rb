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


def position_check(selection, player, connect_four)
  check_winner = false
  token = player
  taken = true
  row = 7
  user_selection = selection
  if token == 1
    token = "X"
  else
    token = "O"
  end
  while taken == true
    if row < 0
      user_selection = player_input
      row = 7
    elsif connect_four[row][user_selection] != "."
      row -= 1
    else
      connect_four[row][user_selection] = token
      taken = false
      check_winner = check_win(user_selection, token, connect_four, row)
    end
  end
  return check_winner
end


def check_horizontal(selection, token, connect_four, row)
  left_select = selection
  right_select = selection
  horizontal_win = false
  total_tokens = -1
  equals_token_left = true
  equals_token_right = true
  while equals_token_left == true
    if selection < 0
      equals_token_left = false
    else
      if connect_four[row][left_select] == token
        left_select -= 1
        total_tokens += 1
      else
        equals_token_left = false
      end
    end

    while equals_token_right == true
      if selection > 7
        equals_token_right = false
      else
        if connect_four[row][right_select] == token
          right_select += 1
          total_tokens += 1
        else
          equals_token_right = false
        end
      end
    end
  end
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
    if row > 7
      equals_token_down = false
    else
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
  while equals_token_down_right == true
    if se_row > 7 || se_column > 7
      equals_token_down_right = false
    else
      if connect_four[se_row][se_column] == token
        se_row += 1
        se_column += 1
        total_tokens += 1
      else
        equals_token_down_right = false
      end
    end
  end
  while equals_token_up_left == true
    if nw_row < 0 || nw_column < 0
      equals_token_up_left = false
    else
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
player = 1
game_over = false

print_grid(connect_four)


while user_choice == "y" && game_over == false
  if player == 1
    user_selected = player_input
  else
    user_selected = player_input
  end
  if game_over == false
    game_over = position_check(user_selected, player, connect_four)
    sleep(1)
    print_grid(connect_four)
    if game_over == true
      puts "Player #{player} wins."
    end
    if player == 1
      player = 2
    else
      player = 1
    end
  end
end