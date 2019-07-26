# create an array
shoe_array = [
    "shoestring",
    "hi-tops",
    "sandals",
    "boots"
]

puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"

# add a new element to the array
# add by index
shoe_array[4] = "converse"

puts

puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"

# add a new element of the array
# add by index dynamically
shoe_array[shoe_array.length] = "flip flop"
puts
puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"

# add a new element to the array
# add using the push() method
shoe_array.push("uggs")
puts
puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"

# add a new element to the array
# add using the << method
shoe_array << "crocs"
puts
puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"

# change the value of an element
shoe_array[0] = "doc martens"
puts
puts shoe_array
puts shoe_array.inspect
puts "array size: #{shoe_array.length}"


# show all ways to see size of array
puts

puts "array length: #{shoe_array.length}"
puts "array size: #{shoe_array.size}"
puts "array count: #{shoe_array.count}"


