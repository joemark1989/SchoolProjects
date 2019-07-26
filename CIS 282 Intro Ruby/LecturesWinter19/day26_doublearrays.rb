# single array
my_single_array = [
    "a",
    "b",
    "c",
    "d",
    "e",
]

puts "single array"
p my_single_array
puts my_single_array

# double array
# outer array is like rows
# inner (nested) array as columns
my_double_array = [
    # cols 0    1     2     3     4
    ["a", "b", "c", "d", "e"], # index 0
    ["f", "g", "h", "i", "j"], # index 1
    ["k", "l", "m", "n", "o"] # index 2
]
puts "double array"
p my_double_array

=begin
# ref letter d
puts my_double_array[0][3]

# change i to z
my_double_array[1][3] = "z"
p my_double_array

# change value L to taco
my_double_array[2][1] = "taco"
p my_double_array

# print out letter c of taco
puts my_double_array
puts my_double_array[2][1][2]
=end

puts
puts

# printing a row
puts "print a row"
# idea each loop with if checking for index 0 or what row
# idea print out my array [0]
# puts my_double_array[0]     this printed each element value on it's own line
# print my_double_array[0]    printed like an inspect

# try the .each on the array
=begin
my_double_array.each do |row|       # passes element value one at a time
                                    #  row is an array
                                    # print row prints like inspect
                                    # how do you get access to each element in the row?
  row.each do |column|              # column is the value of each element
    # print column                  # print column abcdefghzjktacomno
    # print "#{column} "            # prints: a b c d etc. adds extra space at end
    print column  # "a"
    if row.last != column
      print " "
    end
  end
  puts

end
=end

# same at above I just wanted to show it without comments.

my_double_array.each do |row|
  row.each do |column|
    print column
    if row.last != column
      print " "
    end
  end
  puts
end

puts

# printing our grid
# easier way does the same as above.
my_double_array.each do |row|
  puts row.join(" ")

end