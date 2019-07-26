def reverse_digit
  numbers = 123456789
  reverse_digit = 0
  while numbers > 0 do
    reverse_digit = reverse_digit * 10
    reverse_digit = reverse_digit + (numbers % 10)
    numbers = numbers / 10
    puts reverse_digit
  end
end

puts reverse_digit
