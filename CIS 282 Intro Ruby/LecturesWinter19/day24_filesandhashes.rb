# Step 1 open a file and read it
people_file = File.open("database.txt", "r")

# trail number 4 change from array to hash
=begin
database = {} # empty hash
  until people_file.eof?
    record = people_file.gets.chomp.split(", ") # array

    # store data in the hash
    # hash[key] = value
    # hash[random number] = ["product", price]  # array of product details(assignment)

    # create / generate random number for our people as the key
    # use the record as the value for that key
    database[rand(1..20)] = record
  end
=end
# p database

# print out a report
# hash.each do | value, index |
# code
# end

=begin
# Report 1A
database.each do |record_id, record|
  # record id is name who is age years old with eye color eyes
  puts "#{record_id} is #{record[0]} who is #{record[1]} years old with #{record[2]} eyes"

end
=end


# Report 1B

=begin
database.each do |record_id, record|
  person_id = record_id
  name = record[0]
  age = record[1]
  eye_color = record[2]
  hair_color = [3]

  puts "#{person_id} #{name} who is #{age} and eye color #{eye_color}"
end
=end


# Trial 5 data type conversions when we get the data
database = {}
until people_file.eof?
  record = people_file.gets.chomp.split(", ")

  # convert age to integer
  record[1] = record[1].to_i
  database[rand(1..20)] = record
end
# close the file
people_file.close

# print a report
# person is x years in dog years

# database.each do |record_id, record|
#   puts "#{record[0]} is #{record[1] * 7} years old in dog years"
# end

# Step 2 do stuff
# CRUD - add new person, view all people, update a peron, delete a person

# view all people
database.each do |record_id, record|
  puts " ID: #{record_id}, Name: #{record[0]}, Age: #{record[1]}, Eyes: #{record[2]}, Hair: #{record[3]}."
end

# add someone to the database
database[rand(1..20)] = [] # store array of values

# inspect database
p database

# add another person from the user
print "Enter name: "
name = gets.chomp
print "Enter age: "
age = gets.to_i
print "Enter eye color: "
eye = gets.chomp
print "Enter hair color: "
hair = gets.chomp

# add person to database
database[rand(1..20)] = [name,age,eye,hair]

p database
