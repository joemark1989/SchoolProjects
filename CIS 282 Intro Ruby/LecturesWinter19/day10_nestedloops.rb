# nested loops
# write one loop at a time - inner loop first

=begin
 1
 abcde
 2
 abcde
 3
 abcde
 4
 abcde
 5
 abcde
=end

# write the loop that creates abcde
# print/puts while/wile(m)/until/for  string "abcde"
#                                   could be: "a","b","c" or abcde
# new learning: "abcde" each letter is represented by an index # like an array
# first letter "abcde"[0]         # string has lengh: "abcde".length  5

index = 0
our_string = "abcde"
while index < our_string.length   # is the length of the string
  print our_string[index]
  index +=1
end

puts

# write the loop that lists number 1 - 5

count = 1
  while count <= 5
    puts count
    count += 1
  end

# combining our loops to create our final output
puts
puts
# outer loop starts with number output

our_string = "abcde"
count = 1
while count <= 5
  puts count

  index = 0
  while index < our_string.length   # is the length of the string
    print our_string[index]
    index +=1
  end
  puts
  count += 1
end
puts
puts
# write outer number 1 - 5 followed by 1 - 20

# outer loop
outer_count = 1
  while outer_count <= 5
    puts outer_count
# inner loop
    inner_count = 1
    while inner_count <= 10
      print "\t#{inner_count} "
      inner_count += 1
    end
    puts
    outer_count += 1
  end
