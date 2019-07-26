# array of 50 states
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
    "Utah",
    "Vermont",
    "Virginia",
    "Washington",
    "West Virginia",
    "Wisconsin",
    "Wyoming"
]
# Problem: find the shortest state
# option 1: declare variable to store a string so big anything else is smaller
# shortest_state = "ksoldgnkjsongsjongdsjkngdskngsdkgnmks"


=begin
# get the first state, count letters, store as current shortest state
shortest_state = states[0]

# if the number of letters in the state is < current shortest state
# assign state as now the current shortest state
next_state = states[1]

if next_state.length < shortest_state.length
  shortest_state = second_state
end

third_state = states[2]
if next_state < shortest_state.length
  shortest_state.length = third_state
end
=end
# ***** my note I am just re-writing the short_state because it's in a block of comment

shortest_state = states[0]

# loop through array and run code for each next state
# options for looping: .each(element value), while[needs a counter as a index number], .each_with_index(element value)
states.each do |next_state|
  if next_state.length < shortest_state.length
    shortest_state = next_state
  end
end
# print out shortest state
puts shortest_state

# problem: find longest state
longest_state = states[0]   # longest_state = ""
states.each do |next_state|
  if next_state.length > longest_state.length
    longest_state = next_state
  end
end
puts longest_state

# print out all states that start with the letter "A"
# loop through the array, look at each state if state begins with A, print out

states.each do | state |
  if state[0].upcase =="A"
    puts state
  end
end

# print out all states that end with the letter "S"
states.each do | state |
  if state[-1].upcase == "S"
    puts state
  end
end