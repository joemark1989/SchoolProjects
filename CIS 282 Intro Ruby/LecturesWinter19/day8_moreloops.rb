# while loop runs 0 or more
# puts "while loop"
# count = 5
# while count < 5
#   puts count
#   count += 1
# end
#
# puts
# #while modifier - runs 1 or more
# # do something while this condition is true
# puts "while modifier"
# count = 5
# begin
#   puts count
#   count += 1
# end while count < 5


#menu option
# offer the user a set of options
# prompt the user to make a choice
# based on the choice to print something out
# if the user doesn't make a valid choice
# print error message and prompt again

user_choice = 0
  while user_choice != 4
  # create the menu
  puts "  1. Draw a square
  2. Draw a circle
  3. Draw a triangle
  4. Exit"
  puts
  # get user's choice from menu
  print "Please enter your choice: "
  user_choice = gets.to_i

  # check user's choices
  if user_choice == 1
    puts "square"
    puts
  elsif user_choice == 2
    puts "circle"
    puts
  elsif user_choice == 3
   puts "triangle"
    puts
  elsif user_choice == 4
    puts "sorry you have to leave"
    puts
  else
    puts "Invalid choice."
  end
end
