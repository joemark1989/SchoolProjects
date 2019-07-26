# Step 1 open a file and read it
people_file = File.open("database.txt", "r")

# Read in and store data

database = {}
until people_file.eof?
  record = people_file.gets.chomp.split(", ")

  # convert age to integer
  record[1] = record[1].to_i
  database[rand(100..999)] = record

end
# close the file
people_file.close

##############
# Step 2 do your stuff CRUD
# add a person to the file
##############
# new_person = ["Guy", 100, "black", "green"]

# note for myself adding an array here and hard coding the information
# In reality we would want to get the user to put the data in so an empty string would be the answer.


new_person = ["John", 12, "brown", "green"]
database[rand(1..100)] = new_person
p database



##########
# Step 3 Writing to files - user exits.

# Open file for writing
people_file = File.open("database.txt", "w")


# Write contents of hash to the file
# people_file.puts database - don't do this
database.each do |person_id, record|
  # write to file
  people_file.puts "#{record[0]}, #{record[1]}, #{record[2]}, #{record[3]}"

end




# Then close the file after down writing.
people_file.close