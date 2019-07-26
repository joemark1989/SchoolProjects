
shoe_array = [
    "shoestring",
    "hi-tops",
    "sandals",
    "boots"
]
# loop through arrays
puts
index = 0
while index < shoe_array.length
  puts "Element at index #{index} is: #{shoe_array[index]}"
  index += 1
end
puts "end of while loop"

# .each iterator
puts

shoe_array.each do |shoe|
  puts "I own this shoe: #{shoe}"
end
puts "end  of each iterator"
puts

# .each iterator to reproduce while loop output
count = 0
shoe_array.each do |shoe|
  puts "I own this shoe: #{shoe}"
  puts "element of index #{count} is: #{shoe}"
  count += 1
end
puts "end  of each iterator"
puts

# each with index iterator 
shoe_array.each_with_index do |value, index|  # |shoe, index|
  puts "element of index #{index} is: #{value}"
end
puts "end  of each_with_index iterator"
puts

# each with index iterator
shoe_array.each_with_index do |value, index|  # |shoe, index|
  # 1. shoe
  puts "#{index + 1}. #{value}"
end
puts "end  of each_with_index iterator"
puts

# create an array of 50 states
states = [
    "Alabama",
    "Alaska",
    "Arizona",
    "Arkansas",
    "California",
    "Colorado",
    "Connecticut",
    "Delaware",
    "Florida",
    "Georgia",
    "Hawaii",
    "Idaho",
    "Illinois",
    "Indiana",
    "Iowa",
    "Kansas",
    "Kentucky",
    "Louisiana",
    "Maine",
    "Maryland",
    "Massachusetts",
    "Michigan",
    "Minnesota",
    "Mississippi",
    "Missouri",
    "Montana",
    "Nebraska",
    "Nevada",
    "New Hampshire",
    "New Jersey",
    "New Mexico",
    "New York",
    "North Carolina",
    "North Dakota",
    "Ohio",
    "Oklahoma",
    "Oregon",
    "Pennsylvania",
    "Rhode Island",
    "South Carolina",
    "South Dakota",
    "Tennessee",
    "Texas",
    "Vermont",
    "Virginia",
    "Utah",
    "Washington",
    "West Virginia",
    "Wisconsin",
    "Wyoming"
]
# see's how many elements are in your array
# states.size
# puts
# sort
# sorted_states =states.sort
# puts sorted_states
# puts states

# reverse the order
# puts
# reversed_states = states.sort.reverse
# puts reversed_states
# puts states

# chomp! sort! reverse!
# full_name = gets.chomp    # "Joey\n"  "Joey"
# full_name = gets          # "joey\n"
# full_name.chomp!          # "Joey"

# modify in place
# puts states.sort!
# puts states

# ruby-doc syntax
# .each { | value | code }
# .each do | value | code end
# .each with do/end
# states.each do | state |
#   puts state
# end
# # .each with {}
# states.each { |state|
#   puts state
# }