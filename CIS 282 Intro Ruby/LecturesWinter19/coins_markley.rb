puts "Please enter the number of quarters: "
user_quarters = gets.to_i
puts "Please enter the number of dimes: "
user_dimes = gets.to_i
puts "Please enter the number of nickles: "
user_nickles = gets.to_i
puts "Please enter the number of pennies: "
user_pennies = gets.to_i

change_add = user_quarters * 0.25 + user_dimes * 0.10 + user_nickles * 0.05 + user_pennies * 0.01

puts "You have #{user_quarters} quarters, #{user_dimes} dimes, #{user_nickles} nickles, #{user_pennies} pennies for a total of $#{format("%.2f", change_add)}"



