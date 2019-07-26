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
  if total_tokens == 4
    horizontal_win = true
    return horizontal_win
  else
    return horizontal_win
  end
end








def check_NW_SE(selection, token, connect_four, row)
  diagonal_win = false
  selection_column = selection
  selection_row = row
  total_tokens = 1
  equals_token_down_right = true
  equals_token_up_left = true
  while equals_token_down_right == true
    if selection_row > 7 || selection_column > 7
      equals_token_down_right = false
    else
      if connect_four[selection_row][selection_column] == token
        selection_row += 1
        selection_column += 1
        total_tokens += 1
      else
        selection_column = selection
        selection_row = row
        equals_token_down_right = false
      end
    end
  end
  while equals_token_up_left == true
    if selection_row < 0 || selection_column < 0
      equals_token_up_left = false
    else
      if connect_four[selection_row][selection_column] == token
        selection_row -= 1
        selection_column -= 1
        total_tokens += 1
      else
        selection_column = selection
        selection_row = row
        equals_token_up_left = false
      end
    end
  end
  if total_tokens == 4
    diagonal_win = true
    return diagonal_win
  else
    return diagonal_win
  end
end

def check_NE_SW(selection, token, connect_four, row)
  diagonal_win = false
  selection_column = selection
  selection_row = row
  total_tokens = 1
  equals_token_down_left = true
  equals_token_up_right = true
  while equals_token_down_left == true
    if selection_row > 7 || selection_column < 0
      equals_token_down_left = false
    else
      if connect_four[selection_row][selection_column] == token
        selection_row += 1
        selection_column -= 1
        total_tokens += 1
      else
        selection_column = selection
        selection_row = row
        equals_token_down_left = false
      end
    end
  end
  while equals_token_up_right == true
    if selection_row < 0 || selection_column > 7
      equals_token_up_right = false
    else
      if connect_four[selection_row][selection_column] == token
        selection_row -= 1
        selection_column += 1
        total_tokens += 1
      else
        selection_column = selection
        selection_row = row
        equals_token_up_right = false
      end
    end
  end
  if total_tokens == 4
    diagonal_win = true
    return diagonal_win
  else
    return diagonal_win
  end
end

def check_diagonal(selection, token, connect_four, row)
  diagonal_win = false
  total_tokens = 1
  equals_token_down_right = true
  equals_token_down_left = true
  equals_token_up_left = true
  equals_token_up_right = true
  while equals_token_down_right == true && total_tokens < 3
    if row == 7 || selection == 7
      equals_token_down_right = false
    else
      if connect_four[row][selection] == token
        row += 1
        selection += 1
        total_tokens += 1
      else
        equals_token_down_right = false
      end
    end
    while equals_token_up_left == true && total_tokens < 3
      if row == 0 || selection == 0
        equals_token_up_left = false
      else
        if connect_four[row][selection] == token
          row -= 1
          selection -= 1
          total_tokens += 1
        else
          equals_token_up_left = false
        end
      end
    end
  end
  while equals_token_down_left == true && total_tokens < 3
    if row == 7 || selection == 0
      equals_token_down_left = false
    else
      if connect_four[row][selection] == token
        row += 1
        selection -= 1
        total_tokens += 1
      else
        equals_token_down_left = false
      end
    end
    while equals_token_up_right == true && total_tokens < 3
      if row == 0 || selection == 7
        equals_token_up_right = false
      else
        if connect_four[row][selection] == token
          row -= 1
          selection += 1
          total_tokens += 1
        else
          equals_token_up_right = false
        end
      end
    end
  end
  if total_tokens == 4
    diagonal_win = true
    return diagonal_win
  else
    diagonal_win
    return diagonal_win
  end
end


# Computer turn alter this later.
# if row < connect_four.size
#   computer_number = rand(0..7)
#   connect_four[row][computer_number] = "0"
# end


# This will affect only the column and replace all with x's
=begin
while row < connect_four.length do
  connect_four[row][column] = "X"
  row += 1
end
puts
print_grid(connect_four)
sleep(1)
=end


# Working on this example from class

=begin
while row < connect_four.size
  while column < connect_four[row].size
    print_grid(connect_four)
    puts "Please select a column number:"
    user_selected = gets.to_i
    user_selected = user_selected - 1
    if connect_four[row][column] == "."
      connect_four[row][user_selected] = "X"
    end
    puts
    print_grid(connect_four)
    sleep(1)
  end
end
=end

=begin
# here are some examples of what I need to do to get the game going I need to manipulate the cells of the array.
print_grid(connect_four)

connect_four[1][1] = "X"
print_grid(connect_four)

print_grid(connect_four)

connect_four[1][0] = "X"
print_grid(connect_four)

print_grid(connect_four)
# pause playing
sleep(3)
=end

# finding "." placing X using CASE

=begin
while user_choice == "y"
  puts "What column do you want your token?"
  user_selected = gets.to_i
  row = connect_four.size - 1
  column = user_selected - 1
  token_drop = true
  while token_drop
    case
    when row < 0
      token_drop = false
      print_grid(connect_four)
      sleep(1)
    when connect_four[row][user_selected] == "."
      connect_four[row][column] = "X"
      token_drop = false
    else
      row -= 1
    end
    print_grid(connect_four)
    sleep(1)
  end
end
=end


=begin
def connect4_checker(array, symbol)
  counter = 0
  array.size.times do |i|
    if array[i] == symbol
      counter+=1
      return true if counter == 4
    else
      counter = 0
    end
  end
  return false
end
=end