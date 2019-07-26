# array
# index             | 0 1 2 3 4|
# element value   | "a","b","c","d"|

# Hash is similar to an array

# hash (key-value)
# key             | 123        245     |
# value   | "Sam S.", "Kim B."|

# create a hash
# hash_name = {
# #     key => value1,
# #     key2 => value2,
# #     keyN => valueN
# # }

numbers = {
    # key => value
    10=> "ten",
    20 => "twenty",
    30 => "thirty"
}
puts numbers.length
puts numbers.inspect
puts numbers
# look something up in hash
# hash_name [key] # returns the value for the provided key
puts numbers[20]

# look something in hash with non-existent key
puts numbers[50]
puts numbers[50].inspect

# add an element (key/value pair) to the hash

puts "Enter a choice"
user_choice = gets.chomp

numbers[user_choice] = user_choice.chomp
puts numbers.inspect

numbers[400] = "forty"
puts numbers.inspect

numbers[40] = "forty"
puts numbers.inspect

# modified a hash value
numbers[400] = "four hundred"
puts numbers.inspect
puts

# prompt user for a key and check to see if it exist in our hash

print "Please enter your key: "
user_key =gets.to_i
puts user_key.inspect

# option 1

# if numbers[user_key] != nil
#   puts "your key value is: #{numbers[user_key]}"
# else
#   puts "your key doesn't exist"
# end

# option 2

if numbers.has_key?(user_key)
  puts "your key value is: #{numbers[user_key]}"
else
  puts "your key doesn't exist"
end
puts
# looping through a hash
# while loop isn't the best option
# count = 0
# while count < numbers.length
#   puts ""
# end

# better option for looping
# hash.each (| key, value | block)
# hash.each do | key, value |
# block of code
# end

# numbers.each do | key, value |
#   puts "Key is #{key}/ value = #{value}"
# end
#
# puts
#
# # re-write .each with {} syntax
# numbers.each {| key, value|
#   puts "Key is #{key}/ value = #{value}"
# # }
# # puts
# # numbers.each do | key, value|
# #   if key == 30
# #     puts "key found"
# #   end
# end

puts

# add key / value pair with 0 as key
numbers[0] = "zero"
puts numbers.inspect

# has_key?
print "enter your key: "
user_key = gets.to_i

# check if numbers has has user_key
if numbers.has_key?(user_key)
  puts "key found"      # 10 , 20 , 30 etc (numbers are found)
else
  puts "key not found"  # typed in foo which is in the hash but it wasn't found due to the user_key = gets.to_i (int)
                        # when we added numbers[0] = "zero"     puts.numbers.inspect we can now move foo / zero to found
end
puts
# has_value?
# check if numbers hash has value
print "Enter your value: "
user_value = gets.chomp

if numbers.has_value?(user_value)
  puts "value found"    # "ten"
else
  puts"value not found" # "foo"
end

