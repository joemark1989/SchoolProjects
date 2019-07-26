menu_items = [
    "draw circle",
    "draw square",
    "draw triangle",
    "draw hexagon",
    "draw rectangle"
]

def menu(menu)
  # print out the menu
  menu.each_with_index do |item, index|
    puts "#{index + 1}.   #{item}"
  end
  # print the quit option
  puts "#{menu.length + 1}.   Quit"
  puts
  print "please enter your choice: "
  user_choice = gets.to_i
  # returns user choice
  return user_choice
end

# determine user's choice and run the code

while (user_choice = menu(menu_items)) != (menu_items.length + 1)
if user_choice == 1
  puts "circle"
elsif user_choice == 2
  puts "square"
elsif user_choice == 3
  puts "triangle"
elsif user_choice == 4
  puts "hexagon"
elsif user_choice == 5
  puts "rectangle"
else
  puts "Invalid choice. Please choose from the user menu: "
end
end
puts "Thanks. Bye."

