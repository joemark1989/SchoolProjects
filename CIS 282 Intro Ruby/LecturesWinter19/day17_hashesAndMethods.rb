
foods = {
    # key => value
    'tomato' => 'veggie',
    'grapes' => 'fruit',
    'celery' => 'veggie',
    'parsnip' => 'veggie',
    'banana' => 'fruit'
}
puts foods
 #  sorting hashes
# don't do this
puts  foods.sort.inspect
puts foods

numbers_hash = {
    3 => "three",
    1 => "one",
    2 => "two"
}
# trying to sort on numbers hash
puts numbers_hash.sort.inspect
puts numbers_hash

######
# better way to sort hashes
# sort by keys
puts foods.keys.sort.inspect
puts numbers_hash.keys.sort.inspect

# sort by values
puts foods.values.sort.inspect
puts numbers_hash.values.sort.inspect

#######
numbers_hash.keys.sort.each do |key|
  puts numbers_hash[key]
end


# new top methods (aka function, subroutine, routine, ....)
# reusable piece of code
# defined fir built-in objects of the language
# we can define our own

=begin
# syntax using example below as basic syntax
def method_name(argument1, argument2, arugmentN)

end
=end

# define a method that prints any symbol it receives
def print_symbol(symbol,num)
  puts symbol * num
end
# # write code to call/invoke the method
# print "please enter a symbol of your choice: "
# user_symbol = gets.chomp
# print "print symbol how many times?: "
# quanity = gets.to_i
# print_symbol(user_symbol,quanity)

# play a game that keeps playing until user wants to quit
play =""

while play!= "N"
  print "please enter a symbol of your choice: "

  user_symbol = gets.chomp

  print "print symbol how many times?: "

  quanity = gets.to_i

  print_symbol(user_symbol,quanity)

  print "do you want to play again?(enter y or n): "
  play = gets.chomp.upcase
end