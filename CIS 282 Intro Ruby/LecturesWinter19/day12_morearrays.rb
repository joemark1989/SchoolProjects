shoe_array = [
    "shoestring",
    "hi-tops",
    "sandals",
    "boots"
]
# add by literal index number
shoe_array[4] = "converse"

# add by dynamic index number
shoe_array[shoe_array.length] = "flip flop"

# add by using the push method
shoe_array.push("uggs")

# add by using the double chevron method
shoe_array << "crocs"

# change the value of an element
shoe_array[0] = "doc martens"
puts shoe_array
puts shoe_array.inspect

# empty
puts

puts "is the shoe_array empty? #{shoe_array.empty?}"
puts "is this [] array empty? #{[].empty?}"


# include
puts

puts "does shoe_array contain boots? #{shoe_array.include?("boots")}"
puts "does shoe_array contain heels? #{shoe_array.include?("heels")}"
puts "does shoe_array contain Boots? #{shoe_array.include?("Boots")}"

# delete
puts
deleted_item = shoe_array.delete("sandals")
puts "I just deleted #{deleted_item}"
shoe_array.delete("sandals")
puts shoe_array
puts shoe_array.inspect

# loop through arrays
puts
index = 0
while index < shoe_array.length
  puts "Element at index #{index} is: #{shoe_array[index]}"
  index += 1
end
puts "end of while loop"

# .each iterator
puts

shoe_array.each do |shoe|
  puts "I own this shoe: #{shoe}"
end

