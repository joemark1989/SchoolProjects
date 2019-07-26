def print_grid(grid)
  # clear the screen
  system('cls') # windows

  # print grid
  grid.each do |row|
    puts row.join(" ")
  end
end

my_double_array = [
    # cols 0    1     2     3     4
    ["a", "b", "c", "d", "e"], # index 0
    ["f", "g", "h", "i", "j"], # index 1
    ["k", "l", "m", "n", "o"] # index 2
]
# printing the original grid
print_grid(my_double_array)
# pause playing
sleep(3)

# replace row 2 with letter x
row = 1 # this doesnt change
column = 0

while column < my_double_array[row].length # length of row
  my_double_array[row][column] = "X"
  column += 1 # go to next col
end

# printing new grid with change in row 2
print_grid(my_double_array)

# update cell with letter 'i'
my_double_array[1][3] = "Z"
print_grid(my_double_array)

# update column 3 with letter "Y"
row = 0       # ITERATE thru all rows
column = 3    # this doesn't change

while row < my_double_array.length    # length/size of the grid
  my_double_array[row][column] = "Y"
  row += 1  # go to next row
end
print_grid(my_double_array)
# print_grid(my_double_array)

