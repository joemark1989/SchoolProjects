foods = {
    # key => value
    'tomato' => 'veggie',
    'grapes' => 'fruit',
    'celery' => 'veggie',
    'parsnip' => 'veggie',
    'banana' => 'fruit'
}

# loop through hash.each
foods.each do |key, value|
  # tomato is a veggie
  puts "#{key} is a #{value}"
end

puts
# .each_key method / function
foods.each_key do |key|
  puts "key is #{key}"
  if key == 'tomato'
    puts "#{key} has value #{foods[key]}"
    # make tomato a fruit
    foods[key] = 'fruit'
  end
end

puts
# each value method

foods.each_value do |value|
  puts "#{value} is #{value}"
end
puts
# empty?
puts "is our hash empty? #{foods.empty?}"

puts
# fetch (key [,default message])
puts "using fetch method: #{foods.fetch("grapes")}"
puts "not using fetch: #{foods["grapes"]}"
puts "fetching nonexistent value: #{foods.fetch("apple", "that key doesn't exist")}"

puts
# include?(key) .has_key?(key)
puts "using include? apple: #{foods.include?("apple")}"
puts "using has_key? apple: #{foods.has_key?("apple")}"

puts
# .delete
if foods.has_key?('parsnip')
  puts "just deleted parsnip which was a #{foods.delete('parsnip')}"
end
# to show that we deleted the hash
puts foods

# .delete_if
foods.delete_if do |key, value|
  # if expression is true, delete that key / value pair
  value == 'veggie'
end
puts foods