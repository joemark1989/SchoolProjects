# Joseph Markley

numbers = [100, 20, 30, 40, 80]
smallest_number = numbers[0]
menu_selection = ""

while menu_selection != "4"
  puts "1 Show All Numbers"
  puts "2 Add a Number"
  puts "3 Show Smallest Number"
  puts "4 Exit Program"
  puts "Press enter to continue"
  menu_selection = gets.chomp
  if menu_selection == "1"
    numbers.each do |number_list|
      puts "#{number_list}"
    end
    puts "Press enter to continue"
  elsif menu_selection == "2"
    puts "Enter a new number: "
    numbers[numbers.length] = gets.to_i
  elsif menu_selection == "3"
    numbers.each do |next_smallest|
      if next_smallest < smallest_number
        smallest_number = next_smallest
        puts "Smallest number is: #{smallest_number}"
      end
    end
  end
end

