#loops
#.times
# while

# puts"*" *10
# 10.times do
#   #code to repeat use print because it prints on 1 line.
#   print"*"
# end

#times loop with a var

# print "Please enter the number of loops: "
# loops = gets.to_i
# loops.times do
#   print "*"
# end
#
# # times loop with an expression
# puts
# (loops +5) .times do
#   print"*"
# end

#while loop
# 3 parts or 3 required elements
# 1. Starting condition
# 2. boolean expression
# 3. changed the value of boolean expresion

#syntax
# while (boolean_expression)
# code to run
# update your expression
# end

# while I have gas in my tank, keep driving
gallons = 10 #number of gallons of gas in the tank
while (gallons > 0)
  puts "keep driving - you have #{gallons} gallons of gas left"
  gallons = gallons - 1
end
puts "out of gas"

#using puts for spaces in output

puts

# #print out numbers 1-10
#
# count = 1
# while count <= 10
#   puts count
#   #or u can use count = count + 1
#   count += 1
# end
# #another way to do code 1-10 numbers
# puts
count = 0
while count < 10
  count += 1
  puts count
end
# puts

#write out even numbers 1-20
count = 0
while count < 20
  count += 2
  puts count
end

puts

#write out odd numbers 1-30
count = 1
while count < 30
  puts count
  count += 2
end
puts
# modulus operator %
# use for even or odd
puts "starting the modulus section: "

# 8 / 2 remainder 0
# 8 % 2 remainder 0
# 8 / 3 remainder 2
# 8 % 3 remainder 2
puts "8 % 2 = #{8 % 2}"
puts "8 % 3 = #{8 % 3}"
puts "9 % 2 = #{9 % 2}"
puts
#print out even numbers from 1-20
# using modulus

count = 1
while count <= 20
  if count % 2 == 0
    puts count
  end
  count += 1
end
puts
#write out numbers from 1 to 100 divisible by 5

count = 1
while count <= 100
  if count % 5 == 0
    print "#{count} "
  end
  count += 1
end

puts
# var on above loop
count = 1
while count <= 100
  print "#{count} " if (count % 5 == 0)
  count += 1
end

# hi low game
# computer chooses number (6) in a range (1..100)
# player guesses a number(18)
# computer tells the player if the chosen number (6) is higher or lower than the guess (18)
# repeat player guess until the guess is correct
# if the guess is correct you print "you win"

#generate a random number for the computer
# rand() method with a range
puts
computer_number = rand(1..100)
puts "computer chose: #{computer_number}"

#prompt user for first guess

print "Please enter a number between 1 and 100: "
player_guess = gets.to_i

# start our loop - check user's guess and say higher or lower
#
while player_guess != computer_number

  # check the guess
  if computer_number > player_guess
    puts "guess higher!"
  elsif computer_number < player_guess
    puts "guess lower"
  end

  print "guess again: "
  player_guess = gets.to_i
end
puts "you win!"