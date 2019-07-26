# string methods: rjust(), ljust(), center()

# cherries:   3.00
# apple:      5.00
# banana      6.00
# fig         0.75
# pomegranate 11.50

# create an array four our fruits
# create an array for our prices

# fruits = [
#     "cherries",
#     "apple",
#     "banana",
#     "fig",
#     "pomegranate"
# ]
fruits = %w(cherries apple banana fig pomegranate)
# puts fruits.inspect
prices = [3, 5, 6, 0.75, 11.50]

# # print out our products and prices
# fruits.each_with_index do |fruit, index|
#   puts "#{fruit}       #{prices[index]}"
# end
#
# puts
#
# # string..ljust(col_width,padstr='')
# # fruit column 15 chars wide
# fruits.each_with_index do |fruit, index|
#   puts "#{fruit.ljust(15)}#{prices[index]}"
# end
#
# puts
# # string..rjust(col_width,padstr='')
# # price column width 5 chars wide
#
# fruits.each_with_index do |fruit, index|
#   price = prices[index].to_s
#   puts "#{fruit.ljust(15)}#{price.rjust(5)}"
# end
# puts
# # improved price output
# # format to 2 decimal places
# fruits.each_with_index do |fruit, index|
#   price = format("%.2f", prices[index])
#   puts "#{fruit.ljust(15)}#{price.rjust(5)}"
# end
#
# # what happens if data is unusually long
# # add a new fruit
# fruits << "purple mangosteen"
# prices << 259
# fruit_col_width = "purple mangosteen".length + 5
# price_col_width = 10
#
# fruits.each_with_index do |fruit, index|
#   price = prices[index].to_s
#   puts "#{fruit.ljust(fruit_col_width)}#{price.rjust(price_col_width)}"
# end
# puts
# # dynamically figure out column width
# # determine the longest fruit
#
# fruits << "aokdgfsnakndagsk naodnfgkofgna kognkogfd nasgokng"
# prices << 234.55

longest_fruit = ""
fruits.each do |fruit|
  if fruit.length > longest_fruit.length
    longest_fruit = fruit
  end
end

fruit_col_width = longest_fruit.length + 5
price_col_width = 10

fruits.each_with_index do |fruit, index|
  price = prices[index].to_s
  puts "#{fruit.ljust(fruit_col_width)}#{price.rjust(price_col_width)}"
end
