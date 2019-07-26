# check if person is eligible to drive in washington or idaho
# Washington & Idaho need to be 16 and need a license
print "Please enter your age: "
age = gets.to_i
print "Please enter your state (2-letter abbreviation):"
state = gets.chomp.upcase

#check age and state
# I can run this code below with or without () if the user puts age 15 and there is no () it will run true.
# So to avoid this you must put () around your or statement for this example to work.
if age>= 16 && (state == "WA" || state =="ID")
  puts "You can drive"
end
#story
# label person as infant, toddler, child\
# adolescent, adult or senior citizen based on their age
# rules:
# age less than 1             infant
# age 1 to 3                  toddler
# age 3 to 10                 child
# age 10 to 18                adolescent
# age 18 or older             adult
# age 55 or older             senior citizen

# age = gets.to_i
#
# print "what is your age?"
#
# if age < 1
#   puts "infant"
# elsif age >= 1 && age < 3
#   puts "toddler"
# elsif age >= 3 && age < 10
#   puts "child"
# elsif age >= 10 && age < 18
#   puts"adolescent"
# elsif  age >= 18 && age < 55
#   puts "adult"
# elsif age >= 55
#   puts "senior citizen"
# end
#case
# case variable
# when condition
#   code to run
# when condition2
#   code to run
# else
#   code to run
# end
# print "what is your age?"
# age = 55
# case age                                  # when doing if / elsif statements use the code below commented.
#
# when 0...1                                # age < 1
#   puts "infant"
# when 1...3                                # age >= 1 && age < 3
#   puts "toddler"
# when 3...10                               # age >= 3 && age < 10
#   puts "child"
# when 10...18                              # age >= 10 && age < 18
#   puts "adolescent"
# when 18...55                              # age >= 18 && age < 55
#   puts "adult"
# when 55...Float::INFINITY                 # age >= 55
#   puts "senior citizen"
#   else "you did not enter your age"
# end

#Fall thru approach better way to write code for ages etc.
# age = 12
# if age > 55
#   puts "senior citizen"
# elsif age > 18
#   puts "adult"
# elsif age > 10
#   puts "adolescence"
# elsif age > 1
#   "toddler"
# elsif age > 0
#   puts "infant"
# end

#ternary ? : if statement is an example of code that would work with an if statement.
age = 20
# if age < 18
#   puts "child"
# else
#   puts "adult"
# end
#ternary example
puts (age > 18) ? "child" : "adult"


