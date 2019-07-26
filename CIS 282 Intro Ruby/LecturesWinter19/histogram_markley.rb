###########################################################
#
#  Name:                 Joseph Markley
#  Assignment:           Array Histogram
#  Date:                 02/08/2019
#  Class:                CIS 282
#  Description:          Array histogram that allows us to visually inspect a set of values
#
###########################################################

# produce chart that will display the information (rough draft below) R stands for random
#Range        # Found      Chart
# --------    ----------   ----------------------------------
# 1 - 10       |RInt|      ************************
# range will keep going 11 - 20, 21 - 30, 31 - 40 etc. until 91 - 100
# I will need to store a few variables one for the array , range and found.
# For the array just create an array that generates 200 random integers but inclusive 1-100
# for the range I need to loop through the array to compare numbers that fall into 1-10 , 11-20... until 90-100.
# Once the numbers have been found within that range I will need to store that information.
# Once that information is stored I need to output the found numbers within the range into ********
# Once the information is stored I will need to format the variables to fit the histogram.
# important note when using ljust,center,rjust it uses all spaces you give it including the number 1 - 10 = 6 spaces.

puts "Range      # Found       Chart                                 "
puts "--------   -----------   ----------------------------------    "

# Created array with an index of 10 all set to 0
# Create 200 random integers between 1 - 100
# Compared the array integers by using if statement and incrementing the indexes by 1 each time.


numbers = Array.new(10, 0)


p numbers

200.times do
  rand_numbers = (rand(100) + 1)
  if rand_numbers <= 10
    numbers[0] = numbers[0] + 1
  elsif rand_numbers >= 11 && rand_numbers <= 20
    numbers[1] = numbers[1] + 1
  elsif rand_numbers >= 21 && rand_numbers <= 30
    numbers[2] = numbers[2] + 1
  elsif rand_numbers >= 31 && rand_numbers <= 40
    numbers[3] = numbers[3] + 1
  elsif rand_numbers >= 41 && rand_numbers <= 50
    numbers[4] = numbers[4] + 1
  elsif rand_numbers >= 51 && rand_numbers <= 60
    numbers[5] = numbers[5] + 1
  elsif rand_numbers >= 61 && rand_numbers <= 70
    numbers[6] = numbers[6] + 1
  elsif rand_numbers >= 71 && rand_numbers <= 80
    numbers[7] = numbers[7] + 1
  elsif rand_numbers >= 81 && rand_numbers <= 90
    numbers[8] = numbers[8] + 1
  else
    rand_numbers >= 91 && rand_numbers <= 100
    numbers[9] = numbers[9] + 1
  end
end

# Created low_end , high_end, array counter to store variables and indexes.
# print out 1 - 10 using low_end and high_end
# array_counter stores the index from numbers
# numbers is the array I created above.
# 10.times do loops through the variables / indexes / array to create the desired output.
# stars loop prints the stars = to the number found within the array / index
# I attempted to use rjust / ljust / center to make the variables align within the columns
# Unfortunately, ran out of time I know that I probably needed to string the variables just wasn't working
# Will have research this at a later time.

low_end = 1
high_end = 10
array_counter = 0

10.times do
  print " #{low_end} - #{high_end}"
  print "      |#{numbers[array_counter]}|        "
  stars = numbers[array_counter]
  stars.times do
    print "*"
  end
  puts
  low_end = low_end + 10
  high_end = high_end + 10
  array_counter = array_counter + 1
end


# creating an array with 1 - 100 inclusive that has 200 integers.

numbers = []

200.times do
  numbers << (rand(100) + 1)
end
p numbers

# Attempted to use counters but it didn't work out.

# numbers.each do |random_numbers|
#   if  random_numbers. <= 10
#     puts "1 - 10 #{random_numbers}"
#   end
# end

# Tried this first had the most success displaying integers but it caused issues by constantly putsing out
# the full index or everything in the element of the array. Attempted to re-create the 31 - 75.
# Because I know you can utilize string methods to get rid of errors when using r.just , l.just etc.
# Unfortunately unsuccessful, will need to research this as this. Lines 100 - 116

# numbers = Array.new(10, 0)
#
# 200.times do
#   numbers << (rand(100) + 1)
# end

# puts "#{numbers.size}"


# numbers.each.with_index do |random_numbers, index|
#   if index <= 10
#     puts "#{index}"
#     index[0] = index[0] + 1
#   end
# index = index.to_s
# puts "#{random_numbers}#{index}"
# end


# .step is interesting code I found could of been of use but decided not to use it.

# (1..100).step(10) do |range|
# puts "#{range}-#{range + 9} #{numbers}"
# end


# Attempted to use this it didn't work out. Couldn't wrap my head around the new method of %w() even though
# it's just a normal array just didn't feel the same.

# # numbers = %w( 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
# # 16 17 18 19 20 21 22 23 24 25 26 27
# # 28 29 30 31 32 33 34 35 36 37 38 39
# # 40 41 42 43 44 45 46 47 48 49 50 51
# # 52 53 54 55 56 57 58 59 60 61 62 63
# # 64 65 66 67 68 69 70 71 72 73 74 75
# # 76 77 78 79 80 81 82 83 84 85 86 87
# # 88 89 90 91 92 93 94 95 96 97 98 99
# # 100 )

# # numbers_array = hash.new(0)
# # numbers.each {|numbers| numbers_array[numbers] += 1}


# maybe use?

# numbers.new(1){|index|index * 2}
#
# puts numbers

# 200.times do
#   index << (rand(100) + 1)
# end


# Attempted to make an array 200. (first try)

# while array < 100
#   if array < 100
#   array * 2
#     print "#{array}"
#     count += 1
#   end
#   count += 1
# end


# codecademy example for array that uses hash.new


# puts "Text please: this is a string"
# text = gets.chomp
# words = text.split(" ")
# frequencies = Hash.new(0)
# words.each { |word| frequencies[word] += 1 }
# frequencies = frequencies.sort_by {|a, b| b }
# frequencies.reverse!
# frequencies.each { |word, frequency| puts word + " " + frequency.to_s }
#


# Classroom examples.

# shoe_array = %w(0 1 2 3 4 5 6 7)
#
# index = 0
# while index < shoe_array.length
#   puts "Element at index #{index} is: #{shoe_array[index]}"
#   index += 1
# end
#
# puts
# index = 0
# while index < shoe_array.length
#   puts "Element at index #{index} is: #{shoe_array[index]}"
#   index += 1
# end
# puts "end of while loop"


# shoe_array = [
#     "shoestring",
#     "hi-tops",
#     "sandals",
#     "boots"
# ]
#
# shoe_array.each_with_index do |value, index|  # |shoe, index|
#   # 1. shoe
#   puts "#{index + 1}. #{value}"
# end
# puts "end  of each_with_index iterator"
