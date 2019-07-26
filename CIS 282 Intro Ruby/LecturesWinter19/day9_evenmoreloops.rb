# while loop
# loops while a true condition is met
#
# until loop
# loops until a true condition is met
# aka while loop running while condition is false
# syntax if this was while loop: while (true) === while (!false)
#
puts "until loop"
  count = 1
  until count > 5 do
    puts count
    count += 1
  end

puts while "loop"
count = 1
while count <= 5
  puts count
  count += 1
end
#
# for loop
# executes code once for each iteration in a rage / collection
#
# syntax
# for var in expression
# code to run each iteration
# end

puts "for loop"
for count in 1..5
  puts count
end

puts "for loop using i"
for i in 1..5
  puts i
end

puts "for loop using num"
for num in 1..5
  puts num
end

puts "can I use #{i} or #{num} outside of the for loop?"

puts
puts "quick example using array with for loop"
letters = [ "a", "b", "c" ]
for letter in letters
  puts letter
end