print "Range      # Found       Chart                                 "
puts
print "--------   -----------   ----------------------------------    "
puts
def find_range(arr, low, high)
  arr.find_all {|item| item >= low && item <= high}.length
end

def rows(arr, low, high)
  leading_zero = low == 1 ? '1' : low

  if high < 100
    print "#{leading_zero} - #{high}:" + ' ' * 2
  else
    print "#{leading_zero} -  #{high}: " * 1
  end
  puts '*' * find_range(arr, low, high)
end

random = []
200.times do
  random << (rand(100) + 1)
end

counter = 0
10.times do
  rows(random, 01 + counter, 10 + counter)
  counter += 10
end


# codecademy example
# puts "Text please: "
# text = gets.chomp
#
# words = text.split(" ")
# frequencies = Hash.new(0)
# words.each { |word| frequencies[word] += 1 }
# frequencies = frequencies.sort_by {|a, b| b }
# frequencies.reverse!
# frequencies.each { |word, frequency| puts word + " " + frequency.to_s }