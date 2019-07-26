 # variables
# variable_name_with_underscore
# first_name
# age
# score1

# prompt a user for input and store in variable
# print "please enter your age:"
# age = gets.chomp
# puts "you are #{age} years old."
# puts age.inspect

#math with our age -= calculate dog years
# print "Please enter your age: "
# age = gets.to_i
# dog_years = age * 7
# puts "You are #{age} years old which is #{dog_years} in dog years."
# puts age.inspect
# puts dog_years.inspect

# repeating a string for output
# puts "hi" * 7
# puts 7 * "Hi" will cause an error because of the number 7 string first "hi"
# calculate our age in seconds pseudocode assume age in years
# 1 year = 365 days/year * 24 hrs/day * 60 min/hr * 60 sec/min
#
# print out for 1 year
# puts (365 * 24 * 60 * 60).to_s + "seconds in 1 year"
# puts "#{365 * 24 * 60 * 60} seconds in 1 year"

# print out for 5 years
# puts "#{5 *365 * 24 * 60 * 60} seconds in 5 years"
print "Please enter your age: "
age = gets.to_i
puts "#{age *(365 * 24 * 60 * 60)} seconds in #{age} years"
#
# #casting: to_s (make string), to_i (make integer,) int_f (float)
# puts (7.5).to_i
# puts (7.5).to_f


