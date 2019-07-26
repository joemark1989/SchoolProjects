# New file creation add / write

# write one thing to a file
new_states_file = File.open("new_states.txt", "w+")

# write Puerto Rico to the file (adding a new state)
new_states_file.puts("Puerto Rico")

# close the new file
new_states_file.close


##############################
# add to the existing file
# add Virgin Islands
new_states_file = File.open("new_states.txt", "a+")

# write to the file
new_states_file.puts("Virgin Islands")


new_states_file.close
###############################


# open file for reading
states_file = File.open("states.txt")

=begin
states_array = states_file.readlines()
puts states_array.inspect
=end

# get rid of comma's, n's, quote marks.

states_array = []


states_file.each_line do |line|
  line.chomp!
  line.gsub!(",", "")
  line.gsub!("\"", "")
  states_array << line
  p line #  puts line.inspect
end


# use readlines but also remove \n,"", ","
=begin
states_array = states_file.readlines()
states_array.each do |line|
  line.chomp!
  line.gsub!(",", "")
  line.gsub!("\"", "")
end
p states_array
=end



# close file
states_file.close