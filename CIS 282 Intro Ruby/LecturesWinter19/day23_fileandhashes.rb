# Step 1 open a file and read it
people_file = File.open("database.txt")
#
# # p people_file
#
# # Trial 1 read in file into an array
#
# database = []
#
# until people_file.eof?
#   # take each record and store it in an array
#   database.push(people_file.gets.chomp)
# end
# p database



# trial 2 breaking the line up before storing into the array


# until people_file.eof?
#   # string only
#   # record record = people_file.gets.chomp
#
#   # this is an array
#   record = people_file.gets.chomp.split(", ")
#   p record
#   print "press enter to continue"
#   pause = gets
# end


# trial 3 save each record into our database
=begin
database = []

until people_file.eof?
  # get record and split4 to store as array
  record = people_file.gets.chomp.split(", ")
  database << record
  #p database
end

# print out a meaningful report
database.each do |record|            #  array is passed to the record
  puts "#{record[0]} is #{record[1]} years old and has #{record[3]} hair"
end
=end

# trail number 4 change from array to hash
# database = {} # empty hash
# until people_file.eof?
#   record = people_file.gets.chomp.split(", ") # array
#
#   # store data in the hash
#   # hash[key] = value
#   # hash[random number] = ["product", price]  # array of product details(assignment)
#
#   # create / generate random number for our people as the key
#   # use the record as the value for that key
#   database[rand(1..20)] = record
# end
# p database

# print out a report
# hash.each do | value, index |
# code
# end
# database.each do |record_id, record|
#   # record id is name who is age years old with eye color eyes
#   puts "ID: #{record_id}, #{record_id} is #{record[0]} who is #{record[1]} years old with #{record[2]} eyes"
# end
