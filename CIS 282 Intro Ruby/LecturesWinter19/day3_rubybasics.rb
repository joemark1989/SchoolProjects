#Single line comment#
=begin a lot of lines
  wow
  lines
=end
print "hello world"
print "hi again"
puts "this is my third line with puts"
puts "this is another puts line"
#special escape characters
# \t (tab) \n(new line) \\ (show/char) \" (print the char)
puts "Name:\t\t Joey"
puts "1st line
2nd line
3rd line"
# quotes single line and double
puts 'this is \'text\' in single quotes'
puts "this is \"text\" in double quotes"
puts 'this is "text" in single quotes'
puts "this is 'text' in double quotes"
puts 2+2
puts 2+2*5
puts 2**2
#concatenation
puts "c" + "at"
puts "c" + "9"
puts "c" + 9.to_s

#string interpolation build a string with a var output
age = 7
puts "my age is " + age.to_s
puts "my age is #{age}"
puts 'my age is #{age}'

