# returning values from methods

# create method that calculates square footage

=begin
# Option 1 Explicit return
def calculate_sqft(width, height)
  sqft = width * height
  return sqft
end
=end
=begin
# Option 2 explicit return
def calculate_sqft(width, height)
  return width * height
end
=end
=begin
# Option 3 - no explicit return
def calculate_sqft(width, height)
  sqft = width * height
end
=end
=begin
# Option 4 no explicit return with a twist
def calculate_sqft(width, height)
  width * height
end
=end


print "Please enter the width: "
user_width = gets.to_i

print "Please enter the height: "
user_height = gets.to_i

# call the method and store the value
sqft = calculate_sqft(user_width, user_height)
puts "Square footage is: #{sqft}"
