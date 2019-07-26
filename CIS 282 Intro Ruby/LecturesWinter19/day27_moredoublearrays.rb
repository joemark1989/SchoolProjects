# review printing a grid
# work with accessing single cells
# double array
# outer array is like rows
# inner (nested) array as columns
my_double_array = [
    # cols 0    1     2     3     4
    ["a", "b", "c", "d", "e"], # index 0
    ["f", "g", "h", "i", "j"], # index 1
    ["k", "l", "m", "n", "o"] # index 2
]

# print out the grid
=begin
puts "printing grid"

my_double_array.each do |row| # row passed is array [abcde]
  row.each do |column| # column is column value "a"
    print column
    print " " if row.last != column
  end
  puts # start new line for next row.
end
=end

# print grid shorter version
=begin
puts "printing grid - shorter version"
my_double_array.each do |row|
  puts row.join(" ")
end
puts
=end

# define a method whose purpose is to print the grid
puts "printing the grid with a method"

def print_grid(grid)
  grid.each do |row|
    puts row.join(" ")
  end
end

=begin
# call method
print_grid(my_double_array)
returned_from_method = print_grid(my_double_array)
puts "returned method: #{returned_from_method}"
######################################################
# working with individual cells (row/column intersection)
# pseudocode - print out grid
# start at first row
# loop through each row - until we get to the end
# for each row wew work with, we will loop through each column
# print out each cell

# search thru the grid
# if the current cell has letter "n"
# replace with letter x
# using a while loop
puts "using while loop to change cell value"
puts
=end

# print grid
print_grid(my_double_array)
# find cell
row = 0 # first row
while row < my_double_array.size      # row = 0 , size = 3
  column = 0    # first column
  while column < my_double_array[row].size    # col = 0, row size = 5
    # look for our cell
    if my_double_array[row][column] == 'n'
      # puts "found: row/col = #{row}/#{column}"      # a way to find a cell within a row/col
      # replace with x
      my_double_array[row][column] = 'x'
    end
    # print out each cell
    # print my_double_array[row][column]
    # print " " if my_double_array[row][column] != my_double_array[row].last
    column += 1   # go to next column
  end
  puts      # prints row on new line
  row += 1    # go to next row
end
# print grid
puts "revised grid x for n"
print_grid(my_double_array)
###################################################
# day 28 - searching and replacing by row
# want to repalce each letter of the second row with the letter z
# row #2 is index #1
# don't need to loop thru all rows because only interested in one row.

puts "replace entire specified row with letter z"
row = 1     # row stays the same index 1 represents row #2
column = 0  # start at first column and change to look at each column

# loop through our specified row
# while the current column(column index#) is less than the length of the row.

while column < my_double_array[row].length do
  # replace each cell with letter 'z'
  my_double_array[row][column] = "z"
  column += 1   #go to next column
end

puts "revised grid - z for row 2"
print_grid(my_double_array)
puts

##############################################
# replace each letter in the 2nd column with the letter o
# col #2 is index # 1
puts "replace entire specified column with letter o"
# get to col
# replace the value in that col for each row with letter ol

# for each row look only at that col - col 2 which is index 1

row = 0       #row will change
column = 1    # col stays the same
# loop thru each row
# while current row is less than the length of all rows
while row < my_double_array.length do
  # replace each cell in col 2 with letter "o"
  my_double_array[row][column] = "o"
  row += 1  # go to next row
end

puts "revised grid - o for col 2"
print_grid(my_double_array)
puts