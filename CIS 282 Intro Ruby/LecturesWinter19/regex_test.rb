print "Enter your name: "
name = gets.chomp

if name =~ /\A([a-zA-Z]+)\s*([a-zA-z]+)\W/
  first_name = $1
  last_name = $2
  puts "Your first name is #{first_name} and your last name is #{last_name}"
end