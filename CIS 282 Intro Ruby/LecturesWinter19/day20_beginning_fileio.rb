# open states.txt file and store a ref to the file
states_file = File.open("states.txt")

# Option 1 using gets to get one line at a time.

# get the first line of the state file
# Which is Alabama, \n
state1 = states_file.gets       # returns a string

# print out what is being stored in state 1
# puts state1
# puts state1.inspect

# because first line has \n need to chomp
# .chomp without !
state1 = state1.chomp
puts state1

# chomp!
state1.chomp!

# get the second state in the states file
state2 = states_file.gets.chomp
puts state2

# Option 2 loop thru file using while !file.eof

# want to store all States in the file.
# walk through the file / loop through the file
# store each state until we reach the end of the file
# states_array = []
#
# # use loop
# while !states_file.eof?                   # while not at the end of the file
#   state = states_file.gets.chomp
#   state = state.gsub( ",", "" )           # clean up of the states string lose the commas# get current state
#   state = state.gsub("\"", "")                    # get rid of the quote marks.
#   states_array.push(state)                # add state to array
#   puts state
# end
# puts states_array.inspect

# option three loop thru file using the each method.
# 1. loop thru each line in the states file
# 2. chomp off \n
# 3. replace comma and quote marks
# 4. store the state in the array

states_array = []

states_file.each do |line|
  line.chomp!
  line.gsub!(",","")            # replace comma's
  line.gsub!("\"","")
  states_array << line
end
puts states_array.inspect

# most important if you open a file you must close it. Line 2 is opening of the file
states_file.close



